using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lab7_chnage_norification_and_data_validation
{
    public class Name : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler
        PropertyChanged;
        public Name(string fName, string lName)
        {
            mFirstName = fName;
            mLastName = lName;
        }
        string mFirstName;
        string mLastName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
                PropertyChanged(this,
                new System.ComponentModel.PropertyChangedEventArgs("FirstName"));
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
                PropertyChanged(this,
                new System.ComponentModel.PropertyChangedEventArgs("LastName"));
            }
        }
    }

    public class Names :
System.Collections.ObjectModel.ObservableCollection<Name>
    {
        public Names()
        {
            Name aName = new Name("FirstName " + (this.Count + 1).ToString(),
            "LastName " + (this.Count + 1).ToString());
            this.Add(aName);
        }
    }
}
