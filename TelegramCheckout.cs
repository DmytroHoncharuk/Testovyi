namespace testoveGit
{
    public class TelegramCheckout
    {
        public static void DeleteSymbol(ref string str1)//видалення @ у стрічці введення
        {
            char[] arr = str1.ToCharArray();
            for (int i = 0; i < 2; i++) //arr.length
            {
                if (arr[0] == '@')
                {
                    arr[0] = '\0';
                }
            }
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '\0')
                {
                    result += arr[i];
                }
            }
            str1 = result;
        }
    }
}
