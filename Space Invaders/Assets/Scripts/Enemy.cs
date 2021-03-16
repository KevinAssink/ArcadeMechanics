using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0; 
    float timeToMove = 0.5f;
    int numOfMovements = 0; 
    float speed = 0.50f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeToMove && numOfMovements != 11)
        {
            transform.Translate(new Vector3(speed, 0, 0));    
            timer = 0; 
            numOfMovements++;
        }
        if(numOfMovements == 11)
        {
            transform.Translate(new Vector3(0, -1, 0)); 
            numOfMovements = -1;
            speed = -speed;
        } 
    }
}
