using Microsoft.Data.SqlClient;
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
using System.Configuration;
using System.Data;
using EtiquetasWithWPF.Pages;

namespace EtiquetasWithWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
        private SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            //navigationFrame.NavigationService
        }

        public SqlConnection Connection { get => connection; set => connection = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Connection = new SqlConnection(connectionString: "Persist Security Info=False;Initial Catalog=SolmicroERP6_PruebasSub;Data Source=SERVIDOR\\SOLMICRO6;User ID=sa; pwd=Altai2021;Encrypt=True;TrustServerCertificate=True;");
                Connection.Open();
                string query = "Select * from tbMaestroCorreos";
                SqlDataAdapter dataAdapter = new(query,Connection);
                DataTable dataTable = new();
                dataAdapter.Fill(dataTable);
                //dataGrid.ItemsSource = dataTable.DefaultView;
               // Autocompletar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }

        //Navegacion
        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            //navigationFrame.Navigate(new InicioPage());
        }
        private void Producto_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Contacto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
