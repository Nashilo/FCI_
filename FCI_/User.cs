namespace FCI_
{
    public partial class User : Form
    {
        public static User UserInstance;
       
        public User()
        {
            InitializeComponent();
            UserInstance = this;
            
        }

        private void ShowStudentForm_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffLogin staffLogin = new StaffLogin();
            staffLogin.Show();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }
    }
}