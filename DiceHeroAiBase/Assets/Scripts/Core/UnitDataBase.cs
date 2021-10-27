//모든 유닛의 정보가 저장된 데이터베이스입니다.
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
