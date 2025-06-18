using System.Collections;
using System.Collections.Generic;
using TMPro; //Importando o texto 
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public TMP_Text texto_pontos; //Pegando o texto TMPro na Unity
    public ParticleSystem efeito; 
    //"public" para editar a vari�vel no inspector da UnityHub
    //"TMP_Text" --> nome do componente
    int pontos = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pontos++;
            //Incrementa +1 ponto na v�riavel "pontos"
            texto_pontos.text = "Pontos: " + pontos.ToString();
            collision.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            /*"Vector3()" -> recebe valores em x, y e z
              "Vector2()" -> recebe valores em x e y
            */
            Instantiate(efeito, transform.position, Quaternion.identity);
            /*
            Instantiate() --> Fun��o que adiciona o efeito de explos�o
            transform.position --> pega o componente position e troca a moeda pela explos�o 
            Quaternion.identity --> "N�o gire"
             */
            Destroy(gameObject);
            //Destroy() --> Deleta a moeda logo depois de enconstar nela

            
        }
    }






    /*
                            - ANOTA��ES -

    par�metro: variaveis que recebem valores em fun��es ou m�todos
    ex.:
        function nome_funcao(parametro1, parametro2){
        resultado = parametro1 + parametro2
        }

    private int pontos = 5;
    // Start is called before the first frame update
    void Start() --> Fun��o chamada quando o jogo inicia.
    {
        Debug.Log("In�cio do jogo!\n Com: " + pontos + "pontos");
    }

    // Update is called once per frame
    void Update() --> Fun��o chamada continuamente em cada frame.
    {
        
    }
    
    IsTrigger -> faz com que o Player ao inv�s de colidir com o objeto, vai se tornar um gatilho, 
    ou seja, quando o player encontrar com esse objeto vai acionar algo

     
     
    */
}
