//���� ȣ���� �� ����ϴ� Ŭ�����Դϴ�. SceneManager �����տ� ���˴ϴ�.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    /// <summary>
    /// name�� �ش��ϴ� �̸��� ���� Scene�� ȣ���մϴ�.
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
            Debug.Log("�ش� �̸��� ���� Scene�� ã�� �� �����ϴ�.");
        }
    }

    /// <summary>
    /// num�� �ش��ϴ� ��ȣ�� Scene�� ȣ���մϴ�.
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
            Debug.Log("�ش� ��ȣ�� ���� Scene�� ã�� �� �����ϴ�.");
        }
        
    }

}
