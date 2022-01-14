using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [Header("Corpo da bola")]
    [Tooltip("RB da bola")]
    [SerializeField]
    private Rigidbody2D rb;

    [Header("Velocidade da bola")]
    [Tooltip("Velocidade da bola")]
    [SerializeField]
    private float speed = 4f;

    private int forcaX;
    private int forcaY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        startBall();
    }

    void startBall()
    {

        forcaX = Random.Range(5, -5);
        forcaY = Random.Range(5, -5);

        if (forcaX == 0)
        {
            forcaX = 2;

        }else if (forcaY == 0)
        {
            forcaY = 2;
        }

        rb.velocity = new Vector2(forcaX * speed,forcaY * speed);
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        
        if (outro.gameObject.CompareTag("Ponto_p1") || outro.gameObject.CompareTag("Ponto_p2"))
        {
            Restart();
        }
    }

    void Restart()
    {
         rb.velocity = Vector2.zero;
         transform.position = new Vector2(0f,0f);
         transform.GetComponent<TrailRenderer>().Clear();
         startBall();
    }
}
