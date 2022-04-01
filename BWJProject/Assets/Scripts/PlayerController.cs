using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedForward = 5.0F;
    public float speedBackward = 3.0F;
    public float speedLeft = 2.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))               // move forward
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speedForward);  
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))               // move backward
        {
            transform.Translate(Vector3.back * Time.deltaTime * speedBackward);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))               // move left
        {
            transform.Translate(Vector3.left * Time.deltaTime * speedLeft);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))               // move left
        {
            transform.Translate(Vector3.right * Time.deltaTime * speedLeft);
        }
    }
}
