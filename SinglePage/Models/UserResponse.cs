using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePage.Models
{
   public class UserResponse
   {
      //Fields & Properties

      [Required(ErrorMessage = "Date Is Required")]
      public DateTime DateInput { get; set; }
      
      [Required(ErrorMessage = "Odometer Is Required")]
      public int Odometer { get; set; }    
      
      [Required(ErrorMessage = "Gallons Is Required")]
      public double Gallons { get; set; }
      
      [Required(ErrorMessage = "Total Cost Is Required")]
      public decimal TotalCost { get; set; }

    

      //Constructors

      //Methods
   }
}
