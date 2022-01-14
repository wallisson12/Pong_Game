using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisoes : MonoBehaviour
{
    private int _p1;
    private int _p2;

    //Propriedades
    public int P1
    {
        get { return _p1; }
    }

    public int P2
    {
        get { return _p2; }
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Ponto_p1"))
        {
            _p1++;

        }else if (outro.gameObject.CompareTag("Ponto_p2"))
        {
            _p2++;
        }
    }
}
