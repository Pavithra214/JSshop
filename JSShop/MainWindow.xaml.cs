using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace JSShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            //Object creation for class
            Common ocommon = new Common();

            //Assiging values to the object
            ocommon.AgeCalc("1995", 15, 04);

            //We can interchange the parameters by refering the datatype
            ocommon.AgeCalc(day:15,month:04,year:"1995");



            int rsult = ocommon.AgeCalc(txtfirst.Text);
            txtrslt.Text = rsult.ToString();

            //Adding 2 numbers
            int value1=ocommon.AddNumber(1, 2);
            StringBuilder sb = new StringBuilder();
            sb.Append("Total Value is: ");
            sb.Append(value1);
            MessageBox.Show(sb.ToString());
            StringBuilder sb1 = new StringBuilder();

            //Adding 3 numbers
            int value2 =ocommon.AddNumber(1, 2, 3);
            sb1.Append("Total Value is: ");
            sb1.Append(value2);
            MessageBox.Show(sb1.ToString());

            //Adding 4 numbers
            int value3 =ocommon.AddNumber(1, 2, 3, 4);
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("Total Value is: ");
            sb2.Append(value3);
            MessageBox.Show(sb2.ToString());


        



            //int value1 = ocommon.AgeCalc("1995");
            //MessageBox.Show(value1.ToString());
            //int value2=ocommon.AgeCalc("1995", 21);
            //MessageBox.Show(value2.ToString());
            //int value3=ocommon.AgeCalc("1995", 21, 04);
            //MessageBox.Show(value3.ToString());
            //int value4=ocommon.AgeCalc("1995", "Friday", 04);
            //MessageBox.Show(value4.ToString());



            //int first = ocommon.Convrtint(txtfirst.Text);

            //int second = ocommon.Convrtint(txtscnd.Text);
            //if (String.IsNullOrWhiteSpace(txtfirst.Text) == false)
            //{
            //    first=Convert.ToInt32(txtfirst.Text);
            //}
            //if (String.IsNullOrWhiteSpace(txtscnd.Text) == false)
            //{
            //    second = Convert.ToInt32(txtscnd.Text);
            //}
            //    int result=first+second;
            //    txtrslt.Text = result.ToString();
            //}


          //Creating method inside the cs file. It can be accessed by only this file.
            //public int ConvrtInt(string str)
            //{
            //    int value = 0;
            //    if (String.IsNullOrWhiteSpace(str) == false)
            //    {
            //        value = Convert.ToInt32(str);
            //    }
            //    return value;
            //}
        }
    }
}