int factorial=1;
            Console.WriteLine("=== FACTORIAL ===");
            Console.WriteLine("Selamat datang di factorial");
            Console.Write("Enter any Number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input==0)
            {
                factorial = 1;
                Console.Write($"Factorial of {input} is: {factorial}");
            }
            else
            {
                for(int i=1;i<=input;i++){
                    factorial = factorial * i;
                }
                Console.Write($"Factorial of {input} is: {factorial}");
            }