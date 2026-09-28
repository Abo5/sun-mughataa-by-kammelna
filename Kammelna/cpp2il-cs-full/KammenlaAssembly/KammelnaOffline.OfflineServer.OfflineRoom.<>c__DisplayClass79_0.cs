using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Features.GameReplay;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Managers;
using Sfs2X.Entities.Variables;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

namespace KammelnaOffline.OfflineServer;

public class OfflineRoom : Room
{
	private sealed class <>c__DisplayClass77_0
	{
		public int id;

		internal bool <GetUserById>b__0(User user)
		{
			//IL_00ea: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			if (user != null)
			{
				object obj = typeof(UsageHint) + 8;
				nint num = (nint)user;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
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
					goto IL_00ad;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				goto IL_012b;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_012b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X0_v3] (should have been resolved before IL gen)");
			object obj7 = default(object);
			object obj6 = obj7 - id;
			return obj6 == null;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_012b;
		}
	}

	private sealed class <>c__DisplayClass78_0
	{
		public int id;

		internal bool <GetSpectatorById>b__0(User user)
		{
			//IL_00ea: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			if (user != null)
			{
				object obj = typeof(UsageHint) + 8;
				nint num = (nint)user;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
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
					goto IL_00ad;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				goto IL_012b;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_012b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X0_v3] (should have been resolved before IL gen)");
			object obj7 = default(object);
			object obj6 = obj7 - id;
			return obj6 == null;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_012b;
		}
	}

	private sealed class <>c__DisplayClass79_0
	{
		public string name;

