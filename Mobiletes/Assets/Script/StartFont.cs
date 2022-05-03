using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFont : MonoBehaviour
{
    public Text Font;
    //rgb 0.150.255
    private float Green;
    private bool Check;
    private void Start()
    {
        Green = 150.0f/255.0f;
        Check = false;
    }
    private void Update()
    {
        StartCoroutine("ChangeColor");
    }

    IEnumerator ChangeColor()
    {
        while(true)
        {
            if (Green >= 1) Check = true;
            else if (Green <= 0.4) Check = false;
            if (Check) Green-=0.0001f;
            else Green+=0.0001f;
            Font.color = new Color(0,Green,1);
            yield return null;
        }
        
    }
}
