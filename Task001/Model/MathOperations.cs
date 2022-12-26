
namespace task001
{
    public class MathOperations{
        public int exponentiation (int num, int degree){
            if (degree == 0) return 1;
            if (degree == 1) return num;
            if (degree % 2 == 0) return exponentiation (num*num, degree>>1);
            else return num * exponentiation (num*num, (degree - 1)>>1);
        }
    }
}