using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EconomicManager : MonoBehaviour
{
	public Region playerRegion;
	public GameObject moneyCounter;

	private void Start()
	{
		StartCoroutine(AddMoney());
	}

	private void Update()
    {
        moneyCounter.GetComponent<Text>().text = $"Money: {playerRegion.money}";
    }

    IEnumerator AddMoney() //delete after test
	{
		while(true)
		{
			yield return new WaitForSeconds(1);
			playerRegion.money += 1.5f;
		}
	}
}
