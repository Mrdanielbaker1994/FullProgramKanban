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
    public partial class AddRule : Form
    {
        public AddRule()
        {
            InitializeComponent();
        }

        private void AddRule_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            DataAccessLayerConfigFile con = new DataAccessLayerConfigFile();

            try
            {
                con.AddRowToTable(txtSettingName.Text, txtSettingValue.Text, cbIsOn.Checked);
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
                       
        }
    }
}
