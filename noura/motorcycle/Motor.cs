
using System;

namespace noura
{
    public class Motor : Motorcycle 
{
        public string Fuel;

        public override int Id { set; get; }
        public override int Color { set; get; }
        public override int SerialNumber { set; get; }
        public bool Flag { get; set; }

        public Motor(int ID,int Color, int SerialNumber, int KeyId,int NumOfPassengers, int NumOfDoors, string WheelsPower, string Fuel){

         
        this.Id=ID;
        this.Color=Color;
        this.SerialNumber=SerialNumber;
        this.Fuel=Fuel;

        System.Console.WriteLine("Motor istructor is called!");

    }


        public override void startService()
        {


            Int32 choice = 0;
            string direction;


            Console.WriteLine("what action you want to be performed?");
            Console.WriteLine("1-   Switch (on/off)");
            Console.WriteLine("2-   move forward");
            Console.WriteLine("3-   Turn (right/left)");
            Console.WriteLine("4-   Stop");
            Console.WriteLine("0-   Exit System");
            choice = Int32.Parse(Console.ReadLine());

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








        }

        public void Switch()
        {

            if (!Flag)
            {

                System.Console.WriteLine("switched on!");

                Flag = true;
            }
            else
            {

                System.Console.WriteLine("switched off!");

                Flag = false;

            }
        }

        public override void MoveForward()
        {

            if (Flag)
            {
                System.Console.WriteLine("Move Forward!");
            }
            else { System.Console.WriteLine("Bus is turned off"); }
        }

        public override void Turn(string Direction)
        {

            if (Flag)
            {
                System.Console.WriteLine($"Turn {Direction}!");
            }
            else { System.Console.WriteLine("Bus is turned off"); }

        }

        public override void Stop()
        {


            if (Flag)
            {
                System.Console.WriteLine("STOP!");
            }
            else { System.Console.WriteLine("Bus is turned off"); }

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}