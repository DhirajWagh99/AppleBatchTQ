using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpPro
{
    
        class Question
        {
            string questioN;
            string option_A;
            string option_B;
            string option_C;
            string option_D;
            string correctoption;

            public Question(string questioN, string option_A, string option_B, string option_C, string option_D, string correctoption)
            {
                this.QuestioN = questioN;
                this.Option_A = option_A;
                this.Option_B = option_B;
                this.Option_C = option_C;
                this.Option_D = option_D;
                this.Correctoption = correctoption;
            }

            public string QuestioN { get => questioN; set => questioN = value; }
            public string Option_A { get => option_A; set => option_A = value; }
            public string Option_B { get => option_B; set => option_B = value; }
            public string Option_C { get => option_C; set => option_C = value; }
            public string Option_D { get => option_D; set => option_D = value; }
            public string Correctoption { get => correctoption; set => correctoption = value; }
        }

        class Quiz
        {
            static List<Question> Csharp = new List<Question>();
            static List<Question> java = new List<Question>();
            static Dictionary<string, List<Question>> dt = new Dictionary<string, List<Question>>();
            static int score = 0;
            static Quiz()
            {
                Csharp.Add(new Question("Q1 Which of the following converts a type to a double type in C#?", "ToDecimal", "ToDouble", "ToInt32", "ToInt16", "B"));
                Csharp.Add(new Question("Q2 Which of the following is the default access specifier of a class member function?", "private", "protected", "public", "internal", "A"));
                Csharp.Add(new Question("Q3 Abstract class contains _____.", "Abstract methods", " Non Abstract methods", "both", "none", "C"));
                Csharp.Add(new Question("Q4 The point at which an exception is thrown is called the _____.", "Default point", "Invoking point", "Calling point", "Throw point", "D"));
                Csharp.Add(new Question("Q5 Struct’s data members are ___ by default.", "Protected", "Public ", "Private", "Default", "C"));
                Csharp.Add(new Question("Q6 Which of the following keywords is used to refer base class constructor to subclass constructor?", "this", "static", "base", "extend", "C"));
                Csharp.Add(new Question("Q7 C# has strong resemblance with?", "C", "C++", "Java", "Python", "C"));

                Csharp.Add(new Question("Q8 Number of digits upto which precision value of float data type is valid?", "Upto 6 digit", "Upto 7 digit", "Upto 8 digit", "Upto 9 digit", "B"));

                java.Add(new Question("___ Operator is used to creating an object.", "class", "new", "print", "main", "B"));
                java.Add(new Question("Which of the following is not a Looping statement ___", "FOR", "SWITCH", "WHILE", "DO-WHILE", "B"));
                java.Add(new Question("___ is a multi-way branch statement", "switch", "continue", "break", "label", "A"));
                java.Add(new Question("The ___ statement is used inside the switch to terminate a Statement sequence", "break ", "jump", "exit", "goto", "A"));
                java.Add(new Question("A class that is inherited is called a  ___", "superclass", "subclass", "subsetclass", "relative class", "A"));

            }

            static void Main(string[] args)
            {
                Console.WriteLine("hello Enter your name");
                string s = Console.ReadLine();
                Console.WriteLine($"Hello {s} Welcome Lets Start the Quiz");
                Console.WriteLine("1) C#    2) JAVA  press 1 for C#  Press 2 for JAVA");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine($"hello {s} your choice {choice} lets start quiz on C#.............");
                    for (int i = 0; i < Csharp.Count; i++)
                    {
                        Console.WriteLine(Csharp[i].QuestioN);
                        Console.WriteLine("a :" + Csharp[i].Option_A);
                        Console.WriteLine("b :" + Csharp[i].Option_B);
                        Console.WriteLine("c :" + Csharp[i].Option_C);
                        Console.WriteLine("d : " + Csharp[i].Option_D);
                        Console.WriteLine($"enter correct option");
                        string ans = Console.ReadLine();
                        if (ans == Csharp[i].Correctoption)
                        {
                            Console.WriteLine("correct answer");
                        }
                        else
                        {
                            Console.WriteLine("wrong ans");
                        }
                        //Console.WriteLine("correct answer :" + Csharp[i].Correctoption);
                    }
                }

                else if (choice == 2)
                {
                    Console.WriteLine($"hello {s} your choice {choice} lets start quiz on Java............");
                    for (int i = 1; i < java.Count; i++)
                    {
                        Console.WriteLine(java[i].QuestioN);
                        Console.WriteLine("a :" + java[i].Option_A);
                        Console.WriteLine("b :" + java[i].Option_B);
                        Console.WriteLine("c :" + java[i].Option_C);
                        Console.WriteLine("d : " + java[i].Option_D);
                        //Console.WriteLine("correct answer :" + java[i].Correctoption);
                    }

                }

            }
        }
    
}
