namespace Proyecto.CodeQR
{
    public static class CodeQR
    {
        public static string GetCode()
        {
            string result = default;

            Random numRam = new Random();
            result += numRam.Next(1000, 9999);

            return result;
        }
    }
}
