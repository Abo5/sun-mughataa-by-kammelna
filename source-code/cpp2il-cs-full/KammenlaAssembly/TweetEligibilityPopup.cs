using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Sfs2X.Entities;
using Social;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TweetEligibilityPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass17_0
	{
		public string[] hashes;

		public MatchPredictionModel match;

		public TweetEligibilityPopup <>4__this;

		internal void <OnFollowingResult>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Expected O, but got Unknown
			//IL_0181: Expected O, but got I
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected O, but got Unknown
			//IL_01b2: Expected I, but got O
			//IL_01e1: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E650C]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v12+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v12+E4]");
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
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			string userTwitterUserID = SFSKammelnaUserExtensions.GetUserTwitterUserID(localUser);
			MatchPredictionModel matchPredictionModel = match;
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj9 = (nint)0 + (nint)3352;
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<bool> action = default(Action<bool>);
			action..ctor((object)<>4__this, (IntPtr)obj9);
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TwitterRequests.SearchTweet(userTwitterUserID, hashes, matchPredictionModel.<displayDate>k__BackingField, matchPredictionModel.<expiryDate>k__BackingField, action);
			return;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = (object)sessionModel == null;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0133;
		}
	}

	private PredictAndWinEventsChannel eventsChannel;

	private PopupUI popup;

	private Button tweetAgainButton;

	private TweeterValidationStep step1;

	private TweeterValidationStep step2;

	private TweeterValidationStep step3;

	private TweeterValidationStep step4;

	private GameObject successObject;

	private TextMeshProUGUI failObject;

	private List<TweeterValidationStep> _allSteps;

	private UserMatchPredictionModel _model;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00ec: Expected O, but got I4
		//IL_016c: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_018c: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0157: Expected O, but got I4
		//IL_01fa: Expected O, but got I4
		//IL_0271: Expected O, but got I
		//IL_0281: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_02ff: Expected O, but got I4
		//IL_0376: Expected O, but got I
		//IL_0386: Expected O, but got I
		//IL_0396: Expected O, but got I
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0404: Expected O, but got I4
		//IL_047b: Expected O, but got I
		//IL_048b: Expected O, but got I
		//IL_049b: Expected O, but got I
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		Button button = tweetAgainButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(List<Tween>) + 24;
		button.m_OnClick.AddListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = (nint)0 + (nint)2048;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = step1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v5+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v22+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v23+70]");
			object obj9 = 0;
			list.AddWithResize((object)step1);
		}
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = step2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v7+20]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v19+C0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v20+70]");
			object obj9 = 0;
			list.AddWithResize((object)step2);
		}
		object obj18 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj20 = items3 + list._size;
			object obj21 = obj20 + 32;
			obj21 = step3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v9+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v16+C0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v17+70]");
			object obj9 = 0;
			list.AddWithResize((object)step3);
		}
		object obj24 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj25 = !flag4;
		if (obj25 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj26 = items4 + list._size;
			object obj27 = obj26 + 32;
			obj27 = step4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v11+20]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v13+C0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v14+70]");
			object obj9 = 0;
			list.AddWithResize((object)step4);
		}
		object obj30 = this + 104;
		obj30 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void ShowForTweet(UserMatchPredictionModel model)
	{
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0013: Expected O, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_003f: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_015c: Expected I, but got O
		//IL_0192: Expected I, but got O
		//IL_00df: Expected I, but got O
		//IL_00e8: Expected O, but got I4
		//IL_01dd: Expected I, but got O
		//IL_0216: Expected I, but got O
		//IL_0258: Expected I, but got O
		object obj = this + 112;
		UserMatchPredictionModel userMatchPredictionModel = default(UserMatchPredictionModel);
		obj = userMatchPredictionModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X20_v3-8]");
		object obj3 = default(object);
		object obj4 = default(object);
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if ((nint)0 != 0)
		{
			object obj2 = (nint)0 + (nint)2784;
			obj3 = "Picking audio files is not supported on iOS" + 1264;
			obj4 = (nint)0 + (nint)2776;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X20_v3-8]");
			List<object>.Enumerator enumerator = ((List<object>)0).GetEnumerator();
			List<object>.Enumerator enumerator2 = enumerator3;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			TweeterValidationStep tweeterValidationStep = default(TweeterValidationStep);
			while (true)
			{
				userMatchPredictionModel = (UserMatchPredictionModel)obj2;
				if (!enumerator4.MoveNext())
				{
					break;
				}
				if ((object)tweeterValidationStep != null)
				{
					tweeterValidationStep.ResetAllStates();
					if ((object)tweeterValidationStep.inactiveState != null)
					{
						tweeterValidationStep.inactiveState.SetActive(value: true);
						UIExtensions.SetAlpha(tweeterValidationStep.label, 0.7f);
						TextMeshProExtensions.Localize(tweeterValidationStep.label, tweeterValidationStep.defaultText);
						nint num = unchecked((nint)null);
						enumerator2 = (List<object>.Enumerator)1060320051;
						continue;
					}
				}
				goto IL_0277;
			}
			userMatchPredictionModel = (UserMatchPredictionModel)obj4;
			enumerator4.Dispose();
			enumerator5 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			goto IL_0117;
		}
		goto IL_038d;
		IL_0117:
		if ((object)successObject != null)
		{
			successObject.SetActive(value: false);
			bool flag = (object)failObject == null;
			nint num = unchecked((nint)null);
			userMatchPredictionModel = null;
			if (!flag)
			{
				GameObject gameObject = failObject.gameObject;
				bool flag2 = (object)gameObject == null;
				num = unchecked((nint)null);
				userMatchPredictionModel = null;
				if (!flag2)
				{
					gameObject.SetActive(value: false);
					TextMeshProExtensions.Localize(failObject, (string)obj3);
					bool flag3 = (object)tweetAgainButton == null;
					num = unchecked((nint)null);
					userMatchPredictionModel = (UserMatchPredictionModel)obj3;
					if (!flag3)
					{
						GameObject gameObject2 = tweetAgainButton.gameObject;
						bool flag4 = (object)gameObject2 == null;
						num = unchecked((nint)null);
						userMatchPredictionModel = null;
						if (!flag4)
						{
							gameObject2.SetActive(value: false);
							PrepareConnectToTwitter();
							bool flag5 = (object)popup == null;
							num = unchecked((nint)null);
							userMatchPredictionModel = null;
							if (!flag5)
							{
								popup.PopFromCenter();
								return;
							}
						}
					}
				}
			}
		}
		goto IL_038d;
		IL_038d:
		NullReferenceException ex = new NullReferenceException();
		bool flag6 = (nint)userMatchPredictionModel != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			userMatchPredictionModel = (UserMatchPredictionModel)obj4;
			enumerator5.Dispose();
			object obj5 = default(object);
			bool flag7 = obj5 == null;
			enumerator3 = (List<object>.Enumerator)obj5;
			if (flag7)
			{
				goto IL_0117;
			}
			ex2 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223806C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0277:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		goto IL_038d;
	}

	private void PrepareConnectToTwitter()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0061: Expected I, but got O
		//IL_008b: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3328;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		step1.SetProgressState();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private void ConnectToTwitter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)3336;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TwitterRequests.AccessTwitter(action);
	}

	private void OnConnectedToTwitter(bool success)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_008c: Expected I, but got O
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		TweeterValidationStep tweeterValidationStep = step1;
		if (success)
		{
			step1.ResetAllStates();
			tweeterValidationStep.successState.SetActive(value: true);
			UIExtensions.SetAlpha(tweeterValidationStep.label, 1f);
			step2.SetProgressState();
			object obj = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)3312;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
		}
		else
		{
			step1.ResetAllStates();
			tweeterValidationStep.failureState.SetActive(value: true);
			UIExtensions.SetAlpha(tweeterValidationStep.label, 1f);
			GameObject gameObject = failObject.gameObject;
			gameObject.SetActive(value: true);
		}
	}

	private void OnUserFound(string id, string screenName, bool isAccountPrivate)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_02f9: Expected O, but got I4
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_0339: Expected O, but got I4
		//IL_09d3: Expected O, but got I4
		//IL_0a69: Expected O, but got I4
		//IL_0a1f: Expected O, but got I4
		//IL_014f: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_0461: Expected O, but got I4
		//IL_074d: Expected O, but got I
		//IL_075d: Expected O, but got I
		//IL_0773: Expected O, but got I
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected O, but got Unknown
		//IL_079b: Expected O, but got I4
		//IL_07ab: Expected O, but got I
		//IL_019c: Expected O, but got I
		//IL_01b2: Expected O, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_0487: Expected O, but got I4
		//IL_080d: Expected O, but got I
		//IL_081d: Expected O, but got I
		//IL_0833: Expected O, but got I
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		//IL_085b: Expected O, but got I4
		//IL_086b: Expected O, but got I
		//IL_07e5: Expected O, but got I4
		//IL_029f: Expected O, but got I4
		//IL_0222: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_0248: Expected O, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0275: Expected O, but got I
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected O, but got Unknown
		//IL_0ba2: Expected O, but got I4
		//IL_049d: Expected I, but got O
		//IL_04ad: Expected O, but got I
		//IL_04e8: Expected O, but got I
		//IL_08c9: Expected O, but got I
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected O, but got Unknown
		//IL_0de1: Expected O, but got I4
		//IL_0bc8: Expected O, but got I4
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_0e07: Expected O, but got I4
		//IL_0bde: Expected I, but got O
		//IL_0bee: Expected O, but got I
		//IL_0c29: Expected O, but got I
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected O, but got Unknown
		//IL_0e1d: Expected I, but got O
		//IL_0e2d: Expected O, but got I
		//IL_0e68: Expected O, but got I
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Expected O, but got Unknown
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd6: Expected O, but got Unknown
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected O, but got Unknown
		//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f15: Expected O, but got Unknown
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Expected O, but got Unknown
		//IL_0f69: Expected O, but got I
		//IL_0f77: Expected I, but got O
		//IL_0f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8b: Expected O, but got Unknown
		//IL_0fb5: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6508]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v78+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v78+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(id);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		string text = null;
		string text2 = null;
		if (obj5 != null)
		{
			goto IL_00a4;
		}
		goto IL_0351;
		IL_0acb:
		TweeterValidationStep tweeterValidationStep = step2;
		TweeterValidationStep tweeterValidationStep2;
		object obj8;
		object[] array2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		double num;
		string text3;
		if ((object)step2 != null)
		{
			step2.ResetAllStates();
			if ((object)tweeterValidationStep.successState != null)
			{
				tweeterValidationStep.successState.SetActive(value: true);
				UIExtensions.SetAlpha(tweeterValidationStep.label, 1f);
				tweeterValidationStep2 = step2;
				object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object[] array = default(object[]);
				bool flag4 = array == null;
				num = 1.0;
				text3 = null;
				text = (string)1;
				if (!flag4)
				{
					bool flag5 = screenName == null;
					string text4 = (string)1;
					if (!flag5)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
						text4 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						num = 1.0;
						text3 = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						if (flag6)
						{
							goto IL_1005;
						}
					}
					bool flag7 = array.Length == 0;
					num = 1.0;
					text3 = null;
					text = text4;
					if (flag7)
					{
						goto IL_0ff7;
					}
					object obj7 = array + 32;
					obj7 = screenName;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag8 = (object)tweeterValidationStep2 == null;
					num = 1.0;
					text3 = null;
					text = screenName;
					if (!flag8)
					{
						obj8 = "LAK" + 1784;
						num = 1.0;
						array2 = array;
						goto IL_101b;
					}
				}
			}
		}
		goto IL_0fe9;
		IL_0879:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag9 = (object)step2 == null;
		num = 1.0;
		text3 = null;
		text = null;
		if (!flag9)
		{
			goto IL_08b9;
		}
		goto IL_0fe9;
		IL_0212:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X20_v9+38]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v68+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v68+10]");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11 & 1;
		bool flag10 = obj12 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v68+10]");
		object obj13 = 0;
		if (!flag10)
		{
			goto IL_0283;
		}
		goto IL_0879;
		IL_0074:
		bool flag11 = StringsExtensions.IsNullOrEmpty(id);
		bool flag12 = !flag11;
		text = null;
		text2 = null;
		if (!flag12)
		{
			goto IL_00a4;
		}
		goto IL_0351;
		IL_0351:
		bool flag13 = default(bool);
		if (flag13)
		{
			TweeterValidationStep tweeterValidationStep3 = step2;
			bool flag14 = (object)step2 == null;
			text3 = screenName;
			text = text2;
			if (!flag14)
			{
				step2.ResetAllStates();
				bool flag15 = (object)tweeterValidationStep3.failureState == null;
				text3 = screenName;
				text = text2;
				if (!flag15)
				{
					tweeterValidationStep3.failureState.SetActive(value: true);
					UIExtensions.SetAlpha(tweeterValidationStep3.label, 1f);
					TweeterValidationStep tweeterValidationStep4 = step2;
					object obj14 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object[] array3 = default(object[]);
					bool flag16 = array3 == null;
					num = 1.0;
					text3 = null;
					text = (string)1;
					if (!flag16)
					{
						bool flag17 = screenName == null;
						string text5 = (string)1;
						if (!flag17)
						{
							nint num3 = (nint)array3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
							text5 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag18 = ex == null;
							num = 1.0;
							text3 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							if (flag18)
							{
								goto IL_1005;
							}
						}
						bool flag19 = array3.Length == 0;
						num = 1.0;
						text3 = null;
						text = text5;
						if (flag19)
						{
							goto IL_0ff7;
						}
						object obj15 = array3 + 32;
						obj15 = screenName;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag20 = (object)step2 == null;
						num = 1.0;
						text3 = null;
						text = screenName;
						if (!flag20)
						{
							object obj16 = "LAK" + 1776;
							text = (string)obj16;
							TextMeshProExtensions.Localize(tweeterValidationStep4.label, (string)obj16, array3);
							bool flag21 = (object)failObject == null;
							flag13 = false;
							num = 1.0;
							text3 = (string)(object)array3;
							if (!flag21)
							{
								GameObject gameObject = failObject.gameObject;
								bool flag22 = (object)gameObject == null;
								flag13 = false;
								num = 1.0;
								text3 = (string)(object)array3;
								text = null;
								if (!flag22)
								{
									gameObject.SetActive(value: true);
									object text6 = "Picking audio files is not supported on iOS" + 1256;
									TextMeshProExtensions.Localize(failObject, (string)text6);
									return;
								}
							}
						}
					}
				}
			}
			goto IL_0fe9;
		}
		object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v9+E4]");
		string twitterId;
		string value;
		if ((nint)0 != 0)
		{
			twitterId = TwitterRequests.TwitterId;
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v32+E4]");
			bool flag23 = (nint)0 == 0;
			value = twitterId;
			if (!flag23)
			{
				goto IL_06f2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			twitterId = TwitterRequests.TwitterId;
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v32+E4]");
			bool flag24 = (nint)0 == 0;
			object obj20 = !flag24;
			value = twitterId;
			if (obj20 != null)
			{
				goto IL_06f2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag25 = StringsExtensions.IsNullOrEmpty(value);
		bool flag26 = !flag25;
		object obj21 = !flag26;
		string text7 = null;
		text3 = screenName;
		text = null;
		if (obj21 == null)
		{
			goto IL_0a3f;
		}
		goto IL_0acb;
		IL_0283:
		bool flag27 = (object)step2 == null;
		object obj22 = !flag27;
		if (obj22 != null)
		{
			goto IL_08b9;
		}
		num = 1.0;
		text3 = null;
		text = null;
		goto IL_0fe9;
		IL_08b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v123+B8]");
		object obj23 = 0;
		object obj24 = "Error reading data from socket: " + 3256;
		text = (string)obj24;
		TweeterValidationStep tweeterValidationStep5;
		TextMeshProExtensions.Localize(tweeterValidationStep5.label, (string)obj24, (object[])obj23);
		bool flag28 = (object)failObject == null;
		flag13 = false;
		num = 1.0;
		text3 = (string)obj23;
		if (!flag28)
		{
			GameObject gameObject2 = failObject.gameObject;
			bool flag29 = (object)gameObject2 == null;
			flag13 = false;
			num = 1.0;
			text3 = (string)obj23;
			text = null;
			if (!flag29)
			{
				gameObject2.SetActive(value: true);
				return;
			}
		}
		goto IL_0fe9;
		IL_1005:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0ff7:
		ex = new IndexOutOfRangeException();
		goto IL_1005;
		IL_06f2:
		bool flag30 = StringsExtensions.IsNullOrEmpty(twitterId);
		bool flag31 = !flag30;
		text7 = null;
		if (flag31)
		{
			goto IL_0a3f;
		}
		text3 = screenName;
		text = null;
		goto IL_0acb;
		IL_0a3f:
		object obj25 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v33+E4]");
		bool flag32 = (nint)0 == 0;
		object obj26 = !flag32;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string twitterId2 = TwitterRequests.TwitterId;
		bool flag33 = id == twitterId2;
		bool flag34 = !flag33;
		text3 = null;
		text = twitterId2;
		if (!flag34)
		{
			goto IL_0acb;
		}
		TweeterValidationStep tweeterValidationStep6 = step2;
		bool flag35 = (object)step2 == null;
		text3 = null;
		text = twitterId2;
		if (!flag35)
		{
			step2.ResetAllStates();
			bool flag36 = (object)tweeterValidationStep6.inactiveState == null;
			text3 = null;
			text = twitterId2;
			if (!flag36)
			{
				tweeterValidationStep6.inactiveState.SetActive(value: true);
				UIExtensions.SetAlpha(tweeterValidationStep6.label, 1f);
				tweeterValidationStep2 = step2;
				object obj27 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object[] array4 = default(object[]);
				bool flag37 = array4 == null;
				num = 1.0;
				text3 = null;
				text = (string)1;
				if (!flag37)
				{
					bool flag38 = screenName == null;
					string text8 = (string)1;
					if (!flag38)
					{
						nint num4 = (nint)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						text8 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag39 = ex == null;
						num = 1.0;
						text3 = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						if (flag39)
						{
							goto IL_1005;
						}
					}
					bool flag40 = array4.Length == 0;
					num = 1.0;
					text3 = null;
					text = text8;
					if (flag40)
					{
						goto IL_0ff7;
					}
					object obj28 = array4 + 32;
					obj28 = screenName;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag41 = (object)tweeterValidationStep2 == null;
					num = 1.0;
					text3 = null;
					text = screenName;
					if (!flag41)
					{
						obj8 = "LAK" + 1768;
						num = 1.0;
						array2 = array4;
						goto IL_101b;
					}
				}
			}
		}
		goto IL_0fe9;
		IL_0fe9:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0ff7;
		IL_101b:
		text = (string)obj8;
		TextMeshProExtensions.Localize(tweeterValidationStep2.label, (string)obj8, array2);
		bool flag42 = (object)step3 == null;
		flag13 = false;
		text3 = (string)(object)array2;
		if (!flag42)
		{
			step3.SetProgressState();
			object obj29 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj30 = (nint)0 + (nint)3320;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj30);
			object obj31 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v15+E4]");
			bool flag43 = (nint)0 == 0;
			object obj33 = !flag43;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
			return;
		}
		goto IL_0fe9;
		IL_00a4:
		TweeterValidationStep tweeterValidationStep7 = step2;
		bool flag44 = (object)step2 == null;
		text3 = screenName;
		if (!flag44)
		{
			step2.ResetAllStates();
			bool flag45 = (object)tweeterValidationStep7.failureState == null;
			text3 = screenName;
			if (!flag45)
			{
				tweeterValidationStep7.failureState.SetActive(value: true);
				UIExtensions.SetAlpha(tweeterValidationStep7.label, 1f);
				tweeterValidationStep5 = step2;
				object obj34 = (nint)0 + (nint)3232;
				object obj35 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X20_v9+38]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X20_v9+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v51+10]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v51+10]");
					object obj38 = (nint)0 + (nint)309;
					object obj39 = obj38 & 1;
					bool flag46 = obj39 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v51+10]");
					object obj40 = 0;
					if (!flag46)
					{
						goto IL_01ed;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X20_v9+38]");
					object obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v63+10]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v63+10]");
					object obj42 = (nint)0 + (nint)309;
					object obj43 = obj42 & 1;
					bool flag47 = obj43 == null;
					object obj44 = !flag47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v63+10]");
					object obj40 = 0;
					if (obj44 != null)
					{
						goto IL_01ed;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v129+E4]");
				bool flag48 = (nint)0 == 0;
				object obj45 = !flag48;
				if (obj45 != null)
				{
					goto IL_0212;
				}
				goto IL_07f3;
			}
		}
		goto IL_0fe9;
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v129+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0212;
		}
		goto IL_07f3;
		IL_07f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X20_v9+38]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v58+10]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v58+10]");
		object obj47 = (nint)0 + (nint)309;
		object obj48 = obj47 & 1;
		bool flag49 = obj48 == null;
		object obj49 = !flag49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v58+10]");
		obj13 = 0;
		if (obj49 != null)
		{
			goto IL_0283;
		}
		goto IL_0879;
	}

	private void OnFollowingResult(bool isFollowing)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00af: Expected O, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_028d: Expected O, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02fa: Expected I, but got O
		//IL_0329: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		TweeterValidationStep tweeterValidationStep;
		GameObject gameObject;
		if (obj2 != null)
		{
			object obj3 = obj2 + 32;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			tweeterValidationStep = step3;
			if (isFollowing)
			{
				if ((object)step3 != null)
				{
					step3.ResetAllStates();
					gameObject = tweeterValidationStep.successState;
					bool flag = (object)tweeterValidationStep.successState == null;
					object obj4 = !flag;
					if (obj4 != null)
					{
						goto IL_011b;
					}
				}
			}
			else if ((object)step3 != null)
			{
				step3.ResetAllStates();
				gameObject = tweeterValidationStep.inactiveState;
				if ((object)tweeterValidationStep.inactiveState != null)
				{
					goto IL_011b;
				}
			}
		}
		goto IL_035d;
		IL_035d:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_011b:
		gameObject.SetActive(value: true);
		UIExtensions.SetAlpha(tweeterValidationStep.label, 1f);
		if ((object)step4 != null)
		{
			step4.SetProgressState();
			UserMatchPredictionModel model = _model;
			if (_model != null)
			{
				object obj5 = obj2 + 24;
				obj5 = model.<predictionMatch>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = obj5;
				if (obj5 != null)
				{
					object obj7 = typeof(TypeConverter<ushort, char>) + 1952;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					char[] array = default(char[]);
					if (array != null)
					{
						array[0] = ',';
						array[1] = '،';
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+30]");
						if ((nint)0 != 0)
						{
							object obj8 = typeof(SqlSingle[]) + 2376;
							object obj9 = (nint)0 + (nint)968;
							object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+30]");
							string[] array2 = ((string)0).Split(array);
							object obj11 = obj2 + 16;
							obj11 = array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							Action action = default(Action);
							action..ctor(obj2, (IntPtr)obj9);
							object obj12 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v25+E4]");
							bool flag2 = (nint)0 == 0;
							object obj13 = !flag2;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
							return;
						}
					}
				}
			}
		}
		goto IL_035d;
	}

	private void OnTweetFound(bool found)
	{
		//IL_0088: Expected O, but got I4
		TweeterValidationStep tweeterValidationStep = step4;
		GameObject gameObject;
		if (found)
		{
			step4.ResetAllStates();
			tweeterValidationStep.successState.SetActive(value: true);
			UIExtensions.SetAlpha(tweeterValidationStep.label, 1f);
			gameObject = successObject;
			bool flag = (object)successObject == null;
			object obj = !flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			step4.ResetAllStates();
			tweeterValidationStep.failureState.SetActive(value: true);
			UIExtensions.SetAlpha(tweeterValidationStep.label, 1f);
			GameObject gameObject2 = tweetAgainButton.gameObject;
			gameObject2.SetActive(value: true);
			gameObject = failObject.gameObject;
		}
		gameObject.SetActive(value: true);
	}

	private void TryTweetAgain()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		//IL_0043: Expected O, but got I
		object model = this + 112;
		eventsChannel.TriggerShowTweetPreview((UserMatchPredictionModel)model);
		model = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X19_v3-48]");
		((PopupUI)0).ShrinkToParent();
	}

	private void Dismiss()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0034: Expected O, but got I
		object obj = this + 112;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2-48]");
		((PopupUI)0).ShrinkToParent();
	}

	private void <OnConnectedToTwitter>b__15_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_010b: Expected I, but got O
		//IL_01ea: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E650A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		object obj9 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 968;
		object obj10 = (nint)0 + (nint)3360;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		User localUser = sessionModel.LocalUser;
		string userTwitterUserID = SFSKammelnaUserExtensions.GetUserTwitterUserID(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, bool> action = default(Action<object, object, bool>);
		action..ctor((object)this, (IntPtr)obj10);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TwitterRequests.SearchUser(userTwitterUserID, action);
	}

	private void <OnUserFound>b__16_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)3344;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TwitterRequests.CheckFollowingKammelna(action);
	}
}
