using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class LeaderboardFriendListItem : ListViewItem<IListViewItemData<int>, int>
{
	private AvatarInitializer profileInitializer;

	private TextMeshProUGUI placeText;

	private TextMeshProUGUI points;

	private GameObject tournamentPointsIcon;

	private GameObject mySelfModifier;

	private LeaderboardFriendHolder dataHolder;

	public override void Setup(IListViewItemData<int> datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1472;
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		if (datum != null)
		{
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1728;
			object obj3 = obj2;
			nint num = (nint)datum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6 (Il2CppClass<ListView.IListViewItemData`1<System.Int32>>)+40]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X1_v3+40]");
			if (num2 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj4 = default(object);
				dataHolder = (LeaderboardFriendHolder)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v7+10]");
				_ = 0;
				object obj5 = this + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Initialize();
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new InvalidCastException();
	}

	public void Initialize()
	{
		//IL_01c1: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_006e: Expected I4, but got I8
		//IL_00c8: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardFriendListItem)+B8]");
		FriendLeaderboardModel friendLeaderboardModel = (FriendLeaderboardModel)0;
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendProfile profile = FriendsManager.GetProfile((int)friendLeaderboardModel.<userDbId>k__BackingField);
		profileInitializer.Clear();
		AvatarData avatarData;
		if (profile != null)
		{
			avatarData = profile;
			bool flag2 = (object)profileInitializer == null;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			avatarData = friendLeaderboardModel;
		}
		profileInitializer.Initialize(avatarData);
		int num = default(int);
		string text = num.ToString();
		placeText.text = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardFriendListItem)+C0]");
		long num2 = default(long);
		int num3 = default(int);
		string text2 = (((nint)0 != 1) ? num2.ToString() : num3.ToString());
		points.text = text2;
		GameObject obj5 = tournamentPointsIcon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardFriendListItem)+C0]");
		obj5.SetActive(value: false);
		CheckForSelf();
	}

	private unsafe string GetNeededPoints()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardFriendListItem)+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardFriendListItem)+C0]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardFriendListItem)+B8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v1+48]");
				_ = 0;
				int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4));
				return ((int*)num)->ToString();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardFriendListItem)+B8]");
			long num2 = default(long);
			if ((nint)0 != 0)
			{
				return num2.ToString();
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private void ShowIcon()
	{
		GameObject obj = tournamentPointsIcon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardFriendListItem)+C0]");
		obj.SetActive(value: false);
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 128;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void OpenProfile()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 840;
		long num = default(long);
		string dbId = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MiniProfilePopup.Show(dbId, TrackingPlacement.FriendsLeaderboard);
	}

	private void CheckForSelf()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_005d: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		long num = default(long);
		string text = num.ToString();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		bool active = text == dbId;
		mySelfModifier.SetActive(active);
	}

	private void ChangeFormToMine(bool isMine)
	{
		mySelfModifier.SetActive(isMine);
	}

	public LeaderboardFriendListItem()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
