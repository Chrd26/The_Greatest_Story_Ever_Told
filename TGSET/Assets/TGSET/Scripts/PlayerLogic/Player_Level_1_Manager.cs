using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Level_1_Manager : MonoBehaviour
{
    private Animator playerAnimations;
    private float speed;

    // Start is called before the first frame update

    void Start()
    {
        playerAnimations = GetComponent<Animator>();
        speed = 0.1f;
    }

    // Update is called once per frame

    void Update()
    {
        MovementAnimationManager();
        movement();
    }

    //Manage Animations Based on Key Pressess

    private void MovementAnimationManager()
    {
        //Start Movement Animations

        if (Input.GetKey(KeyCode.D))
        {
            PlayWalkLeftSideAnimation();
            StopIdleLeftSideAnimation();
            StopWalkFrontAnimation();
            StopWalkBackAnimation();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            PlayWalkRightSideAnimation();
            StopIdleRightSideAnimation();
            StopWalkFrontAnimation();
            StopWalkBackAnimation();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            PlayWalkFrontAnimation();
            StopIdleFrontAnimation();
            StopWalkLeftSideAnimation();
            StopWalkRightSideAnimation();
            StopWalkBackAnimation();
        }
        else if (Input.GetKey(KeyCode.W))
        {
            PlayWalkBackAnimation();
            StopIdleFrontAnimation();
            StopIdleRightSideAnimation();
            StopIdleLeftSideAnimation();
            StopIdleBackAnimation();
        }

        //Stop Movement Animations

        if (Input.GetKeyUp(KeyCode.D))
        {
            if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                PlayIdleLeftSideAnimation();
                StopWalkLeftSideAnimation();
            }
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                PlayIdleRightSideAnimation();
                StopWalkRightSideAnimation();
            }
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W))
            {
                PlayIdleFrontAnimation();
                StopWalkFrontAnimation();
            }
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S))
            {
                PlayIdleBackAnimation();
                StopWalkBackAnimation();
            }
        }
    }

    //Left Side Animations Functions

    private void PlayWalkLeftSideAnimation()
    {
        playerAnimations.SetTrigger("WalkLeftAnim");
        playerAnimations.ResetTrigger("WalkRightAnim");
        playerAnimations.ResetTrigger("FrontWalkAnim");
        playerAnimations.ResetTrigger("BackWalkAnim");
    }

    private void PlayIdleLeftSideAnimation()
    {
        playerAnimations.SetTrigger("IdleLeftAnim");
    }

    private void PlaySpellLeftSideAnimation()
    {
        playerAnimations.SetTrigger("SpellLeftAnim");
    }

    private void StopWalkLeftSideAnimation()
    {
        playerAnimations.ResetTrigger("WalkLeftAnim");
    }

    private void StopIdleLeftSideAnimation()
    {
        playerAnimations.ResetTrigger("IdleLeftAnim");
    }

    private void StopSpellLeftSideAnimation()
    {
        playerAnimations.ResetTrigger("SpellLeftAnim");
        PlayIdleLeftSideAnimation();
    }


    //Right Side Animations Functions

    private void PlayWalkRightSideAnimation()
    {
        playerAnimations.SetTrigger("WalkRightAnim");
        playerAnimations.ResetTrigger("WalkLeftAnim");
        playerAnimations.ResetTrigger("FrontWalkAnim");
        playerAnimations.ResetTrigger("BackWalkAnim");
    }

    private void PlayIdleRightSideAnimation()
    {
        playerAnimations.SetTrigger("IdleRightAnim");
    }

    private void PlaySpellRightSideAnimation()
    {
        playerAnimations.SetTrigger("SpellRightAnim");
    }

    private void StopWalkRightSideAnimation()
    {
        playerAnimations.ResetTrigger("WalkRightAnim");
    }

    private void StopIdleRightSideAnimation()
    {
        playerAnimations.ResetTrigger("IdleRightAnim");
    }

    private void StopSpellRightSideAnimation()
    {
        playerAnimations.ResetTrigger("SpellRightAnim");
        PlayIdleRightSideAnimation();
    }


    // Front Side Animations Functions

    private void PlayWalkFrontAnimation()
    {
        playerAnimations.SetTrigger("FrontWalkAnim");
        playerAnimations.ResetTrigger("WalkLeftAnim");
        playerAnimations.ResetTrigger("WalkRightAnim");
        playerAnimations.ResetTrigger("BackWalkAnim");
    }

    private void PlayIdleFrontAnimation()
    {
        playerAnimations.SetTrigger("FrontIdleAnim");
    }

    private void PlaySpellFrontAnimation()
    {
        playerAnimations.SetTrigger("FrontSpellAnim");
    }

    private void StopWalkFrontAnimation()
    {
        playerAnimations.ResetTrigger("FrontWalkAnim");
    }

    private void StopIdleFrontAnimation()
    {
        playerAnimations.ResetTrigger("FrontIdleAnim");
    }

    private void StopSpellFrontAnimation()
    {
        playerAnimations.ResetTrigger("FrontSpellAnim");
        PlayIdleFrontAnimation();
    }

    // Back Side Animations Functions

    private void PlayWalkBackAnimation()
    {
        playerAnimations.SetTrigger("BackWalkAnim");
        playerAnimations.ResetTrigger("FrontWalkAnim");
        playerAnimations.ResetTrigger("WalkLeftAnim");
        playerAnimations.ResetTrigger("WalkRightAnim");
    }

    private void PlayIdleBackAnimation()
    {
        playerAnimations.SetTrigger("BackIdleAnim");
    }

    private void PlaySpellBackAnimation()
    {
        playerAnimations.SetTrigger("BackSpellAnim");
    }

    private void StopWalkBackAnimation()
    {
        playerAnimations.ResetTrigger("BackWalkAnim");
    }

    private void StopIdleBackAnimation()
    {
        playerAnimations.ResetTrigger("BackIdleAnim");
    }

    private void StopSpellBackAnimation()
    {
        playerAnimations.ResetTrigger("BackSpellAnim");
        PlayIdleBackAnimation();
    }

    private void movement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
    }

    private void CastFreezeTime()
    {
        if (GameManager.managerInstance.isFreezeTimeAvailable)
        {

            if (Input.GetButtonDown("Freeze Time"))
            {
                PlaySpellBackAnimation();
                PlaySpellFrontAnimation();
                PlaySpellRightSideAnimation();
                PlaySpellLeftSideAnimation();
            }

            if (Input.GetButtonUp("Freeze Time"))
            {
                StopSpellBackAnimation();
                StopSpellFrontAnimation();
                StopSpellLeftSideAnimation();
                StopSpellRightSideAnimation();
            }
        }
    }


}
