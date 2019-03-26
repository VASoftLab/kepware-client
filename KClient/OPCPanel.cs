using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KClient
{
    public partial class OPCPanel : UserControl
    {
        private String PanelTitle_;
        private String RampTitle_;
        private String SinTitle_;
        private String RandomTitle_;

        private Double RampValue_;
        private Double SinValue_;
        private Double RandomValue_;

        public DataPointCollection SinChartPoints
        {
            get { return chart.Series[0].Points; }
        }

        public DataPointCollection RampChartPoints
        {
            get { return chart.Series[1].Points; }
        }

        public DataPointCollection RandomChartPoints
        {
            get { return chart.Series[2].Points; }
        }


        public String PanelTitle
        {
            get { return PanelTitle_; }
            set
            {
                PanelTitle_ = value;
                groupBoxDevice.Text = PanelTitle_;
            }
        }

        public String RampTitle
        {
            get { return RampTitle_; }
            set
            {
                RampTitle_ = value;
                labelRamp.Text = RampTitle_;
            }
        }

        public String SinTitle
        {
            get { return SinTitle_; }
            set
            {
                SinTitle_ = value;
                labelSin.Text = SinTitle_;
            }
        }

        public String RandomTitle
        {
            get { return RandomTitle_; }
            set
            {
                RandomTitle_ = value;
                labelRandom.Text = RandomTitle_;
            }
        }

        public Double RampValue
        {
            get
            {
                return RampValue_;
            }
            set
            {
                RampValue_ = value;
                textBoxRamp.Text = RampValue_.ToString("0.00");
            }
        }

        public Double SinValue
        {
            get
            {
                return SinValue_;
            }
            set
            {
                SinValue_ = value;
                textBoxSin.Text = SinValue_.ToString("0.00");
            }
        }

        public Double RandomValue
        {
            get
            {
                return RandomValue_;
            }
            set
            {
                RandomValue_ = value;
                textBoxRandom.Text = RandomValue_.ToString("0.00");
            }
        }

        public OPCPanel()
        {
            InitializeComponent();
        }            
    }
}
