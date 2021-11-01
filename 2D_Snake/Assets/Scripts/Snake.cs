using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    private Vector2 direction = Vector2.right;                          // Variable for snake direction
                                                                        // Default direction: right
    private List<Transform> segments = new List<Transform>();

    public Transform segmentPrefab;

    public int initialSize = 4;                                          // Initial size of snake = 4
    
    private void Start()    
    {
        ResetState();                                                  // Add first snake body segment (Head)
    }

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
        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].position = segments[i - 1].position;
        }
        
        //variable access the transform of snake and updates position
        this.transform.position = new Vector3( Mathf.Round(this.transform.position.x) + direction.x,
                                               Mathf.Round(this.transform.position.y) + direction.y, 0.0f);
    }

    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = segments[segments.Count - 1].position;       // Setposition of segment at the end of the Snake object

        segments.Add(segment);                                          // Add it to the list
    }

    private void ResetState()                                           // Reset state - Clear out the list of segments
    {
        for (int i = 1; i < segments.Count; i++)
        {
            Destroy(segments[i].gameObject);
        }

        segments.Clear();
        segments.Add(this.transform);

        for(int i = 1; i < this.initialSize; i++)
        {
            segments.Add(Instantiate(this.segmentPrefab));
        }

        this.transform.position = Vector3.zero;
    }

    public void OnTriggerEnter2D(Collider2D collision)                     // When collision is detected/triggered with Food call Grow function
    {
        if (collision.tag == "Food")
        {
            Grow();
        }
        else if (collision.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
            ResetState();
        }
    }


}
