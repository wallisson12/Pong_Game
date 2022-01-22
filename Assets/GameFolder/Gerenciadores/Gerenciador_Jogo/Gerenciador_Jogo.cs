using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerenciador_Jogo : MonoBehaviour
{
    [Header("Telas")]
    [SerializeField]
    private GameObject screen_Player1, screen_Player2;

    [Header("Ball")]
    [SerializeField]
    private Transform ball;

    [Header("Tempo de tela")]
    [SerializeField]
    private float screenTime = 1f;

    [Header("Pontuacao")]
    [SerializeField]
    private int ponto_p1, ponto_p2;

    [Header("Pontos maximos para o mapa")]
    [SerializeField]
    private int max_Pontos;
    
    void Update()
    {
        ponto_p1 = ball.GetComponent<Colisoes>().P1;
        ponto_p2 = ball.GetComponent<Colisoes>().P2;

        if (ponto_p1 >= max_Pontos)
        {
            Player1_Win();

        }else if (ponto_p2 >= max_Pontos)
        {
            Player2_Win();
        }

    }

    /// <summary>
    /// Faz aparecer a tela de vitoria de p1
    /// </summary>
    void Player1_Win()
    {
        screen_Player1.SetActive(true);
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        screenTime -= Time.deltaTime;

        if (screenTime <= 0)
        {
            screen_Player1.SetActive(false);
            ball.GetComponent<Colisoes>().ResetaPontos();
            ball.GetComponent<BallController>().Restart();
            screenTime = 1.5f;
        }
    }


    /// <summary>
    /// Faz aparecer a tela de vitoria de p2
    /// </summary>
    void Player2_Win()
    {
        screen_Player2.SetActive(true);
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        screenTime -= Time.deltaTime;

        if (screenTime <= 0)
        {
            screen_Player2.SetActive(false);
            ball.GetComponent<Colisoes>().ResetaPontos();
            ball.GetComponent<BallController>().Restart();
            screenTime = 1.5f;

        }
    }

}
