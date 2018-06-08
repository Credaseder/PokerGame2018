using System.Collections;
using System.Collections.Generic;

public enum WinState
{
    PLAYER1,
    PLAYER2,
    TIE
}

public class WriteToDisk
{
    public static string[] output = new string[1000];

    public static void WriteRoundToDisk()
    {
        System.IO.File.WriteAllLines(@"E:\output.txt", output);
    }
    
    public static void AddOutput(int round, WinState state)
    {
        output[round] = "round " + (round+1) + " " + state;
    }
}
