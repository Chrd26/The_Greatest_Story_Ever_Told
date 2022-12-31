using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator anim;
    public AudioSource open;
    public AudioSource close;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.StartPlayback();
    }

    // Update is called once per frame
    void Update()
    {
	
        if (!GameManager.managerInstance.isFreezeTimeCasted && GameManager.managerInstance.isFreezeTimeAvailable)
        {
            anim.StopPlayback();
        }
        else if ((GameManager.managerInstance.isFreezeTimeCasted && GameManager.managerInstance.isFreezeTimeAvailable))
        {
            anim.StartPlayback();
        }
    }

    public void DoorOpenSound()
    {
        if (GameManager.managerInstance.isOnLevel1)
        {
            open.pitch = Random.Range(0.9f, 1.1f);
            open.Play();
        }
    }

    public void DoorCloseSound()
    {
        if (GameManager.managerInstance.isOnLevel1)
        {
            close.pitch = Random.Range(0.9f, 1.1f);
            close.Play();
        }
    }
}
