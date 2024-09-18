using System.Collections;
namespace DataTypesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Stack courses1 = new Stack();
            courses1.Push("BSIT");
            courses1.Push("BSA");
            courses1.Push("BSCS");
            courses1.Push("BMMA");
            courses1.Push("BSHM");
            courses1.Push("BSCE");
            courses1.Push("BSAI");
            courses1.Push("BSBA");
            while (0 < courses1.Count)
            {
                courseBox.Items.Add(courses1.Pop());
            }

            Stack levels = new Stack();
            levels.Push("IRREGULAR");
            levels.Push("4th Year - 2nd Sem");
            levels.Push("4th Year - 1st Sem");
            levels.Push("3rd Year - 2nd Sem");
            levels.Push("3rd Year - 1st Sem");
            levels.Push("2nd Year - 2nd Sem");
            levels.Push("2nd Year - 1st Sem");
            levels.Push("1st Year - 2nd Sem");
            levels.Push("1st Year - 1st Sem"); 
            while (0 < levels.Count)
            {
                yearlevelBox.Items.Add(levels.Pop());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string lName = lastnameBox.Text;
            string fName = firstnameBox.Text;
            string mName = middlenameBox.Text;
            string section = sectionBox.Text;
            string yearLevel = yearlevelBox.Text;
            string course = courseBox.Text;
            int idNum = Int32.Parse(idnumberBox.Text);
            string studName = ("Student Name: " + "\n" + lName + ", " + fName + " " + mName + ".");
            string id = ("ID Number: " + "\n" + idNum);
            string sect = ("Section: " + "\n" + section);
            string yL = ("Year Level: " + "\n" + yearLevel);
            string crse = ("Course: " + "\n" + course);
            MessageBox.Show(studName + "\n" + "\n" + id + "\n" + "\n" + sect + "\n" + "\n" + yL + "\n" + "\n" + crse + "\n");


        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
