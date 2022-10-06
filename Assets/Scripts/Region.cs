using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Region : MonoBehaviour
{
    [SerializeField] private bool belongs;

    private void Start()
    {
        if (belongs)
        {
            GetComponent<Image>().color = new Color32(230, 100, 0, 225);
        }
    }

    public void OnMouseDown()
    {
        Debug.Log("sdad");
    }
}
