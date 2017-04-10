using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using AppServiceHelpers.Models;
using System.Runtime.Serialization;

namespace ProjectFolha.Model.Entities
{
    [DataTable("RHESTADOCIVIL")]
    public class RHEstadoCivil
    {
        public string Id { get; set; }
        public string EstadoCivil { get; set; }

        public string Descricao20 { get; set; }

        public string ClasseEstadoCivil { get; set; }

    }
}
