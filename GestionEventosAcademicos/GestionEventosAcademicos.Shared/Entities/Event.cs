using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionEventosAcademicos.Shared.Entities
{
    public class Event
    {
        public int Id {  get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public string Topic { get; set; } = null;
        public Date StartDate { get; set; }
        public Date EndDate { get; set; }



    }
}
