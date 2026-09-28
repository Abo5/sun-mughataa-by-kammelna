using System;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine.TextCore;

public class AvatarUserFeedItemIcon : UserFeedItemIcon
{
	private AvatarInitializer avatarInitializer;

	public override void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		IAvatarFeedData avatarFeedData = default(IAvatarFeedData);
		if (avatarFeedData != null)
		{
			avatarInitializer.Initialize(avatarFeedData);
		}
		Actions.SafeInvoke(onReady);
	}
}
