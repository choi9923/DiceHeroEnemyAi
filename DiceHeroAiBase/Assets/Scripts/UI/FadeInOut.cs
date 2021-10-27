using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public Image fadeImg;
    public GameObject fadeImgObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FadeIn()
    {
        fadeImgObj.SetActive(true);
        StartCoroutine(Fading(0));
    }
    public void FadeOut()
    {
        fadeImgObj.SetActive(true);
        StartCoroutine(Fading(1));
    }

    IEnumerator Fading(int mode)
    {
        fadeImg.color = new Color(0, 0, 0, mode == 0 ? 1 : 0);
        float fadecnt = 0;

        while (fadecnt < 1.0f)
        {
            fadeImg.color = new Color(0, 0, 0, mode == 0 ? 1 - fadecnt : fadecnt);
            yield return new WaitForSeconds(0.01f);
            fadecnt += 0.005f;
        }
        fadeImg.color = new Color(0, 0, 0, mode == 0 ? 1 - fadecnt : fadecnt);
        //fadeImgObj.SetActive(false);
    }
}
