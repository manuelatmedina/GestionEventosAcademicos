using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionEventosAcademicos.Shared.Entities
{
    public class Program
    {
        //Creacion entidad Programa
        public int Id { get; set; }

        [Display(Name = "Horario")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Schedule { get; set; } = null;

        [Display(Name = "Sesiòn")]
        [Required(ErrorMessage = "El Campo {1} es obligatorio")]
        public string Session { get; set; } = null;

        [Display(Name = "Ponente")]
        [Required(ErrorMessage = "El Campo {2} es obligatorio")]
        public string Host { get; set; } = null;

        [Display(Name = "Tema")]
        [Required(ErrorMessage = "El Campo {3} es obligatorio")]
        public string Topic { get; set; } = null;

    }
}
