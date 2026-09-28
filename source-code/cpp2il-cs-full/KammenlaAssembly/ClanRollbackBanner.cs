using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
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

public class ClanRollbackBanner : MonoBehaviour, IClanLandingWidget
{
	private static bool promptResolved;

	private static RollbackInfoModel cachedPrompt;

	private static ClanRollbackBanner current;

	private GameObject banner;

	private TextMeshProUGUI clanNameText;

	private ClanEmblemLoader emblemLoader;

	private ClanTierIcon tierIcon;

	private TextMeshProUGUI countdownText;

	private Button renewButton;

	private ComponentReference<ClanRollbackConfirmPopup> confirmPopupRef;

	private RollbackInfoModel prompt;

	private float nextCountdownTick;

	private static bool HasClan
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017c: Expected I4, but got O
			//IL_01b4: Expected O, but got I4
			//IL_025a: Expected I4, but got O
			//IL_0225: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87FC]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_024c;
			IL_024c:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0158:
			User localUser = sessionModel.LocalUser;
			bool flag4 = localUser == null;
			bool result = (byte)(int)localUser != 0;
			if (!flag4)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 == null)
				{
					goto IL_024c;
				}
				User localUser2 = sessionModel2.LocalUser;
				int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
				object obj10 = clanId + 1;
				bool flag6 = obj10 == null;
				bool flag7 = !flag6;
				result = flag7;
			}
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag8 = (object)sessionModel == null;
			object obj11 = !flag8;
			if (obj11 != null)
			{
				goto IL_0158;
			}
			goto IL_024c;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0051: Expected I, but got O
		//IL_0080: Expected O, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00b2: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+B8]");
		object obj3 = (nint)0 + (nint)16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Button button = renewButton;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj5 = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj5);
		button.m_OnClick.AddListener(unityAction);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v6+B8]");
		object obj7 = 0;
		if ((nint)obj7 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+8]");
			ShowPrompt((RollbackInfoModel)0);
			return;
		}
		object obj8 = this + 88;
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X19_v3-38]");
		((GameObject)0).SetActive(value: false);
	}

	private void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 88;
		if (obj == null)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		if (!(unscaledTime < nextCountdownTick))
		{
			float unscaledTime2 = Time.unscaledTime;
			float num = unscaledTime2 + 1f;
			nextCountdownTick = num;
			RollbackInfoModel rollbackInfoModel = prompt;
			if (!ClanRollbackCountdown.TryApply(countdownText, rollbackInfoModel.ExpiresAt))
			{
				prompt = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				banner.SetActive(value: false);
			}
		}
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_01b3: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_0235: Expected O, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_027b: Expected O, but got I
		//IL_0293: Expected I, but got O
		//IL_0138: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1360;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87FE]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v15+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X8_v16+10]");
			obj7 = (UnityEngine.Object)0;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X8_v16+10]");
			obj9 = (UnityEngine.Object)0;
			if (!flag)
			{
				goto IL_00c9;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v9+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v10+10]");
			obj7 = (UnityEngine.Object)0;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v10+10]");
			obj9 = (UnityEngine.Object)0;
			if (obj12 != null)
			{
				goto IL_00c9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9 == this;
		bool flag4 = !flag3;
		object obj13 = 0;
		UnityEngine.Object obj14 = this;
		object obj15 = 0;
		if (flag4)
		{
			goto IL_0112;
		}
		goto IL_020e;
		IL_025b:
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj17 = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj17);
		Button button;
		button.m_OnClick.RemoveListener(unityAction);
		return;
		IL_0112:
		button = renewButton;
		bool flag5 = (object)renewButton == null;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_025b;
		IL_020e:
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v5+B8]");
		object obj20 = (nint)0 + (nint)16;
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		button = renewButton;
		obj13 = obj15;
		obj14 = null;
		goto IL_025b;
		IL_00c9:
		bool flag6 = obj7 == this;
		bool flag7 = !flag6;
		object obj21 = !flag7;
		obj13 = 0;
		obj14 = this;
		obj15 = 0;
		if (obj21 == null)
		{
			goto IL_0112;
		}
		goto IL_020e;
	}

	public void Populate(ClanLandingResponseModel landing)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_00a3: Expected O, but got I
		//IL_00b5: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1360;
		object obj2 = obj;
		object obj3 = 1;
		RollbackInfoModel rollbackInfoModel = landing?.Rollback;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = rollbackInfoModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v6+8]");
		ShowPrompt((RollbackInfoModel)0);
	}

	public static void Invalidate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		//IL_003f: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_008b: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1360;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj;
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+B8]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+B8]");
		object obj7 = 0;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+10]");
			if (!((UnityEngine.Object)0 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+10]");
			bool flag = (UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				return;
			}
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v8+10]");
		((ClanRollbackBanner)0).Resolve();
	}

	private void Resolve()
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_001b: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Expected O, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_0107: Expected I, but got O
		//IL_00a5: Expected O, but got I
		object obj = this + 88;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v3-38]");
		((GameObject)0).SetActive(value: false);
		if (!HasClan)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1360;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+B8]");
			object obj4 = 0;
			if ((nint)obj4 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+8]");
				ShowPrompt((RollbackInfoModel)0);
				return;
			}
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 608;
			object obj6 = (nint)0 + (nint)1504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj6);
			KammelnaRequests.GetRollbackPrompt(action);
		}
	}

	private void FetchPrompt()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 608;
		object obj2 = (nint)0 + (nint)1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetRollbackPrompt(action);
	}

	private void ShowPrompt(RollbackInfoModel info)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003b: Expected O, but got I4
		//IL_0060: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_036b: Expected O, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0114: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		//IL_02b1: Expected O, but got I4
		if (info == null || HasClan)
		{
			object obj = this + 88;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X19_v3-38]");
			((GameObject)0).SetActive(value: false);
			return;
		}
		object obj2 = this + 88;
		obj2 = info;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X21_v5-30]");
		TextMeshProExtensions.FixArabic((TextMeshProUGUI)0, info.OriginalName);
		ClanBadgeModel clan = info.Clan;
		ClanEmblemLoader clanEmblemLoader;
		UnityEngine.Object target;
		if (info.Clan != null)
		{
			clanEmblemLoader = emblemLoader;
			object obj3 = 152993792;
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88AF]");
			object obj5 = (nint)0 & (nint)1;
			UnityEngine.Object target2;
			if (obj5 != null)
			{
				clanEmblemLoader._loadedClanId = clan.ClanId;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v25+E4]");
				bool flag = (nint)0 == 0;
				target = clanEmblemLoader.target;
				target2 = clanEmblemLoader.target;
				if (!flag)
				{
					goto IL_018a;
				}
			}
			else
			{
				_ = 1;
				clanEmblemLoader._loadedClanId = clan.ClanId;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v25+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				target = clanEmblemLoader.target;
				target2 = clanEmblemLoader.target;
				if (obj7 != null)
				{
					goto IL_018a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)target2)
			{
				goto IL_0261;
			}
			goto IL_02e4;
		}
		goto IL_030f;
		IL_02e4:
		ClanBadgeModel clan2 = info.Clan;
		tierIcon.SetTier(clan2.Tier);
		goto IL_030f;
		IL_018a:
		bool flag3 = target;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_0261;
		}
		goto IL_02e4;
		IL_0261:
		clanEmblemLoader.ShowPlaceholder(show: true);
		if (clan.Emblem != null)
		{
			bool flag5 = !clanEmblemLoader.retryUntilLoaded;
			object obj9 = !flag5;
			object obj10 = ~obj9;
			int retriesLeft = ((obj10 == null) ? 5 : 0);
			clanEmblemLoader.RequestEmblem(clan.ClanId, clan.Emblem, retriesLeft);
		}
		goto IL_02e4;
		IL_030f:
		banner.SetActive(value: true);
		ITrackEvent trackEvent = TrackerLibrary.ClanRollbackBannerViewed();
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void OpenConfirmPopup()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_008c: Expected O, but got I4
		if (prompt != null)
		{
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1576;
			object obj2 = (nint)0 + (nint)1512;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj4 = (nint)0 + (nint)1960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		}
	}

	private void OnRestored()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_002f: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = (nint)0 + (nint)8;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 88;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X19_v2-38]");
		((GameObject)0).SetActive(value: false);
	}

	private void Hide()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0039: Expected O, but got I
		object obj = this + 88;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2-38]");
		((GameObject)0).SetActive(value: false);
	}

	private void <FetchPrompt>b__20_0(KammelnaResponseModel<RollbackInfoModel> response)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		//IL_0121: Expected O, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0144: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_00ad: Expected O, but got I
		//IL_00bf: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+B8]");
		object obj3 = 0;
		obj3 = 1;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		RollbackInfoModel rollbackInfoModel = ((!((KammelnaResponseModel<object>)(object)response).Succeeded) ? null : response.<Model>k__BackingField);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+B8]");
		object obj6 = (nint)0 + (nint)8;
		obj6 = rollbackInfoModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			if (!(this != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = this != null;
			bool flag2 = !flag;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				return;
			}
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+8]");
		ShowPrompt((RollbackInfoModel)0);
	}

	private void <OpenConfirmPopup>b__22_0(ClanRollbackConfirmPopup popup)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0051: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		popup.Initialize(prompt, action);
	}
}
