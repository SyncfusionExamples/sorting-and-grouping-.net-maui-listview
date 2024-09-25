﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class ContactsViewModel : INotifyPropertyChanged
    {

        #region Properties
        private ObservableCollection<Contacts> items;
        public ObservableCollection<Contacts> Items
        {
            get 
            { 
                return items; 
            }
            set
            {
                items = value;
                OnPropertyChanged("Items");
            }
        }
        #endregion

        #region Constructor
        public ContactsViewModel()
        {
            items = new ObservableCollection<Contacts>();
            var date = DateTimeOffset.Now;
            Random r = new Random();
            for (int i = 0; i < ContactNames.Count() - 1; i++)
            {
                var contact = new Contacts(ContactNames[i], date.AddDays(r.Next(-30, 30)).AddMonths(r.Next(0, 12)).AddYears(r.Next(-5, 0)));
                Items.Add(contact);
            }
        }

        #endregion

        #region Fields

        string[] ContactNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson",
            "Mason",
            "Liam",
            "Jacob",
            "Jayden",
            "Ethan",
            "Noah",
            "Lucas",
            "Logan",
            "Caleb",
            "Caden",
            "Jack",
            "Ryan",
            "Connor",
            "Michael",
            "Elijah",
            "Brayden",
            "Benjamin",
            "Nicholas",
            "Alexander",
            "William",
            "Matthew",
            "James",
            "Landon",
            "Nathan",
            "Dylan",
            "Evan",
            "Luke",
            "Andrew",
            "Gabriel",
            "Gavin",
            "Joshua",
            "Parker"
        };

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
