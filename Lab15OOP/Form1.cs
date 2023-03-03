using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) //task 4
        {
            // Read input values from text boxes
            int a = int.Parse(sideATextBox.Text);
            int b = int.Parse(sideBTextBox.Text);
            int c = int.Parse(sideCTextBox.Text);

            // Check if the values represent a triangle
            bool isTriangle = (a + b > c) && (b + c > a) && (c + a > b);

            // Calculate the area if the values represent a triangle
            double area = 0;
            if (isTriangle)
            {
                double s = (a + b + c) / 2.0;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }

            // Display the results in the output label
            if (isTriangle)
            {
                outputLabel.Text = $"Sides {a}, {b}, {c} form a triangle with area {area:F2}";
            }
            else
            {
                outputLabel.Text = $"Sides {a}, {b}, {c} do not form a triangle";
            }
        }

        private void calculateButton1_Click(object sender, EventArgs e)//task 2
        {
            double sideLength = Convert.ToDouble(sideTextBox.Text);

            // Calculate the area of the equilateral triangle
            double area = (Math.Sqrt(3) / 4) * sideLength * sideLength;
            areaLabel.Text = $"Area: {area:F2}";

            // Calculate the height of the equilateral triangle
            double height = Math.Sqrt(3) / 2 * sideLength;
            heightLabel.Text = $"Height: {height:F2}";

            // Calculate the radius of the inscribed circle
            double inscribedRadius = sideLength / (2 * Math.Sqrt(3));
            inscribedCircleLabel.Text = $"Inscribed Circle Radius: {inscribedRadius:F2}";

            // Calculate the radius of the circumscribed circle
            double circumscribedRadius = sideLength / Math.Sqrt(3);
            circumscribedCircleLabel.Text = $"Circumscribed Circle Radius: {circumscribedRadius:F2}";
        }

        private void calculateButton2_Click(object sender, EventArgs e)//task 1
        {
            // Read input values from text boxes
            double x = double.Parse(xTextBox.Text);
            double y = double.Parse(yTextBox.Text);

            // Calculate the value of the expression
            double result = x * Math.Log(x) + (y / (Math.Cos(x) - x / 3.0));

            // Display the result in the output label
            outputLabel1.Text = $"The value of the expression is {result:F2}";
        }

        private void checkButton_Click(object sender, EventArgs e)//task 3
        {
            // Read input value from text box
            int n = int.Parse(numberTextBox.Text);

            // Check if digits form strictly increasing sequence
            bool isIncreasing = true;
            int lastDigit = n % 10;
            n /= 10;
            while (n > 0)
            {
                int currentDigit = n % 10;
                if (currentDigit >= lastDigit)
                {
                    isIncreasing = false;
                    break;
                }
                lastDigit = currentDigit;
                n /= 10;
            }

            // Display result in output label
            outputLabel3.Text = $"The digits of {n} form a strictly increasing sequence: {isIncreasing}";
        }

        private void findButton_Click(object sender, EventArgs e)//task 6
        {
            // Read input string from text box
            string input = inputTextBox.Text;

            // Split input string into words
            string[] words = input.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Find words that start and end with the same letter
            string[] matchingWords = words.Where(w => w.Length > 1 && w[0] == w[w.Length - 1]).ToArray();

            // Build output string
            string output = string.Join(", ", matchingWords);

            // Display output in output label
            outputLabel6.Text = $"The words that start and end with the same letter are: {output}";
        }

        private void replaceButton_Click(object sender, EventArgs e)//task 7
        {
            // Read input string from text box
            string input = inputTextBox7.Text;

            // Replace all colons with semicolons and count the number of replacements
            int numReplacements = 0;
            string output = "";
            foreach (char c in input)
            {
                if (c == ':')
                {
                    output += ';';
                    numReplacements++;
                }
                else
                {
                    output += c;
                }
            }

            // Display output in output label
            outputLabel7.Text = $"Replaced {numReplacements} colons with semicolons. Result: {output}";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void countButton_Click(object sender, EventArgs e)//task 5
        {
            // Read input value from text box
            int n = int.Parse(numberrTextBox.Text);

            // Count numbers not divisible by 2, 3, or 5
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    count++;
                }
            }

            // Display result in output label
            outputLabel5.Text = $"The number of natural numbers not exceeding {n} and not divisible by 2, 3, or 5 is: {count}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
