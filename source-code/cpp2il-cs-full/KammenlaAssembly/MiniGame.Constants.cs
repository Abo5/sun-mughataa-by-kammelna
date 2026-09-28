using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using Util;

public class MiniGame : MonoBehaviour
{
	public delegate void ErrorCallback(string command, string message);

	public static class Constants
	{
		public const string Command = "mg";

		public const string Play = "play";

		public const string Move = "move";

		public const string Claim = "claim";

		public const string Clear = "clear";

		public const string MoveCards = "move_cards";

		public const string ErrorOngoingGame = "game_ongoing";

		public const string ErrorGameNotInitialized = "game_not_initialized";
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Card, string> <>9__25_0;

		public static Action <>9__34_0;

		public static Action <>9__34_1;

		public static Func<MiniGameReward, string> <>9__35_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <SendMove>b__25_0(Card card)
		{
			//IL_0025: Expected I, but got O
			//IL_0035: Expected O, but got I
			//IL_0045: Expected O, but got I
			if (card != null)
			{
				nint num = (nint)card;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Card>)+168]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Card>)+170]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			}
			return (string)(object)new NullReferenceException();
		}

		internal void <OnCommandFail>b__34_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005c: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
		}

		internal void <OnCommandFail>b__34_1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005c: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
		}

		internal string <TrackClaim>b__35_0(MiniGameReward reward)
		{
			if (reward != null)
			{
				return reward.<Name>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private Action m_OnInitialized;

	private Action m_OnMoveSent;

	private Action<MiniGameState> m_OnGameStart;

	private Action<MiniGameState> m_OnMove;

	private Action<MiniGameState> m_OnClaim;

	private ErrorCallback m_OnError;

	public MiniGameVisuals visuals;

	private readonly MiniGameState <State>k__BackingField;

	public MiniGameState State => <State>k__BackingField;

	public event Action OnInitialized
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnMoveSent
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action<MiniGameState> OnGameStart
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<MiniGameState> OnMove
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<MiniGameState> OnClaim
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
			object obj2 = this + 64;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
			object obj2 = this + 64;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event ErrorCallback OnError
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3664;
			object obj2 = this + 72;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3664;
			object obj2 = this + 72;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public void SendStart()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0038: Expected O, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_03e7: Expected O, but got I
		//IL_041a: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I4
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_0341: Expected O, but got I
		//IL_01fa: Expected O, but got I4
		//IL_03af: Expected O, but got I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0279: Expected O, but got I4
		//IL_02cf: Expected O, but got I4
		//IL_0452: Expected O, but got I4
		//IL_0321: Expected O, but got I4
		MiniGameState miniGameState = <State>k__BackingField;
		object obj = typeof(DataRelation) + 712;
		bool flag = !miniGameState.<GameOngoing>k__BackingField;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Actions.SafeInvoke(this.OnInitialized);
		}
		object obj3 = typeof(MemberAchievementClanFeedData) + 784;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = typeof(Queue<string>) + 848;
		DateTime now = DateTime.Now;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = (nint)0 + (nint)2200;
		MiniGameInfo.LastPlayedTime = now;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj12 = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "placementId" + 56;
		object command = "m_StencilDeferredPS" + 1432;
		object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int miniGameTrials = SFSKammelnaUserExtensions.GetMiniGameTrials(localUser);
		bool flag5 = miniGameTrials != 1;
		object obj14 = 0;
		if (!flag5)
		{
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v28+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime = dateTime2.AddHours(2.0000000002328306);
			object obj17 = typeof(DataRelation) + 824;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v34+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime3 = DateTimeUtil.NextMidnight();
			bool flag8 = dateTime > dateTime3;
			bool flag9 = !flag8;
			object obj20 = !flag9;
			object obj21 = ~obj20;
			DateTime miniGameDelay = ((obj21 != null) ? dateTime : dateTime3);
			object obj22 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v40+E4]");
			bool flag10 = (nint)0 == 0;
			object obj23 = !flag10;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			MiniGameInfo.MiniGameDelay = miniGameDelay;
			obj14 = 0;
		}
		object action = "Picking audio files is not supported on iOS" + 384;
		object type = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
		ITrackEvent trackEvent = TrackerLibrary.MiniGameProjectsPlayed();
		object obj24 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v10+E4]");
		bool flag11 = (nint)0 == 0;
		object obj25 = !flag11;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		FirebaseTrack.Event((string)action, (string)type);
	}

	public void SendMove(IEnumerable<Card> cards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_0252: Expected O, but got I
		//IL_0262: Expected O, but got I
		//IL_0284: Expected O, but got I4
		//IL_028d: Expected O, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_013f: Expected I, but got O
		//IL_014f: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02c5: Expected O, but got I
		//IL_02d6: Expected I, but got O
		//IL_02f4: Expected O, but got I
		//IL_030f: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "m_StencilDeferredPS" + 2440;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3656;
		object obj3 = "m_StencilDeferredPS" + 2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v6+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v13+8]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v13+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		object obj8 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v19+B8]");
				obj6 = 0;
			}
			object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)1712;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj6, (IntPtr)obj12);
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v18+B8]");
			object obj14 = (nint)0 + (nint)8;
			obj14 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = 0;
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(cards, selector);
		object[] array = Enumerable.ToArray(source);
		object obj15 = typeof(System.IOAsyncCallback) + 976;
		object command = "m_StencilDeferredPS" + 1432;
		nint num = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X10_v5-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_01cb;
		}
		object obj18 = obj17 + 48;
		object obj19 = num + obj18;
		object obj20 = obj19 + 312;
		goto IL_0340;
		IL_0340:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X0_v12] (should have been resolved before IL gen)");
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
		Actions.SafeInvoke(this.OnMoveSent);
		return;
		IL_01cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0340;
	}

	public void SendClaim()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3392;
		object command = "m_StencilDeferredPS" + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
	}

	public void SendCleanup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 4048;
		object command = "m_StencilDeferredPS" + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0117: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2496;
		object obj3 = typeof(MemberAchievementClanFeedData) + 784;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse += eventListenerDelegate;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool canPlayMiniGameNow = MiniGameInfo.CanPlayMiniGameNow;
		ITrackEvent trackEvent = TrackerLibrary.MiniGameProjectsViewed(canPlayMiniGameNow);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse -= eventListenerDelegate;
	}

	private void OnExtensionResponse(BaseEvent evt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		object obj = "m_StencilDeferredPS" + 1432;
		string command = SFSExtensions.GetCommand(evt);
		if (command != (string)obj)
		{
			return;
		}
		object varName = "clear_mass_tournaments" + 264;
		object defaultValue = (nint)0 + (nint)2000;
		object varName2 = "startPosition" + 1328;
		ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
		string text = SFSExtensions.Get(responseParams, (string)varName, (string)defaultValue);
		if (SFSExtensions.Get(responseParams, (string)varName2, defaultValue: false))
		{
			object obj2 = "placementId" + 56;
			if (text == (string)obj2)
			{
				<State>k__BackingField.UpdateState(responseParams);
				Actions.SafeInvoke((Action<object>)this.OnGameStart, <State>k__BackingField);
				return;
			}
			object obj3 = "m_StencilDeferredPS" + 2440;
			if (text == (string)obj3)
			{
				<State>k__BackingField.UpdateState(responseParams);
				OnMoveCommand();
				return;
			}
			object obj4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3392;
			if (text == (string)obj4)
			{
				<State>k__BackingField.UpdateState(responseParams);
				Actions.SafeInvoke((Action<object>)this.OnClaim, <State>k__BackingField);
				MiniGameState miniGameState = <State>k__BackingField;
				miniGameState.<GameOngoing>k__BackingField = false;
				TrackClaim();
				return;
			}
			object obj5 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 4048;
			if (text == (string)obj5)
			{
				MiniGameState miniGameState2 = <State>k__BackingField;
				if (miniGameState2.<GameOngoing>k__BackingField)
				{
					miniGameState2.FlushState();
					OnMoveCommand();
				}
			}
		}
		else
		{
			OnCommandFail(text, responseParams);
		}
	}

	private void OnPlayCommand()
	{
		Actions.SafeInvoke((Action<object>)this.OnGameStart, <State>k__BackingField);
	}

	private void OnMoveCommand()
	{
		//IL_0056: Expected O, but got I4
		Actions.SafeInvoke((Action<object>)this.OnMove, <State>k__BackingField);
		MiniGameState miniGameState = <State>k__BackingField;
		if (miniGameState.<RemainingMoves>k__BackingField == 0)
		{
			bool flag = Enumerable.Any((IEnumerable<object>)miniGameState.<Rewards>k__BackingField);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj == null)
			{
				MiniGameState miniGameState2 = <State>k__BackingField;
				miniGameState2.<GameOngoing>k__BackingField = false;
			}
		}
	}

	private void OnClaimCommand()
	{
		Actions.SafeInvoke((Action<object>)this.OnClaim, <State>k__BackingField);
		MiniGameState miniGameState = <State>k__BackingField;
		miniGameState.<GameOngoing>k__BackingField = false;
		TrackClaim();
	}

	private void OnCommandFail(string subCommand, ISFSObject param)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0038: Expected O, but got I4
		//IL_0560: Expected O, but got I4
		//IL_01d5: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_0207: Expected O, but got I4
		//IL_038a: Expected O, but got I
		//IL_039a: Expected O, but got I
		//IL_03bc: Expected O, but got I4
		//IL_02f3: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_0085: Expected O, but got I
		//IL_00a7: Expected O, but got I4
		//IL_015c: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_0233: Expected O, but got I
		//IL_0255: Expected O, but got I4
		//IL_0267: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_03e8: Expected O, but got I
		//IL_040a: Expected O, but got I4
		//IL_041c: Expected O, but got I4
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04d6: Expected I, but got O
		//IL_04e7: Expected I, but got O
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_02b9: Expected O, but got I
		//IL_044c: Expected O, but got I4
		object varName = "destinationTimeZone" + 2696;
		object defaultValue = (nint)0 + (nint)2000;
		object obj = "fetch_products" + 2448;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3656;
		string text = SFSExtensions.Get(param, (string)varName, (string)defaultValue);
		string text2 = (string)obj;
		bool flag = text == (string)obj;
		object obj4;
		Action action;
		nint num2;
		object obj3;
		nint num;
		if (flag)
		{
			((MiniGame)flag).SendCleanup();
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+10]");
				action = (Action)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+10]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				num = 0;
				num2 = 0;
				if (obj5 == null)
				{
					goto IL_0227;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+10]");
				action = (Action)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+10]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				num = 0;
				num2 = 0;
				if (obj6 == null)
				{
					goto IL_0227;
				}
			}
			goto IL_02de;
		}
		object obj7 = "fetch_products" + 2440;
		string text3 = (string)obj7;
		bool flag4 = text == (string)obj7;
		bool flag5 = !flag4;
		num = 0;
		string text4 = null;
		if (flag5)
		{
			goto IL_02f8;
		}
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+18]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+18]");
			bool flag6 = (nint)0 == 0;
			object obj8 = !flag6;
			num = 0;
			num2 = 0;
			if (obj8 != null)
			{
				goto IL_02de;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+18]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+18]");
			bool flag7 = (nint)0 == 0;
			object obj9 = !flag7;
			num = 0;
			num2 = 0;
			if (obj9 != null)
			{
				goto IL_02de;
			}
		}
		object obj10 = (nint)0 + (nint)1704;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+E4]");
		bool flag8 = (nint)0 == 0;
		object obj11 = !flag8;
		nint num3 = 0;
		object obj12 = 24;
		object obj13;
		nint num4;
		object obj14;
		if (obj11 == null)
		{
			obj13 = obj10;
			num4 = 0;
			text2 = text3;
			obj14 = 24;
			goto IL_0297;
		}
		goto IL_04b0;
		IL_02f8:
		object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ErrorCallback onError = this.OnError;
		if (this.OnError != null)
		{
			num = ((Delegate)onError).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v131.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			text4 = text;
		}
		ITrackEvent trackEvent = TrackerLibrary.MiniGameProjectsError(text);
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v10+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0227:
		obj13 = (nint)0 + (nint)1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v22+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		num4 = 0;
		obj14 = 16;
		obj10 = obj13;
		num3 = 0;
		text3 = text2;
		obj12 = 16;
		if (obj18 == null)
		{
			goto IL_0297;
		}
		goto IL_04b0;
		IL_02de:
		ShowError(text, action);
		text4 = (string)num2;
		goto IL_02f8;
		IL_04b0:
		object obj19 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		num2 = (nint)obj10;
		Action action2 = default(Action);
		action2..ctor(obj4, (IntPtr)obj10);
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v6+B8]");
		object obj21 = 0 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num = 0;
		action = action2;
		goto IL_02de;
		IL_0297:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v13+B8]");
		obj4 = 0;
		obj10 = obj13;
		num3 = num4;
		text3 = text2;
		obj12 = obj14;
		goto IL_04b0;
	}

	private void TrackClaim()
	{
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_03f0: Expected I, but got O
		//IL_015d: Expected I, but got O
		//IL_0178: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_025a: Expected O, but got I
		//IL_026a: Expected O, but got I
		//IL_0294: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_03a2: Expected I, but got O
		//IL_01e3: Expected O, but got I
		//IL_01f3: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_0137: Expected F8, but got I
		//IL_0150: Expected O, but got I
		//IL_0364: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I
		//IL_04f4: Expected I, but got O
		//IL_0512: Expected O, but got I
		//IL_02fc: Expected O, but got I
		MiniGameState miniGameState = <State>k__BackingField;
		object obj2 = default(object);
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		nint num = default(nint);
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		ResourceCurrency resourceCurrency;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (<State>k__BackingField != null && miniGameState.<Rewards>k__BackingField != null)
		{
			object obj = (nint)0 + (nint)3544;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3656;
			obj4 = "[{0}]:{1}" + 912;
			obj5 = (nint)0 + (nint)3536;
			List<object>.Enumerator enumerator = ((List<object>)(object)miniGameState.<Rewards>k__BackingField).GetEnumerator();
			List<object>.Enumerator enumerator2 = enumerator3;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			object obj8 = default(object);
			while (enumerator4.MoveNext())
			{
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v43+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string itemId = Tracker.ItemId(ResourceItemId.Minigame);
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ stack_-78+18]");
					Tracker.ResourceEvent(ResourceFlowType.Source, ResourceItemType.Reward, itemId, 0.0, ResourceCurrency.Aces);
					resourceCurrency = ResourceCurrency.Aces;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ stack_-78+18]");
					enumerator2 = (List<object>.Enumerator)0;
					continue;
				}
				goto IL_0381;
			}
			num = (nint)obj5;
			enumerator4.Dispose();
			enumerator5 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			goto IL_017d;
		}
		goto IL_0481;
		IL_017d:
		MiniGameState miniGameState2 = <State>k__BackingField;
		object obj10;
		Func<object, object> selector;
		string separator;
		string text;
		if (<State>k__BackingField != null)
		{
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v27+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11+20]");
				selector = (Func<object, object>)0;
				separator = (string)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11+20]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					text = (string)obj4;
					goto IL_02aa;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v27+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11+20]");
				selector = (Func<object, object>)0;
				text = (string)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11+20]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				separator = (string)obj4;
				if (obj12 == null)
				{
					goto IL_02aa;
				}
			}
			goto IL_0301;
		}
		goto IL_0481;
		IL_02aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v27+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v17+B8]");
			obj10 = 0;
		}
		object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)1720;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj10, (IntPtr)obj16);
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v16+B8]");
		object obj18 = (nint)0 + (nint)32;
		obj18 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		resourceCurrency = ResourceCurrency.None;
		selector = func;
		separator = text;
		goto IL_0301;
		IL_0381:
		NullReferenceException ex = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		num = unchecked((nint)null);
		goto IL_0481;
		IL_0481:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag5 = num != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj5;
			enumerator5.Dispose();
			object obj19 = default(object);
			bool flag6 = obj19 == null;
			enumerator3 = (List<object>.Enumerator)obj19;
			if (flag6)
			{
				goto IL_017d;
			}
			ex3 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237C64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0301:
		IEnumerable<object> values = Enumerable.Select(miniGameState2.<Rewards>k__BackingField, selector);
		string prizeSequence = string.Join(separator, (IEnumerable<string>)values);
		ITrackEvent trackEvent = TrackerLibrary.MiniGameProjectsClaim(prizeSequence);
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private static void ShowError(string error, Action action)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007d: Expected I, but got O
		//IL_008d: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0166: Expected I, but got O
		//IL_0176: Expected O, but got I
		//IL_0214: Expected O, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected I, but got Unknown
		//IL_025d: Expected O, but got I4
		//IL_01b1: Expected O, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63A1]");
		nint num = 0;
		object buttonText = "Network Authentication Required" + 3128;
		object obj3 = default(object);
		object obj4 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj11 = default(object);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(action, (string)buttonText);
			nint num2;
			if (popupWindowBuilder != null)
			{
				num = (nint)("Index = {0} position = {1}" + 1744);
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)num);
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 384;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0111;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj4 = obj3 + 16;
						obj2--;
						bool flag = (nint)obj2 != 1;
						obj3 = obj4;
						if (flag)
						{
							continue;
						}
						goto IL_0111;
					}
					goto IL_021e;
				}
			}
			goto IL_0273;
			IL_0273:
			ex = new NullReferenceException();
			goto IL_0281;
			IL_0281:
			object obj5 = obj4 + 9;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v5+8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v171 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v9+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v212 @ X2_v8 (should have been resolved before IL gen)");
			goto IL_021e;
			IL_021e:
			object obj13 = num2 + obj3;
			num = (nint)(obj13 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj14 = !flag2;
			obj4 = obj3;
			if (obj14 != null)
			{
				goto IL_014a;
			}
			goto IL_0273;
			IL_0111:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X0_v11 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			num = intPtr;
			if (!flag3)
			{
				goto IL_014a;
			}
			goto IL_0273;
			IL_014a:
			object obj15 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X10_v9-8]");
					if (0 == (nint)obj15)
					{
						break;
					}
					obj4 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_01f2;
				}
				goto IL_0281;
			}
			goto IL_01f2;
		}
	}

	public MiniGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MiniGameState miniGameState = default(MiniGameState);
		miniGameState..ctor();
		object obj2 = this + 88;
		obj2 = miniGameState;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
