 using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player: MonoBehaviour
{
    public float velocidade = 10.09f;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer spriteRenderer;
    public float forcaPulo = 10f;
    public bool noChao;
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
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ) 
        {
            gameObject.transform.position += new Vector3(-velocidade*Time.deltaTime,0,0);

            Debug.Log("LeftArrow"+Time.deltaTime);

            spriteRenderer.flipX = true;
        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
             gameObject.transform.position += new Vector3(velocidade*Time.deltaTime,0,0);
           
           spriteRenderer.flipX = false;
            Debug.Log("RightArrow"+Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
            _rigidbody2D.AddForce(new Vector2(0,1) * forcaPulo,ForceMode2D.Impulse);
            Debug.Log("Space");
            
        }
        
    }
}
