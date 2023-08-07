using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<frmMntoExpedicione> selectedItems = new ObservableCollection<frmMntoExpedicione>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Refresh()
        {
            //System.Windows.Data.CollectionViewSource frmMntoExpedicioneViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frmMntoExpedicioneViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // frmMntoExpedicioneViewSource.Source = [generic data source]
            try
            {
            using (SolmicroERP6_PruebasSubEntities context = new SolmicroERP6_PruebasSubEntities())
            {
                List<frmMntoExpedicione> expediciones = context.frmMntoExpediciones.Where(item=>
                item.Pendiente > 0 && item.Estado != 3 && item.Estado != 2 && (item.Confirmado?1:0) == 1 ).ToList();
                frmMntoExpedicioneDataGrid.ItemsSource = expediciones;
            }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource frmMntoExpedicioneViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frmMntoExpedicioneViewSource1")));
            // Load data by setting the CollectionViewSource.Source property:
            // frmMntoExpedicioneViewSource1.Source = [generic data source]
            System.Windows.Data.CollectionViewSource frmMntoExpedicioneViewSource2 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frmMntoExpedicioneViewSource2")));
            // Load data by setting the CollectionViewSource.Source property:
            // frmMntoExpedicioneViewSource2.Source = [generic data source]
            System.Windows.Data.CollectionViewSource frmMntoExpedicioneViewSource3 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frmMntoExpedicioneViewSource3")));
            // Load data by setting the CollectionViewSource.Source property:
            // frmMntoExpedicioneViewSource3.Source = [generic data source]
            System.Windows.Data.CollectionViewSource frmMntoExpedicioneViewSource4 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frmMntoExpedicioneViewSource4")));
            // Load data by setting the CollectionViewSource.Source property:
            // frmMntoExpedicioneViewSource4.Source = [generic data source]
            System.Windows.Data.CollectionViewSource frmMntoExpedicioneViewSource5 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frmMntoExpedicioneViewSource5")));
            // Load data by setting the CollectionViewSource.Source property:
            // frmMntoExpedicioneViewSource5.Source = [generic data source]
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && frmMntoExpedicioneDataGrid.SelectedItem is frmMntoExpedicione item)
            {               
                selectedItems.Add(item);
                item.Cantidad = 100;
            }
           
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
