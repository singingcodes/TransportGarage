using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusStationSimulation.Library
{
    public class Passenger : BioClass
    {
        public string Destination;
      
        private static readonly Random round = new Random();
          public int SeatNumber => round.Next(1,19);
        
        Driver driver = new Driver();
        public Passenger(string name, string phonenumber, string destination, string NextofKin)
        {
            Name = name;
            PhoneNumber = phonenumber;
            NextOfKin = NextofKin;
            Destination = destination;
           
        }

        
        public void GetTicket()
        {
            Passenger passenger = new Passenger(Name, PhoneNumber, Destination, NextOfKin);
            Ticketer myTicket = new Ticketer();
            var ticket = myTicket.IssueTicket(passenger); ;
            Console.WriteLine("Your Ticket is as follows:");
            Console.WriteLine($"Ticket Id: {ticket.Id}");
            Console.WriteLine($"Name: {ticket.Name}");
             Console.WriteLine($"Seat Number: {ticket.SeatNumber}");
            Console.WriteLine($"Ticket Issued by: {ticket.issuedBy}");
            Console.WriteLine($"Next of Kin: {ticket.NextOfKin}");
            Console.WriteLine($"Departure Time: {ticket.DepartureTime}");
            Console.WriteLine($"Destination: {ticket.Destination}");
            Console.WriteLine($"Amount: {ticket.Amount}");
            Console.WriteLine($"Bus Plate Number: {ticket.BusPlateNumber}");
        }

        private void Board()
        {
            Console.WriteLine("You are now ready for Boarding");
            Console.WriteLine("Press 1 to Enter Bus, Press 2 to Exit");
            var boardingEntry = Console.ReadLine();
            if (boardingEntry == "1")
            {

                Console.WriteLine($"Please show your ticket");
                GetTicket();
                Console.WriteLine("Confirming Ticket...");
                Thread.Sleep(3000);
                Console.WriteLine($"Welcome to ISE Transport, have a safe trip");

            }
            else if (boardingEntry == "2")
            {
                Console.WriteLine("Thanks for trusting us, please come back next time");
                Environment.Exit(-1);
            }
                
            
        }

        public void MethodCaller()
        {
            Board();
        }

    }
}