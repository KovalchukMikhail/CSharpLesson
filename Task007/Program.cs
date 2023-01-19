// Реализовать волновой алгоритм

using Interfaces;

namespace Task007;

public class Program{
    public static void Main(){
        new Controller(new Model(), new View()).Start();

    }
}