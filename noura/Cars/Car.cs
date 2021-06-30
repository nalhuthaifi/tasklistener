
using System;

namespace noura
{
    public enum carTypes
    {
        Bus = 1,
        Sedan = 2,
        SUV = 3,
        Truck = 4
    };
    public abstract class Car : Vehicle , IVehicle
{
        public  static IVehicle factory()
        {
            IVehicle vehicle = null;
            int counter = 0;


            Console.WriteLine("Which Type of cars you are looking for?");
            Console.WriteLine("1- Bus");
            Console.WriteLine("2- Sedan");
            Console.WriteLine("3- SUV");
            Console.WriteLine("4- Truck");
            var userchoice = Console.ReadLine();
            int CarType;

            if (Int32.TryParse(userchoice, out CarType))
            {
                switch (CarType)
                {
                    case (int)carTypes.Bus:

                        vehicle = new Bus(1, 1, 1, 1, 20, 2, "4x4", "91");
         
                        break;

                    case (int)carTypes.Sedan:
                        vehicle = new Sedan(1, 1, 1, 1, 20, 2, "4x4", "95");
                  
                        break;

                    case (int)carTypes.SUV:
                        vehicle = new SUV(1, 1, 1, 1, 20, 2, "4x4", "95");
          
                        break;

                    case (int)carTypes.Truck:
                        vehicle = new Truck(1, 1, 1, 1, 20, 2, "4x4", "95", "2000 kg", 8);
           
                        break;

                }
                return vehicle;
            }
            else
            {
                Console.WriteLine("Wrong choice");
                if (counter < 3)
                {
                    counter++;
                    return factory();
                }
                else
                {
                    return vehicle;
                }
            }
        }



        public abstract int KeyId{
            set; get;
        }  
    public abstract int NumOfPassengers{
            set; get;
        }  
    public abstract int NumOfDoors{
            set; get;
        }
        public abstract string WheelsPower
        {

            set; get;
        }  
    public abstract string Fuel{
            set; get;
        }  
    public abstract void Switch();

        void IVehicle.startService()
        {
            Console.WriteLine("what action you want to be performed?");
            Console.WriteLine("1-   Switch (on/off)");
            Console.WriteLine("2-   move forward");
            Console.WriteLine("3-   Turn (right/left)");
            Console.WriteLine("4-   stop");
            Console.WriteLine("0-   Exit System");

            Int32 choice = 0;
            string direction;

            do
            {

                var input = Console.ReadLine();

                if (Int32.TryParse(input, out choice))
                {


                    if (choice == 1)
                    {
                        Switch();
                    }
                    else if (choice == 2)
                    {
                        MoveForward();
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("enter direction");
                        direction = Console.ReadLine();
                        Turn(direction);
                    }
                    else if (choice == 4)
                    {
                        Stop();
                    }

                    if (choice == 0)
                        break;
                }
                else { Console.WriteLine("PARSING ERROR"); }


            } while (true);
        }

        //   public abstract bool AirbagFacilition();
    }
}