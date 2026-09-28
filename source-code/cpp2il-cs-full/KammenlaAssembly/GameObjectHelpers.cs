using UnityEngine;

public static class GameObjectHelpers
{
	public static void Enable(GameObject gameObject)
	{
		gameObject.SetActive(value: true);
	}

	public static void Disable(GameObject gameObject)
	{
		gameObject.SetActive(value: false);
	}

	public static void Enable(Component comp)
	{
		GameObject gameObject = comp.gameObject;
		gameObject.SetActive(value: true);
	}

	public static void Disable(Component comp)
	{
		GameObject gameObject = comp.gameObject;
		gameObject.SetActive(value: false);
	}
}
