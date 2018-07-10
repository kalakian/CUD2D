using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  int min = 1;
  int max = 1000;
  int guess = 500;

  void Start()
  {
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
      guess = (max + min) / 2;
      Debug.Log("Is it higher or lower than " + guess + "?");
    }
    else if(Input.GetKeyDown(KeyCode.DownArrow))
    {
      max = guess;
      guess = (max + min) / 2;
      Debug.Log("Is it higher or lower than " + guess + "?");
    }
    else if(Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("I guessed correct :)");
    }
  }
}
