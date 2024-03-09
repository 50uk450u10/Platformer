using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] PlayerStats stats;
    [SerializeField] TMP_Text coinCounter;
    [SerializeField] TMP_Text healthCount;

    private void Update()
    {
        coinCounter.text = "Coins Collected: " + stats.getScore() + "/" + stats.getMaxCoinage();
        healthCount.text = "Health: " + stats.getHealth();
    }
}
