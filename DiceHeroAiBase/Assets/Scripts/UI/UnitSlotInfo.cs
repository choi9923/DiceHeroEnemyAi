using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitSlotInfo : MonoBehaviour
{
    public GameObject infoWindow;
    public GameObject selectSlot;
    public Text passiveInfo;
    public Text unitInfo;
    public int id;

    public void SetInfoToKnightKim()
    {
        Open();
        id = 1;
        passiveInfo.text = "[공격 후]: 피격 대상이 방어태세가 아닌 경우 3만큼 피해를 더 줍니다.";
        unitInfo.text = "김기사는 자신이 전사인줄 압니다.";
    }

    public void SetInfoToTeropin()
    {
        Open();
        id = 2;
        passiveInfo.text = "[방어 중]: 전방의 적이 자신을 지목하도록 합니다.(도발)";
        unitInfo.text = "테로핀은 마을에서 사랑받는 친구입니다.";
    }

    public void SetInfoToMrEgg()
    {
        Open();
        id = 3;
        passiveInfo.text = "[이동 후]: 이동한 횟수x2 만큼 공격력 증가.공격 시 스택 초기화";
        unitInfo.text = "마술대회에서 자신을 계란으로 바꾸어 1등을 수상했으나 본모습으로 돌아오질 못했습니다.";
    }

    public void SetInfoToAndel()
    {
        Open();
        id = 4;
        passiveInfo.text = "[공격 후]: 입힌 피해량 만큼 아군 전체 회복";
        unitInfo.text = "의학적 지식은 없으나 금지된 서적으로 의사가 되었습니다 .";
    }

    public void SetInfoToPython()
    {
        Open();
        id = 5;
        passiveInfo.text = "[공격 후]: 다음 턴에 대상은 파이썬을 공격할 수 없습니다.(공포)";
        unitInfo.text = "자신이 흉한걸 알기에 이걸 무기로 사용합니다.";
    }

    public void SetInfoToZombie()
    {
        Open();
        id = 6;
        passiveInfo.text = "[방어 중]: 사망 시 체력의 50%를 회복하고 부활합니다.";
        unitInfo.text = "던전에 들어왔다가 무참히 당해버린 용병입니다...";
    }

    public void SetInfoToSkeleton()
    {
        Open();
        id = 7;
        passiveInfo.text = "[이동 후]: 적에게 공격력의 50% 만큼의 피해를 입힙니다.";
        unitInfo.text = "좀비였는데 늙어버렸네요.";
    }

    public void SetInfoToGolem()
    {
        Open();
        id = 8;
        passiveInfo.text = "[방어 중]: 같은 라인의 아군이 피해량을 25% 덜 받습니다.";
        unitInfo.text = "철블럭 4개와 호박 하나면 만들 수 있는 귀여운 골렘입니다.";
    }

    public void SetInfoToMosquito()
    {
        Open();
        id = 9;
        passiveInfo.text = "[공격 후]: 피해량의 50%만큼 체력을 회복합니다.";
        unitInfo.text = "징그럽게도 큰 모기라 피도 많이 빱니다.";
    }

    public void SetInfoToDartGoblin()
    {
        Open();
        id = 10;
        passiveInfo.text = "[공격 중]: 대상의 공격력만큼 공격력이 일시적으로 증가합니다.";
        unitInfo.text = "빨대제조업을 맡고 있습니다.";
    }

    public void SetInfoToFFrog()
    {
        Open();
        id = 11;
        passiveInfo.text = "[이동 중]: 후방라인과 전방라인을 오갈 수 있습니다.";
        unitInfo.text = "별미입니다.";
    }

    public void Open()
    {
        infoWindow.SetActive(true);
    }
    public void Close()
    {
        infoWindow.SetActive(false);
    }
    public void Okay()
    {
        Close();
        selectSlot.SetActive(true);
    }
}