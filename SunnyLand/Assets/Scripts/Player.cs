using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int vida = 5;
    private Rigidbody2D rb;
    public float novaGravidade = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
