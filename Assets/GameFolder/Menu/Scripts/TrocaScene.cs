using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaScene : MonoBehaviour
{
   /// <summary>
   /// Carrega a cena para o modo Solo
   /// </summary>
    public void Solo(string nome)
    {
        StartCoroutine(Inicia(nome));
    }

    /// <summary>
    /// Carrega a cena para o modo Versus
    /// </summary>
    public void Versus(string nome)
    {
        StartCoroutine(Inicia(nome));
    }

    /// <summary>
    /// Carrega a cena para os Creditos
    /// </summary>
    public void Credits(string nome)
    {
        StartCoroutine(Inicia(nome));
    }

    /// <summary>
    /// Sai do modo de jogo
    /// </summary>
    public void Exit()
    {
        Application.Quit();
    }

    /// <summary>
    /// Espera alguns segundos para carregar a cena
    /// </summary>
    IEnumerator Inicia(string nome)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(nome);
    }
}
