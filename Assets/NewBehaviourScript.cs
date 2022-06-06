using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
  // Start is called before the first frame update
    void Start()
    {
        texto.text = "Capitán de división de Toman favorito:   a) Mitsuya b) Baji c) Pahchin d) Smiley";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            texto.text= "Mitsuya: No odies la situación en la que naciste";
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            texto.text= "Baji: Uno para todos, y todos para uno. Pondremos nuestras vidas en juego por los otros";
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            texto.text= "Pahchin: EH?! No sé nada sobre esa tontería porque soy demasiado tonto";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            texto.text= "Smiley: Si vas a pelear solo, yo haré lo mismo";
        }
    }

}