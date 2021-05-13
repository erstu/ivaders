using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
public AudioClip explosionSound,bulletSound;
   
    void PlayExplosionSound()
    {
        GetComponent<AudioSource>().PlayOneShot(explosionSound);
    }

    // Update is called once per frame
    void PlayBulletSound()
    {
      GetComponent<AudioSource>().PlayOneShot(bulletSound);  

    }
}
