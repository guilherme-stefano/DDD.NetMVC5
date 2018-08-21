using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDDD.Presentation.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo Description")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Description { get; set; }

        public bool Status { get; set; }

        [ScaffoldColumn(false)]
        
        public DateTime DateCreated { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}