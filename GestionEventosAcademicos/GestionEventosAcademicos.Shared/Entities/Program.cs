using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionEventosAcademicos.Shared.Entities
{
    public class Program
    {
        public int Id { get; set; }
        public string Schedule { get; set; } = null;
        public string Session { get; set; } = null;
        public string Host { get; set; } = null;
        public string Topic { get; set; } = null;

    }
}
