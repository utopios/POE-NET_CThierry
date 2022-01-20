using CoursMVVM.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CoursMVVM.ViewModels
{
    class PersonViewModel : ViewModelBase
    {
        private Person person;

        public string FirstName
        {
            get => person.FirstName;
            set
            {
                person.FirstName = value;
                RaisePropertyChanged();
            }
        }
        public string LastName
        {
            get => person.LastName;
            set
            {
                person.LastName = value;
                RaisePropertyChanged();
            }
        }
        
        public bool IsM
        {
            get => person.IsM;
            set
            {
                person.IsM = value;
                RaisePropertyChanged("Gender");
            }
        }
        public bool IsF
        {
            get => person.IsF;
            set
            {
                person.IsF = value;
                RaisePropertyChanged("Gender");
            }
        }

        public string Gender
        {
            get
            {
                if (IsM)
                    return "Mr";
                else if (IsF)
                    return "Mme";
                else
                    return null;
            }
        }

        public ICommand ValidCommand { get; set; }

        public PersonViewModel()
        {
            person = new Person();
            ValidCommand = new RelayCommand(ActionValidCommand);
        }

        private void ActionValidCommand()
        {
            MessageBox.Show(Gender + " " + LastName + " " + FirstName); 
        }
    }
}
