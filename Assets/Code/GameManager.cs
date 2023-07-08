using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<Choice> choiceList = new List<Choice>();
    private void Start()
    {
       
        
    }
    
    private void Update(){
    }
    
    public void PrintChoiceList(){
        Debug.Log("Printing choice list:");
        foreach (Choice choice in choiceList)
        {
            Debug.Log("Choice: " + choice.GetChoiceName() + ", Value: " + choice.GetOutcomeOfChoice());
        }
    }  
    
    public bool addChoiceToList(Choice newChoice){
        choiceList.Add(newChoice);
        PrintChoiceList();
        return true;
    }
   
}
