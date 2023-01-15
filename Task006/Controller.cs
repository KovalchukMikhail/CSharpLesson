using Interfaces;

namespace Task006;


public class Controller{
        Model model;
        IView view;
        IWorkerWithFile file;

    public Controller(Model model, IView view, IWorkerWithFile file){
        this.model = model;
        this.view = view;
        this.file = file;
    }


    public void Start(){
        string question = "введите адрес файла";
        while(true){
            view.ShowText(question);
        }
    }


}