using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsSoundsManager : MonoBehaviour
{
    public AudioClip[] footsteps;
    private float countdown = 0;
    private int randomNumber;
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        randomNumber = Random.Range(0, 5);
        source.clip = footsteps[randomNumber];
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown < 1)
        {
            countdown += 1 * Time.deltaTime;
        }
        else
        {
            if (!source.isPlaying)
            {
                randomNumber = Random.Range(0, 5);
                source.clip = footsteps[randomNumber];
            }
        }
    }
}
