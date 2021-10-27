using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    GameManager gameManager;
    UnitManager unitManager;
    public Player player;

    public GameObject Stage;

    public GameObject playerSide;
    public GameObject enemySide;

    public GameObject[,] grid = new GameObject[4, 4];

    public Button[] playerGridButton = new Button[8];
    public Button battleStartButton;

    public List<Unit> playerUnitList = new List<Unit>();
    public List<UnitBase> advance = new List<UnitBase>(); //선공
    public List<UnitBase> afterGlow = new List<UnitBase>(); //후공

    public UnityEvent battleStartEvent;

    public UnityEvent turnEndEvent;


    void Start()
    {
        try
        {
            unitManager = GetComponent<UnitManager>();
            gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
            player = gameManager.player;
        }
        catch
        {
            Debug.Log("게임 매니저가 존재하지 않음");
        }

        int z = 0;
        for (int y = 0; y< 2; y++)
        {
            for(int x=0; x<4;x++)
            {
                grid[x,y] = playerSide.transform.GetChild(z).gameObject;
                z++;
            }
        }

        z = 0;
        for (int y = 2; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                grid[x, y] = enemySide.transform.GetChild(z).gameObject;
                z++;
            }
        }

        battleStartButton.onClick.AddListener(() => BattleStart());
    }

    public void BattleStart()
    {
        if (UnitReadyCheck())
        {
            battleStartEvent.Invoke();
            battleStartButton.gameObject.SetActive(false);
        }
        
    }

    public void TurnEnd()
    {
        
    }
    
    private bool UnitReadyCheck()
    {
        for (int i = 0; i < playerUnitList.Count; i++)
        {
            if (playerUnitList[i].transform.position.x == 0)
            {
                Debug.Log("유닛을 모두 할당해 주세요");
                return false;
            }
        }
        return true;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
    }

}
