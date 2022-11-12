using Product.Application.Errors.Common;

namespace Product.Application.Errors
{
    public class BaseNotFoundException : NotFoundException
    {
        public BaseNotFoundException(string TypeOfProduct, string id) 
            : base($"{TypeOfProduct} with ID {id} was not found.")
        {
        }
    }
}
