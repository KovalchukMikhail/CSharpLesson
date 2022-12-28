namespace Model;

public class Receiver{
    public int inputInt(){
        while(true){
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
}