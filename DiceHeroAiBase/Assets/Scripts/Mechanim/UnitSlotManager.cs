using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSlotManager : MonoBehaviour
{
    GameManager gameManager;
    Player player;
    BattleManager battleManager;

    int? unitNum;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);

        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        player = gameManager.player;
        battleManager = FindObjectOfType<BattleManager>().GetComponent<BattleManager>();
        battleManager.battleStartEvent.AddListener(()=>gameObject.SetActive(false));
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pick(int i)
    {
        unitNum = i;
    }
    public void RemoveHandle()
    {
        unitNum = null;
    }

    public void SetUnit(Transform transform)
    {
        battleManager.playerUnitList[(int)unitNum].transform.position = transform.position;
        unitNum = null;
    }

    public int GetUnitNum()
    {
        return (int)unitNum;
    }
}
