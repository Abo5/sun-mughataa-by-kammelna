using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using KammelnaOffline.Common;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace KammelnaOffline.Baloot;

public class BalootGameController : OfflineGameController
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Card, bool> <>9__26_0;

		public static Func<BalootOfflinePlayer, List<Card>> <>9__26_1;

		public static Func<BalootOfflinePlayer, List<Card>> <>9__26_2;

		public static Func<BalootOfflinePlayer, bool> <>9__30_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2608;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <OnPlayCard>b__26_0(Card c)
		{
			bool flag = c == null;
			return !flag;
		}

		internal List<Card> <OnPlayCard>b__26_1(BalootOfflinePlayer player)
		{
			if (player != null)
			{
				return ((OfflinePlayer)player).<AllCards>k__BackingField;
			}
			return (List<Card>)(object)new NullReferenceException();
		}

		internal List<Card> <OnPlayCard>b__26_2(BalootOfflinePlayer player)
		{
			if (player != null)
			{
				return ((OfflinePlayer)player).<AllCards>k__BackingField;
			}
			return (List<Card>)(object)new NullReferenceException();
		}

		internal bool <GetPlayableCards>b__30_0(BalootOfflinePlayer player)
		{
			//IL_0035: Expected I4, but got O
			if (player != null)
			{
				return player.HasEkkah;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public BalootGameController <>4__this;

		public int[] biddersState;

		internal void <OnStartRound>b__0()
		{
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			BalootGameController balootGameController = <>4__this;
			int[] array = biddersState;
			nint num = (nint)balootGameController;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+348]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+350]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public SFSArray projects;

		public SFSArray declaredProjects;

		internal void <BuildRoundState>b__0(BalootOfflinePlayer _)
		{
			//IL_000c: Expected O, but got I
			//IL_0022: Expected O, but got I
			//IL_01fd: Expected O, but got I
			//IL_021f: Expected O, but got I4
			//IL_00a8: Expected O, but got I
			//IL_00be: Expected O, but got I
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00eb: Expected O, but got I
			//IL_0061: Expected O, but got I
			//IL_0301: Expected O, but got I4
			//IL_0259: Expected O, but got I
			//IL_0269: Expected O, but got I
			//IL_027f: Expected O, but got I
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Expected O, but got Unknown
			//IL_02a7: Expected O, but got I4
			//IL_02c7: Expected O, but got I
			//IL_014e: Expected O, but got I
			//IL_015e: Expected O, but got I
			//IL_0174: Expected O, but got I
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_01a1: Expected O, but got I
			//IL_03d1: Expected O, but got I4
			//IL_0339: Expected O, but got I
			//IL_0349: Expected O, but got I
			//IL_035f: Expected O, but got I
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Expected O, but got Unknown
			//IL_0387: Expected O, but got I4
			//IL_039f: Expected O, but got I
			//IL_01c7: Expected O, but got I
			object obj = (nint)0 + (nint)3168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E809D]");
			object obj2 = (nint)0 & (nint)1;
			SFSArray sFSArray;
			SFSArray sFSArray2;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				sFSArray = projects;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
				bool flag = (nint)0 == 0;
				obj5 = obj3;
				sFSArray2 = projects;
				if (!flag)
				{
					goto IL_0098;
				}
			}
			else
			{
				int num = 1;
				sFSArray = projects;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj5 = obj3;
				sFSArray2 = projects;
				if (obj6 != null)
				{
					goto IL_0098;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X20_v5+38]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+10]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			obj3 = obj5;
			sFSArray = sFSArray2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+10]");
			object obj12 = 0;
			if (obj11 != null)
			{
				goto IL_0109;
			}
			goto IL_02d5;
			IL_01b7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v17+B8]");
			object val = 0;
			sFSArray.AddIntArray((int[])val);
			return;
			IL_03ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			bool flag4 = sFSArray2 == null;
			object obj13 = !flag4;
			sFSArray = sFSArray2;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_01b7;
			IL_013e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v20+10]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v20+10]");
			object obj16 = (nint)0 + (nint)309;
			object obj17 = obj16 & 1;
			bool flag5 = obj17 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v20+10]");
			object obj18 = 0;
			sFSArray2 = sFSArray;
			if (!flag5)
			{
				goto IL_01b7;
			}
			goto IL_03ad;
			IL_0098:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v25+10]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v25+10]");
			object obj19 = (nint)0 + (nint)309;
			object obj20 = obj19 & 1;
			bool flag6 = obj20 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v25+10]");
			obj12 = 0;
			obj5 = obj3;
			sFSArray2 = sFSArray;
			if (!flag6)
			{
				goto IL_0109;
			}
			goto IL_02d5;
			IL_02d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			obj3 = obj5;
			sFSArray = sFSArray2;
			if (obj21 != null)
			{
				goto IL_013e;
			}
			goto IL_031f;
			IL_0109:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+E4]");
			bool flag8 = (nint)0 == 0;
			obj5 = obj3;
			sFSArray2 = sFSArray;
			if (!flag8)
			{
				goto IL_013e;
			}
			goto IL_031f;
			IL_031f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X20_v5+38]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5+10]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5+10]");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag9 = obj24 == null;
			object obj25 = !flag9;
			sFSArray = sFSArray2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5+10]");
			obj18 = 0;
			if (obj25 != null)
			{
				goto IL_01b7;
			}
			goto IL_03ad;
		}

		internal void <BuildRoundState>b__1(BalootOfflinePlayer _)
		{
			//IL_000c: Expected O, but got I
			//IL_0022: Expected O, but got I
			//IL_01fd: Expected O, but got I
			//IL_021f: Expected O, but got I4
			//IL_00a8: Expected O, but got I
			//IL_00be: Expected O, but got I
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00eb: Expected O, but got I
			//IL_0061: Expected O, but got I
			//IL_0301: Expected O, but got I4
			//IL_0259: Expected O, but got I
			//IL_0269: Expected O, but got I
			//IL_027f: Expected O, but got I
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Expected O, but got Unknown
			//IL_02a7: Expected O, but got I4
			//IL_02c7: Expected O, but got I
			//IL_014e: Expected O, but got I
			//IL_015e: Expected O, but got I
			//IL_0174: Expected O, but got I
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_01a1: Expected O, but got I
			//IL_03d1: Expected O, but got I4
			//IL_0339: Expected O, but got I
			//IL_0349: Expected O, but got I
			//IL_035f: Expected O, but got I
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Expected O, but got Unknown
			//IL_0387: Expected O, but got I4
			//IL_039f: Expected O, but got I
			//IL_01c7: Expected O, but got I
			object obj = (nint)0 + (nint)3336;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E809E]");
			object obj2 = (nint)0 & (nint)1;
			SFSArray sFSArray;
			SFSArray sFSArray2;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				sFSArray = declaredProjects;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
				bool flag = (nint)0 == 0;
				obj5 = obj3;
				sFSArray2 = declaredProjects;
				if (!flag)
				{
					goto IL_0098;
				}
			}
			else
			{
				int num = 1;
				sFSArray = declaredProjects;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj5 = obj3;
				sFSArray2 = declaredProjects;
				if (obj6 != null)
				{
					goto IL_0098;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X20_v5+38]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+10]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			obj3 = obj5;
			sFSArray = sFSArray2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+10]");
			object obj12 = 0;
			if (obj11 != null)
			{
				goto IL_0109;
			}
			goto IL_02d5;
			IL_01b7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v17+B8]");
			object val = 0;
			sFSArray.AddUtfStringArray((string[])val);
			return;
			IL_03ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			bool flag4 = sFSArray2 == null;
			object obj13 = !flag4;
			sFSArray = sFSArray2;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_01b7;
			IL_013e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v12+38]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v20+10]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v20+10]");
			object obj16 = (nint)0 + (nint)309;
			object obj17 = obj16 & 1;
			bool flag5 = obj17 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v20+10]");
			object obj18 = 0;
			sFSArray2 = sFSArray;
			if (!flag5)
			{
				goto IL_01b7;
			}
			goto IL_03ad;
			IL_0098:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v25+10]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v25+10]");
			object obj19 = (nint)0 + (nint)309;
			object obj20 = obj19 & 1;
			bool flag6 = obj20 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v25+10]");
			obj12 = 0;
			obj5 = obj3;
			sFSArray2 = sFSArray;
			if (!flag6)
			{
				goto IL_0109;
			}
			goto IL_02d5;
			IL_02d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			obj3 = obj5;
			sFSArray = sFSArray2;
			if (obj21 != null)
			{
				goto IL_013e;
			}
			goto IL_031f;
			IL_0109:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+E4]");
			bool flag8 = (nint)0 == 0;
			obj5 = obj3;
			sFSArray2 = sFSArray;
			if (!flag8)
			{
				goto IL_013e;
			}
			goto IL_031f;
			IL_031f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X20_v5+38]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5+10]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5+10]");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag9 = obj24 == null;
			object obj25 = !flag9;
			sFSArray = sFSArray2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5+10]");
			obj18 = 0;
			if (obj25 != null)
			{
				goto IL_01b7;
			}
			goto IL_03ad;
		}
	}

	public Suit CurrentSuit;

	public Card FloorCard;

	public int BestProjectTeam;

	public BalootGame.BalootGameMode GameMode;

	private BalootGame.BalootExtraGameMode ExtraGameMode;

	public bool IsHokomClose;

	public bool BalootProjectShown;

	public bool EkkahProjectShown;

	public Suit TrumpSuit;

	private const int WinningScore = 152;

	private int LastMoveWinner;

	public new BalootOfflinePlayer[] Players
	{
		get
		{
			IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
			return (BalootOfflinePlayer[])Enumerable.ToArray(source);
		}
	}

	protected new BalootPlayingManager PlayingManager
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			BalootPlayingManager playingManager = (BalootPlayingManager)base.PlayingManager;
			if (base.PlayingManager != null)
			{
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2024;
				object obj2 = obj;
				nint num = (nint)playingManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (BalootPlayingManager)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (BalootPlayingManager)base.PlayingManager;
		}
	}

	protected new BalootBiddingManager BiddingManager
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			BalootBiddingManager biddingManager = (BalootBiddingManager)base.BiddingManager;
			if (base.BiddingManager != null)
			{
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1952;
				object obj2 = obj;
				nint num = (nint)biddingManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KammelnaOffline.Baloot.BalootBiddingManager>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KammelnaOffline.Baloot.BalootBiddingManager>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (BalootBiddingManager)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (BalootBiddingManager)base.BiddingManager;
		}
	}

	protected override OfflinePlayer CreatePlayer(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BalootOfflinePlayer balootOfflinePlayer = default(BalootOfflinePlayer);
		balootOfflinePlayer..ctor(index);
		return balootOfflinePlayer;
	}

	protected override AbstractAiLogic CreateAiLogic()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AbstractAiLogic abstractAiLogic = default(AbstractAiLogic);
		abstractAiLogic..ctor();
		object obj2 = abstractAiLogic + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return abstractAiLogic;
	}

	protected override void OnStartRound()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_00c3: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_015e: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01db: Expected O, but got I4
		//IL_01f9: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_0276: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_02d0: Expected O, but got I
		//IL_0311: Expected O, but got I4
		//IL_032f: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_0376: Expected O, but got I
		//IL_03ad: Expected O, but got I
		//IL_03d2: Expected O, but got I
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_041c: Expected O, but got I4
		//IL_0b25: Expected O, but got I4
		//IL_0449: Expected O, but got I
		//IL_046e: Expected O, but got I
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0b55: Expected O, but got I4
		//IL_04d1: Expected O, but got I
		//IL_04f6: Expected O, but got I
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0b85: Expected O, but got I4
		//IL_0559: Expected O, but got I
		//IL_057e: Expected O, but got I
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_0bb5: Expected O, but got I4
		//IL_0bcf: Expected O, but got I4
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected O, but got Unknown
		//IL_0bf7: Expected O, but got I4
		//IL_05e1: Expected O, but got I
		//IL_0606: Expected O, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected O, but got Unknown
		//IL_0922: Expected O, but got I
		//IL_0933: Expected I, but got O
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_0976: Expected O, but got I4
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected O, but got Unknown
		//IL_074d: Expected O, but got I
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected O, but got Unknown
		//IL_0774: Expected O, but got I4
		//IL_0c31: Expected O, but got I4
		//IL_0823: Expected O, but got I4
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected O, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected O, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected O, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07ca: Expected O, but got I4
		//IL_08d2: Unsupported input type for neg.
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected O, but got Unknown
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected O, but got Unknown
		//IL_085e: Expected O, but got I4
		//IL_0d25: Expected O, but got I4
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_080c: Expected O, but got I4
		//IL_08f3: Expected O, but got I4
		//IL_0c99: Expected O, but got I
		//IL_0ca9: Expected O, but got I
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected O, but got Unknown
		//IL_0875: Expected O, but got I4
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected O, but got Unknown
		//IL_08e5: Expected O, but got I4
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected O, but got Unknown
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df2: Expected O, but got Unknown
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Expected O, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj60 = default(object);
			object obj87 = default(object);
			object obj88 = default(object);
			object obj90 = default(object);
			object obj83 = default(object);
			object obj86 = default(object);
			object obj85 = default(object);
			Action action = default(Action);
			while (true)
			{
				CardDistributionFirstPhase();
				object obj4 = 4;
				object obj50;
				while (true)
				{
					IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
					object[] array = Enumerable.ToArray(source);
					if (array == null)
					{
						break;
					}
					object obj5 = obj4 - 4;
					bool flag = (nint)obj5 < array.Length;
					object obj6 = !flag;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v17 (System.Object[])+v179 @ X24_v5*8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v17 (System.Object[])+v179 @ X24_v5*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v11 (System.Object)+18]");
						object obj8 = Enumerable.ElementAt((IEnumerable<object>)0, 0);
						if (obj8 == null)
						{
							break;
						}
						IEnumerable<object> source2 = Enumerable.Cast<object>(base.Players);
						object[] array2 = Enumerable.ToArray(source2);
						if (array2 == null)
						{
							break;
						}
						bool flag2 = (nint)obj5 < array2.Length;
						object obj9 = !flag2;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v23 (System.Object[])+v179 @ X24_v5*8]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v23 (System.Object[])+v179 @ X24_v5*8]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17 (System.Object)+18]");
							object obj11 = Enumerable.ElementAt((IEnumerable<object>)0, 1);
							if (obj11 == null)
							{
								break;
							}
							IEnumerable<object> source3 = Enumerable.Cast<object>(base.Players);
							object[] array3 = Enumerable.ToArray(source3);
							if (array3 == null)
							{
								break;
							}
							bool flag3 = (nint)obj5 < array3.Length;
							object obj12 = !flag3;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v29 (System.Object[])+v179 @ X24_v5*8]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v29 (System.Object[])+v179 @ X24_v5*8]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v23 (System.Object)+18]");
								object obj14 = Enumerable.ElementAt((IEnumerable<object>)0, 2);
								if (obj14 == null)
								{
									break;
								}
								IEnumerable<object> source4 = Enumerable.Cast<object>(base.Players);
								object[] array4 = Enumerable.ToArray(source4);
								if (array4 == null)
								{
									break;
								}
								bool flag4 = (nint)obj5 < array4.Length;
								object obj15 = !flag4;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v35 (System.Object[])+v179 @ X24_v5*8]");
									object obj16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v35 (System.Object[])+v179 @ X24_v5*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v29 (System.Object)+18]");
									object obj17 = Enumerable.ElementAt((IEnumerable<object>)0, 3);
									if (obj17 == null)
									{
										break;
									}
									IEnumerable<object> source5 = Enumerable.Cast<object>(base.Players);
									object[] array5 = Enumerable.ToArray(source5);
									if (array5 == null)
									{
										break;
									}
									bool flag5 = (nint)obj5 < array5.Length;
									object obj18 = !flag5;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v41 (System.Object[])+v179 @ X24_v5*8]");
										object obj19 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v41 (System.Object[])+v179 @ X24_v5*8]");
										if ((nint)0 == 0)
										{
											break;
										}
										object obj20 = (nint)0 + (nint)3736;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v35 (System.Object)+18]");
										object obj21 = Enumerable.ElementAt((IEnumerable<object>)0, 4);
										if (obj21 == null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v43 (System.Object)+10]");
										object obj22 = -8;
										bool flag6 = (nint)obj22 < 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v43 (System.Object)+10]");
										object obj23 = (nint)0 ^ (nint)8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v43 (System.Object)+10]");
										object obj24 = 0 ^ obj22;
										object obj25 = obj23 & obj24;
										bool flag7 = (nint)obj25 < 0;
										bool flag8 = flag6 == flag7;
										object obj26 = !flag8;
										object obj27 = ~obj26;
										bool flag9;
										bool flag10;
										if (obj27 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v37 (System.Object)+10]");
											object obj28 = -8;
											flag9 = (nint)obj28 < 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v37 (System.Object)+10]");
											object obj29 = (nint)0 ^ (nint)8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v37 (System.Object)+10]");
											object obj30 = 0 ^ obj28;
											object obj31 = obj29 & obj30;
											flag10 = (nint)obj31 < 0;
										}
										else
										{
											flag10 = false;
											flag9 = false;
										}
										bool flag11 = flag9 == flag10;
										object obj32 = !flag11;
										object obj33 = ~obj32;
										bool flag12;
										bool flag13;
										if (obj33 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v31 (System.Object)+10]");
											object obj34 = -8;
											flag12 = (nint)obj34 < 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v31 (System.Object)+10]");
											object obj35 = (nint)0 ^ (nint)8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v31 (System.Object)+10]");
											object obj36 = 0 ^ obj34;
											object obj37 = obj35 & obj36;
											flag13 = (nint)obj37 < 0;
										}
										else
										{
											flag13 = false;
											flag12 = false;
										}
										bool flag14 = flag12 == flag13;
										object obj38 = !flag14;
										object obj39 = ~obj38;
										bool flag15;
										bool flag16;
										if (obj39 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v25 (System.Object)+10]");
											object obj40 = -8;
											flag15 = (nint)obj40 < 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v25 (System.Object)+10]");
											object obj41 = (nint)0 ^ (nint)8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v25 (System.Object)+10]");
											object obj42 = 0 ^ obj40;
											object obj43 = obj41 & obj42;
											flag16 = (nint)obj43 < 0;
										}
										else
										{
											flag16 = false;
											flag15 = false;
										}
										bool flag17 = flag15 == flag16;
										object obj44 = !flag17;
										object obj45 = ~obj44;
										bool flag18;
										bool flag19;
										if (obj45 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v19 (System.Object)+10]");
											object obj46 = -8;
											flag18 = (nint)obj46 < 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v19 (System.Object)+10]");
											object obj47 = (nint)0 ^ (nint)8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v19 (System.Object)+10]");
											object obj48 = 0 ^ obj46;
											object obj49 = obj47 & obj48;
											flag19 = (nint)obj49 < 0;
										}
										else
										{
											flag19 = false;
											flag18 = false;
										}
										bool flag20 = flag18 == flag19;
										obj50 = !flag20;
										bool flag21 = (nint)obj5 < 2;
										object obj51 = !flag21;
										object obj52 = obj5 - 2;
										bool flag22 = obj52 == null;
										object obj53 = !flag22;
										object obj54 = obj51 & obj53;
										if (obj54 == null)
										{
											obj4++;
											object obj55 = obj50 & 1;
											if (obj55 == null)
											{
												continue;
											}
										}
										goto IL_003d;
									}
								}
							}
						}
					}
					goto IL_09b8;
				}
				break;
				IL_081a:
				object obj56 = 0;
				goto IL_087f;
				IL_003d:
				object obj57 = obj50 & 1;
				if (obj57 != null)
				{
					continue;
				}
				object obj58 = typeof(TypeConverter<ushort, char>) + 3048;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj59 = obj2 + 24;
				obj59 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj61 = obj59;
				if (obj59 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X13_v3+18]");
				object obj62;
				object obj64;
				if ((nint)0 >= (nint)1)
				{
					obj62 = this + 16;
					object obj63 = obj59 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X13_v3+18]");
					obj64 = (nint)0 & (nint)0x7FFFFFFF;
					object obj65 = obj64 - 1;
					bool flag23 = obj65 < obj64;
					object obj66 = !flag23;
					object obj67 = ~obj66;
					object obj68 = ~obj67;
					if (obj68 != null)
					{
						obj65 = obj64;
					}
					bool flag24 = (nint)obj65 < 8;
					object obj69 = !flag24;
					object obj70 = ~obj69;
					if (obj70 != null)
					{
						goto IL_081a;
					}
					object obj71 = this + 20;
					bool flag25 = obj63 < obj71;
					object obj72 = !flag25;
					if (obj72 == null)
					{
						object obj73 = obj59 + obj65;
						object obj74 = obj73 + 36;
						bool flag26 = obj62 < obj74;
						object obj75 = !flag26;
						if (obj75 == null)
						{
							goto IL_081a;
						}
					}
					object obj76 = obj65 + 1;
					object obj77 = obj76 & 7;
					bool flag27 = obj77 == null;
					object obj78 = !flag27;
					if (obj78 == null)
					{
						obj77 = 8;
					}
					if (0 < (nint)obj62)
					{
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					obj56 = obj76 - obj77;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70185F0]");
					object obj79 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6FBFCB0]");
					object obj80 = 0;
					object obj81 = obj59 + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					object obj82 = obj83;
					object obj84 = obj56;
					obj82 = obj83;
					obj80 = obj85;
					obj79 = obj86;
					obj84 = obj87;
					obj81 = obj88;
					do
					{
						object obj89 = obj80 + obj90;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMEQ not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMEQ not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMEQ not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMEQ not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
						object obj91 = ~obj82;
						object obj92 = 3 & obj91;
						object obj93 = obj92 - obj82;
						object obj94 = ~obj89;
						obj83 = 3 & obj94;
						object obj95 = obj83 - obj89;
						obj81 = obj95;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						obj86 = obj79 + obj95;
						obj85 = obj80 + obj95;
						obj81 += 32;
						obj84 -= 8;
					}
					while ((nint)obj84 != 8);
					goto IL_087f;
				}
				goto IL_08f8;
				IL_08f8:
				object obj96 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj97 = (nint)0 + (nint)784;
				action..ctor(obj2, (IntPtr)obj97);
				object obj98 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj99 = obj98;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v50+E4]");
				bool flag28 = (nint)0 == 0;
				object obj100 = !flag28;
				if (obj100 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Coroutine coroutine = CoroutineDummy.WaitForSeconds(2f, action);
				return;
				IL_087f:
				do
				{
					object obj101 = 0 - obj62;
					object obj102 = obj101 & 3;
					object obj103 = obj62 & 3;
					if (0 >= (nint)obj62)
					{
						obj103 = 0 - obj102;
					}
					object obj104 = obj56 - obj103;
					bool flag29 = obj104 == null;
					object obj105 = !flag29;
					object obj106 = ~obj105;
					if (obj106 == null)
					{
						object obj107 = 3;
					}
					else
					{
						object obj107 = 1;
					}
					obj56++;
				}
				while (obj64 != obj56);
				goto IL_08f8;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_09b8;
		IL_09b8:
		throw new IndexOutOfRangeException();
	}

	protected override BiddingManager CreateBiddingManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BiddingManager biddingManager = default(BiddingManager);
		biddingManager..ctor();
		object obj2 = biddingManager + 24;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj2;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+10]");
			_ = 0;
			return biddingManager;
		}
		return (BiddingManager)(object)new NullReferenceException();
	}

	protected override PlayingManager CreatePlayingManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (PlayingManager)obj2;
	}

	protected override void OnEndBidding()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_00f0: Expected O, but got I4
		//IL_0124: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_018e: Expected O, but got I4
		//IL_01c2: Expected O, but got I
		//IL_0203: Expected I, but got O
		//IL_022c: Expected O, but got I4
		//IL_0260: Expected O, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		CardDistributionSecondPhase();
		BiddingManager biddingManager = base.BiddingManager;
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1952;
		object obj2 = obj;
		nint num = (nint)biddingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v9 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X1_v3+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v9 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X1_v3+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v12-8]");
			if (0 == (nint)obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5 (KammelnaOffline.Common.BiddingManager)+30]");
				TrumpSuit = Suit.SPADES;
				nint num4 = (nint)biddingManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X1_v3+130]");
				bool flag2 = num5 < 0;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X1_v3+130]");
					object obj8 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v17-8]");
					if (0 == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5 (KammelnaOffline.Common.BiddingManager)+34]");
						GameMode = BalootGame.BalootGameMode.NotDetermined;
						nint num7 = (nint)biddingManager;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v5 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X1_v3+130]");
						bool flag3 = num8 < 0;
						object obj9 = !flag3;
						object obj10 = ~obj9;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v5 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X1_v3+130]");
							object obj11 = num9 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X10_v7-8]");
							if (0 == (nint)obj2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5 (KammelnaOffline.Common.BiddingManager)+38]");
								IsHokomClose = false;
								nint num10 = (nint)biddingManager;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X10_v10 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
								nint num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X1_v3+130]");
								bool flag4 = num11 < 0;
								object obj12 = !flag4;
								object obj13 = ~obj12;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X10_v10 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
									nint num12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X1_v3+130]");
									object obj14 = num12 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v5-8]");
									if (0 == (nint)obj2)
									{
										object key = "getSecondRescanTask" + 1696;
										object key2 = "fetch_products" + 2528;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5 (KammelnaOffline.Common.BiddingManager)+3C]");
										ExtraGameMode = BalootGame.BalootExtraGameMode.NotDetermined;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5 (KammelnaOffline.Common.BiddingManager)+34]");
										string val = BalootGameModeExtensions.ToClientString(BalootGame.BalootGameMode.NotDetermined);
										SFSExtensions.Put(base.<RoundState>k__BackingField, (string)key, val);
										string val2 = BalootGameModeExtensions.ToClientString(ExtraGameMode);
										SFSExtensions.Put(base.<RoundState>k__BackingField, (string)key2, val2);
										base.OnEndBidding();
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe override void OnEndRound()
	{
		//IL_28a6: Expected I, but got O
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected I4, but got Unknown
		//IL_017b: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0193: Expected F8, but got I4
		//IL_01b5: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_01f5: Expected F8, but got I4
		//IL_01f0: Expected native int or pointer, but got F8
		//IL_0211: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_34a4: Invalid comparison between F8 and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00aa: Expected I, but got O
		//IL_00ba: Expected O, but got I
		//IL_02a0: Expected O, but got I4
		//IL_02bb: Invalid comparison between F8 and I4
		//IL_02d6: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_1421: Invalid comparison between F8 and I4
		//IL_1432: Expected O, but got I4
		//IL_144c: Invalid comparison between F8 and I4
		//IL_2924: Unknown result type (might be due to invalid IL or missing references)
		//IL_2929: Expected O, but got Unknown
		//IL_2931: Expected I, but got O
		//IL_2941: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_1474: Expected O, but got I4
		//IL_148e: Expected O, but got I4
		//IL_1497: Unknown result type (might be due to invalid IL or missing references)
		//IL_149c: Expected O, but got Unknown
		//IL_14b6: Expected O, but got I4
		//IL_29de: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e3: Expected O, but got Unknown
		//IL_08a7: Expected O, but got I
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected O, but got Unknown
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected O, but got Unknown
		//IL_29ff: Expected I, but got O
		//IL_2a0f: Expected O, but got I
		//IL_2a1f: Expected O, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_2dad: Expected native int or pointer, but got F8
		//IL_2dc1: Invalid comparison between F8 and I4
		//IL_2dd0: Invalid comparison between F8 and I4
		//IL_2de8: Expected native int or pointer, but got F8
		//IL_2ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df2: Expected I4, but got Unknown
		//IL_2e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e09: Expected I4, but got Unknown
		//IL_2e3e: Expected O, but got I4
		//IL_2e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4b: Expected O, but got Unknown
		//IL_14e0: Expected O, but got I4
		//IL_2a52: Expected O, but got I4
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected O, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected O, but got Unknown
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		//IL_2e66: Expected native int or pointer, but got F8
		//IL_2e89: Invalid comparison between F8 and I4
		//IL_2e98: Invalid comparison between F8 and I4
		//IL_2ea2: Expected native int or pointer, but got F8
		//IL_2eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eba: Expected I4, but got Unknown
		//IL_2ebe: Expected native int or pointer, but got F8
		//IL_2ecc: Expected O, but got F8
		//IL_2ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed9: Expected I4, but got Unknown
		//IL_2f01: Expected O, but got I4
		//IL_2f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0e: Expected O, but got Unknown
		//IL_03ef: Expected F8, but got I4
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected O, but got Unknown
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected O, but got Unknown
		//IL_1527: Expected O, but got I4
		//IL_039e: Expected I, but got O
		//IL_03ae: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_2a79: Expected O, but got I4
		//IL_2a93: Expected O, but got I4
		//IL_2a9c: Expected I4, but got O
		//IL_2f3f: Expected O, but got I4
		//IL_2f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4d: Expected O, but got Unknown
		//IL_2f67: Expected O, but got I4
		//IL_1519: Expected O, but got I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected I4, but got Unknown
		//IL_0441: Expected I4, but got O
		//IL_09b8: Expected O, but got I4
		//IL_15de: Expected O, but got I4
		//IL_15e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ec: Expected O, but got Unknown
		//IL_1606: Expected O, but got I4
		//IL_2ab4: Expected F8, but got I4
		//IL_2ad0: Expected O, but got I4
		//IL_2aec: Invalid comparison between F8 and I4
		//IL_15bf: Expected O, but got I4
		//IL_153b: Expected O, but got I4
		//IL_154b: Expected O, but got I
		//IL_1565: Expected O, but got I4
		//IL_156e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1573: Expected O, but got Unknown
		//IL_1593: Unknown result type (might be due to invalid IL or missing references)
		//IL_1598: Expected O, but got Unknown
		//IL_15a8: Expected O, but got I
		//IL_04de: Expected F8, but got I4
		//IL_04f2: Expected O, but got I8
		//IL_0514: Expected O, but got I4
		//IL_2f95: Expected native int or pointer, but got F8
		//IL_2fa9: Invalid comparison between F8 and I4
		//IL_2fb8: Invalid comparison between F8 and I4
		//IL_2fd0: Expected native int or pointer, but got F8
		//IL_2fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fda: Expected I4, but got Unknown
		//IL_2fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff1: Expected I4, but got Unknown
		//IL_3026: Expected O, but got I4
		//IL_302e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3033: Expected O, but got Unknown
		//IL_163a: Expected O, but got I4
		//IL_164a: Expected O, but got I
		//IL_048d: Expected I, but got O
		//IL_049d: Expected O, but got I
		//IL_04c6: Expected O, but got I
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		//IL_09fa: Expected O, but got I4
		//IL_0a36: Expected F8, but got I4
		//IL_304e: Expected native int or pointer, but got F8
		//IL_3071: Invalid comparison between F8 and I4
		//IL_3080: Invalid comparison between F8 and I4
		//IL_308a: Expected native int or pointer, but got F8
		//IL_309d: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a2: Expected I4, but got Unknown
		//IL_30a6: Expected native int or pointer, but got F8
		//IL_30b4: Expected O, but got F8
		//IL_30bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c1: Expected I4, but got Unknown
		//IL_30e9: Expected O, but got I4
		//IL_30f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f6: Expected O, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_0baf: Expected I4, but got O
		//IL_167b: Expected O, but got I4
		//IL_1660: Expected O, but got I4
		//IL_3116: Unknown result type (might be due to invalid IL or missing references)
		//IL_311b: Expected O, but got Unknown
		//IL_05e7: Expected O, but got I4
		//IL_0600: Expected O, but got I4
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c21: Expected O, but got Unknown
		//IL_0c52: Expected O, but got I4
		//IL_0c73: Invalid comparison between F8 and I4
		//IL_0d1a: Expected O, but got I4
		//IL_1697: Expected F8, but got I4
		//IL_3176: Expected I4, but got O
		//IL_1689: Expected F8, but got I4
		//IL_0622: Expected native int or pointer, but got F8
		//IL_062f: Expected native int or pointer, but got F8
		//IL_064e: Expected O, but got F8
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_066d: Expected native int or pointer, but got F8
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected I4, but got Unknown
		//IL_0693: Expected O, but got I4
		//IL_298f: Expected O, but got I4
		//IL_16cd: Expected O, but got I4
		//IL_16ee: Invalid comparison between F8 and I4
		//IL_170a: Expected O, but got I4
		//IL_06bd: Expected O, but got I4
		//IL_06ee: Expected O, but got I4
		//IL_0737: Expected O, but got I4
		//IL_2bc7: Expected O, but got I4
		//IL_1207: Unknown result type (might be due to invalid IL or missing references)
		//IL_120c: Expected O, but got Unknown
		//IL_1260: Unknown result type (might be due to invalid IL or missing references)
		//IL_1265: Expected O, but got Unknown
		//IL_127f: Expected O, but got I4
		//IL_076d: Expected O, but got I4
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_2bf2: Invalid comparison between F8 and I4
		//IL_2c03: Expected O, but got I4
		//IL_0e04: Expected O, but got I4
		//IL_0e1f: Invalid comparison between F8 and I4
		//IL_0ebe: Expected O, but got I4
		//IL_175c: Expected F8, but got I4
		//IL_2c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c5a: Expected O, but got Unknown
		//IL_2c74: Expected O, but got I4
		//IL_1a89: Expected I4, but got O
		//IL_1a9b: Expected O, but got I4
		//IL_0847: Expected native int or pointer, but got F8
		//IL_31de: Expected O, but got I4
		//IL_31fa: Invalid comparison between F8 and I4
		//IL_2c9f: Invalid comparison between F8 and I4
		//IL_2cb0: Expected O, but got I4
		//IL_0f68: Expected I4, but got O
		//IL_0f86: Expected O, but got I4
		//IL_0fa4: Invalid comparison between F8 and I4
		//IL_1043: Expected O, but got I4
		//IL_3235: Unknown result type (might be due to invalid IL or missing references)
		//IL_323a: Expected O, but got Unknown
		//IL_093c: Expected O, but got I4
		//IL_094e: Expected I4, but got O
		//IL_20b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b5: Expected O, but got Unknown
		//IL_20d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d5: Expected O, but got Unknown
		//IL_1dd5: Expected O, but got I4
		//IL_1def: Expected O, but got I4
		//IL_1e09: Invalid comparison between F8 and I4
		//IL_1e1e: Expected O, but got I4
		//IL_1e2b: Expected I4, but got O
		//IL_17a7: Invalid comparison between F8 and I4
		//IL_2cd0: Invalid comparison between F8 and I4
		//IL_2ce3: Expected O, but got F8
		//IL_2ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf0: Expected O, but got Unknown
		//IL_2d18: Expected O, but got I4
		//IL_1093: Expected O, but got I
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a6: Expected I4, but got Unknown
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected O, but got Unknown
		//IL_10bc: Invalid comparison between I4 and F8
		//IL_10cd: Expected O, but got I4
		//IL_10e6: Invalid comparison between F8 and I4
		//IL_10f8: Invalid comparison between I4 and F8
		//IL_20f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20fc: Expected O, but got Unknown
		//IL_2119: Unknown result type (might be due to invalid IL or missing references)
		//IL_211e: Expected O, but got Unknown
		//IL_1af7: Expected F8, but got I4
		//IL_1b12: Expected O, but got I4
		//IL_1b2d: Invalid comparison between F8 and I4
		//IL_1b49: Expected O, but got I4
		//IL_2d3c: Invalid comparison between F8 and I8
		//IL_2148: Expected F8, but got I4
		//IL_2168: Expected O, but got I4
		//IL_11a9: Expected O, but got I4
		//IL_2d6f: Expected F8, but got I8
		//IL_12fa: Expected F8, but got I8
		//IL_2188: Unknown result type (might be due to invalid IL or missing references)
		//IL_218d: Expected O, but got Unknown
		//IL_21ba: Expected F8, but got I4
		//IL_21ce: Expected O, but got I8
		//IL_21f5: Expected O, but got I4
		//IL_21ff: Expected O, but got I4
		//IL_1e60: Expected F8, but got I4
		//IL_1e7b: Expected O, but got I4
		//IL_1e96: Invalid comparison between F8 and I4
		//IL_17f1: Invalid comparison between F8 and I4
		//IL_1802: Expected O, but got I4
		//IL_181d: Invalid comparison between F8 and I4
		//IL_182f: Expected I4, but got O
		//IL_1849: Expected O, but got I4
		//IL_1b86: Expected F8, but got I4
		//IL_1ba1: Expected O, but got I4
		//IL_1bbc: Invalid comparison between F8 and I4
		//IL_1bd8: Expected O, but got I4
		//IL_1319: Expected I4, but got O
		//IL_1337: Expected O, but got I4
		//IL_1355: Invalid comparison between F8 and I4
		//IL_1368: Expected I4, but got O
		//IL_13a1: Expected F8, but got I8
		//IL_13d2: Expected O, but got I4
		//IL_2227: Unknown result type (might be due to invalid IL or missing references)
		//IL_222c: Expected O, but got Unknown
		//IL_2275: Expected O, but got I4
		//IL_1880: Unknown result type (might be due to invalid IL or missing references)
		//IL_1885: Expected O, but got Unknown
		//IL_0a4a: Expected F8, but got I4
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected I4, but got Unknown
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0a81: Expected O, but got I4
		//IL_0a9c: Invalid comparison between F8 and I4
		//IL_0aee: Expected F8, but got I8
		//IL_0b37: Expected F8, but got I8
		//IL_0b70: Expected O, but got I4
		//IL_0b8f: Expected F8, but got I4
		//IL_2290: Expected F8, but got O
		//IL_22bb: Expected O, but got I4
		//IL_22c5: Expected O, but got I4
		//IL_1edd: Expected F8, but got I4
		//IL_1ef8: Expected O, but got I4
		//IL_1f13: Invalid comparison between F8 and I4
		//IL_1939: Invalid comparison between F8 and I4
		//IL_194a: Expected O, but got I4
		//IL_1965: Invalid comparison between F8 and I4
		//IL_1977: Expected I4, but got O
		//IL_1991: Expected O, but got I4
		//IL_1999: Expected I4, but got O
		//IL_1c18: Expected I4, but got O
		//IL_1c36: Expected O, but got I4
		//IL_1c54: Invalid comparison between F8 and I4
		//IL_1c70: Expected O, but got I4
		//IL_18dc: Expected O, but got I
		//IL_1905: Expected O, but got I
		//IL_22f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fa: Expected O, but got Unknown
		//IL_2328: Expected F8, but got O
		//IL_233a: Unknown result type (might be due to invalid IL or missing references)
		//IL_233f: Expected O, but got Unknown
		//IL_2364: Expected O, but got I
		//IL_236e: Expected O, but got I4
		//IL_19c3: Expected F8, but got O
		//IL_19be: Expected native int or pointer, but got F8
		//IL_19ee: Expected I4, but got O
		//IL_1a06: Expected I4, but got O
		//IL_1c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c99: Expected I4, but got Unknown
		//IL_1cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce4: Expected O, but got Unknown
		//IL_1d04: Expected O, but got I4
		//IL_1d1f: Invalid comparison between F8 and I4
		//IL_2396: Unknown result type (might be due to invalid IL or missing references)
		//IL_239b: Expected O, but got Unknown
		//IL_23c6: Expected F8, but got I4
		//IL_23ec: Expected O, but got I
		//IL_23f6: Expected O, but got I4
		//IL_1f5d: Expected F8, but got O
		//IL_1f7b: Expected O, but got I4
		//IL_1f99: Invalid comparison between F8 and I4
		//IL_1a2c: Expected I4, but got O
		//IL_1a34: Expected I4, but got O
		//IL_1a4e: Expected O, but got I4
		//IL_1a5e: Expected I4, but got O
		//IL_1d5d: Expected O, but got I4
		//IL_1d7b: Invalid comparison between F8 and I4
		//IL_2438: Expected O, but got I
		//IL_2017: Unknown result type (might be due to invalid IL or missing references)
		//IL_201c: Expected I4, but got Unknown
		//IL_2025: Unknown result type (might be due to invalid IL or missing references)
		//IL_202a: Expected I4, but got Unknown
		//IL_204d: Expected O, but got I4
		//IL_206b: Invalid comparison between F8 and I4
		//IL_1db0: Expected I4, but got O
		//IL_245d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2462: Expected I4, but got Unknown
		//IL_246c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2471: Expected O, but got Unknown
		//IL_2481: Expected I, but got O
		//IL_32c9: Expected O, but got I
		//IL_32dd: Expected F8, but got I4
		//IL_32f1: Expected O, but got I8
		//IL_330e: Expected O, but got I4
		//IL_3318: Expected O, but got I4
		//IL_332d: Expected O, but got I4
		//IL_3271: Expected O, but got I
		//IL_25a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a9: Expected O, but got Unknown
		//IL_25b1: Expected I4, but got O
		//IL_25b9: Expected I, but got O
		//IL_256f: Expected O, but got I
		//IL_2578: Unknown result type (might be due to invalid IL or missing references)
		//IL_257d: Expected O, but got Unknown
		//IL_339e: Expected O, but got I4
		//IL_33b8: Expected O, but got I4
		//IL_33d2: Invalid comparison between F8 and I4
		//IL_33e7: Expected O, but got I4
		//IL_33f4: Expected I4, but got O
		//IL_335b: Expected O, but got I
		//IL_340c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3411: Expected O, but got Unknown
		//IL_342c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3431: Expected O, but got Unknown
		//IL_3457: Expected F8, but got O
		//IL_3478: Expected O, but got I4
		//IL_3485: Expected O, but got I4
		//IL_2684: Expected O, but got I
		//IL_268d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2692: Expected O, but got Unknown
		//IL_272b: Expected O, but got I4
		//IL_2766: Expected O, but got I4
		//IL_2773: Expected O, but got I4
		//IL_27dd: Expected O, but got I4
		//IL_27e5: Expected O, but got I4
		//IL_2852: Unknown result type (might be due to invalid IL or missing references)
		//IL_2857: Expected O, but got Unknown
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v3 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+3C8]");
		int num2 = 0;
		SFSObject sFSObject = default(SFSObject);
		object obj3;
		int[] array = default(int[]);
		double num5;
		int[] array2;
		SFSArray sFSArray2;
		double num6 = default(double);
		ISFSArray[] array3 = default(ISFSArray[]);
		int num9 = default(int);
		int num11 = default(int);
		string text4 = default(string);
		int[] array5 = default(int[]);
		int[] array6 = default(int[]);
		int[] array7 = default(int[]);
		int[] array11 = default(int[]);
		SFSArray sFSArray5 = default(SFSArray);
		double num13 = default(double);
		int[] array9;
		string text3;
		NullReferenceException ex = default(NullReferenceException);
		bool flag18;
		bool flag5;
		string text2;
		ISFSArray[] array4;
		ISFSArray[] array8;
		int[] array10;
		string text;
		int num4 = default(int);
		object obj17;
		bool flag15;
		bool flag13;
		object obj10;
		double num7;
		if (IsGameOver())
		{
			object obj = typeof(RegisteredWaitHandle) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSObject..ctor();
			object obj2 = typeof(RegisteredWaitHandle) + 1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFSArray sFSArray = default(SFSArray);
			sFSArray..ctor();
			bool flag = sFSObject == null;
			text = null;
			if (!flag)
			{
				obj3 = typeof(System.IOAsyncCallback) + 976;
				object obj4 = "placementId" + 2072;
				nint num3 = (nint)sFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v130 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v130 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0136;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v130 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X10_v50-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj6 += 16;
					obj5--;
					if ((nint)obj5 != 1)
					{
						continue;
					}
					goto IL_0136;
				}
				object obj7 = obj6 + 49;
				object obj8 = num3 + obj7;
				object obj9 = obj8 + 312;
				goto IL_28fd;
			}
		}
		else
		{
			num4 = typeof(TypeConverter<ushort, char>) + 3048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag2 = array == null;
			text = (string)2;
			if (!flag2)
			{
				num5 = array.Length;
				bool flag3 = array.Length == 0;
				array2 = array;
				text2 = (string)2;
				sFSArray2 = (SFSArray)152993792;
				if (!flag3)
				{
					num2 = Team1Score;
					num6 = (double)array + 32.0;
					((double*)(nint)num6)->m_value = Team1Score;
					bool flag4 = array.Length < 1;
					obj10 = !flag4;
					num7 = (double)array.Length - 1.0;
					flag5 = array.Length == 1;
					array2 = array;
					text2 = (string)2;
					sFSArray2 = (SFSArray)152993792;
					if (!flag5)
					{
						array[1] = Team2Score;
						num2 = LastMoveWinner - 1;
						bool flag6 = num2 < array.Length;
						obj10 = !flag6;
						num7 = (double)num2 - (double)array.Length;
						flag5 = num7 == 0.0;
						array2 = array;
						text2 = (string)2;
						sFSArray2 = (SFSArray)152993792;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X26_v5 (System.Double)+v747 @ X9_v5 (System.Int32)*4]");
							object obj11 = (nint)0 + (nint)10;
							object obj12 = typeof(TypeConverter<ushort, char>) + 2888;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							text3 = (string)(typeof(RegisteredWaitHandle) + 1888);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							SFSArray sFSArray3 = default(SFSArray);
							sFSArray3..ctor();
							bool flag7 = array3 == null;
							text = null;
							if (flag7)
							{
								goto IL_287d;
							}
							bool flag8 = sFSArray3 == null;
							text2 = null;
							if (!flag8)
							{
								nint num8 = (nint)array3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v125 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray[]>)+40]");
								text2 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag9 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v125 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray[]>)+40]");
								text = (string)0;
								if (flag9)
								{
									goto IL_288b;
								}
							}
							num5 = array3.Length;
							bool flag10 = array3.Length == 0;
							array4 = array3;
							array2 = array;
							sFSArray2 = sFSArray3;
							if (!flag10)
							{
								num9 = array3 + 32;
								((int*)num9)->m_value = (int)sFSArray3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								SFSArray sFSArray4 = default(SFSArray);
								sFSArray4..ctor();
								bool flag11 = sFSArray4 == null;
								text2 = null;
								if (!flag11)
								{
									nint num10 = (nint)array3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X8_v124 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray[]>)+40]");
									text2 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag12 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X8_v124 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray[]>)+40]");
									text = (string)0;
									if (flag12)
									{
										goto IL_288b;
									}
								}
								num5 = array3.Length;
								object obj13 = array3.Length & 0xFFFFFFFEL;
								flag5 = obj13 == null;
								num11 = num9;
								obj10 = 0;
								array4 = array3;
								array2 = array;
								sFSArray2 = sFSArray4;
								if (!flag5)
								{
									text4 = (string)(array3 + 40);
									text4 = (string)(object)sFSArray4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									CalculateProjects(array, array5, array3, array6);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									flag13 = (byte)array.Length != 0;
									bool flag14 = (byte)(~array.Length) != 0;
									array7 = array6;
									array8 = array3;
									array9 = array6;
									num11 = num9;
									text3 = text4;
									array10 = array5;
									obj10 = 0;
									array4 = array3;
									array2 = array;
									text2 = (string)2;
									array11 = array5;
									sFSArray2 = sFSArray4;
									if (!flag14)
									{
										num5 = ((double*)(nint)num6)->m_value;
										double num12 = ((double*)(nint)num6)->m_value * 1717986919.0;
										object obj14 = num12 >> 34;
										object obj15 = obj14 + obj14;
										object obj16 = obj15 * 10;
										num2 = (int)(((double*)(nint)num6)->m_value - obj16);
										flag15 = num2 < 6;
										obj17 = 10;
										if (!flag15)
										{
											bool flag16 = array.Length < 1;
											obj10 = !flag16;
											num7 = (double)array.Length - 1.0;
											flag5 = array.Length == 1;
											obj17 = 10;
											array7 = array6;
											array8 = array3;
											array9 = array6;
											num11 = num9;
											text3 = text4;
											array10 = array5;
											array4 = array3;
											array2 = array;
											text2 = (string)2;
											array11 = array5;
											sFSArray2 = sFSArray5;
											if (flag5)
											{
												goto IL_13fd;
											}
											object obj18 = array[1] * 1717986919;
											object obj19 = obj18 >> 34;
											object obj20 = obj19 + obj19;
											object obj21 = obj20 * 10;
											obj17 = array[1] - obj21;
											bool flag17 = (nint)obj17 < 6;
											flag18 = true;
											flag13 = (byte)array[1] != 0;
											if (!flag17)
											{
												flag18 = (byte)RoundBidder != 0;
												if (RoundBidder == 4 || RoundBidder == 2)
												{
													double value = num5 - (double)obj17;
													((double*)(nint)num6)->m_value = value;
													flag13 = (byte)array[1] != 0;
												}
												else
												{
													object obj22 = array[1] - num2;
													array[1] = (int)obj22;
													flag13 = (byte)array[1] != 0;
												}
											}
										}
										bool flag19 = BalootGameModeExtensions.IsSunOrAshkal(GameMode);
										bool flag20 = !flag19;
										object obj23 = !flag20;
										object obj24 = ~obj23;
										num13 = ((obj24 != null) ? 10.0 : 5.0);
										goto IL_2a29;
									}
								}
							}
						}
					}
				}
				goto IL_13fd;
			}
		}
		goto IL_287d;
		IL_2540:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_32b9;
		IL_28fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1217 @ X0_v101] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray6 = default(SFSArray);
		sFSArray6..ctor();
		object obj25 = "placementId" + 2080;
		nint num14 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X8_v135 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X8_v135 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_08e8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X8_v135 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X10_v45-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_08e8;
		}
		object obj28 = obj27 + 49;
		object obj29 = num14 + obj28;
		object obj30 = obj29 + 312;
		goto IL_29ca;
		IL_15b6:
		object obj31 = 0;
		goto IL_2f82;
		IL_13fd:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_140b;
		IL_0136:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_28fd;
		IL_32b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2025 @ X0_v29+8]");
		array8 = (ISFSArray[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2025 @ X0_v29] (should have been resolved before IL gen)");
		ISFSArray[] array12 = default(ISFSArray[]);
		num5 = array12.Length;
		object obj32 = array12.Length & 0xFFFFFFFEL;
		flag5 = obj32 == null;
		array10 = (int[])((int*)num11)->m_value;
		obj10 = 0;
		array4 = array12;
		array2 = (int[])((int*)num11)->m_value;
		text2 = text3;
		SFSObject sFSObject2 = default(SFSObject);
		array11 = (int[])(object)sFSObject2;
		if (flag5)
		{
			goto IL_13fd;
		}
		string text5 = default(string);
		array4 = (ISFSArray[])(object)text5;
		object obj33 = "placementId" + 2080;
		num4 = (int)obj33;
		nint num15 = (nint)sFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2034 @ X8_v50 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2034 @ X8_v50 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_2655;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2034 @ X8_v50 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		bool flag21 = (byte)((nuint)0u + (nuint)8u) != 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X10_v18 (System.Boolean)-8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X10_v18 (System.Boolean)-8]");
			if ((nint)0 == ((int*)num4)->m_value)
			{
				break;
			}
			flag13 = (byte)((flag21 ? 1u : 0u) + 16u) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2034 @ X8_v50 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			num2 = (int)(-1);
			bool flag22 = num2 != 1;
			flag21 = flag13;
			if (flag22)
			{
				continue;
			}
			goto IL_2655;
		}
		num2 = (((bool*)(flag21 ? 1 : 0))->m_value ? 1 : 0) + 49;
		object obj34 = num15 + num2;
		object obj35 = obj34 + 312;
		flag13 = flag21;
		goto IL_3384;
		IL_29ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1365 @ X0_v106] (should have been resolved before IL gen)");
		object key = "java.io.FileOutputStream" + 3432;
		SFSExtensions.Put(sFSObject, (string)key, val: true);
		goto IL_29fa;
		IL_08e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_29ca;
		IL_29fa:
		nint num16 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X8_v5 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+2C8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X8_v5 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+2D0]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v1102 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_2a29;
		IL_3384:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2104 @ X0_v32] (should have been resolved before IL gen)");
		object obj38 = RoundBidder - 1;
		bool flag23 = (nint)obj38 < 3;
		obj10 = !flag23;
		num7 = (double)obj38 - 3.0;
		flag5 = num7 == 0.0;
		object obj39 = !flag5;
		int val;
		if ((obj10 & obj39) == 0)
		{
			num2 = 118730752 + 3184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X9_v5 (System.Int32)+v2113 @ X8_v54*4]");
			val = 0;
		}
		else
		{
			val = 0;
		}
		object key2 = "alignContent" + 3552;
		SFSExtensions.Put(sFSObject2, (string)key2, val);
		object obj40 = "utf-32" + 1096;
		text2 = (string)obj40;
		int num17;
		SFSExtensions.Put(sFSObject2, (string)obj40, num17);
		num5 = (double)sFSArray2.dataHolder;
		bool flag24 = sFSArray2.dataHolder == null;
		array8 = null;
		array10 = (int[])num17;
		array2 = (int[])((int*)num11)->m_value;
		array11 = (int[])(object)sFSObject2;
		if (!flag24)
		{
			num2 = Team1TotalScore;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X20_v6 (Sfs2X.Entities.Data.SFSArray)+20]");
			flag13 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X20_v6 (Sfs2X.Entities.Data.SFSArray)+20]");
			int team1Score = (Team1TotalScore = (int)((nint)0 + (nint)Team1TotalScore));
			bool flag25 = (nint)sFSArray2.dataHolder < 1;
			obj10 = !flag25;
			num7 = (double)sFSArray2.dataHolder - 1.0;
			flag5 = (nint)sFSArray2.dataHolder == 1;
			array8 = null;
			array10 = (int[])num17;
			array2 = (int[])((int*)num11)->m_value;
			array11 = (int[])(object)sFSObject2;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X20_v6 (Sfs2X.Entities.Data.SFSArray)+24]");
				int num18 = (Team2TotalScore = (int)((nint)0 + (nint)Team2TotalScore));
				OfflineUserInfo.SaveGame(team1Score, num18, Dealer);
				bool flag26 = base.<Room>k__BackingField == null;
				array8 = null;
				array10 = (int[])Dealer;
				text = (string)num18;
				if (flag26)
				{
					goto IL_287d;
				}
				base.<Room>k__BackingField.UpdateScore(Team1TotalScore, Team2TotalScore);
				if (Team1TotalScore > 151 || Team2TotalScore >= 152)
				{
					object key3 = "java.io.FileOutputStream" + 3432;
					SFSExtensions.Put(sFSObject2, (string)key3, val: true);
				}
				AddKabboot(sFSObject2);
				goto IL_29fa;
			}
		}
		goto IL_13fd;
		IL_2a29:
		bool flag27 = BalootGameModeExtensions.IsSunOrAshkal(GameMode);
		bool flag28 = !flag27;
		object obj41 = !flag28;
		object obj42 = ~obj41;
		int num19 = ((obj42 != null) ? 25 : 44);
		object obj43 = GameMode - 2;
		bool flag29 = obj43 == null;
		object obj44 = !flag29;
		bool flag30 = (byte)(int)(~obj44) != 0;
		text3 = (flag30 ? ((string)(-1)) : null);
		num5 = array.Length;
		bool flag31 = array.Length < 1;
		obj10 = !flag31;
		num7 = (double)array.Length - 1.0;
		flag5 = num7 == 0.0;
		flag15 = array.Length < 1;
		array12 = array3;
		text5 = text4;
		int num20 = num19;
		double num21 = 5.0;
		double num22 = 10.0;
		array7 = array6;
		array8 = array3;
		array9 = array6;
		num11 = num9;
		array10 = array5;
		num2 = 44;
		array4 = array3;
		array2 = array;
		text2 = null;
		array11 = array5;
		sFSArray2 = sFSArray5;
		double num36 = default(double);
		object obj47;
		if (!flag15)
		{
			object obj45 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			double num24 = default(double);
			double num23 = num24;
			double num26 = default(double);
			double num25 = num26;
			double num28 = default(double);
			double num27 = num28;
			double num30 = default(double);
			double num29 = num30;
			object obj46 = 8;
			bool flag32 = flag30;
			double num31 = 5.0;
			double num32 = 10.0;
			bool flag33 = flag15;
			int num33 = num4;
			double num34 = array.Length;
			double num38 = default(double);
			while (true)
			{
				num2 = (int)TeamEatings;
				bool flag34 = TeamEatings == null;
				num24 = num23;
				num26 = num25;
				num28 = num27;
				num21 = num31;
				num22 = num32;
				array8 = array3;
				array9 = array6;
				array10 = array5;
				text = null;
				if (flag34)
				{
					break;
				}
				SFSArray sFSArray7 = (SFSArray)(obj46 - 8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X9_v5 (System.Int32)+18]");
				flag13 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X9_v5 (System.Int32)+18]");
				bool flag35 = (nint)sFSArray7 < 0;
				obj10 = !flag35;
				double num35 = (double)sFSArray7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X9_v5 (System.Int32)+18]");
				num7 = num35 - 0.0;
				flag5 = num7 == 0.0;
				num24 = num23;
				array12 = array3;
				text5 = text4;
				num20 = num19;
				num26 = num25;
				num28 = num27;
				num30 = num29;
				obj47 = obj46;
				num36 = num6;
				flag30 = flag32;
				num21 = num31;
				num22 = num32;
				array7 = array6;
				array8 = array3;
				array9 = array6;
				num11 = num9;
				array10 = array5;
				flag15 = flag33;
				array4 = (ISFSArray[])146599936;
				array2 = array;
				num4 = num33;
				text2 = null;
				array11 = array5;
				num5 = num34;
				sFSArray2 = sFSArray5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X9_v5 (System.Int32)+v187 @ X27_v12*4]");
					if ((nint)0 == 8)
					{
						bool flag36 = array5 == null;
						num24 = num23;
						num26 = num25;
						num28 = num27;
						num21 = num31;
						num22 = num32;
						array8 = array3;
						array9 = array6;
						array10 = array5;
						text = null;
						if (flag36)
						{
							break;
						}
						num2 = array5.Length;
						bool flag37 = (nint)sFSArray7 < array5.Length;
						obj10 = !flag37;
						num7 = (double)sFSArray7 - (double)array5.Length;
						flag5 = num7 == 0.0;
						num24 = num23;
						array12 = array3;
						text5 = text4;
						num20 = num19;
						num26 = num25;
						num28 = num27;
						num30 = num29;
						obj47 = obj46;
						num36 = num6;
						flag30 = flag32;
						num21 = num31;
						num22 = num32;
						array7 = array6;
						array8 = array3;
						array9 = array6;
						num11 = num9;
						array10 = array5;
						array4 = (ISFSArray[])146599936;
						array2 = array;
						num4 = num33;
						text2 = null;
						array11 = array5;
						num5 = num34;
						sFSArray2 = sFSArray5;
						if (obj10 == null)
						{
							bool flag38 = sFSArray5 == null;
							num24 = num23;
							num26 = num25;
							num28 = num27;
							num21 = num31;
							num22 = num32;
							array8 = array3;
							array9 = array6;
							array10 = array5;
							text = null;
							if (flag38)
							{
								break;
							}
							num2 = (int)sFSArray5.dataHolder;
							bool flag39 = sFSArray7 < sFSArray5.dataHolder;
							obj10 = !flag39;
							num7 = (double)sFSArray7 - (double)sFSArray5.dataHolder;
							flag5 = num7 == 0.0;
							num24 = num23;
							array12 = array3;
							text5 = text4;
							num20 = num19;
							num26 = num25;
							num28 = num27;
							num30 = num29;
							obj47 = obj46;
							num36 = num6;
							flag30 = flag32;
							num21 = num31;
							num22 = num32;
							array7 = array6;
							array8 = array3;
							array9 = array6;
							num11 = num9;
							array10 = array5;
							array4 = (ISFSArray[])146599936;
							array2 = array;
							num4 = num33;
							text2 = null;
							array11 = array5;
							num5 = num34;
							sFSArray2 = sFSArray5;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X0_v74 (System.Int32[])+v187 @ X27_v12*4]");
								object obj48 = (nint)0 + (nint)num19;
								num2 = obj46 - 7;
								obj46++;
								bool flag40 = (double)num2 < num34;
								obj10 = !flag40;
								num7 = (double)num2 - num34;
								flag5 = num7 == 0.0;
								flag33 = (double)num2 < num34;
								if (flag33)
								{
									continue;
								}
								num24 = num23;
								array12 = array3;
								text5 = text4;
								num20 = num19;
								num26 = num25;
								num28 = num27;
								obj47 = obj46;
								num36 = num6;
								flag30 = flag32;
								num21 = num31;
								num22 = num32;
								array7 = array6;
								array8 = array3;
								array9 = array6;
								num11 = num9;
								array10 = array5;
								flag15 = flag33;
								flag13 = (byte)num19 != 0;
								array4 = (ISFSArray[])146599936;
								array2 = array;
								num4 = num33;
								text2 = null;
								array11 = array5;
								num5 = num34;
								sFSArray2 = sFSArray5;
								goto IL_140b;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v12 (System.Int32[])+v187 @ X27_v12*4]");
						num4 = 0;
						object obj49 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1852 @ X0_v86+E4]");
						bool flag41 = (nint)0 == 0;
						object obj50 = !flag41;
						if (obj50 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj51 = num4 + text3;
						num30 = (double)obj51 / num13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
						num28 = num30 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						double num37 = num38 + -1.0;
						object obj52 = num38 & 1;
						bool flag42 = obj52 == null;
						object obj53 = !flag42;
						if (obj53 == null)
						{
							num37 = num38;
						}
						double num39 = num30 - -0.5;
						bool flag43 = num39 == 0.0;
						object obj54 = !flag43;
						object obj55 = ~obj54;
						if (obj55 != null)
						{
							num28 = num37;
						}
						num26 = num30 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						num24 = num38 + 1.0;
						object obj56 = num38 & 1;
						bool flag44 = obj56 == null;
						object obj57 = !flag44;
						double num40 = ((obj57 != null) ? num24 : num38);
						double num41 = num30 - 0.5;
						bool flag45 = num41 == 0.0;
						object obj58 = !flag45;
						object obj59 = ~obj58;
						num22 = ((obj59 != null) ? num40 : num26);
						bool flag46 = num30 < 0.0;
						object obj60 = num30 ^ num30;
						object obj61 = num30 & obj60;
						bool flag47 = (nint)obj61 < 0;
						bool flag48 = flag46 == flag47;
						object obj62 = !flag48;
						object obj63 = ~obj62;
						if (obj63 == null)
						{
							num22 = num28;
						}
						flag30 = num22 != 9.218868437227405E+18;
						num5 = (flag30 ? num22 : 2147483648.0);
						bool flag49 = sFSArray5 == null;
						num21 = 9.218868437227405E+18;
						array8 = array3;
						array9 = array6;
						array10 = array5;
						text = null;
						if (flag49)
						{
							break;
						}
						num2 = (int)sFSArray5.dataHolder;
						bool flag50 = sFSArray7 < sFSArray5.dataHolder;
						obj10 = !flag50;
						num7 = (double)sFSArray7 - (double)sFSArray5.dataHolder;
						flag5 = num7 == 0.0;
						flag15 = (byte)(int)(~obj10) != 0;
						array12 = array3;
						text5 = text4;
						num20 = num19;
						obj47 = obj46;
						num36 = num6;
						num21 = 9.218868437227405E+18;
						array7 = array6;
						array8 = array3;
						array9 = array6;
						num11 = num9;
						array10 = array5;
						array4 = (ISFSArray[])146599936;
						array2 = array;
						text2 = null;
						array11 = array5;
						sFSArray2 = sFSArray5;
						if (flag15)
						{
							num34 = array.Length;
							num2 = obj46 - 7;
							obj46++;
							bool flag51 = num2 < array.Length;
							obj10 = !flag51;
							num7 = (double)num2 - (double)array.Length;
							flag5 = num7 == 0.0;
							flag33 = num2 >= array.Length;
							num23 = num24;
							num25 = num26;
							num27 = num28;
							num29 = num30;
							flag32 = flag30;
							num31 = 9.218868437227405E+18;
							num32 = num22;
							num33 = num4;
							array12 = array3;
							text5 = text4;
							num20 = num19;
							obj47 = obj46;
							num36 = num6;
							num21 = 9.218868437227405E+18;
							array7 = array6;
							array8 = array3;
							array9 = array6;
							num11 = num9;
							array10 = array5;
							flag15 = flag33;
							array4 = (ISFSArray[])146599936;
							array2 = array;
							text2 = null;
							array11 = array5;
							num5 = array.Length;
							sFSArray2 = sFSArray5;
							if (!flag33)
							{
								continue;
							}
							goto IL_140b;
						}
					}
				}
				goto IL_13fd;
			}
			goto IL_287d;
		}
		goto IL_349b;
		IL_1aed:
		num5 = array11.Length;
		bool flag52 = (nint)text3 < array11.Length;
		obj10 = !flag52;
		num7 = (double)text3 - (double)array11.Length;
		flag5 = num7 == 0.0;
		flag18 = true;
		obj17 = 2;
		int[] array13;
		double num43;
		SFSArray sFSArray8;
		if (obj10 == null)
		{
			bool flag53 = array13 == null;
			text = text2;
			if (flag53)
			{
				goto IL_287d;
			}
			num5 = array13.Length;
			bool flag54 = (nint)text3 < array13.Length;
			obj10 = !flag54;
			num7 = (double)text3 - (double)array13.Length;
			flag5 = num7 == 0.0;
			flag18 = true;
			obj17 = 2;
			if (obj10 == null)
			{
				bool flag55 = sFSArray2 == null;
				text = text2;
				if (flag55)
				{
					goto IL_287d;
				}
				num2 = (int)sFSArray2.dataHolder;
				bool flag56 = text3 < sFSArray2.dataHolder;
				obj10 = !flag56;
				num7 = (double)text3 - (double)sFSArray2.dataHolder;
				flag5 = num7 == 0.0;
				flag18 = true;
				obj17 = 2;
				if (obj10 == null)
				{
					object obj64 = array11 + text3;
					flag13 = (byte)(array13 + 32) != 0;
					bool flag57 = text3 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1817 @ X10_v26+20]");
					double num42 = 0.0 + num43;
					double num44 = num42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X10_v13 (System.Boolean)+v578 @ X24_v5 (System.String)*4]");
					double num45 = num44 + 0.0;
					obj17 = sFSArray2 + 32;
					bool flag58 = (flag57 ? 1 : 0) < array13.Length;
					obj10 = !flag58;
					num7 = (double)(flag57 ? 1 : 0) - (double)array13.Length;
					flag5 = num7 == 0.0;
					flag18 = flag57;
					if (obj10 == null)
					{
						bool flag59 = (flag57 ? 1 : 0) < (nint)sFSArray2.dataHolder;
						obj10 = !flag59;
						num7 = (double)(flag57 ? 1 : 0) - (double)sFSArray2.dataHolder;
						flag5 = num7 == 0.0;
						flag18 = flag57;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X10_v13 (System.Boolean)+v1550 @ Z_v13 (System.Boolean)*4]");
							_ = 0;
							num17 = (int)sFSArray8;
							flag18 = flag57;
							text = text2;
							goto IL_31c2;
						}
					}
				}
			}
		}
		goto IL_13fd;
		IL_288b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_2f82:
		double num46 = (double)array2[1] - ((double*)(nint)num6)->m_value;
		bool flag60 = num46 < 0.0;
		bool flag61 = num46 == 0.0;
		int num47 = array2[1] ^ ((double*)(nint)num6)->m_value;
		int num48 = array2[1] ^ num46;
		int num49 = num47 & num48;
		bool flag62 = num49 < 0;
		bool flag63 = flag60 == flag62;
		object obj65 = !flag61;
		object obj66 = flag63 & obj65;
		object obj67 = ~obj66;
		if (obj67 == null)
		{
			obj31 = 2;
		}
		double num50 = ((double*)(nint)num6)->m_value - (double)array2[1];
		bool flag64 = num50 < 0.0;
		bool flag65 = num50 == 0.0;
		int num51 = ((double*)(nint)num6)->m_value ^ array2[1];
		object obj68 = ((double*)(nint)num6)->m_value ^ num50;
		int num52 = num51 & obj68;
		bool flag66 = num52 < 0;
		bool flag67 = flag64 == flag66;
		object obj69 = !flag67;
		object obj70 = obj69 | flag65;
		object obj71 = ~obj70;
		obj47 = ((obj71 != null) ? ((object)1) : obj31);
		text3 = (string)(sFSArray8 - 1);
		bool flag68 = text3 == null;
		num5 = ((!BalootGameModeExtensions.IsSunOrAshkal(GameMode)) ? 16.0 : 26.0);
		num2 = (int)TeamEatings;
		bool flag69 = TeamEatings == null;
		text = null;
		if (!flag69)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X9_v5 (System.Int32)+18]");
			flag13 = false;
			string text6 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X9_v5 (System.Int32)+18]");
			bool flag70 = (nint)text6 < 0;
			obj10 = !flag70;
			double num53 = (double)text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X9_v5 (System.Int32)+18]");
			num7 = num53 - 0.0;
			flag5 = num7 == 0.0;
			flag18 = true;
			obj17 = 2;
			text2 = null;
			if (obj10 != null)
			{
				goto IL_13fd;
			}
			object obj72 = TeamEatings + text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ X9_v9+20]");
			num43 = (((nint)0 != 8) ? num5 : ((double)num20));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ X9_v9+20]");
			if ((nint)0 == 8 && (nint)sFSArray8 != BestProjectTeam)
			{
				num5 = (double)BestProjectTeam - 1.0;
				if (!(num5 < 1.0))
				{
					bool flag71 = array11 == null;
					text = null;
					if (!flag71)
					{
						num2 = array11.Length;
						bool flag72 = num5 < (double)array11.Length;
						obj10 = !flag72;
						num7 = num5 - (double)array11.Length;
						flag5 = num7 == 0.0;
						num20 = (int)sFSArray8;
						num36 = num43;
						flag18 = true;
						obj17 = 2;
						text2 = null;
						if (obj10 == null)
						{
							double num54 = (double)array11 + num5;
							_ = 0;
							object obj73 = typeof(RegisteredWaitHandle) + 1888;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							SFSArray sFSArray9 = default(SFSArray);
							sFSArray9..ctor();
							bool flag73 = sFSArray9 == null;
							text2 = null;
							if (!flag73)
							{
								int value2 = ((int*)(&array12))->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v89 (System.Int32)+40]");
								text2 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag74 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v89 (System.Int32)+40]");
								text = (string)0;
								if (flag74)
								{
									goto IL_288b;
								}
							}
							num5 = (double)BestProjectTeam - 1.0;
							num2 = array12.Length;
							bool flag75 = num5 < (double)array12.Length;
							obj10 = !flag75;
							num7 = num5 - (double)array12.Length;
							flag5 = num7 == 0.0;
							num20 = (int)sFSArray8;
							num36 = num43;
							flag18 = true;
							obj17 = 2;
							num4 = (int)array12;
							if (obj10 == null)
							{
								double num55 = (double)num11 + num5;
								((double*)(nint)num55)->m_value = (double)sFSArray9;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								flag15 = array4 != obj47;
								array13 = array7;
								num20 = (int)sFSArray8;
								num36 = num43;
								num2 = num11;
								num4 = (int)array12;
								text2 = (string)(object)sFSArray9;
								if (flag15)
								{
									goto IL_1aed;
								}
								array13 = array7;
								num20 = (int)sFSArray8;
								num17 = (int)sFSArray8;
								num36 = num43;
								flag18 = true;
								obj17 = 2;
								num2 = num11;
								num4 = (int)array12;
								text = (string)(object)sFSArray9;
								goto IL_31c2;
							}
						}
						goto IL_13fd;
					}
					goto IL_287d;
				}
			}
			bool flag76 = array4 == obj47;
			array13 = array7;
			num17 = (int)sFSArray8;
			flag18 = true;
			obj17 = 2;
			num2 = num20;
			text = null;
			if (flag76)
			{
				goto IL_31c2;
			}
			bool flag77 = array11 == null;
			array13 = array7;
			num2 = num20;
			text2 = null;
			text = null;
			if (!flag77)
			{
				goto IL_1aed;
			}
		}
		goto IL_287d;
		IL_287d:
		ex = new NullReferenceException();
		goto IL_288b;
		IL_140b:
		num6 = num36;
		goto IL_349b;
		IL_31c2:
		bool flag78 = ExtraGameMode < BalootGame.BalootExtraGameMode.Double;
		obj10 = !flag78;
		num7 = (double)ExtraGameMode - 1.0;
		flag5 = num7 == 0.0;
		flag15 = ExtraGameMode != BalootGame.BalootExtraGameMode.Double;
		if (!flag15)
		{
			object obj74 = GameMode - 1;
			bool flag79 = (nint)obj74 < 1;
			obj10 = !flag79;
			num7 = (double)obj74 - 1.0;
			flag5 = num7 == 0.0;
			object obj75 = !flag5;
			flag15 = (byte)(obj10 & obj75) != 0;
			if (!flag15)
			{
				if (array11 != null)
				{
					num5 = array11.Length;
					bool flag80 = (nint)text3 < array11.Length;
					obj10 = !flag80;
					num7 = (double)text3 - (double)array11.Length;
					flag5 = num7 == 0.0;
					text2 = text;
					if (obj10 == null)
					{
						if (array13 == null)
						{
							goto IL_287d;
						}
						num5 = array13.Length;
						bool flag81 = (nint)text3 < array13.Length;
						obj10 = !flag81;
						num7 = (double)text3 - (double)array13.Length;
						flag5 = num7 == 0.0;
						text2 = text;
						if (obj10 == null)
						{
							if (sFSArray2 == null)
							{
								goto IL_287d;
							}
							num5 = (double)sFSArray2.dataHolder;
							bool flag82 = text3 < sFSArray2.dataHolder;
							obj10 = !flag82;
							num7 = (double)text3 - (double)sFSArray2.dataHolder;
							flag5 = num7 == 0.0;
							text2 = text;
							if (obj10 == null)
							{
								object obj76 = array11 + text3;
								bool flag83 = text3 == null;
								obj17 = (object)text3 << 2;
								object obj77 = (object)array13 + obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1857 @ X9_v34+20]");
								double num56 = 0.0 + num43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1868 @ X12_v8+20]");
								flag18 = (byte)(int)(0 + num56) != 0;
								num2 = sFSArray2 + 32;
								bool flag84 = (flag83 ? 1 : 0) < (nint)sFSArray2.dataHolder;
								obj10 = !flag84;
								num7 = (double)(flag83 ? 1 : 0) - (double)sFSArray2.dataHolder;
								flag5 = num7 == 0.0;
								flag13 = flag83;
								text2 = text;
								if (obj10 == null)
								{
									_ = 0;
									flag13 = flag83;
									goto IL_3226;
								}
							}
						}
					}
					goto IL_13fd;
				}
				goto IL_287d;
			}
		}
		goto IL_3226;
		IL_2655:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_3384;
		IL_3226:
		object obj78 = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		sFSObject2..ctor();
		string val2 = BalootGameModeExtensions.ToClientString(GameMode);
		object key4 = "java.io.FileOutputStream" + 3672;
		SFSExtensions.Put(sFSObject2, (string)key4, val2);
		object key5 = "java.io.FileOutputStream" + 2880;
		SFSExtensions.Put(sFSObject2, (string)key5, LastMoveWinner);
		object key6 = "destinationTimeZone" + 1056;
		SFSExtensions.Put(sFSObject2, (string)key6, Team1Score);
		object obj79 = "destinationTimeZone" + 1064;
		text2 = (string)obj79;
		SFSExtensions.Put(sFSObject2, (string)obj79, Team2Score);
		num5 = array2.Length;
		bool flag85 = array2.Length == 0;
		array8 = null;
		array10 = (int[])Team2Score;
		array11 = (int[])(object)sFSObject2;
		if (!flag85)
		{
			object obj80 = "not" + 2928;
			text2 = (string)obj80;
			SFSExtensions.Put(sFSObject2, (string)obj80, array2[0]);
			num5 = array2.Length;
			object obj81 = array2.Length & 0xFFFFFFFEL;
			flag5 = obj81 == null;
			array8 = null;
			array10 = (int[])array2[0];
			obj10 = 0;
			array4 = array12;
			array11 = (int[])(object)sFSObject2;
			if (!flag5)
			{
				object obj82 = "not" + 2936;
				text = (string)obj82;
				SFSExtensions.Put(sFSObject2, (string)obj82, array2[1]);
				bool flag86 = sFSArray2 == null;
				array8 = null;
				array10 = (int[])array2[1];
				if (flag86)
				{
					goto IL_287d;
				}
				num5 = (double)sFSArray2.dataHolder;
				bool flag87 = sFSArray2.dataHolder == null;
				array8 = null;
				array10 = (int[])array2[1];
				obj10 = 0;
				array4 = array12;
				text2 = (string)obj82;
				array11 = (int[])(object)sFSObject2;
				if (!flag87)
				{
					object obj83 = "rightCtrl" + 800;
					text2 = (string)obj83;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X20_v6 (Sfs2X.Entities.Data.SFSArray)+20]");
					SFSExtensions.Put(sFSObject2, (string)obj83, 0);
					num5 = (double)sFSArray2.dataHolder;
					object obj84 = sFSArray2.dataHolder & 0xFFFFFFFEL;
					flag5 = obj84 == null;
					array8 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X20_v6 (Sfs2X.Entities.Data.SFSArray)+20]");
					array10 = (int[])0;
					obj10 = 0;
					array4 = array12;
					array11 = (int[])(object)sFSObject2;
					if (!flag5)
					{
						object obj85 = "rightCtrl" + 824;
						text2 = (string)obj85;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X20_v6 (Sfs2X.Entities.Data.SFSArray)+24]");
						SFSExtensions.Put(sFSObject2, (string)obj85, 0);
						num5 = array12.Length;
						bool flag88 = array12.Length == 0;
						array8 = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X20_v6 (Sfs2X.Entities.Data.SFSArray)+24]");
						array10 = (int[])0;
						obj10 = 0;
						array4 = array12;
						array11 = (int[])(object)sFSObject2;
						if (!flag88)
						{
							bool flag89 = sFSObject2 == null;
							array8 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X20_v6 (Sfs2X.Entities.Data.SFSArray)+24]");
							array10 = (int[])0;
							text = (string)obj85;
							if (flag89)
							{
								goto IL_287d;
							}
							num4 = typeof(System.IOAsyncCallback) + 976;
							object obj86 = "placementId" + 2072;
							text3 = (string)obj86;
							nint num57 = (nint)sFSObject2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X8_v43 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X8_v43 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_2540;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X8_v43 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
							bool flag90 = (byte)((nuint)0u + (nuint)8u) != 0;
							bool flag91 = flag15;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2004 @ X10_v23 (System.Boolean)-8]");
								obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2004 @ X10_v23 (System.Boolean)-8]");
								num7 = 0.0 - (double)((int*)num4)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2004 @ X10_v23 (System.Boolean)-8]");
								if ((nint)0 == ((int*)num4)->m_value)
								{
									break;
								}
								flag13 = (byte)((flag90 ? 1u : 0u) + 16u) != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X8_v43 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
								num2 = (int)(-1);
								num7 = (double)num2 - 1.0;
								flag15 = num2 != 1;
								flag91 = flag15;
								flag90 = flag13;
								if (flag15)
								{
									continue;
								}
								goto IL_2540;
							}
							num2 = (((bool*)(flag90 ? 1 : 0))->m_value ? 1 : 0) + 49;
							object obj87 = num57 + num2;
							object obj88 = obj87 + 312;
							flag15 = flag91;
							flag13 = flag90;
							goto IL_32b9;
						}
					}
				}
			}
		}
		goto IL_13fd;
		IL_349b:
		if (num5 != 0.0)
		{
			bool flag92 = num5 < 1.0;
			obj10 = !flag92;
			num7 = num5 - 1.0;
			if (num5 != 1.0)
			{
				object obj89 = RoundBidder - 1;
				bool flag93 = (nint)obj89 < 3;
				object obj90 = !flag93;
				object obj91 = obj89 - 3;
				bool flag94 = obj91 == null;
				object obj92 = !flag94;
				object obj93 = obj90 & obj92;
				bool flag95;
				if (obj93 == null)
				{
					object obj94 = 118730752 + 3184;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X11_v33+v1184 @ X10_v6*4]");
					flag95 = false;
				}
				else
				{
					flag95 = false;
				}
				double num58 = (double)array2[1] - ((double*)(nint)num6)->m_value;
				bool flag96 = num58 < 0.0;
				bool flag97 = num58 == 0.0;
				int num59 = array2[1] ^ ((double*)(nint)num6)->m_value;
				int num60 = array2[1] ^ num58;
				int num61 = num59 & num60;
				bool flag98 = num61 < 0;
				bool flag99 = flag96 == flag98;
				object obj95 = !flag97;
				object obj96 = flag99 & obj95;
				object obj97 = ~obj96;
				if (obj97 == null)
				{
					flag95 = true;
				}
				double num62 = ((double*)(nint)num6)->m_value - (double)array2[1];
				bool flag100 = num62 < 0.0;
				bool flag101 = num62 == 0.0;
				int num63 = ((double*)(nint)num6)->m_value ^ array2[1];
				object obj98 = ((double*)(nint)num6)->m_value ^ num62;
				int num64 = num63 & obj98;
				bool flag102 = num64 < 0;
				bool flag103 = flag100 == flag102;
				object obj99 = !flag103;
				object obj100 = obj99 | flag101;
				object obj101 = ~obj100;
				sFSArray8 = ((obj101 != null) ? ((SFSArray)1) : ((SFSArray)flag95));
				bool flag104 = (nint)obj89 < 3;
				object obj102 = !flag104;
				object obj103 = obj89 - 3;
				bool flag105 = obj103 == null;
				object obj104 = !flag105;
				object obj105 = obj102 & obj104;
				ISFSArray[] array14;
				if (obj105 == null)
				{
					object obj106 = 118730752 + 3184;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X11_v28+v1184 @ X10_v6*4]");
					array4 = (ISFSArray[])0;
					bool flag106 = (nint)obj89 < 3;
					object obj107 = !flag106;
					object obj108 = obj89 - 3;
					bool flag107 = obj108 == null;
					object obj109 = ~obj107;
					object obj110 = obj109 | flag107;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X11_v28+v1184 @ X10_v6*4]");
					array14 = (ISFSArray[])0;
					if (obj110 == null)
					{
						goto IL_15b6;
					}
				}
				else
				{
					bool flag108 = (nint)obj89 < 3;
					object obj111 = !flag108;
					object obj112 = obj89 - 3;
					bool flag109 = obj112 == null;
					object obj113 = !flag109;
					object obj114 = obj111 & obj113;
					array4 = null;
					array14 = null;
					if (obj114 != null)
					{
						goto IL_15b6;
					}
				}
				object obj115 = 118730752 + 3184;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1488 @ X11_v25+v1184 @ X10_v6*4]");
				obj31 = 0;
				array4 = array14;
				goto IL_2f82;
			}
		}
		goto IL_13fd;
	}

	protected virtual void AddKabboot(ISFSObject endRoundState)
	{
	}

	private void CalculateProjects(int[] teamAbnat, int[] teamProjectValue, ISFSArray[] teamProjects, int[] teamBalootProjectValue)
	{
		//IL_0b73: Expected O, but got I
		//IL_0b7f: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_0095: Expected O, but got I4
		//IL_00e1: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_0136: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_015e: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0188: Expected O, but got I4
		//IL_0198: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0769: Expected O, but got I
		//IL_0794: Expected O, but got I4
		//IL_0ac8: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_07ae: Expected O, but got I
		//IL_07d5: Expected O, but got I
		//IL_07fe: Expected O, but got I4
		//IL_0b90: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected O, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I4
		//IL_02e1: Expected O, but got I4
		//IL_02fb: Expected O, but got I4
		//IL_08ba: Expected O, but got I4
		//IL_08cb: Expected O, but got I4
		//IL_0ade: Expected O, but got I4
		//IL_0bdd: Expected O, but got I4
		//IL_0325: Expected O, but got I4
		//IL_0335: Expected O, but got I
		//IL_08f4: Expected O, but got I4
		//IL_0902: Expected O, but got I4
		//IL_0913: Expected O, but got I4
		//IL_0c06: Expected O, but got I4
		//IL_0b3e: Expected O, but got I4
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected O, but got Unknown
		//IL_0b17: Expected O, but got I4
		//IL_0937: Expected O, but got I
		//IL_0959: Expected O, but got I4
		//IL_096a: Expected O, but got I4
		//IL_0539: Expected O, but got I
		//IL_0559: Expected O, but got I4
		//IL_0a15: Expected O, but got I4
		//IL_0993: Expected O, but got I4
		//IL_09a1: Expected O, but got I4
		//IL_09b2: Expected O, but got I4
		//IL_057c: Expected O, but got I
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_09d4: Expected O, but got I4
		//IL_09ee: Expected O, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_0a30: Expected O, but got I4
		//IL_0a41: Expected O, but got I4
		//IL_063f: Expected O, but got I4
		//IL_0a64: Expected O, but got I4
		//IL_0a75: Expected O, but got I4
		//IL_065d: Expected O, but got I
		//IL_0a90: Expected O, but got I4
		//IL_0aa1: Expected O, but got I4
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_06ae: Expected O, but got I
		//IL_0359: Expected O, but got I
		//IL_06e9: Expected O, but got I
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3016;
		object obj2 = (nint)0 + (nint)1144;
		IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
		string text = (string)obj2;
		object[] array = Enumerable.ToArray(source);
		bool flag = array == null;
		ISFSArray[] array2 = teamProjects;
		int[] array3 = teamProjectValue;
		BalootProject balootProject = default(BalootProject);
		int num;
		List<System.Int32Enum>.Enumerator enumerator4;
		List<System.Int32Enum>.Enumerator enumerator3 = default(List<System.Int32Enum>.Enumerator);
		if (!flag)
		{
			if (array.Length < 1)
			{
				return;
			}
			object obj3 = array + 32;
			object obj4 = teamAbnat + 32;
			object obj5 = teamProjectValue + 32;
			object obj6 = teamProjects + 32;
			object obj7 = teamBalootProjectValue + 32;
			array2 = teamProjects;
			array3 = teamProjectValue;
			List<System.Int32Enum>.Enumerator enumerator = (List<System.Int32Enum>.Enumerator)0;
			int[] array4 = teamAbnat;
			object obj8 = 0;
			object[] array5 = array;
			SFSObject sFSObject = default(SFSObject);
			SFSObject sFSObject2 = default(SFSObject);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X9_v5+v183 @ X28_v7*8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X9_v5+v183 @ X28_v7*8]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X22_v8+10]");
				object obj10 = -1;
				bool flag2 = (nint)obj10 < 3;
				object obj11 = !flag2;
				object obj12 = obj10 - 3;
				bool flag3 = obj12 == null;
				object obj13 = !flag3;
				object obj14 = obj11 & obj13;
				object obj16;
				if (obj14 == null)
				{
					object obj15 = 118730752 + 3184;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X9_v39+v571 @ X8_v17*4]");
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X9_v39+v571 @ X8_v17*4]");
					if ((nint)0 != BestProjectTeam)
					{
						goto IL_00a2;
					}
				}
				else
				{
					bool flag4 = 0 != BestProjectTeam;
					obj16 = 0;
					if (flag4)
					{
						goto IL_00a2;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X22_v8+40]");
				if ((nint)0 == 0)
				{
					break;
				}
				obj = obj16 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X22_v8+40]");
				List<System.Int32Enum>.Enumerator enumerator2 = ((List<System.Int32Enum>)0).GetEnumerator();
				if (teamAbnat != null)
				{
					bool flag5 = teamProjectValue == null;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						object obj18 = (nint)0 + (nint)3400;
						text = (string)obj18;
						if (enumerator.MoveNext())
						{
							goto IL_02b9;
						}
					}
					else
					{
						while (true)
						{
							object obj19 = (nint)0 + (nint)3400;
							text = (string)obj19;
							if (!enumerator.MoveNext())
							{
								break;
							}
							int num2;
							if (balootProject <= BalootProject.P50)
							{
								if (balootProject != BalootProject.Sira)
								{
									bool flag6 = balootProject != BalootProject.P50;
									num = 0;
									num2 = 0;
									if (!flag6)
									{
										num2 = ((GameMode != BalootGame.BalootGameMode.Hokom) ? 10 : 5);
										num = 50;
									}
								}
								else
								{
									BalootGame.BalootGameMode balootGameMode = ((GameMode != BalootGame.BalootGameMode.Hokom) ? ((BalootGame.BalootGameMode)4) : GameMode);
									num = 20;
									num2 = (int)balootGameMode;
								}
							}
							else if (balootProject != BalootProject.P100)
							{
								bool flag7 = balootProject != BalootProject.P400;
								num = 0;
								num2 = 0;
								if (!flag7)
								{
									num2 = ((GameMode != BalootGame.BalootGameMode.Hokom) ? 40 : 20);
									num = 400;
								}
							}
							else
							{
								num2 = ((GameMode != BalootGame.BalootGameMode.Hokom) ? 20 : 10);
								num = 100;
							}
							bool flag8 = (nint)obj < teamAbnat.Length;
							object obj20 = !flag8;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X24_v6+v295 @ X21_v10*4]");
								object obj21 = (nint)0 + (nint)num;
								bool flag9 = (nint)obj < teamProjectValue.Length;
								object obj22 = !flag9;
								if (obj22 != null)
								{
									goto IL_09fb;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X19_v10+v295 @ X21_v10*4]");
								object obj23 = (nint)0 + (nint)num2;
								object obj24 = typeof(RegisteredWaitHandle) + 2040;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								sFSObject..ctor();
								string val = BalootProjectMethods.ServerStringValue(balootProject);
								object key = "m_StencilDeferredPS" + 2848;
								SFSExtensions.Put(sFSObject, (string)key, val);
								object obj25 = "utf-32" + 168;
								text = (string)obj25;
								SFSExtensions.Put(sFSObject, (string)obj25, num);
								if (teamProjects == null)
								{
									goto IL_0a1a;
								}
								bool flag10 = (nint)obj < teamProjects.Length;
								object obj26 = !flag10;
								if (obj26 != null)
								{
									goto IL_0a4e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+v295 @ X21_v10*8]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+v295 @ X21_v10*8]");
								if ((nint)0 != 0)
								{
									object obj28 = typeof(System.IOAsyncCallback) + 960;
									object obj29 = obj27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v64+12E]");
									object obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v64+12E]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v64+B0]");
										array4 = (int[])((nint)0 + (nint)8);
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X10_v13 (System.Int32[])-8]");
											if (0 == (nint)obj28)
											{
												break;
											}
											array4 = (int[])(array4 + 16);
											obj30--;
											if ((nint)obj30 != 1)
											{
												continue;
											}
											goto IL_033a;
										}
										object obj31 = array4 + 29;
										object obj32 = obj29 + obj31;
										object obj33 = obj32 + 312;
										goto IL_0349;
									}
									goto IL_033a;
								}
								goto IL_0a7a;
							}
							goto IL_0b24;
							IL_0349:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X0_v45+8]");
							array3 = (int[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v954 @ X0_v45] (should have been resolved before IL gen)");
							array2 = null;
							continue;
							IL_033a:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
							goto IL_0349;
						}
					}
				}
				else
				{
					object obj34 = (nint)0 + (nint)3400;
					text = (string)obj34;
					bool flag11 = enumerator.MoveNext();
					bool flag12 = !flag11;
					object obj35 = !flag12;
					if (obj35 != null)
					{
						goto IL_0aae;
					}
				}
				object obj36 = (nint)0 + (nint)3392;
				text = (string)obj36;
				enumerator.Dispose();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X22_v8+34]");
				object obj37 = (nint)0 & (nint)1;
				bool flag13 = obj37 == null;
				enumerator = enumerator3;
				enumerator4 = enumerator3;
				enumerator3 = (List<System.Int32Enum>.Enumerator)0;
				array5 = array;
				if (flag13)
				{
					goto IL_00a2;
				}
				object obj38 = typeof(RegisteredWaitHandle) + 2040;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				sFSObject2..ctor();
				object key2 = "m_StencilDeferredPS" + 2848;
				object val2 = "alignContent" + 3792;
				SFSExtensions.Put(sFSObject2, (string)key2, (string)val2);
				object obj39 = "utf-32" + 168;
				text = (string)obj39;
				SFSExtensions.Put(sFSObject2, (string)obj39, 20);
				bool flag14 = teamAbnat == null;
				array2 = null;
				array3 = (int[])20;
				enumerator4 = enumerator3;
				enumerator3 = (List<System.Int32Enum>.Enumerator)0;
				if (flag14)
				{
					break;
				}
				bool flag15 = (nint)obj < teamAbnat.Length;
				object obj40 = !flag15;
				array2 = null;
				array3 = (int[])20;
				enumerator4 = enumerator3;
				enumerator3 = (List<System.Int32Enum>.Enumerator)0;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X24_v6+v295 @ X21_v10*4]");
					object obj41 = (nint)0 + (nint)20;
					bool flag16 = teamBalootProjectValue == null;
					array2 = null;
					array3 = (int[])20;
					enumerator4 = enumerator3;
					enumerator3 = (List<System.Int32Enum>.Enumerator)0;
					if (flag16)
					{
						break;
					}
					bool flag17 = (nint)obj < teamBalootProjectValue.Length;
					object obj42 = !flag17;
					array2 = null;
					array3 = (int[])20;
					enumerator4 = enumerator3;
					enumerator3 = (List<System.Int32Enum>.Enumerator)0;
					if (obj42 == null)
					{
						_ = 2;
						array2 = null;
						array3 = (int[])20;
						enumerator = enumerator3;
						enumerator4 = enumerator3;
						enumerator3 = (List<System.Int32Enum>.Enumerator)0;
						array5 = array;
						goto IL_00a2;
					}
				}
				goto IL_0b52;
				IL_00a2:
				obj8++;
				if ((nint)obj8 < array5.Length)
				{
					continue;
				}
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b52;
		IL_0aae:
		NullReferenceException ex2 = new NullReferenceException();
		enumerator4 = enumerator3;
		enumerator3 = (List<System.Int32Enum>.Enumerator)0;
		IndexOutOfRangeException ex3 = (IndexOutOfRangeException)(object)ex2;
		goto IL_0c78;
		IL_0a1a:
		NullReferenceException ex4 = new NullReferenceException();
		array2 = null;
		array3 = (int[])num;
		enumerator4 = enumerator3;
		enumerator3 = (List<System.Int32Enum>.Enumerator)0;
		ex3 = (IndexOutOfRangeException)(object)ex4;
		goto IL_0c78;
		IL_0c78:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BC88");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0a7a:
		NullReferenceException ex5 = new NullReferenceException();
		array2 = null;
		array3 = (int[])num;
		enumerator4 = enumerator3;
		enumerator3 = (List<System.Int32Enum>.Enumerator)0;
		ex3 = (IndexOutOfRangeException)(object)ex5;
		goto IL_0c78;
		IL_02b9:
		bool flag18 = balootProject < BalootProject.P400;
		object obj43 = !flag18;
		object obj44 = balootProject - 3;
		bool flag19 = obj44 == null;
		object obj45 = !flag19;
		object obj46 = obj43 & obj45;
		object obj48;
		if (obj46 == null)
		{
			object obj47 = 119877632 + 1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X9_v36+v643 @ stack_-88 (BalootProject)*4]");
			obj48 = 0;
		}
		else
		{
			obj48 = 0;
		}
		bool flag20 = (nint)obj < teamAbnat.Length;
		object obj49 = !flag20;
		if (obj49 != null)
		{
			goto IL_0b24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X24_v6+v295 @ X21_v10*4]");
		object obj50 = 0 + obj48;
		NullReferenceException ex6 = new NullReferenceException();
		enumerator4 = enumerator3;
		enumerator3 = (List<System.Int32Enum>.Enumerator)0;
		ex3 = (IndexOutOfRangeException)(object)ex6;
		goto IL_0c78;
		IL_09fb:
		ex3 = new IndexOutOfRangeException();
		enumerator4 = enumerator3;
		enumerator3 = (List<System.Int32Enum>.Enumerator)0;
		goto IL_0c78;
		IL_0a4e:
		ex3 = new IndexOutOfRangeException();
		array2 = null;
		array3 = (int[])num;
		enumerator4 = enumerator3;
		enumerator3 = (List<System.Int32Enum>.Enumerator)0;
		goto IL_0c78;
		IL_0b52:
		ex3 = new IndexOutOfRangeException();
		goto IL_0c78;
		IL_0b24:
		ex3 = new IndexOutOfRangeException();
		enumerator4 = enumerator3;
		enumerator3 = (List<System.Int32Enum>.Enumerator)0;
		goto IL_0c78;
	}

	protected override void OnPlayCard(Card card, int playerIndex, ISFSObject param)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_02f0: Expected O, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_234f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2354: Expected O, but got Unknown
		//IL_01ef: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0689: Expected O, but got I
		//IL_0699: Expected O, but got I
		//IL_06a9: Expected O, but got I
		//IL_06cb: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0740: Expected I4, but got O
		//IL_076b: Expected O, but got I4
		//IL_060e: Expected O, but got I
		//IL_061e: Expected O, but got I
		//IL_062e: Expected O, but got I
		//IL_0650: Expected O, but got I4
		//IL_0703: Expected O, but got I4
		//IL_035a: Expected O, but got I8
		//IL_07a4: Expected O, but got I4
		//IL_243a: Unknown result type (might be due to invalid IL or missing references)
		//IL_243f: Expected O, but got Unknown
		//IL_2455: Expected O, but got I
		//IL_2466: Expected I, but got O
		//IL_2484: Expected O, but got I
		//IL_0733: Expected O, but got I
		//IL_2929: Expected O, but got I
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0257: Expected O, but got I
		//IL_0265: Expected I, but got O
		//IL_1eba: Expected I, but got O
		//IL_1ee3: Expected O, but got I4
		//IL_08d5: Expected O, but got I4
		//IL_07bf: Expected I, but got O
		//IL_07cf: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_0467: Expected O, but got I4
		//IL_1f17: Expected O, but got I
		//IL_0907: Expected O, but got I4
		//IL_02ad: Expected O, but got I
		//IL_02b5: Expected I4, but got O
		//IL_02ca: Expected O, but got I
		//IL_0492: Expected O, but got I
		//IL_2743: Expected O, but got I4
		//IL_260e: Expected O, but got I
		//IL_255d: Expected O, but got I4
		//IL_0811: Expected I, but got O
		//IL_083a: Expected O, but got I4
		//IL_03b3: Expected O, but got I4
		//IL_03ce: Expected O, but got I4
		//IL_0f74: Expected O, but got I
		//IL_0f84: Expected O, but got I
		//IL_0fa6: Expected O, but got I4
		//IL_0fc6: Expected O, but got I
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected O, but got Unknown
		//IL_0eed: Expected O, but got I
		//IL_0efd: Expected O, but got I
		//IL_0f1f: Expected O, but got I4
		//IL_0945: Expected O, but got I
		//IL_095d: Expected O, but got I
		//IL_086e: Expected O, but got I
		//IL_03f9: Expected O, but got I
		//IL_1150: Expected O, but got I
		//IL_1168: Expected O, but got I
		//IL_0ff6: Expected O, but got I4
		//IL_0c71: Expected O, but got I
		//IL_0c81: Expected O, but got I
		//IL_0c97: Expected O, but got I
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected O, but got Unknown
		//IL_0cbf: Expected O, but got I4
		//IL_0ccf: Expected O, but got I
		//IL_12cb: Expected O, but got I
		//IL_12db: Expected O, but got I
		//IL_12f1: Expected O, but got I
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ff: Expected O, but got Unknown
		//IL_1319: Expected O, but got I4
		//IL_1329: Expected O, but got I
		//IL_269f: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a4: Expected O, but got Unknown
		//IL_26ba: Expected O, but got I
		//IL_26cb: Expected I, but got O
		//IL_26e9: Expected O, but got I
		//IL_0f4d: Expected O, but got I
		//IL_0992: Expected O, but got I
		//IL_09a8: Expected O, but got I
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected O, but got Unknown
		//IL_09d5: Expected O, but got I
		//IL_08ac: Expected O, but got I4
		//IL_0434: Expected O, but got I
		//IL_119d: Expected O, but got I
		//IL_11b3: Expected O, but got I
		//IL_11bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c1: Expected O, but got Unknown
		//IL_11e0: Expected O, but got I
		//IL_1026: Expected O, but got I
		//IL_0d31: Expected O, but got I
		//IL_0d41: Expected O, but got I
		//IL_0d57: Expected O, but got I
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected O, but got Unknown
		//IL_0d09: Expected O, but got I4
		//IL_282d: Expected O, but got I
		//IL_138b: Expected O, but got I
		//IL_139b: Expected O, but got I
		//IL_13b1: Expected O, but got I
		//IL_13ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bf: Expected O, but got Unknown
		//IL_13d9: Expected O, but got I4
		//IL_13e9: Expected O, but got I
		//IL_1363: Expected O, but got I4
		//IL_105f: Expected I, but got O
		//IL_1088: Expected O, but got I4
		//IL_0a18: Expected O, but got I
		//IL_0a28: Expected O, but got I
		//IL_0a3e: Expected O, but got I
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Expected O, but got Unknown
		//IL_0a66: Expected O, but got I4
		//IL_0a76: Expected O, but got I
		//IL_04f4: Expected I, but got O
		//IL_051d: Expected O, but got I4
		//IL_20c9: Expected O, but got I
		//IL_20d9: Expected O, but got I
		//IL_20fb: Expected O, but got I4
		//IL_1faa: Expected I, but got O
		//IL_1fd3: Expected O, but got I4
		//IL_129e: Expected O, but got I4
		//IL_1223: Expected O, but got I
		//IL_1233: Expected O, but got I
		//IL_1249: Expected O, but got I
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_1257: Expected O, but got Unknown
		//IL_1276: Expected O, but got I
		//IL_0aa3: Expected O, but got I
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Expected O, but got Unknown
		//IL_0d92: Expected O, but got I
		//IL_2061: Expected O, but got I
		//IL_2071: Expected O, but got I
		//IL_2093: Expected O, but got I4
		//IL_142e: Expected O, but got I
		//IL_1453: Expected O, but got I
		//IL_10bc: Expected O, but got I
		//IL_0551: Expected O, but got I
		//IL_21be: Expected O, but got I
		//IL_21d8: Expected O, but got I4
		//IL_212b: Expected O, but got I4
		//IL_2007: Expected O, but got I
		//IL_19c3: Expected O, but got I
		//IL_19d3: Expected O, but got I
		//IL_19e9: Expected O, but got I
		//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f7: Expected O, but got Unknown
		//IL_1a11: Expected O, but got I4
		//IL_1a21: Expected O, but got I
		//IL_2876: Unknown result type (might be due to invalid IL or missing references)
		//IL_287b: Expected O, but got Unknown
		//IL_2891: Expected O, but got I
		//IL_28a2: Expected I, but got O
		//IL_28c0: Expected O, but got I
		//IL_1488: Expected O, but got I
		//IL_149e: Expected O, but got I
		//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ac: Expected O, but got Unknown
		//IL_14cb: Expected O, but got I
		//IL_215b: Expected O, but got I
		//IL_1a83: Expected O, but got I
		//IL_1a93: Expected O, but got I
		//IL_1aa9: Expected O, but got I
		//IL_1ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab7: Expected O, but got Unknown
		//IL_1a5b: Expected O, but got I4
		//IL_2201: Expected I, but got O
		//IL_222a: Expected O, but got I4
		//IL_150e: Expected O, but got I
		//IL_151e: Expected O, but got I
		//IL_1534: Expected O, but got I
		//IL_153d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1542: Expected O, but got Unknown
		//IL_155c: Expected O, but got I4
		//IL_156c: Expected O, but got I
		//IL_1599: Expected O, but got I
		//IL_15be: Expected O, but got I
		//IL_1ae4: Expected O, but got I
		//IL_05b7: Expected O, but got I4
		//IL_225e: Expected O, but got I
		//IL_1b03: Expected O, but got I
		//IL_1b13: Expected O, but got I
		//IL_1b29: Expected O, but got I
		//IL_1b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b37: Expected O, but got Unknown
		//IL_1b51: Expected O, but got I4
		//IL_1b61: Expected O, but got I
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected O, but got Unknown
		//IL_0b7e: Expected I, but got O
		//IL_0b8e: Expected O, but got I
		//IL_15f3: Expected O, but got I
		//IL_1609: Expected O, but got I
		//IL_1612: Unknown result type (might be due to invalid IL or missing references)
		//IL_1617: Expected O, but got Unknown
		//IL_1636: Expected O, but got I
		//IL_0c44: Expected O, but got I4
		//IL_1bc3: Expected O, but got I
		//IL_1bd3: Expected O, but got I
		//IL_1be9: Expected O, but got I
		//IL_1bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Expected O, but got Unknown
		//IL_1b9b: Expected O, but got I4
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e07: Expected O, but got Unknown
		//IL_0e0f: Expected I, but got O
		//IL_0e1f: Expected O, but got I
		//IL_0bc9: Expected O, but got I
		//IL_1679: Expected O, but got I
		//IL_1689: Expected O, but got I
		//IL_169f: Expected O, but got I
		//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Expected O, but got Unknown
		//IL_16c7: Expected O, but got I4
		//IL_16d7: Expected O, but got I
		//IL_1704: Expected O, but got I
		//IL_1729: Expected O, but got I
		//IL_1c24: Expected O, but got I
		//IL_25cb: Expected O, but got I
		//IL_25dd: Expected I4, but got O
		//IL_0e5a: Expected O, but got I
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Expected O, but got Unknown
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected O, but got Unknown
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc0: Expected O, but got Unknown
		//IL_1c43: Expected O, but got I
		//IL_1c53: Expected O, but got I
		//IL_1c69: Expected O, but got I
		//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c77: Expected O, but got Unknown
		//IL_1c91: Expected O, but got I4
		//IL_1ca1: Expected O, but got I
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Expected O, but got Unknown
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Expected O, but got Unknown
		//IL_175e: Expected O, but got I
		//IL_1774: Expected O, but got I
		//IL_177d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1782: Expected O, but got Unknown
		//IL_17a1: Expected O, but got I
		//IL_0eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Expected O, but got Unknown
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected O, but got Unknown
		//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Expected O, but got Unknown
		//IL_1d03: Expected O, but got I
		//IL_1d13: Expected O, but got I
		//IL_1d29: Expected O, but got I
		//IL_1d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d37: Expected O, but got Unknown
		//IL_1cdb: Expected O, but got I4
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Expected O, but got Unknown
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Expected O, but got Unknown
		//IL_17e4: Expected O, but got I
		//IL_17f4: Expected O, but got I
		//IL_180a: Expected O, but got I
		//IL_1813: Unknown result type (might be due to invalid IL or missing references)
		//IL_1818: Expected O, but got Unknown
		//IL_1832: Expected O, but got I4
		//IL_1842: Expected O, but got I
		//IL_186f: Expected O, but got I
		//IL_1d64: Expected O, but got I
		//IL_18b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b9: Expected O, but got Unknown
		//IL_18c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c8: Expected O, but got Unknown
		//IL_18d0: Expected I, but got O
		//IL_18e0: Expected O, but got I
		//IL_1996: Expected O, but got I4
		//IL_1dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd9: Expected O, but got Unknown
		//IL_1de1: Expected I, but got O
		//IL_1df1: Expected O, but got I
		//IL_191b: Expected O, but got I
		//IL_27a9: Expected O, but got I
		//IL_1e2c: Expected O, but got I
		//IL_1d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d77: Expected O, but got Unknown
		//IL_1d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d84: Expected O, but got Unknown
		//IL_1d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d92: Expected O, but got Unknown
		//IL_1929: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Expected O, but got Unknown
		//IL_1937: Unknown result type (might be due to invalid IL or missing references)
		//IL_193c: Expected O, but got Unknown
		//IL_1e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8a: Expected O, but got Unknown
		//IL_1e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e97: Expected O, but got Unknown
		//IL_1ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea5: Expected O, but got Unknown
		//IL_1e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3f: Expected O, but got Unknown
		//IL_1e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4d: Expected O, but got Unknown
		ISFSObject iSFSObject = default(ISFSObject);
		base.OnPlayCard(card, playerIndex, iSFSObject);
		object obj2;
		int num2;
		IEnumerable<int> enumerable = default(IEnumerable<int>);
		IEnumerable<System.Int32Enum> enumerable2;
		int num3;
		IEnumerable<System.Int32Enum> enumerable3;
		if (iSFSObject != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 976;
			obj2 = "placementId" + 1024;
			nint num = (nint)iSFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X10_v47-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 23;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v286+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v770 @ X0_v286] (should have been resolved before IL gen)");
			bool flag = enumerable == null;
			enumerable2 = (IEnumerable<System.Int32Enum>)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v286+8]");
			num3 = 0;
			enumerable3 = (IEnumerable<System.Int32Enum>)obj2;
			if (!flag)
			{
				goto IL_01ad;
			}
			goto IL_02dc;
		}
		goto IL_2291;
		IL_1284:
		SFSArray sFSArray = default(SFSArray);
		bool flag2 = sFSArray == null;
		object obj8 = !flag2;
		if (obj8 != null)
		{
			goto IL_141e;
		}
		goto IL_2291;
		IL_0a08:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X21_v15+38]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v231+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v231+10]");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11 & 1;
		bool flag3 = obj12 == null;
		object obj13 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v231+10]");
		object obj14 = 0;
		if (obj13 == null)
		{
			goto IL_0a84;
		}
		goto IL_0a93;
		IL_0a84:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0a93;
		IL_0a93:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1460 @ X0_v186+B8]");
		object val = 0;
		object obj15 = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray2 = default(SFSArray);
		sFSArray2..ctor();
		object obj17;
		ISFSObject iSFSObject3;
		if (sFSArray2 != null)
		{
			sFSArray2.AddUtfStringArray((string[])val);
			sFSArray2.AddUtfStringArray((string[])val);
			sFSArray2.AddUtfStringArray((string[])val);
			sFSArray2.AddUtfStringArray((string[])val);
			ISFSObject iSFSObject2 = base.<RoundState>k__BackingField;
			if (base.<RoundState>k__BackingField != null)
			{
				object obj16 = typeof(System.IOAsyncCallback) + 976;
				obj17 = "destinationTimeZone" + 816;
				nint num4 = (nint)iSFSObject2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1688 @ X8_v218 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1688 @ X8_v218 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0c0a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1688 @ X8_v218 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X10_v39-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj19 += 16;
					obj18--;
					if ((nint)obj18 != 1)
					{
						continue;
					}
					goto IL_0c0a;
				}
				object obj20 = obj19 + 2;
				object obj21 = num4 + obj20;
				object obj22 = obj21 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1763 @ X0_v204] (should have been resolved before IL gen)");
				iSFSObject3 = base.<RoundState>k__BackingField;
				if (base.<RoundState>k__BackingField != null)
				{
					goto IL_0df3;
				}
			}
		}
		goto IL_2291;
		IL_2109:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ X0_v37+E4]");
		bool flag4 = (nint)0 == 0;
		object obj23 = !flag4;
		object obj25;
		object obj26;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1645 @ X8_v47+B8]");
			obj26 = 0;
		}
		object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)776;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj26, (IntPtr)obj28);
		object obj29 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X8_v46+B8]");
		object obj30 = (nint)0 + (nint)24;
		obj30 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		iSFSObject = null;
		Func<object, object> selector = func;
		goto IL_2160;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v283+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v539 @ X0_v283] (should have been resolved before IL gen)");
		bool flag5 = enumerable == null;
		object obj31 = !flag5;
		enumerable2 = (IEnumerable<System.Int32Enum>)obj2;
		if (obj31 != null)
		{
			goto IL_01ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v283+8]");
		num3 = 0;
		enumerable3 = (IEnumerable<System.Int32Enum>)obj2;
		goto IL_02dc;
		IL_01ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v266 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
		bool flag6 = (nint)0 == 0;
		num3 = num2;
		enumerable3 = enumerable2;
		if (flag6)
		{
			goto IL_02dc;
		}
		object obj32 = (nint)0 + (nint)1144;
		IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
		object[] array = Enumerable.ToArray(source);
		if (array != null)
		{
			object obj33 = array[0];
			if (array[0] != null)
			{
				object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1824;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj35 = (nint)0 + (nint)2344;
				Func<int, System.Int32Enum> func2 = default(Func<int, System.Int32Enum>);
				func2..ctor((object)null, (IntPtr)obj35);
				IEnumerable<System.Int32Enum> enumerable4 = Enumerable.Select(enumerable, func2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v296 (System.Object)+40]");
				if ((nint)0 != 0)
				{
					object obj36 = (nint)0 + (nint)1488;
					num3 = (int)obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v296 (System.Object)+40]");
					((List<System.Int32Enum>)0).AddRange(enumerable4);
					iSFSObject = null;
					enumerable3 = enumerable4;
					goto IL_02dc;
				}
			}
		}
		goto IL_2291;
		IL_1850:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_185f;
		IL_17d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1904 @ X22_v21+38]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1935 @ X8_v121+10]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1935 @ X8_v121+10]");
		object obj39 = (nint)0 + (nint)309;
		object obj40 = obj39 & 1;
		bool flag7 = obj40 == null;
		object obj41 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1935 @ X8_v121+10]");
		object obj42 = 0;
		if (obj41 == null)
		{
			goto IL_1850;
		}
		goto IL_185f;
		IL_2799:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2080 @ X0_v99+8]");
		iSFSObject = (ISFSObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2080 @ X0_v99] (should have been resolved before IL gen)");
		SFSArray sFSArray3 = sFSArray;
		int num6;
		int num5 = num6;
		goto IL_295b;
		IL_14d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X0_v68+E4]");
		if ((nint)0 != 0)
		{
			goto IL_14fe;
		}
		goto IL_1a69;
		IL_141e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1618 @ X0_v66+B8]");
		object val2 = 0;
		sFSArray.AddIntArray((int[])val2);
		object obj44;
		object obj43 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ X22_v19+38]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ X22_v19+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v70+10]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v70+10]");
			object obj47 = (nint)0 + (nint)309;
			object obj48 = obj47 & 1;
			bool flag8 = obj48 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v70+10]");
			object obj49 = 0;
			if (!flag8)
			{
				goto IL_14d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ X22_v19+38]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X8_v77+10]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X8_v77+10]");
			object obj51 = (nint)0 + (nint)309;
			object obj52 = obj51 & 1;
			bool flag9 = obj52 == null;
			object obj53 = !flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X8_v77+10]");
			object obj49 = 0;
			if (obj53 != null)
			{
				goto IL_14d9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X0_v68+E4]");
		bool flag10 = (nint)0 == 0;
		object obj54 = !flag10;
		if (obj54 != null)
		{
			goto IL_14fe;
		}
		goto IL_1a69;
		IL_02dc:
		BalootProjectShown = false;
		object obj55 = 152993792;
		object obj56 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2024;
		if (GameMode == BalootGame.BalootGameMode.Hokom)
		{
			if (card != null)
			{
				object obj57 = (long)card.<Rank>k__BackingField & 0xFFFFFFFEL;
				if ((nint)obj57 != 10 || card.<Suit>k__BackingField != TrumpSuit)
				{
					goto IL_290d;
				}
				IEnumerable<object> source2 = Enumerable.Cast<object>(base.Players);
				object[] array2 = Enumerable.ToArray(source2);
				if (array2 != null)
				{
					object obj58 = playerIndex - 1;
					bool flag11 = (nint)obj58 < array2.Length;
					object obj59 = !flag11;
					if (obj59 != null)
					{
						goto IL_22ad;
					}
					object obj60 = (object)array2 + obj58;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X8_v288+20]");
					object obj61 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X8_v288+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v289+30]");
						object obj62 = (nint)0 + (nint)1;
						goto IL_290d;
					}
				}
			}
			goto IL_2291;
		}
		goto IL_2340;
		IL_2160:
		object[] source4;
		IEnumerable<object> source3 = Enumerable.Select(source4, selector);
		List<object> playersCards = Enumerable.ToList(source3);
		int bestProjectTeam = BalootUtils.GetBestProjectTeam(Dealer, (List<List<Card>>)(object)playersCards, GameMode);
		BestProjectTeam = bestProjectTeam;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X26_v4+C1]");
		object obj63 = (nint)0 & (nint)1;
		bool flag12 = obj63 == null;
		object obj64 = !flag12;
		if (obj64 == null)
		{
			_ = 1;
		}
		BalootPlayingManager playingManager = (BalootPlayingManager)base.PlayingManager;
		if (base.PlayingManager == null)
		{
			goto IL_2291;
		}
		object obj65 = obj56;
		nint num7 = (nint)playingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v35 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+130]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X1_v21+130]");
		bool flag13 = num8 < 0;
		object obj66 = !flag13;
		object obj67 = ~obj66;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v35 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+C8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X1_v21+130]");
			object obj68 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1709 @ X8_v37-8]");
			if (0 == (nint)obj65)
			{
				((BalootPlayingManager)base.PlayingManager).UpdateProjectSecondMove();
				return;
			}
		}
		goto IL_229f;
		IL_0c0a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1726 @ X0_v201] (should have been resolved before IL gen)");
		iSFSObject3 = base.<RoundState>k__BackingField;
		bool flag14 = base.<RoundState>k__BackingField == null;
		object obj69 = !flag14;
		if (obj69 != null)
		{
			goto IL_0df3;
		}
		goto IL_2291;
		IL_0df3:
		object obj70 = typeof(System.IOAsyncCallback) + 976;
		nint num10 = (nint)iSFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1786 @ X8_v222 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1786 @ X8_v222 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e9b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1786 @ X8_v222 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj72 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1850 @ X10_v34-8]");
			if (0 == (nint)obj70)
			{
				break;
			}
			obj72 += 16;
			obj71--;
			if ((nint)obj71 != 1)
			{
				continue;
			}
			goto IL_0e9b;
		}
		object obj73 = obj72 + 49;
		object obj74 = num10 + obj73;
		object obj75 = obj74 + 312;
		goto IL_25bb;
		IL_1a69:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ X22_v19+38]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1741 @ X8_v72+10]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1741 @ X8_v72+10]");
		object obj78 = (nint)0 + (nint)309;
		object obj79 = obj78 & 1;
		if (obj79 == null)
		{
			goto IL_157a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1741 @ X8_v72+10]");
		object obj80 = 0;
		goto IL_1589;
		IL_185f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1954 @ X0_v96+B8]");
		object val3 = 0;
		sFSArray.AddIntArray((int[])val3);
		ISFSObject iSFSObject4 = base.<RoundState>k__BackingField;
		ISFSObject iSFSObject5;
		if (base.<RoundState>k__BackingField != null)
		{
			object obj81 = typeof(System.IOAsyncCallback) + 976;
			object obj82 = "placementId" + 536;
			nint num11 = (nint)iSFSObject4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v108 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj83 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v108 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_195c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v108 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj84 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X10_v25-8]");
				if (0 == (nint)obj81)
				{
					break;
				}
				obj84 += 16;
				obj83--;
				if ((nint)obj83 != 1)
				{
					continue;
				}
				goto IL_195c;
			}
			object obj85 = obj84 + 2;
			object obj86 = num11 + obj85;
			object obj87 = obj86 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1999 @ X0_v109] (should have been resolved before IL gen)");
			iSFSObject5 = base.<RoundState>k__BackingField;
			if (base.<RoundState>k__BackingField != null)
			{
				goto IL_1dc5;
			}
		}
		goto IL_2291;
		IL_14fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ X22_v19+38]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1696 @ X8_v139+10]");
		obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1696 @ X8_v139+10]");
		object obj89 = (nint)0 + (nint)309;
		object obj90 = obj89 & 1;
		bool flag15 = obj90 == null;
		object obj91 = !flag15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1696 @ X8_v139+10]");
		obj80 = 0;
		if (obj91 == null)
		{
			goto IL_157a;
		}
		goto IL_1589;
		IL_2291:
		NullReferenceException ex = new NullReferenceException();
		goto IL_229f;
		IL_290d:
		IEnumerable<object> source5 = Enumerable.Cast<object>(base.Players);
		object obj92 = (nint)0 + (nint)1144;
		enumerable3 = (IEnumerable<System.Int32Enum>)obj92;
		object[] array3 = Enumerable.ToArray(source5);
		if (array3 != null)
		{
			object obj93 = playerIndex - 1;
			bool flag16 = (nint)obj93 < array3.Length;
			object obj94 = !flag16;
			if (obj94 != null)
			{
				goto IL_22ad;
			}
			object obj95 = (object)array3 + obj93;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X8_v263+20]");
			object obj96 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X8_v263+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v264+30]");
				if ((nint)0 != 2)
				{
					goto IL_2340;
				}
				BalootPlayingManager playingManager2 = (BalootPlayingManager)base.PlayingManager;
				if (base.PlayingManager != null)
				{
					object obj97 = obj56;
					nint num12 = (nint)playingManager2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v268 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+130]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X1_v72+130]");
					bool flag17 = num13 < 0;
					object obj98 = !flag17;
					object obj99 = ~obj98;
					if (obj99 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v268 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+C8]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X1_v72+130]");
						object obj100 = num14 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ X8_v270-8]");
						if (0 == (nint)obj97)
						{
							num3 = BestProjectTeam;
							((BalootPlayingManager)base.PlayingManager).CheckBaloot(playerIndex, BestProjectTeam);
							IEnumerable<object> source6 = Enumerable.Cast<object>(base.Players);
							enumerable3 = (IEnumerable<System.Int32Enum>)obj92;
							object[] array4 = Enumerable.ToArray(source6);
							if (array4 != null)
							{
								bool flag18 = (nint)obj93 < array4.Length;
								object obj101 = !flag18;
								if (obj101 != null)
								{
									goto IL_22ad;
								}
								object obj102 = (object)array4 + obj93;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1635 @ X8_v275+20]");
								if ((nint)0 != 0)
								{
									_ = 0;
									goto IL_2340;
								}
							}
							goto IL_2291;
						}
					}
					goto IL_229f;
				}
			}
		}
		goto IL_2291;
		IL_0e9b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_25bb;
		IL_25bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1884 @ X0_v194+8]");
		iSFSObject = (ISFSObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1884 @ X0_v194] (should have been resolved before IL gen)");
		int num15 = (int)sFSArray2;
		Card card2 = (Card)obj17;
		int num16;
		num5 = num16;
		goto IL_250a;
		IL_1669:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ X22_v20+38]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1866 @ X8_v130+10]");
		object obj104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1866 @ X8_v130+10]");
		object obj105 = (nint)0 + (nint)309;
		object obj106 = obj105 & 1;
		bool flag19 = obj106 == null;
		object obj107 = !flag19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1866 @ X8_v130+10]");
		object obj108 = 0;
		if (obj107 == null)
		{
			goto IL_16e5;
		}
		goto IL_16f4;
		IL_1dc5:
		object obj109 = typeof(System.IOAsyncCallback) + 976;
		nint num17 = (nint)iSFSObject5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2022 @ X8_v112 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2022 @ X8_v112 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1e6d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2022 @ X8_v112 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj111 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2063 @ X10_v20-8]");
			if (0 == (nint)obj109)
			{
				break;
			}
			obj111 += 16;
			obj110--;
			if ((nint)obj110 != 1)
			{
				continue;
			}
			goto IL_1e6d;
		}
		object obj112 = obj111 + 49;
		object obj113 = num17 + obj112;
		object obj114 = obj113 + 312;
		goto IL_2799;
		IL_16f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X0_v86+B8]");
		object val4 = 0;
		sFSArray.AddIntArray((int[])val4);
		object obj115 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1904 @ X22_v21+38]");
		object obj116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1904 @ X22_v21+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1905 @ X8_v94+10]");
			object obj117 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1905 @ X8_v94+10]");
			object obj118 = (nint)0 + (nint)309;
			object obj119 = obj118 & 1;
			bool flag20 = obj119 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1905 @ X8_v94+10]");
			object obj120 = 0;
			if (!flag20)
			{
				goto IL_17af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1904 @ X22_v21+38]");
			object obj121 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1926 @ X8_v101+10]");
			object obj117 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1926 @ X8_v101+10]");
			object obj122 = (nint)0 + (nint)309;
			object obj123 = obj122 & 1;
			bool flag21 = obj123 == null;
			object obj124 = !flag21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1926 @ X8_v101+10]");
			object obj120 = 0;
			if (obj124 != null)
			{
				goto IL_17af;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1942 @ X0_v88+E4]");
		bool flag22 = (nint)0 == 0;
		object obj125 = !flag22;
		if (obj125 != null)
		{
			goto IL_17d4;
		}
		goto IL_1ce9;
		IL_16e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_16f4;
		IL_250a:
		int moveNumber = MoveNumber;
		goto IL_2519;
		IL_2519:
		bool flag23 = moveNumber != 2;
		BalootGame.BalootGameMode balootGameMode = (BalootGame.BalootGameMode)num15;
		object obj128;
		Func<object, object> selector2;
		object[] array6;
		if (!flag23)
		{
			IEnumerable<object> source7 = Enumerable.Cast<object>(base.Players);
			object obj126 = (nint)0 + (nint)1144;
			object[] array5 = Enumerable.ToArray(source7);
			object obj127 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X0_v161+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X0_v161+B8]");
				obj128 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v186+10]");
				selector2 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v186+10]");
				bool flag24 = (nint)0 == 0;
				object obj129 = !flag24;
				iSFSObject = (ISFSObject)(object)array5;
				if (obj129 == null)
				{
					array6 = array5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v186+10]");
					Func<object, object> func3 = (Func<object, object>)0;
					goto IL_0fd4;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj127 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X0_v161+B8]");
				obj128 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v186+10]");
				Func<object, object> func3 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v186+10]");
				bool flag25 = (nint)0 == 0;
				object obj130 = !flag25;
				array6 = array5;
				iSFSObject = (ISFSObject)(object)array5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v186+10]");
				selector2 = (Func<object, object>)0;
				if (obj130 == null)
				{
					goto IL_0fd4;
				}
			}
			goto IL_2648;
		}
		goto IL_2984;
		IL_157a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_1589;
		IL_22ad:
		throw new IndexOutOfRangeException();
		IL_2340:
		obj25 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2608;
		object obj131 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v220+E4]");
		object obj132;
		object obj133;
		Func<object, bool> func4;
		object obj135;
		if ((nint)0 != 0)
		{
			obj132 = (nint)0 + (nint)3496;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v220+B8]");
			obj133 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v247+8]");
			func4 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v247+8]");
			bool flag26 = (nint)0 == 0;
			object obj134 = !flag26;
			if (obj134 == null)
			{
				obj135 = obj132;
				goto IL_06e1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj131 = obj25;
			obj135 = (nint)0 + (nint)3496;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v220+B8]");
			obj133 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v247+8]");
			func4 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v247+8]");
			bool flag27 = (nint)0 == 0;
			object obj136 = !flag27;
			obj132 = obj135;
			if (obj136 == null)
			{
				goto IL_06e1;
			}
		}
		goto IL_0738;
		IL_27c8:
		int moveNumber2;
		if (moveNumber2 != 2)
		{
			return;
		}
		IEnumerable<object> source8 = Enumerable.Cast<object>(base.Players);
		object obj137 = (nint)0 + (nint)1144;
		source4 = Enumerable.ToArray(source8);
		object obj138 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ X0_v37+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ X0_v37+B8]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1627 @ X8_v41+18]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1627 @ X8_v41+18]");
			bool flag28 = (nint)0 == 0;
			object obj139 = !flag28;
			if (obj139 == null)
			{
				goto IL_2109;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj138 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ X0_v37+B8]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1627 @ X8_v41+18]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1627 @ X8_v41+18]");
			bool flag29 = (nint)0 == 0;
			object obj140 = !flag29;
			if (obj140 == null)
			{
				goto IL_2109;
			}
		}
		goto IL_2160;
		IL_1589:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1734 @ X0_v76+B8]");
		object val5 = 0;
		sFSArray.AddIntArray((int[])val5);
		object obj141 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ X22_v20+38]");
		object obj142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ X22_v20+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ X8_v82+10]");
			object obj143 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ X8_v82+10]");
			object obj144 = (nint)0 + (nint)309;
			object obj145 = obj144 & 1;
			bool flag30 = obj145 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ X8_v82+10]");
			object obj146 = 0;
			if (!flag30)
			{
				goto IL_1644;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ X22_v20+38]");
			object obj147 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1836 @ X8_v89+10]");
			object obj143 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1836 @ X8_v89+10]");
			object obj148 = (nint)0 + (nint)309;
			object obj149 = obj148 & 1;
			bool flag31 = obj149 == null;
			object obj150 = !flag31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1836 @ X8_v89+10]");
			object obj146 = 0;
			if (obj150 != null)
			{
				goto IL_1644;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1873 @ X0_v78+E4]");
		bool flag32 = (nint)0 == 0;
		object obj151 = !flag32;
		if (obj151 != null)
		{
			goto IL_1669;
		}
		goto IL_1ba9;
		IL_0fd4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X0_v161+E4]");
		bool flag33 = (nint)0 == 0;
		object obj152 = !flag33;
		if (obj152 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj153 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X8_v192+B8]");
			obj128 = 0;
		}
		object obj154 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj155 = (nint)0 + (nint)768;
		Func<object, object> func5 = default(Func<object, object>);
		func5..ctor(obj128, (IntPtr)obj155);
		object obj156 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X8_v191+B8]");
		object obj157 = (nint)0 + (nint)16;
		obj157 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		iSFSObject = (ISFSObject)(object)array6;
		selector2 = func5;
		goto IL_2648;
		IL_06e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v220+E4]");
		bool flag34 = (nint)0 == 0;
		object obj158 = !flag34;
		if (obj158 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj159 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X8_v253+B8]");
			obj133 = 0;
		}
		object obj160 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj161 = (nint)0 + (nint)760;
		Func<object, bool> func6 = default(Func<object, bool>);
		func6..ctor(obj133, (IntPtr)obj161);
		object obj162 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v252+B8]");
		object obj163 = (nint)0 + (nint)8;
		obj163 = func6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj132 = obj135;
		iSFSObject = null;
		func4 = func6;
		goto IL_0738;
		IL_295b:
		PlayingManager playingManager3 = base.PlayingManager;
		if (base.PlayingManager == null)
		{
			goto IL_2291;
		}
		object obj164 = obj56;
		nint num18 = (nint)playingManager3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v17 (Il2CppClass<KammelnaOffline.Common.PlayingManager>)+130]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X1_v11+130]");
		bool flag35 = num19 < 0;
		object obj165 = !flag35;
		object obj166 = ~obj165;
		if (obj166 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v17 (Il2CppClass<KammelnaOffline.Common.PlayingManager>)+C8]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X1_v11+130]");
			object obj167 = num20 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X9_v12-8]");
			if (0 == (nint)obj164)
			{
				base.PlayingManager.OnPlay();
				if (num5 != 4)
				{
					return;
				}
				moveNumber2 = MoveNumber;
				if (MoveNumber != 1)
				{
					goto IL_27c8;
				}
				BalootPlayingManager playingManager4 = (BalootPlayingManager)base.PlayingManager;
				if (base.PlayingManager == null)
				{
					goto IL_2291;
				}
				object obj168 = obj56;
				nint num21 = (nint)playingManager4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v54 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+130]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X1_v24+130]");
				bool flag36 = num22 < 0;
				object obj169 = !flag36;
				object obj170 = ~obj169;
				if (obj170 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v54 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+C8]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X1_v24+130]");
					object obj171 = num23 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1441 @ X8_v56-8]");
					if (0 == (nint)obj168)
					{
						((BalootPlayingManager)base.PlayingManager).UpdateDeclaredProjectsFirstMove(playerIndex);
						moveNumber2 = MoveNumber;
						goto IL_27c8;
					}
				}
			}
		}
		goto IL_229f;
		IL_1644:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1873 @ X0_v78+E4]");
		if ((nint)0 != 0)
		{
			goto IL_1669;
		}
		goto IL_1ba9;
		IL_0738:
		num15 = (int)obj132;
		int num24 = Enumerable.Count(PlayedCards, func4);
		bool flag37 = num24 == 4;
		object obj172 = 0;
		sFSArray3 = (SFSArray)obj132;
		num5 = num24;
		if (!flag37)
		{
			bool flag38 = num24 != 1;
			obj172 = 0;
			card2 = (Card)(object)func4;
			if (!flag38)
			{
				nint num25 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v245 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+430]");
				obj172 = 0;
				CheckEkkah(card, playerIndex);
				iSFSObject = null;
				num15 = playerIndex;
				card2 = card;
			}
			moveNumber = MoveNumber;
			if (MoveNumber != 1)
			{
				bool flag39 = !BalootProjectShown;
				object obj173 = !flag39;
				num5 = num24;
				if (obj173 == null)
				{
					bool flag40 = !EkkahProjectShown;
					object obj174 = !flag40;
					object obj175 = ~obj174;
					num16 = ((obj175 != null) ? num24 : 0);
					bool flag41 = !EkkahProjectShown;
					object obj176 = !flag41;
					num5 = num24;
					if (obj176 == null)
					{
						object obj177 = (nint)0 + (nint)3336;
						object obj178 = obj177;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X21_v15+38]");
						object obj179 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X21_v15+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X8_v202+10]");
							object obj180 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X8_v202+10]");
							object obj181 = (nint)0 + (nint)309;
							object obj182 = obj181 & 1;
							bool flag42 = obj182 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X8_v202+10]");
							object obj183 = 0;
							if (!flag42)
							{
								goto IL_09e3;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X21_v15+38]");
							object obj184 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X8_v209+10]");
							object obj180 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X8_v209+10]");
							object obj185 = (nint)0 + (nint)309;
							object obj186 = obj185 & 1;
							bool flag43 = obj186 == null;
							object obj187 = !flag43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X8_v209+10]");
							object obj183 = 0;
							if (obj187 != null)
							{
								goto IL_09e3;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v178+E4]");
						bool flag44 = (nint)0 == 0;
						object obj188 = !flag44;
						if (obj188 != null)
						{
							goto IL_0a08;
						}
						goto IL_0d17;
					}
					goto IL_250a;
				}
				goto IL_2519;
			}
			BalootPlayingManager playingManager5 = (BalootPlayingManager)base.PlayingManager;
			if (base.PlayingManager == null)
			{
				goto IL_2291;
			}
			object obj189 = obj56;
			nint num26 = (nint)playingManager5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v240 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+130]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X1_v64+130]");
			bool flag45 = num27 < 0;
			object obj190 = !flag45;
			object obj191 = ~obj190;
			if (obj191 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v240 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+C8]");
				nint num28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X1_v64+130]");
				object obj192 = num28 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1240 @ X8_v242-8]");
				if (0 == (nint)obj189)
				{
					((BalootPlayingManager)base.PlayingManager).UpdateDeclaredProjectsFirstMove(playerIndex);
					card2 = (Card)playerIndex;
					num5 = num24;
					goto IL_250a;
				}
			}
			goto IL_229f;
		}
		goto IL_295b;
		IL_2648:
		IEnumerable<object> source9 = Enumerable.Select((IEnumerable<object>)iSFSObject, selector2);
		List<object> playersCards2 = Enumerable.ToList(source9);
		balootGameMode = GameMode;
		int bestProjectTeam2 = BalootUtils.GetBestProjectTeam(Dealer, (List<List<Card>>)(object)playersCards2, GameMode);
		BestProjectTeam = bestProjectTeam2;
		BalootPlayingManager playingManager6 = (BalootPlayingManager)base.PlayingManager;
		if (base.PlayingManager == null)
		{
			goto IL_2291;
		}
		card2 = (Card)obj56;
		nint num29 = (nint)playingManager6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v179 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+130]");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X1_v52 (Card)+130]");
		bool flag46 = num30 < 0;
		object obj193 = !flag46;
		object obj194 = ~obj193;
		if (obj194 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v179 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+C8]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X1_v52 (Card)+130]");
			object obj195 = num31 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1640 @ X8_v181-8]");
			if (0 == (nint)card2)
			{
				((BalootPlayingManager)base.PlayingManager).UpdateProjectSecondMove();
				moveNumber = MoveNumber;
				goto IL_2984;
			}
		}
		goto IL_229f;
		IL_1e6d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_2799;
		IL_1ba9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ X22_v20+38]");
		object obj196 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v84+10]");
		obj104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v84+10]");
		object obj197 = (nint)0 + (nint)309;
		object obj198 = obj197 & 1;
		if (obj198 == null)
		{
			goto IL_16e5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v84+10]");
		obj108 = 0;
		goto IL_16f4;
		IL_2984:
		num6 = ((moveNumber == 3) ? num5 : 0);
		bool flag47 = moveNumber != 3;
		sFSArray3 = (SFSArray)balootGameMode;
		if (!flag47)
		{
			object obj199 = typeof(RegisteredWaitHandle) + 1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSArray..ctor();
			obj44 = (nint)0 + (nint)3168;
			object obj200 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X22_v18+38]");
			object obj201 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X22_v18+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X8_v67+10]");
				object obj202 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X8_v67+10]");
				object obj203 = (nint)0 + (nint)309;
				object obj204 = obj203 & 1;
				bool flag48 = obj204 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X8_v67+10]");
				object obj205 = 0;
				if (!flag48)
				{
					goto IL_11ee;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X22_v18+38]");
				object obj206 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X8_v153+10]");
				object obj202 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X8_v153+10]");
				object obj207 = (nint)0 + (nint)309;
				object obj208 = obj207 & 1;
				bool flag49 = obj208 == null;
				object obj209 = !flag49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X8_v153+10]");
				object obj205 = 0;
				if (obj209 != null)
				{
					goto IL_11ee;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1552 @ X0_v132+E4]");
			bool flag50 = (nint)0 == 0;
			object obj210 = !flag50;
			if (obj210 != null)
			{
				goto IL_1213;
			}
			goto IL_1371;
		}
		goto IL_295b;
		IL_195c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1982 @ X0_v106] (should have been resolved before IL gen)");
		iSFSObject5 = base.<RoundState>k__BackingField;
		bool flag51 = base.<RoundState>k__BackingField == null;
		object obj211 = !flag51;
		if (obj211 != null)
		{
			goto IL_1dc5;
		}
		goto IL_2291;
		IL_229f:
		InvalidCastException ex2 = new InvalidCastException();
		goto IL_22ad;
		IL_17af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1942 @ X0_v88+E4]");
		if ((nint)0 != 0)
		{
			goto IL_17d4;
		}
		goto IL_1ce9;
		IL_1ce9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1904 @ X22_v21+38]");
		object obj212 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X8_v96+10]");
		obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X8_v96+10]");
		object obj213 = (nint)0 + (nint)309;
		object obj214 = obj213 & 1;
		if (obj214 == null)
		{
			goto IL_1850;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X8_v96+10]");
		obj42 = 0;
		goto IL_185f;
		IL_11ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1552 @ X0_v132+E4]");
		if ((nint)0 != 0)
		{
			goto IL_1213;
		}
		goto IL_1371;
		IL_13f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		if (sFSArray != null)
		{
			goto IL_141e;
		}
		goto IL_2291;
		IL_1213:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X22_v18+38]");
		object obj215 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v158+10]");
		object obj216 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v158+10]");
		object obj217 = (nint)0 + (nint)309;
		object obj218 = obj217 & 1;
		bool flag52 = obj218 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v158+10]");
		object obj219 = 0;
		if (!flag52)
		{
			goto IL_1284;
		}
		goto IL_13f7;
		IL_1371:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X22_v18+38]");
		object obj220 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ X8_v148+10]");
		obj216 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ X8_v148+10]");
		object obj221 = (nint)0 + (nint)309;
		object obj222 = obj221 & 1;
		bool flag53 = obj222 == null;
		object obj223 = !flag53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ X8_v148+10]");
		obj219 = 0;
		if (obj223 != null)
		{
			goto IL_1284;
		}
		goto IL_13f7;
		IL_09e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v178+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0a08;
		}
		goto IL_0d17;
		IL_0d17:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X21_v15+38]");
		object obj224 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v204+10]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v204+10]");
		object obj225 = (nint)0 + (nint)309;
		object obj226 = obj225 & 1;
		if (obj226 == null)
		{
			goto IL_0a84;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v204+10]");
		obj14 = 0;
		goto IL_0a93;
	}

	protected virtual void CheckEkkah(Card card, int playerIndex, bool forceEkkah = false)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0068: Expected I, but got O
		//IL_0078: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_0210: Expected O, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_027a: Expected I, but got O
		//IL_028a: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_02c5: Expected O, but got I
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_015a: Expected I, but got O
		//IL_0183: Expected O, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		object obj;
		if (card != null)
		{
			CurrentSuit = card.<Suit>k__BackingField;
			ISFSObject iSFSObject = base.<RoundState>k__BackingField;
			if (base.<RoundState>k__BackingField != null)
			{
				obj = typeof(System.IOAsyncCallback) + 976;
				object obj2 = "com.unity.services.authentication.profile" + 2616;
				nint num = (nint)iSFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X10_v15-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 += 16;
					obj3--;
					if ((nint)obj3 != 1)
					{
						continue;
					}
					goto IL_00f4;
				}
				object obj5 = obj4 + 35;
				object obj6 = num + obj5;
				object obj7 = obj6 + 312;
				goto IL_0399;
			}
		}
		goto IL_0343;
		IL_0399:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v6+8]");
		bool flag = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X0_v6] (should have been resolved before IL gen)");
		if (GameMode != BalootGame.BalootGameMode.Hokom)
		{
			goto IL_0202;
		}
		BalootPlayingManager playingManager = (BalootPlayingManager)base.PlayingManager;
		if (base.PlayingManager == null)
		{
			goto IL_0343;
		}
		object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2024;
		object obj9 = obj8;
		nint num2 = (nint)playingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v22 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+130]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X1_v10+130]");
		bool flag2 = num3 < 0;
		object obj10 = !flag2;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v22 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X1_v10+130]");
			object obj12 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v24-8]");
			if (0 == (nint)obj9)
			{
				((BalootPlayingManager)base.PlayingManager).CheckEkkah(card, playerIndex, forceEkkah);
				flag = forceEkkah;
				goto IL_0202;
			}
		}
		goto IL_0351;
		IL_0202:
		object obj13 = playerIndex - 1;
		bool firstMove = obj13 == null;
		IEnumerable<Card> playableCards = GetPlayableCards(firstMove);
		ISFSObject iSFSObject2 = base.<RoundState>k__BackingField;
		int[] array = OfflineGameController.CardsToInt(playableCards);
		if (base.<RoundState>k__BackingField == null)
		{
			goto IL_0343;
		}
		object obj14 = "placementId" + 520;
		nint num5 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0306;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v9-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj16 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_0306;
		}
		object obj17 = obj16 + 44;
		object obj18 = num5 + obj17;
		object obj19 = obj18 + 312;
		goto IL_0422;
		IL_0343:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0351;
		IL_0351:
		throw new InvalidCastException();
		IL_0422:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v422 @ X0_v13] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0306:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0422;
		IL_00f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0399;
	}

	protected override bool OnEatCard(int playerWillEat, int eaterTeam)
	{
		//IL_08df: Expected I4, but got O
		//IL_006a: Expected O, but got I8
		//IL_00d5: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_015e: Expected O, but got I8
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_08a4: Expected O, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_0300: Expected I, but got O
		//IL_0310: Expected O, but got I
		//IL_03c6: Expected O, but got I4
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_044c: Expected I, but got O
		//IL_045c: Expected O, but got I
		//IL_034b: Expected O, but got I
		//IL_04f2: Expected O, but got I
		//IL_0497: Expected O, but got I
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected O, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0529: Expected O, but got I
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0567: Expected O, but got I
		//IL_0593: Expected O, but got I
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07a7: Expected I, but got O
		//IL_07b7: Expected O, but got I
		//IL_07f2: Expected O, but got I
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_0676: Expected I, but got O
		//IL_0686: Expected O, but got I
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Expected O, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected O, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_06c1: Expected O, but got I
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected O, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		bool flag = base.OnEatCard(playerWillEat, eaterTeam);
		IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
		object[] array = Enumerable.ToArray(source);
		int moveNumber;
		int num3;
		if (array != null)
		{
			if (array.Length == 0)
			{
				goto IL_08d1;
			}
			if (array[0] != null)
			{
				_ = 0;
				IEnumerable<object> source2 = Enumerable.Cast<object>(base.Players);
				object[] array2 = Enumerable.ToArray(source2);
				if (array2 != null)
				{
					object obj = array2.Length & 0xFFFFFFFEL;
					if (obj == null)
					{
						goto IL_08d1;
					}
					if (array2[1] != null)
					{
						_ = 0;
						IEnumerable<object> source3 = Enumerable.Cast<object>(base.Players);
						object[] array3 = Enumerable.ToArray(source3);
						if (array3 != null)
						{
							bool flag2 = array3.Length < 2;
							object obj2 = !flag2;
							object obj3 = array3.Length - 2;
							bool flag3 = obj3 == null;
							object obj4 = ~obj2;
							object obj5 = obj4 | flag3;
							if (obj5 != null)
							{
								goto IL_08d1;
							}
							if (array3[2] != null)
							{
								_ = 0;
								IEnumerable<object> source4 = Enumerable.Cast<object>(base.Players);
								object[] array4 = Enumerable.ToArray(source4);
								if (array4 != null)
								{
									object obj6 = array4.Length & 0xFFFFFFFCL;
									if (obj6 == null)
									{
										goto IL_08d1;
									}
									if (array4[3] != null)
									{
										_ = 0;
										object playedCards = this + 64;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X21_v7+6C]");
										nint num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X21_v7+78]");
										int num2 = BalootUtils.CalculateEatingScore((Card[])playedCards, (BalootGame.BalootGameMode)num, Suit.SPADES);
										if (eaterTeam == 1)
										{
											int team1Score = Team1Score + num2;
											Team1Score = team1Score;
											LastMoveWinner = eaterTeam;
											moveNumber = MoveNumber;
											if (MoveNumber == 8)
											{
												goto IL_02ac;
											}
											num3 = MoveNumber;
										}
										else
										{
											int team2Score = Team2Score + num2;
											Team2Score = team2Score;
											LastMoveWinner = eaterTeam;
											moveNumber = MoveNumber;
											bool flag4 = MoveNumber != 8;
											num3 = MoveNumber;
											if (!flag4)
											{
												goto IL_02ac;
											}
										}
										goto IL_0896;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_08c3;
		IL_02ac:
		ISFSObject iSFSObject = base.<RoundState>k__BackingField;
		object obj7;
		ISFSObject iSFSObject2;
		if (base.<RoundState>k__BackingField != null)
		{
			obj7 = typeof(System.IOAsyncCallback) + 976;
			object obj8 = "m_StencilDeferredPS" + 2168;
			nint num4 = (nint)iSFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_038c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X10_v28-8]");
				if (0 == (nint)obj7)
				{
					break;
				}
				obj10 += 16;
				obj9--;
				if ((nint)obj9 != 1)
				{
					continue;
				}
				goto IL_038c;
			}
			object obj11 = obj10 + 2;
			object obj12 = num4 + obj11;
			object obj13 = obj12 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v533 @ X0_v72] (should have been resolved before IL gen)");
			iSFSObject2 = base.<RoundState>k__BackingField;
			if (base.<RoundState>k__BackingField != null)
			{
				goto IL_0435;
			}
		}
		goto IL_08c3;
		IL_05d1:
		ISFSObject iSFSObject3 = base.<RoundState>k__BackingField;
		object obj14 = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj15 = default(object);
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v51+18]");
			if ((nint)0 == 0)
			{
				goto IL_08d1;
			}
			if (base.<RoundState>k__BackingField != null)
			{
				object obj16 = "alignContent" + 560;
				nint num5 = (nint)iSFSObject3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v53 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v53 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0702;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v53 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj18 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X10_v17-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj18 += 16;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_0702;
				}
				object obj19 = obj18 + 44;
				object obj20 = num5 + obj19;
				object obj21 = obj20 + 312;
				goto IL_0abc;
			}
		}
		goto IL_08c3;
		IL_0702:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0abc;
		IL_0abc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v775 @ X0_v52] (should have been resolved before IL gen)");
		goto IL_0a24;
		IL_0a24:
		object key = "utf-32" + 1200;
		SFSExtensions.Put(base.<RoundState>k__BackingField, (string)key, 0);
		base.<GameStatus>k__BackingField = CardGameStage.CardGameStages.MoveNextRequired;
		object key2 = "fetch_products" + 1824;
		SFSExtensions.Put(base.<RoundState>k__BackingField, (string)key2, 5);
		object obj22 = typeof(TypeConverter<ushort, char>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Card[] playedCards2 = default(Card[]);
		PlayedCards = playedCards2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ISFSObject iSFSObject4 = base.<RoundState>k__BackingField;
		int[] array5 = OfflineGameController.CardsToInt(PlayedCards);
		if (base.<RoundState>k__BackingField == null)
		{
			goto IL_08c3;
		}
		object obj23 = "placementId" + 104;
		nint num6 = (nint)iSFSObject4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0833;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X10_v10-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_0833;
		}
		object obj26 = obj25 + 44;
		object obj27 = num6 + obj26;
		object obj28 = obj27 + 312;
		goto IL_0aef;
		IL_08c3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_08d1;
		IL_038c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v516 @ X0_v69] (should have been resolved before IL gen)");
		iSFSObject2 = base.<RoundState>k__BackingField;
		bool flag5 = base.<RoundState>k__BackingField == null;
		object obj29 = !flag5;
		if (obj29 != null)
		{
			goto IL_0435;
		}
		goto IL_08c3;
		IL_0435:
		object obj30 = "m_StencilDeferredPS" + 2456;
		nint num7 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04d8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj32 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X10_v23-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj32 += 16;
			obj31--;
			if ((nint)obj31 != 1)
			{
				continue;
			}
			goto IL_04d8;
		}
		object obj33 = obj32 + 2;
		object obj34 = num7 + obj33;
		object obj35 = obj34 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v65+8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v627 @ X0_v65] (should have been resolved before IL gen)");
		bool flag6 = playerWillEat != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v65+8]");
		object obj37 = 0;
		if (!flag6)
		{
			goto IL_05a1;
		}
		goto IL_05d1;
		IL_0aef:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v841 @ X0_v38] (should have been resolved before IL gen)");
		base.SendGameState();
		bool isReplay = SFSKammelnaRoomExtensions.GetIsReplay(base.<Room>k__BackingField);
		bool flag7 = !isReplay;
		num3 = moveNumber;
		if (!flag7)
		{
			object command = "___# Content push apply failed [{0}]: {1}" + 2640;
			SFS.SendRoomExtensionRequest((string)command);
			num3 = moveNumber;
		}
		goto IL_0896;
		IL_0896:
		object obj38 = num3 - 8;
		bool flag8 = obj38 == null;
		return !flag8;
		IL_0833:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0aef;
		IL_08d1:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_05a1:
		bool isReplay2 = SFSKammelnaRoomExtensions.GetIsReplay(base.<Room>k__BackingField);
		bool flag9 = !isReplay2;
		obj37 = obj36;
		if (!flag9)
		{
			goto IL_05d1;
		}
		goto IL_0a24;
		IL_04d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v62+8]");
		obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v587 @ X0_v62] (should have been resolved before IL gen)");
		if (playerWillEat == 1)
		{
			goto IL_05a1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v62+8]");
		obj37 = 0;
		goto IL_05d1;
	}

	protected override int GetEatingPlayer()
	{
		return BalootUtils.CheckWhoEats(PlayedCards, CurrentSuit, GameMode, TrumpSuit);
	}

	protected override List<Card> GetPlayableCards(bool firstMove)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		//IL_0226: Expected O, but got I
		//IL_0236: Expected O, but got I
		//IL_0258: Expected O, but got I4
		//IL_0370: Expected O, but got I
		//IL_0114: Expected O, but got I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0290: Expected O, but got I
		//IL_02a1: Expected I, but got O
		//IL_02bf: Expected O, but got I
		//IL_0144: Expected O, but got I
		IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
		object[] array = Enumerable.ToArray(source);
		if (array != null)
		{
			if (array.Length == 0)
			{
				goto IL_016a;
			}
			object obj = array[0];
			if (array[0] != null)
			{
				IEnumerable<object> source2 = Enumerable.Cast<object>(base.Players);
				object[] array2 = Enumerable.ToArray(source2);
				if (array2 != null)
				{
					if (array2.Length == 0)
					{
						goto IL_016a;
					}
					object obj2 = array2[0];
					if (array2[0] != null)
					{
						object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2608;
						IEnumerable<object> source3 = Enumerable.Cast<object>(base.Players);
						object[] array3 = Enumerable.ToArray(source3);
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v19+E4]");
						bool flag = (nint)0 == 0;
						object obj5 = !flag;
						object[] source4 = array3;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj4 = obj3;
							source4 = array3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v19+B8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v18+20]");
						Func<object, bool> selector = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v18+20]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v19+E4]");
							bool flag3 = (nint)0 == 0;
							object obj8 = !flag3;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj9 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v24+B8]");
								obj6 = 0;
							}
							object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 272;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj11 = (nint)0 + (nint)752;
							Func<object, bool> func = default(Func<object, bool>);
							func..ctor(obj6, (IntPtr)obj11);
							object obj12 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v23+B8]");
							object obj13 = (nint)0 + (nint)32;
							obj13 = func;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							selector = func;
						}
						IEnumerable<bool> source5 = Enumerable.Select(source4, selector);
						bool[] ekkahFlags = Enumerable.ToArray(source5);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8 (System.Object)+18]");
						nint num = 0;
						Card[] playedCards = PlayedCards;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12 (System.Object)+10]");
						return BalootUtils.PlayableCards((List<Card>)num, playedCards, firstMove, 0, GameMode, CurrentSuit, TrumpSuit, IsHokomClose, ekkahFlags);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_016a;
		IL_016a:
		return (List<Card>)(object)new IndexOutOfRangeException();
	}

	protected override bool IsGameOver()
	{
		//IL_0038: Expected O, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected I4, but got Unknown
		if (Team1TotalScore > 151)
		{
			return true;
		}
		object obj = Team2TotalScore - 151;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = Team2TotalScore ^ 0x97;
		int num2 = Team2TotalScore ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		return (byte)((flag4 & obj2) ? 1 : 0) != 0;
	}

	protected override bool OnBid(int bidderIndex, string bid)
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0136: Expected I, but got O
		//IL_015f: Expected O, but got I4
		//IL_06f7: Expected I4, but got O
		//IL_0193: Expected O, but got I
		//IL_01d4: Expected I, but got O
		//IL_01fd: Expected O, but got I4
		//IL_0231: Expected O, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_032f: Expected I, but got O
		//IL_033f: Expected O, but got I
		//IL_037a: Expected O, but got I
		//IL_0622: Expected I, but got O
		//IL_064b: Expected O, but got I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_067f: Expected O, but got I
		//IL_0408: Expected I, but got O
		//IL_0431: Expected O, but got I4
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_06bc: Expected O, but got I
		//IL_0465: Expected O, but got I
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04c2: Expected I, but got O
		//IL_04d2: Expected O, but got I
		//IL_050d: Expected O, but got I
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80CA]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80C2]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80C2]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		BiddingManager biddingManager = base.BiddingManager;
		if (base.BiddingManager != null)
		{
			goto IL_0112;
		}
		goto IL_06e9;
		IL_0775:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v568 @ X0_v26] (should have been resolved before IL gen)");
		BalootGame.BalootExtraGameMode balootExtraGameMode = ExtraGameMode;
		goto IL_06f7;
		IL_054e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0775;
		IL_0738:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v485 @ X0_v21] (should have been resolved before IL gen)");
		ISFSObject iSFSObject = base.<RoundState>k__BackingField;
		BiddingManager biddingManager2 = base.BiddingManager;
		object obj6;
		object obj13;
		if (base.BiddingManager != null)
		{
			object obj5 = obj6;
			nint num = (nint)biddingManager2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v28 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X1_v13+130]");
			bool flag2 = num2 < 0;
			object obj7 = !flag2;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v28 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X1_v13+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v30-8]");
				if (0 == (nint)obj5)
				{
					if (base.<RoundState>k__BackingField == null)
					{
						goto IL_06e9;
					}
					object obj10 = "tournament_participate_warning_body_with_tickets_warning_daily" + 728;
					nint num4 = (nint)iSFSObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_054e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
					object obj12 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X10_v14-8]");
						if (0 == (nint)obj13)
						{
							break;
						}
						obj12 += 16;
						obj11--;
						if ((nint)obj11 != 1)
						{
							continue;
						}
						goto IL_054e;
					}
					object obj14 = obj12 + 35;
					object obj15 = num4 + obj14;
					object obj16 = obj15 + 312;
					goto IL_0775;
				}
			}
			goto IL_06db;
		}
		goto IL_06e9;
		IL_0066:
		biddingManager = base.BiddingManager;
		bool flag3 = base.BiddingManager == null;
		object obj17 = !flag3;
		if (obj17 != null)
		{
			goto IL_0112;
		}
		goto IL_06e9;
		IL_0112:
		obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1952;
		object obj18 = obj6;
		nint num5 = (nint)biddingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X1_v2+130]");
		bool flag4 = num6 < 0;
		object obj19 = !flag4;
		object obj20 = ~obj19;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X1_v2+130]");
			object obj21 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v7-8]");
			if (0 == (nint)obj18)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (KammelnaOffline.Common.BiddingManager)+34]");
				GameMode = BalootGame.BalootGameMode.NotDetermined;
				nint num8 = (nint)biddingManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X10_v4 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X1_v2+130]");
				bool flag5 = num9 < 0;
				object obj22 = !flag5;
				object obj23 = ~obj22;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X10_v4 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X1_v2+130]");
					object obj24 = num10 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X9_v4-8]");
					if (0 == (nint)obj18)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (KammelnaOffline.Common.BiddingManager)+3C]");
						balootExtraGameMode = BalootGame.BalootExtraGameMode.NotDetermined;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (KammelnaOffline.Common.BiddingManager)+3C]");
						ExtraGameMode = BalootGame.BalootExtraGameMode.NotDetermined;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (KammelnaOffline.Common.BiddingManager)+34]");
						if ((nint)0 == 0)
						{
							goto IL_06f7;
						}
						object key = "getSecondRescanTask" + 1696;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (KammelnaOffline.Common.BiddingManager)+34]");
						string val = BalootGameModeExtensions.ToClientString(BalootGame.BalootGameMode.NotDetermined);
						SFSExtensions.Put(base.<RoundState>k__BackingField, (string)key, val);
						ISFSObject iSFSObject2 = base.<RoundState>k__BackingField;
						if (base.<RoundState>k__BackingField == null)
						{
							goto IL_06e9;
						}
						obj13 = typeof(System.IOAsyncCallback) + 976;
						object obj25 = "placementId" + 2304;
						nint num11 = (nint)iSFSObject2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_03bb;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj27 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v19-8]");
							if (0 == (nint)obj13)
							{
								break;
							}
							obj27 += 16;
							obj26--;
							if ((nint)obj26 != 1)
							{
								continue;
							}
							goto IL_03bb;
						}
						object obj28 = obj27 + 35;
						object obj29 = num11 + obj28;
						object obj30 = obj29 + 312;
						goto IL_0738;
					}
				}
			}
		}
		goto IL_06db;
		IL_06f7:
		if (balootExtraGameMode != BalootGame.BalootExtraGameMode.NotDetermined)
		{
			object key2 = "fetch_products" + 2528;
			string val2 = BalootGameModeExtensions.ToClientString(balootExtraGameMode);
			SFSExtensions.Put(base.<RoundState>k__BackingField, (string)key2, val2);
		}
		int[] bidders = Bidders;
		if (Bidders != null)
		{
			if (bidders.Length != 0)
			{
				return false;
			}
			BiddingManager biddingManager3 = base.BiddingManager;
			if (base.BiddingManager != null)
			{
				object obj31 = obj6;
				nint num12 = (nint)biddingManager3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v15 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X1_v6+130]");
				bool flag6 = num13 < 0;
				object obj32 = !flag6;
				object obj33 = ~obj32;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v15 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X1_v6+130]");
					object obj34 = num14 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v17-8]");
					if (0 == (nint)obj31)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v10 (KammelnaOffline.Common.BiddingManager)+20]");
						object obj35 = -3;
						bool flag7 = obj35 == null;
						return !flag7;
					}
				}
				goto IL_06db;
			}
		}
		goto IL_06e9;
		IL_06e9:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_06db:
		InvalidCastException ex2 = new InvalidCastException();
		goto IL_06e9;
		IL_03bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0738;
	}

	protected override string GetBiddingFromSfsParam(ISFSObject param)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1960;
		BalootBiddingOption balootBiddingOption = BalootBiddingOptions.BiddingOptionFromSfsObject(param);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
	}

	protected override void BuildRoundState()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00a9: Expected I, but got O
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f5: Expected I, but got O
		//IL_0105: Expected O, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I
		//IL_01e0: Expected I, but got O
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0227: Expected I, but got O
		//IL_0237: Expected O, but got I
		//IL_0272: Expected O, but got I
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_032d: Expected I, but got O
		//IL_033d: Expected O, but got I
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_0554: Expected O, but got I
		//IL_0378: Expected O, but got I
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2624;
		object obj2 = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		base.BuildRoundState();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1248;
		object obj5 = (nint)0 + (nint)792;
		object obj6 = obj3 + 16;
		obj6 = sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = (nint)0 + (nint)1144;
		IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
		object[] enumeration = Enumerable.ToArray(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj3, (IntPtr)obj5);
		ArraysExtensions.ForEach(enumeration, action);
		ISFSObject iSFSObject = base.<RoundState>k__BackingField;
		object obj8 = typeof(System.IOAsyncCallback) + 976;
		object obj9 = "placementId" + 536;
		nint num = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0181;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X10_v18-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0181;
		}
		object obj12 = obj11 + 49;
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		goto IL_0463;
		IL_03b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_053c;
		IL_02b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04f5;
		IL_04f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v463 @ X0_v34] (should have been resolved before IL gen)");
		object key;
		SFSExtensions.Put(base.<RoundState>k__BackingField, (string)key, val: false);
		ISFSObject iSFSObject2 = base.<RoundState>k__BackingField;
		int num2 = FloorCard.AsInt();
		object obj15 = "destinationTimeZone" + 3904;
		object obj16 = obj15;
		nint num3 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03b9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X10_v8-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_03b9;
		}
		object obj19 = obj18 + 35;
		object obj20 = num3 + obj19;
		object obj21 = obj20 + 312;
		goto IL_053c;
		IL_053c:
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v40+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v220 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0181:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0463;
		IL_0463:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v357 @ X0_v19] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray2 = default(SFSArray);
		sFSArray2..ctor();
		object obj24 = obj3 + 24;
		obj24 = sFSArray2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> source2 = Enumerable.Cast<object>(base.Players);
		object[] enumeration2 = Enumerable.ToArray(source2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)800;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj3, (IntPtr)obj25);
		ArraysExtensions.ForEach(enumeration2, action2);
		ISFSObject iSFSObject3 = base.<RoundState>k__BackingField;
		object obj26 = "destinationTimeZone" + 816;
		key = "getSecondRescanTask" + 2536;
		nint num4 = (nint)iSFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02b3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X10_v13-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj28 += 16;
			obj27--;
			if ((nint)obj27 != 1)
			{
				continue;
			}
			goto IL_02b3;
		}
		object obj29 = obj28 + 49;
		object obj30 = num4 + obj29;
		object obj31 = obj30 + 312;
		goto IL_04f5;
	}

	protected void ShuffleCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<Card> allBalootCards = BalootCardUtils.AllBalootCards;
		List<object> array = Enumerable.ToList((IEnumerable<object>)allBalootCards);
		List<object> list = ArraysExtensions.Shuffle(array);
		object obj4 = this + 104;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected virtual void CardDistributionFirstPhase()
	{
		//IL_02ac: Expected O, but got I
		//IL_02c0: Expected O, but got I
		//IL_02c9: Expected O, but got I4
		//IL_0020: Expected O, but got I4
		//IL_0066: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_0157: Expected O, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01a8: Expected I, but got O
		//IL_01e7: Expected O, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0221: Expected O, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1752;
		ShuffleCards();
		object obj2 = (nint)0 + (nint)1144;
		object obj3 = 0;
		Comparison<object> comparison = default(Comparison<object>);
		while (true)
		{
			IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
			object[] array = Enumerable.ToArray(source);
			if (array != null)
			{
				bool flag = (nint)obj3 < array.Length;
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				if (Deck != null)
				{
					object obj5 = (object)array + obj3;
					object obj6 = (nint)0 + (nint)2696;
					List<object> range = ((List<object>)(object)Deck).GetRange(0, 5);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X9_v4+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X9_v4+20]");
						object obj7 = (nint)0 + (nint)24;
						obj7 = range;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if (Deck != null)
						{
							object obj8 = (nint)0 + (nint)2720;
							((List<object>)(object)Deck).RemoveRange(0, 5);
							IEnumerable<object> source2 = Enumerable.Cast<object>(base.Players);
							object[] array2 = Enumerable.ToArray(source2);
							if (array2 != null)
							{
								bool flag2 = (nint)obj3 < array2.Length;
								object obj9 = !flag2;
								if (obj9 != null)
								{
									break;
								}
								object obj10 = (object)array2 + obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v13+20]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v13+20]");
								if ((nint)0 != 0)
								{
									object obj12 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3280;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									comparison..ctor((object)this, (IntPtr)obj);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v14+18]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v14+18]");
										((List<object>)0).Sort(comparison);
										obj3++;
										if ((nint)obj3 != 4)
										{
											continue;
										}
										object obj13 = (nint)0 + (nint)3736;
										object obj14 = Enumerable.ElementAt((IEnumerable<object>)Deck, 0);
										object obj15 = this + 160;
										obj15 = obj14;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										if (Deck != null)
										{
											bool flag3 = ((List<object>)(object)Deck).Remove(obj15);
											return;
										}
									}
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	protected virtual void CardDistributionSecondPhase()
	{
		//IL_07bc: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00f5: Expected O, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_015c: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		//IL_0144: Unsupported input type for neg.
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected I4, but got Unknown
		//IL_0815: Expected O, but got I4
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected O, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected I4, but got Unknown
		//IL_01a2: Expected O, but got I
		//IL_01d7: Expected O, but got I
		//IL_026d: Expected O, but got I4
		//IL_02f2: Expected O, but got I
		//IL_0300: Expected O, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_0315: Expected I, but got O
		//IL_033e: Expected O, but got I4
		//IL_0372: Expected O, but got I
		//IL_0492: Expected O, but got I4
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_04e1: Unsupported input type for neg.
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected I4, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03f8: Expected O, but got I4
		//IL_08de: Expected O, but got I4
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected O, but got Unknown
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected O, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_0965: Expected O, but got I4
		//IL_08ab: Expected O, but got I
		//IL_0992: Expected O, but got I
		//IL_09ac: Expected O, but got I4
		//IL_046c: Expected O, but got I4
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_0582: Expected O, but got I4
		//IL_05a0: Expected O, but got I
		//IL_05f0: Expected O, but got I
		//IL_0639: Expected O, but got I
		//IL_064e: Expected O, but got I
		//IL_066e: Expected O, but got I4
		//IL_068c: Expected O, but got I
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06db: Expected O, but got I
		//IL_06e9: Expected I, but got O
		//IL_0729: Expected O, but got I
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1144;
		IEnumerable<object> source = Enumerable.Cast<object>(base.Players);
		object[] array = Enumerable.ToArray(source);
		BiddingManager biddingManager = base.BiddingManager;
		if (base.BiddingManager == null)
		{
			goto IL_078c;
		}
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1952;
		object obj3 = obj2;
		nint num = (nint)biddingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v11 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X1_v6+130]");
		bool flag = num2 < 0;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v11 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X1_v6+130]");
			object obj6 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v13-8]");
			if (0 == (nint)obj3)
			{
				int num4 = biddingManager.<Bidder>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7 (KammelnaOffline.Common.BiddingManager)+34]");
				if ((nint)0 == 3)
				{
					object obj7 = -biddingManager.<Bidder>k__BackingField;
					object obj8 = obj7 & 3;
					int num5 = biddingManager.<Bidder>k__BackingField & 3;
					if (0 >= biddingManager.<Bidder>k__BackingField)
					{
						num5 = 0 - obj8;
					}
					object obj9 = num5 + 1;
					object obj10 = obj9 >> 13;
					object obj11 = obj10 & 3;
					object obj12 = obj9 + obj11;
					object obj13 = obj12 & 0xFC;
					object obj14 = obj9 - obj13;
					num4 = obj14 + 1;
				}
				if (array != null)
				{
					object obj15 = num4 - 1;
					bool flag2 = (nint)obj15 < array.Length;
					object obj16 = !flag2;
					if (obj16 != null)
					{
						goto IL_07a8;
					}
					object obj17 = (object)array + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v18+20]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v18+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v19+18]");
						List<object> list = (List<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v19+18]");
						if ((nint)0 != 0)
						{
							int version = list._version + 1;
							list._version = version;
							object[] items = list._items;
							if (list._items != null)
							{
								bool flag3 = list._size < items.Length;
								object obj19 = !flag3;
								if (obj19 == null)
								{
									int size = list._size + 1;
									list._size = size;
									object obj20 = list._items + list._size;
									object obj21 = obj20 + 32;
									obj21 = FloorCard;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v19+18]");
									((List<object>)0).AddWithResize((object)FloorCard);
								}
								object obj22 = 4;
								Comparison<object> comparison = default(Comparison<object>);
								while (true)
								{
									BiddingManager biddingManager2 = base.BiddingManager;
									if (base.BiddingManager == null)
									{
										break;
									}
									object obj23 = obj2;
									nint num6 = (nint)biddingManager2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v28 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+130]");
									nint num7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X1_v9+130]");
									bool flag4 = num7 < 0;
									object obj24 = !flag4;
									object obj25 = ~obj24;
									int num9;
									object[] array2;
									if (obj25 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v28 (Il2CppClass<KammelnaOffline.Common.BiddingManager>)+C8]");
										nint num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X1_v9+130]");
										object obj26 = num8 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v30-8]");
										if (0 == (nint)obj23)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v18 (KammelnaOffline.Common.BiddingManager)+34]");
											int num10;
											if ((nint)0 != 3)
											{
												object obj27 = obj22 - 3;
												object obj28 = obj27 - biddingManager2.<Bidder>k__BackingField;
												bool flag5 = obj28 == null;
												object obj29 = !flag5;
												object obj30 = ~obj29;
												num9 = ((obj30 != null) ? 2 : (2 + 1));
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80C0]");
												object obj31 = (nint)0 & (nint)1;
												bool flag6 = obj31 == null;
												num10 = num9;
												if (!flag6)
												{
													goto IL_0431;
												}
											}
											else
											{
												object obj32 = -biddingManager2.<Bidder>k__BackingField;
												object obj33 = obj32 & 3;
												int num11 = biddingManager2.<Bidder>k__BackingField & 3;
												if (0 >= biddingManager2.<Bidder>k__BackingField)
												{
													num11 = 0 - obj33;
												}
												object obj34 = num11 + 1;
												object obj35 = obj34 >> 13;
												object obj36 = obj35 & 3;
												object obj37 = obj34 + obj36;
												object obj38 = obj37 & 0xFC;
												object obj39 = obj34 - obj38;
												object obj40 = obj39 + 1;
												object obj41 = obj22 - 3;
												object obj42 = obj41 - obj40;
												bool flag7 = obj42 == null;
												object obj43 = !flag7;
												object obj44 = ~obj43;
												num9 = ((obj44 != null) ? 2 : (2 + 1));
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80C0]");
												object obj45 = (nint)0 & (nint)1;
												bool flag8 = obj45 == null;
												object obj46 = !flag8;
												num10 = num9;
												if (obj46 != null)
												{
													goto IL_0431;
												}
											}
											_ = 1;
											IEnumerable<object> source2 = Enumerable.Cast<object>(base.Players);
											array2 = Enumerable.ToArray(source2);
											bool flag9 = array2 == null;
											num9 = num10;
											if (flag9)
											{
												break;
											}
											goto IL_0559;
										}
									}
									goto IL_079a;
									IL_0559:
									object obj47 = obj22 - 4;
									bool flag10 = (nint)obj47 < array2.Length;
									object obj48 = !flag10;
									if (obj48 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v19 (System.Object[])+v141 @ X28_v5*8]");
										object obj49 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v19 (System.Object[])+v141 @ X28_v5*8]");
										if ((nint)0 == 0 || Deck == null)
										{
											break;
										}
										object obj50 = (nint)0 + (nint)2696;
										List<object> range = ((List<object>)(object)Deck).GetRange(0, num9);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v35 (System.Object)+18]");
										if ((nint)0 == 0)
										{
											break;
										}
										object obj51 = (nint)0 + (nint)2656;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v35 (System.Object)+18]");
										((List<object>)0).AddRange(range);
										IEnumerable<object> source3 = Enumerable.Cast<object>(base.Players);
										object[] array3 = Enumerable.ToArray(source3);
										if (array3 == null)
										{
											break;
										}
										bool flag11 = (nint)obj47 < array3.Length;
										object obj52 = !flag11;
										if (obj52 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v26 (System.Object[])+v141 @ X28_v5*8]");
											object obj53 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v26 (System.Object[])+v141 @ X28_v5*8]");
											if ((nint)0 == 0)
											{
												break;
											}
											object obj54 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3280;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj55 = (nint)0 + (nint)1752;
											comparison..ctor((object)this, (IntPtr)obj55);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v42 (System.Object)+18]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v42 (System.Object)+18]");
											((List<object>)0).Sort(comparison);
											if (Deck == null)
											{
												break;
											}
											((List<object>)(object)Deck).RemoveRange(0, num9);
											obj22++;
											if ((nint)obj22 == 8)
											{
												return;
											}
											continue;
										}
									}
									goto IL_07a8;
									IL_0431:
									IEnumerable<object> source4 = Enumerable.Cast<object>(base.Players);
									array2 = Enumerable.ToArray(source4);
									bool flag12 = array2 == null;
									object obj56 = !flag12;
									if (obj56 == null)
									{
										break;
									}
									goto IL_0559;
								}
							}
						}
					}
				}
				goto IL_078c;
			}
		}
		goto IL_079a;
		IL_07a8:
		throw new IndexOutOfRangeException();
		IL_079a:
		InvalidCastException ex = new InvalidCastException();
		goto IL_07a8;
		IL_078c:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_079a;
	}

	protected override int CardValue(Card card)
	{
		//IL_0197: Expected I4, but got O
		//IL_0030: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		int num;
		int result;
		if (card != null)
		{
			object obj = card.<Rank>k__BackingField - 5;
			bool flag = (nint)obj < 7;
			object obj2 = !flag;
			object obj3 = obj - 7;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 119877632 + 1096;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X11_v5+v5 @ X10_v1*4]");
				num = 0;
				if (GameMode == BalootGame.BalootGameMode.Hokom)
				{
					goto IL_0114;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X11_v5+v5 @ X10_v1*4]");
				result = 0;
			}
			else
			{
				bool flag3 = GameMode != BalootGame.BalootGameMode.Hokom;
				num = 0;
				result = 0;
				if (!flag3)
				{
					goto IL_0114;
				}
			}
			goto IL_0197;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0114:
		int num2 = ((card.<Rank>k__BackingField != Rank.JACK) ? num : 10);
		int num3 = ((card.<Rank>k__BackingField != Rank.NINE) ? num2 : 9);
		object obj7 = card.<Suit>k__BackingField - TrumpSuit;
		bool flag4 = obj7 == null;
		object obj8 = !flag4;
		object obj9 = ~obj8;
		result = ((obj9 != null) ? num3 : num);
		goto IL_0197;
		IL_0197:
		return result;
	}

	public override int GetOfflineValue(Card card)
	{
		//IL_0200: Expected I4, but got O
		//IL_003f: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		bool flag = BalootGameModeExtensions.IsSunOrAshkal(GameMode);
		int num;
		int num2;
		Suit <Suit>k__BackingField;
		if (card != null)
		{
			object obj = card.<Rank>k__BackingField - 5;
			bool flag2 = (nint)obj < 7;
			object obj2 = !flag2;
			object obj3 = obj - 7;
			bool flag3 = obj3 == null;
			object obj4 = !flag3;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 119877632 + 1096;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X11_v5+v20 @ X10_v1*4]");
				num = 0;
				bool flag4 = !flag;
				object obj7 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X11_v5+v20 @ X10_v1*4]");
				num2 = 0;
				if (obj7 == null)
				{
					goto IL_00ef;
				}
			}
			else
			{
				bool flag5 = !flag;
				num = 0;
				num2 = 0;
				if (flag5)
				{
					goto IL_00ef;
				}
			}
			<Suit>k__BackingField = card.<Suit>k__BackingField;
			goto IL_0205;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_00ef:
		if (GameMode == BalootGame.BalootGameMode.Hokom)
		{
			<Suit>k__BackingField = card.<Suit>k__BackingField;
			bool flag6 = card.<Suit>k__BackingField != TrumpSuit;
			num2 = num;
			if (flag6)
			{
				goto IL_0205;
			}
			int num3 = num * 1000;
			if (card.<Rank>k__BackingField == Rank.JACK)
			{
				num3 = 10000;
			}
			num = ((card.<Rank>k__BackingField != Rank.NINE) ? num3 : 9000);
		}
		return num;
		IL_0205:
		int num4 = num2 * 100;
		if (<Suit>k__BackingField == CurrentSuit)
		{
			num2 = num4;
		}
		return num2;
	}
}
