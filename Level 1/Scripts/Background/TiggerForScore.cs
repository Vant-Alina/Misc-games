using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForScore : MonoBehaviour
{
    private int score = 0;//players score

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Wraith_Move>() != null)
        {
            Debug.Log(score);
        }
    }

    
}
