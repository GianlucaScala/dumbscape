using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
        Debug.Log(item + " added to inventory.");
    }

    public void RemoveItem(string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log(item + " removed from inventory.");
        }
        else
        {
            Debug.Log(item + " not found in inventory.");
        }
    }

    public void ShowInventory()
    {
        Debug.Log("Inventory: " + string.Join(", ", items));
    }
}