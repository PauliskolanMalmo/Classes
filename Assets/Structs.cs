using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ItemS // VALUE TYPE - Stack
{
    public string name;
    public int itemID;

    public ItemS(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}


public class ItemC //REFERENCE TYPE - Heap
{
    public string name;
    public int itemID;

    public ItemC(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}


public class Structs : MonoBehaviour
{

    ItemC sword = new ItemC("Sword", 1);

    ItemS bread;

    private void Start()
    {
        bread.name = "Bread";
        bread.itemID = 2;

        Debug.Log("Current sword name (before): " + sword.name);
        ChangeValue(sword);
        Debug.Log("Current sword name (after): " + sword.name);


        Debug.Log("Current bread name (before): " + bread.name);
        ChangeValue(bread);
        Debug.Log("Current bread name (after): " + bread.name);
    }

    void ChangeValue(ItemS structItem) //value type
    {
        structItem.name = "Dirty Bread";
        Debug.Log(structItem.name);
    }



    void ChangeValue(ItemC classItem)
    {  //referece
        classItem.name = "Master Sword";

    }
    /*
    ItemC sword;
    private void Start()
    {
        sword = new ItemC("Sword", 1);

        //VALUE TYPE: bool, bytes, char, double, float, int, long, structs
        int age = 25;


        //REFERENCE TYPE: class, string, all arrays, delegats
        string myName = "Adam";
    }
    */

}