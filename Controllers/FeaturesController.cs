using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ng4_asp.net_core_2.Controllers.Resources;
using ng4_asp.net_core_2.Models;
using ng4_asp.net_core_2.Persistence;

namespace ng4_asp.net_core_2.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {
            var features = await this.context.Features.ToListAsync();
            return this.mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
        }
    }
}