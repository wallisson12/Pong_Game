using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerenciador_Jogo : MonoBehaviour
{
    [Header("Telas")]
    [SerializeField]
    private GameObject screen_Player1, screen_Player2;

    [Header("Button")]
    private GameObject btn_Stuck;

    [Header("Ball")]
    [SerializeField]
    private Transform ball;

    [Header("Tempo de tela")]
    [SerializeField]
    private float screenTime = 3f;

    [Header("Pontuacao")]
    [SerializeField]
    private int ponto_p1, ponto_p2;

    [Header("Pontos maximos para o mapa")]
    [SerializeField]
    private int max_Pontos;

    void Awake()
    {
        btn_Stuck = GameObject.FindGameObjectWithTag("Stuck");

        btn_Stuck.GetComponent<Button>().onClick.AddListener(ball.GetComponent<BallController>().Restart);
    }
    void Update()
    {
        ponto_p1 = Colisoes.inst._p1;
        ponto_p2 = Colisoes.inst._p2;

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
            Colisoes.inst.ResetaPontos();
            ball.GetComponent<BallController>().Restart();
            screenTime = 3f;
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
            Colisoes.inst.ResetaPontos();
            ball.GetComponent<BallController>().Restart();
            screenTime = 3f;

        }
    }

}
