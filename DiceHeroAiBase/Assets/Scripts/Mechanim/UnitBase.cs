using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RankType
{
    frontRank, //����
    backRank,  //�Ŀ�
    allRank //�ö���
}

public enum DiceType
{
    attack, //����
    defense, //���
    movement //�̵�
}

[System.Serializable]
public class UnitBase
{


    //���� ID
    public int ID;

    //���� �̸�
    public string Name;

    //ü��
    public int HP;
    public int curHP;

    //���ݷ�
    public int AD;
    public int curAD;

    //����
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
