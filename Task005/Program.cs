// Реализовать алгоритм сортировки слиянием
using Interfaces;

namespace Task005;

public class Program{
    public static void Main(){
        IModel model = new Model();
        IView view = new View();
        new Controller(model, view).Start();

    }
}
