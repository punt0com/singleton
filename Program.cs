using System;

namespace SingletonExample
{
    class Program
    {

        public class Life
        {

          private static Life existance = new Life();
            private Life() { }

            public static Life begin
            {

                get { return existance; }
            }


            public void proofOfLife()
            {

                Console.WriteLine("It has begun");
            }

        }
        static void Main(string[] args)
        {

            Life being = Life.begin;
            being.proofOfLife();


            Life anotherBeing = Life.begin;
            being.proofOfLife();

            Life.begin.proofOfLife();

            Console.ReadLine();
            //las clases singleton no se pueden volver a inicializar
        }
    }
}
