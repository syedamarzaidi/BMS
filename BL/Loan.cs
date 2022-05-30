using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    class Loan
    {
        private double loanAmount;
        private double loanInstallment;
        private int loanDuration;

        public double LoanAmount
        {
            get
            {
                return loanAmount;
            }

            set
            {
                loanAmount = value;
            }
        }

        public double LoanInstallment
        {
            get
            {
                return loanInstallment;
            }

            set
            {
                loanInstallment = value;
            }
        }

        public int LoanDuration
        {
            get
            {
                return loanDuration;
            }

            set
            {
                loanDuration = value;
            }
        }
    }
}
