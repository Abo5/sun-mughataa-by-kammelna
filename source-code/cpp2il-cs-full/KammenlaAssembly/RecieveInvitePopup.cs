using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class RecieveInvitePopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass15_0
	{
		public RecieveInvitePanel.Skin skin;

		internal bool <GetPanelToOpen>b__0(RecieveInvitePanel panel)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if ((object)panel != null)
			{
				object obj = panel.skin - skin;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private PopupUI popupUi;

	private List<RecieveInvitePanel> panels;

	private RoomInfoIcons infoIcons;

	private InvitationsNotifier notifier;

	private int roomId;

	private FriendProfile currentInviter;

	private int currentInviterId;

	private GameType currentInviteGameType;

	private void Awake()
	{
		//IL_0123: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_00c4: Expected I, but got O
		//IL_0076: Expected O, but got I4
		bool flag = panels == null;
		object obj = 152993792;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)504;
			obj = (nint)0 + (nint)496;
			List<object>.Enumerator enumerator = ((List<object>)(object)panels).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EDB8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void Initialize(InvitationsNotifier invNotifier)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 56;
		obj = invNotifier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Open(FriendProfile user, string message, GameType gameType)
	{
		HideContent();
		currentInviteGameType = gameType;
		currentInviterId = user.UserID;
		RecieveInvitePanel panelToOpen = GetPanelToOpen(gameType);
		GameObject gameObject = panelToOpen.gameObject;
		gameObject.SetActive(value: true);
		panelToOpen.Populate(user, message);
		popupUi.SlideFromRight();
	}

	public void OpenChallengeInvite(FriendlyChallengeInviteModel challenge)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		HideContent();
		PlayerInfo <Challenger>k__BackingField = challenge.<Challenger>k__BackingField;
		currentInviterId = <Challenger>k__BackingField.<DBID>k__BackingField;
		currentInviteGameType = GameType.Challenge;
		RecieveInvitePanel panelToOpen = GetPanelToOpen(GameType.Challenge);
		object msg = "utf-32" + 3672;
		panelToOpen.OpenChallenge(challenge, (string)msg);
		popupUi.SlideFromRight();
	}

	public void SendReject()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0117: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C51]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.ChallengeRejected();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.ChallengeRejected();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			trackEvent2 = trackEvent;
			if (obj4 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		RecieveInvitePanel panelToOpen = GetPanelToOpen(currentInviteGameType);
		InvitationsNotifier invitationsNotifier = (InvitationsNotifier)(object)panelToOpen;
		goto IL_0163;
		IL_0163:
		List<InvitationsNotifier.InvitationData> pendingInvitations = invitationsNotifier.pendingInvitations;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4 (System.Collections.Generic.List`1<InvitationsNotifier+InvitationData>)+120]");
		if ((nint)0 == 1)
		{
			invitationsNotifier.IgnoreNotifier(currentInviterId);
		}
		notifier.RejectNotifier();
		popupUi.ShrinkToParent();
		return;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		RecieveInvitePanel panelToOpen2 = GetPanelToOpen(currentInviteGameType);
		bool flag3 = (object)panelToOpen2 == null;
		object obj5 = !flag3;
		invitationsNotifier = (InvitationsNotifier)(object)panelToOpen2;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0163;
	}

	public void SendAccept()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C52]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.ChallengeAccepted();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.ChallengeAccepted();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			trackEvent2 = trackEvent;
			if (obj4 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		InvitationsNotifier invitationsNotifier = notifier;
		goto IL_0144;
		IL_0144:
		invitationsNotifier.AcceptNotifier();
		popupUi.ShrinkToParent();
		return;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		invitationsNotifier = notifier;
		bool flag3 = (object)notifier == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0144;
	}

	public void Expired()
	{
		InvitationsNotifier invitationsNotifier = notifier;
		((List<object>)(object)invitationsNotifier.pendingInvitations).RemoveAt(0);
		invitationsNotifier.ReadNextInvite();
	}

	private RecieveInvitePanel GetPanelToOpen(GameType gameType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0077: Expected O, but got I4
		//IL_00df: Expected I, but got O
		//IL_0069: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3056;
			object obj4 = (nint)0 + (nint)3360;
			if (gameType == GameType.Challenge)
			{
				object obj5 = 1 + 1;
			}
			else
			{
				object obj5 = 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (RecieveInvitePanel)Enumerable.FirstOrDefault(panels, func);
		}
		return (RecieveInvitePanel)(object)new NullReferenceException();
	}

	public void Close()
	{
		popupUi.ShrinkToParent();
	}

	private void HideContent()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_014a: Expected I, but got O
		//IL_00be: Expected I, but got O
		//IL_0098: Expected O, but got I4
		bool flag = panels == null;
		RecieveInvitePopup recieveInvitePopup = this;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj = (nint)0 + (nint)504;
			recieveInvitePopup = (RecieveInvitePopup)((nint)0 + (nint)496);
			List<object>.Enumerator enumerator = ((List<object>)(object)panels).GetEnumerator();
			num = (nint)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj2 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)recieveInvitePopup;
			enumerator2.Dispose();
			object obj3 = default(object);
			if (obj3 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj2 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EDB8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}
}
