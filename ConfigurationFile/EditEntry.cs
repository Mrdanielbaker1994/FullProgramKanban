using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigurationFile
{
    public partial class EditEntry : Form
    {
        private string settingName = "";
        private string settingValue = "";
        private bool isOn = false;
        int ID = -1;

        public EditEntry(string newName, string newValue, bool newIsOn, int newID)
        {
            InitializeComponent();
            settingName = newName;
            settingValue = newValue;
            isOn = newIsOn;
            ID = newID;
        }

        private void btnEditEntry_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayerConfigFile layer = new DataAccessLayerConfigFile();
                layer.EditRowInTable(txtSettingName.Text, txtSettingValue.Text, cbIsOn.Checked, ID);
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EditEntry_Load(object sender, EventArgs e)
        {
            txtSettingName.Text = settingName;
            txtSettingValue.Text = settingValue;
            cbIsOn.Checked = isOn;

        }
    }
}
