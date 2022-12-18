using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EconomyAdder : MonoBehaviour
{
    public int Gold;
    public TextMeshProUGUI TMPString;
    // Start is called before the first frame update
    void Start()
    {
        TMPString = GetComponent<TextMeshProUGUI>();
        UpdateGoldCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateGoldCount()
    {
        TMPString.text = Gold.ToString();
    }
    public void AddGold(int Amt)
    {
        Gold += Amt;
        UpdateGoldCount();
    }
}
