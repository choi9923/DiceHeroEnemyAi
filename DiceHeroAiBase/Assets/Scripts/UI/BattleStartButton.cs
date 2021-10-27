using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BattleStartButton : MonoBehaviour
{
    
    BattleManager battleManager;
    Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        battleManager = FindObjectOfType<BattleManager>().GetComponent<BattleManager>();
        startButton = GetComponent<Button>();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
