//게임 매니저입니다. 플레이어, 유닛 데이터베이스를 가지고 있습니다.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player),typeof(UnitDataBase),typeof(UnitDataLoader))]
public class GameManager : MonoBehaviour
{
    public Player player;
    public UnitDataBase unitDataBase;
    public LoadScene loadScene;

    void Awake()
    {
        player = GetComponent<Player>();
        unitDataBase = GetComponent<UnitDataBase>();
        loadScene = GetComponent<LoadScene>();
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {

    }
}
