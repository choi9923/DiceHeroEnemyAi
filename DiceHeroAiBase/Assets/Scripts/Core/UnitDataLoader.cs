//���� �����͸� �о�� ���� �����ͺ��̽��� �����մϴ�.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System;

public class UnitDataLoader : MonoBehaviour
{

    public string fileName = "/Resources/UnitDatas.json";

    private GameManager gameManager;
    public UnitDataBase unitDataBase;



    void Start()
    {
        gameManager = GetComponent<GameManager>();
        unitDataBase = gameManager.unitDataBase;
        Load();
    }

 
    /// <summary>
    /// ���Ͽ��� ���� �����͸� �ε��մϴ�.
    /// </summary>
    public void Load()
    {

        string JsonStr = File.ReadAllText(Application.dataPath + fileName);
        JsonData ad = JsonMapper.ToObject(JsonStr);
        for (int i = 1; i < ad.Count; i++)
        {
            RankType rankt = (RankType)System.Enum.Parse(typeof(RankType), ad[i]["rankType"].ToString());

            unitDataBase.Addunit((int)ad[i]["ID"], 
                new UnitBase(
                (int)ad[i]["ID"], 
                ad[i]["Name"].ToString(), 
                (int)ad[i]["HP"], 
                (int)ad[i]["AD"], 
                (int)ad[i]["DF"], 
                rankt)
                );
            
        }

    }
}
