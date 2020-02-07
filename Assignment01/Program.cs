using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;
            bool flag = true;
            bool flag2 = true;
            int choice;
            bool c1 = true;
            bool flag1 = true;


            do
            {
                try
                {
                    Console.WriteLine("Please enter length of rectangle:");
                    length = int.Parse(Console.ReadLine());
                    if (length > 0)
                    {
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter length greater 0");
                        flag = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (flag == true);

            do
            {
                try
                {
                    Console.WriteLine("Please enter width of rectangle:");
                    width = int.Parse(Console.ReadLine());
                    if (width > 0)
                    {
                        flag2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter width greater 0");
                        flag2 = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (flag2 == true);

            Rectangle r1 = new Rectangle(length, width);
            do
            {
                try
                {
                    Console.WriteLine("\n Menu:");
                    Console.WriteLine("1.Get Rectangle Length");
                    Console.WriteLine("2.Change Rectangle Length");
                    Console.WriteLine("3.Get Rectangle Width");
                    Console.WriteLine("4.Change Rectangle Width");
                    Console.WriteLine("5.Get Rectangle Perimeter");
                    Console.WriteLine("6.Get Rectangle Area");
                    Console.WriteLine("7.Exit");
                    Console.WriteLine("\nPlease enter an option:");
                    choice = int.Parse(Console.ReadLine());


                    if (choice > 0 && choice <= 7)
                    {
                        c1 = false;
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\n Length of Rectangle is: " + r1.GetLength());
                                c1 = true;
                                break;
                            case 2:

                                do
                                {
                                    try
                                    {
                                        Console.WriteLine("Please enter  new length of rectangle:");
                                        var value = int.Parse(Console.ReadLine());
                                        if (value > 0)
                                        {

                                            r1.SetLength(value);
                                            flag1 = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter length greater 0");
                                            flag1 = true;
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e.Message);
                                        flag1 = true;
                                    }
                                } while (flag1 == true);
                                //Console.WriteLine("\n New Length of Rectangle is: " + r1.GetLength());
                                c1 = true;
                                break;
                            case 3:
                                Console.WriteLine("\n Width of Rectangle is: " + r1.GetWidth());
                                c1 = true;
                                break;
                            case 4:

                                do
                                {
                                    try
                                    {
                                        Console.WriteLine("Please enter  new width of rectangle:");
                                        var value = int.Parse(Console.ReadLine());
                                        if (value > 0)
                                        {

                                            r1.SetWidth(value);
                                            flag1 = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter width greater 0");
                                            flag1 = true;
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e.Message);
                                        flag1 = true;
                                    }
                                } while (flag1 == true);
                                c1 = true;
                                break;
                            case 5:
                                Console.WriteLine("\nPerimeter is:" + r1.GetPerimeter() + "\n ");
                                c1 = true;
                                break;
                            case 6:
                                Console.WriteLine("\nArea is:" + r1.GetArea() + "\n  ");
                                c1 = true;
                                break;
                            case 7:
                                Environment.Exit(0);
                                break;
                            default:
                                c1 = true;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n Please enter a correct choice ");
                        c1 = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    c1 = true;
                }
            } while (c1 == true);


        }
    }
}
