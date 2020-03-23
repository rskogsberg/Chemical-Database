using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChemicalMVCDatabase.Models
{
  public class Chemical
  {
    public int Chemical_ID { get; set; }
    [Display(Name = "Name")]
    [Required(ErrorMessage = "Please enter a name to add a chemical to the database.")]
    public string Chemical_Name { get; set; }
    [Display(Name="Molecular Weight")]
    public Decimal Molecular_Weight { get; set; }
    [Display(Name="Product Number")]
    public string Product_Number { get; set; }
    public string Vendor { get; set; }
  }
}