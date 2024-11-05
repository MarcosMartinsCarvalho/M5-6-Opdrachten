using UnityEngine;
using TMPro;
using System;

public class Scoreboard : MonoBehaviour
{
    public static event Action<int> OnPickupCollected; 
    [SerializeField] private TMP_Text scoreText;
    private int score = 0;

    private void Start()
    {
        if (scoreText == null)
        {
            scoreText = GetComponent<TMP_Text>();
        }
       
        OnPickupCollected += AddScore;
    }

    private void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    private void OnDestroy()
    {
        
        OnPickupCollected -= AddScore;
    }
}
