using ConsoleApp22.Entities;
using System;

namespace ConsoleApp22.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        
                public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {

            double basicQuota = contract.totalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }


    }
    }

