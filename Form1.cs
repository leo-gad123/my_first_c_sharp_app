using System;
using System.Windows.Forms;

namespace AddTwoNumbers
{
    public partial class Form1 : Form
    {
        TextBox txt1, txt2;
        Button btn;
        Label result;

        public Form1()
        {
            InitializeComponent();

            txt1 = new TextBox() { Left = 20, Top = 20, Width = 100 };
            txt2 = new TextBox() { Left = 20, Top = 60, Width = 100 };

            btn = new Button() { Left = 20, Top = 100, Text = "Add", Width = 100 };
            btn.Click += AddNumbers; // Event handler

            result = new Label() { Left = 20, Top = 150, Width = 200, Text = "Result: " };

            Controls.Add(txt1);
            Controls.Add(txt2);
            Controls.Add(btn);
            Controls.Add(result);
        }

        private void AddNumbers(object? sender, EventArgs e) // <- note object? here
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int c = a + b;

            result.Text = "Result: " + c;
        }
    }
}
