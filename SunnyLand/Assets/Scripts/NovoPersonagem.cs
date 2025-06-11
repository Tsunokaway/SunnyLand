using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovoPersonagem : MonoBehaviour
{
    public string nomePersonagem = "Elen";
    public int vidaElen = 10;
    public float velocidadeElen = 10f;
    public bool vivo = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nome do personagem: " +  nomePersonagem + "\n Vida: " + vidaElen + "\n Velocidade: " + velocidadeElen+ "\n Vivo: " + vivo);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
