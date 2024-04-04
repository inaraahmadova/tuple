namespace tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = A();
            Console.WriteLine(result.Item1);

            var result2 = B();
            Console.WriteLine(result2);

            var result3 = C();
            Console.WriteLine(result3.Item2);

        }
        

        static(int,string) A()
        {
            return (1, "salam");
        }

        static(int,int,int) B()
        {
            return (55, 66, 77);
        }

        static (int, bool, int ,string) C()
        {
            return (55, false, 77 ,"AzTU");
        }


    }
}
