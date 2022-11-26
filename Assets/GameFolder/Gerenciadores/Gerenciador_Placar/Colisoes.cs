using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisoes : MonoBehaviour
{
    public static Colisoes inst;

    public int _p1 { get; private set; }
    public int _p2 { get; private set; }

    void Awake()
    {
        if (inst == null)
        {
            inst = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void AddPontos_P1()
    {
        _p1++;
    }

    public void AddPontos_P2()
    {
        _p2++;
    }

    /// <summary>
    /// Reseta a pontuacao do jogo
    /// </summary>
    public void ResetaPontos()
    {
        _p1 = 0;
        _p2 = 0;
    }
}
