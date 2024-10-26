using THUCHANH.Models;

namespace THUCHANH.Repository
{
    public interface IProductRepository
    {
        public ICollection<Product> getById(int id);
        public ICollection<Product> getAll();

        public bool updateProduct(Product contact);
        public bool createProduct(Product contact);

        public bool isExist(long id);
        public bool Save();
    }
}
