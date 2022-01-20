using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace CoursMVVM.Models
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private string gender;
        private bool isM;
        private bool isF;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                //RaisePropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                //RaisePropertyChanged("lastName");
            }
        }
        //public string Gender
        //{
        //    get => gender;
        //    set
        //    {
        //        gender = value;
        //        //RaisePropertyChanged("gender");
        //    }
        //}
        public bool IsM
        {
            get => isM;
            set
            {
                isM = value;
                //RaisePropertyChanged("isM");
            }
        }
        public bool IsF
        {
            get => isF;
            set
            {
                isF = value;
                //RaisePropertyChanged("isF");
            }
        }
        //public event PropertyChangedEventHandler PropertyChanged;

        //public void RaisePropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}

