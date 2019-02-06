using KsiążkaKontaktowa.Services;
using KsiążkaKontaktowa.Utilty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KsiążkaKontaktowa.ViewModels
{
    public class BookViewModel: ObservableObject
    {
        private IContactDataService _service;
        private ContactViewModel _contactViewModel;
        public ContactViewModel ContactsVM
        {
            get { return _contactViewModel; }
            set { OnPropertyChanged(ref _contactViewModel, value); }
        }
        public ICommand LoadContactsCommand { get; private set; }
        public ICommand LoadFavoritesCommand { get; private set; }

        public BookViewModel(IContactDataService service)
        {
            ContactsVM = new ContactViewModel();

            _service = service;

            LoadContactsCommand = new RelayCommand(LoadContacts);
            LoadFavoritesCommand = new RelayCommand(LoadFavorites);
        }        

        private void LoadContacts()
        {
            ContactsVM.LoadContact(_service.GetContacts());
        }

        private void LoadFavorites()
        {
            var favorites = _service.GetContacts().Where(c => c.IsFavorite);
            ContactsVM.LoadContact(favorites);
        }
    }
}
