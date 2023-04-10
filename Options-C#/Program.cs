using System;

public class Program {
    public static void Main() {
        ViewMenu();
        string option = Console.ReadLine();
        ProcesarOpcion(option);
    }
    
    public static void ViewMenu() {
        Console.WriteLine("Choose one option of FasttWeb:");
        Console.WriteLine("1. Computers");
        Console.WriteLine("2. Programming");
        Console.WriteLine("3. C#");
        Console.WriteLine("4. Exit");
    }
    
    public static void ProcesarOpcion(string opcion) {
        switch(opcion) {
            case "1":
                Console.WriteLine("\n");
                Console.WriteLine("Hello, Computer, computer or computer​​​ is a programmable digital electronic machine that executes a series of commands to process the input data, conveniently obtaining information that is later sent to the output units.");
                break;
            case "2":
                Console.WriteLine("\n");
                Console.WriteLine("Hello, Programming is the process of creating a set of instructions that tells a computer how to perform some type of task. But not just the action of writing code for the computer or software to run.");
                break;
            case "3":
                Console.WriteLine("\n");
                Console.WriteLine("Hello, C# is a multi-paradigm programming language developed and standardized by the Microsoft company as part of its .NET platform, which was later approved as a standard by ECMA and ISO. C# is one of the programming languages ​​designed for the common language infrastructure.");
                break;
            default:
                Console.WriteLine("\n");
                Console.WriteLine("Invalid Option, Choose One Option One, Two, Three And Four.");
                break;
        }
    }
}
