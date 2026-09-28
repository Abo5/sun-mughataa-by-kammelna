using UnityEngine;

public abstract class ProgressMeterBase : MonoBehaviour
{
	public abstract void SetProgress(int current, int max);

	public abstract void SetProgressInstant(int current, int max);

	public abstract void SetText(string text);
}
