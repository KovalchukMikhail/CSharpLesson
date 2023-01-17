using Interfaces;

namespace Task006;

public class View : IView
{
    public void ShowError()
    {
        Console.WriteLine("Вы ввели некоректные данные");
    }

    public void ShowText(string text)
    {
        Console.WriteLine(text);
    }
}