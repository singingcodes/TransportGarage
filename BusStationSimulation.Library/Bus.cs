﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationSimulation.Library
{
    public class Bus
    {
        
        private string busPlateNumber = "SE249-KJA";
        public string GetBusNumber
        {
            get
            {
                return busPlateNumber;
            }
            
        }


        //Before Entering the Bus your ticket has to be verified
        public void GetDriver()
        {

        }

        //public void BoardBus(Tickets ticket)
        //{
        //    Passenger passenger = new Passenger(Name, PhoneNumber, Destination, NextOfKin);
        //    passenger.GetTicket();

        //}


    }
}
