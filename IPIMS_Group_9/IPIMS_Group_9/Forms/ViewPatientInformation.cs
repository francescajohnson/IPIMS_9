using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPIMS_Group_9.Forms
{
    public partial class ViewPatientInformation : Form
    {
        public ViewPatientInformation()
        {
            InitializeComponent();
        }

        private void user_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.group9_ipimsDataSet1);

        }

        private void ViewPatientInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group9_ipimsDataSet1.user_data' table. You can move, or remove it, as needed.
            this.user_dataTableAdapter.Fill(this.group9_ipimsDataSet1.user_data);

        }
    }
}
