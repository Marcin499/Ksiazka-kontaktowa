using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaKontaktowa.Utilty
{
   public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChnaged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool OnPropertyChanged<T>(ref T backingfield, T value, [CallerMemberName] string propertyname= "")
        {
            if(EqualityComparer<T>.Default.Equals(backingfield, value))
            {
                return false;
            }
            backingfield = value;
            OnPropertyChanged(ref backingfield, value,propertyname);
            return true;
        }
    }
}
