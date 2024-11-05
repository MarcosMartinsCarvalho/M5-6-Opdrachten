using UnityEngine;
using System;

public class Pickup : MonoBehaviour
{
    
    public static event Action<int> OnPickupCollected;
    [SerializeField] private int points = 50; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            OnPickupCollected?.Invoke(points);
            
            Destroy(gameObject);
        }
    }
}
