using UnityEngine;

public class Controlador : MonoBehaviour
{
    Organizador organizador;
    public int numeroDePontos = 0;
    public GameObject ponto;
    public GameObject[] grupoDePontos;

    // Start is called before the first frame update
    void Start()
    {
        grupoDePontos = new GameObject[numeroDePontos];
        GerarPontos();
        organizador.grahamScan(grupoDePontos);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            for(int i = 0; i< grupoDePontos.Length; i++)
            {
                grupoDePontos[i] = null;
            }
            grupoDePontos = new GameObject[numeroDePontos];
            GerarPontos();
        }
    }

    void GerarPontos()
    {
        for(int i = 0; i < numeroDePontos; i++)
        {
            grupoDePontos[i] = ponto;
            Instantiate(ponto, new Vector3(Random.Range(-10f,10f), Random.Range(-10f,10f),0), Quaternion.identity);
        }
    }
}
