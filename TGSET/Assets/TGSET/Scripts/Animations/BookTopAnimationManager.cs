using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookTopAnimationManager : MonoBehaviour
{
    //Create an animation variable
    private Animation openBookAnim;
    public GameObject startButton;
    public Animation spineBookOpen;

    // Start is called before the first frame update
    void Start()
    {
        //Set variable to the animation component
        openBookAnim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Play Animation Function
    public void PlayOpenBookAnimation() {

        openBookAnim.Play("BookTopAnim");
        spineBookOpen.Play("BookSpineOpeningAnim");
        startButton.SetActive(false);
    }
}
