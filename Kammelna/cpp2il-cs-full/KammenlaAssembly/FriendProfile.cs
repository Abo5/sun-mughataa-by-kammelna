using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;

[Serializable]
public class FriendProfile
{
	private sealed class <>c__DisplayClass27_0
	{
		public Games? currentGame;

		internal unsafe bool <GetGameData>b__0(FriendGameData data)
		{
			//IL_0052: Expected I4, but got O
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0030: Expected O, but got I4
			if (data != null)
			{
				System.Int32Enum? int32Enum = (System.Int32Enum?)(object)(this + 16);
				System.Int32Enum value = ((System.Int32Enum?*)int32Enum)->Value;
				object obj = (int)data.Game - (int)value;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int UserID;

	public string UserName;

	public Friend.Status Status;

	public bool RequestSeen;

	public int Cardback;

	public int Pattern;

	public string Title;

	public string Notes;

	public bool IsSubscribed;

	public bool IsVerified;

	[NonSerialized]
	public bool IsOnline;

	[NonSerialized]
	public ClanBadgeModel ActiveClan;

	private long avatarDate;

	public List<PrivateMessageModel> Messages;

	public int UnreadMessages;

	public List<FriendGameData> GamesList;

	private bool <IsDirty>k__BackingField;

	public DateTime? AvatarDate
	{
		get
		{
			//IL_0032: Expected O, but got I4
			if (avatarDate != 0)
			{
				return new DateTime(avatarDate);
			}
			return (DateTime?)(object)0;
		}
		set
		{
			//IL_0009: Expected O, but got I4
			//IL_0020: Expected O, but got I
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00d6: Expected O, but got I4
			//IL_00df: Expected I8, but got I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_0077: Expected I8, but got I4
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_0129: Expected O, but got I
			//IL_01bb: Expected O, but got I4
			//IL_015b: Expected O, but got I4
			//IL_0164: Expected O, but got I4
			//IL_016c: Expected O, but got I
			//IL_01d2: Expected O, but got I4
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6272]");
			object obj2 = (nint)0 & (nint)1;
			DateTime dateTime2;
			long num;
			DateTime? dateTime = default(DateTime?);
			if (obj2 != null)
			{
				object obj3 = (??)dateTime & 1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				dateTime2 = (DateTime)0;
				num = 0L;
				if (obj4 == null)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj5 = (??)dateTime & 1;
				bool flag2 = obj5 == null;
				dateTime2 = (DateTime)0;
				num = 0L;
				if (flag2)
				{
					goto IL_0085;
				}
			}
			object obj6 = typeof(DataRelation) + 712;
			NullReferenceException ex = (NullReferenceException)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v1 (System.NullReferenceException)+E4]");
			bool flag3 = (nint)0 == 0;
			IntPtr intPtr = default(IntPtr);
			dateTime2 = (DateTime)(nint)intPtr;
			if (!flag3)
			{
				num = dateTime2.Ticks;
				bool flag4 = this == null;
				object obj7 = !flag4;
				dateTime = (DateTime?)(object)0;
				dateTime2 = (DateTime)(nint)intPtr;
				if (obj7 != null)
				{
					goto IL_009f;
				}
				goto IL_017a;
			}
			goto IL_0188;
			IL_0188:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num = dateTime2.Ticks;
			bool flag5 = this == null;
			object obj8 = !flag5;
			if (obj8 != null)
			{
				goto IL_009f;
			}
			dateTime = (DateTime?)(object)0;
			goto IL_017a;
			IL_017a:
			ex = new NullReferenceException();
			goto IL_0188;
			IL_0085:
			if (this != null)
			{
				goto IL_009f;
			}
			goto IL_017a;
			IL_009f:
			avatarDate = num;
		}
	}

	public bool IsDirty
	{
		get
		{
			return <IsDirty>k__BackingField;
		}
		set
		{
			<IsDirty>k__BackingField = value;
		}
	}

	public FriendProfile()
	{
	}

	public FriendProfile(Friend friend)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_00b7: Expected I8, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		object obj = this + 24;
		obj = friend.name;
		_ = friend.id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = friend.status;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2728;
		object obj3 = (??)friend.avatarDate & 1;
		long num;
		if (obj3 != null)
		{
			object obj4 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v16+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = default(DateTime);
			num = dateTime.Ticks;
		}
		else
		{
			num = 0L;
		}
		avatarDate = num;
		IsSubscribed = friend.isSubscribed;
		object obj5 = this + 72;
		obj5 = friend.ActiveClan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj6 = this + 88;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
	}

