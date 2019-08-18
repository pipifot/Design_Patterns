using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class BaggageInfo
    {
        private int _flightNo;
        private string _origin;
        private int _location;

        internal BaggageInfo(int flight, string from, int carousel)
        {
            _flightNo = flight;
            _origin = from;
            _location = carousel;
        }

        public int FlightNumber
        {
            get { return _flightNo; }
        }

        public string From
        {
            get { return _origin; }
        }

        public int Carousel
        {
            get { return _location; }
        }
    }

}
