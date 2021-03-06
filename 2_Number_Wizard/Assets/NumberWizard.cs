﻿using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  int min;
  int max;
  int guess;

  void Start()
  {
    StartGame();
  }

  void StartGame()
  {
    min = 1;
    max = 1000;
    guess = 500;

    Debug.Log("Welcome to Number Wizard");
    Debug.Log("Pick a number between " + min + " and " + max + ", don't tell me what it is ...");
    Debug.Log("Tell me if your number is higher or lower than " + guess + "?");
    Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");

    max += 1; // this ensures the max value can be included in guesses
  }

  void Update()
  {
    if(Input.GetKeyDown(KeyCode.UpArrow))
    {
      min = guess;
      NextGuess();
    }
    else if(Input.GetKeyDown(KeyCode.DownArrow))
    {
      max = guess;
      NextGuess();
    }
    else if(Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("I guessed correct :)");
      StartGame();
    }
  }

  void NextGuess()
  {
    guess = (max + min) / 2;
    Debug.Log("Is it higher or lower than " + guess + "?");
  }
}
