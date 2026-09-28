using UI.Loading;
using UnityEngine;

public class SimpleLoadingIndicator : MonoBehaviour, ILoadingIndicator
{
	public void StartLoading()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	public void FinishLoading()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}
}
