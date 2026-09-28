using DG.Tweening;
using UnityEngine;

public class TweenAnimationPlayer : MonoBehaviour
{
	private string friendlyName;

	private TweenAnimation Animation;

	private bool PlayOnAwake;

	public void OnEnable()
	{
		if (PlayOnAwake)
		{
			Sequence sequence = Animation.Replay();
		}
	}

	public void PlayAnimation()
	{
		Sequence sequence = Animation.Replay();
	}

	public void Rewind()
	{
		Animation.Rewind();
	}

	public void PlayBackwards()
	{
		Animation.PlayBackwards();
	}

	public void PlayForward()
	{
		Animation.PlayForward();
	}
}
