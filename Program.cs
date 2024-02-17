using System;
namespace class2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //write an if-statement that takes two integer variables and exchanges
            //their values if the first one is greater than the second one
            System.Console.WriteLine("Question1");
            System.Console.WriteLine("please enter the first number");
            int response1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("please enter the second input");
            int response2 = int.Parse(Console.ReadLine());

            if(response1 > response2)
            {
                System.Console.WriteLine($"the value of the first user is   {response2}");
                System.Console.WriteLine($"the response of the second user is {response1}");
            } 
            else if(response1 == response2)
            {
                System.Console.WriteLine("both user has the same input");
            } else{
                System.Console.WriteLine($"the value of the first user is{response1}");
                System.Console.WriteLine($"the value of the second user is {response2}");
            }

            //write a program that shows the sign(+ or -) of the product of three real
            //numbers without calculating it.


            //write a program that finds the biggest of three integers 
            System.Console.WriteLine("Question 3");
            System.Console.WriteLine("enter the first number ");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter the second");
            int number2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter the third");
            int number3 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
               if(number1 > number3)
               {
                    System.Console.WriteLine("the biggest number is {0}", number1);
               } else if (number1 == number3)
               {
                 System.Console.WriteLine("the first input and the third input are the same which are {0}, {1} respectively", number1,  number3);

               } 

            }else if(number1 == number2)
            {
                if(number1 > number3)
                {
                    System.Console.WriteLine("the first two inputs are the biggest {0}, {1}respectively", number1,  number3);

                }else if(number1 == number3)
                {
                    System.Console.WriteLine("the three numbers are the same, so there is no biggest");
                }
            } 
            else if (number3 > number1 && number3 > number2)
            {
                System.Console.WriteLine("the third input is the biggest {0}", number3);

            }else if(number2 > number1 && number2 > number1)
            {
                System.Console.WriteLine("the second input is the biggest number {0}", number2);
                
            }else
            { 
                System.Console.WriteLine("none");

            }

            //sort three numbers in descending order
            System.Console.WriteLine("Question 4");
            System.Console.WriteLine("enter the first number ");
            int number4 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter the second");
            int number5 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter the third");
            int number6 = int.Parse(Console.ReadLine());

            if (number4 > number5 && number4 > number6)
            {
                if (number5 > number6)
                {
                    System.Console.Write("{0}, {1}, {2}", number4, number5, number6);
                }else
                {
                     System.Console.Write("{0}, {1}, {2}",number4, number6, number5);
                    
                }
               
            }else if(number5 > number4 && number5 > number6)
            {
                if (number4 > number6)
                {
                    System.Console.Write("{0}, {1}, {2}",number5, number4, number6);
                }else
                {
                    System.Console.Write("{0}, {1}, {2}",number5, number6, number4);
                }
            }else
            {
                if(number4 > number5)
                {
                    System.Console.WriteLine("{0}, {1}, {2}",number6, number4, number5);
                }else
                {
                    System.Console.WriteLine("{0}, {1}, {2}",number6, number5, number4);
                }
            }


            System.Console.WriteLine("question 5");
            System.Console.WriteLine("please enter a digit and it must be between 0-9");
            int digit= int.Parse(Console.ReadLine());
            if (digit > 9)
            {
                System.Console.WriteLine("opps!!, you enter a number greater than 9");
                
            }
            
            switch (digit)
                {
                    case  1:
                    System.Console.WriteLine("One");
                    break;

                    case 2:
                    System.Console.WriteLine("two");
                    break;

                    case 3:
                    System.Console.WriteLine("three");
                    break;

                    case 4:
                    System.Console.WriteLine("four");
                    break;

                    case 5:
                    System.Console.WriteLine("five");
                    break;

                    case 6:
                    System.Console.WriteLine("six");
                    break;

                    case 7:
                    System.Console.WriteLine("seven");
                    break;

                    case 8:
                    System.Console.WriteLine("eight");
                    break;

                    case 9:
                    System.Console.WriteLine("nine");
                    break;

                    default:
                    System.Console.WriteLine("completed");
                    break;
                }   


                System.Console.WriteLine("question 8");
                System.Console.WriteLine("please input a number");
                string input= Console.ReadLine();
                bool num= int.TryParse(input, out int digit1);
                
                if (num)
                {
                    
                    System.Console.WriteLine($"{num }");
                    System.Console.WriteLine("the input is a number and the number is {0}", digit1);
                    System.Console.WriteLine($"if the number is added to 1, it will be {digit1 + 1}");
                } else if(double.TryParse(input, out double nu))
                {
                    
                    System.Console.WriteLine($"nu");
                } else
                {
                    System.Console.WriteLine($"{input} * ");
                }
            





            
    
           
            // System.Console.WriteLine("please input a number");
            // int num1 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("please input another number ");
            // int num2 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("input the third number");
            // int num3 = int.Parse(Console.ReadLine());
            // int total =  (num1 + num2 + num3);
            // System.Console.WriteLine("the total number is {0}", total);

            // System.Console.WriteLine("lets find the perimeter of a circle");
            // System.Console.WriteLine("please input the area of the circle you want");
            // int area= int.Parse(Console.ReadLine());
            // System.Console.WriteLine("your area is {0}", area);
            // System.Console.WriteLine("as you know that the formular is 2^r");
            // double calculate= (double)2* 22/7 * area;
            // System.Console.WriteLine("so your parameter is {0}", calculate);
            // System.Console.WriteLine("lets answer the third");

            // System.Console.WriteLine("what's the name of your company");
            // string name = Console.ReadLine();
            // System.Console.WriteLine("please lets know the address of your company");
            // string address = Console.ReadLine();
            // System.Console.WriteLine("tell us your phone your number as well");
            // int phoneNumber = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Do you have a manager?");
            // string manager= Console.ReadLine();
            // if (manager == "yes")
            // {
            //     System.Console.WriteLine("please tell us his name and address");
            //     string nameOfManager = Console.ReadLine();
            //     System.Console.WriteLine("the details of your manager is {0}", nameOfManager);
            // } else if (manager == "no")
            // {
            //    System.Console.WriteLine("ok");
            // }
            // System.Console.WriteLine("your input are: ");
            // System.Console.WriteLine("the name of your company is {0} and the address is {1} while the phone number is {2}", name, address, phoneNumber);
            

            // System.Console.WriteLine("lets deal with question number 4");
            // System.Console.WriteLine("please input one number");
            // int number1 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("enter the second number");
            // int number2 = int.Parse(Console.ReadLine());
            // decimal solve = (decimal)(number1 % number2);
            // System.Console.WriteLine(solve);

        }
    }
}