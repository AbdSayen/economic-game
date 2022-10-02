using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowsManager : MonoBehaviour
{
    [SerializeField] public GameObject regionProp;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenRegionProp()
    {
        regionProp.SetActive(true);
    }
    public void CloseRegionProp()
    {
        regionProp.SetActive(false);
    }
}
