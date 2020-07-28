using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionRondeBackEnd.models
{
    public class BLE
    {
          [Key]
           [Column(TypeName = "varchar(150)")]
          public string idBLE{get; set;}
         [Column(TypeName = "varchar(150)")]
         public string heurAjout{get; set;}
         
    }
}