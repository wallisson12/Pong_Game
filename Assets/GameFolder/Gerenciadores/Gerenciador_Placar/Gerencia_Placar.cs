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
        texto_p1.text = GameObject.Find("Ball").GetComponent<Colisoes>().P1.ToString();
        texto_p2.text = GameObject.Find("Ball").GetComponent<Colisoes>().P2.ToString();
    }
}
