using EmployeAccouting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeAccouting
{
    /// <summary>
    /// Логика взаимодействия для AddAccount.xaml
    /// </summary>
    public partial class AddAccount : Window
    {
        private BindingList<Person> _people;
        public AddAccount(BindingList<Person> people)
        {
            _people = people;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs eventArgs)
        {
            Add.Click += OnClickAddButton;
        }

        private void OnClickAddButton(object sender, RoutedEventArgs eventArgs)
        {
            if(Femal.IsChecked == true)
            {
                Person additedPerson = new Person(Name.Text, Telephone.Text, $"{Countre.Text}, {City.Text}, {Street.Text}, {Home.Text}, {Apartment.Text}", "Female");
                _people.Add(additedPerson);
                this.Close();
            }
            if(Man.IsChecked == true)
            {
                Person additedPerson = new Person(Name.Text, Telephone.Text, $"{Countre.Text}, {City.Text}, {Street.Text}, {Home.Text}, {Apartment.Text}", "Man");
                _people.Add(additedPerson);
                this.Close();
            }
        }
    }
}
