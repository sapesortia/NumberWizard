using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("** Welcome to Number-Wizard **");
        Debug.Log("Pick a number in your mind. Don't tell it to me!");
        Debug.Log("The highest number you can pick is:" + max); // Dette er hvordan man bruker en variable når man skal skrive ut til console.
        Debug.Log("The lowest number you can pick is: " + min); // Samme gjelder minimum.
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("'Push Up Button' if your number is HIGHER, 'Push Down Button' if your number is LOWER, 'PUSH ENTER' if number is CORRECT!");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        /* Dersom en knapp blir trykket ned, og den knappen som blir trykket inn er UP-keyen skal det som er inni skrives ut til skjerm */
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than... " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than... " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
        }
    }
}
