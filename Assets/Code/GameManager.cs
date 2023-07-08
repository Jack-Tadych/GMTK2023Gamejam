using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Choice> choiceList = new List<Choice>();
    public List<Item> inventoryItems = new List<Item>();

    private void Start()
    {
       
        
    }
    
    private void Update(){
    }
    

    //inventory methods 
    public void AddItem(Item item){
        inventoryItems.Add(item);
        //Debug.Log("Item added to inventory: " + item.name);

    }
    public void RemoveItem(Item item){
        inventoryItems.Remove(item);
        //Debug.Log("Item removed from inventory: " + item.name);
    }

    public bool HasItem(string itemToCheck){
        foreach (Item item in inventoryItems)
        {
            if (item != null)
            {
                if (itemToCheck == item.GetItemName())
                {
                    RemoveItem(item);
                    return true;
                }
            }
        }
        return false;
    }

    //choice methods 
    public void PrintChoiceList(){
        foreach (Choice choice in choiceList)
        {
          print(choice.GetDescription());
        }
    }  
    
    public bool addChoiceToList(Choice newChoice){
        choiceList.Add(newChoice);
        PrintChoiceList();
        return true;
    }
   
}
