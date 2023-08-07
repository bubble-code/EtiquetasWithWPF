using System;
using System.Collections.Generic;
using System.Data;
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
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace EtiquetasWithWPF.MVC.View
{
    /// <summary>
    /// Lógica de interacción para Etiquetas.xaml
    /// </summary>
    public partial class Etiquetas : UserControl
    {
        readonly private string connectionString = "Persist Security Info=False;Initial Catalog=SolmicroERP6_PruebasSub;Data Source=SERVIDOR\\SOLMICRO6;User ID=sa; pwd=Altai2021;Encrypt=True;TrustServerCertificate=True;";
        readonly private string queryAutoComplCliente = "SELECT IDCliente, DescCliente FROM  tbMaestroCliente";
        readonly private string queryCarga = "SELECT CAST(0 AS bit) AS 'Check', NPedido,IDCliente,IDArticulo,DescArticulo,convert(DECIMAL(10,2),QPedida) AS 'Cant.Pedida' , convert(DECIMAL(10,2),QServida) AS 'Cant.Servida', convert(DECIMAL(10,2),Pendiente) AS 'Cant.Pendiente', FechaEntrega, DescCliente, convert(DECIMAL(10,2),StockFisico) AS 'StockFisico'   FROM FrmMntoExpediciones where Pendiente > 0 and Estado <>3 and Estado <> 2 and Confirmado = 1";
        private SqlConnection connection;
        private SqlCommand cmd;

        public Etiquetas()
        {
            InitializeComponent();
        }
        private async Task<List<string>> Autocompleted()
        {
            string queryAutoComplCliente = $"SELECT IDCliente, DescCliente FROM  tbMaestroCliente ";
            List<string> listSuggestion = new();
            try
            {
                //await connection.OpenAsync();
                SqlCommand command = new(queryAutoComplCliente, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    listSuggestion.Add(reader.GetString(0) + " " + reader.GetString(1));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listSuggestion;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = await CargarGrid();
            Dispatcher.Invoke(() => mainGrid.ItemsSource = dt.DefaultView);
        }



        private async Task<DataTable> CargarGrid()
        {
            DataTable dt = new();
            try
            {
                cmd = new SqlCommand(queryCarga, connection);
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                dt.Load(reader);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return dt;
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                tb.ItemsSource = await Autocompleted();
                tb.FilterMode = AutoCompleteFilterMode.Contains;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
