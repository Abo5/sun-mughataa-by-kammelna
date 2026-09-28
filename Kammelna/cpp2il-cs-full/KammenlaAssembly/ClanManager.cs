using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanManager : MonoBehaviour
{
	private ClanFeedLoader FeedLoader;

	private Button controlPanelButton;

	private Button memberLeaveButton;

	private TextMeshProUGUI clanTitleText;

	private ClansSerializedUtils clanUtils;

	private ClansDiscoveryPage DiscoveryPage;

	private ClanInfoPanel infoPanel;

	private int testVaultBalance = 5000;

	private ClanModel clanModel;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = controlPanelButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = memberLeaveButton;
		object obj3 = (nint)0 + (nint)1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1472;
		object obj2 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnClanFeedAdded += action;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1472;
		object obj2 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnClanFeedAdded -= action;
	}

	private void Start()
	{
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_077b: Expected O, but got I4
		//IL_0783: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I
		//IL_0102: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_012d: Expected I, but got O
		//IL_006c: Expected O, but got I
		//IL_0153: Expected I, but got O
		//IL_0091: Expected O, but got I
		//IL_009f: Expected I, but got O
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected O, but got Unknown
		//IL_07b1: Expected O, but got I
		//IL_07bd: Expected O, but got I
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07e9: Expected O, but got I
		//IL_07f9: Expected O, but got I
		//IL_018f: Expected O, but got I
		//IL_023a: Expected I, but got O
		//IL_0816: Expected O, but got I
		//IL_0826: Expected O, but got I
		//IL_0218: Expected O, but got I4
		//IL_0263: Expected O, but got I
		//IL_030e: Expected I, but got O
		//IL_0339: Expected I, but got O
		//IL_02ec: Expected O, but got I4
		//IL_035f: Expected I, but got O
		//IL_038a: Expected I, but got O
		//IL_0444: Expected O, but got I4
		//IL_03eb: Expected O, but got I4
		//IL_03f9: Expected O, but got I4
		//IL_046a: Expected I, but got O
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected O, but got Unknown
		//IL_051f: Expected I, but got O
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected O, but got Unknown
		//IL_04fd: Expected O, but got I4
		//IL_0552: Expected O, but got I4
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_0605: Expected O, but got I
		//IL_0613: Expected I, but got O
		//IL_05bd: Expected O, but got I4
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_0679: Expected O, but got I4
		//IL_06bf: Expected I, but got O
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected O, but got Unknown
		//IL_06d2: Expected O, but got I4
		//IL_0729: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		bool flag = clanModel == null;
		object obj2 = !flag;
		IntPtr intPtr = default(IntPtr);
		Action<ClanModel> action = (Action<ClanModel>)(nint)intPtr;
		if (obj2 == null)
		{
			object obj3 = typeof(Queue<string>) + 728;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v116+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)1336;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj7);
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.GetMyClan(action2);
			action = action2;
		}
		object obj8 = (nint)0 + (nint)1360;
		Delegate obj9 = (Delegate)(typeof(SqlSingle[]) + 2376);
		Delegate obj10 = (Delegate)((nint)0 + (nint)1400);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj8);
		ClanServerConnector.OnClanRosterChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj8);
		ClanServerConnector.OnClanRosterChanged += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj10);
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
		object obj13 = (nint)0 + (nint)1384;
		object obj14 = (nint)0 + (nint)1368;
		object obj15 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v8+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v9+20]");
		Delegate obj18 = (Delegate)0;
		Delegate obj25 = default(Delegate);
		Action action6 = default(Action);
		Delegate obj32 = default(Delegate);
		Action<object> action7 = default(Action<object>);
		Action<object> action8 = default(Action<object>);
		Action action9 = default(Action);
		Action action10 = default(Action);
		Action action11 = default(Action);
		Delegate obj40 = default(Delegate);
		Action action12 = default(Action);
		Delegate obj44 = default(Delegate);
		Action<long> action13 = default(Action<long>);
		Delegate obj51 = default(Delegate);
		Delegate obj54 = default(Delegate);
		Action<long> action14 = default(Action<long>);
		object obj59 = default(object);
		Delegate obj61 = default(Delegate);
		while (true)
		{
			Delegate obj19 = Delegate.Remove(obj18, action5);
			if ((object)obj19 != null)
			{
				Delegate obj20 = obj9;
				if ((object)obj19 != obj9)
				{
					object obj21 = 0;
					Delegate obj22 = null;
					goto IL_05d0;
				}
			}
			object obj23 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X9_v8+B8]");
			object obj24 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag3 = (object)obj25 == obj18;
			obj18 = obj25;
			if (!flag3)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action6..ctor(this, (IntPtr)obj10);
			object obj26 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v23+B8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v24+20]");
			Delegate obj28 = (Delegate)0;
			while (true)
			{
				Delegate obj29 = Delegate.Combine(obj28, action6);
				if ((object)obj29 != null)
				{
					Delegate obj20 = obj9;
					if ((object)obj29 != obj9)
					{
						object obj21 = 0;
						Delegate obj22 = null;
						break;
					}
				}
				object obj30 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X9_v13+B8]");
				object obj31 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj32 == obj28;
				obj28 = obj32;
				if (!flag4)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action7..ctor((object)this, (IntPtr)obj13);
				ClanServerConnector.OnMyMembershipChanged -= action7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action8..ctor((object)this, (IntPtr)obj13);
				ClanServerConnector.OnMyMembershipChanged += action8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action9..ctor(this, (IntPtr)obj14);
				CoordinatorService.OnConnected -= action9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action10..ctor(this, (IntPtr)obj14);
				CoordinatorService.OnConnected += action10;
				object obj33 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v75+E4]");
				if ((nint)0 != 0)
				{
					bool flag5 = FeedLoader != null;
					bool flag6 = !flag5;
					object obj34 = !flag6;
					UnityEngine.Object obj35 = null;
					object obj36 = 0;
					if (obj34 == null)
					{
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag7 = FeedLoader != null;
					bool flag8 = !flag7;
					UnityEngine.Object obj35 = null;
					object obj36 = 0;
					if (flag8)
					{
						return;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action11..ctor(this, (IntPtr)obj10);
				object obj37 = FeedLoader + 32;
				Delegate obj38 = (Delegate)obj37;
				while (true)
				{
					Delegate obj39 = Delegate.Remove(obj38, action11);
					if ((object)obj39 != null)
					{
						Delegate obj20 = obj9;
						if ((object)obj39 != obj9)
						{
							object obj21 = 0;
							Delegate obj22 = null;
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag9 = (object)obj40 == obj38;
					obj38 = obj40;
					if (!flag9)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					action12..ctor(this, (IntPtr)obj10);
					object obj41 = FeedLoader + 32;
					Delegate obj42 = (Delegate)obj41;
					while (true)
					{
						Delegate obj43 = Delegate.Combine(obj42, action12);
						object obj21;
						Delegate obj20;
						Delegate obj22;
						if ((object)obj43 != null)
						{
							obj20 = obj9;
							bool flag10 = (object)obj43 == obj9;
							obj21 = 0;
							obj22 = null;
							if (!flag10)
							{
								break;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						bool flag11 = (object)obj44 == obj42;
						obj42 = obj44;
						obj21 = 0;
						obj20 = obj43;
						obj22 = obj44;
						if (!flag11)
						{
							continue;
						}
						object obj45 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj46 = (nint)0 + (nint)1344;
						action13..ctor((object)this, (IntPtr)obj46);
						object obj47 = FeedLoader + 40;
						Delegate obj48 = (Delegate)obj47;
						bool flag13;
						do
						{
							Delegate obj49 = Delegate.Remove(obj48, action13);
							Delegate obj53;
							if ((object)obj49 == null)
							{
								Delegate obj50 = null;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag12 = (object)obj51 == null;
								object obj52 = !flag12;
								Delegate obj50 = obj51;
								if (obj52 == null)
								{
									obj50 = (Delegate)obj45;
									obj53 = null;
									throw new InvalidCastException();
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
							flag13 = (object)obj54 == obj48;
							obj48 = obj54;
							obj53 = obj54;
						}
						while (!flag13);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						action14..ctor((object)this, (IntPtr)obj46);
						object obj55 = FeedLoader + 40;
						Delegate obj56 = (Delegate)obj55;
						bool flag15;
						do
						{
							Delegate obj57 = Delegate.Combine(obj56, action14);
							if ((object)obj57 == null)
							{
								object obj58 = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag14 = obj59 == null;
								object obj60 = !flag14;
								object obj58 = obj59;
								if (obj60 == null)
								{
									throw new InvalidCastException();
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
							flag15 = (object)obj61 == obj56;
							obj56 = obj61;
						}
						while (!flag15);
						return;
					}
					break;
				}
				break;
			}
			goto IL_05d0;
			IL_05d0:
			throw new InvalidCastException();
		}
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_00fb: Expected I, but got O
		//IL_0121: Expected I, but got O
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04c3: Expected O, but got I
		//IL_04cf: Expected O, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04fb: Expected O, but got I
		//IL_050b: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_0208: Expected I, but got O
		//IL_0233: Expected I, but got O
		//IL_01de: Expected O, but got I4
		//IL_02ee: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_02a3: Expected O, but got I4
		//IL_0314: Expected I, but got O
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0347: Expected O, but got I4
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03fa: Expected O, but got I
		//IL_0408: Expected I, but got O
		//IL_03aa: Expected O, but got I4
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_041b: Expected O, but got I4
		//IL_0472: Expected O, but got I4
		Button button = controlPanelButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
		Button button2 = memberLeaveButton;
		object obj3 = (nint)0 + (nint)1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj5 = (nint)0 + (nint)1360;
		Delegate obj6 = (Delegate)(typeof(SqlSingle[]) + 2376);
		Delegate obj7 = (Delegate)((nint)0 + (nint)1400);
		button2.m_OnClick.RemoveListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj5);
		ClanServerConnector.OnClanRosterChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj7);
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
		object obj10 = (nint)0 + (nint)1384;
		object obj11 = (nint)0 + (nint)1368;
		object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj13 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v8+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v9+20]");
		Delegate obj15 = (Delegate)0;
		Delegate obj19 = default(Delegate);
		Action<object> action3 = default(Action<object>);
		Action action4 = default(Action);
		Action action5 = default(Action);
		Delegate obj30 = default(Delegate);
		Action<long> action6 = default(Action<long>);
		object obj37 = default(object);
		Delegate obj39 = default(Delegate);
		while (true)
		{
			Delegate obj16 = Delegate.Remove(obj15, action2);
			if ((object)obj16 == null || (object)obj16 == obj6)
			{
				object obj17 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X9_v8+B8]");
				object obj18 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag = (object)obj19 == obj15;
				obj15 = obj19;
				if (!flag)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action3..ctor((object)this, (IntPtr)obj10);
				ClanServerConnector.OnMyMembershipChanged -= action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action4..ctor(this, (IntPtr)obj11);
				CoordinatorService.OnConnected -= action4;
				object obj20 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v20+E4]");
				if ((nint)0 != 0)
				{
					bool flag2 = FeedLoader != null;
					bool flag3 = !flag2;
					object obj21 = !flag3;
					UnityEngine.Object obj22 = null;
					object obj23 = 0;
					if (obj21 == null)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag4 = FeedLoader != null;
					bool flag5 = !flag4;
					UnityEngine.Object obj22 = null;
					object obj23 = 0;
					if (flag5)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action5..ctor(this, (IntPtr)obj7);
				object obj24 = FeedLoader + 32;
				Delegate obj25 = (Delegate)obj24;
				while (true)
				{
					Delegate obj26 = Delegate.Remove(obj25, action5);
					object obj27;
					Delegate obj28;
					Delegate obj29;
					if ((object)obj26 != null)
					{
						bool flag6 = (object)obj26 == obj6;
						obj27 = 0;
						obj28 = obj6;
						obj29 = null;
						if (!flag6)
						{
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag7 = (object)obj30 == obj25;
					obj25 = obj30;
					obj27 = 0;
					obj28 = obj26;
					obj29 = obj30;
					if (!flag7)
					{
						continue;
					}
					object obj31 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj32 = (nint)0 + (nint)1344;
					action6..ctor((object)this, (IntPtr)obj32);
					object obj33 = FeedLoader + 40;
					Delegate obj34 = (Delegate)obj33;
					bool flag9;
					do
					{
						Delegate obj35 = Delegate.Remove(obj34, action6);
						if ((object)obj35 == null)
						{
							object obj36 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag8 = obj37 == null;
							object obj38 = !flag8;
							object obj36 = obj37;
							if (obj38 == null)
							{
								throw new InvalidCastException();
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						flag9 = (object)obj39 == obj34;
						obj34 = obj39;
					}
					while (!flag9);
					return;
				}
			}
			else
			{
				object obj27 = 0;
				Delegate obj28 = obj6;
				Delegate obj29 = null;
			}
			throw new InvalidCastException();
		}
	}

	public void Initialize(ClanModel model)
	{
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0090: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		object obj = this + 96;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		LoadFeed();
		TextMeshProExtensions.FixArabic(clanTitleText, model.Name);
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		DiscoveryPage.LoadDiscoveryPage();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag = infoPanel != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				goto IL_009f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(infoPanel != null))
			{
				goto IL_009f;
			}
		}
		infoPanel.Initialize(model);
		int tier = model.Tier;
		bool flag3 = ClanTierCelebration.TryClaim(model.ClanId, model.Tier);
		bool flag4 = !flag3;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00e0;
		IL_00e0:
		clanUtils.OpenClanNextLevelPopup(tier);
		return;
		IL_009f:
		tier = model.Tier;
		if (ClanTierCelebration.TryClaim(model.ClanId, model.Tier))
		{
			goto IL_00e0;
		}
	}

	public void LoadFeed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009a: Expected O, but got I
		//IL_00c4: Expected O, but got I4
		//IL_0054: Expected I, but got O
		//IL_006d: Expected O, but got I4
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 736;
		object obj4 = (nint)0 + (nint)1072;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)FeedLoader, (IntPtr)obj4);
		((ClanServerConnector)(object)action).GetClanFeed(50, (long?)(object)0, (Action<List<ClanFeedModel>>)null);
	}

	public void LoadDiscoveryPage()
	{
		DiscoveryPage.LoadDiscoveryPage();
	}

	public void LoadInfoPanel()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0055: Expected O, but got I4
		//IL_007e: Expected O, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0159: Expected O, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0179: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_00ef: Expected I, but got O
		//IL_0105: Expected O, but got I
		ClanModel clanModel = this.clanModel;
		if (this.clanModel != null)
		{
			int clanId = clanModel.ClanId;
		}
		else
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			int clanId2 = SFSKammelnaUserExtensions.GetClanId(localUser);
			int clanId = clanId2;
		}
		object obj5 = typeof(Queue<string>) + 728;
		object obj6 = (nint)0 + (nint)1976;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj8 = (nint)0 + (nint)1328;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj8);
		object obj11 = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1FBC");
	}

	public void LoadVaultPanel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I
		//IL_0117: Expected O, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)280;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE940C");
		UnityEngine.Object obj5 = default(UnityEngine.Object);
		if (obj5 == null)
		{
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj7 = "WhiteSmoke" + 2880;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				KLogger.LogWarning(obj7);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KLogger.LogWarning(obj7);
		}
		else
		{
			((ClanVaultPanel)obj5).Initialize(testVaultBalance);
		}
	}

	public void ResetPendingRequestsSeen()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_00b0: Expected O, but got I
		//IL_0044: Expected O, but got I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_017d: Expected O, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019d: Expected O, but got I
		//IL_01c7: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_012a: Expected I, but got O
		string key = ClanRequestsBadge.WatermarkKey();
		Prefs.DeleteKey(key);
		Prefs.Save();
		ClanModel clanModel = this.clanModel;
		int clanId;
		if (this.clanModel != null)
		{
			clanId = clanModel.ClanId;
			object obj = 0;
		}
		else
		{
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			int clanId2 = SFSKammelnaUserExtensions.GetClanId(localUser);
			object obj = 0;
			clanId = clanId2;
		}
		object obj6 = typeof(Queue<string>) + 728;
		object obj7 = (nint)0 + (nint)1976;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 256;
		object obj9 = (nint)0 + (nint)1496;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj9);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetJoinRequests(clanId, action);
	}

	public void OpenControlPanel()
	{
		clanUtils.OpenClanControlPanel(clanModel);
	}

	private void SimulateTierUpgrade()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		ClanModel clanModel = this.clanModel;
		if (this.clanModel != null && clanModel.Tier >= 2)
		{
			object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3488;
			int num = default(int);
			string text = num.ToString();
			string key = (string)obj + text;
			Prefs.DeleteKey(key);
			Prefs.Save();
			ClanModel clanModel2 = this.clanModel;
			int tier = clanModel2.Tier - 1;
			bool flag = ClanTierCelebration.TryClaim(clanModel2.ClanId, tier);
			ClanModel clanModel3 = this.clanModel;
			if (ClanTierCelebration.TryClaim(clanModel3.ClanId, clanModel3.Tier))
			{
				clanUtils.OpenClanNextLevelPopup(clanModel3.Tier);
			}
		}
	}

	private void LoadOlderFeed(long beforeId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0086: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_0061: Expected I, but got O
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = (nint)0 + (nint)3184;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 736;
		object obj5 = (nint)0 + (nint)1032;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		long? beforeId2 = beforeId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)FeedLoader, (IntPtr)obj5);
		((ClanServerConnector)(object)action).GetClanFeed(50, beforeId2, (Action<List<ClanFeedModel>>)null);
	}

	private void OnCoordinatorConnected()
	{
		if (clanModel != null)
		{
			LoadFeed();
		}
	}

	private void OnClanFeedAdded(ClanFeedModel feed)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		if (feed == null)
		{
			return;
		}
		ClanFeedData data = feed.Data;
		if (feed.Data == null)
		{
			return;
		}
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1384;
		object obj2 = obj;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v4+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v4+130]");
		object obj5 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v4-8]");
		if (0 != (nint)obj2)
		{
			return;
		}
		ClanModel clanModel = this.clanModel;
		if (this.clanModel != null)
		{
			int clanId = clanModel.ClanId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
			if (ClanTierCelebration.TryClaim(clanId, 0))
			{
				ClansSerializedUtils clansSerializedUtils = clanUtils;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
				clansSerializedUtils.OpenClanNextLevelPopup(0);
			}
		}
	}

	private void CelebrateTierIfUpgraded(ClanModel clan)
	{
		if (clan != null && ClanTierCelebration.TryClaim(clan.ClanId, clan.Tier))
		{
			clanUtils.OpenClanNextLevelPopup(clan.Tier);
		}
	}

	private void TryCelebrateTier(int clanId, int tier)
	{
		if (ClanTierCelebration.TryClaim(clanId, tier))
		{
			clanUtils.OpenClanNextLevelPopup(tier);
		}
	}

	private void ReloadFeedIfReady()
	{
		if (clanModel != null)
		{
			LoadFeed();
		}
	}

	private void OnMyMembershipChanged(ClanUserModel membership)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0158: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a6: Expected I, but got O
		//IL_01b6: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		if (membership != null)
		{
			ClanModel clanModel = this.clanModel;
			if (this.clanModel != null && membership.ClanId == clanModel.ClanId)
			{
				return;
			}
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v3+E4]");
		object obj4;
		if ((nint)0 != 0)
		{
			bool flag = FeedLoader != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			obj4 = 0;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (obj3 == null)
			{
				goto IL_00e1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = FeedLoader != null;
			bool flag4 = !flag3;
			obj4 = 0;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (flag4)
			{
				goto IL_00e1;
			}
		}
		ClanFeedLoader feedLoader = FeedLoader;
		object obj7 = typeof(List<AdaptivePerformanceScaler>) + 528;
		ClanFeedListView listView = feedLoader.listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		nint num = (nint)listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v12 (Il2CppClass<ClanFeedListView>)+2B0]");
		obj4 = 0;
		listView.data = (List<ClanFeedEventDataHolder>)(object)list;
		bool flag5 = membership == null;
		object obj8 = !flag5;
		if (obj8 != null)
		{
			goto IL_00fe;
		}
		goto IL_01ec;
		IL_01ec:
		this.clanModel = null;
		object obj9 = this + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00e1:
		if (membership != null)
		{
			goto IL_00fe;
		}
		goto IL_01ec;
		IL_00fe:
		if (this.clanModel != null)
		{
			LoadFeed();
		}
	}

	private void OnClanRosterChanged(ClanModel clan)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0050: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		if (clan == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 96;
		obj2 = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v5-28]");
		TextMeshProExtensions.FixArabic((TextMeshProUGUI)0, clan.Name);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v5-10]");
			bool flag = (UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				goto IL_00bd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v5-10]");
			if (!((UnityEngine.Object)0 != null))
			{
				goto IL_00bd;
			}
		}
		infoPanel.Initialize(clan);
		int tier = clan.Tier;
		bool flag3 = ClanTierCelebration.TryClaim(clan.ClanId, clan.Tier);
		bool flag4 = !flag3;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00fe;
		IL_00bd:
		tier = clan.Tier;
		if (ClanTierCelebration.TryClaim(clan.ClanId, clan.Tier))
		{
			goto IL_00fe;
		}
		return;
		IL_00fe:
		clanUtils.OpenClanNextLevelPopup(tier);
	}

	private void ShowClanTitle(ClanModel m)
	{
		TextMeshProExtensions.FixArabic(clanTitleText, m.Name);
	}

	private void OnLeaveClicked()
	{
		ClanLeaveFlow.Run(clanUtils, clanModel);
	}

	private void <Start>b__12_0(ClanModel clan)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87CC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this != null;
		if (clan != null)
		{
			goto IL_0123;
		}
		return;
		IL_0123:
		if (flag2)
		{
			Initialize(clan);
		}
		return;
		IL_0074:
		flag2 = this != null;
		bool flag3 = clan == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_0123;
	}

	private void <LoadInfoPanel>b__17_0(ClanModel clan)
	{
		if (clan != null)
		{
			infoPanel.Initialize(clan);
		}
	}
}
