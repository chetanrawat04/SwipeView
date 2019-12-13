using SwipeView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace SwipeView.ViewModels
{
    class SwipeviewViewModel : INotifyPropertyChanged
    {
        ObservableCollection<SwipeviewModel> _Items;
        public ObservableCollection<SwipeviewModel> Items
        {
            get
            {
                return _Items;
            }
            set
            {
                _Items = value;
                OnPropertyChanged();
            }
        }

        public SwipeviewViewModel()
        {
            Items = new ObservableCollection<SwipeviewModel>();
            AddItems();
        }
        void AddItems()
        {
            _Items.Add(new SwipeviewModel { Title = "Bullbasaur",Icons= "bullbasaur.png" }); 
            _Items.Add(new SwipeviewModel { Title = "Pikachu" ,Icons= "pikachu.png" });
            _Items.Add(new SwipeviewModel { Title = "Jigglypuff" , Icons= "jigglypuff.png" });
            _Items.Add(new SwipeviewModel { Title = "Snorlax", Icons = "snorlax.png" });
            _Items.Add(new SwipeviewModel { Title = "Dratini", Icons = "dratini.png" });
            _Items.Add(new SwipeviewModel { Title = "Eevee",  Icons = "eevee.png" });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}