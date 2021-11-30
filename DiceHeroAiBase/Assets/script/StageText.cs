using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageText : MonoBehaviour
{
    public Material[] mat;
    public Material[] mats;
    public MeshRenderer bonyRender;
    public Material stage1, stage2;
    public List<Material> Stages = new List<Material>();
    public int iii;
    // Start is called before the first frame update

    
    public void startStageText()
    {
        mats = bonyRender.sharedMaterials;

        foreach (Material mater in mat)
            Stages.Add(mater);

        
    }
    // Update is called once per frame
    public void ChangeStage(int i)
    {

        mats[0] = Stages[i];
        bonyRender.sharedMaterials = mats;
    }
    public void OnStage()//유닛 스테이트 끝날때 호출
    {
        bonyRender.material.color = new Color(255f, 255f, 255f, 255f);
    }
    public void BlindStage() //스테이지 단계 안보이게 하는거. 유닛 스테이트 나올때 호출
    {
        
        bonyRender.material.color = new Color(255f, 255f, 255f, 0f);
    }
}
