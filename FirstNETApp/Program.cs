using System;

Person p1 = new Person();

p1.Age = 10; // Setter

Console.WriteLine(p1.Age); // Getter
 


//p1.Age = -10;
//p1.FirstName = "Semen";
//p1.LastName = "Petrovich";

//Console.WriteLine(p1.Age);
//Console.WriteLine(p1.FirstName);
//Console.WriteLine(p1.LastName);

//Console.WriteLine("Hello, World!"); // top level statements

//bool b = true; // System.Boolean
//byte bt = 1; // 0 - 255
//sbyte sbt = 2; // -128 - 127
//char c = 'й';
//char c1 = 'w';
//short s3 = 10;
//int i = 0; // System.Int32
//long l = 10L; // System.Int64
//ulong ul = 10UL; // System.UInt64
//float f = 10F; // 4 bytes // System.Half
//double d = 20.2; // 8 bytes // System.Double
//decimal dm = 20m; // 16 bytes // System.Decimal
//string str = "Hello C#";

//// char c3 = 90; // error

//Console.WriteLine(c);
//Console.WriteLine(c1);


// 1
//string? read = Console.ReadLine();

//try
//{
//    int result = int.Parse(read);
//    Console.WriteLine(result * 2);
//}
//catch (FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}

// 2

//string? read = Console.ReadLine();

//if (int.TryParse(read, out int value))
//{
//    Console.WriteLine(value * 2);
//}

// 3
//Console.WriteLine(0.1m + 0.2m);
//Console.WriteLine("Enter first number: ");
//string? input1 = Console.ReadLine();
//Console.WriteLine("Enter operator number: ");
//string? input2 = Console.ReadLine();
//Console.WriteLine("Enter second number: ");
//string? input3 = Console.ReadLine();

//if (input1 != null && input2 != null && input3 != null)
//{
//    float num1 = float.Parse(input1);
//    string op = input2;
//    float num2 = float.Parse(input3);

//    switch (op)
//    {
//        case "+":
//            Console.WriteLine(num1 + num2);
//            break;

//        case "-":
//            Console.WriteLine(num1 - num2);
//            break;
//        case "*":
//            Console.WriteLine(num1 * num2);
//            break;
//        case "/":
//            if (num2 != 0)
//            {
//                Console.WriteLine(num1 / num2);
//            }
//            else
//            {
//                Console.WriteLine("∞");
//            }
//            break;
//        case "++":
//            goto case "+";
//    }
//}
//else
//{
//    Console.WriteLine("Error");
//}


// ReferenceType (classes) (pass by reference) (in heap)
// ValueType (structs) (pass by copy) (in stack)

// string - reference type & immutable

class Person
{
    private int age; // field

    public int Age // property
    {
        get
        {
            Console.WriteLine("Getter called!");

            return age;
        }
        set
        {
            Console.WriteLine("Setter called!");
            if (value < 0)
            {
                age = 0;
            }
            else
            {
                age = value;
            }
        }
    }
    public string? FirstName { get; set; }  // auto property
    public string? LastName { get; set; } // auto property
}

