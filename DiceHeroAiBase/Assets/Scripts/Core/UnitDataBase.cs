//��� ������ ������ ����� �����ͺ��̽��Դϴ�.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitDataBase : MonoBehaviour
{
    public Dictionary<int, UnitBase> unitData = new Dictionary<int, UnitBase>();

    public void Addunit(int id, UnitBase unit)
    {
        unitData.Add(id, unit);
        Debug.Log(unit.Name);
    }
}
