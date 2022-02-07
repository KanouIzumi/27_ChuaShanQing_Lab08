﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public Text scoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Obstacle")
        {
            print("+1");
            score++;
            scoreText.text = "Score: " + score;
            Destroy(collision.gameObject);
        }

    }
}
