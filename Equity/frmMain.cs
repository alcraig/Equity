using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equity
{
    public partial class frmMain : Form
    {
        //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\CONTA\SOURCE\REPOS\EQUITY\EQUITY\EQUITY.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EQUITY;UserID=sa;";

        //Tutorial says to put SqlDataAdapter in here but it doesn't seem to be in the toolbox
        //See lesson 52 at 3:30
        System.Data.SqlClient.SqlDataAdapter dataAdapter;
        DataTable table;

        public frmMain()
        {
            InitializeComponent();
        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * FROM Addresses");

        }

        private void GetData(string selectCommand)
        {
            //throw new NotImplementedException();
            try
            {
                dataAdapter = new System.Data.SqlClient.SqlDataAdapter(selectCommand, connString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddress_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetData($"SELECT * FROM Equity.Addresses");
        }
    }
}
