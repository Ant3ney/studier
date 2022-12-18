using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public DystroyWhenAskedBillBord DWABB;
    public GameObject Slide01BillBord;
    public GameObject Slide02BillBord;
    public GameObject Slide03BillBord;
    public GameObject Slide04BillBord;
    public GameObject Slide05BillBord;
    public GameObject Slide06BillBord;
    public GameObject Slide07BillBord;
    public GameObject Slide08BillBord;
    public GameObject Slide09BillBord;
    public GameObject Slide10BillBord;
    public GameObject Slide11BillBord;
    public GameObject Slide12BillBord;
    public GameObject Slide13BillBord;
    public GameObject Slide14BillBord;
    public GameObject Slide15BillBord;
    public GameObject Slide16BillBord;
    public GameObject Slide17BillBord;
    public GameObject Slide18BillBord;
    public GameObject Slide19BillBord;
    public GameObject Slide20BillBord;
    // Start is called before the first frame update
    void Start()
    {
        DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
    }


    // Update is called once per frame
    void Update()
    {

        DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();

    }
    public void SLideBilbord(int NUM)
    {
        if (NUM == 2)
        {
            //print("BillbordDystroyed");
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide02BillBord);
        }
        if (NUM == 3)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide03BillBord);
        }
        if (NUM == 4)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide04BillBord);
        }
        if (NUM == 5)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide05BillBord);
            //print("Instantiated");
        }
        if (NUM == 6)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide06BillBord);
        }
        if (NUM == 7)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide07BillBord);
        }
        if (NUM == 8)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide08BillBord);
        }
        if (NUM == 9)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide09BillBord);
        }
        if (NUM == 10)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide10BillBord);
        }
        if (NUM == 11)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide11BillBord);
        }
        if (NUM == 12)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide12BillBord);
        }
        if (NUM == 13)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide13BillBord);
        }
        if (NUM == 14)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide14BillBord);
        }
        if (NUM == 15)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide15BillBord);
        }
        if (NUM == 16)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide16BillBord);
        }
        if (NUM == 17)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide17BillBord);
        }
        if (NUM == 18)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide18BillBord);
        }
        if (NUM == 19)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide19BillBord);
        }
        if (NUM == 20)
        {
            DWABB = FindObjectOfType<DystroyWhenAskedBillBord>();
            DWABB.BillbordSystroy();
            Inseator(Random.Range(1, 16));
            //Instantiate(Slide20BillBord);
        }
    }
    void Inseator(int Rnd)
    {
        if (Rnd == 1)
        {
            Instantiate(Slide01BillBord);
        }
        else if (Rnd == 2)
        {
            Instantiate(Slide02BillBord);
        }
        else if (Rnd == 3)
        {
            Instantiate(Slide03BillBord);
        }
        else if (Rnd == 4)
        {
            Instantiate(Slide04BillBord);
        }
        else if (Rnd == 5)
        {
            Instantiate(Slide05BillBord);
        }
        else if (Rnd == 6)
        {
            Instantiate(Slide06BillBord);
        }
        else if (Rnd == 7)
        {
            Instantiate(Slide07BillBord);
        }
        else if (Rnd == 8)
        {
            Instantiate(Slide08BillBord);
        }
        else if (Rnd == 9)
        {
            Instantiate(Slide09BillBord);
        }
        else if (Rnd == 10)
        {
            Instantiate(Slide10BillBord);
        }
        else if (Rnd == 11)
        {
            Instantiate(Slide11BillBord);
        }
        else if (Rnd == 12)
        {
            Instantiate(Slide12BillBord);
        }
        else if (Rnd == 13)
        {
            Instantiate(Slide13BillBord);
        }
        else if (Rnd == 14)
        {
            Instantiate(Slide01BillBord);
        }
        else if (Rnd == 15)
        {
            Instantiate(Slide02BillBord);
        }
        else
        {
            Instantiate(Slide03BillBord);
        }
    }
}
