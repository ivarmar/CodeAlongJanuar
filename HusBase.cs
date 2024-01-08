using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongJanuar
{
    internal class HusBase : IHus
    {
        public int Room { get; set; }
        public int Floors { get; set; }
        public int BathRoom { get; set; }

        public int Kitchen { get; set; }

        public int BedRoom { get; set; }

        public int LivingRoom { get; set; }

        public int CustomRoom { get; set; }

        private List<Floor> FloorList { get; } = new List<Floor>();


        public void AddFloor()
        {
            Console.WriteLine("Type what you want your floor to be named in your house");
            var floorInput = Console.ReadLine();
            Floor newFloor = new Floor { FloorName = floorInput };
            FloorList.Add(newFloor);
            Console.WriteLine($"You named your new floor {floorInput}");
            Floors++;
        }

        public void ShowRooms()
        {
            Console.WriteLine("Rooms in the House:");

            foreach (var floor in FloorList)
            {
                Console.WriteLine($"Floor Name: {floor.FloorName}");
                foreach (var room in floor.Rooms)
                {
                    Console.WriteLine($"Room Name: {room.Name}, Floor: {floor.FloorName}");
                }
            }
        }
        public void ShowFloors()
        {
            Console.WriteLine("Floors in the House:");

            foreach (var floor in FloorList)
            {
                Console.WriteLine($"Floor Name: {floor.FloorName}");
            }
        }
        public void AddRoom()
        {
            Console.WriteLine("Select a Floor to add a room to: ");
            ShowFloors();
            var selectedFloor = Console.ReadLine();
            var floor = FloorList.FirstOrDefault(f => f.FloorName == selectedFloor);

 
            if (floor != null)
            {
                Console.WriteLine("Input the room you want to add (only 1 bathroom and kitchen per floor)");
                Console.WriteLine("1. Kitchen");
                Console.WriteLine("2. Bed Room");
                Console.WriteLine("3. LivingRoom");
                Console.WriteLine("4. BathRoom");
                Console.WriteLine("5. New Room (ex: GamingRoom)");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "Kitchen" or "1":
                        if (floor.Kitchen == 0 && floor.TotalRooms < 5)
                        {
                            Console.WriteLine("You Have added a Kitchen to the floor.");
                            floor.AddRoom(new Room { Name = "Kitchen", Floor = selectedFloor });
                            Kitchen++;
                            Room++;
                        }
                        else
                        {
                            Console.WriteLine("You cannot add anymore Kitchens to the floor");
                        }

                        break;
                    case "BedRoom" or "2":
                        if (Room < 5)
                        {
                            Console.WriteLine("You Have added a Bedroom to the floor.");
                            floor.AddRoom(new Room { Name = "BedRoom", Floor = selectedFloor });
                            BedRoom++;
                            Room++;
                        }
                        else
                        {
                            Console.WriteLine("You have Max rooms in the floor");
                        }

                        break;
                    case "LivingRoom" or "3":
                        if (Room < 5)
                        {
                            Console.WriteLine("You Have added a LivingRoom to the floor.");
                            floor.AddRoom(new Room { Name = "LivingRoom", Floor = selectedFloor });
                            LivingRoom++;
                            Room++;
                        }
                        else
                        {
                            Console.WriteLine("Max Rooms on floor.");
                        }

                        break;
                    case "BathRoom" or "4":
                        if (BathRoom == 0 && Room < 5)
                        {
                            Console.WriteLine("You Have added a BathRoom to the floor.");
                            floor.AddRoom(new Room { Name = "BathRoom", Floor = selectedFloor });
                            BathRoom++;
                            Room++;
                        }
                        else
                        {
                            Console.WriteLine("You cannot add anymore BathRooms to the floor");
                        }

                        break;
                    case "New Room" or "5":

                        if (Room < 5)
                        {
                            Console.WriteLine("What would you like the room name to be?");
                            var input1 = Console.ReadLine();
                            floor.AddRoom(new Room { Name = input1, Floor = selectedFloor });
                            CustomRoom++;
                            Room++;
                        }
                        else
                        {
                            Console.WriteLine("You Cant add anymore rooms");
                        }

                        break;
                    default:
                        Console.WriteLine($"invalid or house is done You have {Room} rooms.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect floor, or typed wrong");
            }
        }
    }
}
