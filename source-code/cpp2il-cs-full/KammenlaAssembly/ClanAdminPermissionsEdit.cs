using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanAdminPermissionsEdit : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<bool> <>9__11_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <SaveAndClose>b__11_0(bool b)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0052: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			if (b)
			{
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object message = "October" + 3824;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Toast.Show((string)message, (Vector2)0, 0f);
			}
		}
	}

	private AvatarInitializer avatar;

	private Toggle moderatorToggle;

	private Toggle manageClanToggle;

	private Toggle manageVaultToggle;

	private Toggle manageMembersToggle;

	private Toggle manageActivitiesToggle;

	private Button backButton;

	private ClanUserModel _member;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0107: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86A5]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = backButton;
			obj6 = backButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = backButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = backButton;
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
		IL_00c0:
		Button button = backButton;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)712;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj11);
		button.m_OnClick.AddListener(unityAction);
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		if (!flag6)
		{
			goto IL_00c0;
		}
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0107: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86A6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = backButton;
			obj6 = backButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = backButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = backButton;
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
		IL_00c0:
		Button button = backButton;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)712;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj11);
		button.m_OnClick.RemoveListener(unityAction);
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		if (!flag6)
		{
			goto IL_00c0;
		}
	}

	public void Initialize(ClanUserModel member)
	{
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0066: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_0214: Expected O, but got I
		//IL_02c6: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_034c: Expected O, but got I
		//IL_03fe: Expected O, but got I4
		//IL_03bb: Expected O, but got I4
		//IL_0484: Expected O, but got I
		//IL_0536: Expected O, but got I4
		//IL_04f3: Expected O, but got I4
		//IL_05bc: Expected O, but got I
		//IL_066e: Expected O, but got I4
		//IL_06b0: Expected O, but got I4
		object obj = this + 88;
		obj = member;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AvatarData data = member;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v3-38]");
		((AvatarInitializer)0).Initialize(data);
		ITrackEvent trackEvent = TrackerLibrary.ClanPermissionsViewed();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		ClanUserType clanUserType = ClanUserTypeExtensions.ToUserType(member.Title);
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F1]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 != null)
		{
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v85+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0109;
			}
		}
		else
		{
			_ = 1;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v85+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 != null)
			{
				goto IL_0109;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)moderatorToggle)
		{
			goto IL_01b6;
		}
		goto IL_01e7;
		IL_04ce:
		bool flag3 = manageMembersToggle;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_057b;
		}
		goto IL_058f;
		IL_057b:
		bool isOn;
		manageMembersToggle.isOn = isOn;
		goto IL_058f;
		IL_0443:
		bool isOn2;
		manageVaultToggle.isOn = isOn2;
		goto IL_0457;
		IL_0396:
		bool flag5 = manageVaultToggle;
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 != null)
		{
			goto IL_0443;
		}
		goto IL_0457;
		IL_058f:
		bool isOn3 = ClanPermissionsExtensions.Can(member.Permissions, ClanPermissions.ManageActivities);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F1]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0606;
			}
		}
		else
		{
			_ = 1;
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v27+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			if (obj13 != null)
			{
				goto IL_0606;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag8 = manageActivitiesToggle;
		bool flag9 = !flag8;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			return;
		}
		goto IL_062e;
		IL_0109:
		bool flag10 = moderatorToggle;
		bool flag11 = !flag10;
		object obj15 = !flag11;
		if (obj15 != null)
		{
			goto IL_01b6;
		}
		goto IL_01e7;
		IL_01b6:
		object obj16 = clanUserType - 1;
		bool isOn4 = obj16 == null;
		moderatorToggle.isOn = isOn4;
		goto IL_01e7;
		IL_01e7:
		bool isOn5 = ClanPermissionsExtensions.Can(member.Permissions, ClanPermissions.ManageClan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F1]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			object obj18 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v71+E4]");
			if ((nint)0 != 0)
			{
				goto IL_025e;
			}
		}
		else
		{
			_ = 1;
			object obj18 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v71+E4]");
			bool flag12 = (nint)0 == 0;
			object obj19 = !flag12;
			if (obj19 != null)
			{
				goto IL_025e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)manageClanToggle)
		{
			goto IL_030b;
		}
		goto IL_031f;
		IL_062e:
		manageActivitiesToggle.isOn = isOn3;
		return;
		IL_0606:
		if ((bool)manageActivitiesToggle)
		{
			goto IL_062e;
		}
		return;
		IL_0457:
		isOn = ClanPermissionsExtensions.Can(member.Permissions, ClanPermissions.ManageMembers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F1]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			object obj21 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v43+E4]");
			if ((nint)0 != 0)
			{
				goto IL_04ce;
			}
		}
		else
		{
			_ = 1;
			object obj21 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v43+E4]");
			bool flag13 = (nint)0 == 0;
			object obj22 = !flag13;
			if (obj22 != null)
			{
				goto IL_04ce;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)manageMembersToggle)
		{
			goto IL_057b;
		}
		goto IL_058f;
		IL_025e:
		bool flag14 = manageClanToggle;
		bool flag15 = !flag14;
		object obj23 = !flag15;
		if (obj23 != null)
		{
			goto IL_030b;
		}
		goto IL_031f;
		IL_030b:
		manageClanToggle.isOn = isOn5;
		goto IL_031f;
		IL_031f:
		isOn2 = ClanPermissionsExtensions.Can(member.Permissions, ClanPermissions.ManageVault);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F1]");
		object obj24 = (nint)0 & (nint)1;
		if (obj24 != null)
		{
			object obj25 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v57+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0396;
			}
		}
		else
		{
			_ = 1;
			object obj25 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v57+E4]");
			bool flag16 = (nint)0 == 0;
			object obj26 = !flag16;
			if (obj26 != null)
			{
				goto IL_0396;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)manageVaultToggle)
		{
			goto IL_0443;
		}
		goto IL_0457;
	}

	private void SaveAndClose()
	{
		//IL_037b: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_012b: Expected O, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0189: Expected O, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_029c: Expected O, but got I
		//IL_02ac: Expected O, but got I
		//IL_02ce: Expected O, but got I4
		//IL_0267: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_0220: Expected O, but got I
		//IL_0306: Expected O, but got I4
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_043a: Expected O, but got I
		//IL_044b: Expected I, but got O
		//IL_0469: Expected O, but got I
		//IL_0336: Expected O, but got I
		if (_member == null)
		{
			goto IL_036f;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v9+E4]");
		object obj3;
		object obj4;
		if ((nint)0 != 0)
		{
			bool flag = moderatorToggle;
			bool flag2 = !flag;
			obj3 = 0;
			obj4 = 0;
			if (!flag2)
			{
				goto IL_0080;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = moderatorToggle;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			obj3 = 0;
			obj4 = 0;
			if (obj5 != null)
			{
				goto IL_0080;
			}
		}
		ClanUserType type = ClanUserType.Member;
		goto IL_03d7;
		IL_03d7:
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanAdminData clanAdminData = default(ClanAdminData);
		clanAdminData..ctor();
		string text = ClanUserTypeExtensions.ToRoleTitle(type);
		object obj7 = typeof(Queue<string>) + 728;
		object obj8 = (nint)0 + (nint)1976;
		object obj9 = clanAdminData + 16;
		obj9 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ClanPermissions clanPermissions = ReadPermissions();
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ClanUserModel member = _member;
		object obj12 = typeof(CardUtils.<>c) + 488;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v18+E4]");
		object obj14;
		Action<bool> callback;
		ClanServerConnector clanServerConnector;
		ClanServerConnector clanServerConnector2 = default(ClanServerConnector);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v18+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v6+8]");
			callback = (Action<bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v6+8]");
			bool flag6 = (nint)0 == 0;
			clanServerConnector = clanServerConnector2;
			if (!flag6)
			{
				goto IL_024d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v18+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v6+8]");
			callback = (Action<bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v6+8]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			clanServerConnector = clanServerConnector2;
			if (obj15 != null)
			{
				goto IL_024d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v18+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v25+B8]");
			obj14 = 0;
		}
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)3344;
		Action<bool> action = default(Action<bool>);
		action..ctor(obj14, (IntPtr)obj19);
		object obj20 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v24+B8]");
		object obj21 = (nint)0 + (nint)8;
		obj21 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		callback = action;
		clanServerConnector2 = clanServerConnector;
		goto IL_0350;
		IL_024d:
		bool flag9 = (object)clanServerConnector2 == null;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0350;
		IL_0350:
		clanServerConnector2.UpdateAdminPermissions(member.UserId, clanAdminData, callback);
		goto IL_036f;
		IL_036f:
		object obj23 = (nint)0 + (nint)1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj24 = default(object);
		if (obj24 != null)
		{
			SlideAnimationHelper slideAnimationHelper = default(SlideAnimationHelper);
			slideAnimationHelper.SlideOut();
		}
		return;
		IL_0080:
		Toggle toggle = moderatorToggle;
		type = (toggle.m_IsOn ? ClanUserType.Moderator : ClanUserType.Member);
		obj4 = obj3;
		goto IL_03d7;
	}

	private ClanPermissions ReadPermissions()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_040b: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_0291: Expected O, but got I4
		//IL_0621: Expected I4, but got O
		//IL_0129: Expected O, but got I4
		//IL_04e0: Expected O, but got I4
		//IL_04f1: Expected O, but got I4
		//IL_0313: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_0325: Expected O, but got I4
		//IL_0488: Expected O, but got I4
		//IL_03af: Expected O, but got I4
		//IL_056e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86A8]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v38+E4]");
			bool flag = (nint)0 == 0;
			obj5 = manageClanToggle;
			obj6 = manageClanToggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v38+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = manageClanToggle;
			obj6 = manageClanToggle;
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
		object obj10 = 0;
		if (obj8 != null)
		{
			goto IL_00c9;
		}
		goto IL_0209;
		IL_038c:
		UnityEngine.Object obj11;
		bool flag5 = obj11;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		ClanPermissions clanPermissions2;
		ClanPermissions clanPermissions = clanPermissions2;
		if (obj12 == null)
		{
			goto IL_03c5;
		}
		goto IL_05d3;
		IL_0613:
		NullReferenceException ex = new NullReferenceException();
		return (ClanPermissions)ex;
		IL_04ff:
		Toggle toggle = manageMembersToggle;
		bool flag7;
		object obj16;
		UnityEngine.Object obj17;
		object obj15;
		object obj13;
		if ((object)manageMembersToggle != null)
		{
			clanPermissions2 = ((flag7 | toggle.m_IsOn) ? ClanPermissions.ManageClan : ClanPermissions.None);
			obj11 = manageActivitiesToggle;
			obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v6+E4]");
			bool flag8 = (nint)0 == 0;
			object obj14 = !flag8;
			obj15 = obj16;
			obj17 = manageActivitiesToggle;
			clanPermissions = clanPermissions2;
			if (obj14 != null)
			{
				goto IL_038c;
			}
			goto IL_0596;
		}
		goto IL_0613;
		IL_0091:
		bool flag9 = obj5;
		bool flag10 = !flag9;
		obj9 = 0;
		obj10 = 0;
		if (!flag10)
		{
			goto IL_00c9;
		}
		goto IL_0209;
		IL_0209:
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v18+E4]");
		bool flag11 = (nint)0 == 0;
		UnityEngine.Object obj19 = manageVaultToggle;
		bool flag12 = false;
		UnityEngine.Object obj20 = manageVaultToggle;
		bool flag13 = false;
		if (!flag11)
		{
			goto IL_025c;
		}
		goto IL_03ca;
		IL_00c9:
		Toggle toggle2 = manageClanToggle;
		if ((object)manageClanToggle != null)
		{
			flag12 = toggle2.m_IsOn;
			obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v18+E4]");
			bool flag14 = (nint)0 == 0;
			object obj21 = !flag14;
			obj19 = manageVaultToggle;
			if (obj21 != null)
			{
				goto IL_025c;
			}
			obj20 = manageVaultToggle;
			obj10 = obj9;
			flag13 = toggle2.m_IsOn;
			goto IL_03ca;
		}
		goto IL_0613;
		IL_0596:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj17;
		bool flag16 = !flag15;
		clanPermissions2 = clanPermissions;
		if (flag16)
		{
			goto IL_03c5;
		}
		goto IL_05d3;
		IL_025c:
		bool flag17 = obj19;
		bool flag18 = !flag17;
		object obj22 = !flag18;
		object obj23 = 0;
		object obj24 = 0;
		flag13 = flag12;
		if (obj22 == null)
		{
			goto IL_02a7;
		}
		goto IL_0419;
		IL_03c5:
		return clanPermissions2;
		IL_03ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag19 = obj20;
		bool flag20 = !flag19;
		obj23 = 0;
		flag12 = flag13;
		obj24 = 0;
		if (flag20)
		{
			goto IL_02a7;
		}
		goto IL_0419;
		IL_02a7:
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v12+E4]");
		bool flag21 = (nint)0 == 0;
		UnityEngine.Object obj26 = manageMembersToggle;
		UnityEngine.Object obj27 = manageMembersToggle;
		flag7 = flag12;
		if (!flag21)
		{
			goto IL_02f0;
		}
		goto IL_04b0;
		IL_0419:
		Toggle toggle3 = manageVaultToggle;
		if ((object)manageVaultToggle != null)
		{
			flag12 = flag13 | toggle3.m_IsOn;
			obj26 = manageMembersToggle;
			obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v12+E4]");
			bool flag22 = (nint)0 == 0;
			object obj28 = !flag22;
			obj27 = manageMembersToggle;
			obj23 = obj24;
			flag7 = flag12;
			if (obj28 != null)
			{
				goto IL_02f0;
			}
			goto IL_04b0;
		}
		goto IL_0613;
		IL_05d3:
		Toggle toggle4 = manageActivitiesToggle;
		if ((object)manageActivitiesToggle != null)
		{
			return (ClanPermissions)((int)clanPermissions | (toggle4.m_IsOn ? 1 : 0));
		}
		goto IL_0613;
		IL_02f0:
		bool flag23 = obj26;
		bool flag24 = !flag23;
		object obj29 = !flag24;
		obj15 = 0;
		obj16 = 0;
		flag7 = flag12;
		if (obj29 == null)
		{
			goto IL_033b;
		}
		goto IL_04ff;
		IL_04b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag25 = obj27;
		bool flag26 = !flag25;
		obj15 = 0;
		flag12 = flag7;
		obj16 = 0;
		if (flag26)
		{
			goto IL_033b;
		}
		goto IL_04ff;
		IL_033b:
		obj11 = manageActivitiesToggle;
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v6+E4]");
		bool flag27 = (nint)0 == 0;
		clanPermissions2 = (flag12 ? ClanPermissions.ManageClan : ClanPermissions.None);
		obj17 = manageActivitiesToggle;
		clanPermissions = (flag12 ? ClanPermissions.ManageClan : ClanPermissions.None);
		if (!flag27)
		{
			goto IL_038c;
		}
		goto IL_0596;
	}

	private static void SetToggle(Toggle toggle, bool isOn)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F1]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = toggle;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_009a;
		IL_009a:
		toggle.isOn = isOn;
		return;
		IL_0074:
		if ((bool)toggle)
		{
			goto IL_009a;
		}
	}
}
