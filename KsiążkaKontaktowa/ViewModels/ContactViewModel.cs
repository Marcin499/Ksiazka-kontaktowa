using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KsiążkaKontaktowa.Models;
using KsiążkaKontaktowa.Utilty;

namespace KsiążkaKontaktowa.ViewModels
{
   public class ContactViewModel: ObservableObject
    {
        private Contact _selectedContact;
        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set { OnPropertyChanged(ref _selectedContact, value); }
        }

        public ObservableCollection<Contact> Contacts { get; private set; }

        public ContactViewModel()
        {

        }

        public void LoadContacts(IEnumerable<Contact> contacts)
        {
            contacts = new ObservableCollection<Contact>(contacts);
            OnPropertyChanged("Contacts");
        }
    }
}
