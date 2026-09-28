using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using UnityEngine;
using UnityEngine.UI;

public class MassEventStageUserFeedItemIcon : UserFeedItemIcon
{
	private Image statusImage;

	private Sprite statusWon;

	private Sprite statusKnockedOut;

	private Sprite statusReserved;

	public override void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		//IL_0181: Expected O, but got I
		//IL_0130: Expected O, but got I4
		UserFeedData <Data>k__BackingField = feedItem.<Data>k__BackingField;
		if (feedItem.<Data>k__BackingField != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3752;
			object obj2 = obj;
			nint num = (nint)<Data>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v3 (Il2CppClass<Server.Models.UserFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v5+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v3 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v5+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v5-8]");
				if (0 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4 (Server.Models.UserFeedData)+34]");
					object obj6 = (((nint)0 != 1) ? ((object)48) : ((object)40));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4 (Server.Models.UserFeedData)+34]");
					if ((nint)0 == 2)
					{
						object obj7 = 56;
					}
					else
					{
						object obj7 = obj6;
					}
					Image image = statusImage;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MassEventStageUserFeedItemIcon)+v164 @ X8_v7]");
					image.sprite = (Sprite)0;
					Actions.SafeInvoke(onReady);
					return;
				}
			}
		}
		Actions.SafeInvoke(onReady);
	}
}
