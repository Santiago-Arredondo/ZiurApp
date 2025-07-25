using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiurApp.Shared.Models
{
    public class Documento
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public bool VActiva { get; set; }
    }
}
