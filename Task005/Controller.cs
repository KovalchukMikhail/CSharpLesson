using Interfaces;

namespace Task005;

public class Controller{
    private IModel model;
    private IView view;
    public Controller(IModel model, IView view){
        this.model = model;
        this.view = view;
    }

    public void Start(){
        string request = "Введити длину массива или n для выхода";
        int size = 0;
        while(true){
            view.ShowText(request);
            try
            {    
                string answer = view.InputString();
                if(answer == "n") return;
                if(size >= 0){ 
                    size = Convert.ToInt32(answer);
                    break;
                }
            }
            catch (System.Exception)
            {
                view.ShowError();
                continue;
            }
            view.ShowError();
        }
        int [] array = model.CreateArray(size);
        view.ShowText("Исходный массив:");
        view.ShowArray(array);
        int [] result = model.SortArray(array);
        view.ShowText("Отсортированный массив:");
        view.ShowArray(result);
       
    }
}