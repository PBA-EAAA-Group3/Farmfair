using System;

namespace Interdisc.Farm.Models
{
    public class CategoryModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
