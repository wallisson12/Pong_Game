using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerenciador_Sounds : MonoBehaviour
{
    public static Gerenciador_Sounds inst;
    [SerializeField] private AudioSource _effects;

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



    public void PlayEffects(AudioClip audioClip)
    {
        _effects.PlayOneShot(audioClip, 0.8f);
    }
}
