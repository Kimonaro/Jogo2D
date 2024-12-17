using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player: MonoBehaviour
{
    public float velocidade = 10f;
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-velocidade*Time.deltaTime,0,0);

            Debug.Log("LeftArrow"+Time.deltaTime);

            spriteRenderer.flipX = true;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
             gameObject.transform.position += new Vector3(velocidade*Time.deltaTime,0,0);
           
           spriteRenderer.flipX = false;
            Debug.Log("RightArrow"+Time.deltaTime);
        }
    }
}
