using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleSystem : MonoBehaviour
{
    public ParticleSystem _particleSystem;
    public AudioSource sound;
    public bool soundCheck;



    void Update()
    {
        if (_particleSystem.time >= _particleSystem.emission.GetBurst(0).time && sound.isPlaying == false && soundCheck == false)
        {
            if (playerManager.musicOnOff == 0)
            {
                sound.Play();
                soundCheck = true;
            }

        }

        if (_particleSystem.time == 2)
        {
            soundCheck = false;
            gameObject.SetActive(false);
        }
    }
}
