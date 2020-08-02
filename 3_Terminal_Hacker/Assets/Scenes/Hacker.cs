using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var generalGreeting = "Welcome to Terminal Hacker Game";
        Terminal.WriteLine(generalGreeting);
        ShowMainMenu("Hello Iskander!");
    }

    void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local liberary");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter you selection: ");
    }

    void CookCurry(string meatToUse)
    {
        // common cooking steps go here 
        print("Iam adding the " + meatToUse);
    } 

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu("Hello Iskander!");
        }
    }
}
