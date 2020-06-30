using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    //protected:possible for subclasses to inherit but no not non-sub classes
    //private: then no classes can inherit
    //public: all classes inherit


    protected string branchName;
    protected string location;
    protected int cashInVault;

    public void CheckBalance()
    {
        Debug.Log("Checking balance: " + branchName);
    }

    public void Withdraw()
    {
        Debug.Log("Withdrawing money from: " + branchName);
    }

    public void Deposit()
    {
        Debug.Log("Depositing money to: " + branchName);
    }


}
