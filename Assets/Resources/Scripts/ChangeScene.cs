using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string levelChange;

    public void GoToScene()
    {
        SceneManager.LoadScene(levelChange, LoadSceneMode.Single);
    }
}
