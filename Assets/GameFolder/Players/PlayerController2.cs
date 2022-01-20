using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [Tooltip("Velocidade do player")]
    [SerializeField]
    private float speed;

    [Tooltip("Posicao limite do player")]
    [SerializeField]
    private float limitPosition = 2.45f;

    void Update()
    {
        MovePlayer2();
    }

    /// <summary>
    /// Método para movimentação do player
    /// </summary>
    void MovePlayer2()
    {
        if (transform.position.y < limitPosition)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector2(0f, speed * Time.deltaTime));
            }

        }
        else
        {
            transform.position = new Vector2(transform.position.x, limitPosition);
        }

        if (transform.position.y > -limitPosition)
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector2(0f, -speed * Time.deltaTime));
            }
        }
        else
        {
            transform.position = new Vector2(transform.position.x, -limitPosition);
        }
    }
}
