// Задано уравнение вида q + w = e, q, w, e >= 0. Некоторые цифры могут быть
// заменены знаком вопроса, например 2? + ?5 = 69. Требуется восстановить
// выражение до верного равенства. Предложить хотя бы одно решение или
// сообщить, что его нет

using Interfaces;

namespace Task006;

public class Program{
    public static void Main(){
        IWorkerWithFile file = new WorkerWithFile();
        Model model = new Model();
        IView view = new View();
        Path path = new Path();

        new Controller(model, view, file, path).Start();

    }
}
