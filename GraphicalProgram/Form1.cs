using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GraphicalProgram
{
    public partial class Form1 : Form
    {

        private System.Drawing.Graphics g;
        private ArrayList shapes = new ArrayList();
        private static Pen activePen;

        private 

        bool penPosition = false;
        int X = 0;
        int Y = 0;

        public Form1()
        {

            
            InitializeComponent();
            g = canvasBox.CreateGraphics(); //allows graphics to be drawn onto graphics panel


            ShapeFactory factory = new ShapeFactory();
            try
            {
                shapes.Add(factory.getShape("circle"));
                shapes.Add(factory.getShape("triangle"));
                shapes.Add(factory.getShape("rectangle"));
                shapes.Add(factory.getShape("polygon"));

            }
            catch (ArgumentException e)  //throw argument if invalid shape added. rather than exit or cancel program
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

            //instantiate new shape factory previously created 
            ShapeFactory shapeFactory = new ShapeFactory();

            //create new pen with default color set to black 
            Pen pen = new Pen(Color.Black);

            //allows graphics to be drawn to set picturebox 
            Graphics g = canvasBox.CreateGraphics();


            
            //take input and split 
            //allows multiple lines or commands to be entered at once 
            var input = commandText.Text;
            input.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);

            //functionality for pen up command 
            //canvas colour is set to White. Pen up color set to white, until workaround or appropriate function found.
            if (penPosition.Equals(false))
            {
               
                pen.Color = Color.White;

                if (input.Contains("Move"))
                {
                    string[] movement = input.Split();
                    string x = movement[1];
                    string y = movement[2];

                    int numX = int.Parse(x);
                    int numY = int.Parse(y);

                    Console.WriteLine(x);
                    Console.WriteLine(y);

                    Y = numX;
                    X = numY;
                }


            }

            //functionality for pen down command
            //when pen down the default colour is black 
            //hardcoded black (unless changed)
            if (penPosition.Equals(true))

            
            {
                
                pen.Color = Color.Black;

                //functionality for drawing circle to canvas 
                if (input.Contains("Circle"))
                {

                    try
                    {
                        string[] moveCircle = input.Split();
                        string radius = moveCircle[1];

                        int rad = int.Parse(radius);

                        Console.WriteLine(radius);

                        g.DrawEllipse(pen, X, Y, rad, rad);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The Format should be like this - 'Circle 0 0'", "Circle Error!");
                    }
                }

                //functionality for drawing circle to canvas 
                //rather than height and width, radius is used 
                //moves circle based on command input 
                //changes size based on given value from command prompt 
                //repeats the circle to canvas hardcoded 
                if (input.Contains("RepeatCirc"))
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
                        g.DrawEllipse(pen, 60, 60, rad, rad);
                        g.DrawEllipse(pen, 70, 70, rad, rad);
                        g.DrawEllipse(pen, 80, 80, rad, rad);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The Format should be like this - 'RepeatCirc 0 0'", "Repeat Circle Error!");
                    }
                }

                //functionality for drawing repeat rectangle to canvas 
                //takes variables for moving rectangle and the split string input 
                //takes variable for width and height 
                //parses variables for height and width 
                //publishes writeline for width and height 
                //draws repeated rectangle to canvas (hardcoded) 
                if (input.Contains("RepeatRect"))
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
                        g.DrawRectangle(pen, 10, 10, wid, hei);
                        g.DrawRectangle(pen, 20, 20, wid, hei);
                        g.DrawRectangle(pen, 30, 30, wid, hei);
                        g.DrawRectangle(pen, 40, 40, wid, hei);
                        g.DrawRectangle(pen, 50, 50, wid, hei);
                        g.DrawRectangle(pen, 60, 60, wid, hei);
                        g.DrawRectangle(pen, 70, 70, wid, hei);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The Format should be like this - 'RepeatRect 0 0'", "Repeat Rectangle Error!");
                    }
                }

                //functionality for moving pen via coordinates of x and y
                //writes movement to console for 'x' and 'y' axis
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

                if (input.Contains("Move"))
                {
                    string[] movement = input.Split();
                    string x = movement[1];
                    string y = movement[2];

                    int numX = int.Parse(x);
                    int numY = int.Parse(y);

                    Console.WriteLine(x);
                    Console.WriteLine(y);

                    g.DrawLine(pen, X, Y, numX, numY);
                    Y = numX;
                    X = numY;
                }

                for (int i = 0; i < shapes.Count; i++)
                {

                }

                //functionality for drawing rectangle to canvas
                //takes variables for moving the rectangle and splits
                //takes variable for height and width 
                //parses both variables for height and width 
                //pushes width and height to writeline to show functionality 
                //draws rectangle based on pen, pen position, and the variables for size (width and height) set from command prompt
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



                for (int i = 0; i < shapes.Count; i++)
                {

                }
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

        //functionality for exiting the application when clicking 'x' in right corner
        //if the user presses yes, application ends, if they press no, dialog closes
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
                openFileDialog.InitialDirectory = "c:\\"; //assumes default directory is c:\\
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //types of file formats available to be used or saved as
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

        //functionality for saving document with save dialog prompt 
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
            if (penPosition = false);
            {
                
            }



        }


        //functionality for x coordinates
        private void xTxtbox_TextChanged(object sender, EventArgs e)
        {
            xTxtbox.Text.IndexOf('x');
        }

        //functionality for y coordinates 
        private void yTxtbox_TextChanged(object sender, EventArgs e)
        {
            xTxtbox.Text.IndexOf('y');
        }

        //toolstrip prompt when hovering over command box entry to show 'Enter Commands Here'
        private void commandText_MouseHover(object sender, EventArgs e)
        {
            statusStrip1.Text = "Enter Commands Here";
        }

        //moves to blank in toolstrip when not hovering over object 
        private void commandText_MouseLeave(object sender, EventArgs e)
        {
            statusStrip1.Text = "";
        }


        private void toolStripStatusLabel1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //prompt for starting 'new' or clicking 'new' from 'file'
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

        //prompt for clicking pen up info
        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have lifted the Pen from the Canvas.",
                "Pen Up");

            penPosition = false;
        }
        //prompt for clicking pen down info
        private void coloursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have put the pen on the Canvas.",
                "Pen Down");

            penPosition = true;
        }

        //prompt for clicking rectangle info
        private void commandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This command will allow the user to draw a Rectangle to the Canvas. A Rectangle needs an x and y coordinate. Use this like 'Rectangle 50 50'.",
                "Rectangle");
        }

        //prompt for clicking circle info
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This command will allow the user to draw a Circle to the Canvas. A Circle needs an x and y coordinate. Use this like 'Circle 50 50'.",
                "Circle");
        }

        //prompt fir clicking triangle info
        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This command will allow the user to draw a Triangle to the Canvas. A Triangle is simply drawn to the canvas like this 'Triangle'",
                "Triangle");
        }

        //prompt for clicking polygon info
        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This command will allow the user to draw a Polygon to the Canvas. A Polygon is simply drawn to the canvas like this 'Polygon",
                "Polygon");
        }
    }
    }

    

