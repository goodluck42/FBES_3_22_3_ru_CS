namespace Events
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }

    class Message
    {
        public string Text { get; set; } = null!;
        public User From { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }

    class Chat
    {
        private readonly List<Message> _messages;

        public Chat()
        {
            _messages = new();
        }

        public void SendMessage(Message message)
        {
            message.Timestamp = DateTime.Now;

            _messages.Add(message);

            MessageSent?.Invoke(message);
        }

        public event Action<Message> MessageSent;
    }

    delegate void OnWrite(string text);

    class Program
    {
        static void Main(string[] args)
        {
            // int? v = 10;
            //
            // int result = v ?? 5;
            //
            // Console.WriteLine(v ?? 5);


            // Delegate
            /*{
                OnWrite? method = null;

                var r = Console.ReadLine();

                if (r == "1")
                {
                    method = WriteToConsole;
                }

                if (r == "2")
                {
                    method = WriteToFile;
                }

                method?.Invoke($"{DateTime.Now}: Hello from Main");
                //method($"{DateTime.Now}: Hello from Main");
            }*/

            // Multicast Delegate
            /*{
                OnWrite? methods = null;

                DateTime now = DateTime.Now;

                methods += WriteToConsole;
                methods += WriteToFile;
                methods += (text) => Console.WriteLine($"{now}: Hello from lambda {text}");

                Console.WriteLine("Write to file?");

                var ask = Console.ReadLine()!;

                if (ask.ToUpper() == "N")
                {
                    methods -= WriteToFile;
                }

                methods?.Invoke($"{DateTime.Now}: Hello from Main");
            }*/

            // Action
            /*{
                Action<int, int> act = (a, b) =>
                {
                    Console.WriteLine(a + b);
                };

                act += (a, b) =>
                {
                    PrintMany(a, b, 1, 5, 6);
                };

                act(5, 2);

                Action<string> callback = text =>
                {
                    Console.WriteLine(text);
                };

                Action callback2 = () =>
                {
                    Console.WriteLine(nameof(callback2));
                };

                callback2();
            }*/

            // Predicate
            /*{
                var list = new List<int> { 1, 10, 20, 30 };

                //Predicate<int> pred = x => x == 20;

                //int? result = list.Find(pred);
                int? result = list.Find(x => x == 20);

                if (result != null)
                {
                    Console.WriteLine($"found value: {result}!");
                }
                else
                {
                    Console.WriteLine("Not found!");
                }
            }*/

            // Func
            /*{
                Func<int, int, int> sum = (a, b) =>
                {
                    return a + b;
                };

                Console.WriteLine(sum(10, 50));
            }*/

            // 
            {
                var chat = new Chat();

                chat.MessageSent += message =>
                {
                    Console.WriteLine($"[PC1] | {message.From.Name}: {message.Text}");
                };

                chat.MessageSent += message =>
                {
                    Console.WriteLine($"[PC2] | {message.From.Name}: {message.Text}");
                };
                
                var user1 = new User
                {
                    Id = 42,
                    Name = "Vladik"
                };

                while (true)
                {
                    var messageText = Console.ReadLine();

                    if (messageText == "0")
                    {
                        break;
                    }
                    
                    chat.SendMessage(new Message
                    {
                        From = user1,
                        Text = "Hello my friend!"
                    });
                }
            }
        }

        static void Find(Predicate<int> pred)
        {
        }

        static void WriteToConsole(string text)
        {
            Console.WriteLine(text);
        }

        static void WriteToFile(string text)
        {
            File.WriteAllText("file.txt", text);
        }

        static void PrintMany(params string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }

        static void PrintMany(params int[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}