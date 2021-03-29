using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColumnPool : MonoBehaviour
{
    private int arrSize = 5;
    private GameObject[] columnArr;
    public GameObject columnPrefab;
    private Vector2 columnPos = new Vector2(-20f, -20f);//initial position of meteors to spawn from

    public float respawnRate = 1f;//defines when it's time to respawn columns
    public float timerBeforeRespawn = 0f;

    public float min = -1.5f;//borders of random spawn of columns
    public float max = 3f;


    private int respawnCol = 0;//how many columns are already spawned


    void Start()
    {
        columnArr = new GameObject[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            columnArr[i] = Instantiate(columnPrefab, columnPos, Quaternion.identity);//Instantiate columns
        }

    }

    // Update is called once per frame
    void Update()
    {

        //  timerBeforeRespawn += Time.deltaTime;//update timer
        if (Time.time > timerBeforeRespawn)
        {

            timerBeforeRespawn = Time.time + respawnRate;//set a new timer

            float y_Pos = Random.Range(min, max);//set position  
            float x_Pos = Random.Range(-5, 5);

            if (respawnCol >= arrSize - 1)//...and start again
            {
                respawnCol = 0;
            }
            columnArr[respawnCol].transform.position = new Vector2(3, y_Pos);
            columnArr[++respawnCol].transform.position = new Vector2(x_Pos + 3, y_Pos);

            respawnCol++;



        }

    }


}
