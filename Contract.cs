using System;
using System.Collections.Generic;
using System;

namespace ConsoleApp22.Entities
{
    class Contract
    {
        private int contractNumber;
        private DateTime contractDate;
        private double contractValue;

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double totalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue, List<Installment> installment)
        {
            Number = number;
            Date = date;
            this.totalValue = totalValue;
            Installments = new List<Installment>();
        }

        public Contract(int contractNumber, DateTime contractDate, double contractValue)
        {
            this.contractNumber = contractNumber;
            this.contractDate = contractDate;
            this.contractValue = contractValue;
        }

        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
