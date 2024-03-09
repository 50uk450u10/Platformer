using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    private void OnTriggerEnter(Collider other)
    {
        playerStats.addToScore();
        Destroy(gameObject);
    }
    private void Awake()
    {
        playerStats.increaseMaxCoinage();
    }
}
