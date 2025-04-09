using JSHelper;
using js=JSHelper;
using Microsoft.Data.SqlClient;

namespace JSShop
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        List<Reg> oreg;
      
        public Register()
        {
            InitializeComponent();
            FileHelper fileHelper = new FileHelper();
            Class1 oc=new Class1();
            
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {

            //Connection
            string sql ="Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SUPER730;Data Source=DESKTOP-10MGO6D\\SQLEXPRESS;Encrypt=False\r\n";
            SqlConnection sqlconn = new SqlConnection(sql);
            sqlconn.Open();

            //SQL Command
            string query = $"INSERT INTO Reg1 VALUES('{txtname.Text}','{txtuserId.Text}',{txtage.Text},'{txtemail.Text}',{txtphone.Text},'{pbpwd.Password}')";
            SqlCommand ocmd = new SqlCommand(query, sqlconn);
            
           
            //Execute Non-query
            ocmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("The query is executed successfully");


            // FileValidation.age = 20;
            // FileValidation.a = 30;
            // int value = FileValidation.GetData();
            // string i = "10";
            // int k = i.ToInt();
            // DerivedEmployee demp = new();
            // demp.Name = "Pavithra";

            // LoginSync sync = new LoginSync();
            // (int, string, string) val = sync.AddUser();
            // int v = val.Item1;
            // string v1= val.Item2;
            // string v2= val.Item3;

            // ValidationShop oshop = new ValidationShop();
            // ValidationShop.countstatic = 50;
            // int count= ValidationShop.countstatic;
            // MessageBox.Show(count.ToString());

            // ValidationShop oshop2 = new ValidationShop();
            // ValidationShop.countstatic = 100;
            // int count2 = ValidationShop.countstatic;
            // MessageBox.Show(count2.ToString());

            // ValidationShop oshop3 = new ValidationShop();
            // ValidationShop.countstatic = 200;
            // int count3 = ValidationShop.countstatic;
            // MessageBox.Show(count3.ToString());

            // ValidationShop oshop4 = new ValidationShop();
            // ValidationShop.countstatic = 300;
            // int count4 = ValidationShop.countstatic;
            // MessageBox.Show(count4.ToString());

            // this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            //Assign the data to the Model
            //JSON convert to string
            //File Write
            ValidationShop ovalid = new ValidationShop();

            if (ovalid.RequiredField(txtname.Text) && ovalid.RequiredField(txtemail.Text) && ovalid.RequiredField(txtphone.Text) == true)
            {
                int age1 = Convert.ToInt32((txtage.Text));
                if (ovalid.AgeRequirement(age1) == true)
                {
                    //string[] charemail = { "@", ".com", "@gmail" };
                    if (ovalid.EmailValidation(txtemail.Text, "@", ".com", "@gmail") == true)
                    {
                        if (ovalid.PhoneValidation(txtphone.Text, "1", "2", "3", "4", "5", "6", "7", "8", "9", "0")==true)
                        {


                            if (ovalid.ComparePassword(pbpwd.Password, pbCpwd.Password) == true)
                            {
                                if (oreg == null)
                                {
                                    oreg = new List<Reg>();
                                }


                                Random random = new Random();
                                int number = random.Next();
                                oreg.Add(new Reg { UserName = txtname.Text, UID = number, age = age1, email = txtemail.Text, Password = pbpwd.Password, CPassword = pbCpwd.Password });
                                MessageBox.Show("The registration is successful");
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Phone no. must be 10 digits");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email ID");
                    }
                }
                else
                {
                    MessageBox.Show("Invaid age");
                }
            }
            else
            {
                MessageBox.Show("Enter all the fields");
            }

                
        }


            
        




    }
}
    

