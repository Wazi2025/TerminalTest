namespace TerminalTest;

class Program
{
    static void Main(string[] args)
    {
        string projectName = "ACME";
        string strDir = @"c:\Exercise\";
        string strFileName = @"\data.txt";
        string strRussian = @"\ru-RU";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        //Console.WriteLine(message);
        string strMessage = "View English output:";
        string strNewline = "\n";
        Console.WriteLine(strMessage + strNewline + $@"C:\Excercise\{projectName}{strFileName}");
        Console.WriteLine(strNewline + russianMessage + strNewline + $@"C:\Excercise\{projectName}{strRussian}{strFileName}");

        //string projectName = "ACME";
        //string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
        //Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

        //string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        //string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
        //Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
    }

}