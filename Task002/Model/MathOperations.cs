namespace Model;

public class MathOperations{
    public long GetSumWays(int numA, int numB, int numC, int numD){
        int size = numB + 1;
        long [] numbers = new long [size];
        numbers[numA] = 1;
        for (int i = numA + 1; i < size; i++)
        {
            if(i % numC == 0 && i / numC >= numA) numbers[i] += numbers[i / numC];
            if(i - numD >= numA) numbers[i] += numbers[i - numD];
        }
        return numbers[numB];
    }

    public string GetWay(int numA, int numB, int numC, int numD){
        string way = string.Empty;
        while(numA != numB){
            if(numB % numC == 0 && numB / numC <= numB - numD && numB / numC >= numA && GetSumWays(numA, (numB/numC), numC, numD) != 0){
                numB /= numC;
                way = $" (*{numC})" + way;
            }
            else if (numB - numD >= numA){
                numB -= numD;
                way = $" (+{numD})" + way;
            }
        }
        return way;
    }
}