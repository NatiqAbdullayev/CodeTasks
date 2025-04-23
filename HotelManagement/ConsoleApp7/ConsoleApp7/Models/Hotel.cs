using ConsoleApp7.Expcetions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp7.Models;
//-Id
//- Name
//- Rooms List - içində Room obyektləri saxlayır və private-dır.
class Hotel
{
    private static int idCounter;
    public int Id { get; set; }
    public string Name { get; set; }
    private List<Room> Rooms { get; set; } = [];
    public static List<string> names { get; set; } = [];

    public Hotel(string name)
    {
        idCounter++;
        Id = idCounter;
        Name = name;
    }

    public override string ToString()
    {
        return $"Id:{Id}\nName:{Name}";
    }

    public void AddRoom(Room room)
    {
        if (room is null)
        {
            throw new RoomException("Room cannot be null");
        }

        Rooms.Add(room);
    }

    public void FindRoomByName(string name)
    {
        foreach (var item in Rooms)
        {
            if (item.Name.Equals(name))
            {
                Console.WriteLine(item);
            }
        }
    }
    public void FindRoomById(int id)
    {
        foreach (var item in Rooms)
        {
            if (item.Id == id)
            {
                Console.WriteLine(item);
            }
        }
    }
    public void FindRoomByPrice(int price)
    {
        foreach (var item in Rooms)
        {
            if (item.Price == price)
            {
                Console.WriteLine(item);
            }
        }
    }
    public void FindRoomByCapasity(int cap)
    {
        foreach (var item in Rooms)
        {
            if (item.PersonCapasity == cap)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void FindRoomByAviability(bool status)
    {
        foreach (var item in Rooms)
        {
            if (item.IsAviable == status)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void MakeReservation(int? roomId, int count)
    {
        if (roomId is null)
        {
            throw new NullReferenceException("Room id is null");
        }

        foreach (var item in Rooms)
        {
            if (item.Id == roomId)
            {
                if (item.IsAviable == false)
                {
                    throw new NotAvailableException("Room is not aviable yet");
                }
                else
                {
                    if (item.PersonCapasity < count)
                    {
                        throw new RoomException("Capasity is full");
                    }
                    else
                    {
                        item.PersonCapasity -= count;
                    }

                }
            }
        }
    }

    public void ShowAllRooms() {

        foreach (var item in Rooms)
        {
            Console.WriteLine(item);
        }
    }
}
