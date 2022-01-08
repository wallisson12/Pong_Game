using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [Header("Corpo da bola")]
    [SerializeField]
    private Rigidbody2D rb;

    [Header("Velocidade da bola")]
    [SerializeField]
    private float speed;

    private float forcaX;
    private float forcaY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        forcaX = Random.Range(5f,-5f);
        forcaY = Random.Range(5f,-5f);

        rb.velocity = new Vector2(forcaX * speed,forcaY * speed);
    }
}
