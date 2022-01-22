using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenu : MonoBehaviour
{
    [Header("Pontos")]
    [SerializeField]
    private Transform A,B;

    [Header("Velocidade")]
    [SerializeField]
    private float speed;

    [Header("Direcao")]
    [SerializeField]
    private bool goRight;

    void Update()
    {
        if (goRight)
        {
            if (Vector2.Distance(transform.position,A.position) < 0.2f)
            {
                goRight = false;
            }

            transform.position = Vector2.MoveTowards(transform.position, A.position, speed * Time.deltaTime);
        }
        else
        {
            if (Vector2.Distance(transform.position,B.position) < 0.2f)
            {
                goRight = true;
            }

            transform.position = Vector2.MoveTowards(transform.position, B.position, speed * Time.deltaTime);
        }
    }
}
