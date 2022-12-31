using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem particle;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.managerInstance.isFreezeTimeCasted)
        {
            particle.Pause();
            material.SetColor("_EmissiveColor", Color.cyan * 100);
        }
        else
        {
            particle.Play();
            material.SetColor("_EmissiveColor", Color.yellow * 100);
        }
    }
}
