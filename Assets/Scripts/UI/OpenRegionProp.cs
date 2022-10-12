using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRegionProp : MonoBehaviour
{
    [SerializeField] public GameObject regionProp;

    private void OnMouseUp()
    {
        regionProp.SetActive(true);
        gameObject.SetActive(false);
    }
}
