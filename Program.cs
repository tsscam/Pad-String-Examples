using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            string SSN = "244119999";

            Console.WriteLine(SSN.Substring(5).PadLeft(9, '*'));

            char[] ListofChars = new char[3];

            SSN.CopyTo(4, ListofChars, 0, 5);


            string input = "OneTwoThree";
            string sub1 = input.Substring(0, 3);
            Console.WriteLine(sub1);


            Console.WriteLine(input.Substring(8));
            string str = "Hello!";
            string Message = str + " World";

            string Message = String.Concat(str, "World");

            string[] WordList = Message.Split('\n');

            string str1 = "402";
            Console.WriteLine(str1.PadLeft(10, '*'));


            Char[] delimit = { ' ', ','.}*/
             StringBuilder sb = new StringBuilder();
            sb.AppendLine("first line");
            sb.AppendLine("second line");
            sb.AppendLine("third line");
            string s = sb.ToString();
            Console.WriteLine(s);

            Splitting multiline string into separate lines
            string[] splitted = s.Split(new string[]);

            Output(separate lines)
            for (int i = 0; i < splitted.Count(); i++)
            {
                Console.WriteLine("{0}: {1}", i, splitted[i]);
            }
            bool run = true;
            do
            {
                string str = "I am a Vanilla fan! I love learning these skills.";
                Console.WriteLine(str.IndexOf("l"));
                Console.WriteLine(str.LastIndexOf("a"));
                Console.WriteLine(str.EndsWith("?"));
                string fullName = "AdamSmith";
                var names = fullName.Split(' ');
                string firstName = names[0];
                string lastName = names[1];
                string value = "cat\r\ndog\r\nanimal\r\nperson";
                Split the string on line breaks.
                 ... The return value from Split is a string array.
                string[] lines = Split(value, "\r\n");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);


                    string str = txtFullName.Text;
                    txtFirstName.Text = str.Substring(0, str.IndexOf(' '));
                    txtMidName.Text = str.Substring(str.IndexOf(' ') + 1, str.LastIndexOf(' ') - str.IndexOf(' ') | 1);
                    txtLastName.Text = str.Substring(str.LastIndexOf(' ') + 1, str.Length - str.LastIndexOf(' ') - 1);

                    string input = Console.ReadLine();

                }* while (true);
            }
        public static Tuple<Person, bool> Try Parse(string name)
        {
            bool success;
            var names = name.Split(' ');
            if (names.Length == 2)
            {
                success = true;
                return Tuple.Create(new Person(nam[0], names[1]), success);
            }
            else
            {
                success = false;
                return Tuple.Create(Person) null, success);
            }
            }       

