using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBackgroundChanger : MonoBehaviour
{
    public MeshRenderer stageBackground;
    public List<Material> stages;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeBackground(int stageNum)
    {
        try
        {
            stageBackground.material = stages[stageNum];
        }
        catch
        {
            Debug.LogError("bruh, there's no Material");
        }
    }
}
