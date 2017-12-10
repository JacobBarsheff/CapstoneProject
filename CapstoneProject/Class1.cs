using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    class Deck
    {
        #region Fields
        public string _type;
        public string _number;
        public int _value;

        #endregion

        #region Properties       
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region Constructors


        #endregion


        #region Methods

        #endregion
    }
}
