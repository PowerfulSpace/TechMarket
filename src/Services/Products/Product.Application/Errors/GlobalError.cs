using System.Collections.Generic;

namespace Product.Application.Errors
{
    public class GlobalError
    {
        public string Title { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public IReadOnlyDictionary<string, string[]> Errors { get; set; }
    }
}
