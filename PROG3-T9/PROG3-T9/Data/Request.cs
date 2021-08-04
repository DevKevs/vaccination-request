using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROG3_T9.Data
{
    public class Request
    {
        public int ID { get; set; }
        [Required (ErrorMessage = "La cedula es necesaria")]
        public string CardId { get; set; }
        [Required(ErrorMessage = "El nombre es necesario")]
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "El telefono es necesario")]
        public string Phone { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Debes indicar un email válido")]
        public string Email { get; set; }
        public string Birthdate { get; set; }
        public string BloodType { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "La Latitud es necesaria")]
        public string Lat { get; set; }
        [Required(ErrorMessage = "La Longitud es necesaria")]
        public string Lgn { get; set; }
        public string Covid_confirmation { get; set; }
        [Required(ErrorMessage = "la justificacion es necesaria")]
        public string Justify { get; set; }
    }
}
