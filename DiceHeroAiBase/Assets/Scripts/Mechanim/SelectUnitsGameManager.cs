using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectUnitsGameManager : MonoBehaviour
{
    public FadeInOut fading;
    public VideoManager videoPlayAndzoomInout;
    GameManager gameManager;
    public ChooseSlot chooseSlot;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
        StartCoroutine(starting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator starting()
    {
        yield return new WaitForSeconds(1f);
        fading.FadeIn();
        videoPlayAndzoomInout.StartPamplet();
    }

    public void selectFinish()
    {
        for (int i = 0; i < chooseSlot.unitId.Count; i++)
        {
            gameManager.player.AddCharacter(chooseSlot.unitId[i]);
        }

        StartCoroutine(ending());
    }
    IEnumerator ending()
    {
        fading.FadeOut();
        videoPlayAndzoomInout.EndPamplet();
        yield return new WaitForSeconds(5f);
        gameManager.loadScene.SceneLoad(2);
    }
}
