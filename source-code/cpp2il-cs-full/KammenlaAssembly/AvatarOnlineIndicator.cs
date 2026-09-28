using Kammelna.Server;
using Sfs2X.Entities;
using UI.UI_Themeing;

public class AvatarOnlineIndicator : AvatarComponent
{
	private UiToggler OnlineIndicator;

	private int UserDbId;

	private void OnCheckUserOnline()
	{
		if (UserDbId >= 1)
		{
			bool isON = SFS.CheckIsOnline(UserDbId);
			OnlineIndicator.ToggleManual(isON);
		}
	}

	public unsafe override void Initialize(AvatarData avatarData)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		bool flag = int.TryParse(avatarData.<Dbid>k__BackingField, out *(int*)(this + 48));
		if (UserDbId != 0)
		{
			object methodName = "October" + 320;
			InvokeRepeating((string)methodName, 0f, 1f);
		}
		else
		{
			OnlineIndicator.ToggleManual(isON: false);
		}
	}

	public override void Initialize(User userData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if ((UserDbId = SFSKammelnaUserExtensions.GetIntDbId(userData)) != 0)
		{
			object methodName = "October" + 320;
			InvokeRepeating((string)methodName, 0f, 1f);
		}
		else
		{
			OnlineIndicator.ToggleManual(isON: false);
		}
	}

	public override void Clear()
	{
		UserDbId = 0;
		OnlineIndicator.ToggleManual(isON: false);
		CancelInvoke();
	}
}
