using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game Configuration data
    string[] level1Passwords = { "books", "aisle", "self", "password", "font", "borrwo" };
    string[] level2Passwords = { "prisoner", "handcuffs", "holster", "uniform", "arrest" };

    // Game state 
    int level;

    // Enumerations in C#
    enum Screen 
    {
        MainMenu, 
        Password,
        Win
    };
    
    string password;

    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        var generalGreeting = "Welcome to Terminal Hacker Game";
        print(level1Passwords[0]);
        Terminal.WriteLine(generalGreeting);
        ShowMainMenu("Hello Iskander!");
    }

    void ShowMainMenu(string greeting)
    {
        Screen currentScreen = Screen.MainMenu;
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
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2");

        if (isValidLevelNumber) 
        {
            level = int.Parse(input);
            StartGame();
        }
        else 
        {
            Terminal.WriteLine("Please choose a valid number");
        }
    }

    void StartGame() 
    {
        currentScreen = Screen.Password;

        Terminal.ClearScreen();
        
        switch(level)
        {
            case 1: 
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid Level number");
                break;
        }
        Terminal.WriteLine("Please enter you password: ");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        } 
        else
        {
            Terminal.WriteLine("Sorry, wrong password!");
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward(); 
    }

    void ShowLevelReward() 
    {
        switch (level) 
        {
            case 1: 
                Terminal.WriteLine("Have a book...");
                Terminal.WriteLine(@"
                        ___________
                       /          //
                      /          //
                     /__________//
                    (__________(/ 
                ");
                break;
            case 2: 
                Terminal.WriteLine("You got the prison key!");
                Terminal.WriteLine(@"
                     __
                    /0 \__________
                    \__/-= ' === '
                ");
                break;
            default:
                Debug.LogError("Invalid level reached!");
                break;
        }
    }
}
