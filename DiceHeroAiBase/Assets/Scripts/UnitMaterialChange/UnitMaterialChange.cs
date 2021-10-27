using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitState
{
    public Material idleMaterial;
    public Material attackMaterial;
    public Material deathMaterial;
}

public class UnitMaterialChange : MonoBehaviour
{
    //check Discord:막올려도-상관없는-스크립트-채널 (정리한 유닛들 데이터)
    public int bossUnitStartIndex; //the boss Id is starts on 1000. So you must write where's boss object starts in unitObjects. (look changeStateMaterial function)

    public List<GameObject> unitObjects;
    private List<UnitState> unitState = new List<UnitState>();
    private List<MeshRenderer> frontQuad = new List<MeshRenderer>();
    private List<MeshRenderer> backQuad = new List<MeshRenderer>();
    [SerializeField]
    private List<Animator> unitani = new List<Animator>();
    [SerializeField]
    private List<Transform> uniObT = new List<Transform>();

    public List<Material> unitsIdleMaterial;    //put materials on inspector
    public List<Material> unitsAttackMaterial;  //put materials on inspector
    public List<Material> unitsDeathMaterial;   //put materials on inspector

    // Start is called before the first frame update
    void Start()
    {
        UnitState emptyUnit = new UnitState();
        emptyUnit.idleMaterial = unitsIdleMaterial[0];
        emptyUnit.attackMaterial = unitsAttackMaterial[0];
        emptyUnit.deathMaterial = unitsDeathMaterial[0];

        for (int i = 0; i < unitObjects.Count; i++)
        {
            unitState.Add(emptyUnit);
            unitState[i].idleMaterial = unitsIdleMaterial[0];
            unitState[i].attackMaterial = unitsAttackMaterial[0];
            unitState[i].deathMaterial = unitsDeathMaterial[0];
            unitani[i] = unitObjects[i].GetComponent<Animator>();
            uniObT[i] = unitObjects[i].transform;

            frontQuad.Add(unitObjects[i].transform.Find("front").GetComponent<MeshRenderer>());
            backQuad.Add(unitObjects[i].transform.Find("back").GetComponent<MeshRenderer>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //target is battlefield unit object's index. id is unitId.
    public void changeStateMaterial(int target, int id)
    {
        if (id >= 1001) //if id is over then 1001(boss startId)
        {
            id = bossUnitStartIndex + (id-1001);
        }
        else if (id == bossUnitStartIndex)
        {
            Debug.LogWarning("If you want use boss img, please start from 1001~ ID");
        }
        try
        {
            unitState[target].idleMaterial = unitsIdleMaterial[id];
            unitState[target].attackMaterial = unitsAttackMaterial[id];
            unitState[target].deathMaterial = unitsDeathMaterial[id];

            frontQuad[target].material = unitState[target].idleMaterial;
            backQuad[target].material = unitState[target].attackMaterial;
            return;
        }
        catch
        {
            Debug.LogError("해당 유닛의 ID를 불러오지 못했거나 존재하지 않는 ID입니다.");
        }
    }
    public void changeBack(int target, int mode) //mode 0:attack_to_death 1:death_to_attack
    {
        backQuad[target].material = mode == 0 ? unitState[target].deathMaterial : unitState[target].attackMaterial;
    }
    public void Attack(int target)
    {
        changeBack(target,1);
    }
    public void Dead(int target)
    {
        changeBack(target, 0);
    }

}
