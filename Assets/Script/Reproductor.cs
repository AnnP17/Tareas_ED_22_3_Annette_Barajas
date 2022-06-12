using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{
    [SerializeField]
    AudioSource audioS;
    public AudioClip[] ListaAudio;
    public int indice=0;
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        //ListaAudio= new AudioClip[3];

        audioS.clip = ListaAudio[indice];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            indice++;
        }
        
        audioS.clip = ListaAudio[indice];

        console.log(AudioSource({0})).length;
        console.log(AudioSource({1})).length;
        console.log(AudioSource({2})).length;
    }
}
