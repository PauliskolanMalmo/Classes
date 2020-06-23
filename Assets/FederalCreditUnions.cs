﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FederalCreditUnions : Bank
{
    public int availibleCashToLend;

    public void ApproveLending()
    {
        Debug.Log("You are awarded a loan!");
    }
}
