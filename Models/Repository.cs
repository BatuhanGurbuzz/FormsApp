namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category {CategoryID = 1, CategoryName = "Bilgisayar"});
            
            _categories.Add(new Category {CategoryID = 2, CategoryName = "Telefon"});

            _products.Add(new Product{ProductID = 1, Name = "Iphone 15", Price = 80000, isActive = true, Image = "1.jpg", CategoryID = 2});

            _products.Add(new Product{ProductID = 2, Name = "Iphone 13", Price = 35000, isActive = true, Image = "3.jpg", CategoryID = 2});

            _products.Add(new Product{ProductID = 3, Name = "Iphone 12", Price = 35000, isActive = true, Image = "4.jpg", CategoryID = 2});

            _products.Add(new Product{ProductID = 4, Name = "Macbook Air", Price = 35000, isActive = true, Image = "pc1.jpg", CategoryID = 1});
            
            _products.Add(new Product{ProductID = 5, Name = "Macbook Pro", Price = 35000, isActive = true, Image = "ps2.jpg", CategoryID = 1});
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static List<Category> Categories{
            get{
                return _categories;
            }
        }
    }
}