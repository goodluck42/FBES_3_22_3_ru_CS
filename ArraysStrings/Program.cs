using System.Text;

//int version = 20;

//string s = $"   C++{version}";
//string str = "C++" + 20;

//Console.WriteLine(s.Contains("C++"));

//string newStr = s.TrimStart();


// s.IndexOf("C++");

//Console.WriteLine("--------------");
//Console.WriteLine(str[^1]);
//Console.WriteLine(str[0..3]);
//Console.WriteLine("--------------");

//Console.WriteLine(newStr);
//Console.WriteLine(s);
//Console.WriteLine(str);

//Console.WriteLine(f"{}");

//Console.WriteLine("--------------");
//////////////////////

//string file = "homework.txt";
//string rawStr = $@"C:\Users\skiba_al\Desktop\{file}";

//Console.WriteLine(rawStr);
//////////////////////

//Random random = new Random();

//string password = string.Empty;

//for (int i = 0; i < 12; i++)
//{
//    int isDigit = random.Next(0, 2);
//    char c;


//    if (isDigit == 1)
//    {
//        c = (char)random.Next(48, 57 + 1);
//    }
//    else
//    {
//        c = (char)random.Next(97, 122 + 1);
//    }

//    password += c;
//}

//Console.WriteLine(password);

//////////////////////////////

// using PNSE = System.PlatformNotSupportedException;

///Random random = new Random();
var random = new Random();
var passwordBuilder = new StringBuilder();

for (int i = 0; i < 12; i++)
{
    int isDigit = random.Next(0, 2);
    char c;

    if (isDigit == 1)
    {
        c = (char)random.Next(48, 57 + 1);
    }
    else
    {
        c = (char)random.Next(97, 122 + 1);
    }

    passwordBuilder.Append(c);
}

string password = passwordBuilder.ToString();

Console.WriteLine(password);
