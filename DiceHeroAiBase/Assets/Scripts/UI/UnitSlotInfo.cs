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
        passiveInfo.text = "[���� ��]: �ǰ� ����� ����¼��� �ƴ� ��� 3��ŭ ���ظ� �� �ݴϴ�.";
        unitInfo.text = "����� �ڽ��� �������� �дϴ�.";
    }

    public void SetInfoToTeropin()
    {
        Open();
        id = 2;
        passiveInfo.text = "[��� ��]: ������ ���� �ڽ��� �����ϵ��� �մϴ�.(����)";
        unitInfo.text = "�׷����� �������� ����޴� ģ���Դϴ�.";
    }

    public void SetInfoToMrEgg()
    {
        Open();
        id = 3;
        passiveInfo.text = "[�̵� ��]: �̵��� Ƚ��x2 ��ŭ ���ݷ� ����.���� �� ���� �ʱ�ȭ";
        unitInfo.text = "������ȸ���� �ڽ��� ������� �ٲپ� 1���� ���������� ��������� ���ƿ��� ���߽��ϴ�.";
    }

    public void SetInfoToAndel()
    {
        Open();
        id = 4;
        passiveInfo.text = "[���� ��]: ���� ���ط� ��ŭ �Ʊ� ��ü ȸ��";
        unitInfo.text = "������ ������ ������ ������ �������� �ǻ簡 �Ǿ����ϴ� .";
    }

    public void SetInfoToPython()
    {
        Open();
        id = 5;
        passiveInfo.text = "[���� ��]: ���� �Ͽ� ����� ���̽��� ������ �� �����ϴ�.(����)";
        unitInfo.text = "�ڽ��� ���Ѱ� �˱⿡ �̰� ����� ����մϴ�.";
    }

    public void SetInfoToZombie()
    {
        Open();
        id = 6;
        passiveInfo.text = "[��� ��]: ��� �� ü���� 50%�� ȸ���ϰ� ��Ȱ�մϴ�.";
        unitInfo.text = "������ ���Դٰ� ������ ���ع��� �뺴�Դϴ�...";
    }

    public void SetInfoToSkeleton()
    {
        Open();
        id = 7;
        passiveInfo.text = "[�̵� ��]: ������ ���ݷ��� 50% ��ŭ�� ���ظ� �����ϴ�.";
        unitInfo.text = "���񿴴µ� �ľ���ȳ׿�.";
    }

    public void SetInfoToGolem()
    {
        Open();
        id = 8;
        passiveInfo.text = "[��� ��]: ���� ������ �Ʊ��� ���ط��� 25% �� �޽��ϴ�.";
        unitInfo.text = "ö�� 4���� ȣ�� �ϳ��� ���� �� �ִ� �Ϳ��� ���Դϴ�.";
    }

    public void SetInfoToMosquito()
    {
        Open();
        id = 9;
        passiveInfo.text = "[���� ��]: ���ط��� 50%��ŭ ü���� ȸ���մϴ�.";
        unitInfo.text = "¡�׷��Ե� ū ���� �ǵ� ���� ���ϴ�.";
    }

    public void SetInfoToDartGoblin()
    {
        Open();
        id = 10;
        passiveInfo.text = "[���� ��]: ����� ���ݷ¸�ŭ ���ݷ��� �Ͻ������� �����մϴ�.";
        unitInfo.text = "������������ �ð� �ֽ��ϴ�.";
    }

    public void SetInfoToFFrog()
    {
        Open();
        id = 11;
        passiveInfo.text = "[�̵� ��]: �Ĺ���ΰ� ��������� ���� �� �ֽ��ϴ�.";
        unitInfo.text = "�����Դϴ�.";
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