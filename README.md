AddTwoNumbers - Simple Windows Forms GUI App
Overview

AddTwoNumbers is a simple Windows Forms (WinForms) application built in C# that allows users to add two numbers via a graphical interface. This project demonstrates the basics of WinForms, event handling, and user input validation in a .NET desktop application.

Features

Simple GUI with two input text boxes for numbers.

Add button to calculate the sum.

Displays the result dynamically in a label.

Lightweight and beginner-friendly.

Project Structure
MyWinApp/
├── Program.cs          # Entry point of the application
├── Form1.cs            # Main form logic (UI + event handling)
├── Form1.Designer.cs   # Designer-generated code for the form layout
├── MyWinApp.csproj     # Project file (includes WindowsForms settings)
└── README.md           # Project documentation

Requirements

.NET 8.0 SDK or later

Windows OS (WinForms is Windows-only)

Setup Instructions

Clone or download the project to your local machine.

Open a terminal in the project folder (MyWinApp).

Restore dependencies:

dotnet restore


Build and run the application:

dotnet run


The GUI window should appear, allowing you to input two numbers and calculate the sum.

Key Code Highlights
Form1.cs (Core UI & Logic)
TextBox txt1, txt2;
Button btn;
Label result;

btn.Click += AddNumbers;  // Event handler

private void AddNumbers(object? sender, EventArgs e)
{
    int a = int.Parse(txt1.Text);
    int b = int.Parse(txt2.Text);
    result.Text = "Result: " + (a + b);
}


Uses nullable-aware event handler object? sender for compatibility with C# 8+.

Dynamically adds controls to the form without relying on the designer.

Program.cs (Application Entry)
Application.SetHighDpiMode(HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.Run(new Form1());


Ensures the application runs correctly with Windows Forms styling.

Notes

Ensure Form1.cs and Program.cs are in the same namespace or import the correct namespace.

Project uses <UseWindowsForms>true</UseWindowsForms> in the .csproj file.

License

This project is open-source and free to use for learning and experimentation.
<img width="1440" height="900" alt="image" src="https://github.com/user-attachments/assets/3f51e82e-d744-4a0a-8ee8-ee93a227940a" />
<img width="166" height="210" alt="image" src="https://github.com/user-attachments/assets/7111f20c-4bc4-4527-95dd-c35411b4ca4d" />

