using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private FestivalType _festival;
        private double _SimpleInterest;
        private double _CalculateRate;

        public FixedDeposit(string name,double amount,int duration, FestivalType festival)
        {
            this._name = name;
            this._amount = amount;
            this._duration = duration;
            this._festival = festival;

        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Amount
        {
            get
            {
                return _amount;
            }
        }
        public int Duration
        {
            get
            {
                return _duration;
            }
        }
        public FestivalType Festival
        {
            get
            {
                return _festival;
            }
        }
        public double SimpleInterest()
        {
            _SimpleInterest = (_amount * _CalculateRate * _duration) / 100;
            return _SimpleInterest;
        }
        public double CalculateRate()
        {
            float InterestRate = 7f;
            if (_festival == FestivalType.Diwali)
            {
                InterestRate = 8f;
                return InterestRate;
            }
            else if (_festival == FestivalType.Eid)
            {
                InterestRate = 8.5f;
                return InterestRate;
            }
            else if (_festival == FestivalType.New_Year)
            {
                InterestRate = 9f;
                return InterestRate;
            }
            else if (_festival == FestivalType.Normal)
            {
                InterestRate = 7f;
                return InterestRate;
            }
            else
            {
                return InterestRate;
            }
        }
    }
}
