using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1=0 , num2=0 , answer=0;
            string operation;
            string Opp;
            bool exit = false;

            do
            {
                if(answer == 0)
                {
                    Console.Write("Please enter 1st number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }else
                {
                    num1 = answer;
                }

                    Console.Write("please enter a operand (+, -, *, / )");
                    operation = Console.ReadLine();

                    Console.Write("please enter 2nd number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    switch (operation)
                    {
                        case "+":
                            answer = num1 + num2;
                        
                            break;

                        case "-":
                            answer = num1 - num2;
                            break;
                        case "*":
                            answer = num1 * num2;
                            break;

                        case "/":
                            answer = num1 / num2;
                            break;
                        default:
                            return;

                    }


                    Console.WriteLine("YOUR ANSWER IS: {0}{1}{2}= {3}", num1, operation, num2, answer);
                Console.WriteLine("press Enter to continue >>>------>>>>>");

                Console.WriteLine("Press (((X , x))) to exit the program Or Press (((C , c to))) clear the screen and start again !!!");
                 Opp = Console.ReadLine();
                if (Opp == "x" || Opp == "X")
                {
                    
                    break;
                }
                else if (Opp == "C" || Opp == "c")
                {
                    answer = 0;
                        Console.Clear();
                    
                    
                }
                

            } while (!exit);
        
            

        }
        

    }
    
}
