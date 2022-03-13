using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinsFormsApp
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cMSDATABASEDataSet.tblWorker”中。您可以根据需要移动或移除它。
            this.tblWorkerTableAdapter.Fill(this.cMSDATABASEDataSet1.tblWorker);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cMSDATABASEDataSet1.tblWorker.Clear();
            sqlDataAdapter1.Fill(this.cMSDATABASEDataSet1.tblWorker);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.cMSDATABASEDataSet1.tblWorker);
            MessageBox.Show("The Worker Table is Updated.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cMSDATABASEDataSet1.tblWorker.Clear();
            sqlDataAdapter1.Fill(this.cMSDATABASEDataSet1.tblWorker);
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void sqlDataAdapter1_RowUpdated_1(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }
    }
}
