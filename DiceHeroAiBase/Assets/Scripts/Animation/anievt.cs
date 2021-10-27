using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anievt : MonoBehaviour
{
    public OBAni ani;
    
    // Start is called before the first frame update
    void Start()
    {
        ani = FindObjectOfType<OBAni>();
    }
    public void aniEnd()
    {
        Debug.Log("성공");
        ani.animaotrs[ani.endani].gameObject.SetActive(false);
        ani.endani++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
