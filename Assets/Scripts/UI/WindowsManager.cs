using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WindowsManager : MonoBehaviour
{
    [SerializeField] public GameObject regionProp;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void CloseRegionProp()
    {
        regionProp.SetActive(false);
    }
}
