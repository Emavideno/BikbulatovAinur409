using Corporate_Settlement;
using System;
using System.Collections.Generic;


public class CorporateSettlement
{
    public static void BeatifulOutput()
    {
        Console.WriteLine();
        Console.WriteLine("============");
        Console.WriteLine();
    }
    
    public static void Main(string[] args)
    {
        FirstInputs.PrimordialInput();
        Friends.HowToImportFriends();
        Bars.AddBar();
        BeatifulOutput();
        FileOutput.SaveFriendsToCsv();
        Calculator.Calculate();
        string fullPath = Path.Combine(FirstInputs.corpOutputPath, FirstInputs.corpOutputName);
        FileOutput.SaveToFile(fullPath);
    }
}
