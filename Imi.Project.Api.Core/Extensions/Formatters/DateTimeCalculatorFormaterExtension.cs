using System;

namespace Imi.Project.Api.Core.Extensions.Formatters
{
    public static class DateTimeCalculatorFormaterExtension
    {
        #region Methods

        public static int CalculateToalDaysFromDateTimes(DateTime startDate, DateTime endDate)
        {
            var timeSpan = endDate - startDate;
            var totalDays = timeSpan.TotalDays;
            return (int)totalDays;
        }

        public static int CalculateTotalMonthsFromDateTimes(DateTime startDate, DateTime endDate)
        {
            var timeSpan = endDate - startDate;
            var totalDays = timeSpan.TotalDays;
            var totalMonths = (totalDays / (365.25 / 12));
            return (int)totalMonths;
        }

        public static int CalculateTotalYearsFromDateTimes(DateTime startDate, DateTime endDate)
        {
            var timespan = (endDate - startDate);
            var totalYears = (int)(timespan.Days / 365.25);
            return totalYears;
        }

        #endregion Methods
    }
}