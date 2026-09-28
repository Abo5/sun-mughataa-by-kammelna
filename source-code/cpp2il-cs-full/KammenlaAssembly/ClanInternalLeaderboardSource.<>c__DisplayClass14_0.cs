using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public abstract class ClanInternalLeaderboardSource : BaseLeaderboardSource
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<InternalLeaderboardEntryModel, LeaderBoardPlayer> <>9__16_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal LeaderBoardPlayer <MapRows>b__16_0(InternalLeaderboardEntryModel row)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (row != null && obj2 != null)
			{
				_ = row.UserId;
				object obj3 = obj2 + 48;
				obj3 = row.UserName;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = row.AvatarDate;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [row @ X1 (Kammelna.Server.Models.Clans.InternalLeaderboardEntryModel)+40]");
				_ = 0;
				_ = row.Score;
				_ = row.Rank;
				object obj4 = obj2 + 96;
				obj4 = row.RoleTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = row.IsOwner;
				_ = 0;
				return (LeaderBoardPlayer)obj2;
			}
			return (LeaderBoardPlayer)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public Action<LeaderboardModel> successCallback;

		public Action<string> onError;

		internal void <Load>b__0(KammelnaResponseModel<List<InternalLeaderboardEntryModel>> response)
		{
			//IL_004a: Expected O, but got I
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				List<LeaderBoardPlayer> list = MapRows(response.<Model>k__BackingField);
				object etag = (nint)0 + (nint)2000;
				LeaderboardModel arg = LeaderboardModel.FromList(list, (string)etag);
				Actions.SafeInvoke((Action<object>)successCallback, arg);
			}
			else
			{
				string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
				Actions.SafeInvoke((Action<object>)onError, errorMessage);
			}
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public long myId;

		public LeaderBoardPlayer me;

		public Action<LeaderBoardPlayer> callback;

		public Func<InternalLeaderboardEntryModel, bool> <>9__1;

		internal void <GetMyRanking>b__0(KammelnaResponseModel<List<InternalLeaderboardEntryModel>> response)
		{
			//IL_0011: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0086: Expected O, but got I4
			//IL_00fe: Expected O, but got I
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00be: Expected O, but got I
			//IL_00cc: Expected I, but got O
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_0151: Expected O, but got I
			object obj = (nint)0 + (nint)760;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded && response.<Model>k__BackingField != null)
			{
				object obj2 = this + 40;
				Func<object, bool> predicate = (Func<object, bool>)obj2;
				bool flag = obj2 == null;
				object obj3 = !flag;
				if (obj3 == null)
				{
					object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1984;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj5 = (nint)0 + (nint)3800;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor((object)this, (IntPtr)obj5);
					<>9__1 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				object obj6 = (nint)0 + (nint)944;
				object obj7 = Enumerable.FirstOrDefault(response.<Model>k__BackingField, predicate);
				if (obj7 != null)
				{
					object obj8 = me + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v10 (System.Object)+50]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v10 (System.Object)+48]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v10 (System.Object)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					LeaderBoardPlayer leaderBoardPlayer = me;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v10 (System.Object)+58]");
					leaderBoardPlayer.IsClanOwner = false;
				}
			}
			Actions.SafeInvoke((Action<object>)callback, me);
		}

		internal bool <GetMyRanking>b__1(InternalLeaderboardEntryModel row)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (row != null)
			{
				object obj = row.UserId - myId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private int <ClanId>k__BackingField;

	private OneShotEvent<KammelnaResponseModel<List<InternalLeaderboardEntryModel>>> _fetch;

	protected abstract InternalLeaderboardKind Kind { get; }

	public int ClanId
	{
		get
		{
			return <ClanId>k__BackingField;
		}
		set
		{
			<ClanId>k__BackingField = value;
		}
	}

	public override bool IsLive => true;

	public override bool IsGameDependent => true;

	protected ClanInternalLeaderboardSource(int clanId)
	{
		<ClanId>k__BackingField = clanId;
	}

	public override string GetCacheFilePath()
	{
		return null;
	}

	public override void Load(GameObject lifecycle, Action<LeaderboardModel> successCallback, Action useCacheCallback, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a8: Expected I, but got O
		//IL_00b9: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 384;
		object obj4 = (nint)0 + (nint)3784;
		object obj5 = obj2 + 16;
		obj5 = successCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		OneShotEvent<KammelnaResponseModel<List<InternalLeaderboardEntryModel>>> oneShotEvent = StartFetch();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	public override void GetMyRanking(Action<LeaderBoardPlayer> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0119: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I
		//IL_01b7: Expected I, but got O
		//IL_014a: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
		object obj4 = obj2 + 32;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		User mySelf = SFS.MySelf;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LeaderBoardPlayer leaderBoardPlayer = default(LeaderBoardPlayer);
		leaderBoardPlayer..ctor(mySelf);
		object obj5 = obj2 + 24;
		obj5 = leaderBoardPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		User mySelf2 = SFS.MySelf;
		int clanId = SFSKammelnaUserExtensions.GetClanId(mySelf2);
		if (<ClanId>k__BackingField == clanId)
		{
			User mySelf3 = SFS.MySelf;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(mySelf3);
			OneShotEvent<KammelnaResponseModel<List<InternalLeaderboardEntryModel>>> fetch = _fetch;
			bool flag = _fetch == null;
			object obj6 = !flag;
			if (obj6 == null)
			{
				OneShotEvent<KammelnaResponseModel<List<InternalLeaderboardEntryModel>>> oneShotEvent = StartFetch();
				fetch = oneShotEvent;
			}
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)3792;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj8);
			object obj9 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
		}
		else
		{
			Actions.SafeInvoke((Action<object>)obj4, obj5);
		}
	}

	private OneShotEvent<KammelnaResponseModel<List<InternalLeaderboardEntryModel>>> StartFetch()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_003e: Expected I, but got O
		//IL_0072: Expected O, but got I4
		//IL_00b8: Expected I, but got O
		object obj = typeof(List<Tween>) + 2896;
		object obj2 = (nint)0 + (nint)2240;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 384;
		object obj5 = (nint)0 + (nint)2256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997628");
		object obj6 = this + 24;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		InternalLeaderboardKind kind = Kind;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj7, (IntPtr)obj5);
		KammelnaRequests.GetClanInternalLeaderboard(kind, currentGame, <ClanId>k__BackingField, action);
		return (OneShotEvent<KammelnaResponseModel<List<InternalLeaderboardEntryModel>>>)obj7;
	}

	private static List<LeaderBoardPlayer> MapRows(List<InternalLeaderboardEntryModel> rows)
	{
		//IL_000c: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_015d: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01c7: Expected O, but got I
		//IL_01d8: Expected I, but got O
		//IL_01f6: Expected O, but got I
		//IL_00f8: Expected O, but got I
		object obj = (nint)0 + (nint)2648;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)rows))
		{
			object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			return (List<LeaderBoardPlayer>)(object)list;
		}
		object obj3 = typeof(CardUtils.<>c) + 776;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v6+8]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v6+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3776;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v11+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(rows, selector);
		return (List<LeaderBoardPlayer>)(object)Enumerable.ToList(source);
	}
}
