
namespace homeDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner a = new AirConditioner("Кондиционер", 1669,false);
            Heater h= new Heater("Гармидиханда", 999,true);
            a.Run();
            a.TurnOn();
            a.SetEnergy(2123);
            h.Run();
            h.TurnOff();
            h.SetEnergy(1007);
           
        }
       
   }
   
}

