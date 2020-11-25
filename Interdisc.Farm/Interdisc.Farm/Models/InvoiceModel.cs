using System;

namespace Interdisc.Farm.Models
{
    public class InvoiceModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
test