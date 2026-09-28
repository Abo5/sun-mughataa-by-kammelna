using UnityEngine;

public interface ICustomPlayAnimation
{
	GameAction Action { get; set; }

	void StartAnimation(SpriteRenderer card, Transform startPlacement, Userbox userbox, SpriteRenderer[] groundCards, Vector3 landingWorldPosition);
}
