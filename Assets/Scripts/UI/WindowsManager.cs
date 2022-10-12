using UnityEngine;
using UnityEngine.SceneManagement;

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
