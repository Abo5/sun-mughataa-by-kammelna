using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ReplyButton : MonoBehaviour
{
	private sealed class <>c__DisplayClass7_0
	{
		public CommonWord word;

		public ReplyButton <>4__this;

		public bool isTop4;

		internal unsafe void <Populate>b__0()
		{
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0068: Expected O, but got Ref
			//IL_00a8: Expected O, but got I4
			//IL_0192: Expected O, but got I
			//IL_01c5: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			CommonWord commonWord = word;
			ChatHandler.SendChat(commonWord.<Word>k__BackingField);
			ReplyButton replyButton = <>4__this;
			replyButton.gameEventsChannel.TriggerCloseQuickReplies();
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = default(object);
			string category = ((Enum)(&obj3)).ToString();
			ITrackEvent trackEvent = TrackerLibrary.GameQuickReplyClicked(category);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)2200;
			Tracker.DesignEvent(trackEvent);
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			if (SFSKammelnaUserExtensions.IsSubscribed(localUser))
			{
				ITrackEvent trackEvent2 = TrackerLibrary.GameQuickReplyTop4Clicked(isTop4);
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent2);
			}
		}
	}

	private static readonly Color DisabledColor;

	private EnumSprites filters;

	private Image filterImage;

	private GameObject crwon;

	private GameEventsChannel gameEventsChannel;

	private Button button;

	private TextMeshProUGUI textMesh;

	public void Populate(CommonWord word, bool isTop4)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_0142: Expected O, but got I
		//IL_01e2: Expected O, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03cc: Expected O, but got I
		//IL_03e7: Expected I, but got O
		//IL_030d: Expected O, but got I
		//IL_0426: Expected O, but got I
		//IL_0370: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)3640;
			object obj4 = (nint)0 + (nint)288;
			object obj5 = obj2 + 16;
			obj5 = word;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 24;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj7 = this + 64;
			object obj8 = default(object);
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
			object obj9 = this + 72;
			object obj10 = default(object);
			obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X23_v7-28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X23_v7-28]");
				((EnumSprites)0).Setup();
				object obj11 = obj5;
				if (obj5 != null)
				{
					TextMeshProUGUI textMeshProUGUI = textMesh;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v5+10]");
					TextMeshProExtensions.FixArabic(textMeshProUGUI, (string)0);
					object obj12 = obj5;
					if (obj5 != null)
					{
						EnumSprites enumSprites = filters;
						if (filters != null)
						{
							Sprite[] sprites = enumSprites.Sprites;
							if (enumSprites.Sprites != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v3+18]");
								bool flag = (nint)0 < (nint)sprites.Length;
								object obj13 = !flag;
								if (obj13 != null)
								{
									goto IL_043c;
								}
								if ((object)filterImage != null)
								{
									Sprite[] sprites2 = enumSprites.Sprites;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v3+18]");
									object obj14 = sprites2 + 0;
									Image image = filterImage;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v8+20]");
									image.sprite = (Sprite)0;
									object obj15 = obj5;
									if (obj5 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v9+1C]");
										bool flag2 = (nint)0 != 1;
										object obj16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v8+20]");
										bool flag3 = false;
										if (!flag2)
										{
											object obj17 = typeof(Queue<string>) + 848;
											object obj18 = obj17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v27+E4]");
											bool flag4 = (nint)0 == 0;
											object obj19 = !flag4;
											if (obj19 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj20 = (nint)0 + (nint)2200;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
											SessionModel sessionModel = default(SessionModel);
											if ((object)sessionModel == null)
											{
												goto IL_042e;
											}
											User localUser = sessionModel.LocalUser;
											bool flag5 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
											bool flag6 = !flag5;
											obj16 = 0;
											flag3 = true;
											if (flag6)
											{
												HandleNonSubscribed();
												return;
											}
										}
										object obj21 = obj7;
										if (obj7 != null)
										{
											object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
											object obj23 = (nint)0 + (nint)3944;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											UnityAction unityAction = default(UnityAction);
											unityAction..ctor(obj2, (IntPtr)obj23);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12+100]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12+100]");
												((UnityEvent)0).AddListener(unityAction);
												return;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_042e;
		IL_042e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_043c;
		IL_043c:
		throw new IndexOutOfRangeException();
	}

	private void HandleNonSubscribed()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0165: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_020b: Expected O, but got I4
		//IL_0235: Expected O, but got I
		//IL_01af: Expected O, but got I4
		//IL_024c: Expected I, but got O
		//IL_025c: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0100: Expected O, but got I
		//IL_0113: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76BD]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = crwon;
			obj6 = crwon;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = crwon;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = crwon;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00b7;
		}
		goto IL_01bd;
		IL_00b7:
		crwon.SetActive(value: true);
		Button button = this.button;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)216;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(gameEventsChannel, (IntPtr)obj10);
		button.m_OnClick.AddListener(unityAction);
		return;
		IL_01bd:
		this.button.interactable = false;
		object obj11 = typeof(RegisteredWaitHandle) + 624;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		filterImage.color = (Color)0;
		TextMeshProUGUI textMeshProUGUI = textMesh;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v161 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
		goto IL_01bd;
	}

	static ReplyButton()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 624;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F40]");
		obj3 = 0;
	}
}
