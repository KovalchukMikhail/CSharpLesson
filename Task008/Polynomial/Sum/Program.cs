using Polynomial.Creator;
using Polynomial.Keeper;

namespace Polynomial.Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PolynomialCreator polynomialCreator = new PolynomialCreator(5);
            PolynomialKeeper polynomialKeeper = new PolynomialKeeper();
            polynomialCreator.CreatePolynomial(-5, 5);
            polynomialKeeper.Write("../../../ghbdtn/file.txt", polynomialCreator.Polynomial, false);
            polynomialCreator.CreatePolynomial(-5, 5);
            polynomialKeeper.Write("../../../ghbdtn/file.txt", polynomialCreator.Polynomial, true);

        }
    }
}