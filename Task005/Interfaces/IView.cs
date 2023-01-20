namespace Interfaces;

public interface IView{
    public void ShowText(string text);

    public void ShowError();

    public string InputString();

    public void ShowArray(int [] array);
}