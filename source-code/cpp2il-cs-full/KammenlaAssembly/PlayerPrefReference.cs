using UnityEngine;

public abstract class PlayerPrefReference<T> : ScriptableObject
{
	protected string key;

	protected T defaultValue;

	public abstract T Value { get; set; }
}
