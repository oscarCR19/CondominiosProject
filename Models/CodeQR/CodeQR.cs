namespace Proyecto.Models.CodeQR
{
    public class CodeQR
    {

        public int GetCode()
        {
            string? result = null;

            Random numRam = new Random();
            for (int i = 0; i < 4; i++)
            {
                int? num= numRam.Next(0, 9);
                if (result== null && num==0)
                {
                    result += numRam.Next(1, 9);
                }
                else
                {
                    result += numRam.Next(0, 9);
                }
                num = null;
                

            }
            return Convert.ToInt32(result);
        }

        public int GetCode2()
        {
            for(int i = 0; i < 20; i++)
            {
                int num = GetCode();
            }

            return 1;
        }

    }
}
