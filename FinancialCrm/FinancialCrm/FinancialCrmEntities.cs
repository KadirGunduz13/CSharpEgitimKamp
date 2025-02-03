using FinancialCrm.Models;
using System;

namespace FinancialCrm
{
    internal class FinancialCrmEntities
    {
        public object BankProcesses { get; internal set; }

        public static implicit operator FinancialCrmEntities(FinancialCrmDbEntities v)
        {
            throw new NotImplementedException();
        }
    }
}