using UnityEngine;

public abstract class AbstractEndGameScore : MonoBehaviour
{
	public abstract void ResetScore();

	public abstract void SetupScore(int[] scores);
}
