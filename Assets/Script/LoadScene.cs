using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Stage1");

    }
    public void ChangeSceneMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

}
