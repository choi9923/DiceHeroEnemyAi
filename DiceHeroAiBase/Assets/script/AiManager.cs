using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AiManager : MonoBehaviour
{
    
    public int attChace;
    public int defChace;
    public int moveChace;
    public List<GameObject> Units = new List<GameObject>();
    public List<GameObject> dirUnits = new List<GameObject>();
    public GameObject[] StartUnits;
  
    //public GameObject[] attackUnits = new GameObject[3];
    //int num = 0;
    private void Start()
    {
        StartUnits = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject unit in StartUnits)
            Units.Add(unit);
       
        
        EnemyAi();
    }
 
    
    public void StartAi(GameObject[] EnemyUnits)   //여기서 상대 유닛들을 받음.
    {
        foreach (GameObject unit in EnemyUnits)
            Units.Add(unit);
        EnemyAi();
    }

    void EnemyAi()
    {

        //Debug.Log(units[1].gameObject.name);
        if (attChace > 0)
        {
            foreach (GameObject units in Units)
            {
                UnitBase unit = units.GetComponent<Unit>().GetUnit();
                //여기서 hp를 받아서 백분율을 낸다.(지금은 아직 백분율 안함)
                int maxHp = unit.curHP;
                int curHp = unit.HP;


                if (curHp / maxHp * 100.0 >= 25)//체력 25% 이상.
                {
                    //누가 통과했는지 확인하고 공격가능 인원 한번더 구분함.
                    //Debug.Log("1차공격가능 인원 :" + unit);

                    //attackUnits[num] = unit; 
                    //num++;
                    dirUnits.Add(units);
                }

            }
            if (dirUnits.Count == 0)
            {
                dirUnits.Add(Units[0]);//제일 처음꺼 아니면 랜덤으로 할 예정

            }
            attackDis();

        }
        else if (defChace > 0)
        {
            foreach (GameObject units in Units)
            {
                UnitBase unit = units.GetComponent<Unit>().GetUnit();
                //여기서 hp를 받아서 백분율을 낸다.(지금은 아직 백분율 안함)
                int maxHp = unit.curHP;
                int curHp = unit.HP;


                if (curHp / maxHp * 100.0 > 30)//체력 30% 이상.
                {
                    dirUnits.Add(units);
                }

            }
            if(dirUnits.Count == 0)
            {
                dirUnits.Add(Units[0]);//제일 처음꺼 아니면 랜덤으로 할 예정
            }
            
            DefDis();

        }
        else if(moveChace > 0)
        {
            
          moveDis();
            
        }
        else
        {
            Debug.Log("이제 주사위 없음");
        }
    }
        

    void attackDis()
    {
        attChace--;
        int maxAtt = 0;
        GameObject dicAtt = StartUnits[0];
        UnitBase unit;
        foreach (GameObject attUnit in dirUnits)//여기서 공격순으로 정렬
        {
           unit = attUnit.GetComponent<Unit>().GetUnit();
            if (maxAtt < unit.curAD)
            {
                
                maxAtt = unit.curAD;
                dicAtt = attUnit;               
                
            }           
            
        }
        unit = dicAtt.GetComponent<Unit>().GetUnit();
        Debug.Log("공격선택 : " + unit.Name);
        Units.Remove(dicAtt);
        dirUnits.Clear();

        EnemyAi();
    }

    void DefDis()
    {
        defChace--;
        int maxDef = 0;
        GameObject dicDef = StartUnits[0];
        UnitBase unit;
        foreach (GameObject defUnit in dirUnits)//여기서 공격순으로 정렬
        {
            unit = defUnit.GetComponent<Unit>().GetUnit();
            if (maxDef < unit.curDF)
            {

                maxDef = unit.curDF;
                dicDef = defUnit;

            }

        }
        unit = dicDef.GetComponent<Unit>().GetUnit();
        Debug.Log("방어선택 : " + unit.Name);
        Units.Remove(dicDef);
        dirUnits.Clear();

        EnemyAi();
    }
    void moveDis()
    {
        moveChace--;
        UnitBase unit = Units[0].GetComponent<Unit>().GetUnit();
        Debug.Log("이동선택 : " + unit.Name);
        Units.Remove(Units[0]);
        EnemyAi();

    }
    

}
