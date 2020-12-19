using System;
using UnityEngine;
using UnityEngine.UI;

public class CtrlInput : MonoBehaviour
{
    public StartClick start;
    public StopClick stop;

    GvrControllerInputDevice Controller;


    void Start()
    {
        Controller = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
    }
    private float quitTime = 0;
    private bool mirastart = true;

    public void Update()
    {

        if (Controller.GetButtonDown(GvrControllerButton.TouchPadButton))
        {

            if (Controller.TouchPos.x < Controller.TouchPos.y & -Controller.TouchPos.x < Controller.TouchPos.y)
            {
                //Upper part of touchpad

                Debug.Log("Top");
            }
            if (Controller.TouchPos.x > Controller.TouchPos.y & -Controller.TouchPos.x > Controller.TouchPos.y)
            {
                //Lower part of touchpad

                Debug.Log("Bottom");
            }
            else if (Controller.TouchPos.x >= Controller.TouchPos.y & -Controller.TouchPos.x <= Controller.TouchPos.y)
            {
                click.GetComponent<Click>().click = 1;  //Right part of the touchpad
            }

            else if (Controller.TouchPos.x <= Controller.TouchPos.y & -Controller.TouchPos.x >= Controller.TouchPos.y)
            {
                click.GetComponent<Click>().click = 0;  //Left part of the touchpad
            }
        }
        //ppos.GetComponent<PolePos>().plps = GetComponent<Slider>().value / 10;
        //ptxt.GetComponent<plpsTxt>().plpstxt = GetComponent<Slider>().value / 10;
    }

    internal object Getcomponet<T>()
    {
        throw new NotImplementedException();
    }
}
