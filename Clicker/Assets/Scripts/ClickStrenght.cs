using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickStrenght : MonoBehaviour
{
    private int coins;
    private int strenght = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CoinsPerSecond", 0, 3); //per 3 seconds starting from second 0
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Coins: " + coins.ToString());
        Debug.Log("Strenght: " + strenght.ToString());
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (coins >= 3)
            {
                strenght++;
                coins -= 3;
            }
        }
        if(Input.GetMouseButtonDown(0))
        {
            coins += strenght;
        }
    }

    private void CoinsPerSecond()
    {
        coins++;
    }
}
