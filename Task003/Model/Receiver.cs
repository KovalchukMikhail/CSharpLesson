namespace Model;

public class Receiver{
    public int inputInt(){
        try
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception)
        {     
            throw;
        }
    }
}