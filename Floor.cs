using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongJanuar
{
    internal class Floor
    {
        public string FloorName { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();

        public int Kitchen => Rooms.Count(r => r.Name == "Kitchen");
        public int TotalRooms => Rooms.Count;

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
    }
}
