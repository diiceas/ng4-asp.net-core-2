using ng4_asp.net_core_2.Extensions;

namespace ng4_asp.net_core_2.Core.Models
{
    public class VehicleQuery: IQueryObject
    {
        public int? MakeId { get; set; }
        public int? ModelId { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}