using HotelRoomTask.Models;
using HotelRoomTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomTask.Services.Implimentation
{
    internal class RoomServices : IRoomServices
    {
        Hotel hotel =new Hotel();

        public void CreateNewRoom(int no,double price)
        {
            Room room = new Room
            {
                 No= no,
                Price = price,
                IsReserved=false

            };
            
                 Array.Resize(ref hotel.Rooms, hotel.Rooms.Length + 1);
                 hotel.Rooms[hotel.Rooms.Length - 1]=room;
                 
        }

        public Room[] GetAllRooms()
        {
            return hotel.Rooms;
        }

        public void ReserveARoom(int id)
        {
            for (int i = 0; i < hotel.Rooms.Length; i++)
            {
                if (hotel.Rooms[i].Id==id)
                {
                    if (hotel.Rooms[i].IsReserved != true)
                    {
                        hotel.Rooms[i].IsReserved = true;
                        Console.WriteLine("Otaq Rezerv Edildi");
                    }
                    else if (hotel.Rooms[i].Id != id)
                    {
                        Console.WriteLine("Bu Id-de Otaq Yoxdur!!!");
                    }
                    else
                    {
                        Console.WriteLine("Bu Otaq Artiq Rezerv Edilib!!!");  
                    }
                    
                }
            }
        }
    }
}
