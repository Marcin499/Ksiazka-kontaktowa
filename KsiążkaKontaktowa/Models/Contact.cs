using KsiążkaKontaktowa.Utilty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaKontaktowa.Models
{
    public class Contact : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { OnPropertyChanged(ref _name, value); }
        }

        private string[] _phonenumber;
        public string[] PhoneNumber
        {
            get { return _phonenumber; }
            set { OnPropertyChanged(ref _phonenumber, value); }
        }

        private string[] _email;
        public string[] Email
        {
            get { return _email; }
            set { OnPropertyChanged(ref _email, value); }
        }

        private string[] _location;
        public string[] Location
        {
            get { return _location; }
            set { OnPropertyChanged(ref _location, value); }
        }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get { return _isFavorite; }
            set { OnPropertyChanged(ref _isFavorite, value); }
        }

        private string[] _image;
        public string[] Image
        {
            get { return _image; }
            set { OnPropertyChanged(ref _image, value); }
        }
    }
}
