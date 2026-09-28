using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanCard : ListViewItem<ClanCardDataHolder, int>
{
	private sealed class <>c__DisplayClass39_0
	{
		public ClanCard <>4__this;

		public int clanId;

		public Func<UserPendingMembershipModel, bool> <>9__1;

		internal void <RefreshRequestButtons>b__0(List<UserPendingMembershipModel> pending)
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I4
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00dc: Expected O, but got I
			//IL_00ea: Expected I, but got O
			ClanCard clanCard = <>4__this;
			ClanModel model = clanCard.model;
			if (clanCard.model == null || model.ClanId != clanId)
			{
				return;
			}
			if (pending != null)
			{
				object obj = this + 32;
				Func<object, bool> predicate = (Func<object, bool>)obj;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 128;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj4 = (nint)0 + (nint)3360;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor((object)this, (IntPtr)obj4);
					<>9__1 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				bool requestButtons = Enumerable.Any(pending, predicate);
				<>4__this.SetRequestButtons(requestButtons);
			}
			else
			{
				clanCard.SetRequestButtons(hasPendingRequest: false);
			}
		}

		internal bool <RefreshRequestButtons>b__1(UserPendingMembershipModel p)
		{
			//IL_007e: Expected I4, but got O
			//IL_0056: Expected O, but got I4
			if (p != null)
			{
				if (p.ClanId == clanId)
				{
					object obj = p.Direction - 1;
					return obj == null;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string ERROR_TITLE_KEY = "apologies";

	private TextMeshProUGUI title;

	private TextMeshProUGUI userCount;

	private TextMeshProUGUI points;

	private TextMeshProUGUI top10PointsText;

	private TextMeshProUGUI description;

	private TextMeshProUGUI rules;

	private TextMeshProUGUI order;

	private ClanEmblemLoader emblemLoader;

	private ClanTierIcon clanLevelImage;

	private ClanTierIcon clanXpLevelImage;

	private ClansSerializedUtils clanUtils;

	private GameObject joinRequestButton;

	private TextMeshProUGUI joinRequestLabel;

	private GameObject cancelRequestButton;

	private Button showClanProgressPopup;

	private bool autoLoadMyClan;

	private ClanInternalLeaderboardUI clanLeaderboardUI;

	private GameObject visitorExtraContent;

	private string _defaultJoinLabel;

	private string _fullJoinLabel;

	[NonSerialized]
	public ClanModel model;

	private bool IsClanFull
	{
		get
		{
			//IL_00dd: Expected I4, but got O
			//IL_0062: Expected O, but got I4
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected I4, but got Unknown
			ClanModel clanModel = model;
			if (model != null)
			{
				if (clanModel.MaxPlayers >= 1)
				{
					object obj = clanModel.ParticipantCount - clanModel.MaxPlayers;
					bool flag = (nint)obj < 0;
					int num = clanModel.ParticipantCount ^ clanModel.MaxPlayers;
					int num2 = clanModel.ParticipantCount ^ obj;
					int num3 = num & num2;
					bool flag2 = num3 < 0;
					return flag == flag2;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private unsafe void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_019a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022a: Expected O, but got I
		//IL_0238: Expected I, but got O
		//IL_0283: Expected O, but got I4
		//IL_028c: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_029e: Expected O, but got I4
		//IL_02a7: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_031d: Expected O, but got I
		//IL_034e: Expected O, but got Ref
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_03ed: Expected O, but got I
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_0419: Expected I, but got O
		//IL_0448: Expected O, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0386: Expected O, but got I
		//IL_0394: Expected I, but got O
		//IL_03ae: Expected O, but got I
		//IL_03b7: Expected O, but got I4
		//IL_03c0: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86B3]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			obj5 = showClanProgressPopup;
			obj6 = showClanProgressPopup;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = showClanProgressPopup;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = showClanProgressPopup;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		UnityAction unityAction = null;
		UnityAction unityAction2 = null;
		if (flag4)
		{
			goto IL_00cc;
		}
		goto IL_01f1;
		IL_03cd:
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)760;
		object obj10 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
		return;
		IL_0311:
		object obj13 = (nint)0 + (nint)1752;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
		object obj15 = default(object);
		bool flag6 = obj15 == null;
		object obj17 = default(object);
		object obj16 = obj17;
		object obj18 = default(object);
		UnityAction unityAction3 = (UnityAction)(&obj18);
		if (!flag6)
		{
			object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)744;
			UnityAction unityAction4 = default(UnityAction);
			unityAction4..ctor(this, (IntPtr)obj20);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ stack_-38_v4+100]");
			((UnityEvent)0).AddListener(unityAction4);
			obj16 = 0;
			obj14 = 0;
			unityAction3 = unityAction4;
		}
		goto IL_03cd;
		IL_011d:
		UnityEngine.Object obj21;
		bool flag7 = obj21;
		bool flag8 = !flag7;
		object obj22 = !flag8;
		if (obj22 != null)
		{
			goto IL_0311;
		}
		obj16 = obj17;
		unityAction3 = null;
		goto IL_03cd;
		IL_0091:
		bool flag9 = obj5;
		bool flag10 = !flag9;
		object obj23 = !flag10;
		unityAction = null;
		unityAction2 = null;
		if (obj23 == null)
		{
			goto IL_00cc;
		}
		goto IL_01f1;
		IL_01f1:
		Button button = showClanProgressPopup;
		object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)784;
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj25);
		button.m_OnClick.AddListener(unityAction5);
		obj21 = cancelRequestButton;
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v16+E4]");
		bool flag11 = (nint)0 == 0;
		object obj27 = !flag11;
		obj17 = 0;
		obj14 = 0;
		obj16 = 0;
		object obj28 = 0;
		unityAction = unityAction5;
		UnityEngine.Object obj29 = cancelRequestButton;
		if (obj27 != null)
		{
			goto IL_011d;
		}
		goto IL_02c7;
		IL_00cc:
		obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v16+E4]");
		bool flag12 = (nint)0 == 0;
		obj21 = cancelRequestButton;
		obj16 = obj17;
		obj28 = obj14;
		obj29 = cancelRequestButton;
		if (!flag12)
		{
			goto IL_011d;
		}
		goto IL_02c7;
		IL_02c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = obj29;
		bool flag14 = !flag13;
		obj17 = obj16;
		obj14 = obj28;
		unityAction3 = null;
		if (!flag14)
		{
			goto IL_0311;
		}
		goto IL_03cd;
	}

	private void OnConfigChanged()
	{
		if (model != null)
		{
			UpdateUserCount(model);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00fe: Expected I, but got O
		//IL_003d: Expected I, but got O
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_00b0: Expected I, but got O
		//IL_00d6: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 464;
		object obj2 = (nint)0 + (nint)768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, bool> action = default(Action<int, bool>);
		action..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnMyJoinRequestChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, bool> action2 = default(Action<int, bool>);
		action2..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnMyJoinRequestChanged += action2;
		if (autoLoadMyClan)
		{
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
			object obj4 = (nint)0 + (nint)776;
			ReloadMyClan();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action3 = default(Action<object>);
			action3..ctor((object)this, (IntPtr)obj4);
			ClanServerConnector.OnMyMembershipChanged -= action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action4 = default(Action<object>);
			action4..ctor((object)this, (IntPtr)obj4);
			ClanServerConnector.OnMyMembershipChanged += action4;
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_011e: Expected I, but got O
		//IL_0148: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_00d6: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)760;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 464;
		object obj5 = (nint)0 + (nint)768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, bool> action2 = default(Action<int, bool>);
		action2..ctor((object)this, (IntPtr)obj5);
		ClanServerConnector.OnMyJoinRequestChanged -= action2;
		if (autoLoadMyClan)
		{
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
			object obj9 = (nint)0 + (nint)776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action3 = default(Action<object>);
			action3..ctor((object)this, (IntPtr)obj9);
			ClanServerConnector.OnMyMembershipChanged -= action3;
		}
	}

	public unsafe void Initialize(ClanModel clan)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_00a1: Expected I, but got O
		//IL_0102: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_0548: Expected I, but got O
		//IL_054d: Expected I, but got O
		//IL_0181: Expected O, but got I4
		//IL_060b: Expected O, but got I4
		//IL_0610: Expected I, but got O
		//IL_0615: Expected I, but got O
		//IL_0200: Expected O, but got I4
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected I8, but got Unknown
		//IL_06a3: Expected I, but got O
		//IL_06f4: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected I8, but got Unknown
		//IL_079a: Expected I, but got O
		//IL_07eb: Expected O, but got I4
		//IL_02fe: Expected O, but got I4
		//IL_08a0: Expected O, but got I4
		//IL_08a5: Expected I, but got O
		//IL_08aa: Expected I, but got O
		//IL_037d: Expected O, but got I4
		//IL_0965: Expected O, but got I4
		//IL_096a: Expected I, but got O
		//IL_096f: Expected I, but got O
		//IL_0400: Expected O, but got I4
		//IL_0a22: Expected O, but got I4
		//IL_0a27: Expected I, but got O
		//IL_0a2c: Expected I, but got O
		//IL_0483: Expected O, but got I4
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Expected O, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aec: Expected O, but got Unknown
		//IL_0af8: Expected O, but got I
		//IL_0b22: Expected O, but got I4
		//IL_0bc5: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		model = clan;
		object obj2 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = title;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)title)
			{
				goto IL_0088;
			}
		}
		goto IL_00a6;
		IL_0a86:
		object obj5 = clanLeaderboardUI + 72;
		obj5 = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		clanLeaderboardUI.UpdateMyPlace();
		clanLeaderboardUI.UpdateLeaderboard();
		nint num2 = default(nint);
		nint num = num2;
		ClanModel clanModel = clan;
		goto IL_0ad8;
		IL_0460:
		UnityEngine.Object obj6;
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			goto IL_0a86;
		}
		num = num2;
		clanModel = null;
		goto IL_0ad8;
		IL_0088:
		TextMeshProExtensions.FixArabic(title, clan.Name);
		num2 = unchecked((nint)null);
		goto IL_00a6;
		IL_00a6:
		UpdateUserCount(clan);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v9+E4]");
		string text;
		if ((nint)0 != 0)
		{
			bool flag5 = description;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			text = null;
			if (obj9 == null)
			{
				goto IL_0115;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = description;
			bool flag8 = !flag7;
			text = null;
			if (flag8)
			{
				goto IL_0115;
			}
		}
		ClanModel clanModel2 = model;
		text = clanModel2.Description;
		TextMeshProExtensions.FixArabic(description, clanModel2.Description);
		UnityEngine.Object obj10 = rules;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v90+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		num2 = unchecked((nint)null);
		nint num3 = unchecked((nint)null);
		UnityEngine.Object obj13 = rules;
		if (obj12 != null)
		{
			goto IL_015e;
		}
		goto IL_0565;
		IL_0c55:
		UpdateJoinButtonFullState();
		RefreshRequestButtons();
		return;
		IL_0ad8:
		object obj14 = typeof(Queue<string>) + 728;
		object obj15 = (nint)0 + (nint)1976;
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		ClanUserModel myMembership = clanServerConnector.GetMyMembership();
		if (myMembership != null)
		{
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v16+E4]");
		bool flag13;
		if ((nint)0 != 0)
		{
			bool flag11 = visitorExtraContent;
			bool flag12 = !flag11;
			object obj19 = !flag12;
			if (obj19 != null)
			{
				goto IL_0c21;
			}
			flag13 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag14 = visitorExtraContent;
			bool flag15 = !flag14;
			flag13 = false;
			if (!flag15)
			{
				goto IL_0c21;
			}
		}
		goto IL_0c55;
		IL_0c21:
		bool flag16 = ClanModelExtensions.ContainsMe(clan);
		flag13 = (byte)((flag16 ? 1u : 0u) ^ 1u) != 0;
		visitorExtraContent.SetActive(flag13);
		goto IL_0c55;
		IL_0115:
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v90+E4]");
		bool flag17 = (nint)0 == 0;
		obj10 = rules;
		num3 = num2;
		obj13 = rules;
		if (!flag17)
		{
			goto IL_015e;
		}
		goto IL_0565;
		IL_0565:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag18 = obj13;
		bool flag19 = !flag18;
		num2 = num3;
		string text2 = null;
		if (flag19)
		{
			goto IL_0194;
		}
		goto IL_05a7;
		IL_015e:
		bool flag20 = obj10;
		bool flag21 = !flag20;
		object obj20 = !flag21;
		text2 = null;
		if (obj20 == null)
		{
			goto IL_0194;
		}
		goto IL_05a7;
		IL_05a7:
		ClanModel clanModel3 = model;
		text2 = clanModel3.Rules;
		TextMeshProExtensions.FixArabic(rules, clanModel3.Rules);
		UnityEngine.Object obj21 = points;
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v33+E4]");
		bool flag22 = (nint)0 == 0;
		object obj23 = !flag22;
		num2 = unchecked((nint)null);
		nint num4 = unchecked((nint)null);
		UnityEngine.Object obj24 = points;
		if (obj23 != null)
		{
			goto IL_01dd;
		}
		goto IL_062d;
		IL_0194:
		obj21 = points;
		obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v33+E4]");
		bool flag23 = (nint)0 == 0;
		num4 = num2;
		obj24 = points;
		if (!flag23)
		{
			goto IL_01dd;
		}
		goto IL_062d;
		IL_062d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag24 = obj24;
		bool flag25 = !flag24;
		num2 = num4;
		string text3 = null;
		if (flag25)
		{
			goto IL_0213;
		}
		goto IL_066f;
		IL_01dd:
		bool flag26 = obj21;
		bool flag27 = !flag26;
		object obj25 = !flag27;
		text3 = null;
		if (obj25 == null)
		{
			goto IL_0213;
		}
		goto IL_066f;
		IL_066f:
		TextMeshProUGUI textMeshProUGUI = points;
		long num5 = model + 56;
		string text4 = ((long*)num5)->ToString();
		nint num6 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v31 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		num2 = 0;
		textMeshProUGUI.text = text4;
		UnityEngine.Object obj26 = top10PointsText;
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v28+E4]");
		bool flag28 = (nint)0 == 0;
		object obj28 = !flag28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v31 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		nint num7 = 0;
		text3 = text4;
		UnityEngine.Object obj29 = top10PointsText;
		if (obj28 != null)
		{
			goto IL_025c;
		}
		goto IL_0724;
		IL_0213:
		obj26 = top10PointsText;
		obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v28+E4]");
		bool flag29 = (nint)0 == 0;
		num7 = num2;
		obj29 = top10PointsText;
		if (!flag29)
		{
			goto IL_025c;
		}
		goto IL_0724;
		IL_0724:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag30 = obj29;
		bool flag31 = !flag30;
		num2 = num7;
		string text5 = null;
		if (flag31)
		{
			goto IL_0292;
		}
		goto IL_0766;
		IL_025c:
		bool flag32 = obj26;
		bool flag33 = !flag32;
		object obj30 = !flag33;
		text5 = null;
		if (obj30 == null)
		{
			goto IL_0292;
		}
		goto IL_0766;
		IL_0766:
		TextMeshProUGUI textMeshProUGUI2 = top10PointsText;
		long num8 = model + 56;
		string text6 = ((long*)num8)->ToString();
		nint num9 = (nint)textMeshProUGUI2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v26 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		num2 = 0;
		textMeshProUGUI2.text = text6;
		UnityEngine.Object obj31 = emblemLoader;
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v23+E4]");
		bool flag34 = (nint)0 == 0;
		object obj33 = !flag34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v26 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		nint num10 = 0;
		text5 = text6;
		UnityEngine.Object obj34 = emblemLoader;
		if (obj33 != null)
		{
			goto IL_02db;
		}
		goto IL_081b;
		IL_0292:
		obj31 = emblemLoader;
		obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v23+E4]");
		bool flag35 = (nint)0 == 0;
		num10 = num2;
		obj34 = emblemLoader;
		if (!flag35)
		{
			goto IL_02db;
		}
		goto IL_081b;
		IL_081b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag36 = obj34;
		bool flag37 = !flag36;
		num2 = num10;
		ClanModel clanModel4 = null;
		if (flag37)
		{
			goto IL_0311;
		}
		goto IL_085d;
		IL_02db:
		bool flag38 = obj31;
		bool flag39 = !flag38;
		object obj35 = !flag39;
		clanModel4 = null;
		if (obj35 == null)
		{
			goto IL_0311;
		}
		goto IL_085d;
		IL_085d:
		emblemLoader.Load(clan);
		UnityEngine.Object obj36 = clanLevelImage;
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20+E4]");
		bool flag40 = (nint)0 == 0;
		object obj38 = !flag40;
		num2 = unchecked((nint)null);
		nint num11 = unchecked((nint)null);
		clanModel4 = clan;
		UnityEngine.Object obj39 = clanLevelImage;
		if (obj38 != null)
		{
			goto IL_035a;
		}
		goto IL_08ca;
		IL_0311:
		obj36 = clanLevelImage;
		obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20+E4]");
		bool flag41 = (nint)0 == 0;
		num11 = num2;
		obj39 = clanLevelImage;
		if (!flag41)
		{
			goto IL_035a;
		}
		goto IL_08ca;
		IL_08ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag42 = obj39;
		bool flag43 = !flag42;
		num2 = num11;
		int num12 = 0;
		if (flag43)
		{
			goto IL_0394;
		}
		goto IL_0910;
		IL_035a:
		bool flag44 = obj36;
		bool flag45 = !flag44;
		object obj40 = !flag45;
		num12 = 0;
		if (obj40 == null)
		{
			goto IL_0394;
		}
		goto IL_0910;
		IL_0910:
		num12 = clan.ActiveEmblemTier;
		clanLevelImage.SetTier(clan.ActiveEmblemTier);
		UnityEngine.Object obj41 = clanXpLevelImage;
		object obj42 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v17+E4]");
		bool flag46 = (nint)0 == 0;
		object obj43 = !flag46;
		num2 = unchecked((nint)null);
		nint num13 = unchecked((nint)null);
		UnityEngine.Object obj44 = clanXpLevelImage;
		if (obj43 != null)
		{
			goto IL_03dd;
		}
		goto IL_0987;
		IL_0394:
		obj41 = clanXpLevelImage;
		obj42 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v17+E4]");
		bool flag47 = (nint)0 == 0;
		num13 = num2;
		obj44 = clanXpLevelImage;
		if (!flag47)
		{
			goto IL_03dd;
		}
		goto IL_0987;
		IL_0987:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag48 = obj44;
		bool flag49 = !flag48;
		num2 = num13;
		int num14 = 0;
		if (flag49)
		{
			goto IL_0417;
		}
		goto IL_09cd;
		IL_03dd:
		bool flag50 = obj41;
		bool flag51 = !flag50;
		object obj45 = !flag51;
		num14 = 0;
		if (obj45 == null)
		{
			goto IL_0417;
		}
		goto IL_09cd;
		IL_09cd:
		num14 = clan.Tier;
		clanXpLevelImage.SetTier(clan.Tier);
		obj6 = clanLeaderboardUI;
		object obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v14+E4]");
		bool flag52 = (nint)0 == 0;
		object obj47 = !flag52;
		num2 = unchecked((nint)null);
		num = unchecked((nint)null);
		UnityEngine.Object obj48 = clanLeaderboardUI;
		if (obj47 != null)
		{
			goto IL_0460;
		}
		goto IL_0a44;
		IL_0417:
		obj6 = clanLeaderboardUI;
		obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v14+E4]");
		bool flag53 = (nint)0 == 0;
		num = num2;
		obj48 = clanLeaderboardUI;
		if (!flag53)
		{
			goto IL_0460;
		}
		goto IL_0a44;
		IL_0a44:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag54 = obj48;
		bool flag55 = !flag54;
		num2 = num;
		clanModel = null;
		if (!flag55)
		{
			goto IL_0a86;
		}
		goto IL_0ad8;
	}

	public void Initialize(ClanModel clan, int order)
	{
		Initialize(clan);
		int num = default(int);
		string text = num.ToString();
		this.order.text = text;
	}

	public override void Setup(ClanCardDataHolder datum, bool firstTime)
	{
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		ClanModel clan = datum.<Model>k__BackingField;
		Initialize(clan);
	}

	public void OpenClanProfile()
	{
		ClanModel clanModel = model;
		clanUtils.OpenClanInfoPopup(clanModel.ClanId);
	}

	public void OpenClanProgress()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0055: Expected O, but got I4
		//IL_008c: Expected I4, but got I8
		ClanModel clanModel = model;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.ClanProgressViewed(clanModel.Tier);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		clanUtils.OpenClanLockedLevelPopup(model, -1);
	}

	public void RequestJoin()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		ClanModel clanModel = model;
		if (clanModel.MaxPlayers < 1 || clanModel.ParticipantCount < clanModel.MaxPlayers)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			ITrackEvent trackEvent = TrackerLibrary.ClanJoinRequestClicked();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			ClanModel clanModel2 = model;
			ClanJoinRequestFlow.RequestJoinClan(clanModel2.ClanId);
		}
		else
		{
			ShowClanFullError();
		}
	}

	private unsafe void UpdateJoinButtonFullState()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0156: Expected O, but got I
		//IL_029b: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected I4, but got Unknown
		//IL_025c: Expected O, but got I4
		//IL_03ad: Expected O, but got I4
		//IL_03d5: Expected O, but got I
		//IL_039f: Expected O, but got I4
		//IL_0391: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86BA]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj5 = joinRequestButton;
			obj6 = joinRequestButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = joinRequestButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = joinRequestButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj6)
		{
			return;
		}
		goto IL_014a;
		IL_014a:
		object obj8 = (nint)0 + (nint)1752;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
		object obj10 = default(object);
		bool flag3 = obj10 == null;
		Selectable selectable = default(Selectable);
		bool flag4 = (byte)(&selectable) != 0;
		if (!flag3)
		{
			ClanModel clanModel = model;
			if (clanModel.MaxPlayers >= 1)
			{
				object obj11 = clanModel.ParticipantCount - clanModel.MaxPlayers;
				bool flag5 = (nint)obj11 < 0;
				int num = clanModel.ParticipantCount ^ clanModel.MaxPlayers;
				int num2 = clanModel.ParticipantCount ^ obj11;
				int num3 = num & num2;
				bool flag6 = num3 < 0;
				bool flag7 = flag5 == flag6;
				bool flag8 = !flag7;
				bool flag9 = (object)selectable == null;
				object obj12 = !flag9;
				flag4 = flag8;
				if (obj12 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				flag4 = true;
			}
			selectable.interactable = flag4;
			obj9 = 0;
		}
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!joinRequestLabel)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!joinRequestLabel)
			{
				return;
			}
		}
		ClanModel clanModel2 = model;
		if (clanModel2.MaxPlayers >= 1)
		{
			if (clanModel2.ParticipantCount >= clanModel2.MaxPlayers)
			{
				object obj14 = 280;
			}
			else
			{
				object obj14 = 272;
			}
		}
		else
		{
			object obj14 = 272;
		}
		TextMeshProUGUI textMesh = joinRequestLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanCard)+v190 @ X8_v9]");
		TextMeshProExtensions.Localize(textMesh, (string)0);
		return;
		IL_0091:
		bool flag10 = obj5;
		bool flag11 = !flag10;
		object obj15 = !flag11;
		if (obj15 == null)
		{
			return;
		}
		goto IL_014a;
	}

	private static void ShowClanFullError()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_034e: Expected O, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		//IL_00cf: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_0175: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c8: Expected I, but got O
		//IL_01d8: Expected O, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_028c: Expected I, but got O
		//IL_029c: Expected O, but got I
		//IL_02c0: Expected O, but got I4
		//IL_02d8: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86BB]");
		nint num = 0;
		object buttonText = "Network Authentication Required" + 3128;
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)buttonText);
		bool flag = popupWindowBuilder == null;
		object obj = 0;
		object obj7 = default(object);
		object obj10;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag)
		{
			object obj2 = "alignContent" + 1960;
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
			IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			bool flag2 = popupWindowBuilderNeedsBody == null;
			obj = 0;
			num = 13007;
			if (!flag2)
			{
				object obj4 = typeof(System.IOAsyncCallback) + 384;
				nint num2 = (nint)popupWindowBuilderNeedsBody;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0153;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X10_v12-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj7 = obj6 + 16;
					obj5--;
					bool flag3 = (nint)obj5 != 1;
					obj6 = obj7;
					if (flag3)
					{
						continue;
					}
					goto IL_0153;
				}
				object obj8 = num2 + obj6;
				object obj9 = obj8 + 312;
				num = (nint)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v20+8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ X0_v20] (should have been resolved before IL gen)");
				bool flag4 = ex == null;
				object obj11 = !flag4;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v20+8]");
				obj = 0;
				if (obj11 != null)
				{
					goto IL_01ac;
				}
			}
		}
		goto IL_02e6;
		IL_0254:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v13] (should have been resolved before IL gen)");
		return;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj12 = default(object);
		num = (nint)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v17+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v252 @ X0_v17] (should have been resolved before IL gen)");
		bool flag5 = ex == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v17+8]");
		obj = 0;
		if (!flag5)
		{
			goto IL_01ac;
		}
		goto IL_02e6;
		IL_02e6:
		ex = new NullReferenceException();
		goto IL_02f4;
		IL_01ac:
		object obj13 = typeof(System.IOAsyncCallback) + 368;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0254;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v9-8]");
			bool flag6 = 0 == (nint)obj13;
			obj = obj10;
			if (flag6)
			{
				break;
			}
			obj7 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0254;
		}
		goto IL_02f4;
		IL_02f4:
		object obj15 = obj7 + 9;
		object obj16 = num + obj15;
		object obj17 = obj16 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ X8_v5] (should have been resolved before IL gen)");
	}

	public void CancelRequest()
	{
		ClanModel clanModel = model;
		ClanJoinRequestFlow.CancelJoinRequest(clanModel.ClanId);
	}

	private void OnMyMembershipChanged(ClanUserModel membership)
	{
		ReloadMyClan();
	}

	private void OnMyJoinRequestChanged(int clanId, bool hasPendingRequest)
	{
		ClanModel clanModel = model;
		if (model != null && clanModel.ClanId == clanId)
		{
			SetRequestButtons(hasPendingRequest);
		}
	}

	private void ReloadMyClan()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_02b1: Expected O, but got I
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02ea: Expected O, but got I
		//IL_02f8: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86BC]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v21+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v21+E4]");
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
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		if (localUser == null)
		{
			return;
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
		if (clanId < 1)
		{
			return;
		}
		ClanModel clanModel = model;
		if (model == null || clanId != clanModel.ClanId)
		{
			object obj10 = typeof(Queue<string>) + 728;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = (nint)0 + (nint)1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)752;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj15);
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.GetMyClan(action);
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void RefreshRequestButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I
		//IL_020a: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_01b2: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b4: Expected O, but got I
		//IL_02e8: Expected O, but got I4
		//IL_032f: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag = joinRequestButton;
			bool flag2 = !flag;
			object obj6 = 0;
			if (flag2)
			{
				goto IL_0112;
			}
			object obj7 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = joinRequestButton;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj6 = 0;
			object obj7 = 0;
			if (obj8 == null)
			{
				goto IL_0112;
			}
		}
		goto IL_01c0;
		IL_01c0:
		object obj9 = typeof(Queue<string>) + 728;
		object obj10 = (nint)0 + (nint)1976;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		ClanUserModel myMembership = clanServerConnector.GetMyMembership();
		ClanModel clanModel = model;
		if (myMembership == null || myMembership.ClanId != clanModel.ClanId)
		{
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 896;
			object obj14 = (nint)0 + (nint)3352;
			_ = clanModel.ClanId;
			object obj15 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v17+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj14);
			ClanServerConnector clanServerConnector2 = default(ClanServerConnector);
			clanServerConnector2.GetMyPendingMemberships(action);
		}
		return;
		IL_0112:
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v27+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = cancelRequestButton;
			bool flag8 = !flag7;
			object obj18 = !flag8;
			object obj7 = 0;
			if (obj18 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = cancelRequestButton;
			bool flag10 = !flag9;
			object obj7 = 0;
			if (flag10)
			{
				return;
			}
		}
		goto IL_01c0;
	}

	private void SetRequestButtons(bool hasPendingRequest)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86BE]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = joinRequestButton;
			obj6 = joinRequestButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = joinRequestButton;
			obj6 = joinRequestButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01d2;
		IL_0132:
		cancelRequestButton.SetActive(hasPendingRequest);
		return;
		IL_010c:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_0132;
		}
		return;
		IL_023b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0132;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_01d2;
		IL_01d2:
		flag5 = (byte)((hasPendingRequest ? 1u : 0u) ^ 1u) != 0;
		joinRequestButton.SetActive(flag5);
		obj8 = cancelRequestButton;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		obj9 = cancelRequestButton;
		if (obj13 != null)
		{
			goto IL_010c;
		}
		goto IL_023b;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = cancelRequestButton;
		obj9 = cancelRequestButton;
		if (!flag11)
		{
			goto IL_010c;
		}
		goto IL_023b;
	}

	private void UpdateUserCount(ClanModel clan)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017f: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_01c9: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_031d: Expected O, but got I4
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_029b: Expected I, but got O
		//IL_02b5: Expected O, but got I
		//IL_02bd: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86BF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = userCount;
			obj6 = userCount;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = userCount;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = userCount;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_0300:
		int maxPlayers;
		clan.MaxPlayers = maxPlayers;
		object obj10 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "utf-32" + 3752;
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		userCount.text = text;
		UpdateJoinButtonFullState();
		return;
		IL_00c0:
		if (clan.MaxPlayers >= 1)
		{
			object obj11 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format2 = "utf-32" + 3752;
			object arg3 = default(object);
			object arg4 = default(object);
			string text2 = string.Format((string)format2, arg3, arg4);
			userCount.text = text2;
			return;
		}
		object obj12 = typeof(RegisteredWaitHandle) + 56;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v25+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		if (current.<Clans>k__BackingField != null)
		{
			ClanTierConfig tier = current.<Clans>k__BackingField.GetTier(clan.Tier);
			bool flag6 = tier == null;
			nint num = unchecked((nint)null);
			if (!flag6)
			{
				object obj15 = (nint)0 + (nint)3136;
				num = (nint)obj15;
				int? num2 = tier.MaxMembers;
				int num3 = default(int);
				maxPlayers = num3;
				goto IL_0300;
			}
		}
		maxPlayers = 0;
		goto IL_0300;
		IL_0091:
		bool flag7 = obj5;
		bool flag8 = !flag7;
		obj9 = 0;
		if (!flag8)
		{
			goto IL_00c0;
		}
	}

	public ClanCard()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		object defaultJoinLabel = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3096;
		object fullJoinLabel = "The operation is not allowed on non-connected sockets." + 3288;
		_defaultJoinLabel = (string)defaultJoinLabel;
		object obj = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_fullJoinLabel = (string)fullJoinLabel;
		object obj2 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
