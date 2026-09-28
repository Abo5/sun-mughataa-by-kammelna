using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuNavigator : MonoBehaviour
{
	private sealed class <>c__DisplayClass20_0
	{
		public RoutingCommand command;

		public string commandParam;

		public MenuNavigator <>4__this;

		public Action<EditProfilePopup> <>9__3;

		internal void <OnRoute>b__0(PlayerProfile popup)
		{
			popup.Route(command, commandParam);
		}

		internal void <OnRoute>b__1(StoreNavigator navigator)
		{
			MenuNavigator menuNavigator = <>4__this;
			menuNavigator.StoreTab.isOn = true;
			navigator.OnRoute(command, commandParam);
		}

		internal void <OnRoute>b__2(PlayerProfile instance)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62FE]");
			object obj2 = (nint)0 & (nint)1;
			Action<object> callBack;
			if (obj2 != null)
			{
				object obj3 = this + 40;
				callBack = (Action<object>)obj3;
				if (obj3 != null)
				{
					goto IL_006c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = this + 40;
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
			object obj6 = (nint)0 + (nint)1400;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj6);
			<>9__3 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = (object)instance == null;
			object obj7 = !flag2;
			callBack = action;
			if (obj7 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_006c;
			IL_006c:
			instance.ShowEditProfile(callBack);
		}

		internal void <OnRoute>b__3(EditProfilePopup edit)
		{
			edit.OnRoute(command, commandParam);
		}
	}

	private const string CLAN_LOAD_ERROR_BODY_KEY = "clan_load_error_body";

	private RoutingEventsChannel _routingEventsChannel;

	private Toggle HomeTab;

	private Toggle TournamentsListTab;

	private TournamentNavigator tournamentNavigator;

	private Toggle CommunityTab;

	private CommunityNavigator communityNavigator;

	private Toggle ChatTab;

	private Toggle StoreTab;

	private Toggle ClanTab;

	private ClansSerializedUtils clanUtils;

	private ComponentReference<Store> Store;

	private RectTransform storeCanvasLayer;

	private AssetReferenceGameObject playerProfile;

	private PlayerProfileNavigator playerProfileNavigator;

	private AssetReferenceGameObject friendsCenter;

	private AssetReferenceGameObject friendsAdditions;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00ac: Expected I, but got O
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_007b: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute += (Action<RoutingCommand, string>)(object)action;
		Toggle clanTab = ClanTab;
		object obj3 = typeof(TypeConverter<ushort, char>) + 360;
		object obj4 = (nint)0 + (nint)1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj4);
		clanTab.onValueChanged.AddListener(unityAction);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00ac: Expected I, but got O
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_007b: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute -= (Action<RoutingCommand, string>)(object)action;
		Toggle clanTab = ClanTab;
		object obj3 = typeof(TypeConverter<ushort, char>) + 360;
		object obj4 = (nint)0 + (nint)1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj4);
		clanTab.onValueChanged.RemoveListener(unityAction);
	}

	private void OnClanTabToggled(bool isOn)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0056: Expected I, but got O
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		if (!isOn)
		{
			return;
		}
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+38]");
		if ((nint)0 == 1)
		{
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)1216;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj5);
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3728;
			PopupWindow.ShowError((string)message, action);
		}
	}

	private void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_00c0: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_06ce: Expected O, but got I4
		//IL_0673: Expected O, but got I4
		//IL_0237: Expected O, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02d6: Expected O, but got I4
		//IL_0780: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = commandParam;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
		IKeyEvaluator keyEvaluator;
		IKeyEvaluator reference;
		Toggle toggle;
		if ((nint)0 > (nint)3500)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
			bool flag = (nint)0 < (nint)3701;
			object obj5 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
			object obj6 = -3701;
			bool flag2 = obj6 == null;
			object obj7 = ~obj5;
			object obj8 = obj7 | flag2;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
				if ((nint)0 != 3700)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
					if ((nint)0 != 3701)
					{
						return;
					}
					keyEvaluator = friendsAdditions;
					object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v22+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					reference = friendsAdditions;
					if (obj11 == null)
					{
						goto IL_02ee;
					}
				}
				else
				{
					reference = friendsCenter;
					object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
					object obj10 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v22+E4]");
					bool flag4 = (nint)0 == 0;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						keyEvaluator = friendsCenter;
						goto IL_02ee;
					}
				}
				goto IL_07d3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
			if ((nint)0 > (nint)14001)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
				if ((nint)0 != 14002)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
					if ((nint)0 == 14003)
					{
						ClanTab.isOn = true;
						clanUtils.OpenJoinRequests();
					}
				}
				else
				{
					ClanTab.isOn = true;
					clanUtils.OpenClanCreation();
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
			if ((nint)0 != 14000)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
				if ((nint)0 == 14001)
				{
					ClanTab.isOn = true;
					clanUtils.OpenClansLeaderboards();
				}
				return;
			}
			toggle = ClanTab;
			bool flag5 = (object)ClanTab == null;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				goto IL_07b4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
			if ((nint)0 > (nint)3100)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
				object obj15 = (nint)0 & (nint)0x7FFFFFFC;
				if ((nint)obj15 == 3400)
				{
					CommunityTab.isOn = true;
					CommunityNavigator obj16 = communityNavigator;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
					obj16.OnRoute((RoutingCommand)num, (string)0);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
				if ((nint)0 != 3500)
				{
					return;
				}
				toggle = ChatTab;
				bool flag6 = (object)ChatTab == null;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					goto IL_07b4;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
				if ((nint)0 != 3000)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
					if ((nint)0 != 3100)
					{
						return;
					}
				}
				toggle = HomeTab;
			}
		}
		toggle.isOn = true;
		return;
		IL_02ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		reference = keyEvaluator;
		goto IL_07d3;
		IL_07d3:
		PrefabInitializer.InitializePrefab(reference);
		return;
		IL_07b4:
		throw new NullReferenceException();
	}

	private void <OnClanTabToggled>b__19_0()
	{
		HomeTab.isOn = true;
	}
}
