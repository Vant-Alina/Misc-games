using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//checks is pl is dead or not, 
//moves pl (wraith) up and down
public class Wraith_Move : MonoBehaviour
   
{
   private bool isDead = false;
   private Rigidbody2D rigBd2D_wraith;
    private float verticForce = 25f;//physic simulation
    private Animator wr_anim;

    void Start()
    {
        rigBd2D_wraith =  GetComponent<Rigidbody2D > ();
        wr_anim = GetComponent<Animator>();
    }



    void Update()
    {
        if (!isDead)//if pl isn't dead
        {
            if (Input.GetButton("Jump"))
            { 
            rigBd2D_wraith.velocity = Vector2.zero;

            //everytime the velocity of player will be updated up to 0
            rigBd2D_wraith.AddForce(new Vector2(0, verticForce));

                //animation of flight
                wr_anim.SetTrigger("Flight");

            }
        }
      
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;//if pl collides, pl dies
        wr_anim.SetTrigger("Die");
        GameController.instantiator.PlayerDied();
    }


}
