using KsiążkaKontaktowa.ViewModels;
using KsiążkaKontaktowa.Utilty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaKontaktowa.Utilty
{
    public class AppViewModel: ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set {OnPropertyChanged(ref _currentView, value); }
        }

        private BookViewModel _bookViewModel;
        public BookViewModel BookViewM
        {
            get { return _bookViewModel;}
            set { OnPropertyChanged(ref _bookViewModel, value); }
        }

        public AppViewModel()
        {
            BookViewM = new BookViewModel();
            CurrentView = BookViewM;
        }
    }
}
