using System.Collections.Generic;
using System.Collections.ObjectModel;
using ng4_asp.net_core_2.Models;

namespace ng4_asp.net_core_2.Controllers.Resources
{
    public class MakeResource: KeyValuePairResource
    {
        public ICollection<KeyValuePairResource> Models { get; set; }
        public MakeResource()
        {
            Models = new Collection<KeyValuePairResource>();
        }
    }
}