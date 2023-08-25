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
//var random = new Random();
//var passwordBuilder = new StringBuilder();

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

//    passwordBuilder.Append(c);
//}

//string password = passwordBuilder.ToString();

//Console.WriteLine(password);
////////



//{
//    int[] arr = { 10, 20, 30 };
//    //int[] arr2 = new[] { 10, 20, 30 };
//    //int[] arr3 = new int[3] { 10, 20, 30 };

//    int lastIndex = arr.GetUpperBound(0);

//    Console.WriteLine(lastIndex);
//}

//{
//    string?[]? names = { "vadik", "vladik", null, "semen"};

//    foreach (var name in names)
//    {
//        var result = name?.Capitalize(); // null conditional

//        Console.WriteLine(result);
//    }
//}


/*{
    string? text = null;

    // text = text ?? "123";
    text ??= "123";

    Console.WriteLine(text ?? "Text is null!!!");

    //if (text == null)
    //{
    //    Console.WriteLine("Text is null!!!");
    //}
    //else
    //{
    //    Console.WriteLine(text);
    //}

}*/
////////////////////

//{
//    string?[]? names = { "vadik", "vladik", null, "semen" };

//    names[2] = "Egor";

//    Console.WriteLine($"Length = {names.Length}");
//    Console.WriteLine($"Rank = {names.Rank}");
//}

{
    //int[,] matrix = new int[,]
    //{
    //    { 10, 20, 30, 20 },
    //    { 90, 42, 36, 10 }
    //};

    //Console.WriteLine(matrix.GetLowerBound(0));
    //Console.WriteLine(matrix.GetLowerBound(1));

    //int rows = matrix.GetUpperBound(0) + 1;
    //int cols = matrix.GetUpperBound(1) + 1;

    //Console.WriteLine(rows);
    //Console.WriteLine(cols);

    //for (int i = 0; i < rows; ++i)
    //{
    //    for (int j = 0; j < cols; ++j)
    //    {
    //        matrix[i, j] *= 2;

    //        Console.Write($"{matrix[i, j]} ");
    //    }
    //    Console.WriteLine();
    //}
}

///////////////////////

{
    "Hello".ToCharArray();
    int[][] jagged = new int[][]
    {
        new int[] { 30, 42, 50 },
        new int[] { 90, 80 },
        new int[] { 90, 80, 70, 90, 100 }
    };


    for (int i = 0; i < jagged.Length; i++)
    {
        for (int j = 0; j < jagged[i].Length; j++)
        {
            Console.Write($"{jagged[i][j]} ");
        }
        Console.WriteLine();
    }




}


public static class StringExtensions
{
    public static string Capitalize(this string source)
    {
        return $"{char.ToUpper(source[0])}{source[1..]}";
    }
}