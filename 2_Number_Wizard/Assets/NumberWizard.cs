using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  void Start ()
  {
    int min = 1;
    int max = 1000;

    Debug.Log("Welcome to Number Wizard");
    Debug.Log("Pick a number between " + min + " and " + max + ", don't tell me what it is ...");
  }

  void Update ()
  {
  }
}
