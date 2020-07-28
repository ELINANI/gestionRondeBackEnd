using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionRondeBackEnd.models
{
    public class Admin
    {
        [Key]
            [Column(TypeName = "varchar(150)")]
        public string codeAdmin{get; set;}
         [Column(TypeName = "varchar(150)")]

        public string nomAdmin{get ;set;}
         [Column(TypeName = "varchar(150)")]

        public string prenomAdmin {get; set;}
         [Column(TypeName = "varchar(150)")]

        public string pawdAdmin {get;set;}
        
    }
}