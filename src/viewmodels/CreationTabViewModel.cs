using noodling.src.data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public RelayCommand<IGeographicalEntity> SelectedEntityChangedCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }

        private IGeographicalEntity selectedEntity;

        public IGeographicalEntity SelectedEntity
    {
            get { return selectedEntity; }
            set
            {
                this.selectedEntity = value;
                NotifyPropertyChanged();
            }
        }

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

        private ObservableCollection<Continent> world;

        public ObservableCollection<Continent> World
        {
            get { return world; }
            set
            {
                this.world = value;
                NotifyPropertyChanged();
            }
        }

        private Continent europe;

        public Continent Europe
        {
            get { return europe; }
            set
            {
                this.europe = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Country> Countries2 { get; set; }

        private Country germany;

        public Country Germany
        {
            get { return germany; }
            set
            {
                this.germany = value;
                NotifyPropertyChanged();
            }
        }

        public CreationTabViewModel()
        { 
            numberOfContinents = 3;
            numberOfCountries = 3;
            numberOfCities = 5;

            var cities = new List<City>
            {
                new City { Name = "London" },
                new City { Name = "Manchester"},
                new City { Name = "Glasgow"}
            };
            Country England = new Country(cities) { Name = "England" };
            var cities2 = new List<City>
            {
                new City { Name = "Paris" },
                new City { Name = "Lyon"},
                new City { Name = "Toulouse"}
            };
            Country France = new Country(cities2) { Name = "France" };
            var cities3 = new List<City>
            {
                new City { Name = "Berlin" },
                new City { Name = "München"},
                new City { Name = "Düsseldorf"}
            };
            Germany = new Country(cities3) { Name = "Germany" };
            var someEuropeanCountries = new List<Country>{ England, France, Germany};
            Europe = new Continent(someEuropeanCountries) { Name = "Europe" };
            World = new ObservableCollection<Continent> { Europe };
            Countries2 = new ObservableCollection<Country>(someEuropeanCountries);

            SelectedEntityChangedCommand = new RelayCommand<IGeographicalEntity>(c => changeSelection(c));
            SaveCommand = new RelayCommand(() => save());
        }

        private void save()
        {
            ;
        }

        private void changeSelection(object c)
        {
            this.SelectedEntity = c as IGeographicalEntity;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
