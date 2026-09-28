using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Purchasing.Telemetry;

public class ClansSerializedUtils : ScriptableObject
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<ClansBrowser> <>9__23_0;

		public static Action<CreateClanPopup> <>9__24_0;

		public static Action<SlideAnimationHelper> <>9__35_0;

		public static Action<PopupUI> <>9__40_0;

		public static Action<PopupUI> <>9__41_0;

		public static Action<ClanAnnouncementCreator> <>9__42_0;

		public static Action<CreateGamePopup> <>9__43_0;

		public static Action<TournamentCreationPopup> <>9__44_0;

		public static Action<AddFundsToClanPopup> <>9__46_0;

		public static Action<AddFundsToClanPopup> <>9__47_0;

		public static Action<RequestFundsPopup> <>9__48_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OpenClansPage>b__23_0(ClansBrowser c)
		{
			c.Initialize();
		}

		internal void <OpenClanCreation>b__24_0(CreateClanPopup c)
		{
			c.Initialize();
		}

		internal void <OpenClansLeaderboards>b__35_0(SlideAnimationHelper helper)
		{
			helper.SlideIn();
		}

		internal void <OpenCreateActivitiesPopup>b__40_0(PopupUI popupUI)
		{
			popupUI.SlideFromBottom();
		}

		internal void <OpenCreateActivitiesFromChatPopup>b__41_0(PopupUI popupUI)
		{
			popupUI.SlideFromBottom();
		}

		internal void <OpenCreateAnnouncementActivityPopup>b__42_0(ClanAnnouncementCreator creator)
		{
			creator.Open();
		}

		internal void <OpenCreateRoom>b__43_0(CreateGamePopup popup)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8964]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
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
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
			popup.Popup(isVoiceChatVersion: false, 0, clanId);
			return;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0133;
		}

		internal void <OpenCreateTournament>b__44_0(TournamentCreationPopup popup)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8965]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
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
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
			popup.Initialize(TournamentType.Private, clanId);
			return;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0133;
		}

		internal void <OpenAddFundsPopup>b__46_0(AddFundsToClanPopup popup)
		{
			//IL_0011: Expected O, but got I
			object obj = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI popupUI = default(PopupUI);
			popupUI.PopFromCenter();
		}

		internal void <OpenAddFundsBottomSheet>b__47_0(AddFundsToClanPopup popup)
		{
			//IL_0011: Expected O, but got I
			object obj = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI popupUI = default(PopupUI);
			popupUI.SlideFromBottom();
		}

		internal void <OpenRequestFundsPopup>b__48_0(RequestFundsPopup popup)
		{
			//IL_0011: Expected O, but got I
			object obj = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI popupUI = default(PopupUI);
			popupUI.PopFromCenter();
		}
	}

	private sealed class <>c__DisplayClass26_0
	{
		public ClanModel model;

		internal void <OpenClanView>b__0(ClanManager c)
		{
			c.Initialize(model);
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public ClanModel model;

		internal void <OpenClanInfoPopup>b__0(ClanInfoPopup c)
		{
			c.Initialize(model);
		}
	}

	private sealed class <>c__DisplayClass30_0
	{
		public ClanModel model;

		internal void <OpenClanCardInfoPopup>b__0(ClanCardPopup c)
		{
			c.Initialize(model);
		}
	}

	private sealed class <>c__DisplayClass31_0
	{
		public ClanModel model;

		public int tier;

		internal void <OpenClanLockedLevelPopup>b__0(ClanLockedLevelPopup c)
		{
			c.Initialize(model, tier);
		}
	}

	private sealed class <>c__DisplayClass32_0
	{
		public int clanId;

		public int tier;

		internal void <OpenClanUnlockEmblemPopup>b__0(ClanUnlockEmblemPopup c)
		{
			c.Initialize(clanId, tier);
		}
	}

	private sealed class <>c__DisplayClass33_0
	{
		public int tier;

		internal void <OpenClanNextLevelPopup>b__0(ClanNextLevelAchievementPopup c)
		{
			c.Initialize(tier);
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public ClanUserModel member;

		internal void <OpenClanAdminPermissionsPage>b__0(ClanAdminPermissionsEdit c)
		{
			c.Initialize(member);
		}
	}

	private sealed class <>c__DisplayClass36_0
	{
		public ClanModel model;

		internal void <OpenClanControlPanel>b__0(ClanControlPanel c)
		{
			c.Initialize(model);
		}
	}

	private sealed class <>c__DisplayClass38_0
	{
		public Action<ClanModel> onTransferred;

		internal void <OpenClanTransferOwnershipPopup>b__0(TransferOwnershipPanel c)
		{
			c.Initialize(onTransferred);
		}
	}

	private sealed class <>c__DisplayClass39_0
	{
		public Action onLeft;

		public Action<ClanModel> onClanRefreshed;

		internal void <OpenLeaveClanPopup>b__0(LeaveClanPanel c)
		{
			c.Initialize(onLeft, onClanRefreshed);
		}
	}

	private sealed class <>c__DisplayClass49_0
	{
		public long feedId;

		internal void <OpenVaultSupportersPopup>b__0(VaultSupportersPopup popup)
		{
			//IL_0011: Expected O, but got I
			object obj = (nint)0 + (nint)4008;
			popup.Initialize(feedId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI popupUI = default(PopupUI);
			popupUI.SlideFromBottom();
		}
	}

	private ComponentReference<ClansBrowser> clansViewLoaderRef;

	private ComponentReference<CreateClanPopup> clanCreatorRef;

	private ComponentReference<ClanManager> clanManagerRef;

	private ComponentReference<ClanAdminPermissionsEdit> adminPermissionsRef;

	private ComponentReference<SlideAnimationHelper> clansLeaderboards;

	private ComponentReference<ClanControlPanel> controlPanelRef;

	private AssetReferenceGameObject joinRequestsRef;

	private ComponentReference<TransferOwnershipPanel> transferOwnershipPopupRef;

	private ComponentReference<LeaveClanPanel> leaveClanPopupRef;

	private ComponentReference<ClanInfoPopup> clanInfoPopupRef;

	private ComponentReference<ClanCardPopup> clanCardInfoPopupRef;

	private ComponentReference<ClanLockedLevelPopup> clanLockedLevelPopupRef;

	private ComponentReference<ClanUnlockEmblemPopup> clanUnlockEmblemPopupRef;

	private ComponentReference<ClanNextLevelAchievementPopup> clanNextLevelPopupRef;

	private ComponentReference<AddFundsToClanPopup> addFundsPopup;

	private ComponentReference<AddFundsToClanPopup> addFundsBottomSheet;

	private ComponentReference<RequestFundsPopup> requestFundsPopup;

	private ComponentReference<VaultSupportersPopup> vaultSupportersPopupRef;

	private ComponentReference<PopupUI> _createActivitiesPickerPopupRef;

	private ComponentReference<PopupUI> _createActivitiesPickerPopupFromChatRef;

	private ComponentReference<ClanAnnouncementCreator> _createAnnouncementPopupRef;

	private ComponentReference<CreateGamePopup> createGamePopupRef;

	private ComponentReference<TournamentCreationPopup> createTournamentPopupRef;

	public void OpenClansPage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8948]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<ClansBrowser> componentReference2;
		object obj4;
		ComponentReference<ClansBrowser> componentReference;
		if (obj3 != null)
		{
			componentReference = clansViewLoaderRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = clansViewLoaderRef;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = clansViewLoaderRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = clansViewLoaderRef;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)1984;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)912;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)1984;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OpenClanCreation()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8949]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<CreateClanPopup> componentReference2;
		object obj4;
		ComponentReference<CreateClanPopup> componentReference;
		if (obj3 != null)
		{
			componentReference = clanCreatorRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = clanCreatorRef;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = clanCreatorRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = clanCreatorRef;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+10]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2008;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+10]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+10]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)896;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)16;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2008;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OpenClanView(int clanId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj4 = (nint)0 + (nint)1776;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClan(clanId, action);
	}

	public void OpenClanView(ClanModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_0118: Expected I, but got O
		//IL_0142: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = obj2 + 16;
		obj5 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1536;
		object obj9 = (nint)0 + (nint)968;
		object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj11 = (nint)0 + (nint)1944;
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.ConnectToClan();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj9);
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void OpenClanInfoPopup(int clanId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj4 = (nint)0 + (nint)1768;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClan(clanId, action);
	}

	public void OpenClanInfoPopup(ClanModel model)
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
		object obj = typeof(CardUtils.<>c) + 1632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1496;
		object obj4 = (nint)0 + (nint)976;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1920;
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

	public void OpenClanCardInfoPopup(int clanId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj4 = (nint)0 + (nint)1760;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClan(clanId, action);
	}

	public void OpenClanCardInfoPopup(ClanModel model)
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
		object obj = typeof(CardUtils.<>c) + 1640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1440;
		object obj4 = (nint)0 + (nint)984;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1904;
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

	public void OpenClanLockedLevelPopup(ClanModel model, int tier = -1)
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
		//IL_009e: Expected I, but got O
		//IL_00c8: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1512;
		object obj4 = (nint)0 + (nint)992;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1928;
		object obj7 = obj2 + 16;
		obj7 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void OpenClanUnlockEmblemPopup(int clanId, int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_007e: Expected I, but got O
		//IL_00ad: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1616;
		object obj4 = (nint)0 + (nint)1000;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void OpenClanNextLevelPopup(int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0079: Expected I, but got O
		//IL_00a8: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1560;
		object obj4 = (nint)0 + (nint)1008;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void OpenClanAdminPermissionsPage(ClanUserModel member)
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
		object obj = typeof(CardUtils.<>c) + 1672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1424;
		object obj4 = (nint)0 + (nint)1016;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1880;
		object obj7 = obj2 + 16;
		obj7 = member;
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

	public void OpenClansLeaderboards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03a4: Expected O, but got I
		//IL_03b5: Expected I, but got O
		//IL_03d3: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02d3: Expected O, but got I4
		//IL_0298: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		ITrackEvent trackEvent = TrackerLibrary.ClanInternalLeaderboardViewed();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		ComponentReference<SlideAnimationHelper> componentReference2;
		object obj4;
		Action<object> action2;
		ComponentReference<SlideAnimationHelper> componentReference;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			componentReference = clansLeaderboards;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = clansLeaderboards;
			if (!flag)
			{
				goto IL_0075;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			componentReference = clansLeaderboards;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = clansLeaderboards;
			if (obj6 != null)
			{
				goto IL_0075;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+18]");
		Action<object> action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+18]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		action = action2;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_00e6:
		object obj11 = (nint)0 + (nint)2344;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		Action<object> action4 = action3;
		object obj13 = obj11;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0137;
		}
		goto IL_0309;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action3 = action4;
		obj11 = obj13;
		componentReference = componentReference2;
		goto IL_0137;
		IL_0137:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0075:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+18]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+18]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		action2 = action;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)904;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11+B8]");
		object obj19 = (nint)0 + (nint)24;
		obj19 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2344;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v4+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action3 = action5;
		componentReference = componentReference2;
		action = action5;
		action4 = action5;
		obj13 = obj11;
		if (obj20 != null)
		{
			goto IL_0137;
		}
		goto IL_0309;
	}

	public void OpenClanControlPanel(ClanModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_0170: Expected I, but got O
		//IL_0100: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1448;
		object obj5 = (nint)0 + (nint)1024;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ITrackEvent trackEvent = TrackerLibrary.ClanControlPanelViewed();
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)1912;
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void OpenJoinRequests()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_0179: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01c2: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		//IL_00ee: Expected I, but got O
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0219: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_012e: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8956]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
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
			object obj4 = (nint)0 + (nint)1976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
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
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		bool flag3 = (object)clanServerConnector == null;
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
		ClanUserModel myMembership = clanServerConnector.GetMyMembership();
		if (myMembership == null)
		{
			return;
		}
		bool flag4 = !myMembership.IsOwner;
		object obj9 = !flag4;
		nint num = unchecked((nint)null);
		if (obj9 == null)
		{
			object obj10 = myMembership.Permissions & ClanPermissions.ManageMembers;
			bool flag5 = obj10 == null;
			object obj11 = !flag5;
			num = unchecked((nint)null);
			if (obj11 == null)
			{
				return;
			}
		}
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v2+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(joinRequestsRef, CanvasLayer.SecondaryCanvas);
	}

	public void OpenClanTransferOwnershipPopup(Action<ClanModel> onTransferred)
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
		object obj = typeof(CardUtils.<>c) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3848;
		object obj4 = (nint)0 + (nint)1032;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2432;
		object obj7 = obj2 + 16;
		obj7 = onTransferred;
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

	public void OpenLeaveClanPopup(Action onLeft = null, Action<ClanModel> onClanRefreshed = null)
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
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00e8: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2544;
		object obj4 = (nint)0 + (nint)1040;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2096;
		object obj7 = obj2 + 16;
		obj7 = onLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = onClanRefreshed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void OpenCreateActivitiesPopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8959]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<PopupUI> componentReference2;
		object obj4;
		ComponentReference<PopupUI> componentReference;
		if (obj3 != null)
		{
			componentReference = _createActivitiesPickerPopupRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = _createActivitiesPickerPopupRef;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = _createActivitiesPickerPopupRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = _createActivitiesPickerPopupRef;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+20]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+20]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2240;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+20]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+20]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)928;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)32;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2240;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OpenCreateActivitiesFromChatPopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E895A]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<PopupUI> componentReference2;
		object obj4;
		ComponentReference<PopupUI> componentReference;
		if (obj3 != null)
		{
			componentReference = _createActivitiesPickerPopupFromChatRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = _createActivitiesPickerPopupFromChatRef;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = _createActivitiesPickerPopupFromChatRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = _createActivitiesPickerPopupFromChatRef;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+28]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+28]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2240;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+28]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+28]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)920;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)40;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2240;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OpenCreateAnnouncementActivityPopup()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_01de: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_023e: Expected O, but got I
		//IL_024e: Expected O, but got I
		//IL_0270: Expected O, but got I4
		//IL_02b8: Expected O, but got I4
		//IL_0141: Expected O, but got I
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03cc: Expected O, but got I
		//IL_03dd: Expected I, but got O
		//IL_03fb: Expected O, but got I
		//IL_02f9: Expected O, but got I
		//IL_0323: Expected O, but got I4
		//IL_02e8: Expected O, but got I
		if (!EnsureCanManageActivities())
		{
			return;
		}
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		ITrackEvent trackEvent = TrackerLibrary.ClanActivityCreatorViewed(ClanActivityType.Announcement);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+E4]");
		ComponentReference<ClanAnnouncementCreator> componentReference2;
		object obj4;
		Action<object> action;
		ComponentReference<ClanAnnouncementCreator> componentReference;
		Action<object> action2;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			componentReference = _createAnnouncementPopupRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = _createAnnouncementPopupRef;
			if (!flag)
			{
				goto IL_00c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			componentReference = _createAnnouncementPopupRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = _createAnnouncementPopupRef;
			if (obj6 != null)
			{
				goto IL_00c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v6+30]");
		Action<object> action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v6+30]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		action = action2;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0135;
		}
		goto IL_0296;
		IL_0296:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v13+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)936;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v11+B8]");
		object obj16 = (nint)0 + (nint)48;
		obj16 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = (nint)0 + (nint)1888;
		object obj18 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		action3 = action4;
		componentReference = componentReference2;
		object obj20 = obj17;
		action = action4;
		Action<object> action5 = action4;
		if (obj19 != null)
		{
			goto IL_0186;
		}
		goto IL_0359;
		IL_0135:
		obj17 = (nint)0 + (nint)1888;
		obj18 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		obj20 = obj17;
		action5 = action3;
		componentReference2 = componentReference;
		if (!flag6)
		{
			goto IL_0186;
		}
		goto IL_0359;
		IL_0359:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj17 = obj20;
		action3 = action5;
		componentReference = componentReference2;
		goto IL_0186;
		IL_0186:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_00c4:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v6+30]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v6+30]");
		bool flag7 = (nint)0 == 0;
		obj10 = obj7;
		action2 = action;
		componentReference2 = componentReference;
		if (!flag7)
		{
			goto IL_0135;
		}
		goto IL_0296;
	}

	public void OpenCreateRoom()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_03a9: Expected O, but got I
		//IL_03ba: Expected I, but got O
		//IL_03d8: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02d3: Expected O, but got I4
		//IL_0298: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		ITrackEvent trackEvent = TrackerLibrary.ClanActivityCreatorViewed(ClanActivityType.FriendlyRoom);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+E4]");
		ComponentReference<CreateGamePopup> componentReference2;
		object obj4;
		Action<object> action2;
		ComponentReference<CreateGamePopup> componentReference;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			componentReference = createGamePopupRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = createGamePopupRef;
			if (!flag)
			{
				goto IL_0075;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			componentReference = createGamePopupRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = createGamePopupRef;
			if (obj6 != null)
			{
				goto IL_0075;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6+38]");
		Action<object> action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6+38]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		action = action2;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_00e6:
		object obj11 = (nint)0 + (nint)2016;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		Action<object> action4 = action3;
		object obj13 = obj11;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0137;
		}
		goto IL_0309;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action3 = action4;
		obj11 = obj13;
		componentReference = componentReference2;
		goto IL_0137;
		IL_0137:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0075:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6+38]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6+38]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		action2 = action;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v13+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)944;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v11+B8]");
		object obj19 = (nint)0 + (nint)56;
		obj19 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2016;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action3 = action5;
		componentReference = componentReference2;
		action = action5;
		action4 = action5;
		obj13 = obj11;
		if (obj20 != null)
		{
			goto IL_0137;
		}
		goto IL_0309;
	}

	public void OpenCreateTournament()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0240: Expected O, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_0263: Expected O, but got I
		//IL_0273: Expected O, but got I
		//IL_0295: Expected O, but got I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0128: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_02c5: Expected O, but got I4
		//IL_01b7: Expected O, but got I
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_040b: Expected O, but got I
		//IL_041c: Expected I, but got O
		//IL_043a: Expected O, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0338: Expected O, but got I4
		//IL_02f5: Expected O, but got I
		if (!EnsureCanManageActivities())
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 56;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
		Action<object> action4;
		object obj18;
		Action<object> action3;
		Action<object> action;
		if (<Tournaments>k__BackingField.<Private>k__BackingField.CanCreateTournament)
		{
			ITrackEvent trackEvent = TrackerLibrary.ClanActivityCreatorViewed(ClanActivityType.Tournament);
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			object obj7 = typeof(CardUtils.<>c) + 1616;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v21+E4]");
			object obj9;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v21+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+40]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+40]");
				if ((nint)0 != 0)
				{
					goto IL_015d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v21+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+40]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+40]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 != null)
				{
					goto IL_015d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v21+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v28+B8]");
				obj9 = 0;
			}
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)952;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj9, (IntPtr)obj14);
			object obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v24+B8]");
			object obj16 = (nint)0 + (nint)64;
			obj16 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			action = action2;
			action3 = action2;
			action4 = action2;
			if (obj19 != null)
			{
				goto IL_01ab;
			}
			goto IL_035e;
		}
		object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Complete" + 2920;
		Toast.Show((string)message, (Vector2)0, 0f);
		return;
		IL_015d:
		object obj23 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		obj18 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		action3 = null;
		action4 = action;
		if (!flag7)
		{
			goto IL_01ab;
		}
		goto IL_035e;
		IL_035e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action4;
		goto IL_01ab;
		IL_01ab:
		object obj24 = (nint)0 + (nint)2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private static bool EnsureCanManageActivities()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_01f1: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_017f: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_0124: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E895E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
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
			object obj4 = (nint)0 + (nint)1976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
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
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		bool flag3 = (object)clanServerConnector == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_00a0:
		ClanUserModel myMembership = clanServerConnector.GetMyMembership();
		if (myMembership != null)
		{
			bool flag4 = !myMembership.IsOwner;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				object obj10 = myMembership.Permissions & ClanPermissions.ManageActivities;
				bool flag5 = obj10 == null;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					goto IL_0132;
				}
			}
			return true;
		}
		goto IL_0132;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_0132:
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3904;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show((string)message, (Vector2)0, 0f);
		return false;
	}

	public void OpenAddFundsPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03a4: Expected O, but got I
		//IL_03b5: Expected I, but got O
		//IL_03d3: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02d3: Expected O, but got I4
		//IL_0298: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		ITrackEvent trackEvent = TrackerLibrary.ClanVaultDepositViewed();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		ComponentReference<AddFundsToClanPopup> componentReference2;
		object obj4;
		Action<object> action2;
		ComponentReference<AddFundsToClanPopup> componentReference;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			componentReference = addFundsPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = addFundsPopup;
			if (!flag)
			{
				goto IL_0075;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			componentReference = addFundsPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = addFundsPopup;
			if (obj6 != null)
			{
				goto IL_0075;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+48]");
		Action<object> action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+48]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		action = action2;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_00e6:
		object obj11 = (nint)0 + (nint)1808;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		Action<object> action4 = action3;
		object obj13 = obj11;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0137;
		}
		goto IL_0309;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action3 = action4;
		obj11 = obj13;
		componentReference = componentReference2;
		goto IL_0137;
		IL_0137:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0075:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+48]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+48]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		action2 = action;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)888;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11+B8]");
		object obj19 = (nint)0 + (nint)72;
		obj19 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)1808;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v4+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action3 = action5;
		componentReference = componentReference2;
		action = action5;
		action4 = action5;
		obj13 = obj11;
		if (obj20 != null)
		{
			goto IL_0137;
		}
		goto IL_0309;
	}

	public void OpenAddFundsBottomSheet()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03a4: Expected O, but got I
		//IL_03b5: Expected I, but got O
		//IL_03d3: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02d3: Expected O, but got I4
		//IL_0298: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		ITrackEvent trackEvent = TrackerLibrary.ClanVaultDepositViewed();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		ComponentReference<AddFundsToClanPopup> componentReference2;
		object obj4;
		Action<object> action2;
		ComponentReference<AddFundsToClanPopup> componentReference;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			componentReference = addFundsBottomSheet;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = addFundsBottomSheet;
			if (!flag)
			{
				goto IL_0075;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			componentReference = addFundsBottomSheet;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = addFundsBottomSheet;
			if (obj6 != null)
			{
				goto IL_0075;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+50]");
		Action<object> action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+50]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		action = action2;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_00e6:
		object obj11 = (nint)0 + (nint)1808;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		Action<object> action4 = action3;
		object obj13 = obj11;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0137;
		}
		goto IL_0309;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action3 = action4;
		obj11 = obj13;
		componentReference = componentReference2;
		goto IL_0137;
		IL_0137:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0075:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+50]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+50]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		action2 = action;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)880;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11+B8]");
		object obj19 = (nint)0 + (nint)80;
		obj19 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)1808;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v4+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action3 = action5;
		componentReference = componentReference2;
		action = action5;
		action4 = action5;
		obj13 = obj11;
		if (obj20 != null)
		{
			goto IL_0137;
		}
		goto IL_0309;
	}

	public void OpenRequestFundsPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03a4: Expected O, but got I
		//IL_03b5: Expected I, but got O
		//IL_03d3: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02d3: Expected O, but got I4
		//IL_0298: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(CardUtils.<>c) + 1616;
		ITrackEvent trackEvent = TrackerLibrary.ClanSupportRequestViewed();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		ComponentReference<RequestFundsPopup> componentReference2;
		object obj4;
		Action<object> action2;
		ComponentReference<RequestFundsPopup> componentReference;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			componentReference = requestFundsPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = requestFundsPopup;
			if (!flag)
			{
				goto IL_0075;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			componentReference = requestFundsPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			action = null;
			action2 = null;
			object obj5 = obj4;
			componentReference2 = requestFundsPopup;
			if (obj6 != null)
			{
				goto IL_0075;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+58]");
		Action<object> action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+58]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		action = action2;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_00e6:
		object obj11 = (nint)0 + (nint)2320;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		Action<object> action4 = action3;
		object obj13 = obj11;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0137;
		}
		goto IL_0309;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action3 = action4;
		obj11 = obj13;
		componentReference = componentReference2;
		goto IL_0137;
		IL_0137:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0075:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+58]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+58]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		action2 = action;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_0246;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)960;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11+B8]");
		object obj19 = (nint)0 + (nint)88;
		obj19 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2320;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v4+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action3 = action5;
		componentReference = componentReference2;
		action = action5;
		action4 = action5;
		obj13 = obj11;
		if (obj20 != null)
		{
			goto IL_0137;
		}
		goto IL_0309;
	}

	public void OpenVaultSupportersPopup(long feedId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_0150: Expected I, but got O
		//IL_00e0: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3984;
		object obj5 = (nint)0 + (nint)1048;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		ITrackEvent trackEvent = TrackerLibrary.ClanVaultDonorsViewed();
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = (nint)0 + (nint)2448;
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void <OpenClanView>b__25_0(ClanModel model)
	{
		if (model != null)
		{
			OpenClanView(model);
		}
	}

	private void <OpenClanInfoPopup>b__27_0(ClanModel model)
	{
		if (model != null)
		{
			OpenClanInfoPopup(model);
		}
	}

	private void <OpenClanCardInfoPopup>b__29_0(ClanModel model)
	{
		if (model != null)
		{
			OpenClanCardInfoPopup(model);
		}
	}
}
