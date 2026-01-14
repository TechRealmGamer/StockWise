using StockWise.Commands;
using StockWise.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace StockWise.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<string> Categories { get; set; }
        
        // Selected product in DataGrid
        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }

        // Search/filter properties
        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
                // Optional: add filtering logic later
            }
        }

        private string _selectedCategory;
        public string SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                _selectedCategory = value;
                OnPropertyChanged();
                // Optional: add filtering logic later
            }
        }

        private bool _showLowStockOnly;
        public bool ShowLowStockOnly
        {
            get => _showLowStockOnly;
            set
            {
                _showLowStockOnly = value;
                OnPropertyChanged();
                // Optional: add filtering logic later
            }
        }

        // Status message
        private string _statusMessage;
        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                _statusMessage = value;
                OnPropertyChanged();
            }
        }

        // Commands
        public ICommand AddProductCommand { get; set; }
        public ICommand EditProductCommand { get; set; }
        public ICommand DeleteProductCommand { get; set; }
        public ICommand IncreaseStockCommand { get; set; }
        public ICommand DecreaseStockCommand { get; set; }

        public MainViewModel()
        {
            // Dummy data for layout preview
            Products = new ObservableCollection<Product>
            {
                new Product { Id=1, Name="Widget A", Category="Tools", Price=9.99m, Quantity=10, LastUpdated=DateTime.Now },
                new Product { Id=2, Name="Widget B", Category="Gadgets", Price=19.99m, Quantity=2, LastUpdated=DateTime.Now },
                new Product { Id=3, Name="Widget C", Category="Supplies", Price=5.50m, Quantity=0, LastUpdated=DateTime.Now },
            };

            Categories = new ObservableCollection<string> { "All", "Tools", "Gadgets", "Supplies" };

            // Select first product by default
            SelectedProduct = Products[0];

            // Commands (empty for now)
            AddProductCommand = new RelayCommand(o => StatusMessage = "Add clicked");
            EditProductCommand = new RelayCommand(o => StatusMessage = "Edit clicked");
            DeleteProductCommand = new RelayCommand(o => StatusMessage = "Delete clicked");
            IncreaseStockCommand = new RelayCommand(o => StatusMessage = "Increase Stock clicked");
            DecreaseStockCommand = new RelayCommand(o => StatusMessage = "Decrease Stock clicked");

            StatusMessage = "Ready";
        }
    }
}