	public void UpdateInfo(Friend friend)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_00e9: Expected I8, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I4
		if (CheckDirty(friend))
		{
			<IsDirty>k__BackingField = true;
		}
		object obj = this + 24;
		obj = friend.name;
		_ = friend.id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = friend.status;
		object obj2 = (??)friend.avatarDate & 1;
		long num;
		if (obj2 != null)
		{
			object obj3 = typeof(DataRelation) + 712;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = default(DateTime);
			num = dateTime.Ticks;
		}
		else
		{
			num = 0L;
		}
		avatarDate = num;
		object obj6 = this + 72;
		obj6 = friend.ActiveClan;
		_ = friend.isSubscribed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void UpdateInfo(PlayerProfileModel profile, Games? currentGame = null)
	{
		//IL_004a: Expected I4, but got I8
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_0123: Expected I8, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_017a: Expected I4, but got O
		if (CheckDirty(profile, currentGame))
		{
			<IsDirty>k__BackingField = true;
		}
		UserID = (int)profile.<userDbId>k__BackingField;
		object obj = this + 24;
		obj = profile.<userName>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 48;
		obj2 = profile.<activeTitle>k__BackingField;
		_ = profile.<activeCardback>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = profile.<isSubscribed>k__BackingField;
		object obj3 = (??)profile.<avatarDate>k__BackingField & 1;
		long num;
		if (obj3 != null)
		{
			object obj4 = typeof(DataRelation) + 712;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = default(DateTime);
			num = dateTime.Ticks;
		}
		else
		{
			num = 0L;
		}
		avatarDate = num;
		FriendGameData gameData = GetGameData(currentGame);
		gameData.IsNew = profile.<isNew>k__BackingField;
		gameData.Points = profile.<points>k__BackingField;
		TournamentRankingModel <tournamentRanking>k__BackingField = profile.<tournamentRanking>k__BackingField;
		bool flag2 = profile.<tournamentRanking>k__BackingField == null;
		int tournamentPoints = (int)profile.<tournamentRanking>k__BackingField;
		if (!flag2)
		{
			tournamentPoints = <tournamentRanking>k__BackingField.<currentMonthPoints>k__BackingField;
		}
		gameData.TournamentPoints = tournamentPoints;
	}

