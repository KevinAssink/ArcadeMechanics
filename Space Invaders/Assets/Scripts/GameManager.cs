﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives = 3; 
    public static bool playGame = true; 
    public Text livesText;  
    public Text endScreen;
    public Text winScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;  
        if(lives == 0)
        {
            endScreen.text = "YOU LOSE";
        }
    }
}
