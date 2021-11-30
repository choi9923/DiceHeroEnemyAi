using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputManager : MonoBehaviour
{

    public InputField input_ID;
    public InputField input_PW;
    public Button button;
    public Text IDtxt;
    public Text PWtxt;
    // Start is called before the first frame update
   // public string[] IDdata = new string[3];
    //public string[] PWdata = new string[3];
    public string IDdata;
    public string PWdata;

    int i = 0;
    public void OutPutButton()
    {
        IDdata = input_ID.text;
        PWdata = input_PW.text;

        IDtxt.text = IDdata;
        PWtxt.text = PWdata;

        if (i == 2)
        {
            Debug.Log("∞°µÊ√°¥Ÿ.");
        }
        else
        {
            i++;
        }

    }
    public void Delete1()
    {
        IDtxt.text = "";
        PWtxt.text = "";
    }
    public void Delete2()
    {
        IDtxt.text = "";
        PWtxt.text = "";
    }
    public void Delete3()
    {
        IDtxt.text = "";
        PWtxt.text = "";
    }
}
