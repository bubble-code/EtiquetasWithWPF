using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WPFMain.Model;

namespace WPFMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<SeleccionadosModel> selectedItems = new ObservableCollection<SeleccionadosModel>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            selectedItemsList.ItemsSource = selectedItems;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Refresh()
        {
            try
            {
                using (SolmicroERP6_PruebasSubEntities context = new SolmicroERP6_PruebasSubEntities())
                {
                    List<frmMntoExpedicione> expediciones = context.frmMntoExpediciones.Where(item =>
                    item.Pendiente > 0 && item.Estado != 3 && item.Estado != 2 && (item.Confirmado ? 1 : 0) == 1).ToList();
                    frmMntoExpedicioneDataGrid.ItemsSource = expediciones;
                }

            }
            catch (Exception ex)
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
            System.Windows.Data.CollectionViewSource frmMntoExpedicioneViewSource6 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frmMntoExpedicioneViewSource6")));
            // Load data by setting the CollectionViewSource.Source property:
            // frmMntoExpedicioneViewSource6.Source = [generic data source]
            System.Windows.Data.CollectionViewSource seleccionadosModelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("seleccionadosModelViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // seleccionadosModelViewSource.Source = [generic data source]
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.DataContext is frmMntoExpedicione item)
            {
                selectedItems.Add((SeleccionadosModel)item);
                //selectedItemsList.ItemsSource = selectedItems;
                //frmMntoExpedicioneDataGrid.UpdateLayout();
            }

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.DataContext is frmMntoExpedicione item)
            {
                var selection = selectedItems.FirstOrDefault(s => s.IDLineaPedido == item.IDLineaPedido);
                if (selection != null)
                {
                    selectedItems.Remove((SeleccionadosModel)selection);
                }
            }
        }


        private void Image_Mouse(object sender, MouseButtonEventArgs e)
        {
            DatePicker datePicker = FindResource("DatePicker") as DatePicker;
            TextBox fechaTextBox = FindResource("Fecha") as TextBox;

            if (datePicker != null && fechaTextBox != null)
            {
                datePicker.SelectedDate = DateTime.Today; // Puedes establecer la fecha actual por defecto
                datePicker.Visibility = Visibility.Visible;
                datePicker.Focus();
                datePicker.SelectedDateChanged += (s, args) =>
                {
                    fechaTextBox.Text = datePicker.SelectedDate?.ToString("dd/MM/yyyy");
                    datePicker.Visibility = Visibility.Collapsed;
                };
            }
        }

    }
}
