﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPIMS_Group_9
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void user_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);

        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.user_data' table. You can move, or remove it, as needed.
            this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);

        }
    }
}
