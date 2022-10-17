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

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int k = 0;
            for(int i=0;i<3;i++)
            {
                
                for(int j=0;j<3;j++)
                {
                    k++;
                    Button btn1 = new Button();
                    btn1.Margin = new Thickness(5);
                    btn1.FontSize = 20;
                    btn1.Content = k;
                    grid.Children.Add(btn1);
                    Grid.SetColumn(btn1, j);
                    Grid.SetRow(btn1, i);
                }
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            resultado_TextBlock.Text += boton.Content.ToString();
        }
    }
}
