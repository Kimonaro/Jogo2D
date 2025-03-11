using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;
    public int fast = 5;

    public int acula = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void RebolarMato()
    {
        if (acula == 1)
        {
            acula = 2;
            spriteRenderer.flipX = true;
        }
        else if (acula == 2)
        {
            acula = 1;
            spriteRenderer.flipX = false;
        } 
            
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Muro")
        {
            RebolarMato();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (acula == 1)
        {
            gameObject.transform.position += new Vector3(fast * Time.deltaTime, 0, 0);
        }
        else if (acula == 2)
        {
            gameObject.transform.position += new Vector3(-fast * Time.deltaTime, 0, 0);
        }
    }
}
