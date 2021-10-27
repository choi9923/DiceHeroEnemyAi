using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RankType
{
    frontRank, //전열
    backRank,  //후열
    allRank //올라운더
}

public enum DiceType
{
    attack, //공격
    defense, //방어
    movement //이동
}

[System.Serializable]
public class UnitBase
{


    //유닛 ID
    public int ID;

    //유닛 이름
    public string Name;

    //체력
    public int HP;
    public int curHP;

    //공격력
    public int AD;
    public int curAD;

    //방어력
    public int DF;
    public int curDF;

    public RankType rankType;

    public DiceType diceType;


    public UnitBase(int _id, string _name, int _hp, int _ad, int _df, RankType _rankType)
    {
        ID = _id;
        Name = _name;

        HP = _hp;

        AD = _ad;

        DF = _df;

        rankType = _rankType;
    }
}
