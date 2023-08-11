using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace WPFMain
{
    public partial class TextBoxTheme : ResourceDictionary
    {
        public void Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            Image image = sender as Image;
            TextBox fechaTextBox = image.FindName("Fecha") as TextBox;
            Popup popup = image.FindName("popUp1") as Popup;
            Calendar calendar = (Calendar)image.FindName("MyCalendar");

            popup.IsOpen = true;
            calendar.SelectedDate = DateTime.Today;
            if (calendar.SelectedDate.HasValue)
            {
                fechaTextBox.Text = calendar.SelectedDate?.ToString();
            };

        }
        public void Popup_LostFocus(object sender, RoutedEventArgs e)
        {
            Popup popup = sender as Popup;
            popup.IsOpen = false;
            Calendar calendar = (Calendar)popup.FindName("MyCalendar");
            calendar.ReleaseMouseCapture();
        }
        public void Change_Date(object sender, EventArgs e)
        {
            if (sender is Calendar calendar)
            {
                TextBox fechaTextBox = (TextBox)calendar.FindName("Fecha");
                Popup popup = calendar.FindName("popUp1") as Popup;
                if (calendar.SelectedDate.HasValue)
                {
                    fechaTextBox.Text = calendar.SelectedDate?.ToString();
                    //popup.IsOpen = false;
                    calendar.ReleaseMouseCapture();
                }

            }
        }
    }
}
