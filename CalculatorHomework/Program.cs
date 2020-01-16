﻿using System;

namespace CalculatorHomework
{
    class Program
    {

        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public static void calc(String formula)
        {

            String sub_form = formula.Split("(")[1];
            Console.WriteLine(sub_form);
            String simple;
            if (sub_form.Contains("add") || sub_form.Contains("sub") || sub_form.Contains("mul") || sub_form.Contains("div")) {
                simple = "no";
            } else
            {
                simple = "yes";
            }

            if (simple == "yes")
            {


                String operation = formula.Substring(0, 3);
                String operand1 = formula.Split(",")[0];
                String sop1 = operand1.Split("(")[1].Trim();
                //Console.WriteLine(op1);
                String operand2 = formula.Split(",")[1];
                //Console.WriteLine(operand2);
                String sop2 = operand2.Split(")")[0].Trim();
                int op1 = int.Parse(sop1);
                int op2 = int.Parse(sop2);
                // Console.WriteLine(op1);
                // Console.WriteLine(op2);
                // int op1 = int.Parse(operand1);
                // String operand2 = formula.Substring(formula.IndexOf(',') + 2, formula.IndexOf(')') - 1);
                // int op2 = int.Parse(operand2);

                 switch (operation)
                 {
                     case "add":
                         Console.Write("Additoin: ");
                         add(op1, op2);
                         break;

                     case "sub":
                         Console.Write("Subtraction: ");
                         sub(op1, op2);
                         break;

                     case "mul":
                         Console.Write("Multiplication: ");
                         mul(op1, op2);
                         break;

                     case "div":
                         Console.Write("Division: ");
                         div(op1, op2);
                         break;

                     default:
                         Console.WriteLine("Not possible in current context");
                         break;
                 }

                /*Console.WriteLine(op1);
                Console.WriteLine(op2);*/
            }

            else
            {
                String sub_form1 = formula.Split(",")[2];
                Console.WriteLine(sub_form1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // calc("add(1, 3)");
            calc("add(1, add(10, 5))");
            /*calc("sub(1, -3000)");
            calc("mul(5, 10)");
            calc("div(50, 6)");*/
        }
    }
}
