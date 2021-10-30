using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOnlineEx
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {

        private string fname;
        public string Fname
        {
            get { return fname; }
            set { fname = value; }// OnPropertyChanged(Fname);  }
        }


        private string lname;
        public string Lname
        {
            get { return lname; }
            set { lname = value; }// OnPropertyChanged(Lname);  }
        }

        private string fullName;
        public string FullName
        {
            get
            {
                return fullName = Fname + " " + Lname;
            }
            set
            {
                if (FullName != value)
                {
                    fullName = value;
                    OnPropertyChanged(FullName);
                }
            }
        }

        public DateTime DateAdded { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string parameter)
        {
            PropertyChangedEventHandler PC = PropertyChanged;
            if (PC != null)
            {
                PC(this, new PropertyChangedEventArgs(parameter));
            }
        }

        // INotifyErrorInfo
        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string propertyName]
        {
            get
            {
                string result = string.Empty;
                switch (propertyName)
                {
                    case "Fname":
                        if (string.IsNullOrEmpty(Fname))
                            result = "First Name is required!";
                        break;

                    case "Lname":
                        if (string.IsNullOrEmpty(Lname))
                            result = "Last Name is required!";
                        break;
                }
                return result;
            }
        }

    }
}
