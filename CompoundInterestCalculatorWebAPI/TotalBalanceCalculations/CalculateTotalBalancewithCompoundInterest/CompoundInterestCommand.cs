using CompoundInterestCalculatorWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CompoundInterestCalculatorWebAPI.TotalBalanceCalculations.CalculateTotalBalancewithCompoundInterest
{
    public class CompoundInterestCommand
    {
        public CompoundInterest Model { get; set; } // This property was created to access the parameters taken from the user.
        public CompoundInterestCommand() /* The empty construction method was generated.
                                            It was created as a result of further requirements such as dbContext. */
        {
     
        }

        public CompoundInterestViewModel Calculate()
        {
            CompoundInterestViewModel result = new CompoundInterestViewModel(); /* The instance of CompoundInterestViewModel class was generated 
                                                                                    to access all the properties of the mentioned class.*/

            result.TotalBalance = Math.Round(Model.InitialPrincipal * Math.Pow((1 + Model.InterestRate / 100), Model.CompoundInterval), 3); // The mathematical formulation of Compound Interest was implemented.
            result.InterestAmount = Math.Round(result.TotalBalance - Model.InitialPrincipal,3); // The difference between Total Balance and Initial Principal gives the Interest Amount.
            return result;
        }

    }

    public class CompoundInterestViewModel // Another model class was created with only several specific properties. 
                                           /* The aim of doing this is that we want to 
                                            show only "InterestAmount" and "TotalBalance" as a result to the clients.*/
                                           /* This practice might be unnecessary for this example. 
                                            However, this kind of use is suggested for best practice.*/
    {
        public double InterestAmount { get; set; } 
        public double TotalBalance { get; set; }
    }
}
