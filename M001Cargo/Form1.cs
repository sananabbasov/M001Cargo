using DataAccess;

namespace M001Cargo
{
    public partial class Form1 : Form
    {
        CargoDbContext db = new CargoDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = db.Users.FirstOrDefault(x => x.Email == txtEmail.Text);

            if (user == null)
            {
                MessageBox.Show("Bele bir istifadeci tapilmadi");
            }
            else
            {
                if (user.Password == txtPassword.Text && user.Email == txtEmail.Text)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Email ve ya sifre sehfdi");
                }
            }
        }
    }
}