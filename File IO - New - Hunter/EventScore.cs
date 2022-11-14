using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO___New___Hunter
{
    internal class EventScore
    {
        private string _name;
        private string _event;
        private double _totalScore;


        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Event
        {
            get
            {
                return _event;
            }
        }

        public double TotalScore
        {
            get
            {
                return _totalScore;
            }
        }
    }
}
