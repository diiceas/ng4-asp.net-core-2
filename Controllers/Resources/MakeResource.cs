using System.Collections.Generic;
using System.Collections.ObjectModel;
using ng4_asp.net_core_2.Models;

namespace ng4_asp.net_core_2.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }
        public MakeResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}