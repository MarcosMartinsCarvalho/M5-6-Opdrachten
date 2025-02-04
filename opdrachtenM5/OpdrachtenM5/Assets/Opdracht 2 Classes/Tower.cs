using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    void Start()
    {
        float randomScale = Random.Range(0.5f, 2f);
        transform.localScale = new Vector3(randomScale, randomScale, randomScale);
    }
}