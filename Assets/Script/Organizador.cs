using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organizador
{
    GameObject[] pontosBorda;
    GameObject pontoEsquerda;
    public void grahamScan(GameObject[] pontos)
    {
       pontosBorda[0] = primeiroPonto(pontos);
        pontoEsquerda.GetComponent<SpriteRenderer>().color.r.Equals(255);
    }

    GameObject primeiroPonto(GameObject[] pontos)
    {
        pontoEsquerda = pontos[0];
        for (int i = 1; i < pontos.Length; i++)
        {
            if (pontoEsquerda.transform.position.x < pontos[i].transform.position.x)
            {
                pontoEsquerda = pontos[i];
            }
        }
        return pontoEsquerda;
    }

}
