using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    [Tooltip("Velocidade do player")]
    [SerializeField]
    private float speed;

    [Tooltip("Posicao limite do player")]
    [SerializeField]
    private float limitPosition = 2.45f;

    [Tooltip("Tela de pausa")]
    [Header("Tela de pausa")]
    [SerializeField]
    private Transform pauseScreen;

    void Update()
    { 
         MovePlayer();
    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseScreen.GetComponent<PauseGame>().enabled = !pauseScreen.GetComponent<PauseGame>().enabled;
        }

    }

    /// <summary>
    /// Método para movimentação do player
    /// </summary>
    void MovePlayer()
    {
        if (transform.position.y < limitPosition)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(new Vector2(0f, speed * Time.deltaTime));
            }

        }
        else
        {
            transform.position = new Vector2(transform.position.x,limitPosition);
        }

        if (transform.position.y > -limitPosition)
        {
            if (Input.GetKey(KeyCode.DownArrow))
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
