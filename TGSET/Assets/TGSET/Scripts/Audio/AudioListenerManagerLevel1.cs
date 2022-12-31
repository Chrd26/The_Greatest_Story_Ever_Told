using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioListenerManagerLevel1 : MonoBehaviour
{
    private AudioListener listener;

    // Start is called before the first frame update
    void Start()
    {
        listener = GetComponent<AudioListener>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.managerInstance.isonLevel)
        {
            listener.enabled = true;
        }
        else
        {
            listener.enabled = false;
        }
        
    }
}
