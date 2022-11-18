namespace Proyecto.Models.CodeQR
{
    public class CodeQR
    {

        public string GetCode()
        {
            string result = default;

            Random numRam = new Random();
            result += numRam.Next(1000, 9999);
                
                

            
            return result;
        }

       

    }
}
