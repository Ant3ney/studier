using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissableSelected : MonoBehaviour
{
    public GameObject Selected01;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TurnOff()
    {
        Selected01.SetActive(false);
    }
    public void TurnOn()
    {
        Selected01.SetActive(true);
    }
    
}
