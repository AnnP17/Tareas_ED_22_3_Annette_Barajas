using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public string mensaje;

    void OnMouseDown() 
    {
        //Destroy de gameObject after clicking on it
        //Destroy(gameObject);
        Debug.Log(mensaje);
    }
}
