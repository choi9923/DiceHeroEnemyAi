//���� �Ŵ����Դϴ�. �÷��̾�, ���� �����ͺ��̽��� ������ �ֽ��ϴ�.
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
