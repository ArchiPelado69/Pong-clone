using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 10;
    private float y_speed = 0;
    Transform ball;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        ball = gameObject.transform;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Moves de balls
        ball.Translate(speed * Time.deltaTime, y_speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Handles bounceback with player
        if (collision.gameObject.CompareTag("Player"))
        {
            speed *= -1;

            if (transform.position.x <= 0)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    y_speed = 10;
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    y_speed = -10;
                }
            }

            if (transform.position.x >= 0)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    y_speed = 1;
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    y_speed = -1;
                }
            }
        }
        //Handles Bounce on borders
        if (collision.gameObject.CompareTag("Border"))
        {
            y_speed *= -1;
        }
        //Handles Goal interaction
        if (collision.gameObject.CompareTag("Goal"))
        {
            if (transform.position.x <= 0)
            {
                gameManager.P2_Score += 1;
            }
            if (transform.position.x >= 0)
            {
                gameManager.P1_Score += 1;
            }
            transform.position = new Vector2(0, 0);
            speed *= -1;
        }
    }
}
