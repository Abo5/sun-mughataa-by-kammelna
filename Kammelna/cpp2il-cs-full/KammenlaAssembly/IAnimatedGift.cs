using UnityEngine;

public interface IAnimatedGift
{
	Vector3 startPosition { get; }

	Vector3 targetPosition { get; }

	Userbox fromUserBox { get; }

	Userbox toUserbox { get; }

	float canvasScale { get; }

	bool allowClearing { get; set; }

	bool isCleared { get; }

	bool affectCards { get; set; }

	void StartAnimation();

	void Setup();

	void SetUserboxes(Userbox sender, Userbox receiver);

	void Clear();

	void OnSplinePrepared()
	{
	}
}
