using System;

namespace Product.Application.Errors.Common
{
    public class ApplicationException : Exception
    {
        public string Title { get; }
        protected ApplicationException(string title, string message)
            : base(message)
            => Title = title;
    }
}
