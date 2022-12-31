using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator anim;

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
            Debug.Log("Play Anim");
        }
        else if ((GameManager.managerInstance.isFreezeTimeCasted && GameManager.managerInstance.isFreezeTimeAvailable))
        {
            anim.StartPlayback();
            Debug.Log("Stop Anim");
        }
    }
}
