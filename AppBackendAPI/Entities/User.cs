using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Usuario")]
    public class User
    {
        [Key]
        public decimal UsuID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
