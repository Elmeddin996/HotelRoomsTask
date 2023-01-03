using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelRoomTask.Models
{
    internal class Room
    {
        private static int _id = 0;
        private int _no;
        private double _price;
        public bool IsReserved { get; set; }
        public readonly int Id;
        public int No 
        {
            get => _no;

            set
            {
                if (value>0)
                {
                    _no=value;
                    
                }
                else
                {
                    Console.WriteLine("Duzgun Nomre Daxil Edin!!!");
                }
            }
        }
        public double Price
        {
            get => _price;

            set
            {
                if (value>=20)
                {
                    _price = value;
                    
                }
                else
                {
                    Console.WriteLine("Qiymet Minimumu 20Azn-dir!!!");
                }
            }
        }



        public Room()
        {
            _id++;
            Id=_id;
           
        }

        public override string ToString()
        {
            return $"Room number: {No}\n\tRoom Price: {Price}Azn\n\tRoom reserv status: {IsReserved}";
        }

    }
    
}
