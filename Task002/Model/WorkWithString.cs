namespace Model;

public class WorkWithString{
    public int[] InputValues(string str){
        int [] values = new int [2];
        foreach(string temp in str.Split("\n")){
            if(temp.StartsWith("c")) values[0] = Convert.ToInt32(temp.Split(" ")[1]);
            if(temp.StartsWith("d")) values[1] = Convert.ToInt32(temp.Split(" ")[1]);
        }
        return values;
    }

    public string getResultStr(long sumWays, string exampleWay) =>
            (exampleWay != "") ? $"Количкство решений: {sumWays}\nВариант пути:\n{exampleWay}" : $"Количкство решений: {sumWays}";
}