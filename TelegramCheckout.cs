namespace testoveGit
{
    internal class TelegramCheckout
    {
        public static void CheckTelegramIdentity(ref string str1)//видалення @ у стрічці введення
        {
            char[] arr = str1.ToCharArray();
            for (int i = 0; i < 2; i++) //arr.length
            {
                if (arr[0] == '@')
                {
                    arr[0] = '\0';
                }
            }
        }
    }
}
