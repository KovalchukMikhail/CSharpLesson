using Interfaces;

namespace Task007;

public class Controller{
    IModel model;
    IView view;

    public Controller(IModel model, IView view)
    {
        this.model = model;
        this.view = view;
    }

    public void Start(){
        
    }
}