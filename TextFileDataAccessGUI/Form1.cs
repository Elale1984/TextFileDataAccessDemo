using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileDataAccessDemo;

namespace TextFileDataAccessGUI
{
    public partial class Form1 : Form
    {

        List<Person> people = new List<Person>();
        public BindingSource bindingSource = new BindingSource();
         
        public Form1()
        {
            InitializeComponent();

        }

        

        private void btn_SaveToList_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person();
                person.firstName = tb_FName.Text;
                person.lastName = tb_LName.Text;
                person.url = tb_URL.Text;

                people.Add(person);
                bindingSource.ResetBindings(false);
               
                tb_FName.Clear();
                tb_LName.Clear();
                tb_URL.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Oops, you missed something or put incompatable data \nin one or more of your feeds. \n\nTry again");
            }


        }

       

        private void btn_LoadFromFile_Click(object sender, EventArgs e)
        {
            ofd_File.ShowDialog();
            ofd_File.InitialDirectory = "c:\\";
            ofd_File.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd_File.FilterIndex = 2;
            ofd_File.RestoreDirectory = true;

            if (ofd_File.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd_File.FileName;
                //Creates a list of type  string and reads the data from the file to this list
                List<string> news = File.ReadAllLines(filePath).ToList();

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

                        // update display members
                        bindingSource.ResetBindings(false);

                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("One or more of the pieces of information were incorrect in the format. These items were skipped.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            bindingSource.DataSource = people;
            lb_PersonList.DataSource = bindingSource;
            lb_PersonList.DisplayMember = people.ToString();
            



        }

        private void btn_SaveToFile_Click_1(object sender, EventArgs e)
        {
          
            string newFileName = "";

           
           
            FileName newFile = new FileName(newFileName);
            newFile.ShowDialog();
            newFileName = newFile.tb_FilePath.Text + "\\" + newFile.tb_NewFileName.Text + ".txt";


            

            if (!File.Exists(newFileName) && newFileName != "\\.txt") // If file does not exists
            {
                File.Create(newFileName).Close(); // Create file
                using (StreamWriter sw = File.AppendText(newFileName))
                {
                    foreach (Person person in people)
                    {
                        sw.WriteLine(person.firstName + " " + person.lastName + " " + person.url);
                    }
                }

            }
            else // If file already exists
            {
                if(newFileName != "\\.txt")
                    MessageBox.Show("File Already Exists. Cannot create file");
                else
                    MessageBox.Show("File Name Required");


            } 
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
