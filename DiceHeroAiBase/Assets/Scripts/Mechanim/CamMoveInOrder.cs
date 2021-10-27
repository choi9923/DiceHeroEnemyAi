using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoveInOrder : MonoBehaviour
{
    public GameObject cam;
    public List<Vector3> movePos; //move order. It can just move camera to reserved location (ex: movePos[3])
    public int camPosNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveCamera()
    {
        cam.transform.position = movePos[camPosNum++];
        if (camPosNum == movePos.Count) camPosNum = 0;
    }
}
