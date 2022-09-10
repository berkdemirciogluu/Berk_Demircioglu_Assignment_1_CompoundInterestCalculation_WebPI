using FluentValidation;

namespace CompoundInterestCalculatorWebAPI.TotalBalanceCalculations.CalculateTotalBalancewithCompoundInterest
{
    public class CompundInterestCommandValidator : AbstractValidator<CompoundInterestCommand>
    // This means that "CompundInterestCommandValidator" validates the "CompoundInterestCommand" class.
    // This validator is interested in the inputs of CompoundInterestCommand class.

    {
        public CompundInterestCommandValidator()
        {
            // Checking if the right values are entered or not.
            // It is required that the parameters must be greater than or equal to 0(zero).
            /* .NotNull() was not used. If it was, the user would not be able to enter a 0(zero) value.
                Therefore, the [Required] attribute was used in the model class to avoid this situation.*/
            
            RuleFor(command => command.Model.InitialPrincipal).GreaterThanOrEqualTo(0); // It is required that the parameters must be greater than or equal to 0(zero)
            RuleFor(command => command.Model.InterestRate).GreaterThanOrEqualTo(0);
            RuleFor(command => command.Model.CompoundInterval).GreaterThanOrEqualTo(0);
        }
    }
}
