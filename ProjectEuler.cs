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

        // 2 - Even Fibonacci numbers
        public static void Exercise2()
        {

        }

        // 3 - Largest prime factor
        public static void Exercise3()
        {

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

        // 5 - Smallest multiple
        public static void Exercise5()
        {

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

        // 8 - Largest product in a series
        public static void Exercise8()
        {
            string bi_1 = "73167176531330624919225119674426574742355349194934";
            string bi_2 = "96983520312774506326239578318016984801869478851843";
            string bi_3 = "85861560789112949495459501737958331952853208805511";
            string bi_4 = "12540698747158523863050715693290963295227443043557";
            string bi_5 = "66896648950445244523161731856403098711121722383113";

            string bi_6 = "62229893423380308135336276614282806444486645238749";
            string bi_7 = "30358907296290491560440772390713810515859307960866";
            string bi_8 = "70172427121883998797908792274921901699720888093776";
            string bi_9 = "65727333001053367881220235421809751254540594752243";
            string bi_10 = "52584907711670556013604839586446706324415722155397";

            string bi_11 = "53697817977846174064955149290862569321978468622482";
            string bi_12 = "83972241375657056057490261407972968652414535100474";
            string bi_13 = "82166370484403199890008895243450658541227588666881";
            string bi_14 = "16427171479924442928230863465674813919123162824586";
            string bi_15 = "17866458359124566529476545682848912883142607690042";

            string bi_16 = "24219022671055626321111109370544217506941658960408";
            string bi_17 = "07198403850962455444362981230987879927244284909188";
            string bi_18 = "84580156166097919133875499200524063689912560717606";
            string bi_19 = "05886116467109405077541002256983155200055935729725";
            string bi_20 = "71636269561882670428252483600823257530420752963450";

            string bi_total = bi_1 + bi_2 + bi_3 + bi_4 + bi_5 + bi_6 + bi_7 + bi_8 + bi_9 + bi_10 + bi_11 + bi_12 + bi_13 + bi_14 + bi_15 + bi_16 + bi_17 + bi_18 + bi_19 + bi_20;
            int greatest_product = 0;
            for(int i = 12; i <= 999; i++)
            {
                int gp = 1;
                string sub = bi_total.Substring(i - 12, 13);
                for(int j = 0; j < sub.Length; j++)
                {
                    gp *= Convert.ToInt32(sub[j].ToString());
                    if(gp > greatest_product)
                    {
                        greatest_product = gp;
                    }
                }
            }

            Console.WriteLine("greatest_product = " + greatest_product); // 2091059712
        }

        // 9 - Special Pythagoreon triplet
        public static void Exercise9()
        {

        }

        // 10 - Summation of primes
        public static void Exercise10()
        {

        }

        // 11 - Largest product in a grid
        public static void Exercise11()
        {

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

        // 15 - Lattice paths
        public static void Exercise15()
        {

        }

        // 16 - Power digit sum
        public static void Exercise16()
        {

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

        // 20 - Factorial digit sum
        public static void Exercise20()
        {

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

        // 29 -	Distinct powers
        public static void Exercise29()
        {

        }

        // 30 - Digit fifth powers
        public static void Exercise30()
        {

        }

        // 31 - Coin sums
        public static void Exercise31()
        {

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

        // 36 - Double-base palindromes
        public static void Exercise36()
        {

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

        // 48 - Self powers
        public static void Exercise48()
        {

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
        // 53 - Combinatoric selections
        // 54 - Poker hands
        // 55 - Lychrel numbers
        // 56 - Powerful digit sum
        // 57 - Square root convergents
        // 58 - Spiral primes
        // 59 - XOR decryption
        // 60 - Prime pair sets
        // 61 - Cyclical figurate numbers
        // 62 - Cubic permutations
        // 63 - Powerful digit counts
        // 64 - Odd period square roots
        // 65 - Convergents of e
        // 66 -	Diophantine equation
        // 67 - Maximum path sum II
        // 68 - Magic 5-gon ring
        // 69 - Totient maximum
        // 70 - Totient permutation
        // 71 - Ordered fractions
        // 72 - Counting fractions
        // 73 - Counting fractions in a range
        // 74 - Digit factorial chains
        // 75 - Singular integer right triangles
        // 76 - Counting summations
        // 77 - Prime summations
        // 78 -	Coin partitions
        // 79 - Passcode derivation
        // 80 - Square root digital expansion
        // 81 - Path sum: two ways
        // 82 - Path sum: three ways
        // 83 - Path sum: four ways
        // 84 -	Monopoly odds
        // 85 - Counting rectangles
        // 86 - Cuboid route
        // 87 - Prime power triples
        // 88 - Product-sum numbers
        // 89 - Roman numerals
        // 90 - Cube digit pairs
        // 91 - Right triangles with integer coordinates
        // 92 -	Square digit chains
        // 93 -	Arithmetic expressions
        // 94 - Almost equilateral triangles
        // 95 - Amicable chains
        // 96 - Su Doku
        // 97 -	Large non-Mersenne prime
        // 98 - Anagramic squares
        // 99 - Largest exponential
        // 100 - Arranged probability
        // 101 - Optimum polynomial
        // 102 - Triangle containment
        // 103 - Special subset sums: optimum
        // 104 - Pandigital Fibonacci ends
        // 105 - Special subset sums: testing
        // 106 - Special subset sums: meta-testing
        // 107 - Minimal network
        // 108 - Diophantine reciprocals I
        // 109 - Darts
        // 110 - Diophantine reciprocals II
        // 111 - Primes with runs
        // 112 - Bouncy numbers
        // 113 - Non-bouncy numbers
        // 114 - Counting block combinations I
        // 115 - Counting block combinations II
        // 116 - Red, green or blue tiles
        // 117 - Red, green, and blue tiles
        // 118 - Pandigital prime sets
        // 119 - Digit power sum
        // 120 - Square remainders
        // 121 - Disc game prize fund
        // 122 - Efficient exponentiation
        // 123 - Prime square remainders
        // 124 - Ordered radicals
        // 125 - Palindromic sums
        // 126 - Cuboid layers
        // 127 - abc-hits
        // 128 - Hexagonal tile differences
        // 129 - Repunit divisibility
        // 130 - Composites with prime repunit property
        // 131 - Prime cube partnership
        // 132 - Large repunit factors
        // 133 - Repunit nonfactors
        // 134 - Prime pair connection
        // 135 - Same differences
        // 136 - Singleton difference
        // 137 - Fibonacci golden nuggets
        // 138 - Special isosceles triangles
        // 139 - Pythagorean tiles
        // 140 - Modified Fibonacci golden nuggets
        // 141 - Investigating progressive numbers, n, which are also square
        // 142 - Perfect Square Collection
        // 143 - Investigating the Torricelli point of a triangle
        // 144 - Investigating multiple reflections of a laser beam
        // 145 - How many reversible numbers are there below one-billion?
        // 146 - Investigating a Prime Pattern
        // 147 - Rectangles in cross-hatched grids
        // 148 - Exploring Pascal's triangle
        // 149 - Searching for a maximum-sum subsequence
        // 150 - Searching a triangular array for a sub-triangle having minimum-sum
        // 151 - Paper sheets of standard sizes: an expected-value problem
        // 152 - Writing 1/2 as a sum of inverse squares
        // 153 - Investigating Gaussian Integers
        // 154 - Exploring Pascal's pyramid
        // 155 - Counting Capacitor Circuits
        // 156 - Counting Digits
        // 157 - Solving the diophantine equation 1/a+1/b= p/10n
        // 158 - Exploring strings for which only one character comes lexicographically after its neighbour to the left
        // 159 - Digital root sums of factorisations
        // 160 - Factorial trailing digits
        // 161 - Triominoes
        // 162 - Hexadecimal numbers
        // 163 - Cross-hatched triangles
        // 164 - Numbers for which no three consecutive digits have a sum greater than a given value
        // 165 - Intersections
        // 166 - Criss Cross
        // 167 - Investigating Ulam sequences
        // 168 - Number Rotations
        // 169 - Exploring the number of different ways a number can be expressed as a sum of powers of 2
        // 170 - Find the largest 0 to 9 pandigital that can be formed by concatenating products
        // 171 - Finding numbers for which the sum of the squares of the digits is a square
        // 172 - nvestigating numbers with few repeated digits
        // 173 - Using up to one million tiles how many different "hollow" square laminae can be formed?
        // 174 - Counting the number of "hollow" square laminae that can form one, two, three, ... distinct arrangements
        // 175 - Fractions involving the number of different ways a number can be expressed as a sum of powers of 2
        // 176 - Right-angled triangles that share a cathetus
        // 177 - Integer angled Quadrilaterals
        // 178 - Step Numbers
        // 179 - Consecutive positive divisors
        // 180 - Rational zeros of a function of three variables
        // 181 - Investigating in how many ways objects of two different colours can be grouped
        // 182 - RSA encryption
        // 183 - Maximum product of parts
        // 184 - Triangles containing the origin
        // 185 - Number Mind
        // 186 - Connectedness of a network
        // 187 - Semiprimes
        // 188 - The hyperexponentiation of a number
        // 189 - Tri-colouring a triangular grid
        // 190 - Maximising a weighted product
        // 191 - Prize Strings
        // 192 - Best Approximations
        // 193 - Squarefree Numbers
        // 194 - Coloured Configurations
        // 195 - Inscribed circles of triangles with one angle of 60 degrees
        // 196 - Prime triplets
        // 197 - Investigating the behaviour of a recursively defined sequence
        // 198 - Ambiguous Numbers
        // 199 - Iterative Circle Packing
        // 200 - Find the 200th prime-proof sqube containing the contiguous sub-string "200"
        // 201 - Subsets with a unique sum
        // 202 - Laserbeam
        // 203 - Squarefree Binomial Coefficients
        // 204 - Generalised Hamming Numbers
        // 205 - Dice Game
        // 206 - Concealed Square
        // 207 - Integer partition equations
        // 208 - Robot Walks
        // 209 - Circular Logic
        // 210 - Obtuse Angled Triangles
        // 211 - Divisor Square Sum
        // 212 - Combined Volume of Cuboids
        // 213 - Flea Circus
        // 214 - Totient Chains
        // 215 - Crack-free Walls
        // 216 - Investigating the primality of numbers of the form 2n2-1
        // 217 - Balanced Numbers
        // 218 - Perfect right-angled triangles
        // 219 - Skew-cost coding
        // 220 - Heighway Dragon
        // 221 - Alexandrian Integers
        // 222 - Sphere Packing
        // 223 - Almost right-angled triangles I
        // 224 - Almost right-angled triangles II
        // 225 - Tribonacci non-divisors
        // 226 - A Scoop of Blancmange
        // 227 - The Chase
        // 228 - Minkowski Sums
        // 229 - Four Representations using Squares
        // 230 - Fibonacci Words
        // 231 - The prime factorisation of binomial coefficients
        // 232 - The Race
        // 233 - Lattice points on a circle
        // 234 - Semidivisible numbers
        // 235 - An Arithmetic Geometric sequence
        // 236 - Luxury Hampers
        // 237 - Tours on a 4 x n playing board
        // 238 - Infinite string tour
        // 239 - Twenty-two Foolish Primes
        // 240 - Top Dice
        // 241 - Perfection Quotients
        // 242 - Odd Triplets
        // 243 - Resilience
        // 244 - Sliders
        // 245 - Coresilience
        // 246 - Tangents to an ellipse
        // 247 - Squares under a hyperbola
        // 248 - Numbers for which Euler’s totient function equals 13!
        // 249 - Prime Subset Sums
        // 250 - 250250
        // 251 - Cardano Triplets
        // 252 - Convex Holes
        // 253 - Tidying up
        // 254 - Sums of Digit Factorials
        // 255 - Rounded Square Roots
        // 256 - Tatami-Free Rooms
        // 257 - Angular Bisectors
        // 258 - A lagged Fibonacci sequence
        // 259 - Reachable Numbers
        // 260 - Stone Game
        // 261 - Pivotal Square Sums
        // 262 - Mountain Range
        // 263 - An engineers' dream come true
        // 264 - Triangle Centres
        // 265 - Binary Circles
        // 266 - Pseudo Square Root
        // 267 - Billionaire
        // 268 - Counting numbers with at least four distinct prime factors less than 100
        // 269 - Polynomials with at least one integer root
        // 270 - Cutting Squares
        // 271 - Modular Cubes, part 1
        // 272 - Modular Cubes, part 2
        // 273 - Sum of Squares
        // 274 - Divisibility Multipliers
        // 275 - Balanced Sculptures
        // 276 - Primitive Triangles
        // 277 - A Modified Collatz sequence
        // 278 - Linear Combinations of Semiprimes
        // 279 - Triangles with integral sides and an integral angle
        // 280 - Ant and seeds
        // 281 - Pizza Toppings
        // 282 - The Ackermann function
        // 283 - Integer sided triangles for which the area/perimeter ratio is integral
        // 284 - Steady Squares
        // 285 - Pythagorean odds
        // 286 - Scoring probabilities
        // 287 - Quadtree encoding (a simple compression algorithm)
        // 288 - An enormous factorial
        // 289 - Eulerian Cycles
        // 290 - Digital Signature
        // 291 - Panaitopol Primes
        // 292 - Pythagorean Polygons
        // 293 - Pseudo-Fortunate Numbers
        // 294 - Sum of digits - experience #23
        // 295 - Lenticular holes
        // 296 - Angular Bisector and Tangent
        // 297 - Zeckendorf Representation
        // 298 - Selective Amnesia
        // 299 - Three similar triangles
        // 300 - Protein folding
        // 301 - Nim
        // 302 - Strong Achilles Numbers
        // 303 - Multiples with small digits
        // 304 - Primonacci
        // 305 - Reflexive Position
        // 306 - Paper-strip Game
        // 307 - Chip Defects
        // 308 - An amazing Prime-generating Automaton
        // 309 - Integer Ladders
        // 310 - Nim Square
        // 311 - Biclinic Integral Quadrilaterals
        // 312 - Cyclic paths on Sierpiński graphs
        // 313 - Sliding game
        // 314 - The Mouse on the Moon
        // 315 - Digital root clocks
        // 316 - Numbers in decimal expansions
        // 317 - Firecracker
        // 318 - 2011 nines
        // 319 - Bounded Sequences
        // 320 - Factorials divisible by a huge integer
        // 321 - Swapping Counters
        // 322 - Binomial coefficients divisible by 10
        // 323 - Bitwise-OR operations on random integers
        // 324 - Building a tower
        // 325 - Stone Game II
        // 326 - Modulo Summations
        // 327 - Rooms of Doom
        // 328 - Lowest-cost Search
        // 329 - Prime Frog
        // 330 - Euler's Number
        // 331 - Cross flips
        // 332 - Spherical triangles
        // 333 - Special partitions
        // 334 - Spilling the beans
        // 335 - Gathering the beans
        // 336 - Maximix Arrangements
        // 337 - Totient Stairstep Sequences
        // 338 - Cutting Rectangular Grid Paper
        // 339 - Peredur fab Efrawg
        // 340 - Crazy Function
        // 341 - Golomb's self-describing sequence
        // 342 - The totient of a square is a cube
        // 343 - Fractional Sequences
        // 344 - Silver dollar game
        // 345 - Matrix Sum
        // 346 - Strong Repunits
        // 347 - Largest integer divisible by two primes
        // 348 - Sum of a square and a cube
        // 349 - Langton's ant
        // 350 - Constraining the least greatest and the greatest least
        // 351 - Hexagonal orchards
        // 352 - Blood tests
        // 353 - Risky moon
        // 354 - Distances in a bee's honeycomb
        // 355 - Maximal coprime subset
        // 356 - Largest roots of cubic polynomials
        // 357 - Prime generating integers
        // 358 - Cyclic numbers
        // 359 - Hilbert's New Hotel
        // 360 - Scary Sphere
        // 361 - Subsequence of Thue-Morse sequence
        // 362 - Squarefree factors
        // 363 - Bézier Curves
        // 364 - Comfortable distance
        // 365 - A huge binomial coefficient
        // 366 - Stone Game III
        // 367 - Bozo sort
        // 368 - A Kempner-like series
        // 369 - Badugi
        // 370 - Geometric triangles
        // 371 - Licence plates
        // 372 - Pencils of rays
        // 373 - Circumscribed Circles
        // 374 - Maximum Integer Partition Product
        // 375 - Minimum of subsequences
        // 376 - Nontransitive sets of dice
        // 377 - Sum of digits - experience #13
        // 378 - Triangle Triples
        // 379 - Least common multiple count
        // 380 - Amazing Mazes!
        // 381 - (prime-k) factorial
        // 382 - Generating polygons
        // 383 - Divisibility comparison between factorials
        // 384 - Rudin-Shapiro sequence
        // 385 - Ellipses inside triangles
        // 386 - Maximum length of an antichain
        // 387 - Harshad Numbers
        // 388 - Distinct Lines
        // 389 - Platonic Dice
        // 390 - Triangles with non rational sides and integral area
        // 391 - Hopping Game
        // 392 - Enmeshed unit circle
        // 393 - Migrating ants
        // 394 - Eating pie
        // 395 - Pythagorean tree
        // 396 - Weak Goodstein sequence
        // 397 - Triangle on parabola
        // 398 - Cutting rope
        // 399 - Squarefree Fibonacci Numbers
        // 400 - Fibonacci tree game
        // 401 -
        // 402 -
        // 403 -
        // 404 -
        // 405 -
        // 406 - 
        // 407 -
        // 408 -
        // 409 - 
        // 410 -
        // 411 - 
        // 412 - 
        // 413 -
        // 414 -
        // 415 - 
        // 416 -
        // 417 -
        // 418 -
        // 419 -
        // 420 -
        // 421 -
        // 422 -
        // 423 -
        // 424 -
        // 425 -
        // 426 -
        // 427 -
        // 428 -
        // 429 -
        // 430 - 
        // 431 - 
        // 432 - 
        // 433 -
        // 434 -
        // 435 -
        // 436 -
        // 437 - 
        // 438 - 
        // 439 -
        // 440 -
        // 441 -
        // 442 -
        // 443 -
        // 444 -
        // 445 -
        // 446 -
        // 447 -
        // 448 -
        // 449 -
        // 450 -
        // 451 -
        // 452 -
        // 453 -
        // 454 -
        // 455 -
        // 456 -
        // 457 -
        // 458 -
        // 459 -
        // 460 -
        // 461 -
        // 462 -
        // 463 -
        // 464 -
        // 465 -
        // 466 -
        // 467 -
        // 468 -
        // 469 - 
        // 470 -
        // 471 -
        // 472 -
        // 473 -
        // 474 -
        // 475 -
        // 476 -
        // 477 -
        // 478 -
        // 479 -
        // 480 - 
        // 481 - 
        // 482 -
        // 483 -
        // 484 -
        // 485 -
        // 486 -
        // 487 -
        // 488 -
        // 489 -
        // 490 -
        // 491 -
        // 492 -
        // 493 -
        // 494 -
        // 495 -
        // 496 -
        // 497 -  
        // 498 -
        // 499 -
        // 500 -
        // 501 -
        // 502 -
        // 503 -
        // 504 -
        // 505 -
        // 506 -
        // 507 -
        // 508 -
        // 509 -
        // 510 - 
        // 511 -
        // 512 -
        // 513 -
        // 514 -
        // 515 -
        // 516 -
        // 517 -
        // 518 -
        // 519 -
        // 520 -
        // 521 -
        // 522 -
        // 523 -
        // 524 -
        // 525 -
        // 526 -
        // 527 -
        // 528 -
        // 529 -
        // 530 -
        // 531 -
        // 532 -
        // 533 -
        // 534 -
        // 535 -
        // 536 -
        // 537 -
        // 538 -
        // 539 -
        // 540 -
        // 541 -
        // 542 -
        // 543 -
        // 544 -
        // 545 -
        // 546 -
        // 547 -
        // 548 -
        // 549 -
        // 550 -
        // 551 -
        // 552 -
        // 553 -
        // 554 -
        // 555 -
        // 556 -
        // 557 -
        // 558 -
        // 559 - 
        // 560 -
        // 561 -
        // 562 -
        // 563 -
        // 564 -
        // 565 -
        // 566 -
        // 567 -
        // 568 -
        // 569 -
        // 570 -
        // 571 -
        // 572 -
        // 573 -
        // 574 -
        // 575 -
        // 576 - 
        // 577 -
        // 578 -
        // 579 -
        // 580 -
        // 581 -
        // 582 -
        // 583 - 
        // 584 -
        // 585 -
        // 586 -
        // 587 -
        // 588 -
        // 589 -
        // 590 -
        // 591 -
        // 592 -
        // 593 - 
        // 594 -
        // 595 -
        // 596 - 
        // 597 -
        // 598 -
        // 599 -
        // 600 -
        // 601 -
        // 602 -
        // 603 -
        // 604 -
        // 605 -
        // 606 -
        // 607 -
        // 608 -
        // 609 -
        // 610 -
        // 611 -
        // 612 -
        // 613 -
        // 614 -
        // 615 -
        // 616 -
        // 617 -
        // 618 -
        // 619 -
        // 620 -
        // 621 -
        // 622 -
        // 623 -
        // 624 -
        // 625 -
        // 626 -
        // 627 -
        // 628 -
        // 629 -
        // 630 -
        // 631 -
        // 632 -
        // 633 -
        // 634 -
        // 635 -
        // 636 -
        // 637 -
        // 638 -
        // 639 -
        // 640 -
        // 641 -
        // 642 -
        // 643 -
        // 644 -
        // 645 -
        // 646 -
        // 647 -
        // 648 -
        // 649 -
        // 650 -
        // 651 -
        // 652 -
        // 653 -
        // 654 -
        // 655 -
        // 656 -
        // 657 -
        // 658 -
        // 659 -
        // 660 -
        // 661 -
        // 662 -
        // 663 -
        // 664 -
        // 665 -
        // 666 -
        // 667 -
        // 668 -
        // 669 -
        // 670 -
        // 671 -
        // 672 -
        // 673 -
        // 674 -
        // 675 -
        // 676 -
        // 677 -
        // 678 -
        // 679 -
        // 680 -
        // 681 -
        // 682 -
        // 683 -
        // 684 -
        // 685 -
        // 686 -
        // 687 -
        // 688 -
        // 689 -
        // 690 -
        // 691 -
        // 692 -
        // 693 -
        // 694 -
        // 695 -
        // 696 -
        // 697 -
        // 698 -
        // 699 -
        // 700 -
        // 701 -
        // 702 -
        // 703 -
        // 704 -
        // 705 -
        // 706 -
        // 707 -
        // 708 -
        // 709 -
        // 710 -
        // 711 -
        // 712 -
        // 713 -
        // 714 -
        // 715 -
        // 716 -
        // 717 -
        // 718 -
        // 719 -
        // 720 -
        // 721 -
        // 722 -
        // 723 -
        // 724 -
        // 725 -
        // 726 -
        // 727 -
        // 728 -
        // 729 -
        // 730 -
        // 731 -
        // 732 -
        // 733 -
        // 734 -
        // 735 -
        // 736 -
        // 737 -
        // 738 -
        // 739 -
        // 740 -
        // 741 -
        // 742 -
        // 743 -
        // 744 -
        // 745 -
        // 746 -
        // 747 -
        // 748 -
        // 749 -
        // 750 -
        // 751 -
        // 752 -
        // 753 -
        // 754 -
        // 755 -
        // 756 -
        // 757 -
    }
}
