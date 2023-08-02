using EtiquetasWithWPF.Core;
using System;

namespace EtiquetasWithWPF.MVC.ViewModel
{
    internal class MainViewModel:ObservableObject
    {
        public EtiquetaModel EtiquetaVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChange();
            }
        }

        public MainViewModel() 
        { 
        
        }
    }
}
