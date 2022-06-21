using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    Image imagePowerup;
    [SerializeField]
    TMP_Text textPowerAmt;

    private bool isPowerUp = false;
    private bool isDirectUp = true;
    private float amtPower = 0.0f;
    private float powerSpeed = 100.0f;
    private float normalSpeed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        if(isPowerUp)
        {
            PowerActive();
        }
    }

    void PowerActive()
    {
        if(isDirectUp)
        {
            amtPower += Time.deltaTime * powerSpeed;
            if(amtPower > 100)
            {
                isDirectUp = false;
                amtPower = 100.0f;
                //lose
            }
        }
        else
        {
            amtPower -= Time.deltaTime * powerSpeed;
            //if (amtPower < 90)
            //{
            //    isDirectUp = true;
            //    amtPower = 50.0f;
            //    //win
            //}
            if (amtPower < 0)
            {
                isDirectUp = true;
                amtPower = 0.0f;
                //lose
            }
        }

        imagePowerup.fillAmount = (0.511f - 0.25f) * amtPower / 100.0f + 0.25f;
    }

    public void StartPowerUp()
    {
        isPowerUp = true;
        amtPower = 0.0f;
        isDirectUp = true;
        textPowerAmt.text = "";
    }

    public void EndPowerUp()
    {
        isPowerUp = false;
        textPowerAmt.text = amtPower.ToString("F0");
    }
}
