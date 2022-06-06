using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
  // Start is called before the first frame update
    void Start()
    {
        texto.text = 'Ingrese Opcion';
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            text.text= 'Mitsuya: No odies la situación en la que naciste';
        }
        if (input.GetKeyDown(KeyCode.B))
        {
            text.text= 'Baji: Uno para todos, y todos para uno. Pondremos nuestras vidas en juego por los otros'
        }
        if (input.GetKeyDown(KeyCode.C))
        {
            text.text= 'Pahchin: EH?! No sé nada sobre esa tontería porque soy demasiado tonto'
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            text.text= 'Smiley: Si vas a pelear solo, yo haré lo mismo'
        }
    }

}