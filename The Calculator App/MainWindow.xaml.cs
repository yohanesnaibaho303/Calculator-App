using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace The_Calculator_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;

        public MainWindow()
        {
            InitializeComponent();

            //event handler inside constructor
            //called code-behind for its dinamik control, readability and flexibility

            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
            percentageButton.Click += PercentageButton_Click;
            equalButton.Click += EqualButton_Click;

            
        }

        #region Functions Code-Behind
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        #endregion

        #region Event Handlers for Operation Button

        private void OperationButton_Click(Object sender, RoutedEventArgs e)
        {

        }

        #endregion

        #region Event Handlers for Button Numbers

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            //int selectedValue: Variabel untuk menyimpan angka yang diambil dari tombol.
            //int.Parse: Metode untuk mengonversi string ke integer.
            //sender as Button: Mengonversi objek sender menjadi Button untuk akses properti tombol.
            //Content.ToString(): Mengonversi nilai Content tombol menjadi string agar bisa diproses lebih lanjut.
            int selectedValue = int.Parse((sender as Button).Content.ToString());

            if (resultLabel.Content.ToString() == "0")
            {
                //$ symbol adalah interpolasi
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }

        #endregion

    }
}
