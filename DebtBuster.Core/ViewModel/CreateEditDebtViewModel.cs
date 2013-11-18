using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DebtBuster.Core.ViewModel
{
    public class CreateEditDebtViewModel : INotifyPropertyChanged
    {
        public CreateEditDebtViewModel()
        {
            PaymentPeriods = Enum.GetValues(typeof (PaymentPeriod)).Cast<PaymentPeriod>().ToList();
        }

        private IList<PaymentPeriod> _paymentPeriods; 
        public List<PaymentPeriod> PaymentPeriods
        {
            get { return Enum.GetValues(typeof (PaymentPeriod)).Cast<PaymentPeriod>().ToList(); }
            set
            {
                if (_paymentPeriods != value)
                {
                    _paymentPeriods = value;
                    OnPropertyChanged("PaymentPeriods");
                }
            }
        }

        private Debt _debt;
        public Debt Debt
        {
            get { return _debt; }
            set
            {
                if (_debt != value)
                {
                    _debt = value;
                    OnPropertyChanged("Debt");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
