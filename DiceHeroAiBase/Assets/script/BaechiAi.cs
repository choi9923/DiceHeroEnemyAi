using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
   
public class BaechiAi : MonoBehaviour
{
 /*
    public GameObject[] proUnits;
    public GameObject[] behUnits;

    public List<GameObject> frontUnits = new List<GameObject>();
    public List<GameObject> backUnits = new List<GameObject>();
    int dir1 = 0;


    private void Start()
    {
        StartAi(proUnits, behUnits);
    }

    void StartAi(GameObject[] proUnits, GameObject[] behUnits)
    {
        foreach(GameObject unit in proUnits)
        {
            frontUnits.Add(unit);
        }
        foreach (GameObject unit in behUnits)
        {
            backUnits.Add(unit);
        }
        ArrangeAi();
    }

    void ArrangeAi()
    {
        

        if(frontUnits.Any())
        {
            frontBaechi();
        }
        if (backUnits.Any())
        {
            behindBaechi();
        }
        else
        {
            Debug.Log("더는 유닛이 없다.");
        }


    }

    void frontBaechi()
    {

        foreach(GameObject unit in frontUnits)
        {
            dir1 = Random.Range(0, 2);
            if(dir1 == 0)
            {
                dir1 = Random.Range(0, 2);
                if (dir1 == 0)
                {
                    Debug.Log("유닛: " + unit.GetComponent<UnitState>().name + "A1에 배치한다.");
                    

                }
                else 
                {
                    Debug.Log("유닛: " + unit.GetComponent<UnitState>().name + "A2에 배치한다.");
                    
                }
            }
            else
            {
                dir1 = Random.Range(0, 2);
                if (dir1 == 0)
                {
                    Debug.Log("유닛: " + unit.GetComponent<UnitState>().name + "A3에 배치한다.");                    
                }
                else
                {
                    Debug.Log("유닛: " + unit.GetComponent<UnitState>().name + "A4에 배치한다.");
                }
            }

        }
        frontUnits.Clear();
        ArrangeAi();
    }
    void behindBaechi()
    {
        foreach (GameObject unit in backUnits)
        {
            dir1 = Random.Range(0, 2);
            if (dir1 == 0)
            {
                dir1 = Random.Range(0, 2);
                if (dir1 == 0)
                {
                    Debug.Log("유닛: " + unit.GetComponent<UnitState>().name + "B1에 배치한다.");

                }
                else
                {
                    Debug.Log("유닛: " + unit.GetComponent<UnitState>().name + "B2에 배치한다.");

                }
            }
            else
            {
                dir1 = Random.Range(0, 2);
                if (dir1 == 0)
                {
                    Debug.Log("유닛: " + unit.GetComponent<UnitState>().name + "B3에 배치한다.");

                }
                else
                {
                    Debug.Log("유닛: " + unit.GetComponent<UnitState>().name + "B4에 배치한다.");
                
                }
                frontUnits.Clear();
            }
        }
    }

    */
}
