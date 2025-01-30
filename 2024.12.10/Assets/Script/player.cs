 using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player: MonoBehaviour
{
    public float velocidade = 7f;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer spriteRenderer;
    public float forcaPulo = 9f;
    public bool noChao = false;
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        { 
            noChao = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            noChao = false;
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
        {
            gameObject.transform.position += new Vector3(-velocidade*Time.deltaTime,0,0);

            Debug.Log("esquerda"+Time.deltaTime);

            spriteRenderer.flipX = true;
        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        { 
            gameObject.transform.position += new Vector3(velocidade*Time.deltaTime,0,0);
           
           spriteRenderer.flipX = false;
           
            Debug.Log("direita"+Time.deltaTime);
        }

        if (( Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) ) && noChao == true)
        {
            _rigidbody2D.AddForce(new Vector2(0,1) * forcaPulo,ForceMode2D.Impulse);
            
            Debug.Log("para cima");
        }
    }
}