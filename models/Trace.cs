using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionRondeBackEnd.models
{
    public class Trace
    {
        [Key]
        [Column(TypeName = "varchar(150)")]
        public string codeTrace{get ;set;}
        
        public string wifiName{get; set;}
       
        public string codeAgent{get; set;}
         [ForeignKey("codeAgent")]
         public Agent Agent {get; set;}
        

    }
}