using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCam : MonoBehaviour
{
    public static ShakeCam inst;

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

    public void Shake()
    {
        int i = Random.Range(1, 4);

        switch (i)
        {
            case 1:
                GetComponent<Animator>().SetTrigger("shake");
                break;

            case 2:
                GetComponent<Animator>().SetTrigger("shake2");
                break;

            case 3:
                GetComponent<Animator>().SetTrigger("shake3");
                break;
        }
    }
}
