using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDR_SOL.Models
{
  public class Owner
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string FirstName { get; set; }

  }
}
