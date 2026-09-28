using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class MatchPredictionsUI : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public UserMatchPredictionModel model;

		public MatchPredictionsUI <>4__this;

		internal void <ShowTweetPreview>b__0(PredictAndWinTweetPreview instance)
		{
			MatchPredictionsUI matchPredictionsUI = <>4__this;
			instance.Open(model, matchPredictionsUI.screenshotManager);
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public string tweetText;

		public UserMatchPredictionModel model;

		public MatchPredictionsUI <>4__this;

		public Action <>9__1;

		public Func<UserMatchPredictionModel, bool> <>9__3;

		public Action<KammelnaResponseModel<UserMatchPredictionModel>> <>9__4;

		public Action <>9__2;

		internal void <SubmitPrediction>b__0(bool isSuccess)
		{
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Expected O, but got Unknown
			//IL_018e: Expected O, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_0224: Expected O, but got I
			//IL_0232: Expected I, but got O
			//IL_0275: Expected O, but got I4
			//IL_027e: Expected O, but got I4
			//IL_0286: Expected I, but got O
			//IL_0297: Expected O, but got I4
			//IL_029f: Expected I, but got O
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected O, but got Unknown
			//IL_0306: Expected O, but got I
			//IL_030e: Expected I, but got O
			//IL_031c: Expected I, but got O
			//IL_035f: Expected O, but got I4
			//IL_0370: Expected O, but got I4
			bool flag = default(bool);
			object obj;
			Action action;
			nint num2 = default(nint);
			if (flag)
			{
				obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj2 = this + 40;
				action = (Action)obj2;
				object obj4;
				nint num;
				Action action2;
				object obj5 = default(object);
				if (obj2 != null)
				{
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					obj4 = obj5;
					num = num2;
					action2 = action;
					if (!flag2)
					{
						goto IL_008e;
					}
				}
				else
				{
					object obj6 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj7 = (nint)0 + (nint)1128;
					Action action3 = default(Action);
					action3..ctor(this, (IntPtr)obj7);
					<>9__1 = action3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v11+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					obj5 = 0;
					num2 = (nint)obj7;
					action = action3;
					obj4 = 0;
					num = (nint)obj7;
					action2 = action3;
					if (obj8 != null)
					{
						goto IL_008e;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
				num2 = num;
				action = action2;
				goto IL_008e;
			}
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object message = "Index = {0} position = {1}" + 1736;
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError((string)message);
			ITrackEvent trackEvent = TrackerLibrary.PredictAndWinFailedScreenshot();
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			return;
			IL_0116:
			Action action4;
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action4);
			return;
			IL_008e:
			Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(1f, action);
			object obj14 = this + 64;
			action4 = (Action)obj14;
			Action action6;
			if (obj14 != null)
			{
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v21+E4]");
				bool flag5 = (nint)0 == 0;
				nint num3 = num2;
				Action action5 = null;
				action6 = action4;
				if (!flag5)
				{
					goto IL_0116;
				}
			}
			else
			{
				object obj16 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)1136;
				nint num3 = (nint)obj17;
				Action action7 = default(Action);
				action7..ctor(this, (IntPtr)obj17);
				<>9__2 = action7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v21+E4]");
				bool flag6 = (nint)0 == 0;
				object obj18 = !flag6;
				action4 = action7;
				object obj5 = 0;
				Action action5 = action7;
				action6 = action7;
				if (obj18 != null)
				{
					goto IL_0116;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action4 = action6;
			goto IL_0116;
		}

		internal void <SubmitPrediction>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00cc: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E646E]");
			object obj2 = (nint)0 & (nint)1;
			string text;
			string text2;
			if (obj2 != null)
			{
				text = tweetText;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				text2 = tweetText;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				text = tweetText;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				text2 = tweetText;
				if (obj4 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SocialUtilities.PredictAndWin(text2);
			return;
			IL_0088:
			SocialUtilities.PredictAndWin(text);
		}

		internal void <SubmitPrediction>b__2()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_02d3: Expected O, but got I4
			//IL_02ed: Expected O, but got I
			//IL_02fd: Expected O, but got I
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0138: Expected O, but got I
			//IL_0146: Expected I, but got O
			//IL_017c: Expected O, but got I
			//IL_004d: Expected O, but got I
			//IL_019b: Expected O, but got I4
			//IL_01ac: Expected O, but got I4
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00c8: Expected O, but got I4
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected O, but got Unknown
			//IL_0218: Expected O, but got I4
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Expected O, but got Unknown
			//IL_0250: Expected O, but got I
			//IL_025e: Expected I, but got O
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = (nint)0 + (nint)2888;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
			object obj5 = 0;
			object obj6 = this + 48;
			if (obj6 != null)
			{
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+8]");
				bool flag2 = Enumerable.Any((IEnumerable<object>)0, (Func<object, bool>)obj6);
				bool flag3 = !flag2;
				Func<object, bool> func = (Func<object, bool>)obj6;
				object obj9 = default(object);
				object obj8 = obj9;
				Func<object, bool> func2 = (Func<object, bool>)obj6;
				object obj10 = obj4;
				if (!flag3)
				{
					goto IL_008a;
				}
			}
			else
			{
				object obj11 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 120;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj12 = (nint)0 + (nint)1144;
				Func<object, bool> func3 = default(Func<object, bool>);
				func3..ctor((object)this, (IntPtr)obj12);
				<>9__3 = func3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+8]");
				bool flag4 = Enumerable.Any((IEnumerable<object>)0, func3);
				bool flag5 = !flag4;
				object obj13 = !flag5;
				Func<object, bool> func = func3;
				object obj8 = 0;
				Func<object, bool> func2 = func3;
				object obj10 = obj4;
				if (obj13 != null)
				{
					goto IL_008a;
				}
			}
			UserMatchPredictionModel userMatchPredictionModel = model;
			MatchPredictionModel <predictionMatch>k__BackingField = userMatchPredictionModel.<predictionMatch>k__BackingField;
			object obj14 = this + 56;
			Action<object> callback = (Action<object>)obj14;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 672;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)1152;
				Action<object> action = default(Action<object>);
				action..ctor((object)this, (IntPtr)obj17);
				<>9__4 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				callback = action;
			}
			KammelnaRequests.PredictMatch(<predictionMatch>k__BackingField.<id>k__BackingField, userMatchPredictionModel.<homeTeamScore>k__BackingField, userMatchPredictionModel.<awayTeamScore>k__BackingField, callback);
			return;
			IL_008a:
			object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v20+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.DismissMessage();
			MatchPredictionsUI matchPredictionsUI = <>4__this;
			matchPredictionsUI.eventsChannel.TriggerPredictionSubmitted(model);
		}

		internal bool <SubmitPrediction>b__3(UserMatchPredictionModel m)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (m != null)
			{
				MatchPredictionModel <predictionMatch>k__BackingField = m.<predictionMatch>k__BackingField;
				if (m.<predictionMatch>k__BackingField != null)
				{
					UserMatchPredictionModel userMatchPredictionModel = model;
					if (model != null)
					{
						MatchPredictionModel <predictionMatch>k__BackingField2 = userMatchPredictionModel.<predictionMatch>k__BackingField;
						if (userMatchPredictionModel.<predictionMatch>k__BackingField != null)
						{
							object obj = <predictionMatch>k__BackingField.<id>k__BackingField - <predictionMatch>k__BackingField2.<id>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <SubmitPrediction>b__4(KammelnaResponseModel<UserMatchPredictionModel> response)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00d6: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			//IL_0104: Expected O, but got I
			//IL_02e7: Expected O, but got I
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_0168: Expected O, but got I4
			//IL_0323: Expected O, but got I4
			//IL_037a: Expected O, but got I
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Expected O, but got Unknown
			//IL_0199: Expected O, but got I
			//IL_01b5: Expected O, but got I
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Expected O, but got Unknown
			//IL_0216: Expected O, but got I4
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Expected O, but got Unknown
			//IL_0255: Expected O, but got I4
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Expected O, but got Unknown
			//IL_02a1: Expected O, but got I4
			//IL_0392: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Expected O, but got Unknown
			//IL_03a3: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6470]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v35+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v35+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.DismissMessage();
			goto IL_00f8;
			IL_00f8:
			object obj5 = (nint)0 + (nint)1632;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v19+B8]");
				object obj9 = 0;
				object obj10 = (nint)0 + (nint)2960;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v14+8]");
				((List<object>)0).Insert(0, model);
				MatchPredictionsUI matchPredictionsUI = <>4__this;
				matchPredictionsUI.eventsChannel.TriggerPredictionSubmitted(model);
				object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message = "Picking audio files is not supported on iOS" + 1272;
				Toast.Show((string)message, (Vector2)0, 0f);
				ITrackEvent trackEvent = TrackerLibrary.PredictAndWinSucceeded();
				object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v25+E4]");
				bool flag4 = (nint)0 == 0;
				object obj16 = !flag4;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				object action = "Picking audio files is not supported on iOS" + 1232;
				object type = (nint)0 + (nint)2000;
				FirebaseTrack.Event((string)action, (string)type);
			}
			else
			{
				MatchPredictionsUI matchPredictionsUI2 = <>4__this;
				matchPredictionsUI2.eventsChannel.TriggerPredictionFail();
				object obj17 = (nint)0 + (nint)1624;
				string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v9+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.ShowError(errorMessage);
				ITrackEvent trackEvent2 = TrackerLibrary.PredictAndWinFailedRequest();
				object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v12+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent2);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent2);
			}
			return;
			IL_0074:
			PopupWindow.DismissMessage();
			bool flag6 = response == null;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00f8;
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public MatchPredictionModel model;

		internal void <ShowRewardsView>b__0(PredictAndWinRewardPopup instance)
		{
			instance.Populate(model);
			instance.popupUI.PopFromCenter();
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public UserMatchPredictionModel model;

		internal void <ShowRewardsView>b__0(PredictAndWinRewardPopup instance)
		{
			UserMatchPredictionModel userMatchPredictionModel = model;
			instance.Populate(userMatchPredictionModel.<predictionMatch>k__BackingField);
			instance.Populate(userMatchPredictionModel);
			instance.popupUI.PopFromCenter();
		}
	}

	private PredictAndWinEventsChannel eventsChannel;

	private PredictAndWinScreenshot screenshotManager;

	private ComponentReference<PredictAndWinRewardPopup> giftViewRef;

	private ComponentReference<PredictAndWinTweetPreview> tweetPreviewPopupRef;

	private RectTransform cardToHistoryAnimationTarget;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0228: Expected O, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0258: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_0288: Expected I, but got O
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_0104: Expected I, but got O
		//IL_0115: Expected O, but got I
		//IL_0141: Expected I, but got O
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj5 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3056;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2680;
		object obj7 = (nint)0 + (nint)3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = default(object);
		obj8..ctor();
		_ = 0;
		object obj9 = obj8 + 32;
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj8);
		ITrackEvent trackEvent = TrackerLibrary.PredictAndWinViewed();
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj7);
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3960;
		object obj13 = (nint)0 + (nint)3872;
		eventsChannel.ShowMatchRewards += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj13);
		object obj14 = (nint)0 + (nint)3880;
		eventsChannel.ShowPredictionRewards += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj14);
		object obj15 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 768;
		object obj16 = (nint)0 + (nint)3888;
		eventsChannel.ShowTweetPreview += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action4 = default(Action<object, object>);
		action4..ctor((object)this, (IntPtr)obj16);
		eventsChannel.SubmitPrediction += action4;
		object obj17 = eventsChannel + 24;
		obj17 = cardToHistoryAnimationTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0154: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00ff: Expected I, but got O
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0131: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2680;
		object obj2 = (nint)0 + (nint)3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3960;
		object obj4 = (nint)0 + (nint)3872;
		eventsChannel.ShowMatchRewards -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)3880;
		eventsChannel.ShowPredictionRewards -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj5);
		object obj6 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 768;
		object obj7 = (nint)0 + (nint)3888;
		eventsChannel.ShowTweetPreview -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action4 = default(Action<object, object>);
		action4..ctor((object)this, (IntPtr)obj7);
		eventsChannel.SubmitPrediction -= action4;
		object obj8 = eventsChannel + 24;
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void SubmitPrediction(string tweetText, UserMatchPredictionModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_024f: Expected O, but got I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0347: Expected O, but got I4
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_0388: Expected O, but got I
		//IL_0399: Expected I, but got O
		//IL_017a: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02b5: Expected O, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I
		//IL_01fa: Expected O, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = tweetText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+10]");
		object obj17;
		object key;
		if ((nint)0 < (nint)281)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object msgBody = "LAK" + 2136;
			PopupWindow.ShowLoading((string)msgBody, dismissible: false);
			object fileName = "Picking audio files is not supported on iOS" + 1224;
			object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			string filePath = ScreenshotCamera.GetFilePath((string)fileName);
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			FileUtils.Delete(filePath);
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1120;
			Action<bool> action = default(Action<bool>);
			action..ctor(obj2, (IntPtr)obj14);
			PredictAndWinScreenshot predictAndWinScreenshot = screenshotManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
			predictAndWinScreenshot.TakeScreenshot((UserMatchPredictionModel)0, action);
			object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				obj17 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E8]");
				object obj18 = (nint)0 & (nint)1;
				bool flag3 = obj18 == null;
				object obj19 = !flag3;
				key = obj17;
				if (obj19 == null)
				{
					goto IL_0210;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2128;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64E8]");
				object obj20 = (nint)0 & (nint)1;
				if (obj20 == null)
				{
					goto IL_0210;
				}
				key = obj17;
			}
			goto IL_039e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj21 = !flag4;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "ThisIsFakeReceiptData" + 2712;
		PopupWindow.ShowError((string)message);
		return;
		IL_039e:
		bool hasAvatar = Prefs.GetBool((string)key, defaultValue: true);
		ITrackEvent trackEvent = TrackerLibrary.PredictAndWinTweetAttempted(hasAvatar);
		object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v23+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0210:
		_ = 1;
		key = obj17;
		goto IL_039e;
	}

	private void ShowRewardsView(MatchPredictionModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		//IL_00c3: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3064;
		object obj4 = (nint)0 + (nint)1160;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2256;
		object obj7 = obj2 + 16;
		obj7 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void ShowRewardsView(UserMatchPredictionModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		//IL_00c3: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3064;
		object obj4 = (nint)0 + (nint)1168;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2256;
		object obj7 = obj2 + 16;
		obj7 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void ShowTweetPreview(UserMatchPredictionModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_0210: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		//IL_0222: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_025a: Expected O, but got I
		//IL_026b: Expected I, but got O
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I4
		//IL_02d7: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string userTwitterID = SFSKammelnaUserExtensions.GetUserTwitterID(localUser);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = StringsExtensions.IsNullOrEmpty(userTwitterID);
			bool flag3 = !flag2;
			object obj11 = 0;
			object obj12 = 0;
			if (!flag3)
			{
				goto IL_0169;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = StringsExtensions.IsNullOrEmpty(userTwitterID);
			bool flag5 = !flag4;
			object obj13 = !flag5;
			object obj11 = 0;
			object obj12 = 0;
			if (obj13 != null)
			{
				goto IL_0169;
			}
		}
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1112;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj15);
		object obj16 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v21+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = (nint)0 + (nint)2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0169:
		object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v30+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "LAK" + 1760;
		PopupWindow.ShowError((string)message);
	}
}
