using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSlot : MonoBehaviour
{
    public GameObject selectSlot;
    public GameObject info;
    public List<int> unitId;
    public List<MeshRenderer> unitSlots;
    public List<Material> unitFaces;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            unitId[i] = 0;
        }
    }

    public void FirstSlot()
    {
        int id = info.GetComponent<UnitSlotInfo>().id;
        if (UnitOverlapCheck(id))
        {
            unitSlots[0].material = unitFaces[id];
            unitId[0] = id;
        }
        selectSlot.SetActive(false);
    }
    public void SecondSlot()
    {
        int id = info.GetComponent<UnitSlotInfo>().id;
        if (UnitOverlapCheck(id))
        {
            unitSlots[1].material = unitFaces[id];
            unitId[1] = id;
        }
        selectSlot.SetActive(false);
    }
    public void ThirdSlot()
    {
        int id = info.GetComponent<UnitSlotInfo>().id;
        if (UnitOverlapCheck(id))
        {
            unitSlots[2].material = unitFaces[id];
            unitId[2] = id;
        }
        selectSlot.SetActive(false);
    }
    public void ForuthSlot()
    {
        int id = info.GetComponent<UnitSlotInfo>().id;
        if (UnitOverlapCheck(id))
        {
            unitSlots[3].material = unitFaces[id];
            unitId[3] = id;
        }
        selectSlot.SetActive(false);
    }

    public void ClearAllSlot()
    {
        for (int i = 0; i < 4; i++)
        {
            unitSlots[i].material = unitFaces[0]; //question mark : defined
            unitId[i] = 0;
        }
        selectSlot.SetActive(false);
    }

    bool UnitOverlapCheck(int id)
    {
        for (int i = 0; i < 4; i++)
        {
            if (unitId[i] == id)
                return false;
        }
        return true;
    }
}
