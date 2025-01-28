using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;
public class Bandeira : MonoBehaviour
{
    public string nomedaFase;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nomedaFase); 
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}