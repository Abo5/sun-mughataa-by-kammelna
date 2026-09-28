using System;
using UnityEngine;

namespace UI.Mutations;

[Serializable]
public class EnableBehaviorMutation : IMutation
{
	private enum ActiveMode
	{
		Enable,
		Disable
	}

	private ActiveMode mode;

	private MonoBehaviour behaviour;

	public void Setup(GameObject gm)
	{
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		bool enabled = mode == ActiveMode.Enable;
		behaviour.enabled = enabled;
	}

	public void UndoMutation()
	{
		bool flag = mode == ActiveMode.Enable;
		bool enabled = !flag;
		behaviour.enabled = enabled;
	}
}
