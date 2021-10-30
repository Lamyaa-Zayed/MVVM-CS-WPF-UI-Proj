using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfOnlineEx
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;
        public Person Person
        {
            get { return _person; }
            set { _person = value; NotifyPropertyChanged("Person");  }
        }

        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; NotifyPropertyChanged("Persons");  }
        }

        private ICommand submitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if(submitCommand == null)
                {
                    submitCommand = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }
                return submitCommand;
            }
            //set
            //{
            //    MessageBox.Show("Please Enter both names to submit");
            //}
        }

        public PersonViewModel()
        {
            Person = new Person();
            Persons = new ObservableCollection<Person>();
        }

        private void SubmitExecute(object parameter)
        {
            Persons.Add(Person);
        }


        private bool CanSubmitExecute(object parameter)
        {
            if (string.IsNullOrEmpty(Person.Fname) || string.IsNullOrEmpty(Person.Lname))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
