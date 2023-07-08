using UnityEngine;

public class Choice : MonoBehaviour
{
    private string choiceName = "";
    private bool outcomeOfChoice = false;

    public string GetChoiceName()
    {
        return choiceName;
    }

    public bool GetOutcomeOfChoice()
    {
        return outcomeOfChoice;
    }

    public Choice(string name, bool outcome)
    {
        choiceName = name;
        outcomeOfChoice = outcome;
    }

    public void PrintChoice()
    {
        Debug.Log("Choice Name: " + choiceName);
        Debug.Log("Outcome: " + outcomeOfChoice);
    }
}
