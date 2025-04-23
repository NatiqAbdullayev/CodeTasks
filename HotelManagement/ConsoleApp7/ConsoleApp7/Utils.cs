using ConsoleApp7.Expcetions;
using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7;

public static class Utils
{

    private static List<Hotel> HotelList { get; set; } = [];

    public static void CreateHotel(string name)
    {


        foreach (var item in Hotel.names)
        {
            if (item.Equals(name))
            {
                throw new HotelException("This name is already taken");
            }
        }


        Hotel hotel = new Hotel(name);
        HotelList.Add(hotel);

    }

    public static void ShowAllHotels()
    {

        if (HotelList.Count == 0)
        {
            Console.WriteLine("There not found any hotel");
            return;
        }

        foreach (var item in HotelList)
        {
            Console.WriteLine(item);
        }
    }

    public static void PickHotel(string name)
    {
        bool isHave = false;
        foreach (var item in HotelList)
        {
            if (item.Name.Equals(name))
            {
                isHave = true;
                RoomService(item.Name);
            }
        }

        //if (isHave)
        //{
        //    RoomService("");
        //}
    }


    public static void RoomService(string hotelName)
    {

        Console.WriteLine("1.Room yarat\r\n2.Roomlari gor\r\n3.Rezervasya et\r\n4.Evvelki menuya qayit.\r\n0.Exit");
        string res = Console.ReadLine();
        bool status = true;
        do
        {
            switch (res)
            {
                case "1":

                    try
                    {
                        Console.WriteLine("Enter name,price,capasity,aviable status(0-false,1-true) :");
                        string name = Console.ReadLine();
                        int price = int.Parse(Console.ReadLine());
                        int cap = int.Parse(Console.ReadLine());
                        int aviable = int.Parse(Console.ReadLine());
                        Room room = new Room(name, price, cap, aviable == 1 ? true : false);
                        foreach (var item in HotelList)
                        {
                            if (item.Name.Equals(hotelName))
                            {
                                item.AddRoom(room);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }



                    break;
                case "2":
                    foreach (var item in HotelList)
                    {
                        if (item.Name.Equals(hotelName))
                        {
                            item.ShowAllRooms();
                        }
                    }
                    break;
                case "3":

                    try
                    {
                        Console.WriteLine("Ardicil olaraq room id ve capasity daxil et:");
                        int roomId = int.Parse(Console.ReadLine());
                        int cap = int.Parse(Console.ReadLine());

                        foreach (var item in HotelList)
                        {
                            if (item.Name.Equals(hotelName))
                            {
                                item.MakeReservation(roomId, cap);
                            }
                        }
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    break;
                case "4":
                    status = false;
                    break;
                default:
                    Console.WriteLine("yalnis secim");
                    break;
            }
        } while (status);


    }
}
