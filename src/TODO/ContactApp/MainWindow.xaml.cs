using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;


namespace ContactApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Contact _selectedContact;

        public ObservableCollection<Contact> Contacts { get; set; }

        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        public Contact EditedContact { get; set; }
        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
                FilterContacts();
            }
        }

        public ObservableCollection<Contact> FilteredContacts { get; set; }
        public ICommand SaveContactCommand { get; set; }
        public ICommand SaveToFileCommand { get; set; }
        public ICommand LoadFromFileCommand { get; set; }
        public ICommand AddContactCommand { get; set; }
        public ICommand RemoveContactCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Alice", Email = "alice@example.com" },
                new Contact { Name = "Bob", Email = "bob@example.com" }
            };

            AddContactCommand = new RelayCommand(AddContact, CanAddContact);
            RemoveContactCommand = new RelayCommand(RemoveContact, CanRemoveContact);
            // Add this code in the MainWindow constructor
            EditedContact = new Contact();
            SaveContactCommand = new RelayCommand(SaveContact, CanSaveContact);
            
            // Add this code in the MainWindow constructor
            FilteredContacts = new ObservableCollection<Contact>(Contacts);

            // Add this code in the MainWindow constructor
            SaveToFileCommand = new RelayCommand(SaveToFile, CanSaveToFile);
            LoadFromFileCommand = new RelayCommand(LoadFromFile, CanLoadFromFile);
        }

        private bool CanAddContact(object parameter)
        {
            return true;
        }

        private void AddContact(object parameter)
        {
            Contacts.Add(new Contact { Name = "New Contact", Email = "new@example.com" });
        }

        private bool CanRemoveContact(object parameter)
        {
            return SelectedContact != null;
        }

        private void RemoveContact(object parameter)
        {
            Contacts.Remove(SelectedContact);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Add these methods at the bottom of the MainWindow class
        private bool CanSaveContact(object parameter)
        {
            return SelectedContact != null && !string.IsNullOrEmpty(EditedContact.Name) && !string.IsNullOrEmpty(EditedContact.Email);
        }

        private void SaveContact(object parameter)
        {
            SelectedContact.Name = EditedContact.Name;
            SelectedContact.Email = EditedContact.Email;
        }

        // Add these methods at the bottom of the MainWindow class
        private void FilterContacts()
        {
            if (string.IsNullOrEmpty(SearchText))
            {
                FilteredContacts = new ObservableCollection<Contact>(Contacts);
            }
            else
            {
                FilteredContacts = new ObservableCollection<Contact>(Contacts.Where(c => c.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase) || c.Email.Contains(SearchText, StringComparison.OrdinalIgnoreCase)));
            }

            OnPropertyChanged(nameof(FilteredContacts));
        }

        // Add these methods at the bottom of the MainWindow class
        private bool CanSaveToFile(object parameter)
        {
            return Contacts.Count > 0;
        }

        private void SaveToFile(object parameter)
        {
            // Save contacts to a file
            string path = "contacts.json";
            string json = JsonSerializer.Serialize(Contacts);
            File.WriteAllText(path, json);
        }

        private bool CanLoadFromFile(object parameter)
        {
            return true;
        }

        private void LoadFromFile(object parameter)
        {
            // Load contacts from a file
            string path = "contacts.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                Contacts = JsonSerializer.Deserialize<ObservableCollection<Contact>>(json);
                FilterContacts();
            }
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
