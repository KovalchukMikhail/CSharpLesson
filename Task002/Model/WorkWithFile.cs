namespace Model;

public class WorkWithFile{
    public string GetString(string path){
        string result = string.Empty;
        using (StreamReader reader = new StreamReader(path)){
            string? line = string.Empty;
            while((line = reader.ReadLine()) != null){
                if(line.StartsWith("c") || line.StartsWith("d")) result += $"{line}\n";
            }
        }
        return result;
    }

    public void WriteText(string path, string text){
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.Write(text);
        }
    }
}