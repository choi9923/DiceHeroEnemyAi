using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BeamProjector : MonoBehaviour
{
    public GameObject theLight;
    public GameObject screen;
    public VideoPlayer storyVideo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Show()
    {
        StartCoroutine(showing());
    }
    IEnumerator showing()
    {
        screen.SetActive(true);
        storyVideo.Play();
        theLight.SetActive(true);
        yield return new WaitForSeconds((float)storyVideo.length - 0.4f);
        theLight.SetActive(false);
        yield return new WaitForSeconds(1f);
        screen.SetActive(false);
    }
}
