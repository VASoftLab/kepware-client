using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kepware.ClientAce.OpcDaClient;

namespace KClient
{
    public partial class FormMain : Form
    {
        // Global variables
        private string URL;
        private int KeepAliveTime;
        private bool RetryAfterConnectionError;
        private bool RetryInitialConnection;
        private string ClientName = "OPCClient";

        public DaServerMgt DAServer = new DaServerMgt();
        private ConnectInfo connectInfo = new ConnectInfo();
        private Boolean isOPCConnectionFailed = false;

        private ItemIdentifier[] itemIdentifiers;

        private int clientHandle = 1;
        private int clientSubscription = 1;
        private int serverSubscription = 0;

        public int UpdateRate = 1000;

        public bool IsConnected { get { return DAServer.IsConnected; } }

        public Settings settings = new Settings();

        public FormMain()
        {
            InitializeComponent();

            settings.Load();

            KeepAliveTime = 1000;
            RetryAfterConnectionError = true;
            RetryInitialConnection = false;
            ClientName = "OPCClient";
            URL = settings.OPCServerURL;

            SubscribeToOPCDAServerEvents(DAServer_StateChanged, DAServer_DataChanged);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public bool TestConnection()
        {
            bool result = false;
            if (String.IsNullOrEmpty(URL))
                return false;
            try
            {
                Kepware.ClientAce.OpcDaClient.ConnectInfo connectInfo = new Kepware.ClientAce.OpcDaClient.ConnectInfo();
                Kepware.ClientAce.OpcDaClient.DaServerMgt DAserver = new Kepware.ClientAce.OpcDaClient.DaServerMgt();
                Boolean connectFailed = false;

                connectInfo.LocalId = "en";
                connectInfo.KeepAliveTime = KeepAliveTime;
                connectInfo.RetryAfterConnectionError = RetryAfterConnectionError;
                connectInfo.RetryInitialConnection = RetryInitialConnection;
                connectInfo.ClientName = "OPCClient";

                Int32 clientHandle = 1;

                DAserver.Connect(URL, clientHandle, ref connectInfo, out connectFailed);
                result = !connectFailed;
                DAserver.Disconnect();
                return result;
            }
            catch { return false; }
        }

        private void buttonCheckConnection_Click(object sender, EventArgs e)
        {
            if (TestConnection() == true)
                MessageBox.Show("Successfully connected");
            else
                MessageBox.Show("Successfully failed");
        }
        public void ConnectOPCServer(bool connectToOPC)
        {
            if (connectToOPC)
            {
                connectInfo.LocalId = "en";
                connectInfo.KeepAliveTime = KeepAliveTime;
                connectInfo.RetryAfterConnectionError = RetryAfterConnectionError;
                connectInfo.RetryInitialConnection = RetryInitialConnection;
                connectInfo.ClientName = ClientName;

                try
                {
                    if (DAServer.IsConnected == false)
                        DAServer.Connect(URL, clientHandle, ref connectInfo, out isOPCConnectionFailed);
                    int tagCount = SubscribeData();
                    ModifySubscription(true);
                    MessageBox.Show(String.Format("Succesfully connected to {0} tags", tagCount), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }
            }
            else
            {
                try
                {
                    UnSubscribeData();
                    if (DAServer.IsConnected == true)
                        DAServer.Disconnect();
                }
                catch { }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected == false)
            {
                ConnectOPCServer(true); // Connect to OPC Server
                buttonConnect.Text = "DISCONNECT";
            }
            else
            {
                ConnectOPCServer(false); // Disconnect from OPC Server
                buttonConnect.Text = "CONNECT";                
            }
        }

        private int SubscribeData()
        {
            List<OPCTag> TagList = new List<OPCTag>();
            TagList.Add(new OPCTag()
            {
                Name = settings.TagRamp1,
                Type = OPCTagType.Char
            });
            TagList.Add(new OPCTag()
            {
                Name = settings.TagRandom1,
                Type = OPCTagType.Long
            });
            TagList.Add(new OPCTag()
            {
                Name = settings.TagSin1,
                Type = OPCTagType.Float
            });

            bool active = false;
            int updateRate = UpdateRate;
            Single deadBand = 0;
            int revisedUpdateRate;

            int clientHandleUNQ = 0;
            int index = 0;            

            itemIdentifiers = new ItemIdentifier[TagList.Count];
            
            foreach (OPCTag tag in TagList)
            {
                itemIdentifiers[index] = new ItemIdentifier();
                itemIdentifiers[index].ClientHandle = clientHandleUNQ;
                itemIdentifiers[index].DataType = Type.GetType(tag.Type.ToString());
                itemIdentifiers[index].ItemName = tag.Name;                
                index++;
                clientHandleUNQ++;
            }

            try
            {
                DAServer.Subscribe(clientSubscription, active, updateRate, out revisedUpdateRate, deadBand, ref itemIdentifiers, out serverSubscription);
                int faultCounter = 0;
                for (int itemIndex = 0; itemIndex < TagList.Count; itemIndex++)
                {
                    if (itemIdentifiers[itemIndex].ResultID.Succeeded == false)
                        faultCounter++;
                }
                return TagList.Count - faultCounter;
            }
            catch { return 0; }
        }

        private void UnSubscribeData()
        {
            try
            {
                if ((serverSubscription != 0) && (itemIdentifiers.Count() > 0))
                    DAServer.SubscriptionRemoveItems(serverSubscription, ref itemIdentifiers);
            }
            catch { };
        }

        public void ModifySubscription(bool action)
        {
            DAServer.SubscriptionModify(serverSubscription, action);
        }

        public void SubscribeToOPCDAServerEvents(DaServerMgt.ServerStateChangedEventHandler DAServer_StateChanged, DaServerMgt.DataChangedEventHandler DAServer_DataChanged)
        {
            // DAServer.ReadCompleted += new Kepware.ClientAce.OpcDaClient.DaServerMgt.ReadCompletedEventHandler(DAServer_ReadCompleted);
            // DAServer.WriteCompleted += new Kepware.ClientAce.OpcDaClient.DaServerMgt.ReadCompletedEventHandler(DAServer_WriteCompleted);
            DAServer.ServerStateChanged += new Kepware.ClientAce.OpcDaClient.DaServerMgt.ServerStateChangedEventHandler(DAServer_StateChanged);
            DAServer.DataChanged += new DaServerMgt.DataChangedEventHandler(DAServer_DataChanged);
        }

        public void DAServer_StateChanged(int clientHandle, ServerState state)
        {
            object[] SSCevHndArray = new object[2];
            SSCevHndArray[0] = clientHandle;
            SSCevHndArray[1] = state;
            BeginInvoke(new DaServerMgt.ServerStateChangedEventHandler(ServerStateChanged), SSCevHndArray);
        }
        public void DAServer_DataChanged(int clientSubscription, bool allQualitiesGood, bool noErrors, ItemValueCallback[] ItemValues)
        {
            object[] DCevHndlrArray = new object[4];
            DCevHndlrArray[0] = clientSubscription;
            DCevHndlrArray[1] = allQualitiesGood;
            DCevHndlrArray[2] = noErrors;
            DCevHndlrArray[3] = ItemValues;
            BeginInvoke(new DaServerMgt.DataChangedEventHandler(DataChanged), DCevHndlrArray);
        }
        public void ServerStateChanged(int clientHandle, ServerState state)
        {
            try
            {
                switch (state)
                {
                    case ServerState.ERRORSHUTDOWN:
                        labelServerState.Text = "SERVER STATE: The server is shutting down";
                        break;
                    case ServerState.ERRORWATCHDOG:
                        labelServerState.Text = "SERVER STATE: Server connection has been lost";
                        break;
                    case ServerState.CONNECTED:
                        labelServerState.Text = "SERVER STATE: Server is connected";
                        break;
                    case ServerState.DISCONNECTED:
                        labelServerState.Text = "SERVER STATE: Server is disconnected";
                        break;
                }
            }
            catch { }
        }
        public void DataChanged(int clientSubscription, bool allQualitiesGood, bool noErrors, ItemValueCallback[] ItemValues)
        {
            DateTime itemTimeStamp = DateTime.Now;
            String itemName = String.Empty;

            foreach (ItemValueCallback item in ItemValues)
            {
                switch ((int)item.ClientHandle)
                {
                    case 0:
                        textBoxRamp1.Text = item.Value.ToString();
                        break;
                    case 1:
                        textBoxRandom1.Text = item.Value.ToString();
                        break;
                    case 2:
                        textBoxSin1.Text = item.Value.ToString();
                        break; 
                }
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings frmSettings = new FormSettings();
            if (frmSettings.ShowDialog() == DialogResult.OK)
            {
                settings.Load();
            }
        }
    }
}