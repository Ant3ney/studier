using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldParticleControll : MonoBehaviour
{
    public ParticleSystem PS;
    // Start is called before the first frame update
    void Start()
    {
        PS = FindObjectOfType<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGoldOnece()
    {
        PS.Play();
    }
}
