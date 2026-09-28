using UnityEngine;
using UnityEngine.Events;

namespace Util.Addressables;

public class InitializationAction : MonoBehaviour, IInitializable
{
	private UnityEvent action;

	public void Initialize()
	{
		if (action != null)
		{
			action.Invoke();
		}
	}
}
