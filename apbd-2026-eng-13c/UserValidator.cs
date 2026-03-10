namespace apbd_2026_eng_13c;

public class UserValidator
{
    public static string usernameValidator(string username)
    {
        if (string.IsNullOrEmpty(username)) throw new ArgumentException("username cannot be null or empty");
        if (username.Length < 8) throw new ArgumentException("username too short");
        else return "Hello " + username;
    }
}