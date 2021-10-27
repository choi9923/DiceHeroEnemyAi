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
 
    
    public void StartAi(GameObject[] EnemyUnits)   //���⼭ ��� ���ֵ��� ����.
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
                //���⼭ hp�� �޾Ƽ� ������� ����.(������ ���� ����� ����)
                int maxHp = unit.curHP;
                int curHp = unit.HP;


                if (curHp / maxHp * 100.0 >= 25)//ü�� 25% �̻�.
                {
                    //���� ����ߴ��� Ȯ���ϰ� ���ݰ��� �ο� �ѹ��� ������.
                    //Debug.Log("1�����ݰ��� �ο� :" + unit);

                    //attackUnits[num] = unit; 
                    //num++;
                    dirUnits.Add(units);
                }

            }
            if (dirUnits.Count == 0)
            {
                dirUnits.Add(Units[0]);//���� ó���� �ƴϸ� �������� �� ����

            }
            attackDis();

        }
        else if (defChace > 0)
        {
            foreach (GameObject units in Units)
            {
                UnitBase unit = units.GetComponent<Unit>().GetUnit();
                //���⼭ hp�� �޾Ƽ� ������� ����.(������ ���� ����� ����)
                int maxHp = unit.curHP;
                int curHp = unit.HP;


                if (curHp / maxHp * 100.0 > 30)//ü�� 30% �̻�.
                {
                    dirUnits.Add(units);
                }

            }
            if(dirUnits.Count == 0)
            {
                dirUnits.Add(Units[0]);//���� ó���� �ƴϸ� �������� �� ����
            }
            
            DefDis();

        }
        else if(moveChace > 0)
        {
            
          moveDis();
            
        }
        else
        {
            Debug.Log("���� �ֻ��� ����");
        }
    }
        

    void attackDis()
    {
        attChace--;
        int maxAtt = 0;
        GameObject dicAtt = StartUnits[0];
        UnitBase unit;
        foreach (GameObject attUnit in dirUnits)//���⼭ ���ݼ����� ����
        {
           unit = attUnit.GetComponent<Unit>().GetUnit();
            if (maxAtt < unit.curAD)
            {
                
                maxAtt = unit.curAD;
                dicAtt = attUnit;               
                
            }           
            
        }
        unit = dicAtt.GetComponent<Unit>().GetUnit();
        Debug.Log("���ݼ��� : " + unit.Name);
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
        foreach (GameObject defUnit in dirUnits)//���⼭ ���ݼ����� ����
        {
            unit = defUnit.GetComponent<Unit>().GetUnit();
            if (maxDef < unit.curDF)
            {

                maxDef = unit.curDF;
                dicDef = defUnit;

            }

        }
        unit = dicDef.GetComponent<Unit>().GetUnit();
        Debug.Log("���� : " + unit.Name);
        Units.Remove(dicDef);
        dirUnits.Clear();

        EnemyAi();
    }
    void moveDis()
    {
        moveChace--;
        UnitBase unit = Units[0].GetComponent<Unit>().GetUnit();
        Debug.Log("�̵����� : " + unit.Name);
        Units.Remove(Units[0]);
        EnemyAi();

    }
    

}
