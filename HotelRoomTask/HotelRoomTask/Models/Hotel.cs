using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomTask.Models
{
    internal class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Room[] Rooms = new Room[0];

    }
}
