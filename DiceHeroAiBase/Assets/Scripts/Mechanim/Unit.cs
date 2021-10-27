using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 유닛의 기본 클래스입니다. 유닛 오브젝트에 컴포넌트로 존재합니다.
/// </summary>
[RequireComponent(typeof(UnitAnimationController))]
public class Unit : MonoBehaviour
{

    [SerializeField]
    UnitBase myunit;

    BattleManager battleManager;
    UnitAnimationController animator;
    //방어 체크 용도의 함수입니다. 방어 시 true로 전환되며 피해를 받으면 false로 전환됩니다.
    bool isDefense;

    void Start()
    {
        try
        {
            battleManager = FindObjectOfType<BattleManager>().GetComponent<BattleManager>();
        }
        catch
        {
            Debug.Log("battleManager를 찾지 못하였습니다. ChangeGrid 함수 기능이 정상적으로 작동하지 않을 가능성이 있습니다.");
        }

        try
        {
            animator = GetComponent<UnitAnimationController>();
        }
        catch
        {
            Debug.Log("UnitAnimationController를 찾지 못하였습니다. Attack, Dead 함수 기능이 정상적으로 작동하지 않을 가능성이 있습니다.");
        }
    }

    /// <summary>
    /// Unit의 myunit을 세팅합니다.
    /// </summary>
    /// <param name="unit"></param>
    public void SetUnit(UnitBase unit)
    {
        myunit = unit;
    }

    /// <summary>
    /// 이 Unit이 가진 myunit을 반환합니다.
    /// </summary>
    /// <returns></returns>
    public UnitBase GetUnit()
    {
        return myunit;
    }

    /// <summary>
    /// 유닛의 위치를 battleManager의 grid[z,x]에 해당하는 포지션으로 변경합니다.
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
    /// 공격 함수입니다. target에 해당하는 대상을 공격합니다.
    /// </summary>
    /// <param name="target"></param>
    public void Attack(Unit target)
    {
        animator.Attack();
        target.TakeDamage(myunit.curAD);
    }

    /// <summary>
    /// 방어 함수입니다. 방어를 실행합니다.
    /// </summary>
    public void Defense()
    {
        isDefense = true;
    }

    /// <summary>
    /// 피격 함수입니다. 피격 시 호출되며 damage만큼의 피해를 받습니다.
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
    /// 사망 함수입니다. myunit의 curHP가 0가 되면 호출됩니다.
    /// </summary>
    private void Dead()
    {
        animator.Dead();
    }


}
