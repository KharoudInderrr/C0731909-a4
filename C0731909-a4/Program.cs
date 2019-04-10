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
      











        }
}
