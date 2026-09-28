using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;

public class NotEnoughTicketsPopupManager : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<NotEnoughTicketsPopupManager> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ShowPopup>b__6_0(NotEnoughTicketsPopupManager instance)
		{
			instance.InitPopupVariant();
			instance.popup.SlideFromBottom(null);
		}
	}

	private static readonly AddressReference<NotEnoughTicketsPopupManager> Address;

	private PopupUI popup;

	private GameObject UserHasEnoughCurrency;

	private GameObject UserHasNoEnoughCurrency;

	public void Awake()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		if ((object)UserHasEnoughCurrency != null)
		{
			Transform transform = UserHasEnoughCurrency.transform;
			if ((object)transform != null)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				if (transform != obj)
				{
					goto IL_00c9;
				}
				((RectTransform)transform).anchoredPosition = (Vector2)0;
				if ((object)UserHasNoEnoughCurrency != null)
				{
					Transform transform2 = UserHasNoEnoughCurrency.transform;
					if ((object)transform2 != null)
					{
						if (transform2 == obj)
						{
							((RectTransform)transform2).anchoredPosition = (Vector2)0;
							return;
						}
						goto IL_00c9;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00c9;
		IL_00c9:
		throw new InvalidCastException();
	}

	private void InitPopupVariant()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0190: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected I4, but got Unknown
		//IL_025d: Expected O, but got I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected I4, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77C1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0133:
		object obj8 = typeof(RegisteredWaitHandle) + 56;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		FastTrackConfig <FastTrack>k__BackingField = current.<FastTrack>k__BackingField;
		object obj11 = aces - <FastTrack>k__BackingField.<TicketPrice>k__BackingField;
		bool flag4 = (nint)obj11 < 0;
		int num = aces ^ <FastTrack>k__BackingField.<TicketPrice>k__BackingField;
		int num2 = aces ^ obj11;
		int num3 = num & num2;
		bool flag5 = num3 < 0;
		bool active = flag4 == flag5;
		UserHasEnoughCurrency.SetActive(active);
		object obj12 = aces - <FastTrack>k__BackingField.<TicketPrice>k__BackingField;
		bool flag6 = (nint)obj12 < 0;
		int num4 = aces ^ <FastTrack>k__BackingField.<TicketPrice>k__BackingField;
		int num5 = aces ^ obj12;
		int num6 = num4 & num5;
		bool flag7 = num6 < 0;
		bool flag8 = flag6 == flag7;
		bool active2 = !flag8;
		UserHasNoEnoughCurrency.SetActive(active2);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag9 = (object)sessionModel == null;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	public static void ShowPopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0207: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02d5: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_0307: Expected O, but got I4
		//IL_0247: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_034f: Expected O, but got I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0439: Expected O, but got I
		//IL_044a: Expected I, but got O
		//IL_0468: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_03ba: Expected O, but got I4
		//IL_037f: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77C2]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 824;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 824;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v17+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj4 = obj7;
		object obj14 = obj12;
		object obj15 = obj10;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_029f;
		IL_0167:
		object obj16 = (nint)0 + (nint)2184;
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = obj16;
		obj15 = obj11;
		Action<object> action2;
		Action<object> action = action2;
		if (!flag4)
		{
			goto IL_01b8;
		}
		goto IL_03e8;
		IL_03e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj19;
		obj11 = obj15;
		action2 = action;
		goto IL_01b8;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		return;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+B8]");
		object obj20 = 0;
		obj11 = obj20;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		obj7 = obj4;
		obj15 = obj20;
		if (!flag5)
		{
			goto IL_00fe;
		}
		goto IL_029f;
		IL_029f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj7;
		obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		obj11 = obj15;
		object obj23 = obj18;
		obj4 = obj7;
		if (obj22 != null)
		{
			goto IL_0167;
		}
		goto IL_032d;
		IL_00fe:
		obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+B8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		bool flag7 = (nint)0 == 0;
		obj23 = obj18;
		obj15 = obj11;
		if (!flag7)
		{
			goto IL_0167;
		}
		goto IL_032d;
		IL_032d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v11+B8]");
			obj21 = 0;
		}
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)2608;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj21, (IntPtr)obj27);
		object obj28 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v9+B8]");
		object obj29 = (nint)0 + (nint)8;
		obj29 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16 = (nint)0 + (nint)2184;
		obj17 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v1+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		obj11 = obj15;
		action2 = action3;
		obj19 = obj16;
		action = action3;
		if (obj30 != null)
		{
			goto IL_01b8;
		}
		goto IL_03e8;
	}

	private void OpenPopup()
	{
		InitPopupVariant();
		popup.SlideFromBottom(null);
	}

	static NotEnoughTicketsPopupManager()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "Network Authentication Required" + 2136;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3096;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
