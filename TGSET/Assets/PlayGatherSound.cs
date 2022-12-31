using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGatherSound : MonoBehaviour
{
    private AudioSource source;
    bool hasPlayed;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        hasPlayed = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasPlayed && GameManager.managerInstance.isFreezeTimeAvailable)
        {
            source.pitch = Random.Range(0.9f, 1.1f);
            source.Play();
            hasPlayed = true;
        }
    }
}
