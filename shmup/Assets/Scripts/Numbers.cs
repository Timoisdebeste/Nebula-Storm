using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numbers : MonoBehaviour
{
    public Text MycashText;
    public int CashNum;

    // Start is called before the first frame update
    void Start()
    {
        CashNum = 0;
        MycashText.text = "Cash : " + CashNum;
    }
    public void GainCash(int Cash)
    {
        CashNum += Cash;

    }
}
