using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectFolha.Services;

namespace ProjectFolha.Model.Entities
{
    public class Repository
    {
        public async Task<List<RHEstadoCivil>> GetEstadoCivil()
        {
            var Service = new ProjectFolha.Services.AzureServices<RHEstadoCivil>();
            var Items = await Service.GetTable();
            return Items.ToList();
        }
    }
}
