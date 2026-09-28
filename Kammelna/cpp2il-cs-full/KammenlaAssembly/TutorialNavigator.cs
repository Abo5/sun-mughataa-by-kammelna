using Kammelna.Server;
using KammelnaOffline.Baloot.Tutorial;
using UnityEngine;

public class TutorialNavigator : MonoBehaviour
{
	private TutorialType tutorialType;

	public void Navigate()
	{
		SFS.GoToTutorial(tutorialType);
	}
}
