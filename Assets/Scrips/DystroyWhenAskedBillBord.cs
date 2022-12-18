using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DystroyWhenAskedBillBord : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BillbordSystroy() //Destroys this object if any class calls this comand. that call this comand
    {
        Destroy(this.gameObject);
        print("BillbordDystroyedEnd");
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        Destroy(this.gameObject);
        
    }
}
