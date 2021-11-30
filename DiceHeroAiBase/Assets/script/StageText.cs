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
    public void OnStage()//���� ������Ʈ ������ ȣ��
    {
        bonyRender.material.color = new Color(255f, 255f, 255f, 255f);
    }
    public void BlindStage() //�������� �ܰ� �Ⱥ��̰� �ϴ°�. ���� ������Ʈ ���ö� ȣ��
    {
        
        bonyRender.material.color = new Color(255f, 255f, 255f, 0f);
    }
}
