using UnityEngine;

public class Choice : MonoBehaviour
{
    private string description = "";
    private string choiceName = "";
    private bool outcomeOfChoice = false;
    private Sprite choiceSprite = null;

    public string GetChoiceName()
    {
        return choiceName;
    }
    public string GetDescription()
    {
        return description;
    }
    public Sprite getSprite(){
        return choiceSprite;
    }


    public bool GetOutcomeOfChoice()
    {
        return outcomeOfChoice;
    }

    public Choice(string name, string whatYouDid, bool outcome, Sprite sprite)
    {
        choiceName = name;
        description = whatYouDid;
        outcomeOfChoice = outcome;
        choiceSprite = sprite;
    }

    public void PrintChoice()
    {
        Debug.Log("Choice Name: " + choiceName);
        Debug.Log("Outcome: " + outcomeOfChoice);
        Debug.Log("Description: " + description);
    }
}
