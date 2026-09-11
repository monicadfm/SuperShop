using SuperShop.Data.Entities;
using SuperShop.Models;

namespace SuperShop.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel mode, string path, bool isNew);

        ProductViewModel ToProductViewModel(Product product);
    }
}
