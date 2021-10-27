using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialAnimation : MonoBehaviour
{
    public MeshRenderer target;
    public List<Material> materials;
    public List<float> changeTimes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartAnimation()
    {
        StartCoroutine(changeMaterial());
    }

    IEnumerator changeMaterial()
    {
        for (int anicnt = 0; anicnt < materials.Count; anicnt++)
        {
            target.material = materials[anicnt];
            yield return new WaitForSeconds(changeTimes[anicnt]);
        }
    }
}
