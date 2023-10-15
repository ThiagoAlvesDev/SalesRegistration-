using SalesWebMVC.Models.Enums;
using System.Collections.Generic;

namespace SalesWebMVC.Models.ViewModels
{
    public class SalesFormViewModels
    {
        public SalesRecords Sales { get; set; }
        public ICollection<Seller> Sellers { get; set; }                
        public ICollection<string> SalesStatuses { get; set; }
    }
}
