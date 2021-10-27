using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    BattleManager battleManager;

    // Start is called before the first frame update
    void Start()
    {
        battleManager = GetComponent<BattleManager>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Act(Unit unit, DiceType diceType)
    {
        switch (diceType)
        {
            case DiceType.attack:
                Attack(unit);
                break;
            case DiceType.defense:
                Defense(unit);
                break;

        }
    }

    private void Attack(Unit unit)
    {
        
    }

    private void Defense(Unit unit)
    {

    }

    private void Move(Unit unit, int x, int z)
    {
        
    }
}
