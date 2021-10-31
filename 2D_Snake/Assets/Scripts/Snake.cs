using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private Vector2 direction = Vector2.right;                          // Variable for snake direction
                                                                        // Default direction: right

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))                          // Snake movements (Up, Down, Right, Left)
        {
            direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        } else if (Input.GetKeyDown(KeyCode.RightArrow))   
        {
            direction = Vector2.right;
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))       
        {
            direction = Vector2.left;
        }
    }

    private void FixedUpdate()
    {
        //variable access the transform of snake and updates position
        this.transform.position = new Vector3( Mathf.Round(this.transform.position.x) + direction.x,
                                               Mathf.Round(this.transform.position.y) + direction.y, 0.0f);
    }

}