		internal bool <GetUserByName>b__0(User user)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			if (user != null)
			{
				object obj = typeof(UsageHint) + 8;
				nint num = (nint)user;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X10_v5-8]");
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
					goto IL_00ad;
				}
				object obj4 = obj3 + 1;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0140;
			}
			return null == name;
			IL_0140:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ X0_v4] (should have been resolved before IL gen)");
			string text = default(string);
			return text == name;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0140;
		}
	}

	private sealed class <>c__DisplayClass80_0
	{
		public string idName;

		internal bool <GetSpectatorByName>b__0(User user)
		{
			//IL_00f8: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			if (user != null)
			{
				object obj = typeof(UsageHint) + 8;
				nint num = (nint)user;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
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
					goto IL_00ad;
				}
				object obj4 = obj3 + 1;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0139;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0139:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X0_v3] (should have been resolved before IL gen)");
			string text = default(string);
			return text == idName;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0139;
		}
	}

	public const string OfflineGroupId = "Offline Rooms group";

	private string <Name>k__BackingField;

	public IRoomExtension RoomExtension;

	private readonly Dictionary<string, RoomVariable> _variables;

	private ISFSArray playersInfo;

	private readonly User[] users;

	private PlayerProfileModel[] _playersProfiles;

	private readonly List<User> <SpectatorList>k__BackingField;

	public int Id => 0;

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string GroupId => "October" + 72;

	public bool IsJoined
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsGame
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public bool IsHidden
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsPasswordProtected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsManaged
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int UserCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MaxUsers
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Capacity => 4;

	public List<User> PlayerList
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(List<Tween>) + 152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor((IEnumerable<object>)users);
			return (List<User>)(object)list;
		}
	}

	public List<User> UserList
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(List<Tween>) + 152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor((IEnumerable<object>)users);
			return (List<User>)(object)list;
		}
	}

	public List<User> SpectatorList => <SpectatorList>k__BackingField;

	public int SpectatorCount
	{
		get
		{
			//IL_001d: Expected I4, but got O
			List<User> list = <SpectatorList>k__BackingField;
			if (<SpectatorList>k__BackingField != null)
			{
				return list._size;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		set
		{
		}
	}

	public int MaxSpectators
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Dictionary<object, object> Properties
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotImplementedException ex = default(NotImplementedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1800;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (Dictionary<object, object>)(object)new OutOfMemoryException();
		}
		set
		{
		}
	}

	public IRoomManager RoomManager
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotImplementedException ex = default(NotImplementedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (IRoomManager)new OutOfMemoryException();
		}
		set
		{
		}
	}

	public OfflineRoom()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0191: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0298: Expected O, but got I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2776;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3512;
		object obj3 = typeof(List<Tween>) + 152;
		object obj4 = "October" + 64;
		object obj5 = typeof(SqlSingle[]) + 472;
		object obj6 = typeof(MemberAchievementClanFeedData) + 3264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj7 = this + 32;
		obj7 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj8 = this + 56;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj10 = this + 64;
		obj10 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj11 = this + 16;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		CachedUserInfoModel currentGameUserModel = OfflineUserInfo.CurrentGameUserModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineUser offlineUser = default(OfflineUser);
		offlineUser..ctor(currentGameUserModel);
		object obj12 = default(object);
		CachedUserInfoModel cachedUserInfoModel;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		CachedUserInfoModel cachedUserInfoModel2;
		if (obj12 != null)
		{
			bool flag = offlineUser == null;
			cachedUserInfoModel = currentGameUserModel;
			if (!flag)
			{
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8+40]");
				cachedUserInfoModel = (CachedUserInfoModel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8+40]");
				cachedUserInfoModel2 = (CachedUserInfoModel)0;
				if (flag2)
				{
					goto IL_04a9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v22+18]");
			if ((nint)0 != 0)
			{
				object obj14 = typeof(MemberAchievementClanFeedData) + 3248;
				object obj15 = "getSecondRescanTask" + 2104;
				object obj16 = "startPosition" + 2144;
				object obj17 = "startPosition" + 2160;
				object obj18 = "not" + 4000;
				object obj19 = obj12 + 32;
				obj19 = offlineUser;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj20 = this + 48;
				obj20 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj21 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj22 = default(object);
				obj22..ctor();
				object obj23 = obj22 + 24;
				obj23 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 2;
				object obj24 = obj22 + 32;
				object obj25 = default(object);
				obj24 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				SetVariable((RoomVariable)obj22);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj26 = default(object);
				obj26..ctor();
				object obj27 = obj26 + 24;
				obj27 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 2;
				object obj28 = obj26 + 32;
				object obj29 = default(object);
				obj28 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				SetVariable((RoomVariable)obj26);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj30 = default(object);
				obj30..ctor();
				object obj31 = obj30 + 24;
				obj31 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 2;
				object obj32 = obj30 + 32;
				object obj33 = default(object);
				obj32 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				SetVariable((RoomVariable)obj30);
				SetPlayers();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj34 = default(object);
				obj34..ctor();
				object obj35 = obj34 + 24;
				obj35 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 6;
				object obj36 = obj34 + 32;
				obj36 = playersInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				SetVariable((RoomVariable)obj34);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			cachedUserInfoModel = currentGameUserModel;
		}
		ex = new IndexOutOfRangeException();
		cachedUserInfoModel2 = cachedUserInfoModel;
		goto IL_04a9;
		IL_04a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public OfflineRoom(TutorialType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2312;
		object obj2 = typeof(MemberAchievementClanFeedData) + 3248;
		object obj3 = "ThisIsFakeReceiptData" + 2672;
		object obj4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2728;
		this..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj5 = this + 16;
		obj5 = friendlyName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj7 = default(object);
		obj7..ctor();
		object obj8 = obj7 + 24;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj9 = obj7 + 32;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj11 = default(object);
		obj11..ctor();
		object obj12 = obj11 + 24;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		object obj13 = obj11 + 32;
		object obj14 = default(object);
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj11);
	}

	public OfflineRoom(GameReplay gameReplay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0170: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2776;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3512;
		object obj3 = typeof(List<Tween>) + 152;
		object obj4 = typeof(SqlSingle[]) + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj5 = this + 32;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj6 = this + 56;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj8 = this + 64;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj9 = this + 48;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AssignPlayers(gameReplay);
		object obj11 = typeof(MemberAchievementClanFeedData) + 3248;
		object obj12 = "https://www.kammelna.com/Home/Terms" + 200;
		object obj13 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2728;
		object obj14 = this + 16;
		obj14 = gameReplay.<Name>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj16 = default(object);
		obj16..ctor();
		object obj17 = obj16 + 24;
		obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj18 = obj16 + 32;
		object obj19 = default(object);
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj20 = default(object);
		obj20..ctor();
		object obj21 = obj20 + 24;
		obj21 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		object obj22 = obj20 + 32;
		object obj23 = default(object);
		obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = "placementId" + 2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj25 = default(object);
		obj25..ctor();
		object obj26 = obj25 + 24;
		obj26 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj27 = obj25 + 32;
		object obj28 = default(object);
		obj27 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj25);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = "getSecondRescanTask" + 2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj30 = default(object);
		obj30..ctor();
		object obj31 = obj30 + 24;
		obj31 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj32 = obj30 + 32;
		object obj33 = default(object);
		obj32 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj30);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = "startPosition" + 2144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj35 = default(object);
		obj35..ctor();
		object obj36 = obj35 + 24;
		obj36 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj37 = obj35 + 32;
		object obj38 = default(object);
		obj37 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj35);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = "startPosition" + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj40 = default(object);
		obj40..ctor();
		object obj41 = obj40 + 24;
		obj41 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj42 = obj40 + 32;
		object obj43 = default(object);
		obj42 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj40);
	}

	private void SetPlayers()
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f4: Expected I, but got O
		//IL_0104: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0270: Expected I, but got O
		//IL_0280: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_0326: Expected O, but got I
		//IL_034a: Expected O, but got I4
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03ec: Expected I, but got O
		//IL_03fc: Expected O, but got I
		//IL_02bb: Expected O, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_022a: Expected O, but got I
		//IL_04a2: Expected O, but got I
		//IL_04c6: Expected O, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0577: Expected I, but got O
		//IL_0587: Expected O, but got I
		//IL_0437: Expected O, but got I
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_143f: Expected I, but got O
		//IL_144f: Expected O, but got I
		//IL_05c2: Expected O, but got I
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_0522: Expected O, but got I
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_14aa: Expected I, but got O
		//IL_14ba: Expected O, but got I
		//IL_0666: Expected O, but got I
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected O, but got Unknown
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_1515: Expected I, but got O
		//IL_1525: Expected O, but got I
		//IL_070a: Expected O, but got I
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_157d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1582: Expected O, but got Unknown
		//IL_1594: Expected I, but got O
		//IL_15a4: Expected O, but got I
		//IL_07ae: Expected O, but got I
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected O, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected O, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected O, but got Unknown
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1601: Expected O, but got Unknown
		//IL_1635: Expected O, but got I4
		//IL_0852: Expected O, but got I
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected O, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected O, but got Unknown
		//IL_0931: Expected O, but got I4
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_1658: Expected I, but got O
		//IL_1668: Expected O, but got I
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected O, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected O, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_16c3: Expected I, but got O
		//IL_16d3: Expected O, but got I
		//IL_0964: Expected O, but got I
		//IL_172e: Expected I, but got O
		//IL_173e: Expected O, but got I
		//IL_0a08: Expected O, but got I
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected O, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected O, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected O, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected O, but got Unknown
		//IL_1791: Unknown result type (might be due to invalid IL or missing references)
		//IL_1796: Expected O, but got Unknown
		//IL_17a8: Expected I, but got O
		//IL_17b8: Expected O, but got I
		//IL_0aac: Expected O, but got I
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected O, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected O, but got Unknown
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected O, but got Unknown
		//IL_1813: Expected I, but got O
		//IL_1823: Expected O, but got I
		//IL_0b50: Expected O, but got I
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected O, but got Unknown
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Expected O, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected O, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected O, but got Unknown
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected O, but got Unknown
		//IL_187e: Expected I, but got O
		//IL_188e: Expected O, but got I
		//IL_0bf4: Expected O, but got I
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected O, but got Unknown
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected O, but got Unknown
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected O, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected O, but got Unknown
		//IL_18e9: Expected I, but got O
		//IL_18f9: Expected O, but got I
		//IL_0c98: Expected O, but got I
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected O, but got Unknown
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected O, but got Unknown
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c75: Expected O, but got Unknown
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected O, but got Unknown
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Expected O, but got Unknown
		//IL_1954: Expected I, but got O
		//IL_1964: Expected O, but got I
		//IL_0d3c: Expected O, but got I
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Expected O, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected O, but got Unknown
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Expected O, but got Unknown
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Expected O, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected O, but got Unknown
		//IL_0de0: Expected O, but got I
		//IL_0d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da2: Expected O, but got Unknown
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Expected O, but got Unknown
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Expected O, but got Unknown
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected O, but got Unknown
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected O, but got Unknown
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected O, but got Unknown
		//IL_0e9a: Expected O, but got I
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Expected O, but got Unknown
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected O, but got Unknown
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e61: Expected O, but got Unknown
		//IL_0f5c: Expected O, but got I4
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected O, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected O, but got Unknown
		//IL_0ff7: Expected O, but got I
		//IL_0ed5: Expected O, but got I
		//IL_10b9: Expected O, but got I4
		//IL_1154: Expected O, but got I
		//IL_1032: Expected O, but got I
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Expected O, but got Unknown
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected O, but got Unknown
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Expected O, but got Unknown
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected O, but got Unknown
		//IL_118f: Expected O, but got I
		//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected O, but got Unknown
		//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fd: Expected O, but got Unknown
		//IL_1239: Expected O, but got I
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_1045: Expected O, but got Unknown
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Expected O, but got Unknown
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d2: Expected O, but got Unknown
		//IL_12e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Expected O, but got Unknown
		//IL_1321: Expected O, but got I4
		//IL_1a94: Expected O, but got I
		//IL_1274: Expected O, but got I
		//IL_119d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a2: Expected O, but got Unknown
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Expected O, but got Unknown
		//IL_1343: Unknown result type (might be due to invalid IL or missing references)
		//IL_1348: Expected O, but got Unknown
		//IL_135e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363: Expected O, but got Unknown
		//IL_1282: Unknown result type (might be due to invalid IL or missing references)
		//IL_1287: Expected O, but got Unknown
		//IL_1290: Unknown result type (might be due to invalid IL or missing references)
		//IL_1295: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8018]");
		object obj = 0;
		object obj2 = typeof(RegisteredWaitHandle) + 1888;
		object obj3 = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		object obj4 = this + 40;
		obj4 = sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject2 = default(SFSObject);
		sFSObject2..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject3 = default(SFSObject);
		sFSObject3..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject4 = default(SFSObject);
		sFSObject4..ctor();
		object obj5;
		object obj9;
		object obj14;
		object obj10 = default(object);
		if (sFSObject != null)
		{
			obj5 = typeof(System.IOAsyncCallback) + 976;
			object obj6 = "m_StencilDeferredPS" + 2872;
			object obj7 = "Error reading data from socket: " + 3656;
			nint num = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0188;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
			obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X10_v28-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				obj10 = obj9 + 16;
				obj8--;
				bool flag = (nint)obj8 != 1;
				obj9 = obj10;
				if (flag)
				{
					continue;
				}
				goto IL_0188;
			}
			object obj11 = obj9 + 39;
			object obj12 = num + obj11;
			object obj13 = obj12 + 312;
			obj = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v155+8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v554 @ X0_v155] (should have been resolved before IL gen)");
			bool flag2 = sFSObject2 == null;
			obj10 = obj9;
			if (!flag2)
			{
				goto IL_0259;
			}
		}
		goto IL_132f;
		IL_07f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_156e;
		IL_156e:
		object obj15 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1011 @ X0_v32] (should have been resolved before IL gen)");
		nint num2 = (nint)sFSObject4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_089b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X10_v86-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj17 + 16;
			obj16--;
			bool flag3 = (nint)obj16 != 1;
			obj17 = obj9;
			if (flag3)
			{
				continue;
			}
			goto IL_089b;
		}
		object obj18 = obj17 + 35;
		object obj19 = num2 + obj18;
		object obj20 = obj19 + 312;
		obj9 = obj17;
		goto IL_15ed;
		IL_1a7c:
		object obj22 = default(object);
		object obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v14+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v535 @ X3_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_12b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1a7c;
		IL_1787:
		object obj24 = "https://www.kammelna.com/Home/Terms" + 3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1360 @ X0_v50] (should have been resolved before IL gen)");
		nint num3 = (nint)sFSObject4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1371 @ X8_v47 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1371 @ X8_v47 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b99;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1371 @ X8_v47 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj26 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X10_v66-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj26 + 16;
			obj25--;
			bool flag4 = (nint)obj25 != 1;
			obj26 = obj9;
			if (flag4)
			{
				continue;
			}
			goto IL_0b99;
		}
		object obj27 = obj26 + 35;
		object obj28 = num3 + obj27;
		object obj29 = obj28 + 312;
		obj9 = obj26;
		goto IL_1801;
		IL_0188:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj30 = default(object);
		obj = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v152+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v433 @ X0_v152] (should have been resolved before IL gen)");
		bool flag5 = sFSObject2 == null;
		object obj31 = !flag5;
		obj9 = obj10;
		if (obj31 != null)
		{
			goto IL_0259;
		}
		goto IL_132f;
		IL_0259:
		object obj32 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2456;
		nint num4 = (nint)sFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0304;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X10_v2-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj10 + 16;
			obj33--;
			bool flag6 = (nint)obj33 != 1;
			obj10 = obj9;
			if (flag6)
			{
				continue;
			}
			goto IL_0304;
		}
		object obj34 = obj10 + 39;
		object obj35 = num4 + obj34;
		object obj36 = obj35 + 312;
		obj = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X0_v148+8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v612 @ X0_v148] (should have been resolved before IL gen)");
		bool flag7 = sFSObject3 == null;
		obj9 = obj10;
		if (!flag7)
		{
			goto IL_03d5;
		}
		goto IL_132f;
		IL_132f:
		throw new NullReferenceException();
		IL_11d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj38 = default(object);
		obj = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1887 @ X0_v74] (should have been resolved before IL gen)");
		object obj39 = obj4;
		bool flag8 = obj4 == null;
		obj10 = obj9;
		if (!flag8)
		{
			goto IL_1221;
		}
		goto IL_132f;
		IL_089b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_15ed;
		IL_107b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj40 = default(object);
		obj = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1832 @ X0_v81] (should have been resolved before IL gen)");
		object obj41 = obj4;
		bool flag9 = obj4 == null;
		object obj42 = !flag9;
		if (obj42 != null)
		{
			goto IL_113c;
		}
		obj10 = obj9;
		goto IL_132f;
		IL_0304:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj43 = default(object);
		obj = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v145+8]");
		obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v595 @ X0_v145] (should have been resolved before IL gen)");
		bool flag10 = sFSObject3 == null;
		object obj44 = !flag10;
		if (obj44 != null)
		{
			goto IL_03d5;
		}
		obj10 = obj9;
		goto IL_132f;
		IL_03d5:
		object obj45 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2464;
		nint num5 = (nint)sFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0480;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X10_v2-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj10 + 16;
			obj46--;
			bool flag11 = (nint)obj46 != 1;
			obj10 = obj9;
			if (flag11)
			{
				continue;
			}
			goto IL_0480;
		}
		object obj47 = obj10 + 39;
		object obj48 = num5 + obj47;
		object obj49 = obj48 + 312;
		obj = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v141+8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v670 @ X0_v141] (should have been resolved before IL gen)");
		bool flag12 = sFSObject4 == null;
		obj9 = obj10;
		if (!flag12)
		{
			goto IL_0551;
		}
		goto IL_132f;
		IL_0af5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1787;
		IL_0d85:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1942;
		IL_0c3d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_186c;
		IL_113c:
		object obj51 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1869 @ X8_v66+12E]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1869 @ X8_v66+12E]");
		if ((nint)0 == 0)
		{
			goto IL_11d8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1869 @ X8_v66+B0]");
		obj10 = (nint)0 + (nint)8;
		object obj53;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X10_v2-8]");
			if (0 == (nint)obj53)
			{
				break;
			}
			obj9 = obj10 + 16;
			obj52--;
			bool flag13 = (nint)obj52 != 1;
			obj10 = obj9;
			if (flag13)
			{
				continue;
			}
			goto IL_11d8;
		}
		object obj54 = obj10 + 29;
		object obj55 = obj51 + obj54;
		object obj56 = obj55 + 312;
		obj = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1903 @ X0_v77] (should have been resolved before IL gen)");
		obj39 = obj4;
		bool flag14 = obj4 == null;
		object obj57 = !flag14;
		if (obj57 != null)
		{
			goto IL_1221;
		}
		goto IL_132f;
		IL_0480:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj58 = default(object);
		obj = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v138+8]");
		obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v653 @ X0_v138] (should have been resolved before IL gen)");
		bool flag15 = sFSObject4 == null;
		object obj59 = !flag15;
		if (obj59 != null)
		{
			goto IL_0551;
		}
		obj10 = obj9;
		goto IL_132f;
		IL_0551:
		object obj60 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2472;
		object obj61 = "placementId" + 2208;
		nint num6 = (nint)sFSObject4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_060b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj63 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X10_v106-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj63 + 16;
			obj62--;
			bool flag16 = (nint)obj62 != 1;
			obj63 = obj9;
			if (flag16)
			{
				continue;
			}
			goto IL_060b;
		}
		object obj64 = obj63 + 39;
		object obj65 = num6 + obj64;
		object obj66 = obj65 + 312;
		obj9 = obj63;
		goto IL_142d;
		IL_186c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1523 @ X0_v56] (should have been resolved before IL gen)");
		nint num7 = (nint)sFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ X8_v53 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ X8_v53 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ce1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ X8_v53 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj68 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1575 @ X10_v56-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj68 + 16;
			obj67--;
			bool flag17 = (nint)obj67 != 1;
			obj68 = obj9;
			if (flag17)
			{
				continue;
			}
			goto IL_0ce1;
		}
		object obj69 = obj68 + 32;
		object obj70 = num7 + obj69;
		object obj71 = obj70 + 312;
		obj9 = obj68;
		goto IL_18d7;
		IL_0ce1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_18d7;
		IL_0e29:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_19ad;
		IL_19ad:
		object obj72 = default(object);
		obj = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1754 @ X0_v65] (should have been resolved before IL gen)");
		object obj73 = obj4;
		bool flag18 = obj4 == null;
		obj10 = obj9;
		object obj79;
		if (!flag18)
		{
			obj53 = typeof(System.IOAsyncCallback) + 960;
			object obj74 = obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1759 @ X8_v62+12E]");
			object obj75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1759 @ X8_v62+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0f1e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1759 @ X8_v62+B0]");
			obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X10_v2-8]");
				if (0 == (nint)obj53)
				{
					break;
				}
				obj9 = obj10 + 16;
				obj75--;
				bool flag19 = (nint)obj75 != 1;
				obj10 = obj9;
				if (flag19)
				{
					continue;
				}
				goto IL_0f1e;
			}
			object obj76 = obj10 + 29;
			object obj77 = obj74 + obj76;
			object obj78 = obj77 + 312;
			obj = obj78;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1794 @ X0_v91] (should have been resolved before IL gen)");
			obj79 = obj4;
			bool flag20 = obj4 == null;
			obj9 = obj10;
			if (!flag20)
			{
				goto IL_0fdf;
			}
		}
		goto IL_132f;
		IL_060b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_142d;
		IL_142d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v768 @ X0_v23] (should have been resolved before IL gen)");
		nint num8 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06af;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj81 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X10_v101-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj81 + 16;
			obj80--;
			bool flag21 = (nint)obj80 != 1;
			obj81 = obj9;
			if (flag21)
			{
				continue;
			}
			goto IL_06af;
		}
		object obj82 = obj81 + 35;
		object obj83 = num8 + obj82;
		object obj84 = obj83 + 312;
		obj9 = obj81;
		goto IL_1498;
		IL_1221:
		obj = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v4+12E]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v4+12E]");
		if ((nint)0 == 0)
		{
			goto IL_12b5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v4+B0]");
		obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X10_v2-8]");
			if (0 == (nint)obj53)
			{
				break;
			}
			obj10 += 16;
			obj85--;
			if ((nint)obj85 != 1)
			{
				continue;
			}
			goto IL_12b5;
		}
		object obj86 = obj10 + 29;
		object obj87 = obj + obj86;
		obj22 = obj87 + 312;
		goto IL_1a7c;
		IL_09ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_16b1;
		IL_16b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1198 @ X0_v44] (should have been resolved before IL gen)");
		nint num9 = (nint)sFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X8_v41 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X8_v41 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a51;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X8_v41 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj89 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X10_v76-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj89 + 16;
			obj88--;
			bool flag22 = (nint)obj88 != 1;
			obj89 = obj9;
			if (flag22)
			{
				continue;
			}
			goto IL_0a51;
		}
		object obj90 = obj89 + 35;
		object obj91 = num9 + obj90;
		object obj92 = obj91 + 312;
		obj9 = obj89;
		goto IL_171c;
		IL_0f1e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj93 = default(object);
		obj = obj93;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1777 @ X0_v88] (should have been resolved before IL gen)");
		obj79 = obj4;
		bool flag23 = obj4 == null;
		object obj94 = !flag23;
		if (obj94 != null)
		{
			goto IL_0fdf;
		}
		obj10 = obj9;
		goto IL_132f;
		IL_06af:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1498;
		IL_1498:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v849 @ X0_v26] (should have been resolved before IL gen)");
		nint num10 = (nint)sFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0753;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj96 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X10_v96-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj96 + 16;
			obj95--;
			bool flag24 = (nint)obj95 != 1;
			obj96 = obj9;
			if (flag24)
			{
				continue;
			}
			goto IL_0753;
		}
		object obj97 = obj96 + 35;
		object obj98 = num10 + obj97;
		object obj99 = obj98 + 312;
		obj9 = obj96;
		goto IL_1503;
		IL_0b99:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1801;
		IL_1801:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1442 @ X0_v53] (should have been resolved before IL gen)");
		nint num11 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v50 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v50 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c3d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v50 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj101 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X10_v61-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj101 + 16;
			obj100--;
			bool flag25 = (nint)obj100 != 1;
			obj101 = obj9;
			if (flag25)
			{
				continue;
			}
			goto IL_0c3d;
		}
		object obj102 = obj101 + 32;
		object obj103 = num11 + obj102;
		object obj104 = obj103 + 312;
		obj9 = obj101;
		goto IL_186c;
		IL_18d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1604 @ X0_v59] (should have been resolved before IL gen)");
		nint num12 = (nint)sFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1614 @ X8_v56 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1614 @ X8_v56 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0d85;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1614 @ X8_v56 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj106 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1656 @ X10_v51-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj106 + 16;
			obj105--;
			bool flag26 = (nint)obj105 != 1;
			obj106 = obj9;
			if (flag26)
			{
				continue;
			}
			goto IL_0d85;
		}
		object obj107 = obj106 + 32;
		object obj108 = num12 + obj107;
		object obj109 = obj108 + 312;
		obj9 = obj106;
		goto IL_1942;
		IL_0fdf:
		object obj110 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1814 @ X8_v64+12E]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1814 @ X8_v64+12E]");
		if ((nint)0 == 0)
		{
			goto IL_107b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1814 @ X8_v64+B0]");
		obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X10_v2-8]");
			if (0 == (nint)obj53)
			{
				break;
			}
			obj9 = obj10 + 16;
			obj111--;
			bool flag27 = (nint)obj111 != 1;
			obj10 = obj9;
			if (flag27)
			{
				continue;
			}
			goto IL_107b;
		}
		object obj112 = obj10 + 29;
		object obj113 = obj110 + obj112;
		object obj114 = obj113 + 312;
		obj = obj114;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1849 @ X0_v84] (should have been resolved before IL gen)");
		obj41 = obj4;
		bool flag28 = obj4 == null;
		obj9 = obj10;
		if (!flag28)
		{
			goto IL_113c;
		}
		goto IL_132f;
		IL_0753:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1503;
		IL_1503:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v930 @ X0_v29] (should have been resolved before IL gen)");
		nint num13 = (nint)sFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v30 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj115 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v30 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07f7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v30 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj116 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X10_v91-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj116 + 16;
			obj115--;
			bool flag29 = (nint)obj115 != 1;
			obj116 = obj9;
			if (flag29)
			{
				continue;
			}
			goto IL_07f7;
		}
		object obj117 = obj116 + 35;
		object obj118 = num13 + obj117;
		object obj119 = obj118 + 312;
		obj9 = obj116;
		goto IL_156e;
		IL_1942:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1685 @ X0_v62] (should have been resolved before IL gen)");
		nint num14 = (nint)sFSObject4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v59 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v59 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e29;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v59 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj121 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1737 @ X10_v46-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj121 + 16;
			obj120--;
			bool flag30 = (nint)obj120 != 1;
			obj121 = obj9;
			if (flag30)
			{
				continue;
			}
			goto IL_0e29;
		}
		object obj122 = obj121 + 32;
		object obj123 = num14 + obj122;
		obj72 = obj123 + 312;
		obj9 = obj121;
		goto IL_19ad;
		IL_0a51:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_171c;
		IL_171c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1279 @ X0_v47] (should have been resolved before IL gen)");
		nint num15 = (nint)sFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ X8_v44 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ X8_v44 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0af5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ X8_v44 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj125 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X10_v71-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj125 + 16;
			obj124--;
			bool flag31 = (nint)obj124 != 1;
			obj125 = obj9;
			if (flag31)
			{
				continue;
			}
			goto IL_0af5;
		}
		object obj126 = obj125 + 35;
		object obj127 = num15 + obj126;
		object obj128 = obj127 + 312;
		obj9 = obj125;
		goto IL_1787;
		IL_15ed:
		object obj129 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1094 @ X0_v35] (should have been resolved before IL gen)");
		object obj130 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v38+E4]");
		bool flag32 = (nint)0 == 0;
		object obj131 = !flag32;
		if (obj131 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj132 = "https://www.kammelna.com/Home/Terms" + 136;
		string userDbId = UserInfo.UserDbId;
		object obj133 = obj129;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X8_v37+E4]");
		bool flag33 = (nint)0 == 0;
		object obj134 = !flag33;
		if (obj134 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num16 = Convert.ToInt32(userDbId);
		nint num17 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj135 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_09ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj136 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X10_v81-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 = obj136 + 16;
			obj135--;
			bool flag34 = (nint)obj135 != 1;
			obj136 = obj9;
			if (flag34)
			{
				continue;
			}
			goto IL_09ad;
		}
		object obj137 = obj136 + 35;
		object obj138 = num17 + obj137;
		object obj139 = obj138 + 312;
		obj9 = obj136;
		goto IL_16b1;
	}

	public void AssignPlayers(GameReplay gameReplay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004a: Expected O, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0166: Expected O, but got I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I8
		//IL_01ba: Expected O, but got I4
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected O, but got Unknown
		//IL_09f6: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_0b2c: Expected O, but got I4
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected O, but got Unknown
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Expected O, but got Unknown
		//IL_0be4: Expected I4, but got O
		//IL_026a: Expected O, but got I4
		//IL_0c0a: Expected O, but got I
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_030f: Expected O, but got I4
		//IL_010e: Expected I4, but got O
		//IL_0c45: Expected O, but got I
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected O, but got Unknown
		//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Expected O, but got Unknown
		//IL_0361: Expected O, but got I4
		//IL_036a: Expected O, but got I4
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Expected O, but got Unknown
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected O, but got Unknown
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected O, but got Unknown
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected O, but got Unknown
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c58: Expected O, but got Unknown
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Expected O, but got Unknown
		//IL_03cb: Expected O, but got I4
		//IL_040c: Expected O, but got I4
		//IL_0427: Expected O, but got I4
		//IL_0430: Expected O, but got I4
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04ce: Expected O, but got I
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_052d: Expected O, but got I4
		//IL_0535: Expected I4, but got O
		//IL_053a: Expected I, but got O
		//IL_0542: Expected I4, but got O
		//IL_056b: Expected O, but got I4
		//IL_0574: Expected O, but got I4
		//IL_057c: Expected I4, but got O
		//IL_0581: Expected I, but got O
		//IL_0589: Expected I4, but got O
		//IL_05af: Expected O, but got I4
		//IL_05b7: Expected I4, but got O
		//IL_05bc: Expected I, but got O
		//IL_05c4: Expected I4, but got O
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_0623: Expected O, but got I4
		//IL_062b: Expected I4, but got O
		//IL_0630: Expected I, but got O
		//IL_0638: Expected I4, but got O
		//IL_0661: Expected O, but got I4
		//IL_066a: Expected O, but got I4
		//IL_0672: Expected I4, but got O
		//IL_0677: Expected I, but got O
		//IL_067f: Expected I4, but got O
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_06de: Expected O, but got I4
		//IL_06e6: Expected I4, but got O
		//IL_06eb: Expected I, but got O
		//IL_06f3: Expected I4, but got O
		//IL_071c: Expected O, but got I4
		//IL_0725: Expected O, but got I4
		//IL_072d: Expected I4, but got O
		//IL_0732: Expected I, but got O
		//IL_073a: Expected I4, but got O
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		//IL_077b: Expected O, but got I
		//IL_0783: Expected I, but got O
		//IL_0791: Expected O, but got I4
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_080c: Expected O, but got I4
		//IL_0814: Expected I4, but got O
		//IL_081c: Expected I4, but got O
		//IL_0841: Expected I4, but got O
		//IL_08d2: Expected O, but got I4
		//IL_08e3: Expected O, but got I4
		//IL_08eb: Expected I4, but got O
		//IL_0857: Expected I, but got O
		//IL_0891: Expected O, but got I4
		//IL_0899: Expected I4, but got O
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected O, but got Unknown
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_0952: Expected O, but got I4
		//IL_0964: Expected O, but got I4
		//IL_096c: Expected I4, but got O
		//IL_0984: Expected I4, but got O
		//IL_09a3: Expected O, but got I4
		//IL_09ab: Expected I4, but got O
		//IL_09b3: Expected I4, but got O
		object obj = typeof(RegisteredWaitHandle) + 1888;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		object obj3 = this + 40;
		obj3 = sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj4 = this + 56;
		Games games = default(Games);
		obj4 = games;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = gameReplay == null;
		Games games2 = games;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj5 = typeof(System.IOAsyncCallback) + 960;
			games2 = games;
			int num = 0;
			PlayerRank playerRank = default(PlayerRank);
			PlayerInfo playerInfo = default(PlayerInfo);
			PlayerProfileModel playerProfileModel3 = default(PlayerProfileModel);
			OfflineUser offlineUser = default(OfflineUser);
			object obj42 = default(object);
			OfflineRoom offlineRoom = default(OfflineRoom);
			DateTime? dateTime2 = default(DateTime?);
			object obj15 = default(object);
			bool flag7 = default(bool);
			nint num3 = default(nint);
			while (true)
			{
				int[] <PlayersDbIds>k__BackingField = gameReplay.<PlayersDbIds>k__BackingField;
				if (gameReplay.<PlayersDbIds>k__BackingField == null)
				{
					break;
				}
				bool flag2 = num < <PlayersDbIds>k__BackingField.Length;
				object obj6 = !flag2;
				object obj13;
				DateTime? dateTime;
				object obj14;
				bool flag6;
				PlayerProfileModel playerProfileModel2;
				nint num2;
				Games games3;
				if (obj6 == null)
				{
					object obj7 = gameReplay.<PlayersDbIds>k__BackingField + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v8+20]");
					object obj8 = 0 & 0x80000000L;
					bool flag3 = obj8 == null;
					object obj9 = !flag3;
					if (obj9 != null)
					{
						object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v41+E4]");
						bool flag4 = (nint)0 == 0;
						object obj12 = !flag4;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						PlayerProfileModel playerProfileModel = PlayerProfilesHandler.AiProfileModel(num);
						obj13 = obj4;
						bool flag5 = obj4 == null;
						dateTime = dateTime2;
						obj14 = obj15;
						flag6 = flag7;
						playerProfileModel2 = playerProfileModel;
						num2 = num3;
						games3 = Games.Baloot;
						games2 = Games.Baloot;
						if (flag5)
						{
							break;
						}
						goto IL_0a7f;
					}
					int[] <PlayersRanksPoints>k__BackingField = gameReplay.<PlayersRanksPoints>k__BackingField;
					if (gameReplay.<PlayersRanksPoints>k__BackingField == null)
					{
						break;
					}
					bool flag8 = num < <PlayersRanksPoints>k__BackingField.Length;
					object obj16 = !flag8;
					if (obj16 == null)
					{
						bool[] <PlayersRanksIsNew>k__BackingField = gameReplay.<PlayersRanksIsNew>k__BackingField;
						if (gameReplay.<PlayersRanksIsNew>k__BackingField == null)
						{
							break;
						}
						bool flag9 = num < <PlayersRanksIsNew>k__BackingField.Length;
						object obj17 = !flag9;
						if (obj17 == null)
						{
							object obj18 = gameReplay.<PlayersRanksPoints>k__BackingField + num;
							object obj19 = gameReplay.<PlayersRanksIsNew>k__BackingField + num;
							object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v27+20]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v28+20]");
							playerRank..ctor(Games.Baloot, (int)num4, isNew: false);
							int[] <PlayersDbIds>k__BackingField2 = gameReplay.<PlayersDbIds>k__BackingField;
							bool flag10 = gameReplay.<PlayersDbIds>k__BackingField == null;
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v28+20]");
							flag7 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v27+20]");
							num3 = 0;
							games2 = Games.Baloot;
							if (flag10)
							{
								break;
							}
							bool flag11 = num < <PlayersDbIds>k__BackingField2.Length;
							object obj21 = !flag11;
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v28+20]");
							flag7 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v27+20]");
							num3 = 0;
							games2 = Games.Baloot;
							if (obj21 == null)
							{
								string[] <PlayersNames>k__BackingField = gameReplay.<PlayersNames>k__BackingField;
								bool flag12 = gameReplay.<PlayersNames>k__BackingField == null;
								obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v28+20]");
								flag7 = false;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v27+20]");
								num3 = 0;
								games2 = Games.Baloot;
								if (flag12)
								{
									break;
								}
								object obj22 = <PlayersNames>k__BackingField.Length;
								bool flag13 = num < <PlayersNames>k__BackingField.Length;
								object obj23 = !flag13;
								obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v28+20]");
								flag7 = false;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v27+20]");
								num3 = 0;
								games2 = Games.Baloot;
								if (obj23 == null)
								{
									object obj24 = gameReplay.<PlayersDbIds>k__BackingField + num;
									object obj25 = gameReplay.<PlayersNames>k__BackingField + num;
									object obj26 = typeof(System.Buffers.Text.ParserHelpers) + 936;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v32+20]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v33+20]");
									playerInfo..ctor((int)num5, (string)0, playerRank);
									object obj27 = typeof(System.Buffers.Text.ParserHelpers) + 1048;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									playerProfileModel3..ctor(playerInfo);
									bool[] <PlayersSubscribed>k__BackingField = gameReplay.<PlayersSubscribed>k__BackingField;
									bool flag14 = gameReplay.<PlayersSubscribed>k__BackingField == null;
									obj15 = 0;
									flag7 = (byte)(int)playerRank != 0;
									num3 = unchecked((nint)null);
									games2 = (Games)playerInfo;
									if (flag14)
									{
										break;
									}
									bool flag15 = num < <PlayersSubscribed>k__BackingField.Length;
									object obj28 = !flag15;
									obj15 = 0;
									flag7 = (byte)(int)playerRank != 0;
									num3 = unchecked((nint)null);
									games2 = (Games)playerInfo;
									if (obj28 == null)
									{
										bool flag16 = playerProfileModel3 == null;
										obj15 = 0;
										flag7 = (byte)(int)playerRank != 0;
										num3 = unchecked((nint)null);
										games2 = (Games)playerInfo;
										if (flag16)
										{
											break;
										}
										object obj29 = gameReplay.<PlayersSubscribed>k__BackingField + num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v39+20]");
										playerProfileModel3.<isSubscribed>k__BackingField = false;
										bool[] <PlayersVerified>k__BackingField = gameReplay.<PlayersVerified>k__BackingField;
										bool flag17 = gameReplay.<PlayersVerified>k__BackingField == null;
										obj15 = 0;
										flag7 = (byte)(int)playerRank != 0;
										num3 = unchecked((nint)null);
										games2 = (Games)playerInfo;
										if (flag17)
										{
											break;
										}
										bool flag18 = num < <PlayersVerified>k__BackingField.Length;
										object obj30 = !flag18;
										obj15 = 0;
										flag7 = (byte)(int)playerRank != 0;
										num3 = unchecked((nint)null);
										games2 = (Games)playerInfo;
										if (obj30 == null)
										{
											object obj31 = gameReplay.<PlayersVerified>k__BackingField + num;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v42+20]");
											playerProfileModel3.<isVerified>k__BackingField = false;
											int[] <PlayersActiveCardsBack>k__BackingField = gameReplay.<PlayersActiveCardsBack>k__BackingField;
											bool flag19 = gameReplay.<PlayersActiveCardsBack>k__BackingField == null;
											obj15 = 0;
											flag7 = (byte)(int)playerRank != 0;
											num3 = unchecked((nint)null);
											games2 = (Games)playerInfo;
											if (flag19)
											{
												break;
											}
											bool flag20 = num < <PlayersActiveCardsBack>k__BackingField.Length;
											object obj32 = !flag20;
											obj15 = 0;
											flag7 = (byte)(int)playerRank != 0;
											num3 = unchecked((nint)null);
											games2 = (Games)playerInfo;
											if (obj32 == null)
											{
												object obj33 = gameReplay.<PlayersActiveCardsBack>k__BackingField + num;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v45+20]");
												playerProfileModel3.<activeCardback>k__BackingField = 0;
												object obj34 = (nint)0 + (nint)2264;
												num3 = (nint)obj34;
												DateTime? dateTime3 = (playerProfileModel3.<avatarDate>k__BackingField = (DateTime)0);
												User[] array = users;
												CachedUserInfoModel cachedUserInfoModel = GenerateCachedUserInfoModel(playerProfileModel3);
												object obj35 = typeof(MemberAchievementClanFeedData) + 3264;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												offlineUser..ctor(cachedUserInfoModel);
												bool flag21 = users == null;
												dateTime2 = dateTime3;
												obj15 = 0;
												flag7 = (byte)(int)playerRank != 0;
												games2 = (Games)cachedUserInfoModel;
												if (flag21)
												{
													break;
												}
												bool flag22 = offlineUser == null;
												Games games4 = (Games)cachedUserInfoModel;
												if (!flag22)
												{
													nint num6 = (nint)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v53 (Il2CppClass<Sfs2X.Entities.User[]>)+40]");
													games4 = Games.Baloot;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag23 = ex == null;
													dateTime2 = dateTime3;
													obj15 = 0;
													flag7 = (byte)(int)playerRank != 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v53 (Il2CppClass<Sfs2X.Entities.User[]>)+40]");
													games2 = Games.Baloot;
													if (flag23)
													{
														goto IL_0d68;
													}
												}
												bool flag24 = num < array.Length;
												object obj36 = !flag24;
												dateTime2 = dateTime3;
												obj15 = 0;
												flag7 = (byte)(int)playerRank != 0;
												games2 = games4;
												if (obj36 == null)
												{
													object obj37 = users + num;
													object obj38 = obj37 + 32;
													obj38 = offlineUser;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													obj13 = obj4;
													bool flag25 = obj4 == null;
													object obj39 = !flag25;
													dateTime = dateTime3;
													obj14 = 0;
													flag6 = (byte)(int)playerRank != 0;
													playerProfileModel2 = playerProfileModel3;
													num2 = num3;
													games3 = (Games)offlineUser;
													if (obj39 == null)
													{
														dateTime2 = dateTime3;
														obj15 = 0;
														flag7 = (byte)(int)playerRank != 0;
														games2 = (Games)offlineUser;
														break;
													}
													goto IL_0a7f;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_0d5a;
				IL_00b7:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v25+8]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v595 @ X0_v25] (should have been resolved before IL gen)");
				num++;
				bool flag26 = num == 4;
				dateTime2 = dateTime;
				obj15 = obj14;
				flag7 = flag6;
				SFSObject sFSObject;
				games2 = (Games)sFSObject;
				if (!flag26)
				{
					continue;
				}
				object obj40 = typeof(MemberAchievementClanFeedData) + 3248;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj41 = "not" + 4000;
				obj42..ctor();
				object obj43 = obj42 + 24;
				obj43 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 6;
				object obj44 = obj42 + 32;
				obj44 = playersInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				SetVariable((RoomVariable)obj42);
				return;
				IL_0a7f:
				if (playerProfileModel2 != null)
				{
					object obj45 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v22+40]");
					games3 = Games.Baloot;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag27 = ex == null;
					dateTime2 = dateTime;
					obj15 = obj14;
					flag7 = flag6;
					num3 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v22+40]");
					games2 = Games.Baloot;
					if (flag27)
					{
						goto IL_0d68;
					}
				}
				int num7 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X25_v5+18]");
				bool flag28 = (nint)num7 < (nint)0;
				object obj46 = !flag28;
				dateTime2 = dateTime;
				obj15 = obj14;
				flag7 = flag6;
				num3 = num2;
				games2 = games3;
				if (obj46 == null)
				{
					object obj47 = obj13 + num;
					object obj48 = obj47 + 32;
					obj48 = playerProfileModel2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					sFSObject = offlineRoom.GeneratePlayerSFSObject(playerProfileModel2);
					object obj49 = obj3;
					bool flag29 = obj3 == null;
					dateTime2 = dateTime;
					obj15 = obj14;
					flag7 = flag6;
					num3 = num2;
					games2 = (Games)playerProfileModel2;
					if (flag29)
					{
						break;
					}
					object obj50 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v13+12E]");
					object obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v13+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00a8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v13+B0]");
					object obj22 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X10_v10-8]");
						if (0 == (nint)obj5)
						{
							break;
						}
						obj22 += 16;
						obj51--;
						if ((nint)obj51 != 1)
						{
							continue;
						}
						goto IL_00a8;
					}
					object obj52 = obj22 + 29;
					object obj53 = obj50 + obj52;
					object obj54 = obj53 + 312;
					goto IL_00b7;
				}
				goto IL_0d5a;
				IL_00a8:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_00b7;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0d5a;
		IL_0d5a:
		ex = new IndexOutOfRangeException();
		goto IL_0d68;
		IL_0d68:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void SetModelToUsers(int index, PlayerProfileModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_0065: Expected I, but got O
		//IL_0075: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3264;
		User[] array = users;
		CachedUserInfoModel cachedUserInfoModel = GenerateCachedUserInfoModel(model);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineUser offlineUser = default(OfflineUser);
		offlineUser..ctor(cachedUserInfoModel);
		CachedUserInfoModel cachedUserInfoModel2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		CachedUserInfoModel cachedUserInfoModel3;
		if (users != null)
		{
			bool flag = offlineUser == null;
			cachedUserInfoModel2 = cachedUserInfoModel;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7 (Il2CppClass<Sfs2X.Entities.User[]>)+40]");
				cachedUserInfoModel2 = (CachedUserInfoModel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7 (Il2CppClass<Sfs2X.Entities.User[]>)+40]");
				cachedUserInfoModel3 = (CachedUserInfoModel)0;
				if (flag2)
				{
					goto IL_0131;
				}
			}
			bool flag3 = index < array.Length;
			object obj2 = !flag3;
			if (obj2 == null)
			{
				object obj3 = users + index;
				object obj4 = obj3 + 32;
				obj4 = offlineUser;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			cachedUserInfoModel2 = cachedUserInfoModel;
		}
		ex = new IndexOutOfRangeException();
		cachedUserInfoModel3 = cachedUserInfoModel2;
		goto IL_0131;
		IL_0131:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void SetModelToPlayersProfiles(int index, PlayerProfileModel model)
	{
		//IL_00b8: Expected O, but got I4
		//IL_0056: Expected I, but got O
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		PlayerProfileModel[] playersProfiles = _playersProfiles;
		int num;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		int num3;
		if (_playersProfiles != null)
		{
			bool flag = model == null;
			num = index;
			if (!flag)
			{
				nint num2 = (nint)playersProfiles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5 (Il2CppClass<PlayerProfileModel[]>)+40]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5 (Il2CppClass<PlayerProfileModel[]>)+40]");
				num3 = 0;
				if (flag2)
				{
					goto IL_0122;
				}
			}
			bool flag3 = index < playersProfiles.Length;
			object obj = !flag3;
			if (obj == null)
			{
				object obj2 = _playersProfiles + index;
				object obj3 = obj2 + 32;
				obj3 = model;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			num = index;
		}
		ex = new IndexOutOfRangeException();
		num3 = num;
		goto IL_0122;
		IL_0122:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void AddModelToPlayersInfo(PlayerProfileModel model)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		PlayerProfileModel playerProfile = default(PlayerProfileModel);
		SFSObject sFSObject = GeneratePlayerSFSObject(playerProfile);
		ISFSArray iSFSArray = playersInfo;
		object obj = typeof(System.IOAsyncCallback) + 960;
		nint num = (nint)iSFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v5-8]");
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
			goto IL_00ad;
		}
		object obj4 = obj3 + 29;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_012b;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_012b;
		IL_012b:
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v4+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v123 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static CachedUserInfoModel GenerateCachedUserInfoModel(PlayerProfileModel profileModel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_0109: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (profileModel != null && obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = profileModel.<userName>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			long num = default(long);
			string text = num.ToString();
			object obj4 = obj2 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = profileModel.<isNew>k__BackingField;
			_ = profileModel.<isVerified>k__BackingField;
			_ = profileModel.<avatarDate>k__BackingField;
			_ = profileModel.<activeCardback>k__BackingField;
			object obj5 = obj2 + 32;
			obj5 = profileModel.<activeTitle>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = profileModel.<points>k__BackingField;
			bool flag = !profileModel.<isSubscribed>k__BackingField;
			object obj6 = !flag;
			object obj7 = ~obj6;
			if (obj7 == null)
			{
				object obj8 = 1 + 1;
			}
			else
			{
				object obj8 = 1;
			}
			return (CachedUserInfoModel)obj2;
		}
		return (CachedUserInfoModel)(object)new NullReferenceException();
	}

	private SFSObject GeneratePlayerSFSObject(PlayerProfileModel playerProfile)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0175: Expected O, but got I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		if (playerProfile != null && sFSObject != null)
		{
			object key = "m_StencilDeferredPS" + 2872;
			object key2 = "m_StencilDeferredPS" + 2848;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			sFSObject.PutUtfString((string)key, playerProfile.<userName>k__BackingField);
			sFSObject.PutUtfString((string)key2, playerProfile.<userName>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(Games.Baloot, playerProfile.<points>k__BackingField, playerProfile.<isNew>k__BackingField);
			if (playerRank != null)
			{
				object key3 = "placementId" + 2208;
				object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
				object key4 = "https://www.kammelna.com/Home/Terms" + 136;
				object key5 = "https://www.kammelna.com/Home/Terms" + 3000;
				object key6 = "placementId" + 1552;
				sFSObject.PutInt((string)key3, (int)playerRank.<Rank>k__BackingField);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int val = Convert.ToInt32(playerProfile.<userDbId>k__BackingField);
				sFSObject.PutInt((string)key4, val);
				sFSObject.PutBool((string)key5, playerProfile.<isNew>k__BackingField);
				sFSObject.PutInt((string)key6, playerProfile.<points>k__BackingField);
				object obj6 = (??)playerProfile.<avatarDate>k__BackingField & 1;
				if (obj6 != null)
				{
					DateTime? dateTime = default(DateTime?);
					DateTime value = dateTime.Value;
					object key7 = "___# Content push apply failed [{0}]: {1}" + 3224;
					SFSExtensions.PutDate(sFSObject, (string)key7, value);
				}
				return sFSObject;
			}
		}
		return (SFSObject)(object)new NullReferenceException();
	}

	public void RemovePlayer(int playerId)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002a: Expected O, but got I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0119: Expected O, but got I
		//IL_0156: Expected O, but got I
		//IL_005c: Expected O, but got I4
		//IL_0061: Expected I, but got O
		//IL_007b: Expected O, but got I
		//IL_0088: Expected I, but got O
		//IL_0173: Expected O, but got I
		//IL_027d: Expected O, but got I4
		//IL_0ce3: Expected I, but got O
		//IL_0cf3: Expected O, but got I
		//IL_0d00: Expected I, but got O
		//IL_01ae: Expected O, but got I
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02af: Expected O, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02f7: Expected O, but got I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I4
		//IL_0374: Expected I, but got O
		//IL_0384: Expected O, but got I
		//IL_03ad: Expected O, but got I
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_04c6: Expected O, but got I4
		//IL_056f: Expected O, but got I
		//IL_05aa: Expected O, but got I
		//IL_0d30: Expected O, but got I
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected O, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_07e0: Expected O, but got I
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected O, but got Unknown
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_06f0: Expected I, but got O
		//IL_0700: Expected O, but got I
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected O, but got Unknown
		//IL_081b: Expected O, but got I
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected O, but got Unknown
		//IL_0da5: Expected O, but got I
		//IL_073b: Expected O, but got I
		//IL_0a58: Expected I, but got O
		//IL_0a68: Expected O, but got I
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected O, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected O, but got Unknown
		//IL_09e8: Expected O, but got I4
		//IL_0a00: Expected O, but got I
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_0d64: Expected O, but got I
		//IL_0922: Expected O, but got I4
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected O, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected O, but got Unknown
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Expected O, but got Unknown
		//IL_0aa3: Expected O, but got I
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_0dd9: Expected O, but got I
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected O, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected O, but got Unknown
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected O, but got Unknown
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Expected O, but got Unknown
		//IL_0af4: Expected O, but got I
		int playerId2 = default(int);
		string text = playerId2.ToString();
		User[] array = users;
		if (users != null)
		{
			object obj = typeof(UsageHint) + 8;
			nint num2 = default(nint);
			nint num = num2;
			object obj2 = 0;
			int num3 = 0;
			object obj8 = default(object);
			bool flag4;
			OfflineRoom offlineRoom = default(OfflineRoom);
			SFSArray sFSArray = default(SFSArray);
			object obj36 = default(object);
			object obj37 = default(object);
			object obj40 = default(object);
			object obj55 = default(object);
			string text5 = default(string);
			SFSObject sFSObject3 = default(SFSObject);
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string a = default(string);
			do
			{
				object obj6;
				object obj7;
				User[] array2;
				string text2;
				if (num3 < array.Length)
				{
					object obj3 = array + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v10+20]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v10+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v10+20]");
						obj2 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v10+20]");
					if ((nint)0 == 0)
					{
						bool flag = string.Equals(null, text);
						bool flag2 = !flag;
						object obj5 = !flag2;
						num = unchecked((nint)null);
						array = users;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X10_v40-8]");
						obj6 = 0;
						obj7 = obj8;
						num2 = unchecked((nint)null);
						text2 = text;
						array2 = users;
						if (obj5 == null)
						{
							goto IL_00a8;
						}
						goto IL_0245;
					}
					object obj9 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v49+12E]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v49+12E]");
					if ((nint)0 == 0)
					{
						goto IL_01f7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v49+B0]");
					object obj11 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X10_v40-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj8 = obj11 + 16;
						obj10--;
						bool flag3 = (nint)obj10 != 1;
						obj11 = obj8;
						if (flag3)
						{
							continue;
						}
						goto IL_01f7;
					}
					object obj12 = obj11 + 1;
					object obj13 = obj9 + obj12;
					object obj14 = obj13 + 312;
					obj8 = obj11;
					goto IL_0cae;
				}
				RemoveWatcher(playerId2);
				return;
				IL_01f7:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num = 1;
				goto IL_0cae;
				IL_00a8:
				num3++;
				flag4 = array == null;
				num2 = num;
				continue;
				IL_0c19:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
				throw new OutOfMemoryException();
				IL_0245:
				if (array2 == null)
				{
					break;
				}
				bool flag5 = num3 < array2.Length;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					object obj16 = array2 + num3;
					object obj17 = obj16 + 32;
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v21+E4]");
					bool flag6 = (nint)0 == 0;
					object obj20 = !flag6;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerProfileModel playerProfileModel = PlayerProfilesHandler.AiProfileModel(num3);
					PlayerProfileModel[] playersProfiles = _playersProfiles;
					if (_playersProfiles == null)
					{
						break;
					}
					bool flag7 = playerProfileModel == null;
					string text3 = null;
					if (!flag7)
					{
						nint num4 = (nint)playersProfiles;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v48 (Il2CppClass<PlayerProfileModel[]>)+40]");
						text3 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag8 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v48 (Il2CppClass<PlayerProfileModel[]>)+40]");
						text2 = (string)0;
						if (flag8)
						{
							goto IL_0c19;
						}
					}
					bool flag9 = num3 < playersProfiles.Length;
					object obj21 = !flag9;
					text2 = text3;
					if (obj21 == null)
					{
						object obj22 = _playersProfiles + num3;
						object obj23 = obj22 + 32;
						obj23 = playerProfileModel;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						SFSObject sFSObject = offlineRoom.GeneratePlayerSFSObject(playerProfileModel);
						object obj24 = typeof(RegisteredWaitHandle) + 1888;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						sFSArray..ctor();
						object obj25 = this + 40;
						object obj26 = obj25;
						if (obj25 == null)
						{
							break;
						}
						object obj27 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
						object obj28 = typeof(System.IOAsyncCallback) + 960;
						string text4 = text5;
						object obj29 = 0;
						nint num5 = num2;
						bool flag12;
						do
						{
							object obj30 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v21+12E]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v21+12E]");
							if ((nint)0 == 0)
							{
								goto IL_05f3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v21+B0]");
							object obj32 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X10_v34-8]");
								obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X10_v34-8]");
								if (0 == (nint)obj27)
								{
									break;
								}
								obj7 = obj32 + 16;
								obj31--;
								bool flag10 = (nint)obj31 != 1;
								obj32 = obj7;
								if (flag10)
								{
									continue;
								}
								goto IL_05f3;
							}
							object obj33 = obj32 + 1;
							object obj34 = obj30 + obj33;
							object obj35 = obj34 + 312;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v730 @ X0_v71] (should have been resolved before IL gen)");
							bool flag11 = obj29 >= obj36;
							obj7 = obj32;
							nint num6 = num5;
							if (!flag11)
							{
								goto IL_069c;
							}
							goto IL_0b3e;
							IL_0784:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
							goto IL_0d88;
							IL_0d88:
							SFSObject sFSObject2 = sFSObject;
							goto IL_04f2;
							IL_04f2:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X0_v64+8]");
							num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v962 @ X0_v64] (should have been resolved before IL gen)");
							obj29++;
							obj26 = obj25;
							flag12 = obj25 == null;
							text5 = text4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X0_v64+8]");
							num2 = 0;
							continue;
							IL_05f3:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v689 @ X0_v68] (should have been resolved before IL gen)");
							bool flag13 = obj29 < obj37;
							num5 = 1;
							if (flag13)
							{
								goto IL_069c;
							}
							num6 = 1;
							goto IL_0b3e;
							IL_0a1e:
							bool flag14 = sFSArray == null;
							sFSObject2 = null;
							text5 = text4;
							nint num7;
							num2 = num7;
							if (flag14)
							{
								break;
							}
							goto IL_0a50;
							IL_0b3e:
							playersInfo = sFSArray;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj38 = typeof(MemberAchievementClanFeedData) + 3248;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj39 = "not" + 4000;
							obj40..ctor();
							object obj41 = obj40 + 24;
							obj41 = obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 6;
							object obj42 = obj40 + 32;
							obj42 = playersInfo;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							SetVariable((RoomVariable)obj40);
							return;
							IL_069c:
							object obj47;
							if ((nint)obj29 == num3)
							{
								bool flag15 = sFSArray == null;
								text5 = text4;
								num2 = num5;
								if (flag15)
								{
									break;
								}
								nint num8 = (nint)sFSArray;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
								object obj43 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_0784;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
								object obj44 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X10_v28-8]");
									obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X10_v28-8]");
									if (0 == (nint)obj28)
									{
										break;
									}
									obj7 = obj44 + 16;
									obj43--;
									bool flag16 = (nint)obj43 != 1;
									obj44 = obj7;
									if (flag16)
									{
										continue;
									}
									goto IL_0784;
								}
								object obj45 = obj44 + 29;
								object obj46 = num8 + obj45;
								obj47 = obj46 + 312;
								obj7 = obj44;
								goto IL_0d88;
							}
							object obj48 = obj25;
							bool flag17 = obj25 == null;
							text5 = text4;
							num2 = num5;
							if (flag17)
							{
								break;
							}
							object obj49 = obj48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v29+12E]");
							object obj50 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v29+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0864;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v29+B0]");
							object obj51 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X10_v16-8]");
								obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X10_v16-8]");
								if (0 == (nint)obj28)
								{
									break;
								}
								obj7 = obj51 + 16;
								obj50--;
								bool flag18 = (nint)obj50 != 1;
								obj51 = obj7;
								if (flag18)
								{
									continue;
								}
								goto IL_0864;
							}
							object obj52 = obj51 + 1;
							object obj53 = obj49 + obj52;
							object obj54 = obj53 + 312;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v57+8]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v915 @ X0_v57] (should have been resolved before IL gen)");
							bool flag19 = obj55 == null;
							object obj56 = !flag19;
							obj7 = obj51;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X10_v16-8]");
							object obj57 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v57+8]");
							num7 = 0;
							if (obj56 != null)
							{
								goto IL_08c5;
							}
							goto IL_0a1e;
							IL_0a50:
							nint num9 = (nint)sFSArray;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X8_v31 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
							object obj58 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X8_v31 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_04d3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X8_v31 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
							obj7 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v30-8]");
								obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v30-8]");
								if (0 == (nint)obj28)
								{
									break;
								}
								obj7 += 16;
								obj58--;
								if ((nint)obj58 != 1)
								{
									continue;
								}
								goto IL_0ae4;
							}
							object obj59 = obj7 + 29;
							object obj60 = num9 + obj59;
							obj47 = obj60 + 312;
							goto IL_04f2;
							IL_04d3:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
							obj6 = obj57;
							obj7 = obj51;
							goto IL_04f2;
							IL_0864:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v54+8]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v833 @ X0_v54] (should have been resolved before IL gen)");
							bool flag20 = obj55 == null;
							obj57 = obj6;
							obj51 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v54+8]");
							num7 = 0;
							if (!flag20)
							{
								goto IL_08c5;
							}
							goto IL_0a1e;
							IL_08c5:
							object obj61 = typeof(System.IOAsyncCallback) + 976;
							text5 = (string)obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							if (sFSObject3 != null)
							{
								bool flag21 = sFSArray == null;
								object obj62 = !flag21;
								obj57 = obj6;
								text4 = (string)obj61;
								sFSObject2 = sFSObject3;
								obj51 = obj7;
								if (obj62 == null)
								{
									break;
								}
								goto IL_0a50;
							}
							goto IL_0bf5;
							IL_0ae4:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v30-8]");
							obj57 = 0;
							obj51 = obj7;
							goto IL_04d3;
						}
						while (!flag12);
						break;
					}
				}
				goto IL_0c0b;
				IL_0bf5:
				InvalidCastException ex2 = new InvalidCastException();
				text2 = text5;
				goto IL_0c0b;
				IL_0c0b:
				ex = new IndexOutOfRangeException();
				goto IL_0c19;
				IL_0cae:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v606 @ X0_v77] (should have been resolved before IL gen)");
				bool flag22 = string.Equals(a, text);
				array = users;
				bool flag23 = !flag22;
				num = unchecked((nint)null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X10_v40-8]");
				obj6 = 0;
				obj7 = obj8;
				num2 = unchecked((nint)null);
				text2 = text;
				array2 = users;
				if (flag23)
				{
					goto IL_00a8;
				}
				goto IL_0245;
			}
			while (!flag4);
		}
		throw new NullReferenceException();
	}

	public unsafe void AddPlayer(int playerIndex, int dbId, string name, int rankPoints, bool rankIsNew, bool subscribed, bool verified, int activeCardsBack)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		//IL_00b4: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_0164: Expected I, but got O
		//IL_0174: Expected O, but got I
		//IL_01b1: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_0376: Expected O, but got I
		//IL_0414: Expected O, but got I
		//IL_0435: Expected O, but got I4
		//IL_03b1: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_0c67: Expected O, but got I
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_048a: Expected O, but got I
		//IL_07d1: Expected O, but got I
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected O, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_086f: Expected O, but got I
		//IL_08a8: Expected O, but got I
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Expected O, but got Unknown
		//IL_080c: Expected O, but got I
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected O, but got Unknown
		//IL_0ccf: Expected O, but got I
		//IL_0602: Expected O, but got I4
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_0a2b: Expected I, but got O
		//IL_0a3b: Expected O, but got I
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected O, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected O, but got Unknown
		//IL_0997: Expected O, but got I
		//IL_09bb: Expected O, but got I4
		//IL_09d3: Expected O, but got I
		//IL_09e3: Expected O, but got I
		//IL_058d: Expected I, but got O
		//IL_059d: Expected O, but got I
		//IL_05d6: Expected O, but got I
		//IL_0913: Expected O, but got I4
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0348: Expected O, but got I
		//IL_0a76: Expected O, but got I
		//IL_0d03: Expected O, but got I
		//IL_06c9: Expected I, but got O
		//IL_06d9: Expected O, but got I
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected O, but got Unknown
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Expected O, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected O, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0714: Expected O, but got I
		//IL_0c9b: Expected O, but got I
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected O, but got Unknown
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected O, but got Unknown
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected O, but got Unknown
		//IL_0b23: Expected O, but got I
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(Games.Baloot, rankPoints, rankIsNew);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(dbId, name, playerRank);
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerProfileModel playerProfileModel = default(PlayerProfileModel);
		playerProfileModel..ctor(playerInfo);
		bool flag = playerProfileModel == null;
		object obj6 = 0;
		PlayerInfo playerInfo2 = playerInfo;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj7 = (nint)0 + (nint)2264;
			playerProfileModel.<isSubscribed>k__BackingField = subscribed;
			playerProfileModel.<isVerified>k__BackingField = verified;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
			playerProfileModel.<activeCardback>k__BackingField = 0;
			obj6 = obj7;
			DateTime? dateTime = (playerProfileModel.<avatarDate>k__BackingField = (DateTime)0);
			if (playerIndex <= 0)
			{
				AddWatcher(playerProfileModel);
				return;
			}
			PlayerProfileModel[] playersProfiles = _playersProfiles;
			bool flag2 = _playersProfiles == null;
			DateTime? dateTime2 = dateTime;
			playerInfo2 = null;
			if (!flag2)
			{
				nint num = (nint)playersProfiles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v12 (Il2CppClass<PlayerProfileModel[]>)+40]");
				playerInfo2 = (PlayerInfo)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				dateTime2 = dateTime;
				if (flag3)
				{
					goto IL_0c0c;
				}
				object obj8 = playerIndex - 1;
				bool flag4 = (nint)obj8 < playersProfiles.Length;
				object obj9 = !flag4;
				dateTime2 = dateTime;
				if (obj9 != null)
				{
					goto IL_0bfe;
				}
				object obj10 = typeof(RegisteredWaitHandle) + 1888;
				object obj11 = (object)_playersProfiles + obj8;
				object obj12 = obj11 + 32;
				obj12 = playerProfileModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				OfflineRoom offlineRoom = default(OfflineRoom);
				SFSObject sFSObject = offlineRoom.GeneratePlayerSFSObject(playerProfileModel);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				SFSArray sFSArray = default(SFSArray);
				sFSArray..ctor();
				object obj13 = this + 40;
				object obj14 = obj13;
				bool flag5 = obj13 == null;
				dateTime2 = dateTime;
				playerInfo2 = null;
				if (!flag5)
				{
					object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
					object obj16 = typeof(System.IOAsyncCallback) + 960;
					object obj17 = obj7;
					PlayerRank playerRank2 = playerRank;
					PlayerInfo playerInfo3 = null;
					object obj21 = default(object);
					object obj22 = default(object);
					object obj26 = default(object);
					SFSObject sFSObject2 = default(SFSObject);
					PlayerRank playerRank3 = default(PlayerRank);
					bool flag9;
					object obj33 = default(object);
					object obj36 = default(object);
					OfflineUser offlineUser = default(OfflineUser);
					do
					{
						object obj18 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v15+12E]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v15+12E]");
						if ((nint)0 == 0)
						{
							goto IL_03fa;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v15+B0]");
						object obj20 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v31-8]");
							obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v31-8]");
							if (0 == (nint)obj15)
							{
								break;
							}
							obj22 = obj20 + 16;
							obj19--;
							bool flag6 = (nint)obj19 != 1;
							obj20 = obj22;
							if (flag6)
							{
								continue;
							}
							goto IL_03fa;
						}
						object obj23 = obj20 + 1;
						object obj24 = obj18 + obj23;
						object obj25 = obj24 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v77+8]");
						playerInfo2 = (PlayerInfo)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v617 @ X0_v77] (should have been resolved before IL gen)");
						bool flag7 = playerInfo3 >= obj26;
						obj22 = obj20;
						object obj27 = obj17;
						if (!flag7)
						{
							goto IL_04c3;
						}
						goto IL_0b30;
						IL_08be:
						object obj28 = typeof(System.IOAsyncCallback) + 976;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						object obj30;
						object obj31;
						SFSObject sFSObject3;
						object obj32;
						if (sFSObject2 != null)
						{
							bool flag8 = sFSArray == null;
							object obj29 = !flag8;
							obj30 = obj21;
							obj31 = obj22;
							playerRank2 = playerRank3;
							sFSObject3 = sFSObject2;
							if (obj29 == null)
							{
								dateTime2 = dateTime;
								obj6 = obj32;
								playerInfo2 = (PlayerInfo)obj28;
								break;
							}
							goto IL_0a23;
						}
						throw new InvalidCastException();
						IL_02d2:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						goto IL_02e1;
						IL_02e1:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v70+8]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v857 @ X0_v70] (should have been resolved before IL gen)");
						playerInfo3 = (PlayerInfo)(playerInfo3 + 1);
						obj14 = obj13;
						flag9 = obj13 == null;
						obj21 = obj30;
						obj22 = obj31;
						dateTime2 = dateTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v70+8]");
						obj6 = 0;
						playerInfo2 = (PlayerInfo)(object)sFSObject3;
						continue;
						IL_03fa:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v74+8]");
						playerInfo2 = (PlayerInfo)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v576 @ X0_v74] (should have been resolved before IL gen)");
						bool flag10 = playerInfo3 < obj33;
						obj17 = 1;
						if (flag10)
						{
							goto IL_04c3;
						}
						obj27 = 1;
						goto IL_0b30;
						IL_09f9:
						bool flag11 = sFSArray == null;
						sFSObject3 = null;
						dateTime2 = dateTime;
						if (flag11)
						{
							break;
						}
						goto IL_0a23;
						IL_0b30:
						playersInfo = sFSArray;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj34 = typeof(MemberAchievementClanFeedData) + 3248;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj35 = "not" + 4000;
						obj36..ctor();
						object obj37 = obj36 + 24;
						obj37 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 6;
						object obj38 = obj36 + 32;
						obj38 = playersInfo;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						SetVariable((RoomVariable)obj36);
						return;
						IL_04c3:
						object obj49;
						if (playerInfo3 == obj8)
						{
							playerRank2 = (PlayerRank)(object)users;
							CachedUserInfoModel cachedUserInfoModel = GenerateCachedUserInfoModel(playerProfileModel);
							object obj39 = typeof(MemberAchievementClanFeedData) + 3264;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							offlineUser..ctor(cachedUserInfoModel);
							bool flag12 = users == null;
							dateTime2 = dateTime;
							obj6 = obj17;
							playerInfo2 = (PlayerInfo)(object)cachedUserInfoModel;
							if (flag12)
							{
								break;
							}
							bool flag13 = offlineUser == null;
							PlayerInfo playerInfo4 = (PlayerInfo)(object)cachedUserInfoModel;
							if (!flag13)
							{
								nint num2 = (nint)playerRank2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v41 (Il2CppClass<PlayerRank>)+40]");
								playerInfo4 = (PlayerInfo)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag14 = ex == null;
								dateTime2 = dateTime;
								obj6 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v41 (Il2CppClass<PlayerRank>)+40]");
								playerInfo2 = (PlayerInfo)0;
								if (flag14)
								{
									goto IL_0c0c;
								}
							}
							bool flag15 = playerRank2.<Points>k__BackingField < (nint)obj8;
							object obj40 = !flag15;
							object obj41 = playerRank2.<Points>k__BackingField - obj8;
							bool flag16 = obj41 == null;
							object obj42 = ~obj40;
							object obj43 = obj42 | flag16;
							dateTime2 = dateTime;
							obj6 = obj17;
							playerInfo2 = playerInfo4;
							if (obj43 == null)
							{
								object obj44 = (object)playerRank2 + obj8;
								object obj45 = obj44 + 32;
								obj45 = offlineUser;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								bool flag17 = sFSArray == null;
								dateTime2 = dateTime;
								obj6 = obj17;
								playerInfo2 = (PlayerInfo)(object)offlineUser;
								if (flag17)
								{
									break;
								}
								nint num3 = (nint)sFSArray;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
								object obj46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
									obj31 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v27-8]");
										obj21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v27-8]");
										if (0 == (nint)obj16)
										{
											break;
										}
										obj22 = obj31 + 16;
										obj46--;
										bool flag18 = (nint)obj46 != 1;
										obj31 = obj22;
										if (flag18)
										{
											continue;
										}
										goto IL_075d;
									}
									object obj47 = obj31 + 29;
									object obj48 = num3 + obj47;
									obj49 = obj48 + 312;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v27-8]");
									obj30 = 0;
									sFSObject3 = sFSObject;
									goto IL_02e1;
								}
								goto IL_075d;
							}
							goto IL_0bfe;
						}
						object obj50 = obj13;
						bool flag19 = obj13 == null;
						dateTime2 = dateTime;
						obj6 = obj17;
						if (flag19)
						{
							break;
						}
						object obj51 = obj50;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v23+12E]");
						object obj52 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v23+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0855;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v23+B0]");
						obj31 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v27-8]");
							obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v27-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj22 = obj31 + 16;
							obj52--;
							bool flag20 = (nint)obj52 != 1;
							obj31 = obj22;
							if (flag20)
							{
								continue;
							}
							goto IL_0855;
						}
						object obj53 = obj31 + 1;
						object obj54 = obj51 + obj53;
						object obj55 = obj54 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v54+8]");
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v733 @ X0_v54] (should have been resolved before IL gen)");
						bool flag21 = playerRank3 == null;
						object obj56 = !flag21;
						obj22 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v27-8]");
						obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v54+8]");
						obj6 = 0;
						playerInfo2 = playerInfo3;
						if (obj56 != null)
						{
							goto IL_08be;
						}
						goto IL_09f9;
						IL_0855:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v51+8]");
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v692 @ X0_v51] (should have been resolved before IL gen)");
						bool flag22 = playerRank3 == null;
						obj30 = obj21;
						obj31 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v51+8]");
						obj6 = 0;
						playerInfo2 = playerInfo3;
						if (!flag22)
						{
							goto IL_08be;
						}
						goto IL_09f9;
						IL_075d:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						obj30 = obj21;
						obj31 = obj22;
						sFSObject3 = sFSObject;
						goto IL_02e1;
						IL_0a23:
						nint num4 = (nint)sFSArray;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
						object obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02d2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
						obj31 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v27-8]");
							obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v27-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj31 += 16;
							obj57--;
							if ((nint)obj57 != 1)
							{
								continue;
							}
							goto IL_02d2;
						}
						object obj58 = obj31 + 29;
						object obj59 = num4 + obj58;
						obj49 = obj59 + 312;
						goto IL_02e1;
					}
					while (!flag9);
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0bfe;
		IL_0bfe:
		ex = new IndexOutOfRangeException();
		goto IL_0c0c;
		IL_0c0c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void AddWatcher(PlayerProfileModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_017f: Expected O, but got I
		//IL_01c6: Expected O, but got I4
		//IL_03aa: Expected O, but got I
		//IL_03c9: Expected O, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_012c: Expected O, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0274: Expected I, but got O
		//IL_0284: Expected O, but got I
		//IL_03fe: Expected O, but got I
		//IL_0432: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3264;
		CachedUserInfoModel userModel = GenerateCachedUserInfoModel(model);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineUser offlineUser = default(OfflineUser);
		offlineUser..ctor(userModel);
		List<object> list = (List<object>)(object)<SpectatorList>k__BackingField;
		object obj2 = (nint)0 + (nint)2824;
		object obj3 = obj2;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object obj4 = typeof(RegisteredWaitHandle) + 2008;
		bool flag = list._size < items.Length;
		object obj5 = !flag;
		nint num;
		OfflineUser offlineUser3;
		object obj8;
		nint num2 = default(nint);
		OfflineUser offlineUser2;
		if (obj5 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj6 = items + list._size;
			object obj7 = obj6 + 32;
			obj7 = offlineUser;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			offlineUser2 = offlineUser;
			if (obj9 == null)
			{
				num = num2;
				offlineUser3 = offlineUser;
				object obj10 = obj8;
				goto IL_01fc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v18+C0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19+70]");
			num = 0;
			list.AddWithResize((object)offlineUser);
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v22+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			offlineUser3 = offlineUser;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19+70]");
			num2 = 0;
			offlineUser2 = offlineUser;
			obj8 = obj10;
			if (obj13 == null)
			{
				goto IL_01fc;
			}
		}
		goto IL_039a;
		IL_0300:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj15 = default(object);
		object obj14 = obj15;
		goto IL_03f2;
		IL_039a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v9+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v8+98]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		IDictionary<string, object> dictionary = sFSEvent.Params;
		object obj17 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj18 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3904;
		object obj19 = typeof(Queue<string>) + 824;
		nint num3 = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0300;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v7-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_0300;
		}
		object obj22 = obj21 + 5;
		object obj23 = num3 + obj22;
		obj14 = obj23 + 312;
		goto IL_03f2;
		IL_03f2:
		object obj24 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ X8_v12] (should have been resolved before IL gen)");
		object obj25 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.Offline_SFS_OnUserJoinRoom(sFSEvent);
		return;
		IL_01fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj4;
		num2 = num;
		offlineUser2 = offlineUser3;
		goto IL_039a;
	}

	public void ClearWatchers()
	{
		List<User> list = <SpectatorList>k__BackingField;
		int num = list._size;
		if (list._size >= 1)
		{
			do
			{
				num--;
				object user = ((List<object>)(object)<SpectatorList>k__BackingField).get_Item(num);
				RemoveWatcher((User)user);
			}
			while (num > 0);
		}
	}

	private void RemoveWatcher(int playerId)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00d0: Expected I, but got O
		//IL_00e0: Expected O, but got I
		//IL_0077: Expected O, but got I4
		//IL_011b: Expected O, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		int num = default(int);
		string b = num.ToString();
		List<User> list = <SpectatorList>k__BackingField;
		object obj = (nint)0 + (nint)2856;
		object obj2 = typeof(UsageHint) + 8;
		int num2 = list._size;
		string a = default(string);
		string a2 = default(string);
		while (true)
		{
			num2--;
			if (num2 < 1)
			{
				break;
			}
			object obj3 = ((List<object>)(object)<SpectatorList>k__BackingField).get_Item(num2);
			nint num3 = (nint)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v7 (Il2CppClass<System.Object>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v7 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0037;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v7 (Il2CppClass<System.Object>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v9-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_0037;
			}
			object obj6 = obj5 + 1;
			object obj7 = num3 + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v184 @ X8_v10] (should have been resolved before IL gen)");
			if (!string.Equals(a, b))
			{
				continue;
			}
			goto IL_01be;
			IL_0037:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v16] (should have been resolved before IL gen)");
			bool flag = string.Equals(a2, b);
			bool flag2 = !flag;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				continue;
			}
			goto IL_01be;
			IL_01be:
			object user = ((List<object>)(object)<SpectatorList>k__BackingField).get_Item(num2);
			RemoveWatcher((User)user);
			break;
		}
	}

	private void RemoveWatcher(User user)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_01f9: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00ec: Expected I, but got O
		//IL_00fc: Expected O, but got I
		//IL_024d: Expected O, but got I
		//IL_0281: Expected O, but got I4
		//IL_0137: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2840;
		object obj2 = typeof(RegisteredWaitHandle) + 2008;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2192;
		bool flag = ((List<object>)(object)<SpectatorList>k__BackingField).Remove((object)user);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v7+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+A0]");
		BaseEvent baseEvent = default(BaseEvent);
		baseEvent..ctor((string)0);
		IDictionary<string, object> dictionary = baseEvent.Params;
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj8 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3904;
		object obj9 = typeof(Queue<string>) + 824;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0178;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X10_v6-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0178;
		}
		object obj12 = obj11 + 5;
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		goto IL_0241;
		IL_0241:
		object obj15 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ X8_v11] (should have been resolved before IL gen)");
		object obj16 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.Offline_SFS_OnUserLeaveRoom(baseEvent);
		return;
		IL_0178:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj18 = default(object);
		obj14 = obj18;
		goto IL_0241;
	}

	public void ProcessEvent(string command, ISFSObject param)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		IRoomExtension roomExtension = RoomExtension;
		object obj = typeof(System.IOAsyncCallback) + 928;
		nint num = (nint)roomExtension;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<KammelnaOffline.OfflineServer.IRoomExtension>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<KammelnaOffline.OfflineServer.IRoomExtension>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<KammelnaOffline.OfflineServer.IRoomExtension>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v5-8]");
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
			goto IL_00ad;
		}
		object obj4 = obj3 + 2;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_011d;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_011d;
		IL_011d:
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v3+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void UpdateScore(int team1Score, int team2Score)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0641: Expected O, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_0669: Expected O, but got I
		//IL_0688: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_018b: Expected O, but got I
		//IL_01c2: Expected O, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0240: Expected I, but got O
		//IL_0250: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_0315: Expected O, but got I
		//IL_036f: Expected O, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I
		//IL_03fc: Expected O, but got I
		//IL_040c: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_0480: Expected O, but got I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_0524: Expected I, but got O
		//IL_0534: Expected O, but got I
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_071d: Expected O, but got I
		//IL_0751: Expected O, but got I4
		//IL_056f: Expected O, but got I
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3248;
		object obj2 = "startPosition" + 2144;
		object obj3 = typeof(RegisteredWaitHandle) + 2008;
		object cmd = "utf-32" + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj5 = default(object);
		obj5..ctor();
		object obj6 = obj5 + 24;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj7 = obj5 + 32;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = "startPosition" + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj10 = default(object);
		obj10..ctor();
		object obj11 = obj10 + 24;
		obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 2;
		object obj12 = obj10 + 32;
		object obj13 = default(object);
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetVariable((RoomVariable)obj10);
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v27+E4]");
		bool flag = (nint)0 == 0;
		object obj15 = !flag;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v27+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v6+E0]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		SFSExtensions.PutCommand(sFSEvent, (string)cmd);
		object obj17 = typeof(Queue<string>) + 848;
		object obj18 = (nint)0 + (nint)2200;
		IDictionary<string, object> dictionary = sFSEvent.Params;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v34+E4]");
		bool flag2 = (nint)0 == 0;
		object obj20 = !flag2;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		object obj21 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj22 = "rightCtrl" + 280;
		object obj23 = typeof(List<AdaptivePerformanceScaler>) + 3624;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02cc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X10_v14-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_02cc;
		}
		object obj26 = obj25 + 1;
		object obj27 = num + obj26;
		object obj28 = obj27 + 312;
		goto IL_06be;
		IL_06be:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v418 @ X0_v39] (should have been resolved before IL gen)");
		IDictionary<string, object> dictionary2 = sFSEvent.Params;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj29 = (nint)0 + (nint)3072;
		object obj30 = obj29;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag3 = list._size < items.Length;
		object obj31 = !flag3;
		if (obj31 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj32 = items + list._size;
			object obj33 = obj32 + 32;
			obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Room room = currentRoom;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v14+20]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v30+C0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v31+70]");
			Room room = (Room)0;
			list.AddWithResize(obj2);
		}
		object obj36 = "startPosition" + 2160;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag4 = list._size < items2.Length;
		object obj37 = !flag4;
		if (obj37 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj38 = items2 + list._size;
			object obj39 = obj38 + 32;
			obj39 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize(obj36);
		}
		object obj40 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2848;
		object obj41 = typeof(Queue<string>) + 824;
		nint num2 = (nint)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj43 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X10_v9-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj43 += 16;
			obj42--;
			if ((nint)obj42 != 1)
			{
				continue;
			}
			goto IL_05b0;
		}
		object obj44 = obj43 + 1;
		object obj45 = num2 + obj44;
		object obj46 = obj45 + 312;
		goto IL_0711;
		IL_02cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06be;
		IL_0711:
		object obj47 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v516 @ X0_v48] (should have been resolved before IL gen)");
		object obj48 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v51+E4]");
		bool flag5 = (nint)0 == 0;
		object obj49 = !flag5;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.SFS_OnRoomVariableUpdate(sFSEvent);
		return;
		IL_05b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0711;
	}

	public void AddUser(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public bool ContainsUser(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005f: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
	}

	public bool ContainsVariable(string name)
	{
		//IL_002c: Expected I4, but got O
		if (_variables != null)
		{
			return ((Dictionary<object, object>)(object)_variables).ContainsKey((object)name);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public User GetUserById(int id)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
			object obj4 = (nint)0 + (nint)4064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (User)Enumerable.FirstOrDefault(users, func);
		}
		return (User)new NullReferenceException();
	}

	public User GetSpectatorById(int id)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
			object obj4 = (nint)0 + (nint)4072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (User)Enumerable.FirstOrDefault(<SpectatorList>k__BackingField, func);
		}
		return (User)new NullReferenceException();
	}

	public User GetUserByName(string name)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
			object obj4 = (nint)0 + (nint)4080;
			object obj5 = obj2 + 16;
			obj5 = name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (User)Enumerable.FirstOrDefault(users, func);
		}
		return (User)new NullReferenceException();
	}

	public User GetSpectatorByName(string idName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
			object obj4 = (nint)0 + (nint)4088;
			object obj5 = obj2 + 16;
			obj5 = idName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (User)Enumerable.FirstOrDefault(<SpectatorList>k__BackingField, func);
		}
		return (User)new NullReferenceException();
	}

	public RoomVariable GetVariable(string name)
	{
		//IL_0037: Expected O, but got I4
		if (_variables != null)
		{
			object value;
			bool flag = ((Dictionary<object, object>)(object)_variables).TryGetValue((object)name, out value);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return (RoomVariable)value;
			}
			return null;
		}
		return (RoomVariable)new NullReferenceException();
	}

	public List<RoomVariable> GetVariables()
	{
		if (_variables != null)
		{
			Dictionary<object, object>.ValueCollection values = ((Dictionary<object, object>)(object)_variables).Values;
			return (List<RoomVariable>)(object)Enumerable.ToList(values);
		}
		return (List<RoomVariable>)(object)new NullReferenceException();
	}

	public void Merge(Room anotherRoom)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void RemoveUser(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public void SetVariable(RoomVariable variable)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 664;
		nint num = (nint)variable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.RoomVariable>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.RoomVariable>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.RoomVariable>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v6-8]");
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
			goto IL_00ad;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ X0_v10] (should have been resolved before IL gen)");
		bool flag = _variables == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c6;
		IL_00c6:
		object key = default(object);
		((Dictionary<object, object>)(object)_variables).set_Item(key, (object)variable);
		return;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ X0_v7] (should have been resolved before IL gen)");
		goto IL_00c6;
	}

	public void SetVariables(ICollection<RoomVariable> roomVariables)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
