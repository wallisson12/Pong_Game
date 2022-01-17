using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [Header("Pontos ate onde o inimigo vai")]
    [SerializeField]
    private Transform A, B;

    [Header("Velocidade do inimigo")]
    [SerializeField]
    private float speed;

    [Header("Verifica qual lado esta indo")]
    [SerializeField]
    private bool isRight = true;

    void Update()
    {
        Move();
    }

    /// <summary>
    /// Faz a movimentacao do inimigo
    /// </summary>
    void Move()
    {
        if (isRight)
        {
            if (Vector2.Distance(transform.position,A.position) < 0.2f)
            {
                isRight = false;
            }

            transform.position = Vector2.MoveTowards(transform.position,A.position,speed * Time.deltaTime);
        }
        else
        {
            if (Vector2.Distance(transform.position,B.position) < 0.2f)
            {
                isRight = true;
            }

            transform.position = Vector2.MoveTowards(transform.position,B.position,speed * Time.deltaTime);
        }
    }
}
