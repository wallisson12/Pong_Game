using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gerencia_Placar : MonoBehaviour
{
    [Header("Caixa de texto")]
    [SerializeField]
    private TMP_Text texto_p1;

    [Header("Caixa de texto")]
    [SerializeField]
    private TMP_Text texto_p2;


    void Update()
    {
        PontosUpdate();
    }

    private void PontosUpdate()
    {
        texto_p1.text = Colisoes.inst._p1.ToString();
        texto_p2.text = Colisoes.inst._p2.ToString();
    }
}
