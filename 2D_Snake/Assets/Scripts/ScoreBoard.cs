using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public Text scoreText;
    public int scoreValue;


    private void Start()
    {
        scoreValue = 0;
        scoreText.text = "Score: " + scoreValue;
    }

    public void OnTriggerEnter2D(Collider2D collision)                     // When collision is detected/triggered with Food call Grow function
    {
        if (collision.tag == "Food")
        {
            scoreValue += 15;
            scoreText.text = "Score: " + scoreValue;
        } else if (collision.tag == "Obstacle")
        {
            scoreValue = 0;
            scoreText.text = "Score: " + scoreValue;
        }
        
    }

}
