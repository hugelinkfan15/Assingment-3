﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;
    public int maxScore = 5;

    private HealthSystem healthSystem;
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if(score >= maxScore)
        {
            healthSystem.gameOver = true;

            textbox.text = "Score: " + score + "\nYou Win!"; 
        }
    }
}
