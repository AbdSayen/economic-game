using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Region : MonoBehaviour
{
	public float money;


    [SerializeField] private bool belongs;
    public GameObject regionPropGO;
    public RegionProp regionPropScript;
    public string regionName;

    private void Start()
    {
        if (belongs)
        {
            GetComponent<Image>().color = new Color32(230, 100, 0, 225);
        }
        else
        {
            //GetComponent<Image>().color = new Color32(230, 100, 0, 225);
        }
    }

    public void BeAttacked()
    {
        GetComponent<Image>().color = new Color32(100, 100, 0, 225);
    }

    public void OnMouseUp()
    {
        regionPropGO.SetActive(true);
        if(belongs)
        {
        	regionPropScript.regionNameText.GetComponent<Text>().text = $"It`s your region {regionName}";
        	regionPropScript.attackBtn.SetActive(false);
        } else
        {	
        	regionPropScript.regionNameText.GetComponent<Text>().text = $"Enemy`s region {regionName}";
        	regionPropScript.attackBtn.SetActive(true);
        }
    }
}
