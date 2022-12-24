using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPageTwo : MonoBehaviour
{
    private Animation turnPage;
    public GameObject pageTwoButton;

    private void Awake()
    {
        turnPage = GetComponent<Animation>();
    }

    public void GoToPageTwo() {

        turnPage.Play("BookPage1TurnAnim");
        pageTwoButton.SetActive(false);
        GameManager.managerInstance.isOnLevel1 = true;

    }
}
