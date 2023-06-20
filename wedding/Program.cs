namespace wedding
{
    internal class Program<T>
    {
        static void Main(string[] args)
        {
            Person<string> Odil = new Person<string>("Odil", false);
        }
        public class Person<T>
        {
            public Person(T name):this(name, false)
            {
                Name= name;
            }
            public Person(T name, bool uylandimi)
            {
                Name= name;
                IsMarried= uylandimi;
            }
            public Person(T name, bool isMarried, Person<T> pair)
            {
                Name= name;
                IsMarried= isMarried;
                if (isMarried)
                {
                    Pair = pair;
                }
                
            }
            public void Love(Person<T> second)
            {
                if (this.IsMarried==false && second.IsMarried==false)
                {
                    this.IsMarried = true;
                    this.Pair = second;
                    second.IsMarried = true;
                    second.Pair = this;
                }
                
            }
            public static void Marriage(Person<T> p1, Person<T> p2)
            {
                if (p1.IsMarried==false && p2.IsMarried==false)
                {
                    Console.WriteLine("Just Married");
                    p1.IsMarried = true;
                    p2.IsMarried = true;
                    p1.Pair = p2;
                    p2.Pair = p1;
                }
                else
                {
                    Console.WriteLine("Someone is cheating");
                }    
            }

            public T Name { get; set; }
            public bool IsMarried { get; set; }
            public Person<T> Pair { get; set; }
                
        }
    }
}