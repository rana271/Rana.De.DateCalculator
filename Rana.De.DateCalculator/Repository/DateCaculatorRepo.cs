using Rana.De.DateCalculator.Models;
using Rana.De.DateCalculator.Helper;
namespace Rana.De.DateCalculator.Repository
{
    public interface IDateCaculatorRepo
    {
        long doDaysCalculate(DateCalculatorViewModel model);
    }
    /// <summary>
    /// Number of Days Calculator
    /// </summary>
    public class DateCaculatorRepo : IDateCaculatorRepo
    {
        public long doDaysCalculate(DateCalculatorViewModel model)
        {
            return model.Days= DateCalculatorHelper.ToJulian(model.EndDate) - DateCalculatorHelper.ToJulian(model.StartDate);
        }
    }
}
