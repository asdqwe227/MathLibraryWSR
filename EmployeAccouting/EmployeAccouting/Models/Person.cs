using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmployeAccouting.Models
{
    public class Person : INotifyPropertyChanged
    { 
        public string Name
        {
            get => _name; 
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private string _name;
        public string Telephone 
        {
            get => _telephone;
            set
            {
                _telephone = value;
                OnPropertyChanged("Phone");
            }
        }
        private string _telephone;
        public string Gender 
        {
            get => _gender;
            set
            {
                if (value == _gender)
                    return;
                _gender = value;
                OnPropertyChanged("Gender");

            }
        }
        private string _gender;
        public string PersonAddres 
        {
            get => _personAdress;
            set
            {
                _personAdress = value;
                OnPropertyChanged("Adress");
            }
        }
        private string _personAdress;

        public Person(string name, string telephone, string personAddres, string gender)
        {
            Gender = gender;
            _name = name;
            _telephone = telephone;
            PersonAddres = personAddres;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
