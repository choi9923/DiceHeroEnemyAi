using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckingChanging : MonoBehaviour
{
    public Text target;
    public Text id;
    public UnitMaterialChange manager;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pressed()
    {
        manager.changeStateMaterial(int.Parse(target.text), int.Parse(id.text));
    }
    public void Attackpressed()
    {
        manager.Attack(int.Parse(target.text));
    }
    public void Deadpressed()
    {
        manager.Dead(int.Parse(target.text));
    }
   
}

