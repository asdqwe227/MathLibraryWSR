using EmployeAccouting.Models;
using EmployeAccouting.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace EmployeAccouting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Saveses save;
        private BindingList<Person> _personData;
        private readonly string Path = $"{Environment.CurrentDirectory}\\PersonData.json";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddAccount window = new AddAccount(_personData);
            window.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            save = new Saveses(Path);
            try
            {
                _personData = save.Load();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                Close();
            }
            Grid.ItemsSource = _personData;
            _personData.ListChanged += PersongDataListChanged;
        }

        private void PersongDataListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                save.Save(_personData);
            }
        }
    }
}
