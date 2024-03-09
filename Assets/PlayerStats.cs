using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats" , menuName = "Objects/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    [SerializeField] int health;
    int score;
    [SerializeField] int maxHealth;
    int maxCoinage;

    public int getScore() { return score; }
    public int getHealth() { return health; }
    public int getMaxCoinage()
    {
        return maxCoinage;
    }

    private void OnEnable()
    {
        score = 0;
        health = maxHealth;
        maxCoinage = 0;
    }
    public void increaseMaxCoinage() { maxCoinage++; }
    public void addToScore()
    {
        score++;
        Debug.Log("Score up " + score);
    }
    
}
