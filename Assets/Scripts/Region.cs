using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Region : MonoBehaviour
{
    static public Region region;

    public float money;
    public float earningsForStep;

    [HideInInspector] public float population = 1;
    [HideInInspector] public float taxesForEveryPerson = 1;
    [HideInInspector] public float happyScale = 1;
    [HideInInspector] public float lawAbiding = 1;
    [HideInInspector] public float averageIq = 1;

    [SerializeField] private bool belongs;
    [SerializeField] private WindowsManager windowsManager;

    public GameObject openRegionPropBtn;
    public RegionProp regionPropScript;
    public GameObject regionPropGO;
    public string regionName;

    private GameObject star;

    private void Start()
    {
        star = transform.GetChild(0).gameObject;

        AddColor();
        StartCoroutine(SaveData());
    }

    private void Update()
    {
        AddStar();
        CountEarningsForStep();
    }

    private void CountEarningsForStep()
    {
        earningsForStep = (population /** 0.65f*/) * taxesForEveryPerson;
        //if(lawAbiding > 0.5)
        //{
        //    earningsForStep *= lawAbiding + 1;
        //}
    }

    public void BeAttacked()
    {
        belongs = true;
        if (belongs) GetComponent<Image>().color = new Color32(230, 100, 0, 225);
        windowsManager.CloseRegionProp();
    }

    public void OnMouseUp()
    {
        if (!regionPropGO.active)
        {
            region = gameObject.GetComponent<Region>();
            openRegionPropBtn.SetActive(true);
            openRegionPropBtn.transform.GetChild(0).gameObject.GetComponent<Text>().text = regionName;
            //PlayerPrefs.SetInt();
            if (belongs)
            {
                regionPropScript.regionNameText.GetComponent<Text>().text = $"It`s your region \"{regionName}\"";
                regionPropScript.attackBtn.SetActive(false);
            }
            else
            {
                regionPropScript.regionNameText.GetComponent<Text>().text = $"Enemy`s region \"{regionName}\"";
                regionPropScript.attackBtn.SetActive(true);
            }
        }
    }

    private void AddStar()
    {
        if (belongs) star.SetActive(true);
    }

    private void AddColor()
    {
        if (belongs)
        {
            GetComponent<Image>().color = new Color32(230, 100, 0, 225);
        }
        else
        {
            var r = Random.Range(0, 100);
            var g = Random.Range(0, 100);
            var b = Random.Range(0, 100);
            GetComponent<Image>().color = new Color32((byte)r, (byte)g, (byte)b, 225);
        }
    }

    public IEnumerator SaveData()
    {
        while (true)
        {
            yield return new WaitForSeconds(60f);
        }
    }
}