using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyDisplay : MonoBehaviour
{
    public MoneyGeneration MoneyStatus;
    public TMP_Text CanvasText;
    public Powerups_controller gowno;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CanvasText.text = MoneyStatus.money.ToString() + "   multiplier: "+gowno.smiec.ToString() + "x";
    }
}
