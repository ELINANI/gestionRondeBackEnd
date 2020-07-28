using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionRondeBackEnd.models
{
    public class Planning
    {
        [Key]
        [Column(TypeName = "varchar(150)")]
        public string codePlanning {get ;set;}
         [Column(TypeName = "varchar(150)")]
         public string desc {get; set;}
        public string codeAdmin{get; set;}
        [ForeignKey("codeAdmin")]
        public Admin admin {get; set;}

        
    }
}