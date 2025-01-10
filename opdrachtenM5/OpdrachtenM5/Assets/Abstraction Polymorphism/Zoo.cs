using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    private List<Animal> animals;

    void Start()
    {
        animals = new List<Animal> { new Bird(), new Dog(), new Elephant() };

        foreach (Animal animal in animals)
        {
            animal.Eat();
            animal.Move();
        }
    }
}