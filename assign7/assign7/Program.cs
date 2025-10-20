namespace assign7

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Calculator calc = new Calculator();
            Console.WriteLine("Addition of 2 integers: " + calc.Add(5, 10));
            Console.WriteLine("Addition of 3 integers: " + calc.Add(5, 10, 15));
            Console.WriteLine("Addition of 2 doubles: " + calc.Add(5.5, 10.3));
            */

            //2
            /*Rectangle rect1 = new Rectangle(10, 20);
            Rectangle rect2 = new Rectangle(15);
            Rectangle rect3 = new Rectangle();
            */

            //3
            /*Complex c1 = new Complex(10,20);
            Complex c2 = new Complex(40,30);
            Complex c3 = c1 + c2;
            Console.WriteLine(c3);
            */

            //4
            //a
            /*Employee emp = new Employee();
            emp.DisplayInfo();
            //b
            Manager mgr = new Manager();
            mgr.DisplayInfo();
            */

            //5
            //a
            /*Base basee = new Base();
            basee.DisplayMessage();
            //b
            Derived1 d = new Derived1();
            d.DisplayMessage();
            //c
            Derived2 derived2 = new Derived2();
            derived2.DisplayMessage();

            //over ride will use the virtual function from parent
            //new will hide the base method
            */

            //part 2

            //1
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);
            // Output: Hours: 1, Minutes: 0, Seconds: 0
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);
            // Output: Hours: 2, Minutes: 10, Seconds: 0
            Duration D4 = new Duration(666);
            Console.WriteLine(D4);
            Console.WriteLine("\n--- Operator Overloading Tests ---");
            // D3 = D1 + D2
            D3 = D1 + D2;
            Console.WriteLine($"D1 + D2 = {D3}");
            // D3 = D1 + 7800
            D3 = D1 + 7800;
            Console.WriteLine($"D1 + 7800 = {D3}");
            // D3 = 666 + D3
            D3 = 666 + D3;
            Console.WriteLine($"666 + D3 = {D3}");
            // D3 = ++D1 (Increase One Minute)
            D3 = ++D1;
            Console.WriteLine($"++D1 = {D3}");
            // D3 = --D2 (Decrease One Minute)
            D3 = --D2;
            Console.WriteLine($"--D2 = {D3}");
            // D1 = D1 - D2
            D1 = D1 - D2;
            Console.WriteLine($"D1 - D2 = {D1}");
            // Comparison operators
            if (D1 > D2)
                Console.WriteLine("D1 > D2 is true");
            if (D1 <= D2)
                Console.WriteLine("D1 <= D2 is true");
            if (D1)
                Console.WriteLine("D1 is non-zero");
            

        }
    }
}
