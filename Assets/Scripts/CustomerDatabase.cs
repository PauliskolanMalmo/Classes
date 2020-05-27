using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{

    public Customer adam;
    public Customer amy;
    public Customer abby;
    public Customer eric;

    private void Start()
    {
        adam = new Customer("Adam", "Adamson", 26, "M", "Teacher");
        amy = new Customer("Amy", "", 36, "F", "Engineer");
        abby = new Customer("Abby", "Lang", 56, "F", "Scientist");
    }
}
