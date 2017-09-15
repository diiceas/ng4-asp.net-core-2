using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using ng4_asp.net_core_2.Models;

namespace ng4_asp.net_core_2.Controllers.Resources
{
    public class SaveVehicleResource
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public bool IsRegistered { get; set; }
        [Required]
        public ContactResource Contact { get; set; }        
        public ICollection<int> Features { get; set; }

        public SaveVehicleResource()
        {
            Features = new Collection<int>();
        }
    }

}