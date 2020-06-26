using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Usuario
    {
        [Required]
        public string nombreUsuario { get; set; }

        [Required]
        public string password { get; set; }

    }
}
