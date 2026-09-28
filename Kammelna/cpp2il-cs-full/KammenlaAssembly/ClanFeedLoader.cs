using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Features.Clans;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class ClanFeedLoader : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanFeedModel, DateTime> <>9__17_0;

		public static Func<ClanFeedModel, long> <>9__17_1;

		public static Func<ClanFeedModel, bool> <>9__19_0;

		public static Func<ClanFeedModel, DateTime> <>9__19_1;

		public static Func<ClanFeedModel, long> <>9__19_2;

		public static Predicate<ClanFeedEventDataHolder> <>9__20_0;

		public static Func<Room, bool> <>9__23_0;

		public static Func<Room, int> <>9__23_1;

		public static Func<Room, int> <>9__24_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <LoadFeed>b__17_0(ClanFeedModel e)
		{
			return (DateTime)(((object?)e?.DateCreated) ?? ((object)new NullReferenceException()));
		}

		internal long <LoadFeed>b__17_1(ClanFeedModel e)
		{
			//IL_0035: Expected I8, but got O
			if (e != null)
			{
				return e.Id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal bool <SyncUpgradeCallToAction>b__19_0(ClanFeedModel e)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (e != null)
			{
				object obj = e.Type - 10;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal DateTime <SyncUpgradeCallToAction>b__19_1(ClanFeedModel e)
		{
			return (DateTime)(((object?)e?.DateCreated) ?? ((object)new NullReferenceException()));
		}

		internal long <SyncUpgradeCallToAction>b__19_2(ClanFeedModel e)
		{
			//IL_0035: Expected I8, but got O
			if (e != null)
			{
				return e.Id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal bool <InsertCallToActionBelow>b__20_0(ClanFeedEventDataHolder d)
		{
			//IL_0068: Expected I4, but got O
			//IL_002b: Expected I4, but got O
			//IL_005a: Expected I4, but got O
			if (d != null)
			{
				if ((int)(~d.<Model>k__BackingField) == 0)
				{
					return d.<Model>k__BackingField.IsSynthetic;
				}
				return (byte)(int)d.<Model>k__BackingField != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SyncTournamentCards>b__23_0(Room room)
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
			if (room != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v5-8]");
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
				object obj4 = obj3 + 3;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0139;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0139:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X0_v3] (should have been resolved before IL gen)");
			string clanTag = ClanTag;
			string text = default(string);
			return text == clanTag;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0139;
		}

		internal int <SyncTournamentCards>b__23_1(Room room)
		{
			//IL_0124: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (room != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
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
				goto IL_00d9;
			}
			goto IL_0116;
			IL_0116:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}

		internal int <SyncClanGameCards>b__24_0(Room r)
		{
			//IL_0124: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (r != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				num = (nint)r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
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
				goto IL_00d9;
			}
			goto IL_0116;
			IL_0116:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public ClanFeedLoader <>4__this;

		public int loadedClanId;

		public ClanUpgradedClanFeedData upgrade;

		public ClanFeedModel latestUpgrade;

		internal void <SyncUpgradeCallToAction>b__3(ClanModel clan)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f2: Expected O, but got I4
			//IL_014b: Expected O, but got I4
			//IL_0208: Expected I8, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E879B]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				goto IL_015a;
			}
			return;
			IL_015a:
			ClanFeedLoader clanFeedLoader = <>4__this;
			if (clanFeedLoader._loadedClanId != loadedClanId)
			{
				return;
			}
			if (clan != null)
			{
				ClanUpgradedClanFeedData clanUpgradedClanFeedData = upgrade;
				if (clan.PurchasedEmblemTier < clanUpgradedClanFeedData.<NewTier>k__BackingField)
				{
					clanFeedLoader.InsertCallToActionBelow(latestUpgrade);
					return;
				}
			}
			clanFeedLoader.listView.RemoveFeedById(-1L);
			return;
			IL_0091:
			if (obj5 == null)
			{
				return;
			}
			goto IL_015a;
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public List<int> liveIds;

		public Func<ClanFeedEventDataHolder, bool> <>9__2;

		internal bool <SyncTournamentCards>b__2(ClanFeedEventDataHolder d)
		{
			//IL_01b9: Expected I4, but got O
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_0076: Expected I, but got O
			//IL_0086: Expected O, but got I
			//IL_00c1: Expected O, but got I
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected O, but got Unknown
			//IL_019d: Expected O, but got I4
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			bool flag;
			if (d != null)
			{
				flag = d.IsLiveTournament;
				if (!flag)
				{
					goto IL_01d6;
				}
				Room <TournamentRoom>k__BackingField = d.<TournamentRoom>k__BackingField;
				if (d.<TournamentRoom>k__BackingField != null)
				{
					object obj = typeof(RegisteredWaitHandle) + 1376;
					nint num = (nint)<TournamentRoom>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0102;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v7-8]");
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
						goto IL_0102;
					}
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ X0_v15] (should have been resolved before IL gen)");
					bool flag2 = liveIds == null;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						goto IL_0135;
					}
				}
			}
			goto IL_01ab;
			IL_01ab:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0135:
			int item = default(int);
			bool flag3 = liveIds.Contains(item);
			flag = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
			goto IL_01d6;
			IL_01d6:
			return flag;
			IL_0102:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ X0_v12] (should have been resolved before IL gen)");
			if (liveIds != null)
			{
				goto IL_0135;
			}
			goto IL_01ab;
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public List<int> liveIds;

		public Func<ClanFeedEventDataHolder, bool> <>9__1;

		internal bool <SyncClanGameCards>b__1(ClanFeedEventDataHolder d)
		{
			//IL_01b9: Expected I4, but got O
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_0076: Expected I, but got O
			//IL_0086: Expected O, but got I
			//IL_00c1: Expected O, but got I
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected O, but got Unknown
			//IL_019d: Expected O, but got I4
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			bool flag;
			if (d != null)
			{
				flag = d.IsLiveGame;
				if (!flag)
				{
					goto IL_01d6;
				}
				Room <GameRoom>k__BackingField = d.<GameRoom>k__BackingField;
				if (d.<GameRoom>k__BackingField != null)
				{
					object obj = typeof(RegisteredWaitHandle) + 1376;
					nint num = (nint)<GameRoom>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0102;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v7-8]");
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
						goto IL_0102;
					}
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ X0_v15] (should have been resolved before IL gen)");
					bool flag2 = liveIds == null;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						goto IL_0135;
					}
				}
			}
			goto IL_01ab;
			IL_01ab:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0135:
			int item = default(int);
			bool flag3 = liveIds.Contains(item);
			flag = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
			goto IL_01d6;
			IL_01d6:
			return flag;
			IL_0102:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ X0_v12] (should have been resolved before IL gen)");
			if (liveIds != null)
			{
				goto IL_0135;
			}
			goto IL_01ab;
		}
	}

	public const int PageSize = 50;

	private Action m_OnReloadRequested;

	private Action<long> m_OnLoadOlderRequested;

	private ClanFeedListView listView;

	private int _index;

	private int _loadedClanId = -1;

	private const long UpgradeCallToActionId = -1L;

	private static bool HasClan
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017c: Expected I4, but got O
			//IL_01b4: Expected O, but got I4
			//IL_025a: Expected I4, but got O
			//IL_0225: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8789]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_024c;
			IL_024c:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0158:
			User localUser = sessionModel.LocalUser;
			bool flag4 = localUser == null;
			bool result = (byte)(int)localUser != 0;
			if (!flag4)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 == null)
				{
					goto IL_024c;
				}
				User localUser2 = sessionModel2.LocalUser;
				int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
				object obj10 = clanId + 1;
				bool flag6 = obj10 == null;
				bool flag7 = !flag6;
				result = flag7;
			}
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag8 = (object)sessionModel == null;
			object obj11 = !flag8;
			if (obj11 != null)
			{
				goto IL_0158;
			}
			goto IL_024c;
		}
	}

	private static string ClanTag
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00fb: Expected O, but got I
			//IL_0125: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_016e: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E878A]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_017c;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
			return ClanUtils.GetClanChatTag(clanId);
			IL_017c:
			return (string)(object)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_017c;
		}
	}

	public event Action OnReloadRequested
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

	public event Action<long> OnLoadOlderRequested
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
			object obj2 = this + 40;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
			object obj2 = this + 40;
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

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_034f: Expected I, but got O
		//IL_00a5: Expected I, but got O
		//IL_00d0: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_0102: Expected I, but got O
		//IL_012b: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_017f: Expected I, but got O
		//IL_01b2: Expected O, but got I
		//IL_01c0: Expected I, but got O
		//IL_01d3: Expected O, but got I4
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0232: Expected O, but got I4
		//IL_026f: Expected I, but got O
		//IL_0282: Expected O, but got I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_02e9: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1472;
		Delegate obj2 = (Delegate)((nint)0 + (nint)1040);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1488;
		object obj4 = (nint)0 + (nint)1048;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1480;
		object obj6 = (nint)0 + (nint)1064;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnClanFeedAdded += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		CoordinatorService.OnClanFeedRemoved += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		CoordinatorService.OnClanFeedPinChanged += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1088;
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj9);
		SFS.OnRoomCreated += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)1096;
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj10);
		SFS.OnRoomRemoved += action5;
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1080;
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj12);
		SFS.OnRoomGroupSubscribe += action6;
		ClanFeedListView clanFeedListView = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)1056;
		Action<long> action7 = default(Action<long>);
		action7..ctor((object)this, (IntPtr)obj13);
		Delegate obj14 = clanFeedListView.OnLoadOlderRequested;
		object obj17 = default(object);
		Delegate obj20 = default(Delegate);
		Action<long> action8 = default(Action<long>);
		object obj25 = default(object);
		Delegate obj28 = default(Delegate);
		object obj23;
		while (true)
		{
			Delegate obj15 = Delegate.Remove(obj14, action7);
			if ((object)obj15 == null)
			{
				object obj16 = 0;
			}
			else
			{
				obj3 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj17 == null;
				object obj18 = !flag;
				object obj16 = obj17;
				if (obj18 == null)
				{
					break;
				}
			}
			object obj19 = clanFeedListView + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag2 = (object)obj20 == obj14;
			obj14 = obj20;
			if (!flag2)
			{
				continue;
			}
			ClanFeedListView clanFeedListView2 = listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action8..ctor((object)this, (IntPtr)obj13);
			Delegate obj21 = clanFeedListView2.OnLoadOlderRequested;
			while (true)
			{
				Delegate obj22 = Delegate.Combine(obj21, action8);
				object obj24;
				if ((object)obj22 == null)
				{
					obj23 = 0;
					obj24 = obj3;
				}
				else
				{
					obj3 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = obj25 == null;
					object obj26 = !flag3;
					obj23 = obj25;
					obj24 = obj8;
					if (obj26 == null)
					{
						break;
					}
				}
				object obj27 = clanFeedListView2 + 400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj28 == obj21;
				obj21 = obj28;
				obj3 = obj24;
				if (flag4)
				{
					SyncTournamentCards();
					SyncClanGameCards();
					Actions.SafeInvoke(this.OnReloadRequested);
					return;
				}
			}
			break;
		}
		obj23 = obj3;
		throw new InvalidCastException();
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0264: Expected I, but got O
		//IL_00a5: Expected I, but got O
		//IL_00d0: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_0102: Expected I, but got O
		//IL_012b: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_017f: Expected I, but got O
		//IL_01b2: Expected O, but got I
		//IL_01c0: Expected I, but got O
		//IL_01d3: Expected O, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_022a: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1472;
		object obj2 = (nint)0 + (nint)1040;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1488;
		Delegate obj4 = (Delegate)((nint)0 + (nint)1048);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1480;
		object obj6 = (nint)0 + (nint)1064;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnClanFeedAdded -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		CoordinatorService.OnClanFeedRemoved -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		CoordinatorService.OnClanFeedPinChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1088;
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj9);
		SFS.OnRoomCreated -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)1096;
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj10);
		SFS.OnRoomRemoved -= action5;
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1080;
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj12);
		SFS.OnRoomGroupSubscribe -= action6;
		ClanFeedListView clanFeedListView = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)1056;
		Action<long> action7 = default(Action<long>);
		action7..ctor((object)this, (IntPtr)obj13);
		Delegate obj14 = clanFeedListView.OnLoadOlderRequested;
		object obj17 = default(object);
		bool flag2;
		Delegate obj20 = default(Delegate);
		do
		{
			Delegate obj15 = Delegate.Remove(obj14, action7);
			if ((object)obj15 == null)
			{
				object obj16 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj17 == null;
				object obj18 = !flag;
				object obj16 = obj17;
				if (obj18 == null)
				{
					throw new InvalidCastException();
				}
			}
			object obj19 = clanFeedListView + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag2 = (object)obj20 == obj14;
			obj14 = obj20;
		}
		while (!flag2);
	}

	public unsafe void AppendOlderFeed(IReadOnlyCollection<ClanFeedModel> events)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0110: Expected I, but got O
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected O, but got Unknown
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Expected O, but got Unknown
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected O, but got Unknown
		//IL_0bc2: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_0d4d: Expected O, but got I4
		//IL_0b36: Expected O, but got I
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0c32: Expected I4, but got O
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected O, but got Unknown
		//IL_0230: Expected O, but got I
		//IL_04f9: Expected O, but got I4
		//IL_050a: Expected O, but got I4
		//IL_0513: Expected O, but got I4
		//IL_0561: Expected O, but got I4
		//IL_0572: Expected O, but got I4
		//IL_057a: Expected I, but got O
		//IL_058b: Expected O, but got I4
		//IL_0bea: Expected O, but got I
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		//IL_0d82: Expected O, but got I4
		//IL_0dc2: Expected O, but got I
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02f4: Expected O, but got I
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05d2: Expected O, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_066d: Expected I, but got O
		//IL_033e: Expected O, but got I
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_0718: Expected I, but got O
		//IL_0728: Expected O, but got I
		//IL_0e34: Expected I4, but got O
		//IL_060d: Expected O, but got I
		//IL_07c6: Expected I4, but got O
		//IL_07d6: Expected O, but got I
		//IL_07f4: Expected I, but got O
		//IL_0829: Expected I, but got O
		//IL_06e1: Expected O, but got I4
		//IL_0e08: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_0a38: Expected O, but got I4
		//IL_0a51: Expected O, but got I4
		//IL_0763: Expected O, but got I
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected O, but got Unknown
		//IL_069d: Expected I, but got O
		//IL_048c: Expected O, but got I4
		//IL_0494: Expected I, but got O
		//IL_0c87: Expected O, but got I
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Expected O, but got Unknown
		//IL_0ec3: Expected O, but got I
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0636: Expected O, but got I
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0455: Expected O, but got I
		//IL_0aa8: Expected O, but got I4
		//IL_0ab0: Expected I, but got O
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected O, but got Unknown
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_089e: Expected I4, but got O
		//IL_08c2: Expected O, but got I4
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_078c: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E878B]");
		int num = 0;
		bool flag2 = default(bool);
		object obj4 = default(object);
		object obj6 = default(object);
		object obj2;
		if (events != null)
		{
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3056;
			nint num2 = (nint)events;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v26 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Kammelna.Server.Models.Clans.ClanFeedModel>>)+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v26 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Kammelna.Server.Models.Clans.ClanFeedModel>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0101;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v26 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Kammelna.Server.Models.Clans.ClanFeedModel>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			bool flag = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X10_v37-8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X10_v37-8]");
				object obj5 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X10_v37-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj6 = obj3 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v26 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Kammelna.Server.Models.Clans.ClanFeedModel>>)+12E]");
				obj2 = -1;
				obj5 = obj2 - 1;
				bool flag3 = obj5 == null;
				flag2 = (nint)obj2 != 1;
				flag = flag2;
				obj3 = obj6;
				if (flag2)
				{
					continue;
				}
				goto IL_0101;
			}
			obj2 = obj3;
			object obj7 = num2 + obj3;
			object obj8 = obj7 + 312;
			flag2 = flag;
			obj6 = obj3;
			goto IL_0b76;
		}
		ClanFeedListView clanFeedListView = listView;
		bool flag4 = (object)listView == null;
		ClanFeedLoader clanFeedLoader = this;
		if (!flag4)
		{
			clanFeedListView._loadingOlder = false;
			listView.SetFooterActive(active: false);
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float olderRetryNotBefore = realtimeSinceStartup + 3f;
			clanFeedListView._olderRetryNotBefore = olderRetryNotBefore;
			return;
		}
		goto IL_0908;
		IL_0837:
		_ = 0;
		((ClanFeedListView)(object)clanFeedLoader).SetFooterActive(active: false);
		object obj9 = default(object);
		if ((nint)obj9 <= 49)
		{
			_ = 1;
		}
		return;
		IL_04b9:
		object obj10 = default(object);
		bool flag5 = obj10 == null;
		object obj11 = obj10;
		int num3 = (int)(&obj11);
		object obj13;
		object obj12 = obj13;
		object obj15;
		object obj14 = obj15;
		object obj17;
		object obj16 = obj17;
		object obj18 = 0;
		object obj19 = obj10;
		object obj20 = 5;
		object obj21 = 0;
		clanFeedLoader = this;
		IReadOnlyCollection<ClanFeedModel> readOnlyCollection = events;
		int num5 = default(int);
		int num4 = num5;
		obj11 = obj10;
		int num6 = (int)(&obj11);
		object obj22 = obj13;
		object obj23 = obj15;
		object obj24 = obj17;
		object obj25;
		obj4 = obj25;
		obj18 = 0;
		object obj27 = default(object);
		object obj26 = obj27;
		object obj28 = 5;
		ClanFeedModel clanFeedModel;
		nint num7 = (nint)clanFeedModel;
		object obj29;
		obj6 = obj29;
		object obj30 = 0;
		ClanFeedLoader clanFeedLoader2 = this;
		clanFeedListView = (ClanFeedListView)events;
		if (!flag5)
		{
			goto IL_05a6;
		}
		goto IL_0d68;
		IL_065e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num7 = unchecked((nint)null);
		goto IL_0e2c;
		IL_0916:
		throw new NullReferenceException();
		IL_0d68:
		object obj32;
		int num8;
		int num9;
		object obj33 = default(object);
		while (true)
		{
			bool flag6 = obj30 == null;
			object obj31 = !flag6;
			num5 = num4;
			num3 = num6;
			obj12 = obj22;
			obj14 = obj23;
			obj16 = obj24;
			obj25 = obj4;
			obj27 = obj26;
			clanFeedModel = (ClanFeedModel)num7;
			obj29 = obj6;
			obj2 = obj32;
			num = num8;
			clanFeedLoader = clanFeedLoader2;
			readOnlyCollection = (IReadOnlyCollection<ClanFeedModel>)clanFeedListView;
			if (obj31 == null)
			{
				break;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if (num9 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj21 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag7 = obj11 == null;
				object obj34 = !flag7;
				obj18 = obj33;
				obj19 = obj11;
				obj20 = 0;
				if (obj34 == null)
				{
					num4 = num5;
					num6 = num3;
					obj22 = obj12;
					obj23 = obj14;
					obj24 = obj16;
					obj4 = obj25;
					obj18 = obj33;
					obj26 = obj27;
					obj28 = 0;
					num7 = (nint)clanFeedModel;
					obj6 = obj29;
					obj32 = obj2;
					num8 = num;
					obj30 = obj33;
					clanFeedLoader2 = clanFeedLoader;
					clanFeedListView = (ClanFeedListView)readOnlyCollection;
					continue;
				}
				goto IL_05a6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		if ((nint)obj28 != 5)
		{
			bool flag8 = obj28 == null;
			object obj35 = !flag8;
			if (obj35 != null)
			{
				return;
			}
		}
		clanFeedLoader = (ClanFeedLoader)(object)clanFeedLoader2.listView;
		object obj36 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2184;
		nint num10 = (nint)clanFeedListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v7 (Il2CppClass<ClanFeedListView>)+12E]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v7 (Il2CppClass<ClanFeedListView>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07b4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v7 (Il2CppClass<ClanFeedListView>)+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v7-8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v7-8]");
			if (0 == (nint)obj36)
			{
				break;
			}
			obj6 = obj37 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v7 (Il2CppClass<ClanFeedListView>)+12E]");
			obj2 = -1;
			bool flag9 = (nint)obj2 != 1;
			obj37 = obj6;
			if (flag9)
			{
				continue;
			}
			goto IL_07b4;
		}
		obj2 = obj37;
		object obj38 = num10 + obj37;
		object obj39 = obj38 + 312;
		num = (int)obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v856 @ X0_v19] (should have been resolved before IL gen)");
		bool flag10 = (object)clanFeedLoader == null;
		object obj40 = !flag10;
		num5 = num4;
		num3 = num6;
		obj12 = obj22;
		obj14 = obj23;
		obj16 = obj24;
		obj27 = obj26;
		obj6 = obj37;
		if (obj40 != null)
		{
			goto IL_0837;
		}
		goto IL_0908;
		IL_0908:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0916;
		IL_05a6:
		object obj41 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj42 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v20+12E]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v20+12E]");
		if ((nint)0 == 0)
		{
			goto IL_065e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v20+B0]");
		object obj43 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X10_v18-8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X10_v18-8]");
			if (0 == (nint)obj41)
			{
				break;
			}
			obj29 = obj43 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v20+12E]");
			obj32 = -1;
			bool flag11 = (nint)obj32 != 1;
			obj43 = obj29;
			if (flag11)
			{
				continue;
			}
			goto IL_065e;
		}
		obj32 = obj43;
		object obj44 = obj42 + obj43;
		object obj45 = obj44 + 312;
		num7 = (nint)clanFeedModel;
		obj29 = obj43;
		goto IL_0e2c;
		IL_0101:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num11 = unchecked((nint)null);
		goto IL_0b76;
		IL_0b76:
		obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj15 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 432;
		obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v37+8]");
		IReadOnlyCollection<ClanFeedModel> readOnlyCollection2 = (IReadOnlyCollection<ClanFeedModel>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v300 @ X0_v37] (should have been resolved before IL gen)");
		num = (int)(&obj11);
		object obj49 = default(object);
		object obj51 = default(object);
		ClanFeedEventDataHolder clanFeedEventDataHolder = default(ClanFeedEventDataHolder);
		ClanFeedModel clanFeedModel2 = default(ClanFeedModel);
		while (true)
		{
			bool flag12 = obj10 == null;
			obj11 = obj10;
			num3 = (int)(&obj11);
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj17;
			obj18 = 0;
			clanFeedLoader = this;
			clanFeedListView = (ClanFeedListView)events;
			if (flag12)
			{
				break;
			}
			object obj46 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v31+12E]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v31+12E]");
			bool flag13 = (nint)0 == 0;
			obj25 = obj4;
			obj29 = obj6;
			if (flag13)
			{
				goto IL_02b5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v31+B0]");
			object obj47 = (nint)0 + (nint)8;
			bool flag14 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v32-8]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v32-8]");
				object obj5 = 0 - obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v32-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj29 = obj47 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v31+12E]");
				obj32 = -1;
				obj5 = obj32 - 1;
				bool flag3 = obj5 == null;
				flag2 = (nint)obj32 != 1;
				flag14 = flag2;
				obj47 = obj29;
				if (flag2)
				{
					continue;
				}
				goto IL_02b5;
			}
			obj32 = obj47;
			object obj48 = obj46 + obj47;
			obj49 = obj48 + 312;
			clanFeedModel = (ClanFeedModel)num11;
			flag2 = flag14;
			obj29 = obj47;
			goto IL_0c2a;
			IL_02b5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			clanFeedModel = null;
			goto IL_0c2a;
			IL_0c2a:
			num8 = (int)obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v41+8]");
			num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v618 @ X0_v41] (should have been resolved before IL gen)");
			object obj50 = obj51 & 1;
			object obj53;
			object obj54;
			object obj57;
			if (obj50 != null)
			{
				if (obj10 != null)
				{
					object obj52 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v34+12E]");
					obj53 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v34+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v34+B0]");
						obj54 = (nint)0 + (nint)8;
						bool flag15 = flag2;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X10_v23-8]");
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X10_v23-8]");
							object obj5 = 0 - obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X10_v23-8]");
							if (0 == (nint)obj15)
							{
								break;
							}
							obj29 = obj54 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v34+12E]");
							obj53 = -1;
							obj5 = obj53 - 1;
							bool flag3 = obj5 == null;
							flag2 = (nint)obj53 != 1;
							flag15 = flag2;
							obj54 = obj29;
							if (flag2)
							{
								continue;
							}
							goto IL_03fe;
						}
						obj53 = obj54;
						object obj55 = obj52 + obj54;
						object obj56 = obj55 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X10_v23-8]");
						obj57 = 0;
						flag2 = flag15;
						goto IL_0cc7;
					}
					goto IL_03fe;
				}
				throw new NullReferenceException();
			}
			goto IL_04b9;
			IL_03fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj57 = obj25;
			clanFeedModel = null;
			obj54 = obj29;
			goto IL_0cc7;
			IL_0cc7:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v812 @ X0_v45] (should have been resolved before IL gen)");
			int num12 = ++_index;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			clanFeedEventDataHolder..ctor(_index, clanFeedModel2);
			listView.AddFeed(clanFeedEventDataHolder);
			num5 = _index;
			obj4 = obj57;
			obj27 = 0;
			num11 = (nint)clanFeedModel2;
			obj6 = obj54;
			obj2 = obj53;
			readOnlyCollection2 = (IReadOnlyCollection<ClanFeedModel>)clanFeedEventDataHolder;
			num = num12;
		}
		goto IL_0916;
		IL_07b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj58 = default(object);
		num = (int)obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v16+8]");
		readOnlyCollection2 = (IReadOnlyCollection<ClanFeedModel>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v841 @ X0_v16] (should have been resolved before IL gen)");
		bool flag16 = (object)clanFeedLoader == null;
		num7 = unchecked((nint)null);
		num5 = num4;
		num3 = num6;
		obj12 = obj22;
		obj14 = obj23;
		obj16 = obj24;
		obj27 = obj26;
		num11 = unchecked((nint)null);
		if (!flag16)
		{
			goto IL_0837;
		}
		goto IL_0908;
		IL_0e2c:
		num8 = (int)obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v29+8]");
		num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v824 @ X0_v29] (should have been resolved before IL gen)");
		num4 = num5;
		num6 = num3;
		obj22 = obj12;
		obj23 = obj14;
		obj24 = obj16;
		obj4 = obj25;
		obj26 = obj27;
		obj28 = obj20;
		obj6 = obj29;
		obj30 = obj21;
		clanFeedLoader2 = clanFeedLoader;
		clanFeedListView = (ClanFeedListView)readOnlyCollection;
		goto IL_0d68;
	}

	public void LoadFeed(IEnumerable<ClanFeedModel> events)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_0264: Expected I4, but got I8
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I4
		//IL_033d: Expected O, but got I
		//IL_034d: Expected O, but got I
		//IL_035d: Expected O, but got I
		//IL_037f: Expected O, but got I4
		//IL_039f: Expected O, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0613: Expected O, but got I4
		//IL_01b2: Expected O, but got I
		//IL_01c2: Expected O, but got I
		//IL_01d2: Expected O, but got I
		//IL_01f4: Expected O, but got I4
		//IL_06bf: Expected O, but got I
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_06df: Expected O, but got I
		//IL_06f1: Expected O, but got I
		//IL_0701: Expected O, but got I
		//IL_0723: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_0294: Expected I, but got O
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02e9: Expected O, but got I4
		//IL_07ca: Expected I, but got O
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_066d: Expected O, but got I
		//IL_067e: Expected I, but got O
		//IL_069c: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_0463: Expected O, but got I4
		//IL_040d: Expected O, but got I4
		//IL_03ff: Expected O, but got I
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_075b: Expected O, but got I
		//IL_076c: Expected I, but got O
		//IL_078a: Expected O, but got I
		//IL_04a2: Expected O, but got I4
		//IL_0493: Expected O, but got I
		//IL_0508: Expected O, but got I4
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected I4, but got Unknown
		if (events == null)
		{
			return;
		}
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int loadedClanId;
		List<object> list;
		if (localUser != null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v63+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
			bool flag3 = clanId != _loadedClanId;
			list = null;
			List<object> list2 = null;
			loadedClanId = clanId;
			if (!flag3)
			{
				goto IL_014d;
			}
		}
		else
		{
			bool flag4 = 4294967295L == _loadedClanId;
			list = null;
			List<object> list2 = null;
			loadedClanId = -1;
			if (flag4)
			{
				goto IL_014d;
			}
		}
		object obj7 = typeof(List<AdaptivePerformanceScaler>) + 528;
		ClanFeedListView clanFeedListView = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		nint num = (nint)clanFeedListView;
		clanFeedListView.data = (List<ClanFeedEventDataHolder>)(object)list3;
		_loadedClanId = loadedClanId;
		object obj8 = typeof(CardUtils.<>c) + 720;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v36+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v33 (Il2CppClass<ClanFeedListView>)+2B0]");
		nint num2 = 0;
		object obj11 = obj8;
		list = list3;
		object obj12 = obj9;
		if (obj10 != null)
		{
			goto IL_01a6;
		}
		goto IL_031f;
		IL_03ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v36+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		object obj15;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v26+B8]");
			obj15 = 0;
		}
		object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3664;
		Func<object, DateTime> func = default(Func<object, DateTime>);
		func..ctor(obj15, (IntPtr)obj17);
		object obj18 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v25+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj20 = 0;
		object obj22;
		object obj21 = obj22;
		obj8 = obj11;
		Func<object, DateTime> keySelector = func;
		goto IL_05d8;
		IL_014d:
		obj8 = typeof(CardUtils.<>c) + 720;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v36+E4]");
		bool flag7 = (nint)0 == 0;
		IntPtr intPtr = default(IntPtr);
		num2 = intPtr;
		obj11 = obj8;
		obj12 = obj9;
		if (!flag7)
		{
			goto IL_01a6;
		}
		goto IL_031f;
		IL_05d8:
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending(events, keySelector);
		object obj23 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj8;
		}
		object obj25 = (nint)0 + (nint)1040;
		object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 640;
		object obj27 = (nint)0 + (nint)1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v13+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v11+10]");
		Func<object, long> keySelector2 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v11+10]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v13+E4]");
			bool flag10 = (nint)0 == 0;
			object obj30 = !flag10;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v17+B8]");
				obj28 = 0;
			}
			object obj32 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj33 = (nint)0 + (nint)3672;
			Func<object, long> func2 = default(Func<object, long>);
			func2..ctor(obj28, (IntPtr)obj33);
			object obj34 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v16+B8]");
			object obj35 = (nint)0 + (nint)16;
			obj35 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj20 = 0;
			keySelector2 = func2;
		}
		IOrderedEnumerable<object> source2 = Enumerable.ThenByDescending(source, keySelector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func3 = default(Func<object, object>);
		func3..ctor((object)this, (IntPtr)obj27);
		IEnumerable<object> source3 = Enumerable.Select(source2, func3);
		List<object> list4 = Enumerable.ToList(source3);
		listView.ReconcileServerFeed((IReadOnlyList<ClanFeedEventDataHolder>)list4);
		ClanFeedListView clanFeedListView2 = listView;
		object obj36 = list4._size - 50;
		bool flag11 = (nint)obj36 < 0;
		int num3 = list4._size ^ 0x32;
		int num4 = list4._size ^ obj36;
		int num5 = num3 & num4;
		bool flag12 = num5 < 0;
		bool flag13 = flag11 == flag12;
		bool reachedFeedEnd = !flag13;
		clanFeedListView2._loadingOlder = false;
		clanFeedListView2._reachedFeedEnd = reachedFeedEnd;
		clanFeedListView2.SetFooterActive(active: false);
		SyncTournamentCards();
		SyncClanGameCards();
		SyncUpgradeCallToAction(events);
		return;
		IL_01a6:
		obj21 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v36+B8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v20+8]");
		keySelector = (Func<object, DateTime>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v20+8]");
		bool flag14 = (nint)0 == 0;
		object obj37 = !flag14;
		Func<object, DateTime> func4;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v33 (Il2CppClass<ClanFeedListView>)+2B0]");
			num2 = 0;
			obj22 = obj21;
			obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v20+8]");
			func4 = (Func<object, DateTime>)0;
			goto IL_03ad;
		}
		goto IL_05d8;
		IL_031f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj11;
		obj22 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v36+B8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v20+8]");
		func4 = (Func<object, DateTime>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v20+8]");
		bool flag15 = (nint)0 == 0;
		object obj38 = !flag15;
		obj21 = obj22;
		obj8 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v20+8]");
		keySelector = (Func<object, DateTime>)0;
		if (obj38 == null)
		{
			goto IL_03ad;
		}
		goto IL_05d8;
	}

	private void SyncUpgradeCallToAction(IEnumerable<ClanFeedModel> events)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_00a3: Expected O, but got I
		//IL_00c5: Expected O, but got I4
		//IL_0272: Expected O, but got I
		//IL_0282: Expected O, but got I
		//IL_0292: Expected O, but got I
		//IL_02b4: Expected O, but got I4
		//IL_0178: Expected O, but got I4
		//IL_035c: Expected O, but got I4
		//IL_01f7: Expected O, but got I
		//IL_0207: Expected O, but got I
		//IL_0217: Expected O, but got I
		//IL_0239: Expected O, but got I4
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected O, but got Unknown
		//IL_08d3: Expected O, but got I
		//IL_08e4: Expected I, but got O
		//IL_0902: Expected O, but got I
		//IL_091d: Expected O, but got I4
		//IL_09c7: Expected O, but got I
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected O, but got Unknown
		//IL_09ec: Expected O, but got I
		//IL_09fc: Expected O, but got I
		//IL_0a1e: Expected O, but got I4
		//IL_02ec: Expected O, but got I4
		//IL_01a8: Expected O, but got I
		//IL_03e4: Expected O, but got I
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected O, but got Unknown
		//IL_095c: Expected O, but got I
		//IL_096d: Expected I, but got O
		//IL_098b: Expected O, but got I
		//IL_09a6: Expected O, but got I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_0459: Expected O, but got I4
		//IL_03a3: Expected O, but got I4
		//IL_031c: Expected O, but got I
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected O, but got Unknown
		//IL_0a56: Expected O, but got I
		//IL_0a67: Expected I, but got O
		//IL_0a85: Expected O, but got I
		//IL_0aa0: Expected O, but got I4
		//IL_03d3: Expected O, but got I
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_06ae: Expected O, but got I4
		//IL_06d2: Expected O, but got I4
		//IL_04da: Expected O, but got I4
		//IL_053c: Expected O, but got I
		//IL_0890: Expected I8, but got I4
		//IL_07c7: Expected O, but got I4
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_05b6: Expected O, but got I4
		//IL_0702: Expected O, but got I
		//IL_0806: Expected O, but got I4
		//IL_0747: Expected O, but got I4
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_05db: Expected O, but got I4
		//IL_060c: Expected O, but got I4
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0b2e: Expected O, but got I4
		//IL_0739: Expected O, but got I
		//IL_085c: Expected O, but got I
		//IL_086d: Expected I, but got O
		//IL_0648: Expected O, but got I
		//IL_068d: Expected O, but got I4
		//IL_0ad1: Expected O, but got I4
		//IL_067f: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(CardUtils.<>c) + 720;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v73+E4]");
		object obj7;
		Func<object, bool> predicate;
		object obj9;
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = (nint)0 + (nint)3320;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v73+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v48+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v48+18]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				obj9 = obj6;
				goto IL_0156;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
			obj9 = (nint)0 + (nint)3320;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v73+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v48+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v48+18]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			obj6 = obj9;
			if (obj10 == null)
			{
				goto IL_0156;
			}
		}
		goto IL_01ad;
		IL_02ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v63+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		object obj13;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v43+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3712;
		Func<object, DateTime> func = default(Func<object, DateTime>);
		func..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v42+B8]");
		object obj17 = (nint)0 + (nint)32;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = 0;
		object obj20;
		object obj19 = obj20;
		Func<object, DateTime> keySelector = func;
		goto IL_0321;
		IL_0697:
		object obj21 = obj2 + 32;
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag4 = obj21 == null;
		object obj22 = !flag4;
		if (obj22 != null)
		{
			goto IL_077b;
		}
		goto IL_0880;
		IL_077b:
		ClanUserModel clanUserModel;
		object obj25;
		object obj23;
		if (clanUserModel != null)
		{
			bool flag5 = ClanPermissionsExtensions.Can(clanUserModel.Permissions, ClanPermissions.ManageVault);
			bool flag6 = !flag5;
			obj23 = 0;
			if (!flag6)
			{
				_ = _loadedClanId;
				object obj24 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v36+E4]");
				bool flag7 = (nint)0 == 0;
				object obj26 = !flag7;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj27 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj28 = (nint)0 + (nint)3728;
				Action<object> action = default(Action<object>);
				action..ctor(obj2, (IntPtr)obj28);
				ClanServerConnector clanServerConnector = default(ClanServerConnector);
				clanServerConnector.GetMyClan(action);
				return;
			}
		}
		goto IL_0880;
		IL_0156:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v73+E4]");
		bool flag8 = (nint)0 == 0;
		object obj29 = !flag8;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj30 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v54+B8]");
			obj7 = 0;
		}
		object obj31 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = (nint)0 + (nint)3704;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj7, (IntPtr)obj32);
		object obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v53+B8]");
		object obj34 = (nint)0 + (nint)24;
		obj34 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = 0;
		obj6 = obj9;
		predicate = func2;
		goto IL_01ad;
		IL_0321:
		IEnumerable<object> source2;
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending(source2, keySelector);
		object obj35 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v18+E4]");
		bool flag9 = (nint)0 == 0;
		object obj36 = !flag9;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj35 = obj3;
		}
		object obj37 = (nint)0 + (nint)1040;
		obj25 = typeof(Queue<string>) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v18+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v28+28]");
		Func<object, long> keySelector2 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v28+28]");
		bool flag10 = (nint)0 == 0;
		object obj39 = !flag10;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v18+E4]");
			bool flag11 = (nint)0 == 0;
			object obj40 = !flag11;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj41 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v34+B8]");
				obj38 = 0;
			}
			object obj42 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj43 = (nint)0 + (nint)3720;
			Func<object, long> func3 = default(Func<object, long>);
			func3..ctor(obj38, (IntPtr)obj43);
			object obj44 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v33+B8]");
			object obj45 = (nint)0 + (nint)40;
			obj45 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj18 = 0;
			keySelector2 = func3;
		}
		object obj46 = (nint)0 + (nint)1976;
		obj23 = obj37;
		IOrderedEnumerable<object> source3 = Enumerable.ThenByDescending(source, keySelector2);
		object obj47 = Enumerable.FirstOrDefault(source3);
		object obj48 = obj2 + 40;
		obj48 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj49 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v25+E4]");
		bool flag12 = (nint)0 == 0;
		object obj50 = !flag12;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		User mySelf = SFS.MySelf;
		ClanUserModel clanUserModel2;
		if (mySelf != null)
		{
			ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(mySelf);
			object obj51 = obj48;
			bool flag13 = obj48 == null;
			object obj52 = !flag13;
			clanUserModel2 = clanMembership;
			if (obj52 != null)
			{
				goto IL_052c;
			}
			clanUserModel = clanMembership;
		}
		else
		{
			object obj51 = obj48;
			bool flag14 = obj48 == null;
			clanUserModel2 = null;
			clanUserModel = null;
			if (!flag14)
			{
				goto IL_052c;
			}
		}
		goto IL_0697;
		IL_052c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v22+78]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v22+78]");
		bool flag15 = (nint)0 == 0;
		clanUserModel = clanUserModel2;
		if (flag15)
		{
			goto IL_0697;
		}
		object obj54 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1384;
		object obj55 = obj54;
		object obj56 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X11_v4+130]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X9_v9+130]");
		bool flag16 = num < 0;
		object obj57 = !flag16;
		object obj62;
		object obj58;
		if (obj57 == null)
		{
			obj58 = obj2 + 32;
			obj58 = 0;
			object obj59 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X11_v13+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X9_v9+130]");
			bool flag17 = num2 < 0;
			object obj60 = !flag17;
			object obj61 = ~obj60;
			obj62 = obj58;
			if (obj61 == null)
			{
				goto IL_062b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X11_v4+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X9_v9+130]");
			object obj63 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X11_v7-8]");
			object obj64;
			if (0 == (nint)obj55)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v22+78]");
				obj64 = 0;
			}
			else
			{
				obj64 = 0;
			}
			obj58 = obj2 + 32;
			obj58 = obj64;
			object obj59 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X11_v13+130]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X9_v9+130]");
			bool flag18 = num4 < 0;
			object obj65 = !flag18;
			obj62 = obj58;
			if (obj65 != null)
			{
				goto IL_062b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag19 = obj62 == null;
		clanUserModel = clanUserModel2;
		if (!flag19)
		{
			goto IL_077b;
		}
		goto IL_0880;
		IL_01ad:
		source2 = Enumerable.Where(events, predicate);
		object obj66 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v63+E4]");
		if ((nint)0 != 0)
		{
			obj19 = (nint)0 + (nint)2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v63+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v37+20]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v37+20]");
			bool flag20 = (nint)0 == 0;
			object obj67 = !flag20;
			if (obj67 == null)
			{
				obj20 = obj19;
				goto IL_02ca;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj66 = obj3;
			obj20 = (nint)0 + (nint)2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v63+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v37+20]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v37+20]");
			bool flag21 = (nint)0 == 0;
			object obj68 = !flag21;
			obj19 = obj20;
			if (obj68 == null)
			{
				goto IL_02ca;
			}
		}
		goto IL_0321;
		IL_062b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X11_v13+C8]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X9_v9+130]");
		object obj69 = num5 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X10_v5-8]");
		if (0 == (nint)obj55)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v22+78]");
			object obj70 = 0;
		}
		else
		{
			object obj70 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag22 = obj58 == null;
		object obj71 = !flag22;
		clanUserModel = clanUserModel2;
		if (obj71 != null)
		{
			goto IL_077b;
		}
		goto IL_0880;
		IL_0880:
		listView.RemoveFeedById(-1L);
	}

	private void InsertCallToActionBelow(ClanFeedModel latestUpgrade)
	{
		//IL_000d: Expected I, but got O
		//IL_001d: Expected I8, but got I
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03c5: Expected I8, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0165: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_00f1: Expected I, but got O
		//IL_011c: Expected O, but got I4
		//IL_0094: Expected O, but got I
		//IL_00a4: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_0284: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_013a: Expected I, but got O
		//IL_0142: Expected I8, but got O
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_0527: Expected O, but got I
		//IL_0538: Expected I, but got O
		//IL_0556: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_0224: Expected I, but got O
		//IL_024d: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_025e: Expected I, but got O
		//IL_0266: Expected I8, but got O
		//IL_0217: Expected O, but got I
		//IL_0352: Expected O, but got I4
		//IL_0357: Expected I, but got O
		//IL_02e4: Expected O, but got I
		//IL_02fc: Expected I, but got O
		//IL_0375: Expected I8, but got I4
		//IL_0386: Expected I8, but got I4
		ClanFeedListView clanFeedListView = listView;
		nint num = (nint)clanFeedListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<ClanFeedListView>)+2A0]");
		long num2 = 0L;
		List<object> data = (List<object>)(object)clanFeedListView.data;
		object obj3;
		Predicate<object> predicate;
		object obj14;
		nint num3;
		object obj13;
		nint num4;
		object obj15 = default(object);
		if (data != null)
		{
			object obj = typeof(CardUtils.<>c) + 720;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v19+E4]");
			object obj4;
			object obj5;
			List<object> list;
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)3272;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v19+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v8+30]");
				predicate = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v8+30]");
				bool flag = (nint)0 == 0;
				obj5 = obj3;
				list = data;
				if (!flag)
				{
					goto IL_00e9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj3 = (nint)0 + (nint)3272;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v19+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v8+30]");
				predicate = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v8+30]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj5 = obj3;
				list = data;
				if (obj6 != null)
				{
					goto IL_00e9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v26+B8]");
				obj4 = 0;
			}
			object obj9 = typeof(List<Tween>) + 3152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3656;
			Predicate<object> predicate2 = default(Predicate<object>);
			predicate2..ctor(obj4, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v25+B8]");
			object obj12 = (nint)0 + (nint)48;
			obj12 = predicate2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num3 = (nint)obj5;
			obj13 = list.Find(predicate2);
			bool flag4 = obj13 == null;
			obj14 = 0;
			obj15 = 0;
			num4 = (nint)obj5;
			num2 = (long)predicate2;
			if (!flag4)
			{
				goto IL_0274;
			}
		}
		goto IL_038b;
		IL_038b:
		object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanFeedModel clanFeedModel = default(ClanFeedModel);
		clanFeedModel..ctor();
		clanFeedModel.Id = -1L;
		object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1176;
		clanFeedModel.ClanId = latestUpgrade.ClanId;
		object obj18 = clanFeedModel + 32;
		obj18 = latestUpgrade.ClanName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj19 = clanFeedModel + 40;
		obj19 = latestUpgrade.Emblem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72535E0]");
		clanFeedModel.Type = ClanFeedType.Announcement;
		clanFeedModel.DateCreated = latestUpgrade.DateCreated;
		clanFeedModel.DateCompleted = latestUpgrade.DateCompleted;
		object obj20 = clanFeedModel + 120;
		obj20 = latestUpgrade.Data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int index = _index + 1;
		_index = index;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanFeedEventDataHolder clanFeedEventDataHolder = default(ClanFeedEventDataHolder);
		clanFeedEventDataHolder..ctor(_index, clanFeedModel);
		listView.AddFeed(clanFeedEventDataHolder);
		return;
		IL_00e9:
		num3 = (nint)obj3;
		obj13 = data.Find(predicate);
		bool flag5 = obj13 == null;
		object obj21 = !flag5;
		obj14 = obj15;
		if (obj21 != null)
		{
			goto IL_0274;
		}
		num4 = (nint)obj3;
		num2 = (long)predicate;
		goto IL_038b;
		IL_0274:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v21 (System.Object)+18]");
		object obj22 = 0;
		object obj23 = typeof(DataRelation) + 712;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v18+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+60]");
			bool flag6 = (DateTime)0 == latestUpgrade.DateCreated;
			bool flag7 = !flag6;
			num4 = unchecked((nint)null);
			if (!flag7)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+60]");
			bool flag8 = (DateTime)0 == latestUpgrade.DateCreated;
			bool flag9 = !flag8;
			object obj25 = !flag9;
			num4 = unchecked((nint)null);
			if (obj25 != null)
			{
				return;
			}
		}
		listView.RemoveFeedById(-1L);
		obj15 = obj14;
		num2 = -1L;
		goto IL_038b;
	}

	public void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 528;
		List<object> list = default(List<object>);
		while (true)
		{
			ClanFeedListView clanFeedListView = listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor();
			nint num = (nint)clanFeedListView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3 (Il2CppClass<ClanFeedListView>)+2A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3 (Il2CppClass<ClanFeedListView>)+2B0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v56 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void HandleLoadOlderRequested(long beforeId)
	{
		long arg = default(long);
		Actions.SafeInvoke(this.OnLoadOlderRequested, arg);
	}

	private unsafe void SyncTournamentCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_0069: Expected I4, but got O
		//IL_0084: Expected I, but got O
		//IL_00a4: Expected O, but got I
		//IL_00eb: Expected O, but got I4
		//IL_00f5: Expected O, but got I4
		//IL_00fd: Expected I4, but got O
		//IL_0abc: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0164: Expected I, but got O
		//IL_0186: Expected O, but got I4
		//IL_0b79: Expected O, but got I
		//IL_0b9b: Expected O, but got I4
		//IL_0ec2: Expected O, but got I
		//IL_0edf: Expected O, but got I
		//IL_0ef4: Expected I, but got O
		//IL_0f16: Expected O, but got I4
		//IL_01ae: Expected I, but got O
		//IL_0c41: Expected O, but got I
		//IL_0c63: Expected O, but got I4
		//IL_01c3: Expected O, but got I
		//IL_01e5: Expected O, but got I4
		//IL_0f38: Expected O, but got I
		//IL_0f5d: Expected O, but got I
		//IL_0f8b: Expected O, but got I4
		//IL_0f95: Expected O, but got I4
		//IL_0f9d: Expected I4, but got O
		//IL_0252: Expected I, but got O
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected O, but got Unknown
		//IL_0bdb: Expected O, but got I
		//IL_0bec: Expected I, but got O
		//IL_0bec: Expected O, but got I
		//IL_0bf4: Expected I, but got O
		//IL_0c0a: Expected O, but got I
		//IL_0289: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_0205: Expected I, but got O
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0329: Expected O, but got I4
		//IL_0333: Expected O, but got I4
		//IL_033b: Expected I4, but got O
		//IL_0c81: Expected O, but got I
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0cab: Expected O, but got I
		//IL_0cbc: Expected I, but got O
		//IL_0cbc: Expected O, but got I
		//IL_0cc4: Expected I, but got O
		//IL_0cda: Expected O, but got I
		//IL_02cf: Expected O, but got I4
		//IL_02b1: Expected I, but got O
		//IL_0359: Expected I, but got O
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected I4, but got Unknown
		//IL_0393: Expected O, but got I4
		//IL_03b2: Expected O, but got I4
		//IL_0cfd: Expected O, but got I
		//IL_0d22: Expected O, but got I
		//IL_0d50: Expected O, but got I4
		//IL_0d5a: Expected O, but got I4
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03f2: Expected O, but got I
		//IL_0403: Expected I, but got O
		//IL_0457: Expected O, but got I
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0420: Expected O, but got I4
		//IL_060f: Expected O, but got I
		//IL_0639: Expected O, but got I4
		//IL_064b: Expected O, but got I4
		//IL_0673: Expected O, but got I
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_098f: Expected O, but got I4
		//IL_09a1: Expected O, but got I4
		//IL_08ea: Expected O, but got I
		//IL_0915: Expected O, but got I4
		//IL_09b9: Expected O, but got I4
		//IL_09cb: Expected O, but got I4
		//IL_09f3: Expected O, but got I4
		//IL_05b2: Expected O, but got I4
		//IL_06b1: Expected I, but got O
		//IL_051a: Expected O, but got I
		//IL_0794: Expected O, but got I4
		//IL_095d: Expected O, but got I4
		//IL_096f: Expected O, but got I4
		//IL_0977: Expected O, but got I4
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Expected O, but got Unknown
		//IL_06fc: Expected O, but got I
		//IL_05bf: Expected I, but got O
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_0a1b: Expected O, but got I4
		//IL_0a23: Expected O, but got I4
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_055b: Expected O, but got I
		//IL_07fe: Expected O, but got I4
		//IL_07a1: Expected I, but got O
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_073d: Expected O, but got I
		//IL_085a: Expected O, but got I4
		//IL_0a4b: Expected O, but got I4
		//IL_0a54: Expected O, but got I4
		//IL_08d1: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (!HasClan)
		{
			return;
		}
		ClanFeedListView clanFeedListView = listView;
		bool flag = (object)listView == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		List<object>.Enumerator enumerator2 = (List<object>.Enumerator)0;
		Func<object, bool> func = default(Func<object, bool>);
		int num = (int)func;
		ClanFeedEventDataHolder clanFeedEventDataHolder = null;
		int num15 = default(int);
		int num17 = default(int);
		DateTime now;
		ClanFeedEventDataHolder clanFeedEventDataHolder2;
		object obj11;
		DateTime dateTime;
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		if (!flag)
		{
			nint num2 = (nint)clanFeedListView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v9 (Il2CppClass<ClanFeedListView>)+298]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v9 (Il2CppClass<ClanFeedListView>)+2A0]");
			clanFeedEventDataHolder = (ClanFeedEventDataHolder)0;
			List<ClanFeedEventDataHolder> data = listView.data;
			if (data == null)
			{
				return;
			}
			bool flag2 = (object)listView == null;
			enumerator = (List<object>.Enumerator)0;
			enumerator2 = (List<object>.Enumerator)0;
			num = (int)func;
			if (!flag2)
			{
				object obj3 = (nint)0 + (nint)568;
				if (!((UiListView<object, object>)(object)listView).TemplatesReady)
				{
					return;
				}
				IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
				IEnumerable<object> enumerable = (IEnumerable<object>)(typeof(CardUtils.<>c) + 720);
				nint num4 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				nint num5 = num4;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num5 = (nint)enumerable;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X9_v12 (Il2CppStaticFields<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
				Func<object, bool> predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X9_v12 (Il2CppStaticFields<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				IEnumerable<object> source = tournamentRooms;
				Func<object, bool> func2 = default(Func<object, bool>);
				IEnumerable<Room> enumerable2 = default(IEnumerable<Room>);
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+E4]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+E4]");
					bool flag5 = (nint)0 == 0;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						nint num6 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v79 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
						num3 = 0;
					}
					object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj9 = (nint)0 + (nint)3688;
					func2..ctor((object)num3, (IntPtr)obj9);
					nint num7 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v78 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
					object obj10 = (nint)0 + (nint)56;
					obj10 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj11 = 0;
					enumerable2 = tournamentRooms;
					predicate = func2;
					source = tournamentRooms;
				}
				object obj12 = (nint)0 + (nint)3736;
				IEnumerable<object> source2 = Enumerable.Where(source, predicate);
				object obj13 = (nint)0 + (nint)2624;
				List<object> list = Enumerable.ToList(source2);
				nint num8 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v32 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				nint num9 = num8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num9 = (nint)enumerable;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v20 (Il2CppStaticFields<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				Func<object, int> selector = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v20 (Il2CppStaticFields<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				object obj16 = func2;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+E4]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+E4]");
					bool flag8 = (nint)0 == 0;
					object obj17 = !flag8;
					nint num11 = num10;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						nint num12 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v71 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
						num11 = 0;
					}
					obj16 = num11;
					object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3176;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj19 = (nint)0 + (nint)3696;
					Func<object, int> func3 = default(Func<object, int>);
					func3..ctor((object)num11, (IntPtr)obj19);
					nint num13 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v70 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
					object obj20 = (nint)0 + (nint)64;
					obj20 = func3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj11 = 0;
					enumerable2 = (IEnumerable<Room>)(object)func3;
					selector = func3;
				}
				object obj21 = (nint)0 + (nint)3960;
				dateTime = (DateTime)obj21;
				IEnumerable<int> source3 = Enumerable.Select(list, selector);
				object obj22 = (nint)0 + (nint)2200;
				clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj22;
				List<int> list2 = Enumerable.ToList(source3);
				bool flag9 = obj2 == null;
				enumerator = (List<object>.Enumerator)0;
				enumerator2 = (List<object>.Enumerator)0;
				num = (int)obj16;
				if (!flag9)
				{
					object obj23 = obj2 + 16;
					obj23 = list2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ClanFeedListView clanFeedListView2 = listView;
					bool flag10 = (object)listView == null;
					enumerator = (List<object>.Enumerator)0;
					enumerator2 = (List<object>.Enumerator)0;
					num = (int)obj16;
					clanFeedEventDataHolder = (ClanFeedEventDataHolder)(object)list2;
					if (!flag10)
					{
						nint num14 = (nint)clanFeedListView2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v26 (Il2CppClass<ClanFeedListView>)+298]");
						num3 = 0;
						IEnumerable<object> data2 = listView.data;
						num = obj2 + 24;
						Func<object, bool> predicate2 = (Func<object, bool>)((int*)num)->m_value;
						bool flag11 = ((int*)num)->m_value == 0;
						object obj24 = !flag11;
						Func<object, bool> func4 = (Func<object, bool>)(object)enumerable2;
						if (obj24 == null)
						{
							object obj25 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 624;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj26 = (nint)0 + (nint)3736;
							Func<object, bool> func5 = default(Func<object, bool>);
							func5..ctor(obj2, (IntPtr)obj26);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj11 = 0;
							func4 = func5;
							enumerable = data2;
							predicate2 = func5;
						}
						object obj27 = (nint)0 + (nint)3312;
						dateTime = (DateTime)obj27;
						IEnumerable<object> source4 = Enumerable.Where(data2, predicate2);
						object obj28 = (nint)0 + (nint)1952;
						clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj28;
						List<object> list3 = Enumerable.ToList(source4);
						bool flag12 = list3 == null;
						enumerator = (List<object>.Enumerator)0;
						enumerator2 = (List<object>.Enumerator)0;
						enumerable2 = (IEnumerable<Room>)(object)func4;
						if (!flag12)
						{
							List<object>.Enumerator enumerator3 = list3.GetEnumerator();
							enumerable = (IEnumerable<object>)((nint)0 + (nint)3968);
							enumerable2 = (IEnumerable<Room>)(typeof(RegisteredWaitHandle) + 1376);
							Room room = default(Room);
							bool flag14 = default(bool);
							while (true)
							{
								clanFeedEventDataHolder = (ClanFeedEventDataHolder)enumerable;
								if (!enumerator2.MoveNext())
								{
									break;
								}
								if (room == null)
								{
									goto IL_097c;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ stack_-98 (Sfs2X.Entities.Room)+20]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ stack_-98 (Sfs2X.Entities.Room)+20]");
								if ((nint)0 == 0)
								{
									goto IL_09a6;
								}
								int value = ((int*)num)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v56 (System.Int32)+12E]");
								num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v56 (System.Int32)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_059f;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v56 (System.Int32)+B0]");
								object obj29 = (nint)0 + (nint)8;
								bool flag13 = flag14;
								object obj6;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X10_v18-8]");
									object obj30 = 0 - enumerable2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X10_v18-8]");
									if (0 == (nint)enumerable2)
									{
										break;
									}
									obj6 = obj29 + 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v56 (System.Int32)+12E]");
									num3 = -1;
									obj30 = num3 - 1;
									bool flag15 = obj30 == null;
									flag14 = num3 != 1;
									flag13 = flag14;
									obj29 = obj6;
									if (flag14)
									{
										continue;
									}
									goto IL_059f;
								}
								num3 = (nint)obj29;
								object obj31 = value + obj29;
								object obj32 = obj31 + 312;
								flag14 = flag13;
								obj6 = obj29;
								goto IL_0db1;
								IL_059f:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
								dateTime = (DateTime)0;
								goto IL_0db1;
								IL_0db1:
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v749 @ X0_v79] (should have been resolved before IL gen)");
								if ((object)listView != null)
								{
									listView.RemoveLiveRoomById(num15);
									continue;
								}
								goto IL_094a;
							}
							object obj33 = (nint)0 + (nint)3960;
							clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj33;
							enumerator2.Dispose();
							bool flag16 = list == null;
							enumerator = (List<object>.Enumerator)0;
							enumerator4 = enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							if (!flag16)
							{
								List<object>.Enumerator enumerator6 = list.GetEnumerator();
								enumerable = (IEnumerable<object>)((nint)0 + (nint)768);
								object obj34 = typeof(DataRelation) + 712;
								List<object>.Enumerator enumerator7 = default(List<object>.Enumerator);
								while (true)
								{
									clanFeedEventDataHolder = (ClanFeedEventDataHolder)enumerable;
									if (!enumerator7.MoveNext())
									{
										break;
									}
									if (room == null)
									{
										goto IL_09d0;
									}
									nint num16 = (nint)room;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0781;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
									object obj35 = (nint)0 + (nint)8;
									bool flag17 = flag14;
									object obj6;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X10_v12-8]");
										object obj30 = 0 - enumerable2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X10_v12-8]");
										if (0 == (nint)enumerable2)
										{
											break;
										}
										obj6 = obj35 + 16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
										num3 = -1;
										obj30 = num3 - 1;
										bool flag15 = obj30 == null;
										flag14 = num3 != 1;
										flag17 = flag14;
										obj35 = obj6;
										if (flag14)
										{
											continue;
										}
										goto IL_0781;
									}
									num3 = (nint)obj35;
									object obj36 = num16 + obj35;
									object obj37 = obj36 + 312;
									flag14 = flag17;
									obj6 = obj35;
									goto IL_0e4c;
									IL_0e4c:
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v814 @ X0_v59] (should have been resolved before IL gen)");
									if ((object)listView == null)
									{
										goto IL_09f8;
									}
									bool flag18 = listView.HasLiveRoom(num17);
									bool flag19 = !flag18;
									object obj38 = !flag19;
									if (obj38 != null)
									{
										continue;
									}
									num = _index;
									int index = _index + 1;
									_index = index;
									object obj39 = obj34;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v65+E4]");
									bool flag20 = (nint)0 == 0;
									object obj40 = !flag20;
									if (obj40 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									now = DateTime.Now;
									clanFeedEventDataHolder2 = ClanFeedEventDataHolder.LiveTournament(num, room, now);
									if ((object)listView != null)
									{
										listView.AddFeed(clanFeedEventDataHolder2);
										obj11 = 0;
										dateTime = now;
										continue;
									}
									goto IL_0a28;
									IL_0781:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
									dateTime = (DateTime)0;
									goto IL_0e4c;
								}
								object obj41 = (nint)0 + (nint)760;
								clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj41;
								enumerator7.Dispose();
								enumerator = enumerator5;
								enumerator4 = enumerator5;
								enumerator5 = (List<object>.Enumerator)0;
								goto IL_091a;
							}
						}
					}
				}
			}
		}
		goto IL_0b4b;
		IL_0b4b:
		NullReferenceException ex = new NullReferenceException();
		bool flag21 = (nint)clanFeedEventDataHolder != 1;
		NullReferenceException ex2 = ex;
		if (!flag21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj42 = (nint)0 + (nint)760;
			clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj42;
			enumerator.Dispose();
			object obj43 = default(object);
			bool flag22 = obj43 == null;
			enumerator5 = (List<object>.Enumerator)obj43;
			if (flag22)
			{
				goto IL_091a;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator5 = (List<object>.Enumerator)obj43;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223C8F0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_097c:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		goto IL_0b4b;
		IL_091a:
		if ((object)listView != null)
		{
			listView.SeedPinFromData();
			return;
		}
		goto IL_0b4b;
		IL_094a:
		NullReferenceException ex5 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		clanFeedEventDataHolder = (ClanFeedEventDataHolder)num15;
		goto IL_0b4b;
		IL_09d0:
		NullReferenceException ex6 = new NullReferenceException();
		enumerator = enumerator5;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		goto IL_0b4b;
		IL_09f8:
		NullReferenceException ex7 = new NullReferenceException();
		enumerator = enumerator5;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		clanFeedEventDataHolder = (ClanFeedEventDataHolder)num17;
		goto IL_0b4b;
		IL_0a28:
		NullReferenceException ex8 = new NullReferenceException();
		enumerator = enumerator5;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		obj11 = 0;
		dateTime = now;
		clanFeedEventDataHolder = clanFeedEventDataHolder2;
		goto IL_0b4b;
		IL_09a6:
		NullReferenceException ex9 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		goto IL_0b4b;
	}

	private void SyncClanGameCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_007c: Expected I, but got O
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_0adf: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0196: Expected O, but got I4
		//IL_0b73: Expected O, but got I
		//IL_0b83: Expected O, but got I
		//IL_0ba5: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_0286: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_01cb: Expected O, but got I
		//IL_01ed: Expected O, but got I4
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Expected O, but got Unknown
		//IL_0be5: Expected O, but got I
		//IL_0bf6: Expected I, but got O
		//IL_0c14: Expected O, but got I
		//IL_0c2f: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_021d: Expected O, but got I
		//IL_02ed: Expected O, but got I4
		//IL_064a: Expected O, but got I4
		//IL_032d: Expected O, but got I4
		//IL_0337: Expected O, but got I4
		//IL_0672: Expected O, but got I
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
		//IL_035a: Expected I, but got O
		//IL_036a: Expected O, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03a9: Expected O, but got I4
		//IL_08fd: Expected O, but got I
		//IL_0928: Expected O, but got I4
		//IL_0c48: Expected O, but got I
		//IL_0c6d: Expected O, but got I
		//IL_0c9b: Expected O, but got I4
		//IL_0ca5: Expected O, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03f1: Expected O, but got I
		//IL_0402: Expected I, but got O
		//IL_0980: Expected O, but got I4
		//IL_0456: Expected O, but got I
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_0427: Expected O, but got I4
		//IL_06c4: Expected I, but got O
		//IL_06d4: Expected O, but got I
		//IL_07a7: Expected O, but got I4
		//IL_0609: Expected O, but got I
		//IL_062c: Expected O, but got I4
		//IL_070f: Expected O, but got I
		//IL_09a8: Expected O, but got I4
		//IL_09b0: Expected O, but got I4
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Expected O, but got Unknown
		//IL_09c8: Expected O, but got I4
		//IL_09da: Expected O, but got I4
		//IL_0811: Expected O, but got I4
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_049c: Expected O, but got I
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_0740: Expected O, but got I
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_09fa: Expected O, but got I4
		//IL_0a0c: Expected O, but got I4
		//IL_0829: Expected O, but got I4
		//IL_086d: Expected O, but got I4
		//IL_04c9: Expected I, but got O
		//IL_04d9: Expected O, but got I
		//IL_08a4: Expected I4, but got O
		//IL_05ac: Expected O, but got I4
		//IL_0514: Expected O, but got I
		//IL_0a6e: Expected O, but got I4
		//IL_0a77: Expected O, but got I4
		//IL_0a2c: Expected O, but got I4
		//IL_0a3e: Expected O, but got I4
		//IL_0a46: Expected O, but got I4
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Expected O, but got Unknown
		//IL_08e4: Expected O, but got I4
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_0545: Expected O, but got I
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (!HasClan)
		{
			return;
		}
		ClanFeedListView clanFeedListView = listView;
		bool flag = (object)listView == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		List<object>.Enumerator enumerator2 = (List<object>.Enumerator)0;
		ClanFeedEventDataHolder clanFeedEventDataHolder = null;
		List<object> list;
		Room room = default(Room);
		bool flag13 = default(bool);
		int num4 = default(int);
		Func<object, int> func;
		object obj17;
		DateTime dateTime;
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		if (!flag)
		{
			nint num = (nint)clanFeedListView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v9 (Il2CppClass<ClanFeedListView>)+298]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v9 (Il2CppClass<ClanFeedListView>)+2A0]");
			clanFeedEventDataHolder = (ClanFeedEventDataHolder)0;
			List<ClanFeedEventDataHolder> data = listView.data;
			if (data == null)
			{
				return;
			}
			bool flag2 = (object)listView == null;
			enumerator = (List<object>.Enumerator)0;
			enumerator2 = (List<object>.Enumerator)0;
			if (!flag2)
			{
				if (!((UiListView<object, object>)(object)listView).TemplatesReady)
				{
					return;
				}
				string clanTag = ClanTag;
				IEnumerable<Room> source = SFS.ClanGameRooms(clanTag);
				object obj4 = (nint)0 + (nint)2624;
				list = Enumerable.ToList((IEnumerable<object>)source);
				object obj5 = typeof(CardUtils.<>c) + 720;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v30+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v30+B8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v61+48]");
				func = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v61+48]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				object obj12 = default(object);
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v30+E4]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v30+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj11 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v67+B8]");
						obj8 = 0;
					}
					obj12 = obj8;
					object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3176;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj14 = (nint)0 + (nint)3680;
					Func<object, int> func2 = default(Func<object, int>);
					func2..ctor(obj8, (IntPtr)obj14);
					object obj15 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v66+B8]");
					object obj16 = (nint)0 + (nint)72;
					obj16 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj17 = 0;
					func = func2;
				}
				object obj18 = (nint)0 + (nint)3960;
				dateTime = (DateTime)obj18;
				IEnumerable<int> source2 = Enumerable.Select(list, func);
				object obj19 = (nint)0 + (nint)2200;
				clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj19;
				List<int> list2 = Enumerable.ToList(source2);
				bool flag6 = obj2 == null;
				enumerator = (List<object>.Enumerator)0;
				enumerator2 = (List<object>.Enumerator)0;
				string text = clanTag;
				if (!flag6)
				{
					object obj20 = obj2 + 16;
					obj20 = list2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag7 = SFS.IsSubscribedToGroup(clanTag);
					bool flag8 = !flag7;
					enumerator2 = (List<object>.Enumerator)0;
					text = clanTag;
					clanFeedEventDataHolder = null;
					if (flag8)
					{
						goto IL_0631;
					}
					ClanFeedListView clanFeedListView2 = listView;
					bool flag9 = (object)listView == null;
					enumerator = (List<object>.Enumerator)0;
					enumerator2 = (List<object>.Enumerator)0;
					text = clanTag;
					clanFeedEventDataHolder = null;
					if (!flag9)
					{
						nint num2 = (nint)clanFeedListView2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v37 (Il2CppClass<ClanFeedListView>)+298]");
						obj3 = 0;
						IEnumerable<object> data2 = listView.data;
						text = (string)(obj2 + 24);
						Func<object, bool> predicate = (Func<object, bool>)(object)text;
						bool flag10 = text == null;
						object obj21 = !flag10;
						IEnumerable<object> enumerable = (IEnumerable<object>)obj12;
						Func<object, bool> func3 = (Func<object, bool>)(object)func;
						if (obj21 == null)
						{
							object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 624;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj23 = (nint)0 + (nint)3744;
							Func<object, bool> func4 = default(Func<object, bool>);
							func4..ctor(obj2, (IntPtr)obj23);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							enumerable = data2;
							obj17 = 0;
							func3 = func4;
							predicate = func4;
						}
						object obj24 = (nint)0 + (nint)3312;
						dateTime = (DateTime)obj24;
						IEnumerable<object> source3 = Enumerable.Where(data2, predicate);
						object obj25 = (nint)0 + (nint)1952;
						clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj25;
						List<object> list3 = Enumerable.ToList(source3);
						bool flag11 = list3 == null;
						enumerator = (List<object>.Enumerator)0;
						enumerator2 = (List<object>.Enumerator)0;
						obj12 = enumerable;
						func = (Func<object, int>)(object)func3;
						if (!flag11)
						{
							List<object>.Enumerator enumerator3 = list3.GetEnumerator();
							func = (Func<object, int>)((nint)0 + (nint)3968);
							obj12 = typeof(RegisteredWaitHandle) + 1376;
							while (enumerator2.MoveNext())
							{
								if (room == null)
								{
									goto IL_09b5;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ stack_-98 (Sfs2X.Entities.Room)+28]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ stack_-98 (Sfs2X.Entities.Room)+28]");
								if ((nint)0 == 0)
								{
									goto IL_09e7;
								}
								nint num3 = (nint)text;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v52 (Il2CppClass<System.String>)+12E]");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v52 (Il2CppClass<System.String>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_0599;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v52 (Il2CppClass<System.String>)+B0]");
								object obj26 = (nint)0 + (nint)8;
								bool flag12 = flag13;
								object obj28;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X10_v18-8]");
									object obj27 = 0 - obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X10_v18-8]");
									if (0 == (nint)obj12)
									{
										break;
									}
									obj28 = obj26 + 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v52 (Il2CppClass<System.String>)+12E]");
									obj3 = -1;
									obj27 = obj3 - 1;
									bool flag14 = obj27 == null;
									flag13 = (nint)obj3 != 1;
									flag12 = flag13;
									obj26 = obj28;
									if (flag13)
									{
										continue;
									}
									goto IL_0599;
								}
								obj3 = obj26;
								object obj29 = num3 + obj26;
								object obj30 = obj29 + 312;
								flag13 = flag12;
								obj28 = obj26;
								goto IL_0d03;
								IL_0599:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
								dateTime = (DateTime)0;
								goto IL_0d03;
								IL_0d03:
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v794 @ X0_v79] (should have been resolved before IL gen)");
								if ((object)listView != null)
								{
									listView.RemoveLiveRoomById(num4);
									continue;
								}
								goto IL_0a19;
							}
							object obj31 = (nint)0 + (nint)3960;
							clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj31;
							enumerator2.Dispose();
							enumerator4 = enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							goto IL_0631;
						}
					}
				}
			}
		}
		goto IL_0b55;
		IL_092d:
		if ((object)listView != null)
		{
			listView.SeedPinFromData();
			return;
		}
		goto IL_0b55;
		IL_09e7:
		NullReferenceException ex = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		clanFeedEventDataHolder = (ClanFeedEventDataHolder)(object)func;
		goto IL_0b55;
		IL_0985:
		NullReferenceException ex2 = new NullReferenceException();
		enumerator = enumerator5;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		int num5 = default(int);
		clanFeedEventDataHolder = (ClanFeedEventDataHolder)num5;
		goto IL_0b55;
		IL_09b5:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		clanFeedEventDataHolder = (ClanFeedEventDataHolder)(object)func;
		goto IL_0b55;
		IL_0b55:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag15 = (nint)clanFeedEventDataHolder != 1;
		NullReferenceException ex5 = ex4;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj32 = (nint)0 + (nint)760;
			clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj32;
			enumerator.Dispose();
			object obj33 = default(object);
			bool flag16 = obj33 == null;
			enumerator5 = (List<object>.Enumerator)obj33;
			if (flag16)
			{
				goto IL_092d;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			enumerator5 = (List<object>.Enumerator)obj33;
			ex5 = (NullReferenceException)(object)ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223C8F0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0a19:
		NullReferenceException ex7 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		clanFeedEventDataHolder = (ClanFeedEventDataHolder)num4;
		goto IL_0b55;
		IL_095d:
		NullReferenceException ex8 = new NullReferenceException();
		enumerator = enumerator5;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		goto IL_0b55;
		IL_0a4b:
		NullReferenceException ex9 = new NullReferenceException();
		enumerator = enumerator5;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		obj17 = 0;
		DateTime now;
		dateTime = now;
		ClanFeedEventDataHolder clanFeedEventDataHolder2;
		clanFeedEventDataHolder = clanFeedEventDataHolder2;
		goto IL_0b55;
		IL_0631:
		bool flag17 = list == null;
		enumerator = (List<object>.Enumerator)0;
		if (!flag17)
		{
			List<object>.Enumerator enumerator6 = list.GetEnumerator();
			func = (Func<object, int>)((nint)0 + (nint)768);
			object obj12 = typeof(RegisteredWaitHandle) + 1376;
			object obj5 = typeof(DataRelation) + 712;
			List<object>.Enumerator enumerator7 = default(List<object>.Enumerator);
			while (true)
			{
				clanFeedEventDataHolder = (ClanFeedEventDataHolder)(object)func;
				if (!enumerator7.MoveNext())
				{
					break;
				}
				if (room == null)
				{
					goto IL_095d;
				}
				nint num6 = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v31 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v31 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0794;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v31 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj34 = (nint)0 + (nint)8;
				bool flag18 = flag13;
				object obj28;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X10_v11-8]");
					object obj27 = 0 - obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X10_v11-8]");
					if (0 == (nint)obj12)
					{
						break;
					}
					obj28 = obj34 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v31 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					obj3 = -1;
					obj27 = obj3 - 1;
					bool flag14 = obj27 == null;
					flag13 = (nint)obj3 != 1;
					flag18 = flag13;
					obj34 = obj28;
					if (flag13)
					{
						continue;
					}
					goto IL_0794;
				}
				obj3 = obj34;
				object obj35 = num6 + obj34;
				object obj36 = obj35 + 312;
				flag13 = flag18;
				obj28 = obj34;
				goto IL_0d96;
				IL_0d96:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v720 @ X0_v49] (should have been resolved before IL gen)");
				if ((object)listView == null)
				{
					goto IL_0985;
				}
				bool flag19 = listView.HasLiveRoom(num5);
				bool flag20 = !flag19;
				object obj37 = !flag20;
				if (obj37 != null)
				{
					continue;
				}
				string text = (string)_index;
				int index = _index + 1;
				_index = index;
				object obj38 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v55+E4]");
				bool flag21 = (nint)0 == 0;
				object obj39 = !flag21;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				now = DateTime.Now;
				clanFeedEventDataHolder2 = ClanFeedEventDataHolder.LiveGame((int)text, room, now);
				if ((object)listView != null)
				{
					listView.AddFeed(clanFeedEventDataHolder2);
					obj17 = 0;
					dateTime = now;
					continue;
				}
				goto IL_0a4b;
				IL_0794:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				dateTime = (DateTime)0;
				goto IL_0d96;
			}
			object obj40 = (nint)0 + (nint)760;
			clanFeedEventDataHolder = (ClanFeedEventDataHolder)obj40;
			enumerator7.Dispose();
			enumerator = enumerator5;
			enumerator4 = enumerator5;
			enumerator5 = (List<object>.Enumerator)0;
			goto IL_092d;
		}
		goto IL_0b55;
	}

	private void OnClanRoomCreated(Room room)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003a: Expected I, but got O
		//IL_004a: Expected O, but got I
		//IL_01f1: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		bool hasClan = HasClan;
		if (room == null || !hasClan)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X10_v6-8]");
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
			goto IL_00c6;
		}
		object obj4 = obj3 + 3;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_01b3;
		IL_00c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01b3;
		IL_01b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X0_v4] (should have been resolved before IL gen)");
		string clanTag = ClanTag;
		string text = default(string);
		bool flag = text != clanTag;
		bool flag2 = !flag;
		object obj7 = !flag2;
		if (obj7 == null && ((UiListView<object, object>)(object)listView).TemplatesReady)
		{
			if (SFSKammelnaRoomExtensions.IsTournamentHub(room))
			{
				AddLiveTournamentCard(room);
			}
			else
			{
				AddLiveGameCard(room);
			}
		}
	}

	private void OnClanGroupSubscribed(string groupTag)
	{
		if (HasClan)
		{
			string clanTag = ClanTag;
			if (!(groupTag != clanTag))
			{
				SyncTournamentCards();
				SyncClanGameCards();
			}
		}
	}

	private void AddLiveTournamentCard(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v6-8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ X0_v21] (should have been resolved before IL gen)");
		goto IL_011a;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X0_v18] (should have been resolved before IL gen)");
		bool flag = (object)listView == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011a;
		IL_011a:
		int roomId = default(int);
		bool flag2 = listView.HasLiveRoom(roomId);
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			int index = _index + 1;
			_index = index;
			object obj8 = typeof(DataRelation) + 712;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			ClanFeedEventDataHolder datum = ClanFeedEventDataHolder.LiveTournament(_index, room, now);
			listView.AddFeed(datum);
		}
		listView.SeedPinFromData();
	}

	private void AddLiveGameCard(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6-8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X0_v20] (should have been resolved before IL gen)");
		goto IL_011a;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X0_v17] (should have been resolved before IL gen)");
		bool flag = (object)listView == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011a;
		IL_011a:
		int roomId = default(int);
		if (!listView.HasLiveRoom(roomId))
		{
			int index = _index + 1;
			_index = index;
			object obj7 = typeof(DataRelation) + 712;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			ClanFeedEventDataHolder datum = ClanFeedEventDataHolder.LiveGame(_index, room, now);
			listView.AddFeed(datum);
			listView.SeedPinFromData();
		}
	}

	private void OnClanRoomRemoved(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00f3: Expected I, but got O
		//IL_0103: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_013e: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		if (room == null)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X10_v13-8]");
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
		object obj4 = obj3 + 3;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_0241;
		IL_017f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ X0_v14] (should have been resolved before IL gen)");
		goto IL_0199;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0241;
		IL_0241:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ X0_v3] (should have been resolved before IL gen)");
		string clanTag = ClanTag;
		string text = default(string);
		if (text != clanTag)
		{
			return;
		}
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_017f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_017f;
		}
		object obj9 = num2 + obj8;
		object obj10 = obj9 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v295 @ X0_v17] (should have been resolved before IL gen)");
		bool flag = (object)listView == null;
		object obj11 = !flag;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0199;
		IL_0199:
		int roomId = default(int);
		listView.RemoveLiveRoomById(roomId);
	}

	private void HandleFeedAdded(ClanFeedModel feed)
	{
		//IL_002e: Expected I8, but got O
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0060: Expected I, but got O
		//IL_0089: Expected O, but got I4
		//IL_009a: Expected I8, but got O
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017e: Expected I, but got O
		//IL_01a7: Expected O, but got I4
		//IL_00c5: Expected O, but got I
		//IL_00e6: Expected I8, but got O
		//IL_01e3: Expected O, but got I
		//IL_013c: Expected I8, but got I
		//IL_014c: Expected I8, but got I
		//IL_0222: Expected I8, but got I4
		//IL_022b: Expected I8, but got I4
		ClanFeedData data = feed.Data;
		bool flag = feed.Data == null;
		long num = (long)feed;
		if (!flag)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 136;
			object obj2 = obj;
			nint num2 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X10_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X9_v6+130]");
			bool flag2 = num3 < 0;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			long num4 = (long)feed;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X10_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X9_v6+130]");
				object obj5 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v7-8]");
				bool flag3 = 0 != (nint)obj2;
				num4 = (long)feed;
				if (!flag3)
				{
					ClanFeedListView clanFeedListView = listView;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v8 (Kammelna.Server.Models.Clans.ClanFeedData)+40]");
					clanFeedListView.ApplyVaultSupportProgress(0);
					data = feed.Data;
					bool flag4 = feed.Data == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v8 (Kammelna.Server.Models.Clans.ClanFeedData)+40]");
					num4 = 0L;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v8 (Kammelna.Server.Models.Clans.ClanFeedData)+40]");
					num = 0L;
					if (flag4)
					{
						goto IL_0230;
					}
				}
			}
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1392;
			object obj7 = obj6;
			nint num6 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v9 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v9+130]");
			bool flag5 = num7 < 0;
			object obj8 = !flag5;
			object obj9 = ~obj8;
			num = num4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v9 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v9+130]");
				object obj10 = num8 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v11-8]");
				bool flag6 = 0 != (nint)obj7;
				num = num4;
				if (!flag6)
				{
					listView.RemoveFeedById(-1L);
					num = -1L;
				}
			}
		}
		goto IL_0230;
		IL_0230:
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1176;
		int index = _index + 1;
		_index = index;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanFeedEventDataHolder clanFeedEventDataHolder = default(ClanFeedEventDataHolder);
		clanFeedEventDataHolder..ctor(_index, feed);
		listView.AddFeed(clanFeedEventDataHolder);
	}

	private void HandleFeedRemoved(ClanFeedRemovedModel payload)
	{
		listView.RemoveFeedById(payload.FeedId);
	}

	private void HandlePinChanged(ClanFeedPinChangeModel payload)
	{
		listView.ApplyPinChangeById(payload.FeedId);
	}

	private ClanFeedEventDataHolder <LoadFeed>b__17_2(ClanFeedModel e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1176;
		int index = _index + 1;
		_index = index;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanFeedEventDataHolder clanFeedEventDataHolder = default(ClanFeedEventDataHolder);
		clanFeedEventDataHolder..ctor(_index, e);
		return clanFeedEventDataHolder;
	}
}
