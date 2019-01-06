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

        private System.Drawing.Graphics g;
        private ArrayList shapes = new ArrayList();
        private static Pen activePen;

        bool penPosition = false;


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


        //dialog prompt for closing application via 'x' with yes or no prompt
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the program?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
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
            Pen pen = new Pen(Color.Black);
            Graphics g = canvasBox.CreateGraphics();

            
            //take input and split 
            var input = commandText.Text;
            input.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);


            //functionality for drawing circle to canvas 
            if (input.Contains("Circle"))
            {

                try
                {
                    string[] moveCircle = input.Split();
                    string radius = moveCircle[1];

                    int rad = int.Parse(radius);

                    Console.WriteLine(radius);

                    g.DrawEllipse(pen, 0, 0, rad, rad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The Format should be like this - 'Circle 0 0'", "Circle Error!");
                }
            }

            //functionality for drawing circle to canvas 
            if (input.Contains("Repeat"))
            {

                try
                {
                    string[] moveCircle = input.Split();
                    string radius = moveCircle[1];

                    int rad = int.Parse(radius);

                    Console.WriteLine(radius);

                    g.DrawEllipse(pen, 0, 0, rad, rad);
                    g.DrawEllipse(pen, 10, 10, rad, rad);
                    g.DrawEllipse(pen, 20, 20, rad, rad);
                    g.DrawEllipse(pen, 30, 30, rad, rad);
                    g.DrawEllipse(pen, 40, 40, rad, rad);
                    g.DrawEllipse(pen, 50, 50, rad, rad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The Format should be like this - 'Repeat 0 0'", "Repeat Error!");
                }
            }

            //functionality for moving pen via coordinates of x and y
            if (input.Contains("move"))
            {
                string[] movement = input.Split();
                string x = movement[1];
                string y = movement[2];

                int numX = int.Parse(x);
                int numY = int.Parse(y);


                Console.WriteLine(x);
                Console.WriteLine(y);

            }

            //functionality for drawing rectangle to canvas 
            if (input.Contains("Rectangle"))
            {

                try
                {
                    var moveRect = input.Split();
                    var width = moveRect[1];
                    var height = moveRect[2];

                    var wid = int.Parse(width);
                    var hei = int.Parse(height);

                    Console.WriteLine(width);
                    Console.WriteLine(height);

                    g.DrawRectangle(pen, 0, 0, wid, hei);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The Format should be like this - 'Rectangle 0 0'", "Rectangle Error!");
                }

            }

            //functionality for drawing triangle to canvas 
            if (input.Contains("Triangle"))
            {
                // Create points that define polygon.
                Point point1 = new Point(0, 50);
                Point point2 = new Point(50, 0);
                Point point3 = new Point(50, 100);
                Point[] curvePoints =
                {
                    point1,
                    point2,
                    point3,
                };
                // Draw polygon to screen.
                g.DrawPolygon(pen, curvePoints);
            }
        
            //functionality for drawing Polygon to canvas 
            if (input.Contains("Polygon"))
            {

                // Create points that define polygon.
                Point point1 = new Point(50, 50);
                Point point2 = new Point(100, 25);
                Point point3 = new Point(200, 5);
                Point point4 = new Point(250, 50);
                Point point5 = new Point(300, 100);
                Point point6 = new Point(350, 200);
                Point point7 = new Point(250, 250);
                Point[] curvePoints =
                {
                    point1,
                    point2,
                    point3,
                    point4,
                    point5,
                    point6,
                    point7
                };

                // Draw polygon to screen.
                g.DrawPolygon(pen, curvePoints);

            }

            //functionality for pen up command 
            if (input.Contains("Pen Up"))
            {
                pen.Color = Color.White;
            }

            //functionality for pen down command
            if (input.Contains("Pen Down"))
            {
                pen.Color = Color.Red;
                g.DrawRectangle(pen, 0, 0, 50, 50);
            }


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
            g.Clear(Color.White);

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
            MessageBox.Show("This Program was built to help understand simple programming concepts.",
                "Help");
        }

        //functionality for command text box field 
        private void commandText_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //functionality for pen status (up or down) (changing colour based on pen being in use or not)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (penPosition = false) ;
            {
                
            }

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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Start Again?", "New", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                g.Clear(Color.White);
                commandText.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }

        }

        private void colourBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

    

