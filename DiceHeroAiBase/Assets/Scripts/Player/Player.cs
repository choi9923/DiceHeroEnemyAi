//플레이어입니다.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    GameManager gameManager;
    public UnitBase[] myUnits = new UnitBase[4];
    public UnityEvent unitFull;

    void Start()
    {
        gameManager = GetComponent<GameManager>();

    }

    void Update()
    {

    }

    /// <summary>
    /// addUnit에 해당하는 유닛을 추가합니다.
    /// </summary>
    /// <param name="addUnit"></param>
    public void AddCharacter(UnitBase addUnit)
    {
        if (!UnitsFullChenk())
        {
            for (int i = 0; i < myUnits.Length; i++)
            {
                if (myUnits[i].ID.Equals(0))
                {
                    myUnits[i] = addUnit;
                    break;
                }
                else
                {

                }
            }
        }
        else
        {
            unitFull.Invoke();
        }

    }

    /// <summary>
    /// 해당 id를 가진 유닛을 추가합니다.
    /// </summary>
    /// <param name="id"></param>
    public void AddCharacter(int id)
    {
        if (!UnitsFullChenk())
        {
            for (int i = 0; i < myUnits.Length; i++)
            {
                if (myUnits[i].ID.Equals(0))
                {
                    try
                    {
                        myUnits[i] = gameManager.unitDataBase.unitData[id];
                        break;
                    }
                    catch
                    {
                        Debug.Log("기록되지 않은 유닛입니다.");
                    }
                    
                }
                else
                {
                    
                }
            }
        }
        else
        {
            unitFull.Invoke();
        }

    }

    /// <summary>
    /// 유닛이 가득 차있는지 체크합니다. 유닛이 가득 차있다면 true, 그렇지 않으면 false를 반환합니다.
    /// </summary>
    /// <returns></returns>
    public bool UnitsFullChenk()
    {

        for (int i = 0; i < myUnits.Length; i++)
        {
            if (myUnits[i].ID.Equals(0))
            {
                return false;
            }

        }

        return true;

    }
}
