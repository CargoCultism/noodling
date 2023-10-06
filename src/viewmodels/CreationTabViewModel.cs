using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace noodling.viewmodels
{
    public class CreationTabViewModel : INotifyPropertyChanged
    {
        private byte numberOfContinents;
        public byte NumberOfContinents
        {
            get { return numberOfContinents; }
            set
            {
                this.numberOfContinents = value;
                NotifyPropertyChanged();
            }
        }

        private byte numberOfCountries;
        public byte NumberOfCountries
        {
            get { return numberOfCountries; }
            set
            {
                this.numberOfCountries = value;
                NotifyPropertyChanged();
            }
        }

        private byte numberOfCities;
        public byte NumberOfCities
        {
            get { return numberOfCities; }
            set
            {
                this.numberOfCities = value;
                NotifyPropertyChanged();
            }
        }
        public CreationTabViewModel()
        {
            numberOfContinents = 3;
            numberOfCountries = 3;
            numberOfCities = 5;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
