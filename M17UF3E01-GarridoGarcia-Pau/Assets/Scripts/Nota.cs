using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour
{
    public KeyCode tecla;
    bool estaEncima = false;
    GameObject notaPartitura;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla) && estaEncima){
            Destroy(notaPartitura);
            sumarPuntuacion();
            estaEncima = false;

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        estaEncima = true;
        if(collision.gameObject.tag == "NotaPartitura")
        {
            notaPartitura = collision.gameObject;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        estaEncima = false;
    }


    public void sumarPuntuacion()
    {
        PlayerPrefs.SetInt("Puntuacion", PlayerPrefs.GetInt("Puntuacion") + 100);
    }



}
