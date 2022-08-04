namespace Assignment.Model
{   

    public static class EncryptDecryptpassword
    {
        static readonly string Key = "bgbagf@@fxcb@";
        public static string ConvertToEncrypt(string password)
        {
            
            if (string.IsNullOrEmpty(password)) return "";
            password +=Key;
            var passwordBytes= System.Text.Encoding.UTF8.GetBytes(password);

            return Convert.ToBase64String(passwordBytes);
        }
        public static string ConvertToDecrypt(string base64Encodedpassword)
        {
           
            if (string.IsNullOrEmpty(base64Encodedpassword)) return "";
            var base64EncodeBytes=Convert.FromBase64String(base64Encodedpassword);
            var result = System.Text.Encoding.UTF8.GetString(base64EncodeBytes);
            result=result.Substring(0,result.Length-Key.Length);
            return result;
        }
    }
}
