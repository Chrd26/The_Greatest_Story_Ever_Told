using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track1Manager : MonoBehaviour
{
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.managerInstance.isFreezeTimeCasted)
        {
            source.Pause();
        }
        else if (!source.isPlaying)
        {
            source.UnPause();
        }
    }
}
