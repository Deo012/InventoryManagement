using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ManageCustomers : Form
    {
        SqlConnection databaseConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Odjoijmani Deo\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");

        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnect.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTable values('"+CustomerIdBox.Texts+ "', '"+CustomerNameBox.Texts+ "', '"+CustomerPhoneBox.Texts+"')", databaseConnect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully added");
                databaseConnect.Close();
                populate();
            }
            catch 
            {
                throw;
            }
        }
        public void populate()
        {
            try
            {
                databaseConnect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from CustomerTable", databaseConnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "CustomerTable");
                CustomersGV.DataSource = ds.Tables[0];
                databaseConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Il y a eu une erreur {e}");
            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdBox.Texts = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameBox.Texts = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneBox.Texts = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnect.Open();
                SqlCommand updateCustomerTable = new SqlCommand("Update CustomerTable set CustomerId = '"+CustomerIdBox.Texts+ "', CustomerName = '"+CustomerNameBox.Texts+"' where CustomerPhone = '"+CustomerPhoneBox.Texts+"'", databaseConnect);
                updateCustomerTable.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                databaseConnect.Close();
                populate();
            }
            catch 
            {
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnect.Open();
                SqlCommand deleteCustomerTable = new SqlCommand("delete from CustomerTable where CustomerPhone = '" + CustomerPhoneBox.Texts + "'", databaseConnect);
                deleteCustomerTable.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                databaseConnect.Close();
                populate();
            }
            catch
            {
                throw;
            }
        }
    }
}
