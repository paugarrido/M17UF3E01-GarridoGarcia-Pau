using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotaPartitura : MonoBehaviour
{

    Rigidbody2D rigidbody;
    public float velocidad;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector3(0, -velocidad, 0);
    }

    void Update()
    {
        
    }
}
