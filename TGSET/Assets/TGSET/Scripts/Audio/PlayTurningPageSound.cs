using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTurningPageSound : MonoBehaviour
{
    public AudioSource source;

    public void PlayPageSound()
    {
        source.pitch = Random.Range(0.9f, 1.1f);
        source.Play();
    }

}
