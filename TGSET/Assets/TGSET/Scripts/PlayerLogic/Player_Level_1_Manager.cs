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
        playerAnimations.SetTrigger("FrontWalkAnim");
    }

    // Update is called once per frame
    void Update()
    {
        AnimationManager();
    }

    private void AnimationManager()
    {

    }



}
