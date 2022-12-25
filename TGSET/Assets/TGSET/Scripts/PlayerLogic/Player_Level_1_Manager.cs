using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Level_1_Manager : MonoBehaviour
{
    private Animator playerAnimations;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayWalkAnimationSide();
    }

    private void PlayWalkAnimationSide() {
        
        if (Input.GetKey(KeyCode.A))
        {
            playerAnimations.SetTrigger("Right Side Walk Animation Trigger");
            playerAnimations.ResetTrigger("Side Idle Animation Trigger");
            playerAnimations.ResetTrigger("Left Side Walk Animation Trigger");

        }
        else if (Input.GetKey(KeyCode.D))
        {

            playerAnimations.SetTrigger("Left Side Walk Animation Trigger");
            playerAnimations.ResetTrigger("Side Idle Animation Trigger");
            playerAnimations.ResetTrigger("Right Side Walk Animation Trigger");

        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnimations.ResetTrigger("Right Side Walk Animation Trigger");
            playerAnimations.SetTrigger("Side Idle Animation Trigger");

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {

            playerAnimations.ResetTrigger("Left Side Walk Animation Trigger");
            playerAnimations.SetTrigger("Side Idle Animation Trigger");

        }


    }

}
