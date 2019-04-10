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
        int linecount =  0 ;
        
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();


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
                while((ln = file.ReadLine()) != null)
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
            foreach(char c in line)
            {
                if(char.IsLetter(c)) { countletters++; }
                if(char.IsWhiteSpace(c)) { countSpaces++; }

            }
            return countSpaces;
        }

        public void lineCount()
        {
            string line;
            TextReader reader = new StreamReader("U:/Users/731909/C0731909-a4/Beowulf.txt");
            while((line = reader.ReadLine()) != null)
            {
                linecount++;
            }
            reader.Close();

        }
       
   

       

       
    }
}
