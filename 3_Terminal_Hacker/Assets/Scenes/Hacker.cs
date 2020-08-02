using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local liberary");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter you selection: ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
