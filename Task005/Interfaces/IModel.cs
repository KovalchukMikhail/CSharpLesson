namespace Interfaces;

public interface IModel{
    public int [] CreateArray(int size, int min = 0, int max = 20);
    public int [] SortArray(int[] array);
    public int [] GetPartArray(int [] array, int startIndex, int finishIndex);
}