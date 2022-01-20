using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TpAnnuaireMVVM.Models;

namespace TpAnnuaireMVVM.ViewModels
{
    internal class ContactViewModel : ViewModelBase
    {
        private Contact contact;

        public string FirstName 
        { 
            get => contact.FirstName; 
            set => contact.FirstName = value; 
        }        
        public string LastName 
        { 
            get => contact.LastName; 
            set => contact.LastName = value; 
        }
        public string Phone 
        { 
            get => contact.Phone; 
            set => contact.Phone = value; 
        }
        public string Email 
        { 
            get => contact.Email; 
            set => contact.Email = value; 
        }

        public ICommand ConfirmCommand { get; set; }

        public ObservableCollection<Contact> Contacts { get; set; }

        public Contact Contact
        {
            get => contact;
            set
            {
                contact = value;
                if(contact != null)
                {
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("Phone");
                    RaisePropertyChanged("Email");
                    RaisePropertyChanged("ContentButton");
                }
            }
        }

        public string ContentButton { get => Contact.Id > 0 ? "Modifier" : "Ajouter"; }

        public ContactViewModel()
        {            
            Contact = new Contact();
            ConfirmCommand = new RelayCommand(ActionConfirmCommand);
            Contacts = new ObservableCollection<Contact>(Contact.GetAll());
        }

        private void ActionConfirmCommand()
        {
            if (Contact.Id > 0)
            {
                if (Contact.Update())
                {
                    MessageBox.Show($"Contact mis à jour avec l'id {Contact.Id}","Update Contact", MessageBoxButton.OK,MessageBoxImage.Information);
                    Contacts = new ObservableCollection<Contact>(Contact.GetAll());
                    RaisePropertyChanged("Contacts");
                    Contact = new Contact();
                }
                else
                    MessageBox.Show($"Erreur lors de la modification du contact {Contact.Id}", "Update Contact", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (Contact.Save())
                {
                    MessageBox.Show($"Contact ajouté avec l'id {Contact.Id}", "Create Contact", MessageBoxButton.OK, MessageBoxImage.Information);
                    Contacts.Add(Contact);
                    Contact = new Contact();
                }
                else
                    MessageBox.Show($"Erreur lors de l'ajout du contact {Contact.Id}", "Create Contact", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
