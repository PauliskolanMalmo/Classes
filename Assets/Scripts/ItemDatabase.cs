using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{


    public Item[] items;



    void Start()
    {
        print("items[0].name: " + items[0].name);
    }


    /*
    [SerializeField]
    public Item sword;
    public Item hammer;
    public Item bread;

    // Start is called before the first frame update
    void Start()
    {

        //Use a constructor in tha class Item instead of doing it like sword
        sword = new Item();
        sword.name = "Sword";
        sword.id = 1;
        sword.description = "This is a sword";

        //if CreateItem is void 
        //CreateItem("Bread", 3, "Bread, yum!");


        //if CreateItem is returning item
        bread = CreateItem("Bread", 3, "Bread, yum!");

        hammer = new Item("Hammer", 2, "Hammertime!");

    }

    private Item CreateItem(string name, int id, string description)
    {
        //"var" is the universal datatype that detects what datatype it should use
        //Could use "Item" instead here
        var item = new Item(name, id, description);

        return item;

    }

    */

}
