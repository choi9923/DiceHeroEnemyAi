//�÷��̾��Դϴ�.
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
    /// addUnit�� �ش��ϴ� ������ �߰��մϴ�.
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
    /// �ش� id�� ���� ������ �߰��մϴ�.
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
                        Debug.Log("��ϵ��� ���� �����Դϴ�.");
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
    /// ������ ���� ���ִ��� üũ�մϴ�. ������ ���� ���ִٸ� true, �׷��� ������ false�� ��ȯ�մϴ�.
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
