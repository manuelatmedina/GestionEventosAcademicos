using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionEventosAcademicos.Shared.Entities
{
    public class Participant
    {
        //Creaciòn Entidad Participante
        public int Id { get; set; }

        [Display(Name = "Participante")]
        [MaxLength(100, ErrorMessage = "El Campo {0} debe tener màximo {1} caràcteres")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Name { get; set; } = null;

        [Display(Name = "Afiliaciòn")]
        [Required(ErrorMessage = "El Campo {1} es obligatorio")]
        public string Affilliation { get; set; } = null;

        [Display(Name = "Àrea")]
        [Required(ErrorMessage = "El Campo {2} es obligatorio")]
        public string Area { get; set; } = null;

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "El Campo {3} es obligatorio")]
        public string Type { get; set; } = null;
    }


    
}
