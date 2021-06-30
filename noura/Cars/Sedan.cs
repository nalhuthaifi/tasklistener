


namespace noura
{
public class Sedan : Car , VehicleWithRoof

{













    bool Open=false;

        public override int KeyId { set; get; }
        public override int NumOfPassengers { set; get; }
        public override int NumOfDoors { set; get; }
        public override string WheelsPower { set; get; }
        public override string Fuel { set; get; }
        public override int Id { set; get; }
        public override int Color { set; get; }
        public override int SerialNumber { set; get; }
  

        public Sedan(int ID,int Color, int SerialNumber, int KeyId,int NumOfPassengers, int NumOfDoors, string WheelsPower, string Fuel){
        this.Id=ID;
        this.Color=Color;
        this.SerialNumber=SerialNumber;
        this.NumOfPassengers=NumOfPassengers;
        this.NumOfDoors=NumOfDoors;
        this.WheelsPower=WheelsPower;
        this.Fuel=Fuel;

        System.Console.WriteLine("Sedan istructor is called!");

    }



        public bool OpenRoof
        {
            get
            {
                if (!Open)
                {
                    System.Console.WriteLine($"Sedan roof is open");
                    Open = true;
                    return Open;
                }
                else
                {
                    System.Console.WriteLine($"Sedan roof is closed");
                    Open = false;
                    return Open;
                }
            }
        }

        public bool Flag { get; set; }


        public override void Switch()
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