using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ConfigurationFile
{
    public partial class Form1 : Form
    {
        private string settingName = "";
        private string settingValue = "";
        private bool isOn = false;
        int ID = -1;
        private DataTable dt = new DataTable();

        public string SettingName { get => settingName; }
        public string SettingValue { get => settingValue;}
        public bool IsOn { get => isOn; }
        public int ID1 { get => ID;}

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            Form adding = new AddRule();
            try
            {
                adding.ShowDialog();
                FillGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditRule_Click(object sender, EventArgs e)
        {
            Form editForm = new EditEntry(settingName, settingValue, isOn, ID);
            Int32 selectedRowCount =
       dgConfigTableView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                try
                {
                    editForm.ShowDialog();
                    FillGridView();
                    settingName = "";
                    settingValue = "";
                    isOn = false;
                    ID = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void FillGridView()
        {
            DataAccessLayerConfigFile dataAccess = new DataAccessLayerConfigFile();
            try
            {
                dt = dataAccess.GetConfigTable();
                dgConfigTableView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dg_selected(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                   dgConfigTableView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                int selectedRowIndex = dgConfigTableView.SelectedRows[0].Index;

                ID = Convert.ToInt32(dt.Rows[selectedRowIndex]["ID"]);
                settingName =  dt.Rows[selectedRowIndex]["Setting Name"].ToString();
                settingValue = dt.Rows[selectedRowIndex]["Setting Value"].ToString();
                isOn = Convert.ToBoolean(dt.Rows[selectedRowIndex][@"Enabled / Disabled"]);

                //MessageBox.Show("Setting Name = " + settingName+ "Setting Value = " + settingValue + "isOn = " + isOn);
            }

        }
    }
}
