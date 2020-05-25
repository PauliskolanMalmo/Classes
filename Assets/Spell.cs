using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell
{
    public string name;
    public int levelRequired;
    public int itemRequired;
    public int expGained;

    public Spell(string name, int levRequired, int itemRequired, int exp)
    {
        this.name = name;
        this.levelRequired = levRequired;
        this.itemRequired = itemRequired;
        this.expGained = exp;
    }

    public void Cast()
    {
        //Debug.Log("Cast Spell!");
        Debug.Log("Castring: " + this.name);
    }
}
