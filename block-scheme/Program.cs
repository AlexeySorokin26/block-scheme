namespace block_scheme
{
    using System;
    using System.Threading;
    using System.Collections.Generic;

    class Program
    {
        public class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }

            public User(string Login, string Name, bool IsPremium)
            {
                this.Login = Login;
                this.Name = Name;
                this.IsPremium = IsPremium;
            }

            static void ShowAds()
            {
                Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                Thread.Sleep(1000);

                Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                Thread.Sleep(2000);

                Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                Thread.Sleep(3000);
            }

            public void Greetings()
            {
                if (!IsPremium)
                    ShowAds();
                Console.WriteLine($"welcom {this.Name}");
            }

        }

        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User("a", "b", true),
                new User("a1", "b1", false)
            };

            users[0].Greetings();
            users[1].Greetings();
        }
    }
}
