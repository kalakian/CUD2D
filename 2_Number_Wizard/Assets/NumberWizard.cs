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
  }

  void Update()
  {
    if(Input.GetKeyDown(KeyCode.UpArrow))
    {
      Debug.Log("Up arrow key was pressed.");
      min = guess;
      Debug.Log(guess);
    }
    else if(Input.GetKeyDown(KeyCode.DownArrow))
    {
      Debug.Log("Down arrow key was pressed.");
      max = guess;
      Debug.Log(guess);
    }
    else if(Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("Return key was pressed.");
    }
  }
}
