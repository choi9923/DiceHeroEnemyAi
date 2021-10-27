using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnitButton : MonoBehaviour
{
    GameManager gameManager;
    BattleManager battleManager;


    public Button[] UnitSlots = new Button[4];
    public UnitSlotManager unitSlotManager;

    private string unitImagePath = "Sprites/Units/";

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        battleManager = FindObjectOfType<BattleManager>().GetComponent<BattleManager>();
        unitSlotManager = GetComponent<UnitSlotManager>();

        UnitSlotDisplay(false);
        battleManager.battleStartEvent.AddListener(()=>UnitSlotDisplay(true));

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void UnitSlotDisplay(bool value)
    {
        gameObject.SetActive(value);
    }

    public void UnitSlotLoad()
    {
        for (int i = 0; i < 4; i++)
        {
            UnitSlots[i] = transform.GetChild(i).gameObject.GetComponent<Button>();
        }

        for (int i = 0; i < 4; i++)
        {
            if (gameManager.player.myUnits[i].ID == 0)
            {

            }
            else
            {
                UnitSlots[i].GetComponent<Image>().sprite = Resources.Load<Sprite>(unitImagePath + gameManager.player.myUnits[i].ID.ToString());
                int temp = i;
                UnitSlots[temp].onClick.AddListener(() => SetHandleUnit(temp));
                Debug.Log(temp);
            }

        }

        for (int i = 0; i < battleManager.playerSide.transform.childCount; i++)
        {
            int temp = i;

            battleManager.playerSide.transform.GetChild(temp).GetChild(0).GetChild(0).GetComponent<Button>().onClick.AddListener
                (() => SettingUnit(battleManager.playerSide.transform.GetChild(temp).GetChild(0).transform));
        }
    }

    public void SetHandleUnit(int i)
    {

        unitSlotManager.Pick(i);
        UnitSlots[i].onClick.RemoveAllListeners();
        UnitSlots[i].GetComponent<Image>().sprite = null;
        UnitSlots[i].onClick.AddListener(()=> RemoveHandleUnit(i));

        for (int f = 0; f < 4; f++)
        {
            if (f == i)
            {

            }
            else
            {
                UnitSlots[f].interactable = false;
            }
        }

        if (battleManager.playerUnitList[unitSlotManager.GetUnitNum()].GetUnit().rankType == RankType.frontRank)
        {
            for (int temp = 4; temp < 8; temp++)
            {
                if (UnitOverlapCheck(temp))
                {

                }
                else
                {
                    battleManager.playerSide.transform.GetChild(temp).GetChild(0).gameObject.SetActive(true);
                }
               
            }
        }
        else if (battleManager.playerUnitList[unitSlotManager.GetUnitNum()].GetUnit().rankType == RankType.backRank)
        {
            for (int temp = 0; temp < 4; temp++)
            {
                battleManager.playerSide.transform.GetChild(temp).GetChild(0).gameObject.SetActive(true);
            }
        }
        else
        {
            for (int temp = 0; temp < battleManager.playerSide.transform.childCount; temp++)
            {
                battleManager.playerSide.transform.GetChild(temp).GetChild(0).gameObject.SetActive(true);
            }
        }


    }

    private void RemoveHandleUnit(int i)
    {
        UnitSlots[i].GetComponent<Image>().sprite = Resources.Load<Sprite>(unitImagePath + gameManager.player.myUnits[i].ID.ToString());
        unitSlotManager.RemoveHandle();

        for(int f =0; f<4; f++)
        {
            if(UnitSlots[f].interactable)
            {
                int temp = f;
                UnitSlots[temp].onClick.AddListener(() => SetHandleUnit(temp));
            }
            else
            {
                UnitSlots[f].interactable = true;
            }
        }

        for (int temp = 0; temp < battleManager.playerSide.transform.childCount; temp++)
        {
            battleManager.playerSide.transform.GetChild(temp).GetChild(0).gameObject.SetActive(false);
        }
    }

    private void SettingUnit(Transform transform)
    {
        unitSlotManager.SetUnit(transform);
        for (int temp = 0; temp < battleManager.playerSide.transform.childCount; temp++)
        {
            battleManager.playerSide.transform.GetChild(temp).GetChild(0).gameObject.SetActive(false);
        }

        for (int f = 0; f < 4; f++)
        {
            if (UnitSlots[f].interactable)
            {
                int temp = f;
                UnitSlots[temp].onClick.AddListener(() => SetHandleUnit(temp));
            }
            else
            {
                UnitSlots[f].interactable = true;
            }
        }
    }

    private bool UnitOverlapCheck(int i)
    {
        for(int temp = 0; temp < battleManager.playerUnitList.Count; temp++)
        {
            if (battleManager.playerSide.transform.GetChild(i).transform.position == battleManager.playerUnitList[temp].transform.position)
            {
                return true;
            }
        }

        return false;
    }



}
