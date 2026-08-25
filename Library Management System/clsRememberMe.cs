using System.IO;

public static class clsRememberMe
{
    private static string FilePath = @"C:\Users\2025\Desktop\RememberMe.txt";

    public static void Save(string UserName, string Password)
    {
        File.WriteAllText(FilePath, UserName + "\n" + Password);
    }

    public static string[] Load()
    {
        if (!File.Exists(FilePath))
            return null;

        return File.ReadAllLines(FilePath);
    }

    public static void Delete()
    {
        if (File.Exists(FilePath))
            File.Delete(FilePath);
    }
}