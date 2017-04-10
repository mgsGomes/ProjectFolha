using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;
using ProjectFolha.Model.Entities;

namespace ProjectFolha.Services
{
    public class AzureServices<T>
    {
        IMobileServiceClient Client;
        IMobileServiceTable<T> Table;
  

        public AzureServices()
        {
            string MyAppServiceURL = "http://projectfolha.azurewebsites.net";
            Client = new MobileServiceClient(MyAppServiceURL);
            Table = Client.GetTable<T>();
        }

        public Task<List<T>> GetTable()
        {
            var teste = Table.ToListAsync();
            return Table.ToListAsync();
        }
    }    
}
