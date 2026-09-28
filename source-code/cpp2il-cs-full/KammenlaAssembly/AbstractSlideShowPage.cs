using UnityEngine;

public abstract class AbstractSlideShowPage : MonoBehaviour
{
	public abstract bool isVisible { get; }

	public abstract void Show();

	public abstract void Hide();

	public abstract void SetHidden();
}
