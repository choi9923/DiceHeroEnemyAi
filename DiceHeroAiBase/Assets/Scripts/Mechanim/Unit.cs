using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ �⺻ Ŭ�����Դϴ�. ���� ������Ʈ�� ������Ʈ�� �����մϴ�.
/// </summary>
[RequireComponent(typeof(UnitAnimationController))]
public class Unit : MonoBehaviour
{

    [SerializeField]
    UnitBase myunit;

    BattleManager battleManager;
    UnitAnimationController animator;
    //��� üũ �뵵�� �Լ��Դϴ�. ��� �� true�� ��ȯ�Ǹ� ���ظ� ������ false�� ��ȯ�˴ϴ�.
    bool isDefense;

    void Start()
    {
        try
        {
            battleManager = FindObjectOfType<BattleManager>().GetComponent<BattleManager>();
        }
        catch
        {
            Debug.Log("battleManager�� ã�� ���Ͽ����ϴ�. ChangeGrid �Լ� ����� ���������� �۵����� ���� ���ɼ��� �ֽ��ϴ�.");
        }

        try
        {
            animator = GetComponent<UnitAnimationController>();
        }
        catch
        {
            Debug.Log("UnitAnimationController�� ã�� ���Ͽ����ϴ�. Attack, Dead �Լ� ����� ���������� �۵����� ���� ���ɼ��� �ֽ��ϴ�.");
        }
    }

    /// <summary>
    /// Unit�� myunit�� �����մϴ�.
    /// </summary>
    /// <param name="unit"></param>
    public void SetUnit(UnitBase unit)
    {
        myunit = unit;
    }

    /// <summary>
    /// �� Unit�� ���� myunit�� ��ȯ�մϴ�.
    /// </summary>
    /// <returns></returns>
    public UnitBase GetUnit()
    {
        return myunit;
    }

    /// <summary>
    /// ������ ��ġ�� battleManager�� grid[z,x]�� �ش��ϴ� ���������� �����մϴ�.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="z"></param>
    public void ChangeGrid(int x, int z)
    {
        for(int i =0; i < battleManager.playerUnitList.Count; i++)
        {
            if(battleManager.grid[z,x].transform.position == battleManager.playerUnitList[i].transform.position)
            {

            }
        }
        transform.position = battleManager.grid[z, x].transform.position;
    }

    /// <summary>
    /// ���� �Լ��Դϴ�. target�� �ش��ϴ� ����� �����մϴ�.
    /// </summary>
    /// <param name="target"></param>
    public void Attack(Unit target)
    {
        animator.Attack();
        target.TakeDamage(myunit.curAD);
    }

    /// <summary>
    /// ��� �Լ��Դϴ�. �� �����մϴ�.
    /// </summary>
    public void Defense()
    {
        isDefense = true;
    }

    /// <summary>
    /// �ǰ� �Լ��Դϴ�. �ǰ� �� ȣ��Ǹ� damage��ŭ�� ���ظ� �޽��ϴ�.
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        if (isDefense)
        {
            damage = Mathf.Clamp(damage - myunit.curDF, 0, damage);
            isDefense = false;
        }
        else
        {
            myunit.curHP = Mathf.Clamp(myunit.curHP - damage, 0, myunit.curHP);
            if (myunit.curHP == 0)
            {
                Dead();
            }
        }
        
    }

    /// <summary>
    /// ��� �Լ��Դϴ�. myunit�� curHP�� 0�� �Ǹ� ȣ��˴ϴ�.
    /// </summary>
    private void Dead()
    {
        animator.Dead();
    }


}
