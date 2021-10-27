using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGameManager : MonoBehaviour
{
    public FadeInOut fading;
    public MaterialAnimation curtainOpen;
    public MaterialAnimation curtainClose;
    public BeamProjector beamProjector;
    public LightOnOff stageLight;
    public OBAni gateDown;
    public List<GameObject> mustActiveFalse;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(starting());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator starting()
    {
        yield return new WaitForSeconds(0.1f);
        fading.FadeIn();
        yield return new WaitForSeconds(3f);
        curtainOpen.StartAnimation();
        yield return new WaitForSeconds(3f);
        beamProjector.Show();
        yield return new WaitForSeconds(18f);
        stageLight.toggleLight();
        yield return new WaitForSeconds(1f);
        gateDown.StartOp();
        yield return new WaitForSeconds(12f);
        StartCoroutine(closeCurtain());
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < mustActiveFalse.Count; i++)
        {
            mustActiveFalse[i].SetActive(false);
        }
    }

    IEnumerator closeCurtain()
    {
        yield return new WaitForSeconds(0.1f);
        curtainClose.StartAnimation();
    }
}
