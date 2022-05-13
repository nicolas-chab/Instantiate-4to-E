using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 position;
    public float rotationspeed;
    public float movementspeed;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position + new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(movementspeed, 0, 0);
            //transform.eulerAngles += new Vector3(0, rotationspeed, 0);
            //transform.localScale += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(-movementspeed, 0, 0);
            //transform.eulerAngles += new Vector3(0, rotationspeed, 0);
            //transform.localScale += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, movementspeed);
            //transform.eulerAngles += new Vector3(0, rotationspeed, 0);
            //transform.localScale += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, -movementspeed);
            //transform.eulerAngles += new Vector3(0, rotationspeed, 0);
            //transform.localScale += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            //transform.position += new Vector3(0, 0, -movementspeed);
            transform.eulerAngles += new Vector3(0, rotationspeed, 0);
            //transform.localScale += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            //transform.position += new Vector3(0, 0, -movementspeed);
            transform.eulerAngles += new Vector3(0, -rotationspeed, 0);
            //transform.localScale += new Vector3(0.1f, 0, 0);
        }
    }
}
