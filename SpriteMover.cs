using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{

    Transform tf;
    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        //checks to see if shift is pressed or not
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                tf.position -= tf.right;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                tf.position += tf.right;
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                tf.position += tf.up;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                tf.position -= tf.up;
            }
        }
        else
        {
            //basic movement but also the else statement for shift
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position -= tf.right;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position += tf.right;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position += tf.up;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position -= tf.up;
            }

        }
        //Vector Reset to start spot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector2 (0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
