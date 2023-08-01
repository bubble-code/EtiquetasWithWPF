using Microsoft.Data.SqlClient;
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

namespace EtiquetasWithWPF.Pages
{
    /// <summary>
    /// Lógica de interacción para InicioPage.xaml
    /// </summary>
    public partial class InicioPage : Page
    {
        readonly private string conection = "Persist Security Info=False;Initial Catalog=SolmicroERP6_PruebasSub;Data Source=SERVIDOR\\SOLMICRO6;User ID=sa; pwd=Altai2021;Encrypt=True;TrustServerCertificate=True;"; 
        public InicioPage()
        {
            InitializeComponent();
            
        }
        private void Cargar_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
            SqlConnection con = new SqlConnection(conection);
                con.Open();
                string query = "Select * from FrmMntoExpediciones";
                SqlDataAdapter adapter = new (query,con);
                DataTable dt = new ();
                adapter.Fill(dt);
                gridExpediciones.ItemsSource = dt.DefaultView;
            } catch { }
        }
    }
}
