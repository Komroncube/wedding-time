namespace wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class Person
        {
            public Person(string name):this(name, false)
            {
                Name= name;
            }
            public Person(string name, bool uylandimi)
            {
                Name= name;
                IsMarried= uylandimi;
            }
            public Person(string name, bool isMarried, Person pair)
            {
                Name= name;
                IsMarried= isMarried;
                if (isMarried)
                {
                    Pair = pair;
                }
                
            }
            public void Love(Person second)
            {
                if (this.IsMarried==false && second.IsMarried==false)
                {
                    this.IsMarried = true;
                    this.Pair = second;
                    second.IsMarried = true;
                    second.Pair = this;
                }
                
            }
            public static void Marriage(Person p1, Person p2)
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

            public string Name { get; set; }
            public bool IsMarried { get; set; }
            public Person Pair { get; set; }
                
        }
    }
}