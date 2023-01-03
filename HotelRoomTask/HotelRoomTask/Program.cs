
using HotelRoomTask.Models;
using HotelRoomTask.Services.Implimentation;
using HotelRoomTask.Services.Interfaces;

IRoomServices room = new RoomServices();

int secim;

try
{
do
{
    Console.WriteLine("Yeni Otaq Daxil Etmek Ucun 1-e Basin.");
    Console.WriteLine("Butun Otaqlara Baxmaq Ucun 2-e Basin");
    Console.WriteLine("Otaq Rezerv Etmek Ucun 3-e Basin");
    Console.WriteLine("Emeliyyati Dayandirmaq Ucun 4-e Basin");


secim= int.Parse(Console.ReadLine());

switch (secim)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Zehmet Olmasa Otaq Nomresini ve Qiymeti Daxil Edin : ");
        room.CreateNewRoom(int.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Otelimizdeki Butun Otaqlar");
        Room[] rooms=room.GetAllRooms();
        foreach (var item in rooms)
        {
          Console.WriteLine(item);
        }break;
        
    case 3:
        Console.Clear();
        Console.WriteLine("Rezerv Etmek Istediyiniz Otaqin Id-ni Daxil Edin");
        room.ReserveARoom(int.Parse(Console.ReadLine()));
        break;


    case 4:
            Console.WriteLine("Emeliyyat Dayandirildi!!!");
        return;

    default:
            Console.WriteLine("Duzgun Secim Daxil Edin!!!");
        break;
}
} while (secim!=4);
}
catch 
{
    Console.WriteLine("Xeta Bash Verdi!!!");
    
}


