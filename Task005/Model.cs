namespace Task005;

public class Model{
    View view = new View();
    public int [] CreateArray(int size, int min = 0, int max = 20){
        int [] array = new int [size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(min, max);
        }
        return array;
    }


    public int [] SortArray(int[] array){
        int size = array.Length;
        if(size == 1) return array;
        int half = size/2;
        int boundary = size - half;
        int [] arrayLeft = GetPartArray(array, 0, half);
        int [] arrayRight = GetPartArray(array, half, size);
        SortArray(arrayLeft);
        SortArray(arrayRight);
        for(int i = 0, j = 0, k = 0; i < size; i++){
            if(j == half){
                array[i] = arrayRight[k];
                k++;
            }else if (k == boundary){
                array[i] = arrayLeft[j];
                j++;
            }else if (arrayLeft[j] < arrayRight[k]){
                array[i] = arrayLeft[j];
                j++;
            }else{
                array[i] = arrayRight[k];
                k++;
            }
        }
        return array;
    }


    public int [] GetPartArray(int [] array, int startIndex, int finishIndex){
        int size = finishIndex - startIndex;
        int [] result = new int [size];
        for (int i = startIndex, j = 0; i < finishIndex; i++, j++)
        {
            result[j] = array[i];
        }
        return result;
    }
}