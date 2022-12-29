namespace Model;

public class Steps{
    public string way = string.Empty;
    public int step = 1;

    public void DoStep(int startTower, int necessaryTower, int tempTower, int countElements){
        if (countElements == 1)
        {
            way += $"{step++}: элемент размера {countElements} на ось {necessaryTower}\n";
            return;
        }
        DoStep(startTower, tempTower, necessaryTower, countElements - 1);
        way += $"{step++}: элемент размера {countElements} на ось {necessaryTower}\n";
        DoStep(tempTower, necessaryTower, startTower, countElements - 1);
    }
    
}