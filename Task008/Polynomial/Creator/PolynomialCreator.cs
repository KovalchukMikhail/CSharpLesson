using System.Text;

namespace Polynomial.Creator
{
    public class PolynomialCreator
    {
        public string Polynomial { get; private set; } = string.Empty;

        public void CreatePolynomial(int degree = 1, int minСoefficient = 0, int maxCoefficient = 100)
        {
            Random random = new Random();
            int currentDegree = degree;
            StringBuilder stringBuilder = new StringBuilder();
            for (; currentDegree >= 0; currentDegree--)
            {
                stringBuilder.Append(CreatePartOfPolynimial(currentDegree, random.Next(minСoefficient, maxCoefficient + 1)));
            }
            Polynomial = stringBuilder.ToString();
            if (Polynomial.StartsWith("+")) Polynomial = Polynomial.Remove(0, 1);
        }
        public void CreatePolynomialFromDict(Dictionary<int, int> dict)
        {
            string result = string.Empty;
            foreach (var item in dict)
            {
                if (item.Value != 0)
                {

                    if (item.Key == 0)
                    {
                        result = $"{item.Value}" + result;
                    }
                    else if (item.Key == 1 && item.Value == 1)
                    {
                        result = "x" + result;
                    }
                    else if (item.Key == 1 && item.Value == -1)
                    {
                        result = "-x" + result;
                    }
                    else if (item.Key == 1)
                    {
                        result = $"{item.Value}*x" + result;
                    }
                    else if (item.Value == 1)
                    {
                        result = $"x^{item.Key}" + result;
                    }
                    else if (item.Value == -1)
                    {
                        result = $"-x^{item.Key}" + result;
                    }
                    else
                    {
                        result = $"{item.Value}*x^{item.Key}" + result;
                    }
                    if (item.Value > 0)
                    {
                        result = "+" + result;
                    }
                }
            }
            Polynomial = result;
            if (Polynomial.StartsWith("+")) Polynomial = Polynomial.Remove(0, 1);
        }
        private string CreatePartOfPolynimial(int currentDegree, int coefficient)
        {
            string result = string.Empty;
            if (coefficient == 0) return result;
            else if (coefficient > 0) result = "+";
            else
            {
                result = "-";
                coefficient = Math.Abs(coefficient);
            }

            if (coefficient == 1 && currentDegree > 1)
            {
                return result + $"x^{currentDegree}";
            }
            else if (coefficient == 1 && currentDegree == 1)
            {
                return result + $"x";
            }
            else if (coefficient > 1 && currentDegree == 0)
            {
                return result + $"{coefficient}";
            }
            else if (coefficient > 1 && currentDegree == 1)
            {
                return result + $"{coefficient}*x";
            }
            else
            {
                return result + $"{coefficient}*x^{currentDegree}";
            }
        }
    }
}