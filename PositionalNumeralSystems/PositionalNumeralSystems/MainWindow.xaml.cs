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

namespace PositionalNumeralSystems
{
    public static class Functions
    {
        public static int Pow(int a, int b)
        {
            int res = 1;
            for (int i = 1; i <= b; i++)
                res *= a;
            return res;
        }
        public static string FromDec(int n, int r)  // От десетична в r-ична
        {
            string sign = n > 0 ? "" : "-";
            string s = "";
            int d;
            n = Math.Abs(n);
            while(n!=0)
            {
                d = n % r;
                if (d > 9)
                    s = (char)(d + 'A' - 10) + s;
                else
                    s = (char)(d + '0') + s;
                n = n / r;
            }
            return sign+s;
        }
        public static int ToDec(string s, int r)    // От r-ична в десетична
        {
            int n = 0;
            int sign = 1;
            if(s[0]=='-')
            {
                sign = -1;
                s = s.Substring(1);
            }
            int l = s.Length;
            s = s.ToUpper();
            for(int i=0; i<l; i++)
            {
                if (s[i] >= 'A')
                    n = n + (s[i] - 'A' + 10) * Pow(r, l - i - 1);
                else
                    n = n + (s[i] - '0') * Pow(r, l - i - 1);
            }
            return sign * n;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FromDecButton_Click(object sender, RoutedEventArgs e)
        {
            HexBox.Text = Functions.FromDec(int.Parse(DecBox.Text), 16);
            BinBox.Text = Functions.FromDec(int.Parse(DecBox.Text), 2);
        }

        private void FromBinButton_Click(object sender, RoutedEventArgs e)
        {
            DecBox.Text = Functions.ToDec(BinBox.Text,2).ToString();
            HexBox.Text = Functions.FromDec(int.Parse(DecBox.Text), 16);
        }

        private void FromHexButton_Click(object sender, RoutedEventArgs e)
        {
            DecBox.Text = Functions.ToDec(HexBox.Text, 16).ToString();
            BinBox.Text = Functions.FromDec(int.Parse(DecBox.Text), 2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
