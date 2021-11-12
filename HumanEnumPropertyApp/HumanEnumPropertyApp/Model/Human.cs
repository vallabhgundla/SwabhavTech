using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanEnumPropertyApp.Model
{
    class Human
    {
        private string _name;
        private float _height;
        private float _weight;
        private GenderType _gender;

        public Human(string name,float height,float weight, GenderType gender)
        {
            this._name=name;
            this._height=height;
            this._weight=weight;
            this._gender = gender;
        }
        public void Eat()
        {
            _weight += _weight * (20 / 100) ;
            
        }
        public void WorkOut()
        {
            _weight -= (10 / 100) * _weight;

            _height += (5 / 100) * _height;

        }
        public GenderType gender
        {
            get
            {
                return _gender;
            }
            
        }
        public string name
        {
            get
            {
                return _name;
            }
            
        }
        public float weight
        {
            get
            {
                return _weight;
            }
            
        }
        public float height
        {
            get
            {
                return _height;
            }
            
        }

    }
}
