using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
       int Direction = 0;

        //Boundry limit
        if (transform.position.y >=  3.885f)
        {
            transform.position = new Vector3(transform.position.x, 3.885f, transform.position.y);
        }
        else if (transform.position.y <= -3.885f)
        {
            transform.position = new Vector3(transform.position.x, -3.885f, transform.position.y);
        }

        //Assigning controlls
        if (transform.position.x <= 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Direction = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Direction = -1;
            }
            else { Direction = 0; }
        }

        if (transform.position.x >= 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Direction = 1;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Direction = -1;
            }
            else { Direction = 0; }
        }

        //Actually Moving
        transform.Translate(0, Direction * speed * Time.deltaTime, 0);
    }
}
