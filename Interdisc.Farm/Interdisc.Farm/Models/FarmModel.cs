using System;

namespace Interdisc.Farm.Models
{
    public class FarmModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
