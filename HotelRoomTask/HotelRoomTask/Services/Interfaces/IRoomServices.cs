using HotelRoomTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomTask.Services.Interfaces
{
    internal interface IRoomServices
    {
        public void CreateNewRoom(int no, double price);
        public Room[] GetAllRooms();
        public void ReserveARoom(int id);
    }
}
