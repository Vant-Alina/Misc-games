using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_Background : MonoBehaviour
{
    private Rigidbody2D rigBd2D_wraith;

    void Start()
    {
        //Get and store a reference to the Rigidbody2D attached to this GameObject
        rigBd2D_wraith = GetComponent<Rigidbody2D>();

        //Start the background moving
        rigBd2D_wraith.velocity = new Vector2(-4f, 0);
    }

    void Update()
    {
        // If the game is over, stop scrolling, start again
        if (GameController.instantiator.gameOver == true)
        {
            rigBd2D_wraith.velocity = Vector2.zero;
        }
    }
}
