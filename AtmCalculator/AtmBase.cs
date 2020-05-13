using System.Collections.Generic;

namespace AtmCalculator
{
    public class AtmBase
    {
        public ReturnedBills CalculateBills(long requestedAmount)
        {
            ReturnedBills result = null;

            result = CalculateAmounts(requestedAmount);

            return result;
        }

        private ReturnedBills CalculateAmounts(long requestedAmount)
        {
            int baseFifties = 0;
            int baseHundreds = 0;
            int baseTwenties = 0;

            ReturnedBills result = null;

            baseHundreds = (int)requestedAmount / 100;

            var remainingAmount = requestedAmount - baseHundreds * 100;

            if (remainingAmount != 0)
            {

                baseFifties = (int)remainingAmount / 50;

                remainingAmount = remainingAmount - baseFifties * 50;

                if (remainingAmount != 0)
                {
                    baseTwenties = (int)remainingAmount / 20;
                }
            }

            result = new ReturnedBills
            {
                Hundreds = baseHundreds,
                Fifties = baseFifties,
                Twenties = baseTwenties
            };

            return result;
        }
    }
}