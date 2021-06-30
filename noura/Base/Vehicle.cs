namespace noura
{
   public abstract class Vehicle //base class
{
    public abstract int Id{

            set; get;
        }  
    public abstract int Color{

            set; get;
        }  
    public abstract int SerialNumber{

            set; get;
        }


    public abstract void MoveForward();
    public abstract void Turn(string Direction);
    public abstract void Stop();

}
}