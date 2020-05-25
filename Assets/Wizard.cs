using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spell fireBlast;

    public int level = 1;
    public int exp;

    // Start is called before the first frame update
    void Start()
    {
        //fireBlast = new Spell("fireblast", 1, 27, 35);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*
            fireBlast.Cast();
            exp += fireBlast.expGained;
            */
        }

    }

}
