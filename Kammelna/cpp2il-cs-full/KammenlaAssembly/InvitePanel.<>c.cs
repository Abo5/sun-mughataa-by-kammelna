using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class InvitePanel : MonoBehaviour, IInitializable
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendInviteDataHolder, bool> <>9__29_0;

		public static Func<FriendInviteDataHolder, int> <>9__29_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SendInviteToAll>b__29_0(FriendInviteDataHolder d)
		{
			//IL_00a1: Expected I4, but got O
			//IL_0080: Expected O, but got I4
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected I4, but got Unknown
			if (d != null)
			{
				if (d.<IsInvited>k__BackingField)
				{
					return false;
				}
				if (d.<IsInGame>k__BackingField)
				{
					return false;
				}
				object obj = (d.<IsInTournament>k__BackingField ? 1 : 0) ^ 1;
				return (byte)(obj & 1) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <SendInviteToAll>b__29_1(FriendInviteDataHolder d)
		{
			//IL_0064: Expected I4, but got O
			if (d != null)
			{
				FriendProfile <Friend>k__BackingField = d.<Friend>k__BackingField;
				if (d.<Friend>k__BackingField != null)
				{
					return <Friend>k__BackingField.UserID;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass26_0
	{
		public FriendInviteDataHolder inviteData;

		internal bool <UpdateFriendInviteStatus>b__0(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					FriendInviteDataHolder friendInviteDataHolder = inviteData;
					if (inviteData != null)
					{
						FriendProfile <Friend>k__BackingField = friendInviteDataHolder.<Friend>k__BackingField;
						if (friendInviteDataHolder.<Friend>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <Friend>k__BackingField.UserID;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <UpdateFriendInviteStatus>b__1(User p)
		{
			//IL_0099: Expected I4, but got O
			//IL_0077: Expected O, but got I4
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(p);
			FriendInviteDataHolder friendInviteDataHolder = inviteData;
			if (inviteData != null)
			{
				FriendProfile <Friend>k__BackingField = friendInviteDataHolder.<Friend>k__BackingField;
				if (friendInviteDataHolder.<Friend>k__BackingField != null)
				{
					object obj = intDbId - <Friend>k__BackingField.UserID;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <FriendStatusUpdater>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public InvitePanel <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <FriendStatusUpdater>d__24(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01c5: Expected O, but got I4
			//IL_01d5: Expected O, but got I4
			//IL_01ef: Expected O, but got I4
			//IL_0226: Expected O, but got I4
			//IL_022f: Expected I4, but got O
			//IL_001e: Expected I4, but got I8
			//IL_01a9: Expected I4, but got O
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			//IL_00f8: Expected O, but got I4
			bool flag = <>1__state < 1;
			object obj = !flag;
			object obj2 = <>1__state - 1;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			object obj4 = obj & obj3;
			if (obj4 == null)
			{
				InvitePanel invitePanel = <>4__this;
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					PopupUI popup = invitePanel.popup;
					if ((object)invitePanel.popup != null)
					{
						if (popup.<IsCurrentlyShown>k__BackingField)
						{
							if ((object)invitePanel.listView == null)
							{
								goto IL_019b;
							}
							IEnumerable<object> data = invitePanel.listView.data;
							object obj5 = (nint)0 + (nint)2560;
							bool flag3 = ArraysExtensions.IsNullOrEmpty(data);
							bool flag4 = !flag3;
							object obj6 = !flag4;
							if (obj6 == null && <>4__this.UpdateFriendInviteStatus())
							{
								<>4__this.Refresh();
							}
						}
						object obj7 = typeof(UsageHint) + 1640;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						WaitForSeconds waitForSeconds = default(WaitForSeconds);
						waitForSeconds..ctor(0.5f);
						object obj8 = this + 24;
						obj8 = waitForSeconds;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 1;
						goto IL_020a;
					}
				}
				goto IL_019b;
			}
			goto IL_020a;
			IL_019b:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_020a:
			bool flag5 = <>1__state < 2;
			object obj9 = !flag5;
			return (byte)(int)(~obj9) != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const int SecondsForReply = 15;

	private PopupUI popup;

	private InputField filterWord;

	private TextMeshProUGUI noOnlineTitle;

	private Button blocker;

	private Button inviteAllFriends;

	private FriendInviteListView listView;

	private Room _room;

	private Coroutine _statusUpdater;

	private bool IsTournament => SFSKammelnaRoomExtensions.IsTournamentHub(_room);

	public bool IsShown
	{
		get
		{
			//IL_0041: Expected I4, but got O
			PopupUI popupUI = popup;
			if ((object)popup != null)
			{
				return popupUI.<IsCurrentlyShown>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_0274: Expected O, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_0316: Expected O, but got I
		//IL_0324: Expected I, but got O
		//IL_036b: Expected O, but got I
		//IL_0383: Expected I, but got O
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_03a8: Expected O, but got I
		//IL_03e1: Expected I, but got O
		//IL_03f4: Expected O, but got I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_044b: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CDE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v43+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v43+E4]");
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
		IL_02f1:
		Button button = inviteAllFriends;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)3248;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		button.m_OnClick.AddListener(unityAction);
		object obj10;
		object obj9 = obj10;
		UnityAction unityAction2 = unityAction;
		goto IL_0350;
		IL_01e8:
		obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		UnityEngine.Object obj11;
		bool flag3 = obj11;
		bool flag4 = !flag3;
		object obj12 = !flag4;
		UnityAction unityAction3 = null;
		if (obj12 != null)
		{
			goto IL_02f1;
		}
		obj9 = obj10;
		unityAction2 = null;
		goto IL_0350;
		IL_0350:
		Button button2 = blocker;
		object obj13 = (nint)0 + (nint)3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj13);
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2016;
		Delegate obj15 = (Delegate)((nint)0 + (nint)3232);
		button2.m_OnClick.AddListener(unityAction4);
		FriendInviteListView friendInviteListView = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj15);
		Delegate obj16 = friendInviteListView.InviteRequested;
		object obj19 = default(object);
		bool flag6;
		Delegate obj22 = default(Delegate);
		do
		{
			Delegate obj17 = Delegate.Combine(obj16, action);
			if ((object)obj17 == null)
			{
				object obj18 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = obj19 == null;
				object obj20 = !flag5;
				object obj18 = obj19;
				if (obj20 == null)
				{
					throw new InvalidCastException();
				}
			}
			object obj21 = friendInviteListView + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag6 = (object)obj22 == obj16;
			obj16 = obj22;
		}
		while (!flag6);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag7 = (object)sessionModel == null;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
		IL_0133:
		object obj24 = typeof(MemberAchievementClanFeedData) + 2976;
		Room currentRoom = sessionModel.CurrentRoom;
		object obj25 = this + 80;
		obj25 = currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag8 = SFSKammelnaRoomExtensions.IsTournamentHub((Room)obj25);
		bool flag9 = !flag8;
		object obj26 = !flag9;
		UnityEngine.Object obj28;
		if (obj26 == null)
		{
			object obj27 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v33+E4]");
			bool flag10 = (nint)0 == 0;
			obj11 = inviteAllFriends;
			obj28 = inviteAllFriends;
			if (!flag10)
			{
				goto IL_01e8;
			}
		}
		else
		{
			BindParticipants();
			object obj27 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v33+E4]");
			bool flag11 = (nint)0 == 0;
			object obj29 = !flag11;
			obj11 = inviteAllFriends;
			obj28 = inviteAllFriends;
			if (obj29 != null)
			{
				goto IL_01e8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		bool flag12 = obj28;
		bool flag13 = !flag12;
		unityAction3 = null;
		obj9 = obj10;
		unityAction2 = null;
		if (!flag13)
		{
			goto IL_02f1;
		}
		goto IL_0350;
	}

	private void BindParticipants()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_006e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3240;
		object varName = "placementId" + 296;
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go, _room, (string)varName, action);
	}

	public void Initialize()
	{
		popup.PopFromCenter();
		OnOpen();
	}

	public void Open()
	{
		popup.PopFromCenter();
		OnOpen();
	}

	public void Close()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		popup.ShrinkToParent(action);
	}

	private void OnInviteRequested(FriendInviteDataHolder inviteData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02c4: Expected O, but got I
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_0302: Expected O, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0261: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		object obj = typeof(Queue<string>) + 736;
		object obj2 = (nint)0 + (nint)1992;
		object obj3 = typeof(TypeConverter<ushort, char>) + 3048;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (inviteData != null)
		{
			FriendProfile <Friend>k__BackingField = inviteData.<Friend>k__BackingField;
			int[] array = default(int[]);
			if (inviteData.<Friend>k__BackingField != null && array != null)
			{
				array[0] = <Friend>k__BackingField.UserID;
				CoordinatorService coordinatorService = default(CoordinatorService);
				if ((object)coordinatorService != null)
				{
					coordinatorService.SendGameInvitations(array);
					float timeSinceLevelLoad = Time.timeSinceLevelLoad;
					inviteData.<InvitationTimestamp>k__BackingField = timeSinceLevelLoad;
					inviteData.<IsInvited>k__BackingField = true;
					bool flag2 = SFSKammelnaRoomExtensions.IsTournamentHub(_room);
					FriendProfile <Friend>k__BackingField2 = inviteData.<Friend>k__BackingField;
					if (flag2)
					{
						if (inviteData.<Friend>k__BackingField != null)
						{
							bool isOnline = <Friend>k__BackingField2.IsOnline;
							trackEvent = TrackerLibrary.TournamentInviteSent(invitedAllFriends: false, <Friend>k__BackingField2.IsOnline);
							object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
							object obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+E4]");
							bool flag3 = (nint)0 == 0;
							object obj8 = !flag3;
							if (obj8 != null)
							{
								goto IL_0280;
							}
							object obj9 = 0;
							trackEvent2 = trackEvent;
							goto IL_028a;
						}
					}
					else if (inviteData.<Friend>k__BackingField != null)
					{
						trackEvent = TrackerLibrary.GameInviteSent(<Friend>k__BackingField2.IsOnline);
						object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
						object obj7 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+E4]");
						bool flag4 = (nint)0 == 0;
						object obj9 = 0;
						bool isOnline = false;
						trackEvent2 = trackEvent;
						if (!flag4)
						{
							goto IL_0280;
						}
						goto IL_028a;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0280:
		Tracker.DesignEvent(trackEvent);
		return;
		IL_028a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
	}

	private void MarkInvitationSent(FriendInviteDataHolder inviteData)
	{
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		inviteData.<InvitationTimestamp>k__BackingField = timeSinceLevelLoad;
		inviteData.<IsInvited>k__BackingField = true;
	}

	private void OnOpen()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_017b: Expected I, but got O
		//IL_0063: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I
		//IL_00d0: Expected I, but got O
		//IL_00e1: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3240;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Refresh();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated += action;
		InputField inputField = filterWord;
		object obj6 = typeof(TypeConverter<ushort, char>) + 464;
		object obj7 = (nint)0 + (nint)3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction = default(UnityAction<object>);
		unityAction..ctor((object)this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)1208;
		((UnityEvent<object>)(object)inputField.m_OnValueChanged).AddListener(unityAction);
		object obj9 = this + 88;
		if (obj9 == null)
		{
			object obj10 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = default(object);
			obj11..ctor();
			_ = 0;
			object obj12 = obj11 + 32;
			obj12 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine statusUpdater = StartCoroutine((IEnumerator)obj11);
			_statusUpdater = statusUpdater;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void OnDestroy()
	{
		OnClose();
	}

	private void ApplyFilter(string word)
	{
		listView.SetFriendInviteStrips(word);
	}

	private void OnClose()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_012f: Expected I, but got O
		//IL_0159: Expected O, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0098: Expected I, but got O
		//IL_00a9: Expected O, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_010c: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3240;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated -= action;
		InputField inputField = filterWord;
		object obj6 = typeof(TypeConverter<ushort, char>) + 464;
		object obj7 = (nint)0 + (nint)3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction = default(UnityAction<object>);
		unityAction..ctor((object)this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)1224;
		object obj9 = obj8;
		((UnityEvent<object>)(object)inputField.m_OnValueChanged).RemoveListener(unityAction);
		object obj10 = this + 88;
		if (obj10 != null)
		{
			StopCoroutine((Coroutine)obj10);
			obj9 = 0;
		}
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private IEnumerator FriendStatusUpdater()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void Refresh()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_00ac: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<FriendProfile> friendsList = FriendsManager.FriendsList;
		if (Enumerable.Any((IEnumerable<object>)friendsList))
		{
			GameObject gameObject = noOnlineTitle.gameObject;
			gameObject.SetActive(value: false);
			IEnumerable<object> data = listView.data;
			bool flag2 = ArraysExtensions.IsNullOrEmpty(data);
			object filter = (nint)0 + (nint)2000;
			bool reload = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			listView.SetFriendInviteStrips((string)filter, reload);
		}
		else
		{
			GameObject gameObject2 = noOnlineTitle.gameObject;
			gameObject2.SetActive(value: true);
		}
	}

	private bool UpdateFriendInviteStatus()
	{
		//IL_08e7: Expected O, but got I4
		//IL_0905: Expected O, but got I
		//IL_000d: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		//IL_098d: Expected O, but got I
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected I4, but got Unknown
		//IL_0844: Expected O, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0868: Expected O, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023b: Expected I, but got O
		//IL_024b: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_0193: Expected I, but got O
		//IL_019f: Expected O, but got I
		//IL_0371: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		//IL_01e0: Expected O, but got I4
		//IL_0af8: Expected I, but got O
		//IL_0286: Expected O, but got I
		//IL_03d6: Expected O, but got I4
		//IL_0a43: Expected O, but got I4
		//IL_0a63: Invalid comparison between F8 and I4
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected O, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected O, but got Unknown
		//IL_091c: Expected O, but got I4
		//IL_092d: Expected O, but got I4
		//IL_06eb: Expected O, but got I4
		//IL_06fc: Expected O, but got I4
		//IL_0704: Expected I, but got O
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_078c: Expected O, but got I
		//IL_07a8: Expected O, but got I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02c9: Expected O, but got I4
		//IL_02e2: Invalid comparison between F8 and I4
		//IL_02f1: Invalid comparison between F8 and I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0728: Expected O, but got I
		//IL_0744: Expected O, but got I4
		//IL_087f: Expected O, but got I4
		//IL_0890: Expected O, but got I4
		//IL_0417: Expected O, but got I
		//IL_053a: Expected O, but got I
		//IL_0554: Expected O, but got I4
		//IL_0b91: Expected O, but got I4
		//IL_0b9a: Expected O, but got I4
		//IL_05cc: Expected O, but got I4
		//IL_05ed: Invalid comparison between F8 and I4
		//IL_05fc: Invalid comparison between F8 and I4
		//IL_0618: Expected O, but got I
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_06b4: Expected O, but got I4
		//IL_08af: Expected O, but got I4
		//IL_08bf: Expected O, but got F4
		//IL_08c8: Expected O, but got I4
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0484: Invalid comparison between O and F8
		//IL_0495: Expected O, but got I4
		//IL_04b2: Invalid comparison between F8 and I4
		//IL_04c1: Invalid comparison between F8 and I4
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_0510: Invalid comparison between O and F8
		FriendInviteListView friendInviteListView = listView;
		nint num2 = default(nint);
		object obj6 = default(object);
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		Func<object, bool> func2 = default(Func<object, bool>);
		Func<object, bool> func3 = default(Func<object, bool>);
		float timeSinceLevelLoad;
		Func<object, bool> func;
		List<object>.Enumerator enumerator2;
		object obj15;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if ((object)listView != null)
		{
			nint num = (nint)friendInviteListView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v11 (Il2CppClass<FriendInviteListView>)+2A0]");
			num2 = 0;
			List<object> data = (List<object>)(object)listView.data;
			if (data != null)
			{
				object obj = (nint)0 + (nint)904;
				object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 32;
				object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
				object obj4 = (nint)0 + (nint)1168;
				object obj5 = (nint)0 + (nint)2872;
				List<object>.Enumerator enumerator = data.GetEnumerator();
				enumerator2 = enumerator3;
				obj6 = 0;
				object obj7 = default(object);
				object obj9 = default(object);
				bool flag6 = default(bool);
				object obj22 = default(object);
				double num4 = default(double);
				bool flag8 = default(bool);
				bool flag9 = default(bool);
				object obj23 = default(object);
				object obj24 = default(object);
				object obj25 = default(object);
				bool flag10 = default(bool);
				IEnumerable<object> source = default(IEnumerable<object>);
				while (enumerator4.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj7..ctor();
					if (obj7 == null)
					{
						goto IL_082a;
					}
					object obj8 = obj7 + 16;
					obj8 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag = SFSKammelnaRoomExtensions.IsTournamentHub(_room);
					bool flag2 = !flag;
					func = null;
					object obj13;
					object obj18;
					if (!flag2)
					{
						List<QueuePlayer> tournamentQueue = SFSKammelnaRoomExtensions.GetTournamentQueue(_room);
						object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj11 = (nint)0 + (nint)1160;
						func2..ctor(obj7, (IntPtr)obj11);
						object obj12 = (nint)0 + (nint)2760;
						obj13 = obj12;
						bool flag3 = Enumerable.Any(tournamentQueue, func2);
						bool flag4 = !flag3;
						object obj14 = !flag4;
						obj15 = 0;
						func = func2;
						if (obj14 != null)
						{
							object obj16 = obj8;
							if (obj8 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v38+1A]");
								object obj17 = (nint)0 ^ (nint)1;
								obj18 = obj17 | obj6;
								_ = 1;
								obj15 = 0;
								obj6 = obj18;
								continue;
							}
							goto IL_090a;
						}
					}
					Room room = _room;
					if (_room == null)
					{
						goto IL_084e;
					}
					object obj19 = typeof(RegisteredWaitHandle) + 1376;
					nint num3 = (nint)room;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_035e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj21 = (nint)0 + (nint)8;
					bool flag5 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X10_v11-8]");
						bool flag7 = 0 < (nint)obj19;
						obj22 = !flag7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X10_v11-8]");
						num4 = 0.0 - (double)obj19;
						flag8 = num4 < 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X10_v11-8]");
						flag9 = 0 == (nint)obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X10_v11-8]");
						obj23 = 0 ^ obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X10_v11-8]");
						obj24 = 0 ^ num4;
						obj25 = obj23 & obj24;
						flag10 = (nint)obj25 < 0;
						if (flag9)
						{
							break;
						}
						obj18 = obj21 + 16;
						obj20--;
						bool flag11 = (nint)obj20 < 1;
						obj22 = !flag11;
						num4 = (double)obj20 - 1.0;
						flag8 = num4 < 0.0;
						flag9 = num4 == 0.0;
						obj23 = obj20 ^ 1;
						obj24 = obj20 ^ num4;
						obj25 = obj23 & obj24;
						flag10 = (nint)obj25 < 0;
						flag6 = (nint)obj20 != 1;
						flag5 = flag6;
						obj21 = obj18;
						if (flag6)
						{
							continue;
						}
						goto IL_035e;
					}
					object obj26 = obj21 + 28;
					object obj27 = num3 + obj26;
					object obj28 = obj27 + 312;
					flag6 = flag5;
					obj18 = obj21;
					goto IL_0ad3;
					IL_035e:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj13 = 28;
					goto IL_0ad3;
					IL_0ad3:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v564 @ X0_v36] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					func3..ctor(obj7, (IntPtr)obj4);
					obj13 = obj5;
					bool flag12 = Enumerable.Any(source, func3);
					object obj29 = obj8;
					bool flag13 = !flag12;
					object obj30 = !flag13;
					bool flag15;
					bool flag16;
					object obj32;
					object obj33;
					object obj34;
					bool flag17;
					bool flag18;
					double num5;
					object obj35;
					if (obj30 == null)
					{
						if (obj8 == null)
						{
							goto IL_086d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+18]");
						object obj31 = (nint)0 & (nint)1;
						if (obj31 != null)
						{
							timeSinceLevelLoad = Time.timeSinceLevelLoad;
							obj29 = obj8;
							if (obj8 == null)
							{
								goto IL_089d;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+1C]");
							enumerator2 = (List<object>.Enumerator)(timeSinceLevelLoad - 0);
							bool flag14 = enumerator2 < (object)15.0;
							obj22 = !flag14;
							num4 = (double)enumerator2 - 15.0;
							flag8 = num4 < 0.0;
							flag9 = num4 == 0.0;
							obj23 = enumerator2 ^ 15.0;
							obj24 = enumerator2 ^ num4;
							obj25 = obj23 & obj24;
							flag10 = (nint)obj25 < 0;
							flag6 = enumerator2 > (object)15.0;
							if (flag6)
							{
								_ = 0;
								flag15 = flag6;
								flag16 = flag10;
								obj32 = obj25;
								obj33 = obj24;
								obj34 = obj23;
								flag17 = flag9;
								flag18 = flag8;
								num5 = num4;
								obj35 = obj22;
								goto IL_0b40;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+19]");
						object obj36 = (nint)0 & (nint)1;
						bool flag19 = obj36 == null;
						object obj37 = !flag19;
						flag15 = flag6;
						flag16 = flag10;
						obj32 = obj25;
						obj33 = obj24;
						obj34 = obj23;
						flag17 = flag9;
						flag18 = flag8;
						num5 = num4;
						obj35 = obj22;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+1A]");
							bool flag20 = (nint)0 < (nint)1;
							obj35 = !flag20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+1A]");
							num5 = 0.0 - 1.0;
							flag18 = num5 < 0.0;
							flag17 = num5 == 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+1A]");
							obj34 = (nint)0 ^ (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+1A]");
							obj33 = 0 ^ num5;
							obj32 = obj34 & obj33;
							flag16 = (nint)obj32 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+1A]");
							flag15 = (nint)0 != 1;
							flag6 = flag15;
							flag10 = flag16;
							obj25 = obj32;
							obj24 = obj33;
							obj23 = obj34;
							flag9 = flag17;
							flag8 = flag18;
							num4 = num5;
							obj22 = obj35;
							obj15 = 0;
							if (flag15)
							{
								continue;
							}
						}
						_ = 0;
						_ = 0;
						goto IL_0b40;
					}
					bool flag21 = obj8 == null;
					obj15 = 0;
					enumerator4 = enumerator3;
					enumerator3 = (List<object>.Enumerator)0;
					num2 = (nint)func3;
					if (!flag21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+19]");
						object obj38 = (nint)0 ^ (nint)1;
						obj18 = obj38 | obj6;
						_ = 1;
						obj15 = 0;
						obj6 = obj18;
						continue;
					}
					goto IL_08ec;
					IL_0b40:
					flag6 = flag15;
					flag10 = flag16;
					obj25 = obj32;
					obj24 = obj33;
					obj23 = obj34;
					flag9 = flag17;
					flag8 = flag18;
					num4 = num5;
					obj22 = obj35;
					obj15 = 0;
					obj6 = 1;
				}
				enumerator4.Dispose();
				goto IL_0817;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_08ec;
		IL_08ec:
		NullReferenceException ex2 = new NullReferenceException();
		List<object>.Enumerator enumerator5 = enumerator4;
		func = (Func<object, bool>)num2;
		goto IL_0940;
		IL_0940:
		bool flag22 = (nint)func != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag22)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj39 = (nint)0 + (nint)896;
			func = (Func<object, bool>)obj39;
			enumerator5.Dispose();
			object obj40 = default(object);
			if (obj40 == null)
			{
				goto IL_0817;
			}
			ex3 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223ED78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result = default(bool);
		return result;
		IL_090a:
		ex2 = new NullReferenceException();
		obj15 = 0;
		enumerator5 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		func = func2;
		goto IL_0940;
		IL_0817:
		return (byte)(obj6 & 1) != 0;
		IL_084e:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		goto IL_0940;
		IL_089d:
		ex2 = new NullReferenceException();
		obj15 = 0;
		enumerator5 = enumerator3;
		enumerator2 = (List<object>.Enumerator)timeSinceLevelLoad;
		enumerator3 = (List<object>.Enumerator)0;
		func = func3;
		goto IL_0940;
		IL_082a:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		func = null;
		goto IL_0940;
		IL_086d:
		ex2 = new NullReferenceException();
		obj15 = 0;
		enumerator5 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		func = func3;
		goto IL_0940;
	}

	private void ShowNoOnlineTitle()
	{
		GameObject gameObject = noOnlineTitle.gameObject;
		gameObject.SetActive(value: true);
	}

	private void HideNoOnlineTitle()
	{
		GameObject gameObject = noOnlineTitle.gameObject;
		gameObject.SetActive(value: false);
	}

	private void SendInviteToAll()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0058: Expected O, but got I4
		//IL_0374: Expected O, but got I
		//IL_0380: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_03a0: Expected O, but got I
		//IL_03c2: Expected O, but got I4
		//IL_0121: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_045d: Expected O, but got I
		//IL_0469: Expected O, but got I
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_048d: Expected O, but got I
		//IL_049d: Expected O, but got I
		//IL_04bf: Expected O, but got I4
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03fa: Expected O, but got I
		//IL_040b: Expected I, but got O
		//IL_0429: Expected O, but got I
		//IL_0444: Expected O, but got I4
		//IL_01a9: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_01f6: Expected O, but got I4
		//IL_0168: Expected O, but got I4
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_04f7: Expected O, but got I
		//IL_0508: Expected I, but got O
		//IL_0526: Expected O, but got I
		//IL_0541: Expected O, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0256: Expected O, but got I
		//IL_0198: Expected O, but got I
		//IL_02a5: Expected O, but got I4
		//IL_056f: Expected I, but got O
		//IL_02ce: Expected O, but got I
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0328: Expected O, but got I4
		//IL_0358: Expected O, but got I4
		FriendInviteListView friendInviteListView = listView;
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 24;
		nint num = (nint)friendInviteListView;
		IEnumerable<object> data = friendInviteListView.data;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)3416;
		object obj5 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v7+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v24+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v24+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v30+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)1144;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v29+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj14 = 0;
			predicate = func;
		}
		IEnumerable<object> source = Enumerable.Where(data, predicate);
		List<object> list = Enumerable.ToList(source);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		object obj17 = (nint)0 + (nint)3240;
		object obj18 = (nint)0 + (nint)1320;
		object obj19 = typeof(Queue<string>) + 736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v13+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v16+10]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v16+10]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v22+B8]");
				obj20 = 0;
			}
			object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)1152;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj20, (IntPtr)obj25);
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v21+B8]");
			object obj27 = (nint)0 + (nint)16;
			obj27 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj14 = 0;
			selector = func2;
		}
		object obj28 = (nint)0 + (nint)1992;
		IEnumerable<int> source2 = Enumerable.Select(list, selector);
		int[] userIds = Enumerable.ToArray(source2);
		object obj29 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj30 = !flag7;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj31 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj32 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2016;
		object obj33 = (nint)0 + (nint)3216;
		CoordinatorService coordinatorService = default(CoordinatorService);
		coordinatorService.SendGameInvitations(userIds);
		ITrackEvent trackEvent = TrackerLibrary.TournamentInviteSent(invitedAllFriends: true, isFriendOnline: false);
		object obj34 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj35 = !flag8;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj33);
		object obj36 = (nint)0 + (nint)2216;
		object obj37 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "SERVICE_DISABLED" + 3040;
		list.ForEach(action);
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v28+E4]");
		bool flag9 = (nint)0 == 0;
		object obj39 = !flag9;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show((string)message, (Vector2)0, 0f);
	}
}
