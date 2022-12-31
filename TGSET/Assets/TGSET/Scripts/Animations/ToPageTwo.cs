using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPageTwo : MonoBehaviour
{
    private Animation turnPage;
    public GameObject pageTwoButton;
    public AudioSource source;

    private void Awake()
    {
        turnPage = GetComponent<Animation>();
    }

    public void GoToPageTwo() {

        turnPage.Play("BookPage1TurnAnim");
        pageTwoButton.SetActive(false);
        GameManager.managerInstance.isOnLevel1 = true;
        GameManager.managerInstance.isonLevel = true;

    }

    public void PlayPageTurningSound()
    {
        source.Play();
        source.pitch = Random.Range(0.9f, 1.1f);
    }
}
