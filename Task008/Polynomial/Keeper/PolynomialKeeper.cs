namespace Polynomial.Keeper
{
    public class PolynomialKeeper
    {
        public bool Write(string path, string text, bool append)
        {
            try
            {
                using StreamWriter sw = new StreamWriter(path, append);
                sw.WriteLine(text);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
}

        public string Read(string path)
        {
            try
            {
                using StreamReader sr = new StreamReader(path);
                return sr.ReadToEnd();
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
    }
}