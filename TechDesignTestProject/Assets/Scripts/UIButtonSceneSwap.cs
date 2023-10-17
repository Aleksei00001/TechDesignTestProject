using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonSceneSwap : MonoBehaviour
{
    [SerializeField] private GameObject UIScenSwap;

    public void CloseUIScenSwap()
    {
        UIScenSwap.SetActive(false);
    }

    public void OpenScen(int ID)
    {
        SceneManager.LoadScene(ID);
    }
}
