using UnityEngine;

public class Choice : MonoBehaviour
{
    private string description = "";
    private string choiceName = "";
    private bool outcomeOfChoice = false;

    public string GetChoiceName()
    {
        return choiceName;
    }
    public string GetDescription()
    {
        return description;
    }


    public bool GetOutcomeOfChoice()
    {
        return outcomeOfChoice;
    }

    public Choice(string name, string whatYouDid, bool outcome)
    {
        choiceName = name;
        description = whatYouDid;
        outcomeOfChoice = outcome;
    }

    public void PrintChoice()
    {
        Debug.Log("Choice Name: " + choiceName);
        Debug.Log("Outcome: " + outcomeOfChoice);
        Debug.Log("Description: " + description);
    }
}
