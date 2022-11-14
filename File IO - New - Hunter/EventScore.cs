using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace File_IO___New___Hunter
{
    internal class EventScore
    {
        private string _name;
        private string _event;
        private double _totalScore;

        public EventScore(string name, string eventName, double score)
        {
            this._name = name;
            this._event = eventName;
            this._totalScore = score;
        }

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

        public double GetTotalScore()
        {
            return _totalScore;
        }

        public double GetAverage()
        {
            return _totalScore/5;
        }

        public override string ToString()
        {
            return $"{_name}, {_event}, {_totalScore}."; 
        }
    }
}
