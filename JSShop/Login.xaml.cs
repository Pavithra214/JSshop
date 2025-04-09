using System.Windows;
using System.IO;

namespace JSShop
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnNewUser_Click(object sender, RoutedEventArgs e)
        {
            Register register=new Register();
            register.Show();
            this.Close();
            Login login=new Login();
            login.Show();
        }

        private void btnforgot_Click(object sender, RoutedEventArgs e)
        {
ForgotPwd forgotPwd = new ForgotPwd();
            forgotPwd.ShowDialog();

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            int? num=10;
            int num1;
            //num1 = Convert.ToInt32(num);
            num1 = (int)num;
            int? salary=null;
            if(salary is null)
            {
                salary = 10;
            }

            //salary = salary ?? 10;
            salary = 100;
            salary = salary.GetValueOrDefault(10);
            MessageBox.Show(salary.ToString());

            string username="Pavithra";
            string password="Pavithra";
            int val = LoginValidation(in username,in password);
            if(val==1)
            {
                MessageBox.Show(username);
                Home home = new Home();
                home.Show();
                this.Close();
            }
         
        }

        public int LoginValidation(in string username,in string password)
        {
            //username = "Pavithra";
            //password = "Pavithra";
            if(username==password)
            {
                //username = "Welcome Dear" + username;
                return 1;
            }
            return 0;
        }
    }
}
