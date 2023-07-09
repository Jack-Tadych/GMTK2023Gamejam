using UnityEngine;
using System.Collections.Generic;

public class correctEvents : MonoBehaviour
{
    private List<Choice> choices;
    private void Start(){
        ending1();

    }
    private void ending1(){
        // Initialize the list
        choices = new List<Choice>();

        // Add choices to the list
        choices.Add(new Choice("KnifeBed", "You put the knife on the bed", true, null));
        choices.Add(new Choice("PictureDresser", "I'll put the picture on the desser", true, null));
        choices.Add(new Choice("movedFag", "gotta move this fag yee yee", true, null));

        // Print the choices
        PrintChoices();
    }

    private void PrintChoices()
    {
        foreach (Choice choice in choices)
        {
            choice.PrintChoice();
        }
    }
}
