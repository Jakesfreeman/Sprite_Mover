using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Transform tf; // A variable to hold our Transform component
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        tf.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // Move up every frame 
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            tf.position += tf.up * speed * Time.deltaTime;// moves the sprite on the y axis one time per frame
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            tf.position += tf.up * speed * Time.deltaTime;// moves the sprite on the y axis one time per frame
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            tf.position += tf.right * speed * Time.deltaTime;// moves the sprite on the y axis one time per frame
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tf.position += tf.right * speed * Time.deltaTime;// moves the sprite on the y axis one time per frame
        }
    }
}
