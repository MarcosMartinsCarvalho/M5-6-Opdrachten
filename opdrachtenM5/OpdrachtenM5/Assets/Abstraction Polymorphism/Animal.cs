using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Animal : MonoBehaviour
{
    public abstract void Move();
    public void Eat()
    {
        Debug.Log("Njam Njam");
    }
}

