using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgram
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private ArrayList shapes = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            g = canvasBox.CreateGraphics();

            ShapeFactory factory = new ShapeFactory();
            try
            {
                shapes.Add(factory.getShape("circle"));
                shapes.Add(factory.getShape("triangle"));
                shapes.Add(factory.getShape("rectangle"));

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Invalid shape: " + e);

            }

            //add some random shapes
            Random rand = new Random(77887);
            for (int i = 0; i < 150; i++)
            {
                int x = rand.Next(Size.Width);
                int y = rand.Next(Size.Height);
                int size = rand.Next(250);

                int red = rand.Next(255);
                int green = rand.Next(255);
                int blue = rand.Next(255);

                Color newColour = Color.FromArgb(128, red, green, blue); //128 is semi transparent

                int shape = rand.Next(2);
                Shape s;
                switch (shape)
                {
                    case 0:
                        s = factory.getShape("circle");
                        s.set(newColour, x, y, size);
                        shapes.Add(s);// new Circle(newColour, x, y, size));

                        break;
                    case 1:
                        s = factory.getShape("rectangle");
                        s.set(newColour, x, y, size, size);
                        shapes.Add(s);
                        break;



                }
            }




        }


        //functionality for the form itself when loaded 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DrawingBoard_Click(object sender, EventArgs e)
        {

        }

        //functionality for the 'draw' / 'run' button
        private void button1_Click(object sender, EventArgs e)
        {

            ShapeFactory shapeFactory = new ShapeFactory();
            Pen pen = new Pen(Color.Red);
            Graphics g = canvasBox.CreateGraphics();

            g.DrawRectangle(pen, 20, 20, 50, 50);

            var input = commandText.Text;
            input.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);

            for (int i = 0; i < shapes.Count; i++)
            {

            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //functionality for clearing text box button
        private void textButton_Click(object sender, EventArgs e)
        {
            commandText.Clear();
        }


        //functionality for clearing canvas 
        private void canvasButton_Click(object sender, EventArgs e)
        {
        }

        private void canvasBox_Click(object sender, EventArgs e)
        {
          
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to exit?";
            const string caption = "Exit";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Functionality for load button 
        //Creates open file dialog using the button inside the menu bar
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }


            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

            }

        //functionality for command text box field 
        private void commandText_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //functionality for pen status (up or down)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //functionality for x coordinates
        private void xTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        //functionality for y coordinates 
        private void yTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void commandText_MouseHover(object sender, EventArgs e)
        {
            statusStrip1.Text = "Enter Commands Here";
        }

        private void commandText_MouseLeave(object sender, EventArgs e)
        {
            statusStrip1.Text = "";
        }

        private void toolStripStatusLabel1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }

    

