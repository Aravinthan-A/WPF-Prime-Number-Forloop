using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace PrimeNumber
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //    string Value = "";
            //    for (int i = 10; i > 6; i--)
            //    {
            //        Value = Value + "\n" + i.ToString() + ",";
            //    }
            //    MessageBox.Show(Value);
            //}








            //int[] number = (txtname.Text);
            //int count = number.Length;
            //for (int i = count - 1; i < 0; i--)
            //{
            //    MessageBox.Show(i.ToString());
            //}













            int number = Convert.ToInt32(txtname.Text);


            //string value=number.ToString();
            //String name = value.Split(',');
            //for (int i = 10; i > 6; i--)
            //{
            //    MessageBox.Show(i.ToString());
            //}













            //for (int i = 10; i > 6; i--)
            //{
            //    MessageBox.Show((i).ToString());
            //}
            //Approach 1


            //Approach 2
          
            //for (int i = 10; i >6; i--)
            //{
            //    MessageBox.Show((i).ToString());
            //}
            //string print = "";
            //for (int i = 10; i >6; i--)
            //{
            //    if (print == "")
            //    {
            //        print = i.ToString();
            //    }
            //    else
            //    {
            //        print = print + "\n" + i.ToString();
            //    }
            //}
            //MessageBox.Show(print);

            //int[] Number = { 7, 8, 9, 10 };
            //int count = Number.Length;
            //for (int i = count-1; i >=0; i--)
            //{
            //    MessageBox.Show(Number[i].ToString());
            //}

            //string  Name = txtname.Text;
            //Name.Split(" ");
            //string result = "";

            //if (Name != "")
            //{
            //    char[] name = Name.ToCharArray();
            //    for (int i = Name.Length-1; i >= 0; i--)
            //    {
            //        result += Name[i].ToString();
            //    }
            //}
            //txtend.Text = result;

            //char[] chars = txtname.Text.ToCharArray();
            //string end = "";
            //string rev = "";
            //for (int i=chars.Length-1; i >= 0; i--) 
            //{
            //    rev += chars[i].ToString();
            //}
            //txtend.Text = rev;



            //string Name=txtname.Text;
            //string End ="";

            //char[] name=Name.ToCharArray();
            //for (int i = name.Length-1; i >= 0; i--)
            //{
            //    End += name[i].ToString();
            //}
            //txtend.Text = End;


            //int [] Number = { 10, 20, 30, 40, 50, 60};
            //int count = Number.Length;
            //for (int i = count-1; i>=0 ; i--)
            //{
            //    MessageBox.Show(Number[i].ToString());
            //}
        }
    } }
    

