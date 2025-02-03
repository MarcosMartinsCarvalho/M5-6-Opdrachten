using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal 
{
    public  void Eat()
    {
        Debug.Log("nomnomnom");
    }
    public abstract void Move();
}
