//Задана натуральная степень k. Сформировать случайным образом список
//коэффициентов многочлена и записать в файл многочлен
//степени k. *Пример: k = 2 => 2 * x^2 +4 * x + 5
//записать в файл два случайных многочлена
//получить сумму этих многочленов
// Сформировать файл содержащий сумму многочленов.

using Polynomial.Creator;
using Polynomial.Keeper;

namespace Polynomial.Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            PolynomialCreator polynomialCreator = new PolynomialCreator();
            
            polynomialCreator.CreatePolynomial(rnd.Next(0, 10), - 5, 5);
            string firstPol = polynomialCreator.Polynomial;
            polynomialCreator.CreatePolynomial(rnd.Next(0, 10), -5, 5);
            string secondPol = polynomialCreator.Polynomial;

            OperationsWithPolynomial operations = new OperationsWithPolynomial();
            Dictionary<int, int> sumAsDict = operations.GetSumPolinomialsAsDict(firstPol, secondPol);
            polynomialCreator.CreatePolynomialFromDict(sumAsDict);
            string resultPol = polynomialCreator.Polynomial;

            PolynomialKeeper polynomialKeeper = new PolynomialKeeper();
            polynomialKeeper.Write("../../../file.txt", firstPol, false);
            polynomialKeeper.Write("../../../file.txt", secondPol, true);
            polynomialKeeper.Write("../../../result.txt", resultPol, false);

            Console.WriteLine($"{firstPol}\n{secondPol}\n\n{resultPol}");
        }
    }
}