	public unsafe FriendGameData GetGameData(Games? currentGame = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I
		//IL_02e1: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00af: Expected O, but got I4
		//IL_02f2: Expected O, but got I
		//IL_02fa: Expected I, but got O
		//IL_0325: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I
		//IL_00e9: Expected I, but got O
		//IL_0140: Expected O, but got I
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_023c: Expected O, but got I4
		//IL_042d: Expected O, but got I4
		//IL_04ad: Expected O, but got I
		//IL_04bd: Expected O, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 3144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object result;
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)2552;
			System.Int32Enum? int32Enum = (System.Int32Enum?)(object)(obj2 + 16);
			int32Enum = (System.Int32Enum?)currentGame;
			object obj4 = (??)currentGame & 1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame2 = Preferences.CurrentGame;
				object obj9 = (nint)0 + (nint)2744;
				nint num = (nint)obj9;
				System.Int32Enum? int32Enum2 = (System.Int32Enum)currentGame2;
				int32Enum = int32Enum2;
			}
			object obj10 = this + 104;
			if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)obj10))
			{
				object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1368;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj12 = default(object);
				obj12..ctor();
				object obj13 = (nint)0 + (nint)2768;
				System.Int32Enum value = ((System.Int32Enum?*)int32Enum)->Value;
				if (obj12 != null)
				{
					object obj14 = typeof(List<AdaptivePerformanceScaler>) + 1096;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					List<object> list = default(List<object>);
					list..ctor();
					if (list != null)
					{
						object obj15 = (nint)0 + (nint)2208;
						object obj16 = obj15;
						int version = list._version + 1;
						list._version = version;
						object[] items = list._items;
						if (list._items != null)
						{
							bool flag3 = list._size < items.Length;
							object obj17 = !flag3;
							if (obj17 == null)
							{
								int size = list._size + 1;
								list._size = size;
								object obj18 = list._items + list._size;
								object obj19 = obj18 + 32;
								obj19 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v33+20]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v35+C0]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v36+70]");
								nint num = 0;
								list.AddWithResize(obj12);
							}
							obj10 = list;
							List<object> list2 = list;
							object obj22 = obj10;
							result = obj12;
							goto IL_0594;
						}
					}
				}
			}
			else
			{
				object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1136;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj24 = (nint)0 + (nint)704;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj24);
				object obj25 = (nint)0 + (nint)792;
				nint num = (nint)obj25;
				object obj26 = Enumerable.FirstOrDefault((IEnumerable<object>)obj10, func);
				bool flag4 = obj26 == null;
				object obj27 = !flag4;
				result = obj26;
				if (obj27 != null)
				{
					goto IL_0504;
				}
				object obj28 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1368;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj29 = default(object);
				obj29..ctor();
				System.Int32Enum value2 = ((System.Int32Enum?*)int32Enum)->Value;
				if (obj29 != null)
				{
					List<object> list3 = (List<object>)obj10;
					if (obj10 != null)
					{
						int version2 = list3._version + 1;
						list3._version = version2;
						object[] items2 = list3._items;
						if (list3._items != null)
						{
							bool flag5 = list3._size < items2.Length;
							object obj30 = !flag5;
							if (obj30 == null)
							{
								int size2 = list3._size + 1;
								list3._size = size2;
								object obj31 = list3._items + list3._size;
								object obj22 = obj31 + 32;
								obj22 = obj29;
								List<object> list2 = (List<object>)obj29;
								result = obj29;
								goto IL_0594;
							}
							((List<object>)obj10).AddWithResize(obj29);
							result = obj29;
							goto IL_0504;
						}
					}
				}
			}
		}
		return (FriendGameData)(object)new NullReferenceException();
		IL_0594:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0504;
		IL_0504:
		return (FriendGameData)result;
	}

	private bool CheckDirty(Friend friend)
	{
		//IL_026d: Expected I4, but got O
		//IL_005d: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_023a: Expected O, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_019f: Expected O, but got I
		//IL_019f: Expected O, but got I4
		if (friend != null)
		{
			if (UserID == friend.id)
			{
				bool flag = UserName != friend.name;
				bool flag2 = !flag;
				object obj = !flag2;
				if (obj == null && Status == friend.status)
				{
					if (avatarDate != 0)
					{
						object obj2 = (nint)0 + (nint)2264;
						DateTime value = new DateTime(avatarDate);
						DateTime? dateTime = value;
						object obj3 = (??)dateTime & 1;
						object obj4 = (??)friend.avatarDate & 1;
						if (obj3 == obj4)
						{
							object obj5 = (??)dateTime & 1;
							if (obj5 != null)
							{
								object obj6 = typeof(DataRelation) + 712;
								object obj7 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v12+E4]");
								bool flag3 = (nint)0 == 0;
								object obj8 = !flag3;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [friend @ X1 (Friend)+30]");
								if ((DateTime)0 != (DateTime)0)
								{
									goto IL_0259;
								}
							}
							goto IL_0200;
						}
					}
					else
					{
						object obj9 = (??)friend.avatarDate & 1;
						bool flag4 = obj9 == null;
						object obj10 = !flag4;
						if (obj10 == null)
						{
							goto IL_0200;
						}
					}
				}
			}
			goto IL_0259;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0200:
		if (IsSubscribed == friend.isSubscribed)
		{
			object obj11 = (IsVerified ? 1 : 0) - (friend.isVerified ? 1 : 0);
			bool flag5 = obj11 == null;
			return !flag5;
		}
		goto IL_0259;
		IL_0259:
		return true;
	}

	private bool CheckDirty(PlayerProfileModel profile, Games? currentGame = null)
	{
		//IL_02df: Expected I4, but got O
		//IL_005d: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		//IL_0324: Expected O, but got I
		//IL_0342: Expected O, but got I4
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_02c6: Expected O, but got I4
		FriendGameData gameData = GetGameData(currentGame);
		if (profile != null)
		{
			if (UserID == profile.<userDbId>k__BackingField)
			{
				bool flag = UserName != profile.<userName>k__BackingField;
				bool flag2 = !flag;
				object obj = !flag2;
				if (obj == null && Cardback == profile.<activeCardback>k__BackingField && Pattern == profile.<activeProfilePattern>k__BackingField)
				{
					bool flag3 = Title != profile.<activeTitle>k__BackingField;
					bool flag4 = !flag3;
					object obj2 = !flag4;
					if (obj2 == null && IsSubscribed == profile.<isSubscribed>k__BackingField && IsVerified == profile.<isVerified>k__BackingField)
					{
						DateTime? dateTime = AvatarDate;
						object obj3 = (object?)dateTime ^ (object?)profile.<avatarDate>k__BackingField;
						object obj4 = obj3 & 1;
						bool flag5 = obj4 == null;
						object obj5 = !flag5;
						if (obj5 == null)
						{
							object obj6 = (??)dateTime & 1;
							if (obj6 != null)
							{
								object obj7 = typeof(DataRelation) + 712;
								object obj8 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v16+E4]");
								bool flag6 = (nint)0 == 0;
								object obj9 = !flag6;
								if (obj9 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string <activeTitle>k__BackingField = profile.<activeTitle>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [profile @ X1 (PlayerProfileModel)+60]");
								bool flag7 = (DateTime)<activeTitle>k__BackingField != (DateTime)0;
								bool flag8 = !flag7;
								object obj10 = !flag8;
								if (obj10 != null)
								{
									goto IL_02cb;
								}
							}
							if (gameData == null)
							{
								goto IL_02d1;
							}
							if (gameData.IsNew == profile.<isNew>k__BackingField && gameData.Points == profile.<points>k__BackingField)
							{
								TournamentRankingModel tournamentRankingModel = profile.<tournamentRanking>k__BackingField;
								if (profile.<tournamentRanking>k__BackingField != null)
								{
									tournamentRankingModel = (TournamentRankingModel)tournamentRankingModel.<currentMonthPoints>k__BackingField;
								}
								object obj11 = gameData.TournamentPoints - tournamentRankingModel;
								bool flag9 = obj11 == null;
								return !flag9;
							}
						}
					}
				}
			}
			goto IL_02cb;
		}
		goto IL_02d1;
		IL_02cb:
		return true;
		IL_02d1:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe override string ToString()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		object obj = "HH:mm:ss.ffZ" + 2408;
		object obj2 = "&action=sign-up" + 3568;
		int num = this + 16;
		string text = ((int*)num)->ToString();
		return (string)obj + text + (string)obj2 + UserName;
	}
}
