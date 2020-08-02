using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string greeting = "Hello Iskander!";

    // Start is called before the first frame update
    void Start()
    {
        CookCurry("lamb");
        var generalGreeting = "Welcome to Terminal Hacker Game";
        Terminal.WriteLine(generalGreeting);
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
