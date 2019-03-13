using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KClient
{
    public partial class FormSettings : Form
    {
        Settings settings = new Settings();

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            settings.Load();
            textBoxOPCURL.Text = settings.OPCServerURL;
            textBoxRamp.Text = settings.TagRamp1;
            textBoxRandom.Text = settings.TagRandom1;
            textBoxSin.Text = settings.TagSin1;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            settings.OPCServerURL = textBoxOPCURL.Text;
            settings.TagRamp1 = textBoxRamp.Text;
            settings.TagRandom1 = textBoxRandom.Text;
            settings.TagSin1 = textBoxSin.Text;
            settings.Save();
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
