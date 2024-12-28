using System;

namespace homeDevice
{
    public class HomeDevice
    {
        private string DeviceName;
        protected int EnergyConsumption;
        private bool IsOn;

        
        public HomeDevice(string deviceName, int energyConsumption)
        {
            this.DeviceName = deviceName;
            this.EnergyConsumption = energyConsumption;
            this.IsOn = false; 
        }

        
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine(DeviceName + " кор карда истодааст.");
        }

        
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine(DeviceName + " хомуш аст.");
        }

        
        public void SetEnergy(int value)
        {
            EnergyConsumption = value;
            Console.WriteLine(DeviceName + " сарф мекунад " + EnergyConsumption + " Вт.");
        }

        
        public void Run()
        {
            Console.WriteLine("Дастгох: " + DeviceName + ", сарфи кувва: " + EnergyConsumption + " Вт, holat: " + IsOn );
        }
    }



}    