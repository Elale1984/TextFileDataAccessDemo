using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileDataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Docs\News.txt";

            //Creates a list of type Person to add the data from the file to the list 
            List<Person> people = new List<Person>();

            //Creates a list of type  string and reads the data from the file to this list
            List<string> news = File.ReadAllLines(file).ToList();

            //Exception handleing for wrong file path or for data not formatted  correctly.
            try
            {
               
                //reads each line from the news list and creates a Person person from that line
                foreach (string line in news)
                {
                    string[] entries = line.Split(',');

                    Person person = new Person();
                    person.lastName = entries[0];
                    person.firstName = entries[1];
                    person.url = entries[2];

                    //Adds the newly created person to the list of people
                    people.Add(person);
                }

                
            }
            catch (IOException)
            {
                Console.WriteLine("File Not Found");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The Format on one or more of the lines from the text doc was not compatable with the class Person. \nThis item was skipped\n\n");
             
            }

            // prints the list of people to the console
            Console.WriteLine("The List Of People\n");
            foreach (Person person in people)
            {
                Console.WriteLine("First Name: " + person.firstName + "\nLast Name: " + person.lastName + "\nURL: " + person.url + "\n");
            }




            //Write the contents of the list Person to a new file. Request user to create file name
            bool fileNameOK = false;

            do
            {
                Console.Write("\n\nEnter a name of a full file path that you wish to create (remeber to put .txt at the end): ");
                string newFile = Console.ReadLine();

                //MCalls method to create file and add contents to the file
                fileNameOK = CreateFile(newFile, people);
                
                //alert message letting the user know that the file was created successfuly 
                if (fileNameOK)
                {
                    Console.WriteLine("\nYour File Was Created!!");
                }

            } while (!fileNameOK); // loop continues until user enters a file name that is acceptable

           

            Console.ReadLine();
        }

        /*
         * This method takes in the file name that the user creates as well as the list of people. The filename is checked to make sure that
         * the file does not already exist. If it does, the method returns false and the user will be prompted for another file name. If the 
         * file name is avalable, the information from the list<Person> of people will be written in the new file and the method will return
         * true signaling success.
         */
        private static bool CreateFile(string newFile, List<Person> people)
        {

           

            try
            {
                // Check if file already exists. if the file exists already, the method will return false and the user will be requested to
                // choose another file name.
                if (File.Exists(newFile))
                {
                    Console.WriteLine("That File already exist, Try another name");
                    return false;
                }
                // if the file name does mot exist, the list<Person> people will be written to the new file 
                else
                {
                    // Create a new file
                    using (StreamWriter stream = File.CreateText(newFile))
                    {
                        //writing to the file 
                        foreach (Person person in people)
                        {
                            stream.WriteLine("First Name: " + person.firstName + ", Last Name: " + person.lastName + ", URL: " + person.url + "\n");

                        }
                    }
                    return true;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                return false;
            }
        }
    }
}
