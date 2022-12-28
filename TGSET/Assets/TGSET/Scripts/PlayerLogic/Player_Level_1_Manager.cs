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
        playerAnimations.SetTrigger("FrontWalkAnim");
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        AnimationManager();
        movement();
    }

    private void AnimationManager()
    {

    }

    private void movement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
    }


}
