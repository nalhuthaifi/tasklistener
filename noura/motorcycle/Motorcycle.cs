using System;
namespace noura
{
public abstract class Motorcycle : Vehicle , IVehicle
    {

        enum motorcycleTypes
        {

            Motor = 1,
            Bicycle = 2

        };


        public static IVehicle factory() {
            IVehicle vehicle = null;
            int counter= 0;


               Console.WriteLine("Which Type of Motorcycle you are looking for?");
               Console.WriteLine("1- Motor");
               Console.WriteLine("2- Bicycle");
                var userchoice = Console.ReadLine();
                int MotorcycleType;

                if (Int32.TryParse(userchoice, out MotorcycleType))
                {
                    switch (MotorcycleType)
                    {
                        case (int)motorcycleTypes.Motor:

                             vehicle = new Motor(1, 1, 1, 1, 20, 2, "4x4", "95");
                           
                        break;

                        case (int)motorcycleTypes.Bicycle:
                        vehicle = new Bicycle(1, 1, 1);
                            
                        break;
                    }
                return vehicle;

                }
            return vehicle;
        }

        public abstract void startService();
    }


}
