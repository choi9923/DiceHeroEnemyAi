using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public GameObject openobj;
    public GameObject closeobj;

    public VideoPlayer openVideo;
    public VideoPlayer closeVideo;

    public List<GameObject> charImage;
    public GameObject selectWindow;
    public CamMoveInOrder camController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartPamplet()
    {
        openobj.SetActive(true);
        StartCoroutine(eraseChar(0f));
        closeobj.SetActive(false);
        openVideo.Play();
        StartCoroutine(showChar(3f));
        StartCoroutine(moveCam(3f));
    }
    public void EndPamplet()
    {
        openobj.SetActive(false);
        StartCoroutine(eraseChar(1.25f));
        StartCoroutine(moveCam(1.25f));
        closeobj.SetActive(true);
        closeVideo.Play();
        closeVideo.SetDirectAudioMute(0, true); //mute
    }
    IEnumerator showChar(float time)
    {
        for (int i = 0; i < charImage.Count; i++)
        {
            Vector3 pos = charImage[i].transform.position;
            charImage[i].transform.position = new Vector3(pos.x + 0.2f, pos.y + 0.2f, pos.z);
        }
        yield return new WaitForSeconds(time);
        for (int i = 0; i < charImage.Count; i++)
            charImage[i].SetActive(true);
        selectWindow.SetActive(true);
    }
    IEnumerator eraseChar(float time)
    {
        for (int i = 0; i < charImage.Count; i++)
        {
            Vector3 pos = charImage[i].transform.position;
            charImage[i].transform.position = new Vector3(pos.x - 0.2f, pos.y - 0.2f, pos.z);
        }
        yield return new WaitForSeconds(time);
        for (int i = 0; i < charImage.Count; i++)
            charImage[i].SetActive(false);
        selectWindow.SetActive(false);
    }
    IEnumerator moveCam(float time)
    {
        yield return new WaitForSeconds(time);
        camController.moveCamera();
    }
}
