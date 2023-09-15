namespace HelpersForUnitTestDemo
{
    public class StringHelper
    {
        public static string FazlaBosluklariSil(string ifade)
        {
            ifade = ifade.Trim();
            string newIfade = string.Empty;
            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == ' ' && ifade[i + 1] == ' ')
                {
                    continue;
                }

                newIfade += ifade[i];
            }
            return newIfade;
        }
    }
}
