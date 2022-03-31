﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    class Flight
    {
        private int _flightTime;

        public string Departure { get; set; }
        public string Destination { get; set; }

        public int FlightTime
        {
            get { return _flightTime; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Flight time should be greater than 0, but was " + value);

                _flightTime = value;
            }
        }

        public Flight() { }
        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }
    }
}