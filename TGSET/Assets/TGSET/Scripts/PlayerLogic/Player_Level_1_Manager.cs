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
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        AnimationManager();
        movement();
    }

    //Manage Animations Based on Key Pressess

    private void AnimationManager()
    {
        if (Input.GetKey(KeyCode.D))
        {
            PlayWalkLeftSideAnimation();
            StopIdleLeftSideAnimation();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            PlayWalkRightSideAnimation();
            StopIdleRightSideAnimation();
        }
        
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
        
    }

    //Left Side Animations Functions

    private void PlayWalkLeftSideAnimation()
    {
        playerAnimations.SetTrigger("WalkLeftAnim");
    }

    private void PlayIdleLeftSideAnimation()
    {
        playerAnimations.SetTrigger("IdleLeftAnim");
    }

    private void PlaySpellLeftSideAnimation()
    {
        playerAnimations.SetTrigger("SpellLeftAnim");
        playerAnimations.ResetTrigger("WalkRightAnim");
    }

    private void StopWalkLeftSideAnimation()
    {
        playerAnimations.ResetTrigger("WalkLeftAnim");
    }

    private void StopIdleLeftSideAnimation()
    {
        playerAnimations.ResetTrigger("IdleLeftAnim");
    }

    private void StopAttackLeftSideAnimation()
    {
        playerAnimations.ResetTrigger("SpellLeftAnim");
    }

    //Right Side Animations Functions

    private void PlayWalkRightSideAnimation()
    {
        playerAnimations.SetTrigger("WalkRightAnim");
        playerAnimations.ResetTrigger("WalkLeftAnim");
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

    private void StopAttackrightSideAnimation()
    {
        playerAnimations.ResetTrigger("SpellRightAnim");
    }


    private void movement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
    }


}
