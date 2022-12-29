using Model;
using View;

namespace Task003;

public class Controller{
    public static void Run(){
        Steps step = new Steps();
        Demonstrator demonstrator = new Demonstrator();
        string error = "Вы ввели некоректные данные";
        int countElements = GetNum(demonstrator, Menu.menuFirst, 0, error);
        int startTower = GetNum(demonstrator, Menu.menuSecond, 0, error, 4);
        int finishTower = GetNum(demonstrator, Menu.menuThird, 0, error, 4, startTower);
        int tempTower = 1;
        for (int i = 1; i < 4; i++){
            if(i != startTower && i != finishTower){
                tempTower = i;
                break;
            }
        }
        step.DoStep(startTower, finishTower, tempTower, countElements);
        Console.WriteLine(step.way);
    }
    
    public static int GetNum(Demonstrator demonstrator, string request, int min, string error, int max = 0, int errorNum = 0){
        int temp;
        Receiver reseiver = new Receiver();
        while(true){
            demonstrator.ShowText(request);
            try
            {
                temp = reseiver.inputInt();
                if(temp > min && (temp < max || max == 0) && temp != errorNum) return temp;
                demonstrator.ShowText(error);
            }
            catch (System.Exception)
            {
                demonstrator.ShowText(error);
            }
        }

    }
}
