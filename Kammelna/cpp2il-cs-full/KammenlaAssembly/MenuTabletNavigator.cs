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
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class MenuTabletNavigator : MonoBehaviour
{
	private sealed class <>c__DisplayClass16_0
	{
		public RoutingCommand command;

		public string commandParam;

		public Action<EditProfilePopup> <>9__3;

		internal void <OnRoute>b__0(TournamentNavigator navigator)
		{
			//IL_0011: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_004c: Expected O, but got I
			//IL_0087: Expected O, but got I
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = (nint)0 + (nint)3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3144;
			object obj4 = default(object);
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v5-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_00c8;
			}
			object obj7 = obj3 + obj6;
			object obj8 = obj7 + 312;
			goto IL_0123;
			IL_00c8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj9 = default(object);
			obj8 = obj9;
			goto IL_0123;
			IL_0123:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v114 @ X8_v9] (should have been resolved before IL gen)");
			navigator.OnRoute(command, commandParam);
		}

		internal void <OnRoute>b__1(PlayerProfile popup)
		{
			popup.Route(command, commandParam);
		}

		internal void <OnRoute>b__2(PlayerProfile p)
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_00ad: Expected O, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e5: Expected O, but got I
			//IL_00f3: Expected I, but got O
			//IL_0126: Expected O, but got I4
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6304]");
			object obj2 = (nint)0 & (nint)1;
			Action<object> callBack;
			if (obj2 != null)
			{
				object obj3 = this + 32;
				callBack = (Action<object>)obj3;
				if (obj3 != null)
				{
					goto IL_006c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = this + 32;
				callBack = (Action<object>)obj3;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_006c;
				}
			}
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)1432;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj6);
			<>9__3 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = (object)p == null;
			object obj7 = !flag2;
			callBack = action;
			if (obj7 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_006c;
			IL_006c:
			p.ShowEditProfile(callBack);
		}

		internal void <OnRoute>b__3(EditProfilePopup edit)
		{
			edit.OnRoute(command, commandParam);
		}
	}

	private const string CLAN_LOAD_ERROR_BODY_KEY = "clan_load_error_body";

	private RoutingEventsChannel _routingEventsChannel;

	private Toggle OfficialTournamentsLeaderboardTab;

	private Toggle RankLeaderboardTab;

	private Toggle OnlinePlayersTab;

	private ComponentReference<TournamentLists> tournamentLists;

	private AssetReferenceGameObject playerProfile;

	private PlayerProfileNavigator playerProfileNavigator;

	private AssetReferenceGameObject friendsCenter;

	private AssetReferenceGameObject friendsAdditions;

	private PopupUI clanView;

	private ClansSerializedUtils clanUtils;

	private Button clansButton;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0169: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0139: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ed: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		_routingEventsChannel.OnRoute += (Action<RoutingCommand, string>)(object)action;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag = clansButton;
			bool flag2 = !flag;
			object obj5 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clansButton;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj5 = 0;
			if (obj6 == null)
			{
				return;
			}
		}
		Button button = clansButton;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)1248;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		button.m_OnClick.AddListener(unityAction);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0169: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0139: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ed: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		_routingEventsChannel.OnRoute -= (Action<RoutingCommand, string>)(object)action;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag = clansButton;
			bool flag2 = !flag;
			object obj5 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clansButton;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj5 = 0;
			if (obj6 == null)
			{
				return;
			}
		}
		Button button = clansButton;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)1248;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		button.m_OnClick.RemoveListener(unityAction);
	}

	private void OnClansButtonClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01b0: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0126: Expected I, but got O
		//IL_0155: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6301]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4599]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4599]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v5+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+38]");
		if ((nint)0 != 1)
		{
			return;
		}
		goto IL_00cb;
		IL_00cb:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1240;
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object message = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v21+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)message, action);
		return;
		IL_008b:
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v15+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v16+38]");
		if ((nint)0 == 1)
		{
			goto IL_00cb;
		}
	}

	private void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_009e: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_0574: Expected O, but got I4
		//IL_0610: Expected O, but got I
		//IL_062a: Expected O, but got I4
		//IL_04fb: Expected O, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_02b1: Expected O, but got I4
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_0676: Expected O, but got I4
		//IL_0209: Expected O, but got I4
		//IL_069f: Expected O, but got I
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		//IL_06f7: Expected O, but got I
		//IL_0774: Expected I, but got O
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_07b2: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = commandParam;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
		IKeyEvaluator keyEvaluator;
		IKeyEvaluator reference;
		if ((nint)0 > (nint)3608)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
			bool flag = (nint)0 < (nint)3701;
			object obj4 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
			object obj5 = -3701;
			bool flag2 = obj5 == null;
			object obj6 = ~obj4;
			object obj7 = obj6 | flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
				if ((nint)0 <= (nint)14001)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
					if ((nint)0 != 14000)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
						if ((nint)0 == 14001)
						{
							clanView.SlideFromBottom();
							clanUtils.OpenClansLeaderboards();
						}
					}
					else
					{
						clanView.SlideFromBottom();
					}
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
				if ((nint)0 != 14002)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
					if ((nint)0 == 14003)
					{
						clanView.SlideFromBottom();
						clanUtils.OpenJoinRequests();
					}
				}
				else
				{
					clanView.SlideFromBottom();
					clanUtils.OpenClanCreation();
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
			if ((nint)0 != 3700)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
				if ((nint)0 != 3701)
				{
					return;
				}
				keyEvaluator = friendsAdditions;
				object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v33+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				reference = friendsAdditions;
				if (obj10 == null)
				{
					goto IL_02c9;
				}
			}
			else
			{
				reference = friendsCenter;
				object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
				object obj9 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v33+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					keyEvaluator = friendsCenter;
					goto IL_02c9;
				}
			}
			goto IL_0754;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
		Toggle toggle;
		if ((nint)0 <= (nint)3401)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
			if ((nint)0 == 3400)
			{
				goto IL_050e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
			if ((nint)0 != 3401)
			{
				goto IL_05fa;
			}
			toggle = OfficialTournamentsLeaderboardTab;
			bool flag5 = (object)OfficialTournamentsLeaderboardTab == null;
			object obj13 = !flag5;
			if (obj13 != null)
			{
				goto IL_051d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
			if ((nint)0 == 3402)
			{
				goto IL_050e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
			if ((nint)0 != 3403)
			{
				goto IL_05fa;
			}
			toggle = RankLeaderboardTab;
			bool flag6 = (object)RankLeaderboardTab == null;
			object obj14 = !flag6;
			if (obj14 != null)
			{
				goto IL_051d;
			}
		}
		throw new NullReferenceException();
		IL_05fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v5-8]");
		object obj15 = -3600;
		bool flag7 = (nint)obj15 < 9;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			object obj17 = typeof(Queue<string>) + 848;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v19+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
			object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = (nint)0 + (nint)1416;
			string userDbID = dbId;
			Action<object> action = default(Action<object>);
			Action<PlayerProfile> callBack = action;
			action..ctor(obj2, (IntPtr)obj22);
			object obj23 = typeof(System.Buffers.Text.ParserHelpers) + 1040;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v9+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfile.ShowDetailProfile(userDbID, TrackingPlacement.Routing, callBack);
		}
		return;
		IL_0754:
		PrefabInitializer.InitializePrefab(reference);
		return;
		IL_050e:
		toggle = OnlinePlayersTab;
		goto IL_051d;
		IL_051d:
		toggle.isOn = true;
		return;
		IL_02c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		reference = keyEvaluator;
		goto IL_0754;
	}

	private void <OnClansButtonClicked>b__15_0()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		PopupUI popupUI = clanView;
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
