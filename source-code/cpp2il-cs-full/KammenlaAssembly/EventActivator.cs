using UnityEngine;
using UnityEngine.Events;

public class EventActivator : MonoBehaviour
{
	private enum ActivationPhase
	{
		Awake,
		Start,
		Enable,
		Disable,
		Destroy
	}

	private ActivationPhase activateOn;

	private UnityEvent action;

	private void Awake()
	{
		if (activateOn == ActivationPhase.Awake && action != null)
		{
			action.Invoke();
		}
	}

	private void Start()
	{
		if (activateOn == ActivationPhase.Start && action != null)
		{
			action.Invoke();
		}
	}

	private void OnEnable()
	{
		if (activateOn == ActivationPhase.Enable && action != null)
		{
			action.Invoke();
		}
	}

	private void OnDisable()
	{
		if (activateOn == ActivationPhase.Disable && action != null)
		{
			action.Invoke();
		}
	}

	private void OnDestroy()
	{
		if (activateOn == ActivationPhase.Destroy && action != null)
		{
			action.Invoke();
		}
	}
}
