using TMPro;
using UnityEngine;

public class TournamentJoinCostUi : MonoBehaviour
{
	private GameObject acesObject;

	private TextMeshProUGUI text;

	public void SetPrice(int price)
	{
		if (price >= 1)
		{
			acesObject.SetActive(value: true);
			TextMeshProExtensions.SetPriceText(text, price, useCommas: true);
		}
		else
		{
			acesObject.SetActive(value: false);
		}
	}
}
