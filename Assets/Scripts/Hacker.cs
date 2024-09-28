using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string[] level1Passwords = { "books", "aisle", "shelf", "password", "font", "borrow" };
    string[] level2Passwords = { "prisoner", "handcuffs", "holster", "uniform", "arrest", "jake" };
    enum Screen { MainMenu, Password , Win };
    [SerializeField] Screen currentScreen;
    string password;
    void Start()
    {
        ShowMainMenuTexts();   
    }
    void ShowMainMenuTexts()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Ohoy There");
        Terminal.WriteLine("Here's a Bullshit Game Witch Provides Nothing For Me,And Ofcourse For You !!");
        Terminal.WriteLine("OK ... Not That I Care But,Witch Category Are You Interested in?");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Pressing 1 Means You are BookWorm!");
        Terminal.WriteLine("And Pressing 2 Means You Are More Like A Broklyn 9-9 Fan!");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("OK Dummy... Let Me Know Your Type :");
    }
    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenuTexts();
        }
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
        else if (currentScreen == Screen.Win)
        {
            Terminal.WriteLine("Haji Bazi Tamom Shod Dige Bekesh Biron :|");
            if(input == "namosan?")
                Terminal.WriteLine("Are Valla :|");
        }
    }
    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            password = "pass1";
            StartGame(input);
        }
        else if(input == "2")
        {
            password = "pass2";
            StartGame(input);
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Oh My... And You Think You Are a Jenuis Named James Bond !!");
            Terminal.WriteLine("Can't You Even Read Mr.DomAss_Jenios ?????");
        }
        else
        {
            Terminal.WriteLine("Ok...I'm Done Here...We Can't Play With SomeOne Who Can't Even Read Numbers!!");
        }
    }
    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Ridi Azizam Password In Nist :)");
            currentScreen = Screen.Password;
        }
    }
    void StartGame(string input)
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Please Enter Your Passwrod :");
    }
    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        Terminal.WriteLine("Barikalla Boy :)");
    }
}
