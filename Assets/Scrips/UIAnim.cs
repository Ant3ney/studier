using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnim : MonoBehaviour
{
    public Animator Anim;
    bool OnOrNot = true;
    public AudioSource AudioSorce;
    public AudioClip Swich;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        AudioSorce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitMissionBuilder()
    {
        
    }
    public void StartMissionBuilder()
    {
        bool quit;
        quit = false;
        if (OnOrNot)
        {
            Anim.SetTrigger("1");
            OnOrNot = false;
            quit = true;
            AudioSorce.clip = Swich;
            AudioSorce.Play();
        }
        if (!OnOrNot && !quit)
        {
            Anim.SetTrigger("2");
            OnOrNot = true;
            AudioSorce.clip = Swich;
            AudioSorce.Play();
        }        
    }
}
