using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;



namespace C0731909_a4
{
    class Program
    {
        ArrayList Beowulf;
        int linecount = 0;
         ArrayList lineNumbers2 = new ArrayList();
        int linenumber= 1;


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
            p.lineCount();
            p.countWords();
            p.Foundnumber();
         
          
           
          


        }

        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/731909/C0731909-a4/Beowulf.txt"))
            {

                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);

                }
                file.Close();
                Console.WriteLine($"File has{counter} lines");





            }

        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }

            }
            return countSpaces;
        }

        public void lineCount()
        {
            string line;
            TextReader reader = new StreamReader("U:/Users/731909/C0731909-a4/Beowulf.txt");
            while ((line = reader.ReadLine()) != null)
            {
                linecount++;
            }
            reader.Close();

            Console.WriteLine(linecount);

        }

        public void countWords()
        {
            StreamReader sr = new StreamReader("U:/Users/731909/C0731909-a4/Beowulf.txt");
            int counter = 0;
            string delim = ",";
            string[] fields = null;
            string line = null;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;

            }

            sr.Close();
            Console.WriteLine("the number of words in the text file is {0}", counter);


        }

        public void Foundnumber()
        {
            using (StreamReader file = new StreamReader("U:/Users/731909/C0731909-a4/Beowulf.txt"))

            {
                int counter = 0;

                int number = 0;

                string line;

                while ((line = file.ReadLine()) != null)

                {

                    if (line.Contains("Sea") && line.Contains("Fare") || line.Contains("sea") && line.Contains("fare"))

                    {

                        int x = counter - 1;

                        number++;

                    }

                    counter++;

                }

                Console.WriteLine($"The number of lines that contains *Sea* and *Fare* are {number}");

                file.Close();

            }

        }
        public void Averagenumber()
        {

            using (StreamReader sr = new StreamReader("U:/Users/731909/C0731909-a4/Beowulf.txt"))
            {
                string line;
                int counter = 0;
                int b = 0, myWord = 1;
                int averageLetterPerWord;
                int counterletters = 0;
                int countspaces = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    FindNumberOfBlankSpaces(line);
                    counter++;

                    while (b <= line.Length - 1)
                    {
                        if (line[b] == ' ' || line[b] == '\n' || line[b] == '\t')
                        {
                            myWord++;
                        }
                        b++;
                    }
                    b = 0;

                }

                averageLetterPerWord = counterletters / countspaces;

                Console.WriteLine("\n\n\n\n********************************\nThe number of lines in the paragraph is " + counter);
                Console.WriteLine("The number of words in paragraph is " + myWord);
                Console.WriteLine("The number of average letters per word is " + averageLetterPerWord);
                Console.ReadLine();




               

                // SECTION D
                if (line.Substring(0).Contains("fare") || line.Substring(0).Contains("Fare"))
                {
                    if (!(line.Substring(0).Contains("war") || line.Substring(0).Contains("War")))
                    {
                        lineNumbers2.Add(linenumber);
                    }
                    Console.WriteLine(linenumber);

                }
            }
        }














        }
}
