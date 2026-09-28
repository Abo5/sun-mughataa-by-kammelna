using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PredictAndWinScreenshot : MonoBehaviour
{
	private sealed class <>c__DisplayClass15_0
	{
		public PredictAndWinScreenshot <>4__this;

		public Action<bool> onSuccess;

		public Action<Sprite> <>9__1;

		internal void <TakeScreenshot>b__0(bool isSuccess)
		{
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_01d4: Expected O, but got I4
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0050: Expected O, but got I4
			//IL_016b: Expected O, but got I
			//IL_017b: Expected O, but got I
			//IL_018b: Expected O, but got I
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_0088: Expected O, but got I
			//IL_0096: Expected I, but got O
			if (isSuccess)
			{
				PredictAndWinScreenshot predictAndWinScreenshot = <>4__this;
				object obj = this + 32;
				Action<object> spriteCallback = (Action<object>)obj;
				object fileName = "Picking audio files is not supported on iOS" + 1224;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj4 = (nint)0 + (nint)1672;
					Action<object> action = default(Action<object>);
					action..ctor((object)this, (IntPtr)obj4);
					<>9__1 = action;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					spriteCallback = action;
				}
				predictAndWinScreenshot.screenshotCamera.Capture((string)fileName, spriteCallback);
				return;
			}
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object message = "Index = {0} position = {1}" + 1736;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
			Action<bool> action2;
			if ((nint)0 != 0)
			{
				PopupWindow.ShowError((string)message);
				action2 = onSuccess;
				if (onSuccess != null)
				{
					goto IL_015b;
				}
				return;
			}
			goto IL_0195;
			IL_0195:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowError((string)message);
			action2 = onSuccess;
			bool flag2 = onSuccess == null;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				return;
			}
			goto IL_015b;
			IL_015b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v8 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v8 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v8 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v138 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0195;
		}

		internal void <TakeScreenshot>b__1(Sprite sprite)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_006f: Expected O, but got I4
			//IL_0162: Expected O, but got I4
			//IL_00b6: Expected O, but got I
			//IL_00c6: Expected O, but got I
			//IL_00d6: Expected O, but got I
			PredictAndWinScreenshot predictAndWinScreenshot = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
			if ((nint)0 == 0)
			{
				goto IL_00e0;
			}
			bool flag = predictAndWinScreenshot.preview != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				goto IL_007d;
			}
			goto IL_011b;
			IL_011b:
			PredictAndWinScreenshot predictAndWinScreenshot2 = <>4__this;
			predictAndWinScreenshot2.preview.sprite = sprite;
			Action<bool> action = onSuccess;
			bool flag3 = onSuccess == null;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				return;
			}
			goto IL_00a6;
			IL_007d:
			action = onSuccess;
			if (onSuccess != null)
			{
				goto IL_00a6;
			}
			return;
			IL_00a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9 (System.Action`1<System.Boolean>)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9 (System.Action`1<System.Boolean>)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9 (System.Action`1<System.Boolean>)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v85 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_00e0;
			IL_00e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(predictAndWinScreenshot.preview != null))
			{
				goto IL_007d;
			}
			goto IL_011b;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public PredictAndWinScreenshot <>4__this;

		public MatchPredictionModel model;

		public Action<bool> onInitSuccess;

		internal void <Init>g__InitTeam1Icon|0()
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0034: Expected O, but got I
			//IL_004c: Expected I, but got O
			PredictAndWinScreenshot predictAndWinScreenshot = <>4__this;
			MatchPredictionModel matchPredictionModel = model;
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj2 = (nint)0 + (nint)1680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj2);
			UIExtensions.LoadSportTeamImage(predictAndWinScreenshot.team1Icon, matchPredictionModel.<homeTeam>k__BackingField, ImageCacher.SportTeamImageType.Prediction, setNative: false, action);
		}

		internal void <Init>b__3(bool isTeam1IconSuccess)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0029: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_0140: Expected O, but got I4
			//IL_01da: Expected O, but got I
			//IL_01ea: Expected O, but got I
			//IL_01fa: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0087;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0087;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				goto IL_014e;
			}
			return;
			IL_014e:
			PredictAndWinScreenshot predictAndWinScreenshot = <>4__this;
			GameObject gameObject = predictAndWinScreenshot.team1Icon.gameObject;
			gameObject.SetActive(isTeam1IconSuccess);
			if (isTeam1IconSuccess)
			{
				<Init>g__InitTeam2Icon|1();
				return;
			}
			Action<bool> action = onInitSuccess;
			if (onInitSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5 (System.Action`1<System.Boolean>)+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5 (System.Action`1<System.Boolean>)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5 (System.Action`1<System.Boolean>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X3_v1 (should have been resolved before IL gen)");
			}
			return;
			IL_0087:
			if (obj5 == null)
			{
				return;
			}
			goto IL_014e;
		}

		internal void <Init>g__InitTeam2Icon|1()
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0034: Expected O, but got I
			//IL_004c: Expected I, but got O
			PredictAndWinScreenshot predictAndWinScreenshot = <>4__this;
			MatchPredictionModel matchPredictionModel = model;
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj2 = (nint)0 + (nint)1688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj2);
			UIExtensions.LoadSportTeamImage(predictAndWinScreenshot.team2Icon, matchPredictionModel.<awayTeam>k__BackingField, ImageCacher.SportTeamImageType.Prediction, setNative: false, action);
		}

		internal void <Init>b__4(bool isTeam2IconSuccess)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0109: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01f0: Expected O, but got I4
			//IL_02a9: Expected O, but got I4
			//IL_0245: Expected O, but got I4
			//IL_0385: Expected O, but got I
			//IL_0395: Expected O, but got I
			//IL_03a5: Expected O, but got I
			//IL_0302: Expected O, but got I
			//IL_0312: Expected O, but got I
			//IL_0322: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E649D]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v16+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = <>4__this;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 == null)
			{
				goto IL_0174;
			}
			return;
			IL_0174:
			MatchPredictionModel matchPredictionModel = model;
			FileInfoModel <sponsorLogo>k__BackingField = matchPredictionModel.<sponsorLogo>k__BackingField;
			PredictAndWinScreenshot predictAndWinScreenshot;
			bool flag8;
			if (matchPredictionModel.<sponsorLogo>k__BackingField != null)
			{
				object obj11 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v11+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = StringsExtensions.IsNullOrEmpty(<sponsorLogo>k__BackingField.<url>k__BackingField);
				predictAndWinScreenshot = <>4__this;
				bool flag7 = (object)<>4__this == null;
				object obj14 = !flag7;
				flag8 = flag6;
				if (obj14 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				predictAndWinScreenshot = <>4__this;
				flag8 = true;
			}
			GameObject gameObject = predictAndWinScreenshot.team2Icon.gameObject;
			gameObject.SetActive(isTeam2IconSuccess);
			object obj15 = isTeam2IconSuccess && flag8;
			if ((nint)obj15 == 1)
			{
				Action<bool> action = onInitSuccess;
				if (onInitSuccess == null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v10 (System.Action`1<System.Boolean>)+18]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v10 (System.Action`1<System.Boolean>)+40]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v10 (System.Action`1<System.Boolean>)+28]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v158 @ X3_v2 (should have been resolved before IL gen)");
			}
			if (isTeam2IconSuccess)
			{
				<Init>g__InitSponsorIcon|2();
				return;
			}
			Action<bool> action2 = onInitSuccess;
			if (onInitSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9 (System.Action`1<System.Boolean>)+18]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9 (System.Action`1<System.Boolean>)+40]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9 (System.Action`1<System.Boolean>)+28]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v159 @ X3_v1 (should have been resolved before IL gen)");
			}
			return;
			IL_0091:
			bool flag9 = obj5 == null;
			bool flag10 = !flag9;
			obj9 = 0;
			obj10 = null;
			if (!flag10)
			{
				return;
			}
			goto IL_0174;
		}

		internal void <Init>g__InitSponsorIcon|2()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_003d: Expected I, but got O
			PredictAndWinScreenshot predictAndWinScreenshot = <>4__this;
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj2 = (nint)0 + (nint)1696;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj2);
			UIExtensions.LoadPredictAndWinImage(predictAndWinScreenshot.sponsorIcon, model, ImageCacher.PredictAndWinImageType.SponsorLogo, setNative: false, action);
		}

		internal void <Init>b__5(bool isSponsorSuccess)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f1: Expected O, but got I4
			//IL_014a: Expected O, but got I4
			//IL_01c4: Expected O, but got I
			//IL_01d4: Expected O, but got I
			//IL_01e4: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E649F]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				goto IL_0158;
			}
			return;
			IL_0158:
			PredictAndWinScreenshot predictAndWinScreenshot = <>4__this;
			GameObject gameObject = predictAndWinScreenshot.sponsorIcon.gameObject;
			gameObject.SetActive(isSponsorSuccess);
			Action<bool> action = onInitSuccess;
			if (onInitSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5 (System.Action`1<System.Boolean>)+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5 (System.Action`1<System.Boolean>)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5 (System.Action`1<System.Boolean>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v109 @ X3_v1 (should have been resolved before IL gen)");
			}
			return;
			IL_0091:
			if (obj5 == null)
			{
				return;
			}
			goto IL_0158;
		}
	}

	public const string TweetImageFileName = "PredictAndWinTweetImage";

	public ScreenshotCamera screenshotCamera;

	private AvatarInitializer avatar;

	private Image sponsorIcon;

	private Image preview;

	private Image backgroundStage;

	private Image team1Icon;

	private Image team2Icon;

	private DateTimeText date;

	private TextMeshProUGUI team1Name;

	private TextMeshProUGUI team2Name;

	private TextMeshProUGUI team1Score;

	private TextMeshProUGUI team2Score;

	private TextMeshProUGUI leagueName;

	private List<Sprite> normalStages;

	public void TakeScreenshot(UserMatchPredictionModel userMatchPredictionModel, Action<bool> onSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0096: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj4 = (nint)0 + (nint)1664;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj4);
		Init(userMatchPredictionModel, action);
	}

	public void Init(UserMatchPredictionModel userMatchPredictionModel, Action<bool> onInitSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_027b: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected I4, but got Unknown
		//IL_0336: Expected O, but got I4
		//IL_0343: Expected I4, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = onInitSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = userMatchPredictionModel.<predictionMatch>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj5;
		DateTimeText dateTimeText = date;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v4+28]");
		dateTimeText.SetDate((DateTime)0);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v5+90]");
		object obj8 = 0;
		TextMeshProUGUI textMesh = leagueName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v6+18]");
		TextMeshProExtensions.FixArabic(textMesh, (string)0);
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v7+80]");
		object obj10 = 0;
		TextMeshProUGUI textMesh2 = team1Name;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v8+18]");
		TextMeshProExtensions.FixArabic(textMesh2, (string)0);
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v9+88]");
		object obj12 = 0;
		TextMeshProUGUI textMesh3 = team2Name;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v10+18]");
		TextMeshProExtensions.FixArabic(textMesh3, (string)0);
		int num = default(int);
		string text = num.ToString();
		team1Score.text = text;
		string text2 = num.ToString();
		team2Score.text = text2;
		GameObject gameObject = backgroundStage.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = sponsorIcon.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = team1Icon.gameObject;
		gameObject3.SetActive(value: false);
		GameObject gameObject4 = team2Icon.gameObject;
		gameObject4.SetActive(value: false);
		UpdateUserAvatar();
		object obj13 = obj5;
		List<object> list = (List<object>)(object)normalStages;
		object obj14 = obj5 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v15+78]");
		object obj15 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v15+78]");
		if ((nint)0 != 0)
		{
			obj14 = obj15;
		}
		int num2 = obj14 / list._size;
		object obj16 = num2 * list._size;
		int index = obj14 - obj16;
		object sprite = list.get_Item(index);
		backgroundStage.sprite = (Sprite)sprite;
		GameObject gameObject5 = backgroundStage.gameObject;
		gameObject5.SetActive(value: true);
		((<>c__DisplayClass16_0)obj2).<Init>g__InitTeam1Icon|0();
	}

	public void UpdateUserAvatar()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		GameObject gameObject = avatar.gameObject;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v6+E4]");
		object obj3;
		object obj5;
		if ((nint)0 != 0)
		{
			obj3 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E8]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E8]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_009f;
			}
		}
		_ = 1;
		bool active = Prefs.GetBool((string)obj5, defaultValue: true);
		obj3 = obj5;
		goto IL_0167;
		IL_0167:
		gameObject.SetActive(active);
		if (Prefs.GetBool((string)obj3, defaultValue: true))
		{
			avatar.InitializeMyAvatar();
		}
		screenshotCamera.UpdateRenderTexture();
		return;
		IL_009f:
		active = Prefs.GetBool((string)obj3, defaultValue: true);
		bool flag3 = (object)gameObject == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0167;
	}

	public static void Clean()
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		object obj = 152985600;
		object fileName = "Picking audio files is not supported on iOS" + 1224;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64F3]");
		object obj3 = (nint)0 & (nint)1;
		string filePath;
		string path;
		if (obj3 != null)
		{
			filePath = ScreenshotCamera.GetFilePath((string)fileName);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			path = filePath;
			if (!flag)
			{
				goto IL_00aa;
			}
		}
		else
		{
			_ = 1;
			filePath = ScreenshotCamera.GetFilePath((string)fileName);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			path = filePath;
			if (obj6 != null)
			{
				goto IL_00aa;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FileUtils.Delete(path);
		return;
		IL_00aa:
		FileUtils.Delete(filePath);
	}
}
