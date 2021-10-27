using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBAni : MonoBehaviour
{
    public Animator[] animaotrs;
    public int number;
    public bool downEnd=false;
    public float time = 0;
    public GameObject gm;
    public float speed=5.0f;
    public int endani = 0;
    public bool endCotton;
    // Start is called before the first frame update
    void Start()
    {
        animaotrs = gm.GetComponentsInChildren<Animator>();
        for(int i = 0; i<animaotrs.Length; i++)
        {
            animaotrs[i].gameObject.SetActive(false);
        }
    }
    public void Moving()
    {
        animaotrs[number].gameObject.SetActive(true);
        
        number++;
    }
    // Update is called once per frame
    void Update()
    {

        if (downEnd == true)
        {
            time += Time.deltaTime;
        }
        else if(endCotton==true)
        {
            GateMove();
        }
        if (time > 1.0f&&number<4)
        {
            Moving();
            time = 0;
        }
    }
    public void StartOp()
    {
        endCotton = true;
    }
    public void GateMove()
    {
        
        transform.position = new Vector3(transform.position.x, transform.position.y -speed * Time.deltaTime,transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            downEnd = true;
            endCotton = false;
            
        }
    }
    
   
}
