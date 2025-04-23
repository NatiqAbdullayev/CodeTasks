using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace ConsoleApp7.Models;

//- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Room obyekt yaradıldıqda avtomatik bir vahid artacaq.
//- Name
//- Price
//- PersonCapacity - otağın neçə nəfərlik olduğunu bildirir.
//- IsAvialable - otağın rezervasiya olunub olunmadığını göstərir, default olaraq true olmalıdır.

class Room
{
    public static int idCounter;
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int PersonCapasity { get; set; }
    public bool IsAviable { get; set; } = true;

    public Room(string name,int price,int capasity,bool aviable)
    {
        idCounter++;
        Id = idCounter;
        Name = name;
        Price = price;
        PersonCapasity = capasity;
        IsAviable = aviable;
    }



    public override string ToString()
    {
        return $"-----Id:{Id}\nName:{Name}\nPrice:{Price}\nPerson Capasity:{PersonCapasity}\nAviable status:{IsAviable}\n-----";
    }
}
