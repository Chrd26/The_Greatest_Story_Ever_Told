using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeSpellGather : MonoBehaviour
{
    public GameObject spellBall;
    public Animation playFreezeBallText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playFreezeBallText.Play();
            GameManager.managerInstance.isFreezeTimeAvailable = true;
            Destroy(spellBall);
            Destroy(this.gameObject);
        }
    }
}
