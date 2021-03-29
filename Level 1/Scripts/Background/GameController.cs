using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController instantiator;
    public bool gameOver = false;


    void Awake()//is called before Start() and used to instantiate obj 
    {
        if (instantiator == null)     instantiator = this;//check if already have game controller, if yes -- destroy the duplicate

        else if (instantiator != this)  Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetButton ("Jump"))
        {
            gameOver = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void PlayerDied()
    {
        gameOver = true;
    }
}
