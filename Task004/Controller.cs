namespace Task004;

public class Controller{
    Model model;
    IView view;

    public Controller(Model model, IView view){
        this.model = model;
        this.view = view;
    }

    public void Start(){
        int number = -1;
        string answer = "Для получения n-ого треугольного числа введите целое число n больше 0 или 0 для выхода";
        bool check = true;

        while(check){
            view.ShowText(answer);
            try
            {
                number = view.InputInt();
                if(number > 0) check = false;
                else if (number == 0) return;
                else view.ShowError();
            }
            catch (System.Exception)
            {
                view.ShowError();
            }
        }
        int result = model.GetTriangularNumber(number);
        view.ShowText($"{number}-ое треугольное число равно {result}");
    }
}