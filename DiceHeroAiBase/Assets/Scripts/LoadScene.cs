//씬을 호출할 때 사용하는 클래스입니다. SceneManager 프리팹에 사용됩니다.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    /// <summary>
    /// name에 해당하는 이름을 가진 Scene을 호출합니다.
    /// </summary>
    /// <param name="name"></param>
    public void SceneLoad(string name)
    {
        try
        {
            SceneManager.LoadScene(name);
        }
        catch
        {
            Debug.Log("해당 이름을 가진 Scene을 찾을 수 없습니다.");
        }
    }

    /// <summary>
    /// num에 해당하는 번호의 Scene을 호출합니다.
    /// </summary>
    /// <param name="num"></param>
    public void SceneLoad(int num)
    {
        try
        {
            SceneManager.LoadScene(num);
        }
        catch
        {
            Debug.Log("해당 번호를 가진 Scene을 찾을 수 없습니다.");
        }
        
    }

}
