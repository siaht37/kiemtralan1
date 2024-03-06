namespace kiemtralan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtpassword.Text == "admin" &&  txtUserName.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!");
            }else {
                MessageBox.Show("Đăng nhập thất bại!");

            }
        }
    }
}