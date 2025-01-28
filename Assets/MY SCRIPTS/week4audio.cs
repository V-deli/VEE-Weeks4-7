using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week4audio : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public week4audio script;
    public AudioSource audioSource;
    public AudioClip audioClip;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            sr.enabled = false;
            go.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            go.SetActive(true);

            //go.activeInHierarchy
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(audioSource.isPlaying==false)
            {
                audioSource.PlayOneShot(audioClip);
            }
            //audiosource.clip.length
        }
    }
}
//drag object into sr
//drag something into go (object)


//add component to game object
//add "audio source"
//music folder, drop in audio clip
// play on awake un-checked!
