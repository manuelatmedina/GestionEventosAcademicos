using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionEventosAcademicos.Shared.Entities
{
    public class Participant
    {

        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Affilliation { get; set; } = null;
        public string Area { get; set; } = null;
        public string Type { get; set; } = null;
    }


    
}
