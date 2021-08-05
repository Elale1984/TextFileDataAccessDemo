using System;
using System.Collections.Generic;
using System.Text;

namespace TextFileDataAccessDemo
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string url { get; set; }

        //This override tostring method in intended to display the full data information
        //in the listbox of the form1
        public override string ToString()
        {
            return firstName + " " + lastName + " " + url;
        }
    }
}
