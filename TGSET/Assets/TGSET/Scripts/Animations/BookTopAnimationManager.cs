using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookTopAnimationManager : MonoBehaviour
{
    //Create an animation variable
    private Animation openBookAnim;
    public GameObject startButton;
    public Animation spineBookOpen;
    public GameObject page2Button;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        //Set variable to the animation component
        openBookAnim = GetComponent<Animation>();
    }


    //Play Animation Function
    public void PlayOpenBookAnimation() {

        openBookAnim.Play("BookTopAnim");
        spineBookOpen.Play("BookSpineOpeningAnim");
        startButton.SetActive(false);
        page2Button.SetActive(true);
    }

    public void PlayBookOpeningSound()
    {
        source.Play();
        source.pitch = Random.Range(0.9f, 1.1f);
    }
}
