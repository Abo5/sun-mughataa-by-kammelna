using System;
using UI.Mutations;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class EnableButtonMutation : IMutation
{
	private Selectable target;

	public void Setup(GameObject gm)
	{
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		target.interactable = true;
	}

	public void UndoMutation()
	{
		target.interactable = false;
	}
}
