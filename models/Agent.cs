using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionRondeBackEnd.models
{
    public class Agent
    {
        [Key]
        [Column(TypeName = "varchar(150)")]
        public string codeAgent{get; set;}
         
         [Column(TypeName = "varchar(150)")]

        public string nomAgent{get ;set;}
         [Column(TypeName = "varchar(150)")]

        public string prenomAgent {get; set;}
         [Column(TypeName = "varchar(150)")]

        public string pawdAgent {get;set;}
        public string codePlanning {get ;set;}
        [ForeignKey("codePlanning")]
        public  Planning planning {get;set;}
    }
}