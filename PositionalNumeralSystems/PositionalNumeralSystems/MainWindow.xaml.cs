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
using static Utils.Functions;   //за директен достъп до функциите на статичния клас Functions

namespace PositionalNumeralSystems
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

        private void FromDecButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HexBox.Text = FromDec(int.Parse(DecBox.Text), 16);
                //HexBox.Text = Convert.ToString(int.Parse(DecBox.Text), 16);
                BinBox.Text = FromDec(int.Parse(DecBox.Text), 2);
                CustomBox.Text = FromDec(int.Parse(DecBox.Text), int.Parse(BaseBox.Text));
            }
            catch(FormatException)
            {
                MessageBox.Show("Некоректен формат на данните");
                HexBox.Text = "0";
                BinBox.Text = "0";
                DecBox.Text = "0";
                CustomBox.Text = "0";
            }
        }

        private void FromBinButton_Click(object sender, RoutedEventArgs e)
        {
            DecBox.Text = ToDec(BinBox.Text,2).ToString();
            HexBox.Text = FromDec(int.Parse(DecBox.Text), 16);
            CustomBox.Text = FromDec(int.Parse(DecBox.Text), int.Parse(BaseBox.Text));
        }

        private void FromHexButton_Click(object sender, RoutedEventArgs e)
        {
            DecBox.Text = ToDec(HexBox.Text, 16).ToString();
            BinBox.Text = FromDec(int.Parse(DecBox.Text), 2);
            CustomBox.Text = FromDec(int.Parse(DecBox.Text), int.Parse(BaseBox.Text));
        }

        private void FromCustomBaseButton_Click(object sender, RoutedEventArgs e)
        {
            DecBox.Text = ToDec(CustomBox.Text, int.Parse(BaseBox.Text)).ToString();
            BinBox.Text = FromDec(int.Parse(DecBox.Text), 2);
            HexBox.Text = FromDec(int.Parse(DecBox.Text), 16);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
