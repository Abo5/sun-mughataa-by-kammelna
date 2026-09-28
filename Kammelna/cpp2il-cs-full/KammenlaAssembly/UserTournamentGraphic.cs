using DataTracking;
using UnityEngine;

public class UserTournamentGraphic : TournamentGraphic
{
	private AvatarInitializer avatar;

	private GameObject avatarParent;

	private GameObject altObject;

	private void Awake()
	{
		AvatarInitializer avatarInitializer = avatar;
		avatarInitializer.<TrackingPlacement>k__BackingField = TrackingPlacement.TournamentsList;
	}

	public override void Initialize(TournamentData tournament)
	{
		if (tournament.<Creator>k__BackingField != null)
		{
			altObject.SetActive(value: false);
			avatarParent.SetActive(value: true);
			AvatarData data = tournament.<Creator>k__BackingField;
			avatar.Initialize(data);
		}
		else
		{
			altObject.SetActive(value: true);
			avatarParent.SetActive(value: false);
		}
	}
}
