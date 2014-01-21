using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Core
{
    public class PlainTextIO
    {
        public static String ReadFile(string fileName)
        {
            //Setup StreamReader to read from the filename passed in from Main.
            using (var sr = new StreamReader(fileName))
            {
                //Setting line to equal the first line of the text file.
                var line = sr.ReadLine();

                //Checking to see if the file is null, if it's not then return the number from it to Main.
                if (line != null)
                {
                    return line;
                }

                //Close the StreamReader.
                sr.Close();
            }

            //If something didn't go right then just retyurn null to Main.
            return null;
        }

        public static String WriteFile(string fileName, IEnumerable<int> numberList)
        {
            //Setup the StreamWriter to use the filename passed in from Main.
            using (var sw = new StreamWriter(fileName))
            {
                //Iterate though each number in the list and write it to the file passed in from Main.
                foreach (var i in numberList)
                {
                    sw.WriteLine(i);
                }

                //Close the StreamWriter
                sw.Close();
            }

            //If something didn't go right then just retyurn null to Main.
            return null;
        }
    }
}