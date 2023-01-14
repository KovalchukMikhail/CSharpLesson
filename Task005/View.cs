namespace Task005;

public class View{
    public void ShowText(string text) => Console.WriteLine(text);

    public void ShowError() => Console.WriteLine("Вы ввели некоректные данные");

    public string InputString() => Console.ReadLine();

    public void ShowArray(int [] array){
        foreach (int item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

}