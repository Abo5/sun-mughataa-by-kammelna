using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MassWinnersStrip : MonoBehaviour
{
	private AvatarInitializer avatarPrefab;

	private Transform avatarsLayout;

	private Image img;

	private TextMeshProUGUI placeText;

	public void Populate(MassEventWinner winner, MassEventPrizeViewModel prize, long eventId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0063: Expected O, but got I
		//IL_0081: Expected I8, but got I4
		//IL_00e3: Expected I, but got O
		object obj = "Network Authentication Required" + 3288;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2528;
		object obj3 = (nint)0 + (nint)3720;
		TextMeshProExtensions.LocalizeOrdinal(placeText, (string)obj, winner.<Place>k__BackingField);
		bool flag = prize == null;
		IntPtr intPtr = default(IntPtr);
		Action<bool> action = (Action<bool>)(nint)intPtr;
		bool flag2 = false;
		MassEventPrizeViewModel massEventPrizeViewModel = (MassEventPrizeViewModel)obj;
		long num = winner.<Place>k__BackingField;
		if (!flag)
		{
			UIExtensions.LoadMassTournamentPrizeImage(img, prize, eventId);
			action = null;
			flag2 = false;
			massEventPrizeViewModel = prize;
			num = eventId;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		((List<object>)(object)winner.<Players>k__BackingField).ForEach(action2);
	}

	private void <Populate>b__4_0(LeaderBoardPlayer w)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E604F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)480;
			AvatarInitializer avatarInitializer = avatarPrefab;
			Transform transform = avatarsLayout;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			AvatarInitializer avatarInitializer2 = avatarPrefab;
			Transform transform2 = avatarsLayout;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)480;
			AvatarInitializer avatarInitializer = avatarPrefab;
			Transform transform = avatarsLayout;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			AvatarInitializer avatarInitializer2 = avatarPrefab;
			Transform transform2 = avatarsLayout;
			if (obj7 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		AvatarInitializer avatarInitializer3 = default(AvatarInitializer);
		bool flag3 = (object)avatarInitializer3 == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c8;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		goto IL_00c8;
		IL_00c8:
		avatarInitializer3.<TrackingPlacement>k__BackingField = TrackingPlacement.MassTournamentView;
		AvatarData data = w;
		avatarInitializer3.Initialize(data);
	}
}
