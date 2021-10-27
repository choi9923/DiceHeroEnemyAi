using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnitSlot : MonoBehaviour
{
    GameManager gameManager;
    
    public Image[] UnitSlots = new Image[4];
    private string unitImagePath = "Sprites/Units/";

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();

       

        for(int i = 0; i < 4; i++)
        {
            UnitSlots[i] = transform.GetChild(i).gameObject.GetComponent<Image>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            UnitSlots[i].sprite = Resources.Load<Sprite>(unitImagePath + gameManager.player.myUnits[i].ID.ToString());
        }

        
    }


}
