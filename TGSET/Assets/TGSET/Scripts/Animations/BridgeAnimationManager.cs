using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeAnimationManager : MonoBehaviour
{
    private Animation bridgeAnim;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        bridgeAnim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.managerInstance.isFreezeTimeCasted)
        {
            if (bridgeAnim.isActiveAndEnabled)
            {
                bridgeAnim.enabled = false;
            }
        }
        else
        {
            if (!bridgeAnim.isActiveAndEnabled)
            {
                bridgeAnim.enabled = true;
            }
        }
        
    }

    public void PlayBridgeSound()
    {
        if (GameManager.managerInstance.isOnLevel1)
        {
            source.pitch = Random.Range(0.9f, 1.1f);
            source.Play();
        }
    }
}
