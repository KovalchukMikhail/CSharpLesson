using View;
using Model;

namespace Task002;

    public class Controller
    {
        public static void Run()
        {
            string pathOutput = "Data\\output.txt";
            string pathInput = "Data\\input.txt";
            string requestNumFirst = "Введите число которое необходимо преобразовать";
            string requestNumSecond = "Введите число которое должно получиться в результате преобразования";
            string error = "Вы ввели некорректные данные";
            Receiver receiver = new Receiver();
            MathOperations operations = new MathOperations();
            WorkWithFile file = new WorkWithFile();
            WorkWithString workWithStr = new WorkWithString();
            int numberFirst = GetNum(requestNumFirst, receiver, error);
            int numberSecond = GetNum(requestNumSecond, receiver, error);
            if(numberFirst > numberSecond){
                Demonstrator.ShowText(error);
                return;
            }
            Console.WriteLine($"{numberFirst} {numberSecond}");
            int[] values = workWithStr.InputValues(file.GetString(pathInput));
            long sumWays = operations.GetSumWays(numberFirst, numberSecond, values[0], values[1]);
            string exampleWay = (sumWays > 0) ? operations.GetWay(numberFirst, numberSecond, values[0], values[1]) : string.Empty;
            string result = workWithStr.getResultStr(sumWays, exampleWay);
            Demonstrator.ShowText(result);
            file.WriteText(pathOutput, result);          
        }

        public static int GetNum(String request, Receiver receiver, string error){
            int result;
            while(true){
                Demonstrator.ShowText(request);
                try
                {
                    result = receiver.inputInt();
                    if (result >= 0) return result;
                    Demonstrator.ShowText(error);
                }
                catch (System.Exception)
                {
                    Demonstrator.ShowText(error);
                }
            }
        }
    }


