using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection ConnectionSqlString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Odjoijmani Deo\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populate()
        {
            try
            {
                ConnectionSqlString.Open();
                string myQuery = "Select * from UserTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, ConnectionSqlString);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                ConnectionSqlString.Close();
            }
            catch 
            { 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionSqlString.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTable values('" + UserNameBox.Texts + "', '" + FullNameBox.Texts + "','" + PasswordBox.Texts + "', '" + TelephoneBox.Texts + "')", ConnectionSqlString);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully added");
                ConnectionSqlString.Close();
                populate();
            }
            catch
            {

            }
        }

        private void UserNameBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserNameBox.Texts = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FullNameBox.Texts = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            PasswordBox.Texts = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            TelephoneBox.Texts = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(TelephoneBox.Texts == "")
            {
                MessageBox.Show("Enter the user phone number");
            }
            else
            {
                ConnectionSqlString.Open();
                string myquery = "delete from userTable where UserPhone = '" + TelephoneBox.Texts + "'";
                SqlCommand cmd = new SqlCommand(myquery, ConnectionSqlString);
                cmd.ExecuteNonQuery();
                MessageBox.Show("USer successfully Deleted");
                ConnectionSqlString.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionSqlString.Open();
                SqlCommand cmd = new SqlCommand("Update UserTable set UserName = '"+UserNameBox.Texts+"', UserFullName = '"+FullNameBox.Texts+"', UserPassword = '"+PasswordBox.Texts+ "' where UserPhone = '"+TelephoneBox.Texts+"'", ConnectionSqlString);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                ConnectionSqlString.Close();
                populate();
            }
            catch
            {

            }
        }
    }
}
