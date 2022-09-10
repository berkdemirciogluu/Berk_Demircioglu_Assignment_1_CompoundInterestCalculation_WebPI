
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CompoundInterestCalculatorWebAPI.Models
{
    public class CompoundInterest
    {
        [Required] // This annotation was used to prevent the user from passing parameters without entering any value.
        [DefaultValue("28500")] // This annotation was used to provide the user with a sense of the type of parameter that will be entered. 
        public double InitialPrincipal { get; set; } // The property that represents the invested money

        
        [Required]
        [DefaultValue("30")]
        public double InterestRate { get; set; } // The property that represents the amount of interest due per period

        [Required]
        [DefaultValue("5")]
        public double CompoundInterval { get; set; } // The property that represents the investment time period

    }
}
