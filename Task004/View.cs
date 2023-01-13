namespace Task004;

public class View : IView{

    public void ShowText(String text) => Console.WriteLine(text);


    public virtual void ShowError() => Console.WriteLine("Вы ввели некоректные данные");

    public int InputInt(){
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