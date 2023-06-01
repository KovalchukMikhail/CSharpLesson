using System.Text;

namespace Polynomial.Creator
{
    public class PolynomialCreator
    {
        public int Degree { get; set; }
        public string Polynomial { get; private set; } = string.Empty;

        public PolynomialCreator(int degree)
        {
            Degree = degree;
        }
        public void CreatePolynomial(int minСoefficient = 0, int maxCoefficient = 100)
        {
            Random random = new Random();
            int currentDegree = Degree;
            StringBuilder stringBuilder = new StringBuilder();
            for (; currentDegree >= 0; currentDegree--)
            {
                stringBuilder.Append(CreatePartOfPolynimial(currentDegree, random.Next(minСoefficient, maxCoefficient + 1)));
            }
            Polynomial = stringBuilder.ToString();
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
            else
            {
                return result + $"{coefficient}*x^{currentDegree}";
            }
        }
    }
}