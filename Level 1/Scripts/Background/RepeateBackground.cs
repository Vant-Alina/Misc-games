using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeateBackground : MonoBehaviour
{

    private float groundLength;
    private BoxCollider2D grCollider;
    // Start is called before the first frame update
    void Start()
    {
        grCollider = GetComponent<BoxCollider2D>();
        groundLength = grCollider.size.x;

    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.x < -groundLength)
        {
            MoveBackground();
        } 
    }

    private void MoveBackground()
    {
        Vector2 offSetGround = new Vector2(groundLength * 2, 0);
        transform.position = (Vector2)transform.position + offSetGround;
    }
}
