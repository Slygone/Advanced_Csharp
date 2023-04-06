
namespace StaticClasses.Domain.Helpers
{
    public static class TextHelper
    {
        public static string ToCapitalFirstLetter(string word)
        {
            if(string.IsNullOrEmpty(word))
            {
                //if word is empty return empty string 
                return string.Empty;
            }
            else if(word.Length == 1)
            {
               return char.ToUpper(word[0]).ToString();
                //return word.ToUpper();
            }else
            {
                //return char.ToUpper(word[0]) + word.Substring(1).ToLower();
                return word.Substring(0,1).ToUpper() + word.Substring(1).ToLower();
            }
        }

        public static int ValidateNumberInput(string input) 
        {
            int choice = 0;
            bool sucess = int.TryParse(input, out choice);

            if(sucess)
            {
                return choice;
            }
            else
            {
                return -1;
            }
        }
    }
}
