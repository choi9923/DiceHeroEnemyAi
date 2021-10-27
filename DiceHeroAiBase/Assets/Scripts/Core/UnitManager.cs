using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{

    GameManager gameManager;
    BattleManager battleManager;
    Player player;
    public GameObject unitPrefab;

    // Start is called before the first frame update
    void Start()
    {
        battleManager = GetComponent<BattleManager>();
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        player = gameManager.player;

        for(int i =0; i < player.myUnits.Length; i++)
        {
            if (player.myUnits[i].ID == 0)
            {
               
            }
            else
            {
                InstantUnit(player.myUnits[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantUnit(UnitBase unitBase)
    {
        GameObject unit = Instantiate(unitPrefab, transform.position, Quaternion.identity);
        unit.GetComponent<Unit>().SetUnit(unitBase);
        battleManager.playerUnitList.Add(unit.GetComponent<Unit>());

    }
}
