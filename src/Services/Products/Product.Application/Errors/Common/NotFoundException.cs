namespace Product.Application.Errors.Common
{
    public class NotFoundException : ApplicationException
    {
        protected NotFoundException(string message) 
            : base("Not Found", message)
        {
        }
    }
}
