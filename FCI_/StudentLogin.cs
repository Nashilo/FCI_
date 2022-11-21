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


namespace FCI_
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HILYASHATIKA\SQLEXPRESS;Initial Catalog=FCI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void button1_Click(object sender, EventArgs e)
        {
            StudentNumbertxtBox.Clear();
            PasswordtxtBox.Clear();

            StudentNumbertxtBox.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String StudentNumber, password;

            StudentNumber = StudentNumbertxtBox.Text;
            password = PasswordtxtBox.Text;

            try
            {
                String querry = "SELECT * FROM Student Login WHERE Student Number = "+StudentNumbertxtBox.Text+" AND password = '"+PasswordtxtBox.Text+"";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    StudentNumber = StudentNumbertxtBox.Text;
                    password = PasswordtxtBox.Text;

                    //Page that needs to load next
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    StudentNumbertxtBox.Clear();
                    PasswordtxtBox.Clear();

                    //to focus StudentNumber
                    StudentNumbertxtBox.Focus();


                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
