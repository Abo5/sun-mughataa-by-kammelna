using UnityEngine;
using UnityEngine.Events;

public class AnimationEventCallback : MonoBehaviour
{
	public UnityEvent<string> callback;

	public void OnAnimationEvent(string id)
	{
		if (callback != null)
		{
			((UnityEvent<object>)(object)callback).Invoke((object)id);
		}
	}
}
