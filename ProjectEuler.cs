using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ProjectEulerCSharp
{
    public static class ProjectEuler
    {
        // 1 - Multiples of 3 or 5 - COMPLETE
        public static void Exercise1()
        {
            int multiple_sum = 0;            
            for(int i = 1; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    multiple_sum += i;
                }
            }

            Console.WriteLine("multiple_sum = " + multiple_sum);       
        }

        // 2 - Even Fibonacci numbers - COMPLETE
        public static void Exercise2()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            // 2 + 3 = 5
            // 3 + 5 = 8
            List<int> even_fibonacci = new List<int>() { b };
            while(c < 4000000)
            {
                int d = b + c; // 2 + 3
                b = c;         // 3
                c = d;         // 5
                if(d % 2 == 0)
                {
                    even_fibonacci.Add(d);
                }
            }

            int sum = 0;
            even_fibonacci.ForEach(p => sum += p);
            Console.WriteLine("sum = " + sum); // 4613732
            even_fibonacci.ForEach(p => Console.WriteLine(p));
        }

        // 3 - Largest prime factor - COMPLETE
        public static void Exercise3()
        {
            long n = 600851475143;
            //long n = 13195;
            List<long> factors = new List<long>();
            long d = 2;
            while(n > 1)
            {
                while(n % d == 0)
                {
                    factors.Add(d);
                    n /= d;
                }
                d += 1;
            }

            factors.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("Largest prime factor = " + factors[factors.Count - 1]); // 6857
        }

        // 4 - Largest palindrome product - COMPLETE
        public static void Exercise4()
        {
            int largest_palindrome = 0;
            for(int i = 100; i <= 999; i++)
            {
                for(int j = 100; j <= 999; j++)
                {
                    int number = i * j;
                    string n = number.ToString();
                    string rev = "";
                    for(int k = n.Length - 1; k >= 0; k--)
                    {
                        rev += n[k];
                    }

                    if(n == rev && Convert.ToInt32(rev) > largest_palindrome)
                    {
                        largest_palindrome = Convert.ToInt32(rev);
                    }
                }
            }

            Console.WriteLine("Largest palindrome number = " + largest_palindrome);
        }

        // 5 - Smallest multiple - COMPLETE
        public static void Exercise5()
        {
            int spn = 0; // smallest positive number
            int n = 1;
            while(n >= 1)
            {
                int number = n * 20;
                int even_divisors = 0;
                for(int i = 1; i <= 20; i++)
                {
                    if(number % i == 0)
                    {
                        even_divisors += 1;
                    }
                }

                if(even_divisors == 20)
                {
                    spn = number;
                    break;
                }

                n++;
            }

            Console.WriteLine("smallest positive number = " + spn); // 232792560
        }

        // 6 - Sum square difference - COMPLETE
        public static void Exercise6()
        {
            double sum_square_natural_numbers = 0;
            double sum_natural_numbers = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum_square_natural_numbers += Math.Pow(i, 2);
                sum_natural_numbers += i;
            }

            sum_natural_numbers = Math.Pow(sum_natural_numbers, 2);
            double difference = sum_natural_numbers - sum_square_natural_numbers;
            Console.WriteLine("difference = " + difference);
        }

        // 7 - 100001st prime
        public static void Exercise7()
        {

        }

        // 8 - Largest product in a series - COMPLETE
        public static void Exercise8()
        {
            string number_1000_digits = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            BigInteger greatest_product = 1;

            for(int i = 12; i < number_1000_digits.Length; i++)
            {
                string thirteen_digits = number_1000_digits.Substring(i - 12, 13);
                BigInteger product = 1;
                foreach(var td in thirteen_digits)
                {
                    int digit = Convert.ToInt32(td.ToString());
                    product *= digit;
                }

                if(product > greatest_product)
                {
                    greatest_product = product;
                }
            }

            Console.WriteLine("Greatest product 13 adjacent digits = " + greatest_product); // 23514624000
        }

        // 9 - Special Pythagoreon triplet - COMPLETE
        public static void Exercise9()
        {
            int abc_product = 1;
            for(int a = 1; a <= 1000; a++)
            {
                for (int b = 1; b <= 1000; b++)
                {
                    for (int c = 1; c <= 1000; c++)
                    {
                        if(a < b && b < c && a < c)
                        {
                            double a2_plus_b2 = Math.Pow(a, 2) + Math.Pow(b, 2);
                            double c2 = Math.Pow(c, 2);
                            double abc = a + b + c;
                            if(a2_plus_b2 == c2 && a + b + c == 1000)
                            {
                                abc_product = a * b * c;
                                Console.WriteLine("a = " + a); // 200
                                Console.WriteLine("b = " + b); // 375
                                Console.WriteLine("c = " + c); // 425
                                break;
                            }
                        }

                    }
                }
            }

            Console.WriteLine("abc_product = " + abc_product); // 31875000
        }

        // 10 - Summation of primes
        public static void Exercise10()
        {

        }

        // 11 - Largest product in a grid
        public static void Exercise11()
        {
            int largest_product = 0;
            int[,] grid = new int[,] { 
                { 8, 2, 22, 97, 38, 15, 0, 4, 0, 75, 4, 5, 7, 78, 52, 12, 50, 77, 91, 8 }, 
                { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 4, 56, 62, 0 }, 
                { 81, 49, 31, 73, 55, 79, 14 ,29 ,93, 71, 40, 67, 53, 88, 30, 3, 49, 13, 36, 65 }, 
                { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24, 68, 56, 1, 32, 56, 71, 37, 2, 36, 91 }, 
                { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 }, 
                { 24, 47, 32, 60, 99, 03, 45, 2, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 }, 
                { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 }, 
                { 67, 26, 20, 68, 2, 62, 12, 20, 95, 63, 94, 39, 63, 8, 40, 91, 66, 49, 94, 21 }, 
                { 24, 55, 58, 5, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 }, 
                { 21, 36, 23, 9, 75, 0, 76, 44, 20, 45, 35, 14, 0, 61, 33, 97, 34, 31, 33, 95 }, 
                { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 3, 80, 4, 62, 16, 14, 09, 53, 56, 92 }, 
                { 16, 39, 5, 42, 96, 35, 31, 47, 55, 58, 88, 24, 0, 17, 54, 24, 36, 29, 85, 57 }, 
                { 86, 56, 0, 48, 35, 71, 89, 7, 5, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 }, 
                { 19, 80, 81, 68, 5, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 4, 89, 55, 40 }, 
                { 4, 52, 8, 83, 97, 35, 99, 16, 7, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 }, 
                { 88, 36, 68, 87, 57 ,62 ,20 ,72 ,3 ,46, 33, 67, 46 ,55, 12, 32, 63, 93, 53, 69 }, 
                { 4, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 8, 46, 29, 32, 40, 62, 76, 36 }, 
                { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 4, 36, 16 },
                { 20, 73, 35, 29, 78, 31, 90, 1, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 5, 54 },
                { 1, 70 ,54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 1 ,89, 19, 67, 48 } };
            //
            // DIAGONAL 1 - LEFT to RIGHT  [0,0] * [1,1] * [2,2] * [3,3] --> [0,1] * [1,2] * [2,3] * [3,4]
            for(int i = 0; i <= 16; i++)
            {
                for(int j = 0; j <= 16; j++)
                {
                    int product = grid[i, j] * grid[i + 1, j + 1] * grid[i + 2, j + 2] * grid[i + 3, j + 3];
                    if (product > largest_product)
                    {
                        largest_product = product; 
                    }
                }
            }

            // DIAGONAL 2 - RIGHT to LEFT   [0,19] * [1,18] * [2,17] * [3,16] --> [0,18] * [1,17] * [2,16] * [3,15]
            for(int i = 0; i <= 16; i++)
            {
                for(int j = 19; j >= 3; j--)
                {
                    int product = grid[i, j] * grid[i + 1, j - 1] * grid[i + 2, j - 2] * grid[i + 3, j - 3];
                    if (product > largest_product)
                    {
                        largest_product = product; // 51267216 --> 70600674
                    }
                }
            }
            // UP  [19,0] + [18,0] + [17,0] + [16,0]
            for (int i = 19; i >= 3; i--)
            {
                for(int j = 0; j <= 19; j++)
                {
                    int product = grid[i, j] * grid[i - 1, j] * grid[i - 2, j] * grid[i - 3, j];
                    if(product > largest_product)
                    {
                        largest_product = product;
                    }
                }
            }

            // DOWN
            /*
            for (int i = 0; i <= 16; i++)
            {
                for (int j = 0; j <= 19; j++)
                {
                    int product = grid[i, j] * grid[i + 1, j] * grid[i + 2, j] * grid[i + 3, j];
                    if (product > largest_product)
                    {
                        largest_product = product;
                    }
                }
            }
            */

            // LEFT
            for(int i = 0; i <= 19; i++)
            {
                for(int j = 3; j <= 19; j++)
                {
                    int product = grid[i, j] * grid[i, j - 1] * grid[i, j - 2] * grid[i, j - 3];
                    if (product > largest_product)
                    {
                        largest_product = product;
                    }
                }
            }

            // RIGHT
            for (int i = 0; i <= 19; i++)
            {
                for (int j = 19; j >= 3; j--)
                {
                    int product = grid[i, j] * grid[i, j - 1] * grid[i, j - 2] * grid[i, j - 3];
                    if (product > largest_product)
                    {
                        largest_product = product;
                    }
                }
            }

            Console.WriteLine("largest_product = " + largest_product);
        }

        // 12 - Highly divisible triangular number
        public static void Exercise12()
        {

        }

        // 13 - Large sum
        public static void Exercise13()
        {

        }

        // 14 - Longest Collatz sequence
        public static void Exercise14()
        {

        }

        // 15 - Lattice paths - COMPLETE
        public static void Exercise15()
        {
            // https://www.mathblog.dk/project-euler-15/
            // https://nl.wikipedia.org/wiki/Binomiaalco%C3%ABffici%C3%ABnt
            BigInteger k = 20;           // Length of grid
            BigInteger n = k * 2;        //
            BigInteger n_minus_k = n - k; //
            BigInteger factorial_n = 1;
            BigInteger factorial_k = 1;
            BigInteger factorial_n_minus_k = 1;

            for(BigInteger i = n; i >= 1; i--)
            {
                factorial_n *= i;
            }

            for (BigInteger j = k; j >= 1; j--)
            {
                factorial_k *= j;
            }

            for (BigInteger l = n_minus_k; l >= 1; l--)
            {
                factorial_n_minus_k *= l;
            }

            Console.WriteLine("factorial_n = " + factorial_n);
            Console.WriteLine("factorial_k = " + factorial_k);
            Console.WriteLine("factorial_n_minus_k = " + factorial_n_minus_k);
            BigInteger result = factorial_n / (factorial_k * factorial_n_minus_k);
            Console.WriteLine("result = " + result);
        }

        // 16 - Power digit sum - COMPLETE
        public static void Exercise16()
        {
            BigInteger k = 1;
            for(int i = 1; i <= 1000; i++)
            {
                k *= 2;
            }

            string kk = k.ToString();
            int digit_sum = 0;
            foreach(var kkk in kk)
            {
                digit_sum += Convert.ToInt32(kkk.ToString());
            }

            Console.WriteLine("digit_sum = " + digit_sum); // 1366

            //Console.WriteLine("k = " + k);
        }

        // 17 - Number letter counts
        public static void Exercise17()
        {

        }

        // 18 - Maximum path sum 1
        public static void Exercise18()
        {

        }

        // 19 - Counting Sundays
        public static void Exercise19()
        {

        }

        // 20 - Factorial digit sum - COMPLETE
        public static void Exercise20()
        {
            BigInteger i = 1;
            for(int j = 2; j <= 100; j++)
            {
                i *= j;
            }

            int digit_sum = 0;
            string ii = Convert.ToString(i);
            foreach(var iii in ii)
            {
                digit_sum += Convert.ToInt32(iii.ToString());
            }

            Console.WriteLine("digit_sum = " + digit_sum); // 648
            Console.WriteLine("i = " + i);
        }

        // 21 - Amicable numbers
        public static void Exercise21()
        {

        }

        // 22 - Names scores
        public static void Exercise22()
        {

        }

        // 23 - Non-abundant sums
        public static void Exercise23()
        {

        }

        // 24 - Lexicographic permutations
        public static void Exercise24()
        {

        }

        // 25 - 1000-digit Fibonacci number
        public static void Exercise25()
        {

        }

        // 26 - Reciprocal cycles
        public static void Exercise26()
        {

        }

        // 27 - Quadratic primes
        public static void Exercise27()
        {

        }

        // 28 -	Number spiral diagonals
        public static void Exercise28()
        {

        }

        // 29 -	Distinct powers - COMPLETE
        public static void Exercise29()
        {
            List<BigInteger> bi = new List<BigInteger>();
            for(int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    string c = Math.Pow(a, b).ToString();
                    Console.WriteLine("c = " + c);
                    //string c = (a ^ b).ToString();
                    //BigInteger d = BigInteger.Parse(c);
                    BigInteger result = 0;
                    for (int i = 0; i < c.Length; i++)
                    {
                        result = result * 10 + (c[i] - '0');
                    }

                    if (!bi.Contains(result))
                    {
                        bi.Add(result);
                    }
                }
            }

            bi.Sort();
            //bi.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("Amount of distinct terms in sequence = " + bi.Count);
        }

        // 30 - Digit fifth powers - COMPLETE
        public static void Exercise30()
        {
            double sum = 0;
            for(int i = 2; i <= 10000000; i++)
            {
                int digit_sum = 0;
                string ii = i.ToString();
                foreach(var iii in ii)
                {
                    digit_sum += Convert.ToInt32(Math.Pow(Convert.ToInt32(iii.ToString()), 5));
                }

                if(digit_sum == i)
                {
                    Console.WriteLine("i = " + i);
                    sum += digit_sum;
                }
            }
            Console.WriteLine("sum = " + sum); // 443839
        }

        // 31 - Coin sums - COMPLETE
        public static void Exercise31()
        {
            int two_pound    = 200 / 200; // 10
            int one_pound    = 200 / 100; // 20
            int fifty_pence  = 200 / 50;  // 4
            int twenty_pence = 200 / 20;  // 10
            int ten_pence    = 200 / 10;  // 20
            int five_pence   = 200 / 5;   // 40
            int two_pence    = 200 / 2;   // 100
            int one_pence    = 200 / 1;   // 200
            int different_ways = 0;
            for(int a = two_pound; a >= 0; a--)
            {
                for (int b = one_pound; b >= 0; b--)
                {
                    for (int c = fifty_pence; c >= 0; c--)
                    {
                        for (int d = twenty_pence; d >= 0; d--)
                        {
                            for (int e = ten_pence; e >= 0; e--)
                            {
                                for (int f = five_pence; f >= 0; f--)
                                {
                                    for (int g = two_pence; g >= 0; g--)
                                    {
                                        for (int h = one_pence; h >= 0; h--)
                                        {
                                            if(a * 200 + b * 100 + c * 50 + d * 20 + e * 10 + f * 5 + g * 2 + h * 1 == 200)
                                            {
                                                different_ways += 1; // 73682
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Amount of different ways to make 2 pounds = " + different_ways);
        }

        // 32 - Pandigital products
        public static void Exercise32()
        {

        }

        // 33 - Digit cancelling fractions
        public static void Exercise33()
        {

        }

        // 34 - Digit factorials
        public static void Exercise34()
        {

        }

        // 35 - Circular primes
        public static void Exercise35()
        {

        }

        // 36 - Double-base palindromes - COMPLETE
        public static void Exercise36()
        {
            BigInteger sum = 0;
            for(int i = 1; i <= 999999; i++)
            {
                string ii = i.ToString();
                string ii_rev = "";
                for(int j = ii.Length - 1; j >= 0; j--)
                {
                    ii_rev += ii[j];
                }

                string binary = Convert.ToString(i, 2);
                string binary_rev = "";
                for (int j = binary.Length - 1; j >= 0; j--)
                {
                    binary_rev += binary[j];
                }

                if (ii_rev == ii && binary == binary_rev)
                {
                    Console.WriteLine("i = " + i);
                    sum += i;
                }
            }
            //int i = 999999;
            //string binary = Convert.ToString(i, 2);
            //Console.WriteLine("binary = " + binary);
            Console.WriteLine("sum of all numbers less than 1 million = " + sum); // 872187
        }

        // 37 - Truncatable primes
        public static void Exercise37()
        {

        }

        // 38 - Pandigital multiples
        public static void Exercise38()
        {

        }

        // 39 - Integer right triangles
        public static void Exercise39()
        {

        }

        // 40 - Champernowne's constant
        public static void Exercise40()
        {

        }

        // 41 - Pandigital prime 
        public static void Exercise41()
        {

        }

        // 42 - Coded triangle numbers
        public static void Exercise42()
        {

        }

        // 43 - Sub-string divisibility
        public static void Exercise43()
        {

        }

        // 44 - Pentagon numbers
        public static void Exercise44()
        {

        }

        // 45 - Triangular, pentagonal, and hexagonal
        public static void Exercise45()
        {

        }

        // 46 - Goldbach's other conjecture
        public static void Exercise46()
        {

        }

        // 47 - Distinct primes factors
        public static void Exercise47()
        {

        }

        // 48 - Self powers - COMPLETE
        public static void Exercise48()
        {
            BigInteger sum = 0;
            for(int i = 1; i <= 1000; i++)
            {
                BigInteger s = i;
                BigInteger multiplier = i;
                for(int j = 1; j < i; j++)
                {
                    s *= multiplier;
                }

                //Console.WriteLine("s = " + s);
                sum += s;
            }

            string ss = sum.ToString();
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("last 10 digits of series = " + ss.Substring(ss.Length - 10,10)); // 9110846700
        }

        // 49 - Prime permutations
        public static void Exercise49()
        {

        }

        // 50 - Consecutive prime sum
        public static void Exercise50()
        {

        }

        // 51 - Prime digit replacements
        public static void Exercise51()
        {

        }

        // 52 - Permuted multiples
        public static void Exercise52()
        {

        }

        // 53 - Combinatoric selections
        public static void Exercise53()
        {
            int distinct_values = 0;
            for(int n = 1; n <= 100; n++)
            {
                for(int r = 1; r <= n; r++)
                {
                    int nn = n;
                    int rr = r;
                    BigInteger n_factorial = 1;
                    BigInteger r_factorial = 1;
                    BigInteger n_minus_r_factorial = 1;
                    int n_minus_r = n - r;
                    if(n_minus_r == 0) { n_minus_r = 1; }

                    for(int nnn = nn; nnn >= 1; nnn--)
                    {
                        n_factorial *= nnn;
                    }

                    for (int rrr = rr; rrr >= 1; rrr--)
                    {
                        r_factorial *= rrr;
                    }

                    for (int nmr = n_minus_r; nmr >= 1; nmr--)
                    {
                        n_minus_r_factorial *= nmr;
                    }

                    BigInteger combinations = n_factorial / (r_factorial * n_minus_r_factorial);
                    if(combinations > 1000000)
                    {
                        distinct_values += 1;
                    }
                }
            }

            Console.WriteLine("Distinct values greater than one-million = " + distinct_values); // 4075
        }

        // 54 - Poker hands
        public static void Exercise54()
        {

        }

        // 55 - Lychrel numbers
        public static void Exercise55()
        {

        }

        // 56 - Powerful digit sum
        public static void Exercise56()
        {

        }

        // 57 - Square root convergents
        public static void Exercise57()
        {

        }

        // 58 - Spiral primes
        public static void Exercise58()
        {

        }

        // 59 - XOR decryption
        public static void Exercise59()
        {

        }

        // 60 - Prime pair sets
        public static void Exercise60()
        {

        }

        // 61 - Cyclical figurate numbers
        public static void Exercise61()
        {

        }

        // 62 - Cubic permutations
        public static void Exercise62()
        {

        }

        // 63 - Powerful digit counts
        public static void Exercise63()
        {

        }

        // 64 - Odd period square roots
        public static void Exercise64()
        {

        }

        // 65 - Convergents of e
        public static void Exercise65()
        {

        }

        // 66 -	Diophantine equation
        public static void Exercise66()
        {

        }

        // 67 - Maximum path sum II
        public static void Exercise67()
        {

        }

        // 68 - Magic 5-gon ring
        public static void Exercise68()
        {

        }

        // 69 - Totient maximum
        public static void Exercise69()
        {

        }

        // 70 - Totient permutation
        public static void Exercise70()
        {

        }

        // 71 - Ordered fractions
        public static void Exercise71()
        {

        }

        // 72 - Counting fractions
        public static void Exercise72()
        {

        }

        // 73 - Counting fractions in a range
        public static void Exercise73()
        {

        }

        // 74 - Digit factorial chains
        public static void Exercise74()
        {

        }

        // 75 - Singular integer right triangles
        public static void Exercise75()
        {

        }

        // 76 - Counting summations
        public static void Exercise76()
        {

        }

        // 77 - Prime summations
        public static void Exercise77()
        {

        }

        // 78 -	Coin partitions
        public static void Exercise78()
        {

        }

        // 79 - Passcode derivation
        public static void Exercise79()
        {

        }

        // 80 - Square root digital expansion
        public static void Exercise80()
        {

        }

        // 81 - Path sum: two ways
        public static void Exercise81()
        {

        }

        // 82 - Path sum: three ways
        public static void Exercise82()
        {

        }

        // 83 - Path sum: four ways
        public static void Exercise83()
        {

        }

        // 84 -	Monopoly odds
        public static void Exercise84()
        {

        }

        // 85 - Counting rectangles
        public static void Exercise85()
        {

        }

        // 86 - Cuboid route
        public static void Exercise86()
        {

        }

        // 87 - Prime power triples
        public static void Exercise87()
        {

        }

        // 88 - Product-sum numbers
        public static void Exercise88()
        {

        }

        // 89 - Roman numerals
        public static void Exercise89()
        {

        }

        // 90 - Cube digit pairs
        public static void Exercise90()
        {

        }

        // 91 - Right triangles with integer coordinates
        public static void Exercise91()
        {

        }

        // 92 -	Square digit chains
        public static void Exercise92()
        {

        }

        // 93 -	Arithmetic expressions
        public static void Exercise93()
        {

        }

        // 94 - Almost equilateral triangles
        public static void Exercise94()
        {

        }

        // 95 - Amicable chains
        public static void Exercise95()
        {

        }

        // 96 - Su Doku
        public static void Exercise96()
        {

        }

        // 97 -	Large non-Mersenne prime
        public static void Exercise97()
        {

        }

        // 98 - Anagramic squares
        public static void Exercise98()
        {

        }

        // 99 - Largest exponential
        public static void Exercise99()
        {

        }

        // 100 - Arranged probability
        public static void Exercise100()
        {

        }

        // 101 - Optimum polynomial
        public static void Exercise101()
        {

        }

        // 102 - Triangle containment
        public static void Exercise102()
        {

        }

        // 103 - Special subset sums: optimum
        public static void Exercise103()
        {

        }

        // 104 - Pandigital Fibonacci ends
        public static void Exercise104()
        {


        }

        // 105 - Special subset sums: testing
        public static void Exercise105()
        {

        }

        // 106 - Special subset sums: meta-testing
        public static void Exercise106()
        {

        }

        // 107 - Minimal network
        public static void Exercise107()
        {

        }

        // 108 - Diophantine reciprocals I
        public static void Exercise108()
        {

        }

        // 109 - Darts
        public static void Exercise109()
        {

        }

        // 110 - Diophantine reciprocals II
        public static void Exercise110()
        {

        }

        // 111 - Primes with runs
        public static void Exercise111()
        {

        }

        // 112 - Bouncy numbers
        public static void Exercise112()
        {

        }

        // 113 - Non-bouncy numbers
        public static void Exercise113()
        {

        }

        // 114 - Counting block combinations I
        public static void Exercise114()
        {

        }

        // 115 - Counting block combinations II
        public static void Exercise115()
        {

        }

        // 116 - Red, green or blue tiles
        public static void Exercise116()
        {

        }

        // 117 - Red, green, and blue tiles
        public static void Exercise117()
        {

        }

        // 118 - Pandigital prime sets
        public static void Exercise118()
        {

        }

        // 119 - Digit power sum
        public static void Exercise119()
        {

        }

        // 120 - Square remainders
        public static void Exercise120()
        {

        }

        // 121 - Disc game prize fund
        public static void Exercise121()
        {

        }

        // 122 - Efficient exponentiation
        public static void Exercise122()
        {

        }

        // 123 - Prime square remainders
        public static void Exercise123()
        {

        }

        // 124 - Ordered radicals
        public static void Exercise124()
        {

        }

        // 125 - Palindromic sums
        public static void Exercise125()
        {

        }

        // 126 - Cuboid layers
        public static void Exercise126()
        {

        }

        // 127 - abc-hits
        public static void Exercise127()
        {

        }

        // 128 - Hexagonal tile differences
        public static void Exercise128()
        {

        }

        // 129 - Repunit divisibility
        public static void Exercise129()
        {

        }

        // 130 - Composites with prime repunit property
        public static void Exercise130()
        {

        }

        // 131 - Prime cube partnership
        public static void Exercise131()
        {

        }

        // 132 - Large repunit factors
        public static void Exercise132()
        {

        }

        // 133 - Repunit nonfactors
        public static void Exercise133()
        {

        }

        // 134 - Prime pair connection
        public static void Exercise134()
        {

        }

        // 135 - Same differences
        public static void Exercise135()
        {

        }

        // 136 - Singleton difference
        public static void Exercise136()
        {

        }

        // 137 - Fibonacci golden nuggets
        public static void Exercise137()
        {

        }

        // 138 - Special isosceles triangles
        public static void Exercise138()
        {

        }

        // 139 - Pythagorean tiles
        public static void Exercise139()
        {

        }

        // 140 - Modified Fibonacci golden nuggets
        public static void Exercise140()
        {

        }

        // 141 - Investigating progressive numbers, n, which are also square
        public static void Exercise141()
        {

        }

        // 142 - Perfect Square Collection
        public static void Exercise142()
        {

        }

        // 143 - Investigating the Torricelli point of a triangle
        public static void Exercise143()
        {

        }

        // 144 - Investigating multiple reflections of a laser beam
        public static void Exercise144()
        {

        }

        // 145 - How many reversible numbers are there below one-billion?
        public static void Exercise145()
        {

        }

        // 146 - Investigating a Prime Pattern
        public static void Exercise146()
        {

        }

        // 147 - Rectangles in cross-hatched grids
        public static void Exercise147()
        {

        }

        // 148 - Exploring Pascal's triangle
        public static void Exercise148()
        {

        }

        // 149 - Searching for a maximum-sum subsequence
        public static void Exercise149()
        {

        }

        // 150 - Searching a triangular array for a sub-triangle having minimum-sum
        public static void Exercise150()
        {

        }

        // 151 - Paper sheets of standard sizes: an expected-value problem
        public static void Exercise151()
        {

        }

        // 152 - Writing 1/2 as a sum of inverse squares
        public static void Exercise152()
        {

        }

        // 153 - Investigating Gaussian Integers
        public static void Exercise153()
        {

        }

        // 154 - Exploring Pascal's pyramid
        public static void Exercise154()
        {

        }

        // 155 - Counting Capacitor Circuits
        public static void Exercise155()
        {

        }

        // 156 - Counting Digits
        public static void Exercise156()
        {

        }

        // 157 - Solving the diophantine equation 1/a+1/b= p/10n
        public static void Exercise157()
        {

        }

        // 158 - Exploring strings for which only one character comes lexicographically after its neighbour to the left
        public static void Exercise158()
        {

        }

        // 159 - Digital root sums of factorisations
        public static void Exercise159()
        {

        }

        // 160 - Factorial trailing digits
        public static void Exercise160()
        {

        }

        // 161 - Triominoes
        public static void Exercise161()
        {

        }

        // 162 - Hexadecimal numbers
        public static void Exercise162()
        {

        }

        // 163 - Cross-hatched triangles
        public static void Exercise163()
        {

        }

        // 164 - Numbers for which no three consecutive digits have a sum greater than a given value
        public static void Exercise164()
        {

        }

        // 165 - Intersections
        public static void Exercise165()
        {

        }

        // 166 - Criss Cross
        public static void Exercise166()
        {

        }

        // 167 - Investigating Ulam sequences
        public static void Exercise167()
        {

        }

        // 168 - Number Rotations
        public static void Exercise168()
        {

        }

        // 169 - Exploring the number of different ways a number can be expressed as a sum of powers of 2
        public static void Exercise169()
        {

        }

        // 170 - Find the largest 0 to 9 pandigital that can be formed by concatenating products
        public static void Exercise170()
        {

        }

        // 171 - Finding numbers for which the sum of the squares of the digits is a square
        public static void Exercise171()
        {

        }

        // 172 - nvestigating numbers with few repeated digits
        public static void Exercise172()
        {

        }

        // 173 - Using up to one million tiles how many different "hollow" square laminae can be formed?
        public static void Exercise173()
        {

        }

        // 174 - Counting the number of "hollow" square laminae that can form one, two, three, ... distinct arrangements
        public static void Exercise174()
        {

        }

        // 175 - Fractions involving the number of different ways a number can be expressed as a sum of powers of 2
        public static void Exercise175()
        {

        }

        // 176 - Right-angled triangles that share a cathetus
        public static void Exercise176()
        {

        }

        // 177 - Integer angled Quadrilaterals
        public static void Exercise177()
        {

        }

        // 178 - Step Numbers
        public static void Exercise178()
        {

        }

        // 179 - Consecutive positive divisors
        public static void Exercise179()
        {

        }

        // 180 - Rational zeros of a function of three variables
        public static void Exercise180()
        {

        }

        // 181 - Investigating in how many ways objects of two different colours can be grouped
        public static void Exercise181()
        {

        }

        // 182 - RSA encryption
        public static void Exercise182()
        {

        }

        // 183 - Maximum product of parts
        public static void Exercise183()
        {

        }

        // 184 - Triangles containing the origin
        public static void Exercise184()
        {

        }

        // 185 - Number Mind
        public static void Exercise185()
        {

        }

        // 186 - Connectedness of a network
        public static void Exercise186()
        {

        }

        // 187 - Semiprimes
        public static void Exercise187()
        {

        }

        // 188 - The hyperexponentiation of a number
        public static void Exercise188()
        {

        }

        // 189 - Tri-colouring a triangular grid
        public static void Exercise189()
        {

        }

        // 190 - Maximising a weighted product
        public static void Exercise190()
        {

        }

        // 191 - Prize Strings
        public static void Exercise191()
        {

        }

        // 192 - Best Approximations
        public static void Exercise192()
        {

        }

        // 193 - Squarefree Numbers
        public static void Exercise193()
        {

        }

        // 194 - Coloured Configurations
        public static void Exercise194()
        {

        }

        // 195 - Inscribed circles of triangles with one angle of 60 degrees
        public static void Exercise195()
        {

        }

        // 196 - Prime triplets
        public static void Exercise196()
        {

        }

        // 197 - Investigating the behaviour of a recursively defined sequence
        public static void Exercise197()
        {

        }

        // 198 - Ambiguous Numbers
        public static void Exercise198()
        {

        }

        // 199 - Iterative Circle Packing
        public static void Exercise199()
        {

        }

        // 200 - Find the 200th prime-proof sqube containing the contiguous sub-string "200"
        public static void Exercise200()
        {

        }

        // 201 - Subsets with a unique sum
        public static void Exercise201()
        {

        }

        // 202 - Laserbeam
        public static void Exercise202()
        {

        }

        // 203 - Squarefree Binomial Coefficients
        public static void Exercise203()
        {

        }

        // 204 - Generalised Hamming Numbers
        public static void Exercise204()
        {

        }

        // 205 - Dice Game
        public static void Exercise205()
        {

        }

        // 206 - Concealed Square
        public static void Exercise206()
        {

        }

        // 207 - Integer partition equations
        public static void Exercise207()
        {

        }

        // 208 - Robot Walks
        public static void Exercise208()
        {

        }

        // 209 - Circular Logic
        public static void Exercise209()
        {

        }

        // 210 - Obtuse Angled Triangles
        public static void Exercise210()
        {

        }

        // 211 - Divisor Square Sum
        public static void Exercise211()
        {

        }

        // 212 - Combined Volume of Cuboids
        public static void Exercise212()
        {

        }

        // 213 - Flea Circus
        public static void Exercise213()
        {

        }

        // 214 - Totient Chains
        public static void Exercise214()
        {

        }

        // 215 - Crack-free Walls
        public static void Exercise215()
        {

        }

        // 216 - Investigating the primality of numbers of the form 2n2-1
        public static void Exercise216()
        {

        }

        // 217 - Balanced Numbers
        public static void Exercise217()
        {

        }

        // 218 - Perfect right-angled triangles
        public static void Exercise218()
        {

        }

        // 219 - Skew-cost coding
        public static void Exercise219()
        {

        }

        // 220 - Heighway Dragon
        public static void Exercise220()
        {

        }

        // 221 - Alexandrian Integers
        public static void Exercise221()
        {

        }

        // 222 - Sphere Packing
        public static void Exercise222()
        {

        }

        // 223 - Almost right-angled triangles I
        public static void Exercise223()
        {

        }

        // 224 - Almost right-angled triangles II
        public static void Exercise224()
        {

        }

        // 225 - Tribonacci non-divisors
        public static void Exercise225()
        {

        }

        // 226 - A Scoop of Blancmange
        public static void Exercise226()
        {

        }

        // 227 - The Chase
        public static void Exercise227()
        {

        }

        // 228 - Minkowski Sums
        public static void Exercise228()
        {

        }

        // 229 - Four Representations using Squares
        public static void Exercise229()
        {

        }

        // 230 - Fibonacci Words
        public static void Exercise230()
        {

        }

        // 231 - The prime factorisation of binomial coefficients
        public static void Exercise231()
        {

        }

        // 232 - The Race
        public static void Exercise232()
        {

        }

        // 233 - Lattice points on a circle
        public static void Exercise233()
        {

        }

        // 234 - Semidivisible numbers
        public static void Exercise234()
        {

        }

        // 235 - An Arithmetic Geometric sequence
        public static void Exercise235()
        {

        }

        // 236 - Luxury Hampers
        public static void Exercise236()
        {

        }

        // 237 - Tours on a 4 x n playing board
        public static void Exercise237()
        {

        }

        // 238 - Infinite string tour
        public static void Exercise238()
        {

        }

        // 239 - Twenty-two Foolish Primes
        public static void Exercise239()
        {

        }

        // 240 - Top Dice
        public static void Exercise240()
        {

        }

        // 241 - Perfection Quotients
        public static void Exercise241()
        {

        }

        // 242 - Odd Triplets
        public static void Exercise242()
        {

        }

        // 243 - Resilience
        public static void Exercise243()
        {

        }

        // 244 - Sliders
        public static void Exercise244()
        {

        }

        // 245 - Coresilience
        public static void Exercise245()
        {

        }

        // 246 - Tangents to an ellipse
        public static void Exercise246()
        {

        }

        // 247 - Squares under a hyperbola
        public static void Exercise247()
        {

        }

        // 248 - Numbers for which Euler’s totient function equals 13!
        public static void Exercise248()
        {

        }

        // 249 - Prime Subset Sums
        public static void Exercise249()
        {

        }

        // 250 - 250250
        public static void Exercise250()
        {

        }

        // 251 - Cardano Triplets
        public static void Exercise251()
        {

        }

        // 252 - Convex Holes
        public static void Exercise252()
        {

        }

        // 253 - Tidying up
        public static void Exercise253()
        {

        }

        // 254 - Sums of Digit Factorials
        public static void Exercise254()
        {

        }

        // 255 - Rounded Square Roots
        public static void Exercise255()
        {

        }

        // 256 - Tatami-Free Rooms
        public static void Exercise256()
        {

        }

        // 257 - Angular Bisectors
        public static void Exercise257()
        {

        }

        // 258 - A lagged Fibonacci sequence
        public static void Exercise258()
        {

        }

        // 259 - Reachable Numbers
        public static void Exercise259()
        {

        }

        // 260 - Stone Game
        public static void Exercise260()
        {

        }

        // 261 - Pivotal Square Sums
        public static void Exercise261()
        {

        }

        // 262 - Mountain Range
        public static void Exercise262()
        {

        }

        // 263 - An engineers' dream come true
        public static void Exercise263()
        {

        }

        // 264 - Triangle Centres
        public static void Exercise264()
        {

        }

        // 265 - Binary Circles
        public static void Exercise265()
        {

        }

        // 266 - Pseudo Square Root
        public static void Exercise266()
        {

        }

        // 267 - Billionaire
        public static void Exercise267()
        {

        }

        // 268 - Counting numbers with at least four distinct prime factors less than 100
        public static void Exercise268()
        {

        }

        // 269 - Polynomials with at least one integer root
        public static void Exercise269()
        {

        }

        // 270 - Cutting Squares
        public static void Exercise270()
        {

        }

        // 271 - Modular Cubes, part 1
        public static void Exercise271()
        {

        }

        // 272 - Modular Cubes, part 2
        public static void Exercise272()
        {

        }

        // 273 - Sum of Squares
        public static void Exercise273()
        {

        }

        // 274 - Divisibility Multipliers
        public static void Exercise274()
        {

        }

        // 275 - Balanced Sculptures
        public static void Exercise275()
        {

        }

        // 276 - Primitive Triangles
        public static void Exercise276()
        {

        }

        // 277 - A Modified Collatz sequence
        public static void Exercise277()
        {

        }

        // 278 - Linear Combinations of Semiprimes
        public static void Exercise278()
        {

        }

        // 279 - Triangles with integral sides and an integral angle
        public static void Exercise279()
        {

        }

        // 280 - Ant and seeds
        public static void Exercise280()
        {

        }

        // 281 - Pizza Toppings
        public static void Exercise281()
        {

        }

        // 282 - The Ackermann function
        public static void Exercise282()
        {

        }

        // 283 - Integer sided triangles for which the area/perimeter ratio is integral
        public static void Exercise283()
        {

        }

        // 284 - Steady Squares
        public static void Exercise284()
        {

        }

        // 285 - Pythagorean odds
        public static void Exercise285()
        {

        }

        // 286 - Scoring probabilities
        public static void Exercise286()
        {

        }

        // 287 - Quadtree encoding (a simple compression algorithm)
        public static void Exercise287()
        {

        }

        // 288 - An enormous factorial
        public static void Exercise288()
        {

        }

        // 289 - Eulerian Cycles
        public static void Exercise289()
        {

        }

        // 290 - Digital Signature
        public static void Exercise290()
        {

        }

        // 291 - Panaitopol Primes
        public static void Exercise291()
        {

        }

        // 292 - Pythagorean Polygons
        public static void Exercise292()
        {

        }

        // 293 - Pseudo-Fortunate Numbers
        public static void Exercise293()
        {

        }

        // 294 - Sum of digits - experience #23
        public static void Exercise294()
        {

        }

        // 295 - Lenticular holes
        public static void Exercise295()
        {

        }

        // 296 - Angular Bisector and Tangent
        public static void Exercise296()
        {

        }

        // 297 - Zeckendorf Representation
        public static void Exercise297()
        {

        }

        // 298 - Selective Amnesia
        public static void Exercise298()
        {

        }

        // 299 - Three similar triangles
        public static void Exercise299()
        {

        }

        // 300 - Protein folding
        public static void Exercise300()
        {

        }

        // 301 - Nim
        public static void Exercise301()
        {

        }

        // 302 - Strong Achilles Numbers
        public static void Exercise302()
        {

        }

        // 303 - Multiples with small digits
        public static void Exercise303()
        {

        }

        // 304 - Primonacci
        public static void Exercise304()
        {

        }

        // 305 - Reflexive Position
        public static void Exercise305()
        {

        }

        // 306 - Paper-strip Game
        public static void Exercise306()
        {

        }

        // 307 - Chip Defects
        public static void Exercise307()
        {

        }

        // 308 - An amazing Prime-generating Automaton
        public static void Exercise308()
        {

        }

        // 309 - Integer Ladders
        public static void Exercise309()
        {

        }

        // 310 - Nim Square
        public static void Exercise310()
        {

        }

        // 311 - Biclinic Integral Quadrilaterals
        public static void Exercise311()
        {

        }

        // 312 - Cyclic paths on Sierpiński graphs
        public static void Exercise312()
        {

        }

        // 313 - Sliding game
        public static void Exercise313()
        {

        }

        // 314 - The Mouse on the Moon
        public static void Exercise314()
        {

        }

        // 315 - Digital root clocks
        public static void Exercise315()
        {

        }

        // 316 - Numbers in decimal expansions
        public static void Exercise316()
        {

        }

        // 317 - Firecracker
        public static void Exercise317()
        {

        }

        // 318 - 2011 nines
        public static void Exercise318()
        {

        }

        // 319 - Bounded Sequences
        public static void Exercise319()
        {

        }

        // 320 - Factorials divisible by a huge integer
        public static void Exercise320()
        {

        }

        // 321 - Swapping Counters
        public static void Exercise321()
        {

        }

        // 322 - Binomial coefficients divisible by 10
        public static void Exercise322()
        {

        }

        // 323 - Bitwise-OR operations on random integers
        public static void Exercise323()
        {

        }

        // 324 - Building a tower
        public static void Exercise324()
        {

        }

        // 325 - Stone Game II
        public static void Exercise325()
        {

        }

        // 326 - Modulo Summations
        public static void Exercise326()
        {

        }

        // 327 - Rooms of Doom
        public static void Exercise327()
        {

        }

        // 328 - Lowest-cost Search
        public static void Exercise328()
        {

        }

        // 329 - Prime Frog
        public static void Exercise329()
        {

        }

        // 330 - Euler's Number
        public static void Exercise330()
        {

        }

        // 331 - Cross flips
        public static void Exercise331()
        {

        }

        // 332 - Spherical triangles
        public static void Exercise332()
        {

        }

        // 333 - Special partitions
        public static void Exercise333()
        {

        }

        // 334 - Spilling the beans
        public static void Exercise334()
        {

        }

        // 335 - Gathering the beans
        public static void Exercise335()
        {

        }

        // 336 - Maximix Arrangements
        public static void Exercise336()
        {

        }

        // 337 - Totient Stairstep Sequences
        public static void Exercise337()
        {

        }

        // 338 - Cutting Rectangular Grid Paper
        public static void Exercise338()
        {

        }

        // 339 - Peredur fab Efrawg
        public static void Exercise339()
        {

        }

        // 340 - Crazy Function
        public static void Exercise340()
        {

        }

        // 341 - Golomb's self-describing sequence
        public static void Exercise341()
        {

        }

        // 342 - The totient of a square is a cube
        public static void Exercise342()
        {

        }

        // 343 - Fractional Sequences
        public static void Exercise343()
        {

        }

        // 344 - Silver dollar game
        public static void Exercise344()
        {

        }

        // 345 - Matrix Sum
        public static void Exercise345()
        {

        }

        // 346 - Strong Repunits
        public static void Exercise346()
        {

        }

        // 347 - Largest integer divisible by two primes
        public static void Exercise347()
        {

        }

        // 348 - Sum of a square and a cube
        public static void Exercise348()
        {

        }

        // 349 - Langton's ant
        public static void Exercise349()
        {

        }

        // 350 - Constraining the least greatest and the greatest least
        public static void Exercise350()
        {

        }

        // 351 - Hexagonal orchards
        public static void Exercise351()
        {

        }

        // 352 - Blood tests
        public static void Exercise352()
        {

        }

        // 353 - Risky moon
        public static void Exercise353()
        {

        }

        // 354 - Distances in a bee's honeycomb
        public static void Exercise354()
        {

        }

        // 355 - Maximal coprime subset
        public static void Exercise355()
        {

        }

        // 356 - Largest roots of cubic polynomials
        public static void Exercise356()
        {

        }

        // 357 - Prime generating integers
        public static void Exercise357()
        {

        }

        // 358 - Cyclic numbers
        public static void Exercise358()
        {

        }

        // 359 - Hilbert's New Hotel
        public static void Exercise359()
        {

        }

        // 360 - Scary Sphere
        public static void Exercise360()
        {

        }

        // 361 - Subsequence of Thue-Morse sequence
        public static void Exercise361()
        {

        }

        // 362 - Squarefree factors
        public static void Exercise362()
        {

        }

        // 363 - Bézier Curves
        public static void Exercise363()
        {

        }

        // 364 - Comfortable distance
        public static void Exercise364()
        {

        }

        // 365 - A huge binomial coefficient
        public static void Exercise365()
        {

        }

        // 366 - Stone Game III
        public static void Exercise366()
        {

        }

        // 367 - Bozo sort
        public static void Exercise367()
        {

        }

        // 368 - A Kempner-like series
        public static void Exercise368()
        {

        }

        // 369 - Badugi
        public static void Exercise369()
        {

        }

        // 370 - Geometric triangles
        public static void Exercise370()
        {

        }

        // 371 - Licence plates
        public static void Exercise371()
        {

        }

        // 372 - Pencils of rays
        public static void Exercise372()
        {

        }

        // 373 - Circumscribed Circles
        public static void Exercise373()
        {

        }

        // 374 - Maximum Integer Partition Product
        public static void Exercise374()
        {

        }

        // 375 - Minimum of subsequences
        public static void Exercise375()
        {

        }

        // 376 - Nontransitive sets of dice
        public static void Exercise376()
        {

        }

        // 377 - Sum of digits - experience #13
        public static void Exercise377()
        {

        }

        // 378 - Triangle Triples
        public static void Exercise378()
        {

        }

        // 379 - Least common multiple count
        public static void Exercise379()
        {

        }

        // 380 - Amazing Mazes!
        public static void Exercise380()
        {

        }

        // 381 - (prime-k) factorial
        public static void Exercise381()
        {

        }

        // 382 - Generating polygons
        public static void Exercise382()
        {

        }

        // 383 - Divisibility comparison between factorials
        public static void Exercise383()
        {

        }

        // 384 - Rudin-Shapiro sequence
        public static void Exercise384()
        {

        }

        // 385 - Ellipses inside triangles
        public static void Exercise385()
        {

        }

        // 386 - Maximum length of an antichain
        public static void Exercise386()
        {

        }

        // 387 - Harshad Numbers
        public static void Exercise387()
        {

        }

        // 388 - Distinct Lines
        public static void Exercise388()
        {

        }

        // 389 - Platonic Dice
        public static void Exercise389()
        {

        }

        // 390 - Triangles with non rational sides and integral area
        public static void Exercise390()
        {

        }

        // 391 - Hopping Game
        public static void Exercise391()
        {

        }

        // 392 - Enmeshed unit circle
        public static void Exercise392()
        {

        }

        // 393 - Migrating ants
        public static void Exercise393()
        {

        }

        // 394 - Eating pie
        public static void Exercise394()
        {

        }

        // 395 - Pythagorean tree
        public static void Exercise395()
        {

        }

        // 396 - Weak Goodstein sequence
        public static void Exercise396()
        {

        }

        // 397 - Triangle on parabola
        public static void Exercise397()
        {

        }

        // 398 - Cutting rope
        public static void Exercise398()
        {

        }

        // 399 - Squarefree Fibonacci Numbers
        public static void Exercise399()
        {

        }

        // 400 - Fibonacci tree game
        public static void Exercise400()
        {

        }

        // 401 - Sum of squares of divisors
        public static void Exercise401()
        {

        }

        // 402 - Integer-valued polynomials
        public static void Exercise402()
        {

        }

        // 403 - Lattice points enclosed by parabola and line
        public static void Exercise403()
        {

        }

        // 404 - Crisscross Ellipses
        public static void Exercise404()
        {

        }

        // 405 - A rectangular tiling
        public static void Exercise405()
        {

        }

        // 406 - Guessing Game
        public static void Exercise406()
        {

        }

        // 407 - Idempotents
        public static void Exercise407()
        {

        }

        // 408 - Admissible paths through a grid
        public static void Exercise408()
        {

        }

        // 409 - Nim Extreme 
        public static void Exercise409()
        {

        }

        // 410 - Circle and tangent line
        public static void Exercise410()
        {

        }

        // 411 - Uphill paths
        public static void Exercise411()
        {

        }

        // 412 - Gnomon numbering
        public static void Exercise412()
        {

        }

        // 413 - One-child Numbers
        public static void Exercise413()
        {

        }

        // 414 - Kaprekar constant
        public static void Exercise414()
        {

        }

        // 415 - Titanic sets
        public static void Exercise415()
        {

        }

        // 416 - A frog's trip
        public static void Exercise416()
        {

        }

        // 417 - Reciprocal cycles II
        public static void Exercise417()
        {

        }

        // 418 - Factorisation triples
        public static void Exercise418()
        {

        }

        // 419 - Look and say sequence
        public static void Exercise419()
        {

        }

        // 420 - 2x2 positive integer matrix
        public static void Exercise420()
        {

        }

        // 421 - Prime factors of n15+1
        public static void Exercise421()
        {

        }

        // 422 - Sequence of points on a hyperbola
        public static void Exercise422()
        {

        }

        // 423 - Consecutive die throws
        public static void Exercise423()
        {

        }

        // 424 - Kakuro
        public static void Exercise424()
        {

        }

        // 425 - Prime connection
        public static void Exercise425()
        {

        }

        // 426 - Box-ball system
        public static void Exercise426()
        {

        }

        // 427 - n-sequences
        public static void Exercise427()
        {

        }

        // 428 - Necklace of circles
        public static void Exercise428()
        {

        }

        // 429 - Sum of squares of unitary divisors
        public static void Exercise429()
        {

        }

        // 430 - Range flips
        public static void Exercise430()
        {

        }

        // 431 - Square Space Silo
        public static void Exercise431()
        {

        }

        // 432 - Totient sum
        public static void Exercise432()
        {

        }

        // 433 - Steps in Euclid's algorithm
        public static void Exercise433()
        {

        }

        // 434 - Rigid graphs
        public static void Exercise434()
        {

        }

        // 435 - Polynomials of Fibonacci numbers
        public static void Exercise435()
        {

        }

        // 436 - Unfair wager
        public static void Exercise436()
        {

        }

        // 437 - Fibonacci primitive roots
        public static void Exercise437()
        {

        }

        // 438 - Integer part of polynomial equation's solutions
        public static void Exercise438()
        {

        }

        // 439 - Sum of sum of divisors
        public static void Exercise439()
        {

        }

        // 440 - GCD and Tiling
        public static void Exercise440()
        {

        }

        // 441 - The inverse summation of coprime couples
        public static void Exercise441()
        {

        }

        // 442 - Eleven-free integers
        public static void Exercise442()
        {

        }

        // 443 - GCD sequence
        public static void Exercise443()
        {

        }

        // 444 - The Roundtable Lottery
        public static void Exercise444()
        {

        }

        // 445 - Retractions A
        public static void Exercise445()
        {

        }

        // 446 - Retractions B
        public static void Exercise446()
        {

        }

        // 447 - Retractions C
        public static void Exercise447()
        {

        }

        // 448 - Average least common multiple
        public static void Exercise448()
        {

        }

        // 449 - Chocolate covered candy
        public static void Exercise449()
        {

        }

        // 450 - Hypocycloid and Lattice points
        public static void Exercise450()
        {

        }

        // 451 - Modular inverses
        public static void Exercise451()
        {

        }

        // 452 - Long Products
        public static void Exercise452()
        {

        }

        // 453 - Lattice Quadrilaterals
        public static void Exercise453()
        {

        }

        // 454 - Diophantine reciprocals III
        public static void Exercise454()
        {

        }

        // 455 - Powers With Trailing Digits
        public static void Exercise455()
        {

        }

        // 456 - Triangles containing the origin II
        public static void Exercise456()
        {

        }

        // 457 - A polynomial modulo the square of a prime
        public static void Exercise457()
        {

        }

        // 458 - Permutations of Project
        public static void Exercise458()
        {

        }

        // 459 - Flipping game
        public static void Exercise459()
        {

        }

        // 460 - An ant on the move
        public static void Exercise460()
        {

        }

        // 461 - Almost Pi
        public static void Exercise461()
        {

        }

        // 462 - Permutation of 3-smooth numbers
        public static void Exercise462()
        {

        }

        // 463 - A weird recurrence relation
        public static void Exercise463()
        {

        }

        // 464 - Möbius function and intervals
        public static void Exercise464()
        {

        }

        // 465 - Polar polygons
        public static void Exercise465()
        {

        }

        // 466 - Distinct terms in a multiplication table
        public static void Exercise466()
        {

        }

        // 467 - Superinteger
        public static void Exercise467()
        {

        }

        // 468 - Smooth divisors of binomial coefficients
        public static void Exercise468()
        {

        }

        // 469 - Empty chairs
        public static void Exercise469()
        {

        }

        // 470 - Super Ramvok
        public static void Exercise470()
        {

        }

        // 471 - Triangle inscribed in ellipse
        public static void Exercise471()
        {

        }

        // 472 - Comfortable Distance II
        public static void Exercise472()
        {

        }

        // 473 - Phigital number base
        public static void Exercise473()
        {

        }

        // 474 - Last digits of divisors
        public static void Exercise474()
        {

        }

        // 475 - Music festival
        public static void Exercise475()
        {

        }

        // 476 - Circle Packing II
        public static void Exercise476()
        {

        }

        // 477 - Number Sequence Game
        public static void Exercise477()
        {

        }

        // 478 - Mixtures
        public static void Exercise478()
        {

        }

        // 479 - Roots on the Rise
        public static void Exercise479()
        {

        }

        // 480 - The Last Question
        public static void Exercise480()
        {

        }

        // 481 - Chef Showdown
        public static void Exercise481()
        {

        }

        // 482 - The incenter of a triangle
        public static void Exercise482()
        {

        }

        // 483 - Repeated permutation
        public static void Exercise483()
        {

        }

        // 484 - Arithmetic Derivative
        public static void Exercise484()
        {

        }

        // 485 - Maximum number of divisors
        public static void Exercise485()
        {

        }

        // 486 - Palindrome-containing strings
        public static void Exercise486()
        {

        }

        // 487 - Sums of power sums
        public static void Exercise487()
        {

        }

        // 488 - Unbalanced Nim
        public static void Exercise488()
        {

        }

        // 489 - Common factors between two sequences
        public static void Exercise489()
        {

        }

        // 490 - Jumping frog
        public static void Exercise490()
        {

        }

        // 491 - Double pandigital number divisible by 11
        public static void Exercise491()
        {

        }

        // 492 - Exploding sequence
        public static void Exercise492()
        {

        }

        // 493 - Under The Rainbow
        public static void Exercise493()
        {

        }

        // 494 - Collatz prefix families
        public static void Exercise494()
        {

        }

        // 495 - Writing n as the product of k distinct positive integers
        public static void Exercise495()
        {

        }

        // 496 - Incenter and circumcenter of triangle
        public static void Exercise496()
        {

        }

        // 497 - Drunken Tower of Hanoi
        public static void Exercise497()
        {

        }

        // 498 - Remainder of polynomial division
        public static void Exercise498()
        {

        }

        // 499 - St. Petersburg Lottery
        public static void Exercise499()
        {

        }

        // 500 - Problem 500!!!
        public static void Exercise500()
        {

        }

        // 501 - Eight Divisors
        public static void Exercise501()
        {

        }

        // 502 - Counting Castles
        public static void Exercise502()
        {

        }

        // 503 - Compromise or persist
        public static void Exercise503()
        {

        }

        // 504 - Square on the Inside
        public static void Exercise504()
        {

        }

        // 505 - Bidirectional Recurrence
        public static void Exercise505()
        {

        }

        // 506 - Clock sequence
        public static void Exercise506()
        {

        }

        // 507 - Shortest Lattice Vector
        public static void Exercise507()
        {

        }

        // 508 - Integers in base i-1
        public static void Exercise508()
        {

        }

        // 509 - Divisor Nim
        public static void Exercise509()
        {

        }

        // 510 - Tangent Circles
        public static void Exercise510()
        {

        }

        // 511 - Sequences with nice divisibility properties
        public static void Exercise511()
        {

        }

        // 512 - Sums of totients of powers
        public static void Exercise512()
        {

        }

        // 513 - Integral median
        public static void Exercise513()
        {

        }

        // 514 - Geoboard Shapes
        public static void Exercise514()
        {

        }

        // 515 - Dissonant Numbers
        public static void Exercise515()
        {

        }

        // 516 - 5-smooth totients
        public static void Exercise516()
        {

        }

        // 517 - A real recursion
        public static void Exercise517()
        {

        }

        // 518 - Prime triples and geometric sequences
        public static void Exercise518()
        {

        }

        // 519 - Tricoloured Coin Fountains
        public static void Exercise519()
        {

        }

        // 520 - Simbers
        public static void Exercise520()
        {

        }

        // 521 - Smallest prime factor
        public static void Exercise521()
        {

        }

        // 522 - Hilbert's Blackout
        public static void Exercise522()
        {

        }

        // 523 - First Sort I
        public static void Exercise523()
        {

        }

        // 524 - First Sort II
        public static void Exercise524()
        {

        }

        // 525 - Rolling Ellipse
        public static void Exercise525()
        {

        }

        // 526 - Largest prime factors of consecutive numbers
        public static void Exercise526()
        {

        }

        // 527 - Randomized Binary Search
        public static void Exercise527()
        {

        }

        // 528 - Constrained Sums
        public static void Exercise528()
        {

        }

        // 529 - 10-substrings
        public static void Exercise529()
        {

        }

        // 530 - GCD of Divisors
        public static void Exercise530()
        {

        }

        // 531 - Chinese leftovers
        public static void Exercise531()
        {

        }

        // 532 - Nanobots on Geodesics
        public static void Exercise532()
        {

        }

        // 533 - Minimum values of the Carmichael function
        public static void Exercise533()
        {

        }

        // 534 - Weak Queens
        public static void Exercise534()
        {

        }

        // 535 - Fractal Sequence
        public static void Exercise535()
        {

        }

        // 536 - Modulo power identity
        public static void Exercise536()
        {

        }

        // 537 - Counting tuples
        public static void Exercise537()
        {

        }

        // 538 - Maximum quadrilaterals
        public static void Exercise538()
        {

        }

        // 539 - Odd elimination
        public static void Exercise539()
        {

        }

        // 540 - Counting primitive Pythagorean triples
        public static void Exercise540()
        {

        }

        // 541 - Divisibility of Harmonic Number Denominators
        public static void Exercise541()
        {

        }

        // 542 - Geometric Progression with Maximum Sum
        public static void Exercise542()
        {

        }

        // 543 - Prime-Sum Numbers
        public static void Exercise543()
        {

        }

        // 544 - Chromatic Conundrum
        public static void Exercise544()
        {

        }

        // 545 - Faulhaber's Formulas
        public static void Exercise545()
        {

        }

        // 546 - The Floor's Revenge
        public static void Exercise546()
        {

        }

        // 547 - Distance of random points within hollow square laminae
        public static void Exercise547()
        {

        }

        // 548 - Gozinta Chains
        public static void Exercise548()
        {

        }

        // 549 - Divisibility of factorials
        public static void Exercise549()
        {

        }

        // 550 - Divisor game
        public static void Exercise550()
        {

        }

        // 551 - Sum of digits sequence
        public static void Exercise551()
        {

        }

        // 552 - Chinese leftovers II
        public static void Exercise552()
        {

        }

        // 553 - Power sets of power sets
        public static void Exercise553()
        {

        }

        // 554 - Centaurs on a chess board
        public static void Exercise554()
        {

        }

        // 555 - McCarthy 91 function
        public static void Exercise555()
        {

        }

        // 556 - Squarefree Gaussian Integers
        public static void Exercise556()
        {

        }

        // 557 - Cutting triangles
        public static void Exercise557()
        {

        }

        // 558 - Irrational base
        public static void Exercise558()
        {

        }

        // 559 - Permuted Matrices
        public static void Exercise559()
        {

        }

        // 560 - Coprime Nim
        public static void Exercise560()
        {

        }

        // 561 - Divisor Pairs
        public static void Exercise561()
        {

        }

        // 562 - Maximal perimeter
        public static void Exercise562()
        {

        }

        // 563 - Robot Welders
        public static void Exercise563()
        {

        }

        // 564 - Maximal polygons
        public static void Exercise564()
        {

        }

        // 565 - Divisibility of sum of divisors
        public static void Exercise565()
        {

        }

        // 566 - Cake Icing Puzzle
        public static void Exercise566()
        {

        }

        // 567 - Reciprocal games I
        public static void Exercise567()
        {

        }

        // 568 - Reciprocal games II
        public static void Exercise568()
        {

        }

        // 569 - Prime Mountain Range
        public static void Exercise569()
        {

        }

        // 570 - Snowflakes
        public static void Exercise570()
        {

        }

        // 571 - Super Pandigital Numbers
        public static void Exercise571()
        {

        }

        // 572 - Idempotent matrices
        public static void Exercise572()
        {

        }

        // 573 - Unfair race
        public static void Exercise573()
        {

        }

        // 574 - Verifying Primes
        public static void Exercise574()
        {

        }

        // 575 - Wandering Robots
        public static void Exercise575()
        {

        }

        // 576 - Irrational jumps
        public static void Exercise576()
        {

        }

        // 577 - Counting hexagons
        public static void Exercise577()
        {

        }

        // 578 - Integers with decreasing prime powers
        public static void Exercise578()
        {

        }

        // 579 - Lattice points in lattice cubes
        public static void Exercise579()
        {

        }

        // 580 - Squarefree Hilbert numbers
        public static void Exercise580()
        {

        }

        // 581 - 47-smooth triangular numbers
        public static void Exercise581()
        {

        }

        // 582 - Nearly isosceles 120 degree triangles
        public static void Exercise582()
        {

        }

        // 583 - Heron Envelopes
        public static void Exercise583()
        {

        }

        // 584 - Birthday Problem Revisited
        public static void Exercise584()
        {

        }

        // 585 - Nested square roots
        public static void Exercise585()
        {

        }

        // 586 - Binary Quadratic Form
        public static void Exercise586()
        {

        }

        // 587 - Concave triangle
        public static void Exercise587()
        {

        }

        // 588 - Quintinomial coefficients
        public static void Exercise588()
        {

        }

        // 589 - Poohsticks Marathon
        public static void Exercise589()
        {

        }

        // 590 - Sets with a given Least Common Multiple
        public static void Exercise590()
        {

        }

        // 591 - Best Approximations by Quadratic Integers
        public static void Exercise591()
        {

        }

        // 592 - Factorial trailing digits 2
        public static void Exercise592()
        {

        }

        // 593 - Fleeting Medians
        public static void Exercise593()
        {

        }

        // 594 - Rhombus Tilings
        public static void Exercise594()
        {

        }

        // 595 - Incremental Random Sort
        public static void Exercise595()
        {

        }

        // 596 - Number of lattice points in a hyperball
        public static void Exercise596()
        {

        }

        // 597 - Torpids
        public static void Exercise597()
        {

        }

        // 598 - Split Divisibilities
        public static void Exercise598()
        {

        }

        // 599 - Distinct Colourings of a Rubik's Cube
        public static void Exercise599()
        {

        }

        // 600 - Integer sided equiangular hexagons
        public static void Exercise600()
        {

        }

        // 601 - Divisibility streaks
        public static void Exercise601()
        {

        }

        // 602 - Product of Head Counts
        public static void Exercise602()
        {

        }

        // 603 - Substring sums of prime concatenations
        public static void Exercise603()
        {

        }

        // 604 - Convex path in square
        public static void Exercise604()
        {

        }

        // 605 - Pairwise Coin-Tossing Game
        public static void Exercise605()
        {

        }

        // 606 - Gozinta Chains II
        public static void Exercise606()
        {

        }

        // 607 - Marsh Crossing
        public static void Exercise607()
        {

        }

        // 608 - Divisor Sums
        public static void Exercise608()
        {

        }

        // 609 - π sequences
        public static void Exercise609()
        {

        }

        // 610 - Roman Numerals II
        public static void Exercise610()
        {

        }

        // 611 - Hallway of square steps
        public static void Exercise611()
        {

        }

        // 612 - Friend numbers
        public static void Exercise612()
        {

        }

        // 613 - Pythagorean Ant
        public static void Exercise613()
        {

        }

        // 614 - Special partitions 2
        public static void Exercise614()
        {

        }

        // 615 - The millionth number with at least one million prime factors
        public static void Exercise615()
        {

        }

        // 616 - Creative numbers
        public static void Exercise616()
        {

        }

        // 617 - Mirror Power Sequence
        public static void Exercise617()
        {

        }

        // 618 - Numbers with a given prime factor sum
        public static void Exercise618()
        {

        }

        // 619 - Square subsets
        public static void Exercise619()
        {

        }

        // 620 - Planetary Gears
        public static void Exercise620()
        {

        }

        // 621 - Expressing an integer as the sum of triangular numbers
        public static void Exercise621()
        {

        }

        // 622 - Riffle Shuffles
        public static void Exercise622()
        {

        }

        // 623 - Lambda Count
        public static void Exercise623()
        {

        }

        // 624 - Two heads are better than one
        public static void Exercise624()
        {

        }

        // 625 - Gcd sum
        public static void Exercise625()
        {

        }

        // 626 - Counting Binary Matrices
        public static void Exercise626()
        {

        }

        // 627 - Counting products
        public static void Exercise627()
        {

        }

        // 628 - Open chess positions
        public static void Exercise628()
        {

        }

        // 629 - Scatterstone Nim
        public static void Exercise629()
        {

        }

        // 630 - Crossed lines
        public static void Exercise630()
        {

        }

        // 631 - Constrained Permutations
        public static void Exercise631()
        {

        }

        // 632 - Square prime factors
        public static void Exercise632()
        {

        }

        // 633 - Square prime factors II
        public static void Exercise633()
        {

        }

        // 634 - Numbers of the form a^2b^3
        public static void Exercise634()
        {

        }

        // 635 - Subset sums
        public static void Exercise635()
        {

        }

        // 636 - Restricted Factorisations
        public static void Exercise636()
        {

        }

        // 637 - Flexible digit sum
        public static void Exercise637()
        {

        }

        // 638 - Weighted lattice paths
        public static void Exercise638()
        {

        }

        // 639 - Summing a multiplicative function
        public static void Exercise639()
        {

        }

        // 640 - Shut the Box
        public static void Exercise640()
        {

        }

        // 641 - A Long Row of Dice
        public static void Exercise641()
        {

        }

        // 642 - Sum of largest prime factors
        public static void Exercise642()
        {

        }

        // 643 - 2-Friendly
        public static void Exercise643()
        {

        }

        // 644 - Squares on the line
        public static void Exercise644()
        {

        }

        // 645 - Every Day is a Holiday
        public static void Exercise645()
        {

        }

        // 646 - Bounded Divisors
        public static void Exercise646()
        {

        }

        // 647 - Linear Transformations of Polygonal Numbers
        public static void Exercise647()
        {

        }

        // 648 - Skipping Squares
        public static void Exercise648()
        {

        }

        // 649 - Low-Prime Chessboard Nim
        public static void Exercise649()
        {

        }

        // 650 - Divisors of Binomial Product
        public static void Exercise650()
        {

        }

        // 651 - Patterned Cylinders
        public static void Exercise651()
        {

        }

        // 652 - Distinct values of a proto-logarithmic function
        public static void Exercise652()
        {

        }

        // 653 - Frictionless Tube
        public static void Exercise653()
        {

        }

        // 654 - Neighbourly Constraints
        public static void Exercise654()
        {

        }

        // 655 - Divisible Palindromes
        public static void Exercise655()
        {

        }

        // 656 - Palindromic sequences
        public static void Exercise656()
        {

        }

        // 657 - Incomplete words
        public static void Exercise657()
        {

        }

        // 658 - Incomplete words II
        public static void Exercise658()
        {

        }

        // 659 - Largest prime
        public static void Exercise659()
        {

        }

        // 660 - Pandigital Triangles
        public static void Exercise660()
        {

        }

        // 661 - A Long Chess Match
        public static void Exercise661()
        {

        }

        // 662 - Fibonacci paths
        public static void Exercise662()
        {

        }

        // 663 - Sums of subarrays
        public static void Exercise663()
        {

        }

        // 664 - An infinite game
        public static void Exercise664()
        {

        }

        // 665 - Proportionate Nim
        public static void Exercise665()
        {

        }

        // 666 - Polymorphic Bacteria
        public static void Exercise666()
        {

        }

        // 667 - Moving Pentagon
        public static void Exercise667()
        {

        }

        // 668 - Square root smooth Numbers
        public static void Exercise668()
        {

        }

        // 669 - The King's Banquet
        public static void Exercise669()
        {

        }

        // 670 - Colouring a Strip
        public static void Exercise670()
        {

        }

        // 671 - Colouring a Loop
        public static void Exercise671()
        {

        }

        // 672 - One more one
        public static void Exercise672()
        {

        }

        // 673 - Beds and Desks
        public static void Exercise673()
        {

        }

        // 674 - Solving -equations
        public static void Exercise674()
        {

        }

        // 675 - 2^w(n)
        public static void Exercise675()
        {

        }

        // 676 - Matching Digit Sums
        public static void Exercise676()
        {

        }

        // 677 - Coloured Graphs
        public static void Exercise677()
        {

        }

        // 678 - Fermat-like Equations
        public static void Exercise678()
        {

        }

        // 679 - Freefarea
        public static void Exercise679()
        {

        }

        // 680 - Yarra Gnisrever
        public static void Exercise680()
        {

        }

        // 681 - Maximal Area
        public static void Exercise681()
        {

        }

        // 682 - 5-Smooth Pairs
        public static void Exercise682()
        {

        }

        // 683 - The Chase II
        public static void Exercise683()
        {

        }

        // 684 - Inverse Digit Sum
        public static void Exercise684()
        {

        }

        // 685 - Inverse Digit Sum II
        public static void Exercise685()
        {

        }

        // 686 - Powers of Two
        public static void Exercise686()
        {

        }

        // 687 - Shuffling Cards
        public static void Exercise687()
        {

        }

        // 688 - Piles of Plates
        public static void Exercise688()
        {

        }

        // 689 - Binary Series
        public static void Exercise689()
        {

        }

        // 690 - Tom and Jerry
        public static void Exercise690()
        {

        }

        // 691 - Long substring with many repetitions
        public static void Exercise691()
        {

        }

        // 692 - Siegbert and Jo
        public static void Exercise692()
        {

        }

        // 693 - Finite Sequence Generator
        public static void Exercise693()
        {

        }

        // 694 - Cube-full Divisors
        public static void Exercise694()
        {

        }

        // 695 - Random Rectangles
        public static void Exercise695()
        {

        }

        // 696 - Mahjong
        public static void Exercise696()
        {

        }

        // 697 - Randomly Decaying Sequence
        public static void Exercise697()
        {

        }

        // 698 - 123 Numbers
        public static void Exercise698()
        {

        }

        // 699 - Triffle Numbers
        public static void Exercise699()
        {

        }

        // 700 - Eulercoin
        public static void Exercise700()
        {

        }

        // 701 - Random connected area
        public static void Exercise701()
        {

        }

        // 702 - Jumping Flea
        public static void Exercise702()
        {

        }

        // 703 - Circular Logic II
        public static void Exercise703()
        {

        }

        // 704 - Factors of Two in Binomial Coefficients
        public static void Exercise704()
        {

        }

        // 705 - Total Inversion Count of Divided Sequences
        public static void Exercise705()
        {

        }

        // 706 - 3-Like Numbers
        public static void Exercise706()
        {

        }

        // 707 - Lights Out
        public static void Exercise707()
        {

        }

        // 708 - Twos are all you need
        public static void Exercise708()
        {

        }

        // 709 - Even Stevens
        public static void Exercise709()
        {

        }

        // 710 - One Million Members
        public static void Exercise710()
        {

        }

        // 711 - Binary Blackboard
        public static void Exercise711()
        {

        }

        // 712 - Exponent Difference
        public static void Exercise712()
        {

        }

        // 713 - Turán's water heating system
        public static void Exercise713()
        {

        }

        // 714 - Duodigits
        public static void Exercise714()
        {

        }

        // 715 - Sextuplet Norms
        public static void Exercise715()
        {

        }

        // 716 - Grid Graphs
        public static void Exercise716()
        {

        }

        // 717 - Summation of a Modular Formula
        public static void Exercise717()
        {

        }

        // 718 - Unreachable Numbers
        public static void Exercise718()
        {

        }

        // 719 - Number Splitting
        public static void Exercise719()
        {

        }

        // 720 - Unpredictable Permutations
        public static void Exercise720()
        {

        }

        // 721 - High powers of irrational numbers
        public static void Exercise721()
        {

        }

        // 722 - Slowly converging series
        public static void Exercise722()
        {

        }

        // 723 - Pythagorean Quadrilaterals
        public static void Exercise723()
        {

        }

        // 724 - Drone Delivery
        public static void Exercise724()
        {

        }

        // 725 - Digit sum numbers
        public static void Exercise725()
        {

        }

        // 726 - Falling bottles
        public static void Exercise726()
        {

        }

        // 727 - Triangle of Circular Arcs
        public static void Exercise727()
        {

        }

        // 728 - Circle of Coins
        public static void Exercise728()
        {

        }

        // 729 - Range of periodic sequence
        public static void Exercise729()
        {

        }

        // 730 - Shifted Pythagorean Triples
        public static void Exercise730()
        {

        }

        // 731 - A Stoneham Number
        public static void Exercise731()
        {

        }

        // 732 - Standing on the shoulders of trolls
        public static void Exercise732()
        {

        }

        // 733 - Ascending subsequences
        public static void Exercise733()
        {

        }

        // 734 - A bit of prime
        public static void Exercise734()
        {

        }

        // 735 - Divisors of 2n^2 
        public static void Exercise735()
        {

        }

        // 736 - Paths to Equality
        public static void Exercise736()
        {

        }

        // 737 - Coin Loops
        public static void Exercise737()
        {

        }

        // 738 - Counting Ordered Factorisations
        public static void Exercise738()
        {

        }

        // 739 - Summation of Summations
        public static void Exercise739()
        {

        }

        // 740 - Secret Santa
        public static void Exercise740()
        {

        }

        // 741 - Binary grid colouring
        public static void Exercise741()
        {

        }

        // 742 - Minimum area of a convex grid polygon
        public static void Exercise742()
        {

        }

        // 743 - Window into a Matrix
        public static void Exercise743()
        {

        }

        // 744 - What? Where? When?
        public static void Exercise744()
        {

        }

        // 745 - Sum of Squares
        public static void Exercise745()
        {

        }

        // 746 - A Messy Dinner
        public static void Exercise746()
        {

        }

        // 747 - Triangular Pizza
        public static void Exercise747()
        {

        }

        // 748 - Upside down Diophantine equation
        public static void Exercise748()
        {

        }

        // 749 - Near Power Sums
        public static void Exercise749()
        {

        }

        // 750 - Optimal Card Stacking
        public static void Exercise750()
        {

        }

        // 751 - Concatenation Coincidence
        public static void Exercise751()
        {

        }

        // 752 - Powers of 1 + square root of 7
        public static void Exercise752()
        {

        }

        // 753 - Fermat Equation
        public static void Exercise753()
        {

        }

        // 754 - Product of Gauss Factorials
        public static void Exercise754()
        {

        }

        // 755 - Not Zeckendorf
        public static void Exercise755()
        {

        }

        // 756 - Approximating a Sum
        public static void Exercise756()
        {

        }

        // 757 - Stealthy Numbers
        public static void Exercise757()
        {

        }

        // 758 - Buckets of Water
        public static void Exercise758()
        {

        }
    }
}
