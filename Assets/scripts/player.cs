using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class player : MonoBehaviour
{
    private Transform tf; // A variable to hold our Transform component
    Vector3 myVector = new Vector3(2, 4, 12);
    public float speed;
    void Start()
    {
        // Get the Transform Component
        tf = GetComponent<Transform>();
        tf.position = Vector3.zero; // Sends object to an origin point
    }

    void Update()
    {
        // Move up every frame 

        if (Input.GetKeyDown(KeyCode.S))
        {
            tf.position = tf.position + Vector3.up; // if S is pressed sends the sprite off the screen in the direction it is looking
        }

        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = myVector; // if Spacebar is pressed sends the sprite to a pre determined space
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position += tf.up * speed * Time.deltaTime;// moves the sprite on the y axis 
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position += tf.up * -speed * Time.deltaTime;// moves the sprite on the y axis 
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position += tf.right * speed * Time.deltaTime;// moves the sprite on the x axis 
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position += tf.right * -speed * Time.deltaTime;// moves the sprite on the x axis 
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //exit game
            Application.Quit();
        }
        

    }
}
