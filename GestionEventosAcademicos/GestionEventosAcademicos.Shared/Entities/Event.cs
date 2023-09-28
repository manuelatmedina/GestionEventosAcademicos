using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionEventosAcademicos.Shared.Entities
{
    //Creacion Entidad Evento
    public class Event
    {
        public int Id {  get; set; }

        [Display(Name = "Evento")]
        [MaxLength(100,ErrorMessage ="El Campo {0} debe tener màximo {1} caràcteres")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Name { get; set; } = null;

        [Display(Name = "Descripciòn")]
        [Required(ErrorMessage = "El Campo {1} es obligatorio")]
        public string Description { get; set; } = null;

        [Display(Name = "Tema")]
        [Required(ErrorMessage = "El Campo {2} es obligatorio")]
        public string Topic { get; set; } = null;

        [Display(Name = "Fecha Inicio")]
        [Required(ErrorMessage = "El Campo {3} es obligatorio")]
        public string StartDate { get; set; } = null;

        [Display(Name = "Fecha Fin")]
        [Required(ErrorMessage = "El Campo {4} es obligatorio")]
        public string EndDate { get; set; } = null;

        [Display(Name = "Ubicaciòn")]
        [Required(ErrorMessage = "El Campo {5} es obligatorio")]
        public string Location { get; set; } = null;



    }
}
