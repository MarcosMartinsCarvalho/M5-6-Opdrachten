using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    List<Animal> animals;

    private void Start()
    {
        animals = new List<Animal> { new Elephant(), new Bird(), new Dog()};

        foreach (var animal in animals)
        {
            animal.Move();
            animal.Eat();
        }
    }
}
