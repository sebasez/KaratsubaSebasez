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

namespace KaratsubaMultiplicatorSebasez
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LogicLayer.Karatsuba karatsuba;
        public MainWindow()
        {
            InitializeComponent();
            tbx_muldo.Focus();
        }

        private void tbx_muldo_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }

        private static void soloNumeros(KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbx_muldor_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }

        private void btn_operar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                karatsuba = new LogicLayer.Karatsuba();
                Int64 multiplicando = Int64.Parse(tbx_muldo.Text.ToString().Trim());
                Int64 multiplicador = Int64.Parse(tbx_muldor.Text.ToString().Trim());
                lbl_respuesta.Content = "Respuesta: " + karatsuba.calcular(multiplicando,multiplicador).ToString();
            }
            catch (FormatException Ex)
            {
                MessageBox.Show(Ex.Message,this.Title +" - Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
