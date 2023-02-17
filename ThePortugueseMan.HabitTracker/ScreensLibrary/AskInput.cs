﻿using HabitsLibrary;
namespace ScreensLibrary;

public class AskInput
{
    private void ClearPreviousLines (int numberOfLines)
    {
        for (int i = 1; i <= numberOfLines; i++)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
    public string LettersNumberAndSpaces (string message)
    {
        string returnString;
        bool showError = false;
        do
        {
            if (showError)
            {
                ClearPreviousLines(2);
                Console.Write("Invalid Input.");
            }
            else Console.Write(message);

            Console.WriteLine(" Use only letters, numbers and spaces");
            returnString = Console.ReadLine();
            showError= true;
        }
        while (!((returnString.All(c => Char.IsLetterOrDigit(c) || c == ' ')) && returnString != ""));
        
        returnString.Trim();
        return returnString;
    }

    public int Digits(string message)
    {
        string? input;
        bool showError = false;
        int number;
        do
        {
            Console.WriteLine(message);
            if (showError)
            {
                ClearPreviousLines(3);
                Console.Write("Invalid Input. ");
            }

            Console.WriteLine("Use numbers only.");
            input = Console.ReadLine();
            showError = true;
        }
        while (!(Int32.TryParse(input, out number) || number < 0));
        return number;
    }

    public void AnyAndEnterToContinue()
    {
        Console.WriteLine("Press any key and Enter to continue");
        Console.ReadLine();
    }

    public bool ZeroOrAnyKeyAndEnterToContinue()
    {
        Console.WriteLine("Press any key and Enter to continue. Or press 0 to return to the menu");
        if (Console.ReadLine() == "0") return true;
        else return false;

    }
}