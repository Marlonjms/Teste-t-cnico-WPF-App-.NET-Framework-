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
using System.Windows.Shapes;
using Teste_Técnico.View;


namespace Teste_Técnico
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            MainContent.Content = new DashboardUserControl();
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new DashboardUserControl();
        }

        private void Pedidos_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new PedidosUserControl();
        }

        private void Pessoas_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new PessoasUserControl();
        }

        private void Produtos_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ProdutosUserControl();
        }

    }
}
