using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [Header("Corpo da bola")]
    [SerializeField]
    private Rigidbody2D rb;

    [Header("Explosao")]
    [SerializeField]
    private GameObject _explosion;

    [Header("Velocidade da bola")]
    [SerializeField]
    private float speed = 4f;

    private int forcaX;
    private int forcaY;


    [Header("Som da bola")]
    [SerializeField]
    private AudioClip ping,explosion;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        startBall();

    }

    /// <summary>
    /// Inicia a movimentacao da bola
    /// </summary>
    void startBall()
    {

        forcaX = Random.Range(5, -5);
        forcaY = Random.Range(5, -5);

        if (forcaX < 2 && forcaX > -2)
        {
            forcaX = 2;

        }
        
        if (forcaY < 2 && forcaY > -2)
        {
            forcaY = 2;
        }

        rb.velocity = new Vector2(forcaX * speed,forcaY * speed);
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        //Executa o audio
        Ping();

        if (outro.gameObject.CompareTag("Ponto_p1"))
        {
            Colisoes.inst.AddPontos_P2();
        }
        else if(outro.gameObject.CompareTag("Ponto_p2"))
        {
            Colisoes.inst.AddPontos_P1();
        }

        if (outro.gameObject.CompareTag("Ponto_p1") || outro.gameObject.CompareTag("Ponto_p2"))
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
            Gerenciador_Sounds.inst.PlayEffects(explosion);
            DesabilitaBall();
            Invoke("Restart", 1.5f);
        }
    }

    /// <summary>
    /// Reseta a posicao da bola
    /// </summary>
    public void Restart()
    {
         HabilitaBall();
         rb.velocity = Vector2.zero;
         transform.position = new Vector2(0f,0f);
         transform.GetComponent<TrailRenderer>().Clear();
         startBall();
    }

    /// <summary>
    /// Executa o audio da bola
    /// </summary>
    void Ping()
    {
        Gerenciador_Sounds.inst.PlayEffects(ping);
    }

    void DesabilitaBall()
    {
        gameObject.SetActive(false);
    }

    void HabilitaBall()
    {
        gameObject.SetActive(true);
    }
}
