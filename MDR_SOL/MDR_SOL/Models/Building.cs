using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MDR_SOL.Models
{
  public class Building
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Address { get; set; }
    [DisplayName("Construction Year")]
    [Range(1850,2015)]
    public int ConstructionYear { get; set; }

    public int IdOwner { get; set; }
    // FACULTATIF on peut formellement identifier le champ lien
    [ForeignKey("IdOwner")]
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec ZombieType
    public virtual Owner Owner { get; set; }
  }
}
