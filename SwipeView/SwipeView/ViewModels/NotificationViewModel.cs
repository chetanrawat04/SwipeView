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
    class NotificationViewModel : INotifyPropertyChanged
    {
        ObservableCollection<NotificationModel> _Items;
        public ObservableCollection<NotificationModel> Items
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

        public NotificationViewModel()
        {
            Items = new ObservableCollection<NotificationModel>();
            AddItems();
        }
        void AddItems()
        {
            _Items.Add(new NotificationModel { Title = "Info", Message = "This is only information message please ignor this one." });
            _Items.Add(new NotificationModel { Title = "Alert", Message = "This is only Alert message please ignor this one." });
            _Items.Add(new NotificationModel { Title = "Suggesstion", Message = "This is only Suggesstion message please ignor this one." });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}