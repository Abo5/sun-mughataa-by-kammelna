using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class TournamentInviteManager : MonoBehaviour
{
	private sealed class <>c__DisplayClass22_0
	{
		public int dbId;

		public QueuePlayer player;

		internal bool <HandleResponse>b__0(QueuePlayer p)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					object obj = <info>k__BackingField.<DBID>k__BackingField - dbId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <HandleResponse>b__1(QueuePlayer p)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					object obj = <info>k__BackingField.<DBID>k__BackingField - dbId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <HandleResponse>b__2(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <HandleResponse>b__3(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public int dbId;

		internal bool <GetStatus>b__0(QueuePlayer i)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (i != null)
			{
				PlayerInfo <info>k__BackingField = i.<info>k__BackingField;
				if (i.<info>k__BackingField != null)
				{
					object obj = <info>k__BackingField.<DBID>k__BackingField - dbId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass26_0
	{
		public TournamentInviteManager <>4__this;

		public QueuePlayer player;

		internal void <PlayerSelected>b__1()
		{
			<>4__this.SendInvite(player);
		}

		internal void <PlayerSelected>b__2()
		{
			<>4__this.SendCancel(player);
		}

		internal void <PlayerSelected>b__3()
		{
			<>4__this.SendAccept(player);
		}

		internal void <PlayerSelected>b__4()
		{
			<>4__this.SendReject(player);
		}

		internal GameObject <PlayerSelected>g__CreateAvatar|0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0072: Expected O, but got I4
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_01ab: Expected O, but got I4
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Expected O, but got Unknown
			//IL_0247: Expected O, but got I
			//IL_0258: Expected I, but got O
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected O, but got Unknown
			//IL_0296: Expected O, but got I4
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3616;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			Component component = <>4__this;
			Component component2;
			if ((object)<>4__this != null)
			{
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = (nint)0 + (nint)872;
				Transform transform = <>4__this.transform;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				if (obj2 != null)
				{
					object obj7 = obj2 + 16;
					object obj8 = default(object);
					obj7 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					QueuePlayer queuePlayer = player;
					if (player != null && queuePlayer.<info>k__BackingField != null)
					{
						int num = default(int);
						string userDbId = num.ToString();
						User onlineUser = SFS.GetOnlineUser(userDbId);
						if (onlineUser != null)
						{
							if (obj7 != null)
							{
								((AvatarInitializer)obj7).Initialize(onlineUser);
								component2 = (Component)obj7;
								bool flag2 = obj7 == null;
								object obj9 = !flag2;
								if (obj9 != null)
								{
									goto IL_02e6;
								}
							}
						}
						else
						{
							QueuePlayer queuePlayer2 = player;
							if (player != null && queuePlayer2.<info>k__BackingField != null)
							{
								string userId = num.ToString();
								object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj11 = (nint)0 + (nint)3976;
								Action<object> action = default(Action<object>);
								action..ctor(obj2, (IntPtr)obj11);
								object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
								object obj13 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v23+E4]");
								bool flag3 = (nint)0 == 0;
								object obj14 = !flag3;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								PlayerProfilesHandler.RequestUserProfile(userId, action);
								component2 = (Component)obj7;
								if (obj7 != null)
								{
									goto IL_02e6;
								}
							}
						}
					}
				}
			}
			return (GameObject)(object)new NullReferenceException();
			IL_02e6:
			return component2.gameObject;
		}
	}

	private sealed class <>c__DisplayClass26_1
	{
		public AvatarInitializer avatar;

		internal void <PlayerSelected>b__5(PlayerProfileModel p)
		{
			AvatarData data = p;
			avatar.Initialize(data);
		}
	}

	private sealed class <>c__DisplayClass27_0
	{
		public QueuePlayer player;

		public TournamentInviteManager <>4__this;

		internal void <SendInvite>g__Callback|0()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			//IL_005a: Expected I, but got O
			//IL_006b: Expected O, but got I
			//IL_00b6: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_0187: Expected O, but got I
			//IL_0197: Expected O, but got I
			//IL_01a7: Expected O, but got I
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_022f: Expected O, but got I4
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Expected O, but got Unknown
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Expected O, but got Unknown
			QueuePlayer queuePlayer = player;
			queuePlayer.<status>k__BackingField = QueuePlayer.Status.PendingRequest;
			TournamentInviteManager tournamentInviteManager = <>4__this;
			object obj = typeof(List<Tween>) + 3408;
			object obj2 = (nint)0 + (nint)3984;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor((object)this, (IntPtr)obj2);
			object obj3 = (nint)0 + (nint)2960;
			object obj4 = obj3;
			int num = ((List<object>)(object)tournamentInviteManager.invites).RemoveAll(predicate);
			TournamentInviteManager tournamentInviteManager2 = <>4__this;
			List<object> invites = (List<object>)(object)tournamentInviteManager2.invites;
			object obj5 = (nint)0 + (nint)2928;
			object obj6 = obj5;
			int version = invites._version + 1;
			invites._version = version;
			object[] items = invites._items;
			bool flag = invites._size < items.Length;
			object obj7 = !flag;
			if (obj7 == null)
			{
				int size = invites._size + 1;
				invites._size = size;
				object obj8 = items + invites._size;
				object obj9 = obj8 + 32;
				obj9 = player;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v9+20]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v16+C0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v17+70]");
				obj4 = 0;
				invites.AddWithResize((object)player);
			}
			TournamentInviteManager tournamentInviteManager3 = <>4__this;
			List<object> watchedPlayers = (List<object>)(object)tournamentInviteManager3.watchedPlayers;
			int version2 = watchedPlayers._version + 1;
			watchedPlayers._version = version2;
			object[] items2 = watchedPlayers._items;
			bool flag2 = watchedPlayers._size < items2.Length;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				int size2 = watchedPlayers._size + 1;
				watchedPlayers._size = size2;
				object obj13 = items2 + watchedPlayers._size;
				object obj14 = obj13 + 32;
				obj14 = player;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				watchedPlayers.AddWithResize((object)player);
			}
		}

		internal bool <SendInvite>b__1(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public TournamentInviteManager <>4__this;

		public QueuePlayer player;

		internal void <SendCancel>g__Callback|0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_003d: Expected I, but got O
			//IL_004e: Expected O, but got I
			//IL_007f: Expected O, but got I
			//IL_0097: Expected I, but got O
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00fa: Expected O, but got I4
			//IL_012f: Expected O, but got I
			//IL_0144: Expected O, but got I
			TournamentInviteManager tournamentInviteManager = <>4__this;
			object obj = typeof(List<Tween>) + 3408;
			object obj2 = (nint)0 + (nint)4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor((object)this, (IntPtr)obj2);
			object obj3 = (nint)0 + (nint)2960;
			int num = ((List<object>)(object)tournamentInviteManager.invites).RemoveAll(predicate);
			TournamentInviteManager tournamentInviteManager2 = <>4__this;
			object obj4 = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate2 = default(Predicate<object>);
			predicate2..ctor((object)this, (IntPtr)obj4);
			object obj5 = typeof(DataRelation) + 712;
			int num2 = ((List<object>)(object)tournamentInviteManager2.watchedPlayers).RemoveAll(predicate2);
			TournamentInviteManager tournamentInviteManager3 = <>4__this;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v7+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8+10]");
			tournamentInviteManager3.lastInviteTime = (DateTime)0;
		}

		internal bool <SendCancel>b__1(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SendCancel>b__2(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass29_0
	{
		public TournamentInviteManager <>4__this;

		public Action callback;

		internal void <SendAccept>g__Callback|0()
		{
			TournamentInviteManager tournamentInviteManager = <>4__this;
			List<QueuePlayer> invites = tournamentInviteManager.invites;
			int version = invites._version + 1;
			invites._size = 0;
			invites._version = version;
			if (invites._size >= 1)
			{
				Array.Clear(invites._items, 0, invites._size);
				tournamentInviteManager = <>4__this;
			}
			List<QueuePlayer> watchedPlayers = tournamentInviteManager.watchedPlayers;
			int version2 = watchedPlayers._version + 1;
			watchedPlayers._size = 0;
			watchedPlayers._version = version2;
			if (watchedPlayers._size >= 1)
			{
				Array.Clear(watchedPlayers._items, 0, watchedPlayers._size);
			}
			Actions.SafeInvoke(callback);
		}
	}

	private sealed class <>c__DisplayClass30_0
	{
		public QueuePlayer player;

		public TournamentInviteManager <>4__this;

		public Action callback;

		internal void <SendReject>g__Callback|0()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			//IL_005a: Expected I, but got O
			//IL_006b: Expected O, but got I
			//IL_00b6: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_0187: Expected O, but got I
			//IL_0197: Expected O, but got I
			//IL_01a7: Expected O, but got I
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_01d6: Expected O, but got I
			//IL_01ee: Expected I, but got O
			QueuePlayer queuePlayer = player;
			queuePlayer.<status>k__BackingField = QueuePlayer.Status.Rejected;
			TournamentInviteManager tournamentInviteManager = <>4__this;
			object obj = typeof(List<Tween>) + 3408;
			object obj2 = (nint)0 + (nint)4032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor((object)this, (IntPtr)obj2);
			object obj3 = (nint)0 + (nint)2960;
			object obj4 = obj3;
			int num = ((List<object>)(object)tournamentInviteManager.invites).RemoveAll(predicate);
			TournamentInviteManager tournamentInviteManager2 = <>4__this;
			List<object> invites = (List<object>)(object)tournamentInviteManager2.invites;
			object obj5 = (nint)0 + (nint)2928;
			object obj6 = obj5;
			int version = invites._version + 1;
			invites._version = version;
			object[] items = invites._items;
			bool flag = invites._size < items.Length;
			object obj7 = !flag;
			if (obj7 == null)
			{
				int size = invites._size + 1;
				invites._size = size;
				object obj8 = items + invites._size;
				object obj9 = obj8 + 32;
				obj9 = player;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v9+20]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v12+C0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+70]");
				obj4 = 0;
				invites.AddWithResize((object)player);
			}
			TournamentInviteManager tournamentInviteManager3 = <>4__this;
			object obj12 = (nint)0 + (nint)4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate2 = default(Predicate<object>);
			predicate2..ctor((object)this, (IntPtr)obj12);
			int num2 = ((List<object>)(object)tournamentInviteManager3.watchedPlayers).RemoveAll(predicate2);
			Actions.SafeInvoke(callback);
		}

		internal bool <SendReject>b__1(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SendReject>b__2(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public int myDbId;

		public QueuePlayer myPlayer;

		internal bool <QueueUpdated>b__0(QueuePlayer player)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (player != null)
			{
				PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
				if (player.<info>k__BackingField != null)
				{
					object obj = <info>k__BackingField.<DBID>k__BackingField - myDbId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <QueueUpdated>b__1(QueuePlayer p)
		{
			//IL_00e5: Expected I4, but got O
			//IL_00b2: Expected O, but got I4
			if (p != null)
			{
				QueuePlayer queuePlayer = myPlayer;
				if (myPlayer != null)
				{
					if (p.<team>k__BackingField != queuePlayer.<team>k__BackingField)
					{
						return false;
					}
					PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
					if (p.<info>k__BackingField != null)
					{
						object obj = <info>k__BackingField.<DBID>k__BackingField - myDbId;
						bool flag = obj == null;
						return !flag;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <QueueUpdated>b__2(QueuePlayer player)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (player != null)
			{
				PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
				if (player.<info>k__BackingField != null)
				{
					object obj = <info>k__BackingField.<DBID>k__BackingField - myDbId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass34_1
	{
		public QueuePlayer invite;

		internal bool <QueueUpdated>b__3(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = invite;
					if (invite != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <QueueUpdated>b__4(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = invite;
					if (invite != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <QueueUpdated>b__5(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = invite;
					if (invite != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass34_2
	{
		public QueuePlayer player;

		internal bool <QueueUpdated>b__6(QueuePlayer p)
		{
			//IL_0117: Expected I4, but got O
			//IL_00e4: Expected O, but got I4
			if (p != null)
			{
				QueuePlayer queuePlayer = player;
				if (player != null)
				{
					if (p.<team>k__BackingField != queuePlayer.<team>k__BackingField)
					{
						return false;
					}
					PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
					if (p.<info>k__BackingField != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							bool flag = obj == null;
							return !flag;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <QueueUpdated>b__7(QueuePlayer p)
		{
			//IL_0117: Expected I4, but got O
			//IL_00e4: Expected O, but got I4
			if (p != null)
			{
				QueuePlayer queuePlayer = player;
				if (player != null)
				{
					if (p.<team>k__BackingField != queuePlayer.<team>k__BackingField)
					{
						return false;
					}
					PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
					if (p.<info>k__BackingField != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							bool flag = obj == null;
							return !flag;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass35_0
	{
		public QueuePlayer player;

		internal bool <MarkRejected>b__0(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <MarkRejected>b__1(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const int CoolDown = 10;

	private const string Request = "tti";

	private const string Command = "cmd";

	private const string CommandRequest = "rq";

	private const string CommandCancel = "cncl";

	private const string CommandAccept = "acp";

	private const string CommandReject = "rj";

	private const string Recipient = "recipient_id";

	private const string Invitor = "invitor_id";

	private const string Unauthorized = "unauthorized";

	private const string NotOnline = "not_online";

	private const string NoSeats = "no_seats";

	private TeamInvitesPanel invitesPanel;

	private AvatarInitializer avatarTemplate;

	private TournamentSceneEventsChannel tournamentEventsChannel;

	private readonly List<QueuePlayer> invites;

	private readonly List<QueuePlayer> watchedPlayers;

	private Action lastRequestCallback;

	private DateTime lastInviteTime;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0156: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00db: Expected I, but got O
		//IL_010a: Expected O, but got I4
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 616;
		object obj2 = (nint)0 + (nint)904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)912;
		tournamentEventsChannel.OnAcceptInvite += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj3);
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj5 = (nint)0 + (nint)896;
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 816;
		tournamentEventsChannel.OnRejectInvite += action2;
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.AddListener(go, (string)command, onlyOnce: false, action3);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008a: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 616;
		object obj2 = (nint)0 + (nint)904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)912;
		tournamentEventsChannel.OnAcceptInvite -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj3);
		tournamentEventsChannel.OnRejectInvite -= action2;
	}

	private void OnExtensionsResponse(ISFSObject param)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0190: Expected I, but got O
		//IL_01a0: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0236: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_036e: Expected O, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_01db: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_016b: Expected O, but got I4
		//IL_049e: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0319: Expected O, but got I
		//IL_033d: Expected O, but got I4
		//IL_04c2: Expected I4, but got I8
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_027e: Expected O, but got I4
		object obj = typeof(System.IOAsyncCallback) + 976;
		object varName = "destinationTimeZone" + 2696;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X10_v14-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00bc;
		}
		object obj4 = obj3 + 1;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ X0_v56] (should have been resolved before IL gen)");
		object obj7 = default(object);
		bool flag = obj7 == null;
		object obj8 = !flag;
		if (obj8 != null)
		{
			goto IL_00ed;
		}
		goto IL_0179;
		IL_0353:
		object varName2 = "clear_mass_tournaments" + 264;
		object defaultValue = (nint)0 + (nint)2000;
		string text = SFSExtensions.Get(param, (string)varName2, (string)defaultValue);
		object obj9 = "rightCtrl" + 584;
		bool flag2 = text == (string)obj9;
		bool flag3 = !flag2;
		object obj10 = !flag3;
		object varName3;
		if (obj10 == null)
		{
			object obj11 = "clear_mass_tournaments" + 304;
			if (!(text == (string)obj11))
			{
				varName3 = "placementId" + 2600;
				goto IL_04ac;
			}
		}
		varName3 = "https://www.kammelna.com/Home/Terms" + 2288;
		goto IL_04ac;
		IL_0440:
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj13;
		if (lastRequestCallback != null)
		{
			Actions.SafeInvoke(lastRequestCallback);
			obj13 = 0;
		}
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v33+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		tournamentEventsChannel.TriggerUpdateQueue();
		return;
		IL_00ed:
		object defaultValue2 = (nint)0 + (nint)2000;
		string error = SFSExtensions.Get(param, (string)varName, (string)defaultValue2);
		HandleError(error);
		return;
		IL_04ac:
		int dbId = SFSExtensions.Get(param, (string)varName3, -1);
		HandleResponse(text, dbId);
		return;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ X0_v53] (should have been resolved before IL gen)");
		object obj16 = default(object);
		if (obj16 != null)
		{
			goto IL_00ed;
		}
		goto IL_0179;
		IL_0179:
		object obj17 = "startPosition" + 1328;
		nint num2 = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_021c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj19 += 16;
			obj18--;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_021c;
		}
		object obj20 = obj19 + 1;
		object obj21 = num2 + obj20;
		object obj22 = obj21 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v45+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v368 @ X0_v45] (should have been resolved before IL gen)");
		object obj24 = default(object);
		bool flag5 = obj24 == null;
		object obj25 = !flag5;
		obj13 = obj17;
		if (obj25 != null)
		{
			goto IL_0440;
		}
		goto IL_0353;
		IL_021c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v42+8]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v336 @ X0_v42] (should have been resolved before IL gen)");
		object obj26 = default(object);
		bool flag6 = obj26 == null;
		obj13 = obj17;
		if (flag6)
		{
			goto IL_0353;
		}
		goto IL_0440;
	}

	private void HandleResponse(string command, int dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0065: Expected I, but got O
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0244: Expected O, but got I4
		//IL_026d: Expected O, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I4
		//IL_02b1: Expected O, but got I
		//IL_02c2: Expected I, but got O
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0317: Expected O, but got I4
		//IL_0320: Expected O, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_013e: Expected O, but got I
		//IL_0383: Expected O, but got I
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_0198: Expected O, but got I4
		//IL_03c5: Expected O, but got I
		//IL_03d6: Expected I, but got O
		//IL_0589: Expected O, but got I
		//IL_0599: Expected O, but got I
		//IL_05a9: Expected O, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_0786: Expected O, but got I
		//IL_0797: Expected I, but got O
		//IL_0624: Expected O, but got I4
		//IL_07a8: Expected O, but got I
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_07f9: Expected O, but got I4
		//IL_0699: Expected O, but got I
		//IL_06a9: Expected O, but got I
		//IL_06b9: Expected O, but got I
		//IL_0863: Expected O, but got I
		//IL_0875: Expected O, but got I
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
		object obj4 = (nint)0 + (nint)3904;
		object obj5 = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj6 = Enumerable.FirstOrDefault(invites, func);
		object obj7;
		if (obj6 != null)
		{
			obj7 = obj2 + 24;
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag = obj7 == null;
			object obj8 = 0;
			if (flag)
			{
				return;
			}
		}
		else
		{
			object obj9 = typeof(Queue<string>) + 848;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			Room currentRoom = sessionModel.CurrentRoom;
			List<QueuePlayer> tournamentQueue = SFSKammelnaRoomExtensions.GetTournamentQueue(currentRoom);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)3912;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj2, (IntPtr)obj13);
			object obj14 = Enumerable.FirstOrDefault(tournamentQueue, func2);
			obj7 = obj2 + 24;
			obj7 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag3 = obj7 == null;
			object obj15 = !flag3;
			object obj8 = 0;
			if (obj15 == null)
			{
				return;
			}
		}
		object obj16 = "rightCtrl" + 584;
		if (command == (string)obj16)
		{
			_ = 3;
			List<object> list = (List<object>)(object)invites;
			object obj17 = (nint)0 + (nint)2928;
			object obj18 = obj17;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag4 = list._size < items.Length;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj20 = items + list._size;
				object obj21 = obj20 + 32;
				obj21 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj22 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v48+20]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v55+C0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v56+70]");
				object obj22 = 0;
				list.AddWithResize(obj7);
			}
			List<object> list2 = (List<object>)(object)watchedPlayers;
			object obj25 = obj17;
			int version2 = list2._version + 1;
			list2._version = version2;
			object[] items2 = list2._items;
			bool flag5 = list2._size < items2.Length;
			object obj26 = !flag5;
			if (obj26 == null)
			{
				int size2 = list2._size + 1;
				list2._size = size2;
				object obj27 = items2 + list2._size;
				object obj28 = obj27 + 32;
				obj28 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v50+20]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v52+C0]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v53+70]");
				object obj22 = 0;
				list2.AddWithResize(obj7);
			}
			invitesPanel.ShowInvite((QueuePlayer)obj7);
		}
		else
		{
			object obj31 = "clear_mass_tournaments" + 304;
			if (command == (string)obj31)
			{
				_ = 0;
				object obj32 = (nint)0 + (nint)2952;
				bool flag6 = ((List<object>)(object)invites).Remove(obj7);
				object obj33 = typeof(List<Tween>) + 3408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj34 = (nint)0 + (nint)3920;
				Predicate<object> predicate = default(Predicate<object>);
				predicate..ctor(obj2, (IntPtr)obj34);
				int num = ((List<object>)(object)watchedPlayers).RemoveAll(predicate);
				object message = "startPosition" + 3968;
				invitesPanel.ShowNotification((QueuePlayer)obj7, (string)message, overrideExisting: true);
			}
			else
			{
				object obj35 = "___# Content push apply failed [{0}]: {1}" + 2992;
				if (command == (string)obj35)
				{
					List<QueuePlayer> list3 = invites;
					int version3 = list3._version + 1;
					list3._size = 0;
					list3._version = version3;
					if (list3._size >= 1)
					{
						Array.Clear(list3._items, 0, list3._size);
					}
					List<QueuePlayer> list4 = watchedPlayers;
					int version4 = list4._version + 1;
					list4._size = 0;
					list4._version = version4;
					if (list4._size >= 1)
					{
						Array.Clear(list4._items, 0, list4._size);
					}
					QueuePlayer queuePlayer = (QueuePlayer)obj7;
					queuePlayer.<status>k__BackingField = QueuePlayer.Status.Accepted;
					invitesPanel.ShowAccepted(queuePlayer);
				}
				else
				{
					object obj36 = "rightCtrl" + 192;
					if (command == (string)obj36)
					{
						QueuePlayer queuePlayer2 = (QueuePlayer)obj7;
						queuePlayer2.<status>k__BackingField = QueuePlayer.Status.Rejected;
						invitesPanel.ShowRejected(queuePlayer2);
						object obj37 = typeof(List<Tween>) + 3408;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj38 = (nint)0 + (nint)3928;
						Predicate<object> predicate2 = default(Predicate<object>);
						predicate2..ctor(obj2, (IntPtr)obj38);
						object obj39 = (nint)0 + (nint)2960;
						int num2 = ((List<object>)(object)watchedPlayers).RemoveAll(predicate2);
						object obj40 = typeof(DataRelation) + 712;
						object obj41 = obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v41+E4]");
						bool flag7 = (nint)0 == 0;
						object obj42 = !flag7;
						if (obj42 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj41 = obj40;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v41+B8]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v31+10]");
						lastInviteTime = (DateTime)0;
					}
				}
			}
		}
		tournamentEventsChannel.TriggerUpdateQueue();
	}

	private void HandleError(string error)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_004d: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0246: Expected O, but got I4
		//IL_0124: Expected O, but got I
		object obj = "tournament_participate_warning_body_with_tickets_warning_daily" + 1504;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		string text = (string)obj;
		object obj5;
		object obj7;
		string text3;
		if (error == (string)obj)
		{
			object obj4 = obj3;
			obj5 = "startPosition" + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			string text2 = null;
			obj7 = obj5;
			if (obj6 == null)
			{
				goto IL_0068;
			}
		}
		else
		{
			object obj8 = "not" + 136;
			text = (string)obj8;
			if (error == (string)obj8)
			{
				object obj4 = obj3;
				obj7 = "startPosition" + 4008;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v22+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					string text2 = null;
					obj5 = obj7;
					goto IL_0068;
				}
			}
			else
			{
				object obj10 = "m_StencilDeferredPS" + 3848;
				text = (string)obj10;
				bool flag3 = error == (string)obj10;
				bool flag4 = !flag3;
				text3 = null;
				if (flag4)
				{
					goto IL_00c4;
				}
				object obj4 = obj3;
				obj7 = "startPosition" + 4000;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v22+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					string text2 = null;
					obj5 = obj7;
					goto IL_0068;
				}
			}
		}
		goto IL_007f;
		IL_0068:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj5;
		goto IL_007f;
		IL_00c4:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v12+B8]");
		object obj14 = 0;
		object obj15 = this + 72;
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v11+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X19_v2-18]");
		((TournamentSceneEventsChannel)0).TriggerUpdateQueue();
		return;
		IL_007f:
		object title = "startPosition" + 3984;
		object obj16 = "Network Authentication Required" + 3128;
		text = (string)obj7;
		text3 = (string)obj16;
		PopupWindow.ShowError((string)title, (string)obj7, (string)obj16);
		goto IL_00c4;
	}

	private void ConfirmLastRequest()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_003f: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		if (lastRequestCallback != null)
		{
			Actions.SafeInvoke(lastRequestCallback);
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		tournamentEventsChannel.TriggerUpdateQueue();
	}

	public QueuePlayer.Status GetStatus(int dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ba: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		//IL_0089: Expected I4, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
			object obj4 = (nint)0 + (nint)3936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			object obj5 = Enumerable.FirstOrDefault(invites, func);
			bool flag = obj5 == null;
			QueuePlayer.Status result = (QueuePlayer.Status)obj5;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8 (System.Object)+20]");
				result = QueuePlayer.Status.None;
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (QueuePlayer.Status)ex;
	}

	public unsafe void PlayerSelected(QueuePlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0098: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_037a: Expected O, but got I4
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected O, but got Unknown
		//IL_0729: Expected I, but got O
		//IL_0739: Expected O, but got I
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03bd: Expected O, but got I8
		//IL_07f3: Expected O, but got I4
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected O, but got Unknown
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Expected O, but got Unknown
		//IL_0c07: Expected O, but got I
		//IL_0774: Expected O, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_015f: Expected O, but got I
		//IL_0170: Expected I, but got O
		//IL_0853: Expected O, but got I4
		//IL_0871: Expected O, but got I4
		//IL_0440: Expected O, but got I4
		//IL_045e: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I4
		//IL_01c8: Expected I, but got O
		//IL_0c42: Expected O, but got I
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected O, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0496: Expected O, but got I4
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected O, but got Unknown
		//IL_08a9: Expected O, but got I
		//IL_08ba: Expected I, but got O
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected O, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected O, but got Unknown
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_090a: Expected O, but got I4
		//IL_0912: Expected I, but got O
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0216: Expected O, but got I4
		//IL_021b: Expected I, but got O
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f32: Expected O, but got Unknown
		//IL_0f4a: Expected O, but got I
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_0526: Expected O, but got I4
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Expected O, but got Unknown
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected O, but got Unknown
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_1705: Expected O, but got Unknown
		//IL_173c: Expected O, but got I4
		//IL_174e: Expected O, but got I4
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected O, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected O, but got Unknown
		//IL_0953: Expected I, but got O
		//IL_0963: Expected O, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_025c: Expected I, but got O
		//IL_026c: Expected O, but got I
		//IL_192a: Unknown result type (might be due to invalid IL or missing references)
		//IL_192f: Expected O, but got Unknown
		//IL_1945: Expected O, but got I
		//IL_1956: Expected I, but got O
		//IL_1960: Unknown result type (might be due to invalid IL or missing references)
		//IL_1965: Expected O, but got Unknown
		//IL_0f85: Expected O, but got I
		//IL_0a1d: Expected O, but got I4
		//IL_1274: Expected O, but got I4
		//IL_1279: Expected I, but got O
		//IL_055b: Expected O, but got I4
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected O, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected O, but got Unknown
		//IL_0adf: Expected O, but got I
		//IL_099e: Expected O, but got I
		//IL_16c4: Expected O, but got I4
		//IL_02a7: Expected O, but got I
		//IL_1237: Unknown result type (might be due to invalid IL or missing references)
		//IL_123c: Expected O, but got Unknown
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_1257: Expected O, but got Unknown
		//IL_060e: Expected O, but got I4
		//IL_0a34: Expected O, but got I4
		//IL_12a7: Expected O, but got I
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Expected O, but got Unknown
		//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa6: Expected O, but got Unknown
		//IL_0571: Expected I, but got O
		//IL_0581: Expected O, but got I
		//IL_05b8: Expected O, but got I4
		//IL_05d1: Expected O, but got I
		//IL_181f: Expected O, but got I4
		//IL_0b1a: Expected O, but got I
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected O, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected O, but got Unknown
		//IL_0a8e: Expected O, but got I4
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Expected O, but got Unknown
		//IL_0ce6: Expected O, but got I
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Expected O, but got Unknown
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Expected O, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected O, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Expected O, but got Unknown
		//IL_0da0: Expected O, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_1a20: Expected O, but got I
		//IL_1a31: Expected I, but got O
		//IL_1a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a40: Expected O, but got Unknown
		//IL_12e2: Expected O, but got I
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_06b0: Expected O, but got I4
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected O, but got Unknown
		//IL_0e10: Expected O, but got I
		//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Expected O, but got Unknown
		//IL_1066: Expected O, but got I
		//IL_1086: Expected O, but got I4
		//IL_0d21: Expected O, but got I
		//IL_1398: Expected O, but got I4
		//IL_139d: Expected I, but got O
		//IL_176f: Expected O, but got I4
		//IL_0eca: Expected O, but got I4
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected O, but got Unknown
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Expected O, but got Unknown
		//IL_0db7: Expected O, but got I4
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_137b: Expected O, but got Unknown
		//IL_1192: Expected O, but got I
		//IL_0e4b: Expected O, but got I
		//IL_1ac4: Expected O, but got I
		//IL_10aa: Expected O, but got I
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Expected O, but got Unknown
		//IL_0ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Expected O, but got Unknown
		//IL_1030: Expected O, but got I4
		//IL_13cb: Expected O, but got I
		//IL_12f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Expected O, but got Unknown
		//IL_12fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1303: Expected O, but got Unknown
		//IL_0ee1: Expected O, but got I4
		//IL_199f: Expected O, but got I4
		//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected O, but got Unknown
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected O, but got Unknown
		//IL_1483: Expected O, but got I4
		//IL_11cd: Expected O, but got I
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Expected O, but got Unknown
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Expected O, but got Unknown
		//IL_1154: Expected O, but got I4
		//IL_1567: Unknown result type (might be due to invalid IL or missing references)
		//IL_156c: Expected O, but got Unknown
		//IL_1582: Unknown result type (might be due to invalid IL or missing references)
		//IL_1587: Expected O, but got Unknown
		//IL_1406: Expected O, but got I
		//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Expected O, but got Unknown
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected O, but got Unknown
		//IL_10b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected O, but got Unknown
		//IL_10c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected O, but got Unknown
		//IL_14b9: Expected O, but got I
		//IL_14d9: Expected O, but got I4
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1340: Expected O, but got Unknown
		//IL_1356: Unknown result type (might be due to invalid IL or missing references)
		//IL_135b: Expected O, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a7: Expected O, but got Unknown
		//IL_15db: Expected O, but got I4
		//IL_15e4: Expected O, but got I4
		//IL_11db: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e0: Expected O, but got Unknown
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Expected O, but got Unknown
		//IL_10f4: Expected O, but got I4
		//IL_14fd: Expected O, but got I
		//IL_1414: Unknown result type (might be due to invalid IL or missing references)
		//IL_1419: Expected O, but got Unknown
		//IL_1422: Unknown result type (might be due to invalid IL or missing references)
		//IL_1427: Expected O, but got Unknown
		//IL_1a9e: Expected O, but got I4
		//IL_150b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1510: Expected O, but got Unknown
		//IL_1519: Unknown result type (might be due to invalid IL or missing references)
		//IL_151e: Expected O, but got Unknown
		//IL_1539: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		QueuePlayer queuePlayer = null;
		object obj14;
		object obj20;
		object obj25 = default(object);
		object obj18;
		nint num;
		object obj11;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			bool flag2 = obj4 == null;
			queuePlayer = player;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v6+10]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v6+10]");
				bool flag3 = (nint)0 == 0;
				queuePlayer = player;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v7+10]");
					QueuePlayer.Status status = GetStatus(0);
					if (status <= QueuePlayer.Status.PendingRequest)
					{
						if (status == QueuePlayer.Status.None)
						{
							goto IL_033c;
						}
						if (status != QueuePlayer.Status.PendingRequest)
						{
							return;
						}
						object obj7 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj8 = (nint)0 + (nint)3952;
						Action action = default(Action);
						action..ctor(obj2, (IntPtr)obj8);
						object obj9 = "COORDINATE_TYPE_GCJ_02" + 1864;
						object obj10 = "AvailableVoices" + 768;
						PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, (string)obj9, (string)obj10);
						bool flag4 = popupWindowBuilder == null;
						obj11 = 0;
						num = (nint)obj10;
						queuePlayer = (QueuePlayer)obj9;
						if (!flag4)
						{
							object obj12 = "October" + 3720;
							IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)obj12);
							bool flag5 = popupWindowBuilderNeedsBody == null;
							obj11 = 0;
							num = unchecked((nint)null);
							queuePlayer = (QueuePlayer)obj12;
							if (!flag5)
							{
								object obj13 = typeof(System.IOAsyncCallback) + 384;
								obj14 = "Unsupported map type" + 3480;
								nint num2 = (nint)popupWindowBuilderNeedsBody;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v123 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v123 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_02e8;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v123 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
								object obj16 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X10_v79-8]");
									if (0 == (nint)obj13)
									{
										break;
									}
									obj16 += 16;
									obj15--;
									if ((nint)obj15 != 1)
									{
										continue;
									}
									goto IL_02e8;
								}
								object obj17 = num2 + obj16;
								obj18 = obj17 + 312;
								goto IL_1685;
							}
						}
					}
					else
					{
						if (status != QueuePlayer.Status.PendingResponse)
						{
							if (status == QueuePlayer.Status.Rejected)
							{
								goto IL_033c;
							}
							return;
						}
						IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
						bool flag6 = popupWindowBuilderNeedsTitle == null;
						queuePlayer = null;
						if (!flag6)
						{
							object obj19 = typeof(System.IOAsyncCallback) + 392;
							obj20 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 736;
							nint num3 = (nint)popupWindowBuilderNeedsTitle;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v73 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v73 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_07b5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v73 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
							object obj22 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v63-8]");
								if (0 == (nint)obj19)
								{
									break;
								}
								obj22 += 16;
								obj21--;
								if ((nint)obj21 != 1)
								{
									continue;
								}
								goto IL_07b5;
							}
							object obj23 = num3 + obj22;
							object obj24 = obj23 + 312;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v108+8]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v432 @ X8_v108] (should have been resolved before IL gen)");
							bool flag7 = obj25 == null;
							queuePlayer = (QueuePlayer)obj20;
							if (!flag7)
							{
								goto IL_0bcc;
							}
						}
					}
				}
			}
		}
		goto IL_15fa;
		IL_1a00:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1587 @ X0_v105] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)3968;
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj26);
		object label = "Read object reference Id '{0}' for {1}." + 1144;
		PopupButton popupButton = PopupButton.Neutral((string)label, action2);
		object obj27 = default(object);
		bool flag8 = obj27 == null;
		obj11 = 0;
		num = unchecked((nint)null);
		queuePlayer = (QueuePlayer)(object)action2;
		object obj31;
		object obj34 = default(object);
		if (!flag8)
		{
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v95+12E]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v95+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1447;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v95+B0]");
			object obj30 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v43-8]");
				if (0 == (nint)obj31)
				{
					break;
				}
				obj30 += 16;
				obj29--;
				if ((nint)obj29 != 1)
				{
					continue;
				}
				goto IL_1447;
			}
			object obj32 = obj28 + obj30;
			object obj33 = obj32 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1722 @ X0_v117+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1722 @ X0_v117] (should have been resolved before IL gen)");
			bool flag9 = obj34 == null;
			object obj35 = !flag9;
			obj11 = 0;
			queuePlayer = (QueuePlayer)(object)popupButton;
			if (obj35 != null)
			{
				goto IL_1499;
			}
		}
		goto IL_15fa;
		IL_1608:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_1616;
		IL_0e8c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X0_v46+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1547 @ X0_v46] (should have been resolved before IL gen)");
		object obj36 = default(object);
		bool flag10 = obj36 == null;
		object obj37 = !flag10;
		if (obj37 != null)
		{
			goto IL_117a;
		}
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X0_v46+8]");
		num = 0;
		GameObject gameObject;
		queuePlayer = (QueuePlayer)(object)gameObject;
		goto IL_15fa;
		IL_1499:
		object obj38 = obj31;
		object obj39 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X8_v9+12E]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X8_v9+12E]");
		bool flag11 = (nint)0 == 0;
		object obj41 = 0;
		if (flag11)
		{
			goto IL_1547;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X8_v9+B0]");
		object obj42 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ X10_v5-8]");
			bool flag12 = 0 == (nint)obj38;
			obj41 = 0;
			if (flag12)
			{
				break;
			}
			obj42 += 16;
			obj40--;
			bool flag13 = (nint)obj40 != 1;
			obj41 = 0;
			if (flag13)
			{
				continue;
			}
			goto IL_1547;
		}
		goto IL_155e;
		IL_046c:
		object obj44;
		object obj43 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v61+E4]");
		bool flag14 = (nint)0 == 0;
		object obj45 = !flag14;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime2;
		DateTime dateTime = ((DateTime*)dateTime2)->AddSeconds(8.000000000465661);
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = dateTime - now;
		object obj46 = typeof(DataRelation) + 824;
		object obj47 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X8_v58+E4]");
		bool flag15 = (nint)0 == 0;
		object obj48 = !flag15;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string durationText = DateTimeUtil.GetDurationText(timeSpan, 1, DateTimeUnit.Seconds);
		object obj49 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag16 = array == null;
		double num6;
		double num5 = num6;
		double num7 = 8.000000000465661;
		obj11 = 0;
		num = 5;
		queuePlayer = (QueuePlayer)1;
		if (flag16)
		{
			goto IL_15fa;
		}
		bool flag17 = durationText == null;
		QueuePlayer queuePlayer2 = (QueuePlayer)1;
		if (!flag17)
		{
			nint num8 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v68 (Il2CppClass<System.Object[]>)+40]");
			queuePlayer2 = (QueuePlayer)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag18 = ex == null;
			num5 = num6;
			num7 = 8.000000000465661;
			obj11 = 0;
			num = 5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v68 (Il2CppClass<System.Object[]>)+40]");
			queuePlayer = (QueuePlayer)0;
			if (flag18)
			{
				goto IL_1616;
			}
		}
		bool flag19 = array.Length == 0;
		num5 = num6;
		num7 = 8.000000000465661;
		obj11 = 0;
		num = 5;
		queuePlayer = queuePlayer2;
		if (!flag19)
		{
			object obj50 = array + 32;
			obj50 = durationText;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object text = "startPosition" + 3976;
			LocalizableText text2 = TextMeshProExtensions.LocalizeWith((string)text, array);
			object obj51 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v67+E4]");
			bool flag20 = (nint)0 == 0;
			object obj53 = !flag20;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(text2, (Vector2)0, 0f);
			return;
		}
		goto IL_1608;
		IL_09df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X0_v54+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1087 @ X0_v54] (should have been resolved before IL gen)");
		object obj54 = default(object);
		bool flag21 = obj54 == null;
		object obj55 = !flag21;
		if (obj55 != null)
		{
			goto IL_0aa4;
		}
		obj11 = 0;
		object obj56;
		queuePlayer = (QueuePlayer)obj56;
		goto IL_15fa;
		IL_1aac:
		object obj58;
		object obj57 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v8+8]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v602 @ X2_v5 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_02e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj60 = default(object);
		obj18 = obj60;
		goto IL_1685;
		IL_1616:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_1447:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1707 @ X0_v114+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1707 @ X0_v114] (should have been resolved before IL gen)");
		bool flag22 = obj34 == null;
		obj11 = 0;
		queuePlayer = (QueuePlayer)(object)popupButton;
		if (!flag22)
		{
			goto IL_1499;
		}
		goto IL_15fa;
		IL_07b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v128+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v781 @ X0_v128] (should have been resolved before IL gen)");
		bool flag23 = obj25 == null;
		object obj61 = !flag23;
		if (obj61 != null)
		{
			goto IL_0bcc;
		}
		queuePlayer = (QueuePlayer)obj20;
		goto IL_15fa;
		IL_0bcc:
		object obj62 = typeof(System.IOAsyncCallback) + 384;
		object obj63 = "WhiteSmoke" + 2096;
		object obj64 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v79+12E]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v79+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c83;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v79+B0]");
		object obj66 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X10_v58-8]");
			if (0 == (nint)obj62)
			{
				break;
			}
			obj66 += 16;
			obj65--;
			if ((nint)obj65 != 1)
			{
				continue;
			}
			goto IL_0c83;
		}
		object obj67 = obj64 + obj66;
		object obj68 = obj67 + 312;
		goto IL_1859;
		IL_0aa4:
		object obj69 = typeof(System.IOAsyncCallback) + 384;
		object obj70 = "Unsupported map type" + 3984;
		object obj71 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X8_v37+12E]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X8_v37+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b5b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X8_v37+B0]");
		object obj73 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X10_v24-8]");
			if (0 == (nint)obj69)
			{
				break;
			}
			obj73 += 16;
			obj72--;
			if ((nint)obj72 != 1)
			{
				continue;
			}
			goto IL_0b5b;
		}
		object obj74 = obj71 + obj73;
		object obj75 = obj74 + 312;
		goto IL_17e0;
		IL_1685:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v124+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v433 @ X8_v124] (should have been resolved before IL gen)");
		GameObject gameObject2 = ((<>c__DisplayClass26_0)obj2).<PlayerSelected>g__CreateAvatar|0();
		object obj76 = default(object);
		bool flag24 = obj76 == null;
		obj11 = 0;
		queuePlayer = (QueuePlayer)obj14;
		object obj77;
		if (!flag24)
		{
			obj77 = typeof(System.IOAsyncCallback) + 368;
			object obj78 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X8_v125+12E]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X8_v125+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0d62;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X8_v125+B0]");
			object obj80 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v74-8]");
				if (0 == (nint)obj77)
				{
					break;
				}
				obj80 += 16;
				obj79--;
				if ((nint)obj79 != 1)
				{
					continue;
				}
				goto IL_0d62;
			}
			object obj81 = obj80 + 1;
			object obj82 = obj78 + obj81;
			object obj83 = obj82 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v146+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1279 @ X0_v146] (should have been resolved before IL gen)");
			bool flag25 = obj34 == null;
			obj11 = 0;
			queuePlayer = (QueuePlayer)(object)gameObject2;
			if (!flag25)
			{
				goto IL_1046;
			}
		}
		goto IL_15fa;
		IL_117a:
		object obj84 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1619 @ X8_v41+12E]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1619 @ X8_v41+12E]");
		if ((nint)0 == 0)
		{
			goto IL_120e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1619 @ X8_v41+B0]");
		object obj86 = (nint)0 + (nint)8;
		object obj87;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1658 @ X10_v14-8]");
			if (0 == (nint)obj87)
			{
				break;
			}
			obj86 += 16;
			obj85--;
			if ((nint)obj85 != 1)
			{
				continue;
			}
			goto IL_120e;
		}
		object obj88 = obj86 + 9;
		object obj89 = obj84 + obj88;
		object obj90 = obj89 + 312;
		goto IL_19d1;
		IL_155e:
		object obj91 = obj42 + 9;
		object obj92 = obj39 + obj91;
		obj58 = obj92 + 312;
		goto IL_1aac;
		IL_0c83:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj93 = default(object);
		obj68 = obj93;
		goto IL_1859;
		IL_1859:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v80+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v437 @ X8_v80] (should have been resolved before IL gen)");
		GameObject gameObject3 = ((<>c__DisplayClass26_0)obj2).<PlayerSelected>g__CreateAvatar|0();
		object obj94 = default(object);
		bool flag26 = obj94 == null;
		queuePlayer = (QueuePlayer)obj63;
		if (flag26)
		{
			goto IL_15fa;
		}
		obj31 = typeof(System.IOAsyncCallback) + 368;
		object obj95 = obj94;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v81+12E]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v81+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0fc6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v81+B0]");
		object obj97 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X10_v53-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj97 += 16;
			obj96--;
			if ((nint)obj96 != 1)
			{
				continue;
			}
			goto IL_0fc6;
		}
		object obj98 = obj97 + 1;
		object obj99 = obj95 + obj98;
		object obj100 = obj99 + 312;
		goto IL_1911;
		IL_19d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v658 @ X8_v42] (should have been resolved before IL gen)");
		return;
		IL_15fa:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1608;
		IL_0b5b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj101 = default(object);
		obj75 = obj101;
		goto IL_17e0;
		IL_17e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v38+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v435 @ X8_v38] (should have been resolved before IL gen)");
		gameObject = ((<>c__DisplayClass26_0)obj2).<PlayerSelected>g__CreateAvatar|0();
		object obj102 = default(object);
		bool flag27 = obj102 == null;
		obj11 = 0;
		queuePlayer = (QueuePlayer)obj70;
		if (!flag27)
		{
			obj87 = typeof(System.IOAsyncCallback) + 368;
			object obj103 = obj102;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v39+12E]");
			object obj104 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v39+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0e8c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v39+B0]");
			object obj105 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v19-8]");
				if (0 == (nint)obj87)
				{
					break;
				}
				obj105 += 16;
				obj104--;
				if ((nint)obj104 != 1)
				{
					continue;
				}
				goto IL_0e8c;
			}
			object obj106 = obj105 + 1;
			object obj107 = obj103 + obj106;
			object obj108 = obj107 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1599 @ X0_v49+8]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1599 @ X0_v49] (should have been resolved before IL gen)");
			bool flag28 = obj36 == null;
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1599 @ X0_v49+8]");
			num = 0;
			queuePlayer = (QueuePlayer)(object)gameObject;
			if (!flag28)
			{
				goto IL_117a;
			}
		}
		goto IL_15fa;
		IL_0d62:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ X0_v143+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1179 @ X0_v143] (should have been resolved before IL gen)");
		bool flag29 = obj34 == null;
		object obj109 = !flag29;
		if (obj109 != null)
		{
			goto IL_1046;
		}
		obj11 = 0;
		queuePlayer = (QueuePlayer)(object)gameObject2;
		goto IL_15fa;
		IL_0fc6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1911;
		IL_1911:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1216 @ X0_v98] (should have been resolved before IL gen)");
		object obj110 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj111 = (nint)0 + (nint)3960;
		Action action3 = default(Action);
		action3..ctor(obj2, (IntPtr)obj111);
		object label2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3048;
		PopupButton popupButton2 = PopupButton.Positive((string)label2, action3);
		object obj112 = default(object);
		bool flag30 = obj112 == null;
		obj11 = 0;
		num = unchecked((nint)null);
		queuePlayer = (QueuePlayer)(object)action3;
		if (flag30)
		{
			goto IL_15fa;
		}
		object obj113 = obj112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1442 @ X8_v88+12E]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1442 @ X8_v88+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1323;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1442 @ X8_v88+B0]");
		object obj115 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1549 @ X10_v48-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj115 += 16;
			obj114--;
			if ((nint)obj114 != 1)
			{
				continue;
			}
			goto IL_1323;
		}
		object obj116 = obj113 + obj115;
		object obj117 = obj116 + 312;
		goto IL_1a00;
		IL_033c:
		obj44 = typeof(DataRelation) + 712;
		object obj118 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v24+E4]");
		bool flag31 = (nint)0 == 0;
		object obj119 = !flag31;
		if (obj119 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		dateTime2 = (DateTime)(this + 80);
		TimeSpan timeSpan2 = now2 - (DateTime)dateTime2._dateData;
		object obj120 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj121 = obj120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X0_v29+E4]");
		TimeSpan timeSpan3 = default(TimeSpan);
		if ((nint)0 != 0)
		{
			double totalSeconds = timeSpan3.TotalSeconds;
			bool flag32 = !(totalSeconds < 8.000000000465661);
			num6 = 8.000000000465661;
			object obj122 = 0;
			num5 = 8.000000000465661;
			num7 = totalSeconds;
			object obj123 = 0;
			if (!flag32)
			{
				goto IL_046c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			double totalSeconds = timeSpan3.TotalSeconds;
			bool flag33 = totalSeconds < 8.000000000465661;
			num6 = 8.000000000465661;
			object obj122 = 0;
			num5 = 8.000000000465661;
			num7 = totalSeconds;
			object obj123 = 0;
			if (flag33)
			{
				goto IL_046c;
			}
		}
		object obj124 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj125 = (nint)0 + (nint)3944;
		Action action4 = default(Action);
		action4..ctor(obj2, (IntPtr)obj125);
		object obj126 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 728;
		object obj127 = "AvailableVoices" + 768;
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle2 = PopupWindowBuilder.CreateConfirm(action4, (string)obj126, (string)obj127);
		bool flag34 = popupWindowBuilderNeedsTitle2 == null;
		obj11 = 0;
		num = (nint)obj127;
		queuePlayer = (QueuePlayer)obj126;
		if (!flag34)
		{
			object obj128 = typeof(System.IOAsyncCallback) + 392;
			obj56 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 736;
			nint num9 = (nint)popupWindowBuilderNeedsTitle2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X8_v31 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			object obj129 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X8_v31 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_09df;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X8_v31 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
			object obj130 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v29-8]");
				if (0 == (nint)obj128)
				{
					break;
				}
				obj130 += 16;
				obj129--;
				if ((nint)obj129 != 1)
				{
					continue;
				}
				goto IL_09df;
			}
			object obj131 = num9 + obj130;
			object obj132 = obj131 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v54+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v431 @ X8_v54] (should have been resolved before IL gen)");
			bool flag35 = obj54 == null;
			obj11 = 0;
			queuePlayer = (QueuePlayer)obj56;
			if (!flag35)
			{
				goto IL_0aa4;
			}
		}
		goto IL_15fa;
		IL_1046:
		obj38 = obj77;
		obj39 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X8_v9+12E]");
		object obj133 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X8_v9+12E]");
		bool flag36 = (nint)0 == 0;
		obj41 = 0;
		if (flag36)
		{
			goto IL_1547;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X8_v9+B0]");
		obj42 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ X10_v5-8]");
			bool flag37 = 0 == (nint)obj38;
			obj41 = 0;
			if (flag37)
			{
				break;
			}
			obj42 += 16;
			obj133--;
			if ((nint)obj133 != 1)
			{
				continue;
			}
			goto IL_10eb;
		}
		goto IL_155e;
		IL_120e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 9;
		object obj134 = default(object);
		obj90 = obj134;
		goto IL_19d1;
		IL_1547:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj135 = default(object);
		obj58 = obj135;
		goto IL_1aac;
		IL_10eb:
		obj41 = 0;
		goto IL_1547;
		IL_1323:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1a00;
	}

	private void SendInvite(QueuePlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_010d: Expected O, but got I
		//IL_012d: Expected I, but got O
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(DataRelation) + 712;
		object command = "rightCtrl" + 584;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)3992;
		object obj6 = obj2 + 16;
		obj6 = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		lastInviteTime = now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
		SendCommandHelper((QueuePlayer)0, (string)command);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj5);
		object obj10 = this + 72;
		obj10 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void SendCancel(QueuePlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00b7: Expected I, but got O
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object command = "clear_mass_tournaments" + 304;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4016;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SendCommandHelper((QueuePlayer)obj6, (string)command);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = this + 72;
		obj7 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SendAccept(QueuePlayer player, Action callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00b7: Expected I, but got O
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object command = "___# Content push apply failed [{0}]: {1}" + 2992;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4024;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SendCommandHelper(player, (string)command);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = this + 72;
		obj7 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SendReject(QueuePlayer player, Action callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00d7: Expected I, but got O
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object command = "rightCtrl" + 192;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4048;
		object obj5 = obj2 + 16;
		obj5 = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SendCommandHelper((QueuePlayer)obj5, (string)command);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = this + 72;
		obj8 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private static void SendCommandHelper(QueuePlayer player, string command)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_009e: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_014c: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, command);
		object obj2 = "rightCtrl" + 584;
		bool flag = command == (string)obj2;
		bool flag2 = !flag;
		object obj3 = !flag2;
		object key2;
		if (obj3 == null)
		{
			object obj4 = "clear_mass_tournaments" + 304;
			if (!(command == (string)obj4))
			{
				key2 = "https://www.kammelna.com/Home/Terms" + 2288;
				goto IL_00c5;
			}
		}
		key2 = "placementId" + 2600;
		bool flag3 = player == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c5;
		IL_00c5:
		PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
		object command2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 816;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		SFSExtensions.Put(sFSObject, (string)key2, <info>k__BackingField.<DBID>k__BackingField);
		SFS.SendRoomExtensionRequest((string)command2, sFSObject);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.SetLoading(loading: true);
	}

	private static string GetUserKey(string command)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		object obj = "rightCtrl" + 584;
		bool flag = command == (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			object obj3 = "clear_mass_tournaments" + 304;
			if (!(command == (string)obj3))
			{
				return "https://www.kammelna.com/Home/Terms" + 2288;
			}
		}
		return "placementId" + 2600;
	}

	private static string GetOtherUserKey(string command)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		object obj = "rightCtrl" + 584;
		bool flag = command == (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			object obj3 = "clear_mass_tournaments" + 304;
			if (!(command == (string)obj3))
			{
				return "placementId" + 2600;
			}
		}
		return "https://www.kammelna.com/Home/Terms" + 2288;
	}

	public void QueueUpdated(List<QueuePlayer> waitingPlayers, List<QueuePlayer> matchupsPlayers)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0c5c: Expected O, but got I
		//IL_0c99: Expected O, but got I4
		//IL_0a9a: Expected O, but got I4
		//IL_0ab0: Expected I, but got O
		//IL_0b83: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_0bd0: Expected O, but got I
		//IL_0c00: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0140: Expected I, but got O
		//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dca: Expected O, but got Unknown
		//IL_0de0: Expected O, but got I
		//IL_0df1: Expected I, but got O
		//IL_0dfd: Expected O, but got I
		//IL_0cd3: Expected O, but got I
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_07a0: Expected O, but got I4
		//IL_072e: Expected O, but got I
		//IL_074b: Expected O, but got I
		//IL_088f: Expected O, but got I
		//IL_08a0: Expected I, but got O
		//IL_07cc: Expected O, but got I
		//IL_07e4: Expected O, but got I4
		//IL_08fe: Expected O, but got I4
		//IL_0810: Expected O, but got I
		//IL_0821: Expected I, but got O
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0859: Expected O, but got I4
		//IL_0862: Expected O, but got I4
		//IL_0932: Expected O, but got I4
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02c1: Expected O, but got I
		//IL_02d2: Expected I, but got O
		//IL_02e3: Expected O, but got I
		//IL_02eb: Expected I, but got O
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0229: Expected O, but got I
		//IL_0231: Expected I, but got O
		//IL_0242: Expected I, but got O
		//IL_098e: Expected I, but got O
		//IL_09a7: Expected O, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0367: Expected O, but got I4
		//IL_0952: Expected I, but got O
		//IL_096b: Expected O, but got I4
		//IL_05df: Expected O, but got I
		//IL_05f0: Expected I, but got O
		//IL_0272: Expected O, but got I
		//IL_027a: Expected I, but got O
		//IL_0292: Expected I, but got O
		//IL_0601: Expected O, but got I
		//IL_0609: Expected I, but got O
		//IL_0385: Expected O, but got I
		//IL_0396: Expected I, but got O
		//IL_0acb: Expected I, but got O
		//IL_0ae4: Expected O, but got I4
		//IL_03a7: Expected O, but got I
		//IL_03af: Expected I, but got O
		//IL_0652: Expected O, but got I4
		//IL_0b07: Expected I, but got O
		//IL_0b20: Expected O, but got I4
		//IL_0a0e: Expected I, but got O
		//IL_0a27: Expected O, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_041e: Expected O, but got I
		//IL_042f: Expected I, but got O
		//IL_0440: Expected O, but got I
		//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Expected O, but got Unknown
		//IL_069c: Expected O, but got I
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d37: Expected O, but got Unknown
		//IL_0d6a: Expected I, but got O
		//IL_09ca: Expected I, but got O
		//IL_09d2: Expected I, but got O
		//IL_09eb: Expected O, but got I4
		//IL_0b43: Expected I, but got O
		//IL_0b5c: Expected O, but got I4
		//IL_0491: Expected O, but got I4
		//IL_04a5: Expected I, but got O
		//IL_04ad: Expected I, but got O
		//IL_04cf: Expected I, but got O
		//IL_04d7: Expected I, but got O
		//IL_04f5: Expected O, but got I
		//IL_0a4a: Expected I, but got O
		//IL_0a52: Expected I, but got O
		//IL_0a6b: Expected O, but got I4
		//IL_053d: Expected I, but got O
		//IL_0545: Expected I, but got O
		//IL_0569: Expected I, but got O
		//IL_0582: Expected O, but got I4
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected O, but got Unknown
		//IL_0d23: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3656;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag2 = (object)sessionModel == null;
		Func<object, bool> func = null;
		object obj8 = default(object);
		nint num;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num2 = default(nint);
		object obj12 = default(object);
		object obj15 = default(object);
		object obj23;
		object obj29;
		object obj24;
		Func<object, bool> func4 = default(Func<object, bool>);
		object obj32;
		List<QueuePlayer> list2;
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag2)
		{
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			bool flag3 = obj4 == null;
			func = null;
			if (!flag3)
			{
				object obj7 = (nint)0 + (nint)2576;
				func = (Func<object, bool>)obj7;
				List<object> list = Enumerable.ToList((IEnumerable<object>)watchedPlayers);
				bool flag4 = list == null;
				obj8 = obj4;
				if (!flag4)
				{
					object obj9 = (nint)0 + (nint)336;
					object obj10 = typeof(SkeletonBinary.SkeletonInput) + 3664;
					object obj11 = typeof(SkeletonBinary.SkeletonInput) + 3672;
					List<object>.Enumerator enumerator = list.GetEnumerator();
					num = (nint)matchupsPlayers;
					object obj14 = default(object);
					Predicate<object> predicate = default(Predicate<object>);
					Func<object, bool> func2 = default(Func<object, bool>);
					Func<object, bool> func3 = default(Func<object, bool>);
					while (true)
					{
						bool flag5 = enumerator2.MoveNext();
						bool flag6 = !flag5;
						bool flag7 = (byte)num2 != 0;
						string text = (string)num;
						if (flag6)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj12..ctor();
						if (obj12 == null)
						{
							goto IL_08dc;
						}
						object obj13 = obj12 + 16;
						obj13 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj15..ctor();
						object obj16 = obj13;
						if (obj13 == null)
						{
							goto IL_0910;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v35+20]");
						if ((nint)0 == 4)
						{
							object obj17 = typeof(List<Tween>) + 3408;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj18 = (nint)0 + (nint)4080;
							num = (nint)obj18;
							predicate..ctor(obj12, (IntPtr)obj18);
							if (watchedPlayers != null)
							{
								object obj19 = (nint)0 + (nint)2960;
								num = (nint)obj19;
								int num3 = ((List<object>)(object)watchedPlayers).RemoveAll(predicate);
								num2 = unchecked((nint)null);
								continue;
							}
							goto IL_0944;
						}
						object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj21 = (nint)0 + (nint)4088;
						func2..ctor(obj12, (IntPtr)obj21);
						object obj22 = (nint)0 + (nint)1120;
						num = (nint)obj22;
						obj23 = Enumerable.FirstOrDefault(matchupsPlayers, func2);
						if (obj15 == null)
						{
							goto IL_0980;
						}
						obj24 = obj15 + 16;
						obj24 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj25 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
						bool flag8 = obj24 == null;
						object obj26 = !flag8;
						if (obj26 != null)
						{
							goto IL_05c9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj27 = 0;
						func3..ctor(obj12, (IntPtr)obj27);
						object obj28 = (nint)0 + (nint)1120;
						num = (nint)obj28;
						obj29 = Enumerable.FirstOrDefault(waitingPlayers, func3);
						obj24 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if (obj24 != null)
						{
							object obj30 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj31 = (nint)0 + (nint)16;
							func4..ctor(obj15, (IntPtr)obj31);
							obj32 = (nint)0 + (nint)1120;
							list2 = (List<QueuePlayer>)obj32;
							object obj33 = Enumerable.FirstOrDefault(waitingPlayers, func4);
							QueuePlayer queuePlayer = (QueuePlayer)obj24;
							if (obj24 == null)
							{
								goto IL_09bc;
							}
							object obj34 = queuePlayer.<team>k__BackingField + 1;
							bool flag9 = obj34 == null;
							num2 = unchecked((nint)null);
							num = (nint)obj32;
							if (flag9)
							{
								continue;
							}
							bool flag10 = obj33 == null;
							num2 = unchecked((nint)null);
							num = (nint)obj32;
							if (flag10)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v96 (System.Object)+10]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v96 (System.Object)+10]");
							if ((nint)0 == 0)
							{
								goto IL_0a3c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v76+10]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3 (System.Object)+10]");
							bool flag11 = num4 == 0;
							num2 = unchecked((nint)null);
							num = (nint)obj32;
							if (flag11)
							{
								continue;
							}
							bool flag12 = (object)invitesPanel == null;
							num2 = unchecked((nint)null);
							enumerator2 = enumerator3;
							enumerator4 = enumerator3;
							enumerator3 = (List<object>.Enumerator)0;
							obj8 = obj4;
							func = func4;
							if (!flag12)
							{
								object obj36 = "startPosition" + 4016;
								invitesPanel.ShowNotification((QueuePlayer)obj24, (string)obj36, overrideExisting: true);
								MarkRejected((QueuePlayer)obj24);
								num2 = 1;
								num = (nint)obj36;
								continue;
							}
							goto IL_0a9f;
						}
						if ((object)invitesPanel != null)
						{
							object obj37 = "startPosition" + 4024;
							invitesPanel.ShowNotification((QueuePlayer)obj13, (string)obj37, overrideExisting: true);
							MarkRejected((QueuePlayer)obj13);
							num2 = 1;
							num = (nint)obj37;
							continue;
						}
						goto IL_0a00;
					}
					goto IL_0722;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		list2 = matchupsPlayers;
		enumerator2 = (List<object>.Enumerator)0;
		goto IL_0a9f;
		IL_0944:
		NullReferenceException ex2 = new NullReferenceException();
		num2 = unchecked((nint)null);
		List<object>.Enumerator enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj8 = obj4;
		func = (Func<object, bool>)obj12;
		goto IL_0b77;
		IL_0980:
		ex2 = new NullReferenceException();
		num2 = unchecked((nint)null);
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj8 = obj4;
		func = (Func<object, bool>)obj23;
		goto IL_0b77;
		IL_0722:
		object obj38 = (nint)0 + (nint)328;
		func = (Func<object, bool>)obj38;
		enumerator2.Dispose();
		object obj39 = (nint)0 + (nint)2760;
		enumerator4 = enumerator3;
		object obj40 = obj4;
		goto IL_0db6;
		IL_0db6:
		object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)4056;
		Func<object, bool> func5 = default(Func<object, bool>);
		func5..ctor(obj40, (IntPtr)obj42);
		object obj43 = (nint)0 + (nint)1120;
		object obj44 = obj43;
		object obj45 = Enumerable.FirstOrDefault(waitingPlayers, func5);
		object obj46 = obj40 + 24;
		obj46 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj47 = obj46;
		bool flag13 = obj46 == null;
		object obj48 = 0;
		Func<object, bool> func6 = (Func<object, bool>)obj45;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v9+1C]");
			object obj49 = (nint)0 + (nint)1;
			bool flag14 = obj49 == null;
			obj48 = 0;
			func6 = (Func<object, bool>)obj45;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj50 = (nint)0 + (nint)4064;
				Func<object, bool> func7 = default(Func<object, bool>);
				func7..ctor(obj40, (IntPtr)obj50);
				obj44 = obj39;
				bool flag15 = Enumerable.Any(waitingPlayers, func7);
				bool flag16 = !flag15;
				object obj51 = !flag16;
				obj48 = 0;
				func6 = func7;
				if (obj51 != null)
				{
					goto IL_08d0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj52 = (nint)0 + (nint)4072;
		Func<object, bool> func8 = default(Func<object, bool>);
		func8..ctor(obj40, (IntPtr)obj52);
		if (Enumerable.Any(matchupsPlayers, func8))
		{
			goto IL_08d0;
		}
		return;
		IL_05c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj53 = (nint)0 + (nint)8;
		Func<object, bool> func9 = default(Func<object, bool>);
		func9..ctor(obj15, (IntPtr)obj53);
		object obj54 = (nint)0 + (nint)1120;
		num = (nint)obj54;
		object obj55 = Enumerable.FirstOrDefault(waitingPlayers, func9);
		QueuePlayer queuePlayer2 = (QueuePlayer)obj24;
		if (obj24 != null)
		{
			object obj56 = queuePlayer2.<team>k__BackingField + 1;
			if (obj56 != null && obj55 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v71 (System.Object)+10]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v71 (System.Object)+10]");
				if ((nint)0 == 0)
				{
					ex2 = new NullReferenceException();
					num2 = unchecked((nint)null);
					enumerator5 = enumerator3;
					enumerator4 = enumerator3;
					enumerator3 = (List<object>.Enumerator)0;
					obj8 = obj4;
					func = func9;
					goto IL_0b77;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v56+10]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3 (System.Object)+10]");
				bool flag17 = num5 == 0;
				bool flag7 = false;
				string text = (string)obj54;
				if (flag17)
				{
					goto IL_0722;
				}
			}
			if ((object)invitesPanel != null)
			{
				object obj58 = "startPosition" + 4016;
				string text = (string)obj58;
				invitesPanel.ShowNotification((QueuePlayer)obj24, (string)obj58, overrideExisting: true);
				MarkRejected((QueuePlayer)obj24);
				bool flag7 = true;
				goto IL_0722;
			}
			ex2 = new NullReferenceException();
			num2 = unchecked((nint)null);
			enumerator5 = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			obj8 = obj4;
			func = func9;
		}
		else
		{
			ex2 = new NullReferenceException();
			num2 = unchecked((nint)null);
			enumerator5 = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			obj8 = obj4;
			func = func9;
		}
		goto IL_0b77;
		IL_0a00:
		ex2 = new NullReferenceException();
		num2 = unchecked((nint)null);
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj8 = obj4;
		func = (Func<object, bool>)obj29;
		goto IL_0b77;
		IL_0a9f:
		ex2 = new NullReferenceException();
		num = (nint)list2;
		enumerator5 = enumerator2;
		goto IL_0b77;
		IL_0b77:
		obj39 = (nint)0 + (nint)2760;
		bool flag18 = (nint)func != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj59 = (nint)0 + (nint)328;
			func = (Func<object, bool>)obj59;
			enumerator5.Dispose();
			object obj60 = default(object);
			bool flag19 = obj60 == null;
			bool flag7 = (byte)num2 != 0;
			string text = (string)num;
			obj40 = obj8;
			if (flag19)
			{
				goto IL_0db6;
			}
			ex3 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj60;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2239364");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_08dc:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj8 = obj4;
		func = null;
		goto IL_0b77;
		IL_0a3c:
		ex2 = new NullReferenceException();
		num2 = unchecked((nint)null);
		num = (nint)obj32;
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj8 = obj4;
		func = func4;
		goto IL_0b77;
		IL_0910:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj8 = obj4;
		func = null;
		goto IL_0b77;
		IL_09bc:
		ex2 = new NullReferenceException();
		num2 = unchecked((nint)null);
		num = (nint)obj32;
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj8 = obj4;
		func = func4;
		goto IL_0b77;
		IL_08d0:
		ClearInvites();
	}

	private void MarkRejected(QueuePlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		//IL_008a: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I
		//IL_00de: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(List<Tween>) + 3408;
		object obj4 = (nint)0 + (nint)24;
		object obj5 = obj2 + 16;
		obj5 = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj4);
		object obj6 = (nint)0 + (nint)2960;
		object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
		object obj8 = (nint)0 + (nint)32;
		int num = ((List<object>)(object)watchedPlayers).RemoveAll(predicate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj8);
		object obj9 = Enumerable.FirstOrDefault(invites, func);
		if (obj9 != null)
		{
			_ = 5;
		}
	}

	private void ClearInvites()
	{
		List<QueuePlayer> list = invites;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
		List<QueuePlayer> list2 = watchedPlayers;
		int version2 = list2._version + 1;
		list2._size = 0;
		list2._version = version2;
		if (list2._size >= 1)
		{
			Array.Clear(list2._items, 0, list2._size);
		}
		tournamentEventsChannel.TriggerDismissAllInvites();
	}

	public TournamentInviteManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 56;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj3 = this + 64;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
