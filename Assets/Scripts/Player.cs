using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour
{
private Transform tf; // A variable to hold our Transform component
Vector3 myVector = new Vector3(2, 4, 12); // a preset vector to move too
public float speed; // a speed variable that designers can change in unity
private SpriteRenderer SR; // a variable for the sprite renderer
void Start()
{

tf = GetComponent<Transform>(); // gets the transform to use for movement
tf.position = Vector3.zero; // Sends object to an origin point
SR = GetComponent<SpriteRenderer>(); // gets sprite renderer for later use
}

void Update()
{

 



if (Input.GetKeyDown(KeyCode.Space))
{
tf.position = myVector; // if Space bar is pressed sends the sprite to a pre determined space
}

if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) // will only trigger if either of the shift keys are down
{
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                tf.Translate(0,1,0); // moves the sprite on the y axis one unit
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                tf.Translate(0, -1, 0);// moves the sprite on the y axis one unit
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                tf.Translate(1, 0, 0);// moves the sprite on the y axis one unit
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                tf.Translate(-1, 0, 0);// moves the sprite on the x axis one unit
            }
}
else //if neither shift key is held these actions will be performed when pressing corresponding keys
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

if (Input.GetKey(KeyCode.Q)) // when Q is pressed will turn off the sprite renderer breaking the game
{
    SR.enabled = false;
}
if (Input.GetKeyDown(KeyCode.S))
{
    tf.position = tf.position + Vector3.up; // if S is pressed sends the player up for one frame 
}
}

if (Input.GetKeyDown(KeyCode.Escape)) // when escape is hit it will close the game once it is built
{
//exit game
Application.Quit();
}


}
}
