using UnityEngine;

public class OnlyForSubscribersReq : ScriptableObject
{
	private Sprite featureIcon;

	private string featureText;

	private GameObject featureBottomTextObject;

	private GameObject featureBottomObject;

	public string FeatureText => featureText;

	public Sprite FeatureIcon => featureIcon;

	public GameObject FeatureBottomTextObject => featureBottomTextObject;

	public GameObject FeatureBottomObject => featureBottomObject;
}
