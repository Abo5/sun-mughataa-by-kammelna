using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using KammelnaOffline.Common;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

namespace KammelnaOffline.Baloot;

public class BalootPlayingManager : PlayingManager
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Card, bool> <>9__3_0;

		public static Func<ProjectsUtility<BalootProject>.Project, BalootProject> <>9__4_0;

		public static Func<ProjectsUtility<BalootProject>.Project, IEnumerable<Card>> <>9__4_1;

		public static Func<BalootOfflinePlayer, string[]> <>9__4_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <OnPlay>b__3_0(Card card)
		{
			bool flag = card == null;
			return !flag;
		}

		internal BalootProject <UpdateDeclaredProjectsFirstMove>b__4_0(ProjectsUtility<BalootProject>.Project pair)
		{
			//IL_0005: Expected I4, but got O
			return (BalootProject)pair;
		}

		internal IEnumerable<Card> <UpdateDeclaredProjectsFirstMove>b__4_1(ProjectsUtility<BalootProject>.Project pair)
		{
			//IL_0005: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			return (IEnumerable<Card>)(nint)intPtr;
		}

		internal string[] <UpdateDeclaredProjectsFirstMove>b__4_2(BalootOfflinePlayer p)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_003f: Expected I, but got O
			if (p != null)
			{
				object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 304;
				object obj2 = (nint)0 + (nint)2360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<System.Int32Enum, object> func = default(Func<System.Int32Enum, object>);
				func..ctor((object)null, (IntPtr)obj2);
				IEnumerable<object> source = Enumerable.Select((IEnumerable<System.Int32Enum>)p.<DeclaredProjectsList>k__BackingField, func);
				return (string[])Enumerable.ToArray(source);
			}
			return (string[])(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public ISFSObject param;

		public BalootPlayingManager <>4__this;

		internal void <OnPlay>b__2()
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			BalootPlayingManager balootPlayingManager = <>4__this;
			BalootGameController gameController = balootPlayingManager._gameController;
			object command = "___# Content push apply failed [{0}]: {1}" + 2680;
			((OfflineGameController)gameController).<Room>k__BackingField.ProcessEvent((string)command, param);
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public BalootOfflinePlayer player;

		internal bool <UpdateProjectSecondMove>b__0(Card card)
		{
			//IL_005f: Expected I4, but got O
			BalootOfflinePlayer balootOfflinePlayer = player;
			if (player != null && ((OfflinePlayer)balootOfflinePlayer).<PlayedCards>k__BackingField != null)
			{
				bool flag = ((List<object>)(object)((OfflinePlayer)balootOfflinePlayer).<PlayedCards>k__BackingField).Contains((object)card);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private readonly BalootGameController _gameController;

	public BalootPlayingManager(BalootGameController gameController)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void StartPlaying()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_008d: Expected O, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0186: Expected I, but got O
		//IL_0196: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d8: Expected I, but got O
		//IL_02e8: Expected O, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_040c: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_0485: Expected I, but got O
		//IL_0495: Expected O, but got I
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0457: Expected O, but got I4
		//IL_04d0: Expected O, but got I
		//IL_0561: Expected O, but got I4
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05d0: Expected I, but got O
		//IL_05e0: Expected O, but got I
		//IL_061b: Expected O, but got I
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_06d0: Expected I, but got O
		//IL_06e0: Expected O, but got I
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_071b: Expected O, but got I
		//IL_092d: Expected I, but got O
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected O, but got Unknown
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected O, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected O, but got Unknown
		BalootGameController gameController = _gameController;
		ISFSObject <RoundState>k__BackingField = ((OfflineGameController)gameController).<RoundState>k__BackingField;
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "alignContent" + 3552;
		nint num = (nint)<RoundState>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X10_v36-8]");
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
			goto IL_00ce;
		}
		object obj5 = obj4 + 2;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v421 @ X0_v51] (should have been resolved before IL gen)");
		BalootGameController gameController2 = _gameController;
		goto IL_015d;
		IL_0511:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0868;
		IL_0868:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v613 @ X0_v13] (should have been resolved before IL gen)");
		OfflineGameController gameController3 = _gameController;
		object obj8 = gameController3.Dealer + 1;
		int num2 = (((nint)obj8 == 5) ? 1 : (gameController3.Dealer + 1));
		gameController3.SetMover(num2);
		BalootGameController gameController4 = _gameController;
		ISFSObject <RoundState>k__BackingField2 = ((OfflineGameController)gameController4).<RoundState>k__BackingField;
		object obj9 = "m_StencilDeferredPS" + 2456;
		nint num3 = (nint)<RoundState>k__BackingField2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_065c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X10_v16-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_065c;
		}
		object obj12 = obj11 + 35;
		object obj13 = num3 + obj12;
		object obj14 = obj13 + 312;
		goto IL_08c1;
		IL_08fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v759 @ X0_v20] (should have been resolved before IL gen)");
		if (num2 == 1)
		{
			_gameController.SendGameState();
		}
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v391 @ X8_v36 (Il2CppClass<KammelnaOffline.Baloot.BalootPlayingManager>)+188] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_07a9:
		throw new NullReferenceException();
		IL_00ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v48] (should have been resolved before IL gen)");
		gameController2 = _gameController;
		bool flag = _gameController == null;
		object obj15 = !flag;
		if (obj15 != null)
		{
			goto IL_015d;
		}
		goto IL_07a9;
		IL_015d:
		ISFSObject <RoundState>k__BackingField3 = ((OfflineGameController)gameController2).<RoundState>k__BackingField;
		object obj16 = "destinationTimeZone" + 3904;
		nint num5 = (nint)<RoundState>k__BackingField3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0212;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X10_v31-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_0212;
		}
		object obj19 = obj18 + 2;
		object obj20 = num5 + obj19;
		object obj21 = obj20 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v472 @ X0_v44] (should have been resolved before IL gen)");
		BalootGameController gameController5 = _gameController;
		goto IL_02a1;
		IL_0364:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_082b;
		IL_082b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v539 @ X0_v6] (should have been resolved before IL gen)");
		BalootGameController gameController6 = _gameController;
		object key = "getSecondRescanTask" + 1696;
		string val = BalootGameModeExtensions.ToClientString(gameController6.GameMode);
		SFSExtensions.Put(((OfflineGameController)gameController6).<RoundState>k__BackingField, (string)key, val);
		BalootGameController gameController7 = _gameController;
		bool flag2 = gameController7.GameMode != BalootGame.BalootGameMode.Hokom;
		object obj22 = 0;
		if (!flag2)
		{
			object key2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 728;
			SFSExtensions.Put(((OfflineGameController)gameController7).<RoundState>k__BackingField, (string)key2, (int)gameController7.TrumpSuit);
			gameController7 = _gameController;
			obj22 = 0;
		}
		ISFSObject <RoundState>k__BackingField4 = ((OfflineGameController)gameController7).<RoundState>k__BackingField;
		object obj23 = "placementId" + 2304;
		nint num6 = (nint)<RoundState>k__BackingField4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0511;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X10_v21-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_0511;
		}
		object obj26 = obj25 + 35;
		object obj27 = num6 + obj26;
		object obj28 = obj27 + 312;
		goto IL_0868;
		IL_065c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08c1;
		IL_075c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08fe;
		IL_0212:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v452 @ X0_v41] (should have been resolved before IL gen)");
		gameController5 = _gameController;
		bool flag3 = _gameController == null;
		object obj29 = !flag3;
		if (obj29 != null)
		{
			goto IL_02a1;
		}
		goto IL_07a9;
		IL_02a1:
		gameController5.MoveNumber = 1;
		ISFSObject <RoundState>k__BackingField5 = ((OfflineGameController)gameController5).<RoundState>k__BackingField;
		object obj30 = "m_StencilDeferredPS" + 2168;
		nint num7 = (nint)<RoundState>k__BackingField5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0364;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj32 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X10_v26-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj32 += 16;
			obj31--;
			if ((nint)obj31 != 1)
			{
				continue;
			}
			goto IL_0364;
		}
		object obj33 = obj32 + 35;
		object obj34 = num7 + obj33;
		object obj35 = obj34 + 312;
		goto IL_082b;
		IL_08c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v684 @ X0_v17] (should have been resolved before IL gen)");
		BalootGameController gameController8 = _gameController;
		((OfflineGameController)gameController8).<GameStatus>k__BackingField = CardGameStage.CardGameStages.Playing;
		ISFSObject <RoundState>k__BackingField6 = ((OfflineGameController)gameController8).<RoundState>k__BackingField;
		object obj36 = "fetch_products" + 1824;
		nint num8 = (nint)<RoundState>k__BackingField6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_075c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj38 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X10_v11-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj38 += 16;
			obj37--;
			if ((nint)obj37 != 1)
			{
				continue;
			}
			goto IL_075c;
		}
		object obj39 = obj38 + 35;
		object obj40 = num8 + obj39;
		object obj41 = obj40 + 312;
		goto IL_08fe;
	}

	public override void OnPlay()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_079e: Expected O, but got I
		//IL_07af: Expected I, but got O
		//IL_07cd: Expected O, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03e3: Expected O, but got I
		//IL_03f1: Expected I, but got O
		//IL_01c6: Expected O, but got I
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_0434: Expected O, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02c9: Expected I, but got O
		//IL_02d9: Expected O, but got I
		//IL_0314: Expected O, but got I
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04c9: Expected I, but got O
		//IL_04d9: Expected O, but got I
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_0514: Expected O, but got I
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected O, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_05c7: Expected O, but got I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_06ab: Expected O, but got I
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06da: Expected O, but got I
		//IL_06eb: Expected I, but got O
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected O, but got Unknown
		//IL_0729: Expected O, but got I4
		BalootGameController gameController = _gameController;
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v53+E4]");
		object obj3;
		object obj4;
		Func<object, bool> func;
		object obj5;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)3496;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v53+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v48+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v48+8]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj3 = (nint)0 + (nint)3496;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v53+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v48+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v48+8]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_009f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v53+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v55+B8]");
			obj4 = 0;
		}
		object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)808;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj4, (IntPtr)obj10);
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v53+B8]");
		object obj12 = (nint)0 + (nint)8;
		obj12 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = obj5;
		int num = Enumerable.Count(gameController.PlayedCards, func2);
		BalootGameController gameController2 = _gameController;
		Func<object, bool> func3 = func2;
		goto IL_0200;
		IL_0355:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0808;
		IL_0808:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v475 @ X0_v20] (should have been resolved before IL gen)");
		BalootGameController gameController3 = _gameController;
		((OfflineGameController)gameController3).<GameStatus>k__BackingField = CardGameStage.CardGameStages.WaitingForEating;
		ISFSObject <RoundState>k__BackingField = ((OfflineGameController)gameController3).<RoundState>k__BackingField;
		object obj14 = "fetch_products" + 1824;
		nint num2 = (nint)<RoundState>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0555;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj16 = (nint)0 + (nint)8;
		object obj17;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X10_v8-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj16 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_0555;
		}
		object obj18 = obj16 + 35;
		object obj19 = num2 + obj18;
		object obj20 = obj19 + 312;
		goto IL_0845;
		IL_0200:
		bool firstPlayer = num == 0;
		gameController2.FirstPlayer = firstPlayer;
		int num3;
		if (num == 4)
		{
			num3 = BalootUtils.CheckWhoEats(gameController2.PlayedCards, gameController2.CurrentSuit, gameController2.GameMode, gameController2.TrumpSuit);
			_gameController.SetMover(num3);
			BalootGameController gameController4 = _gameController;
			ISFSObject <RoundState>k__BackingField2 = ((OfflineGameController)gameController4).<RoundState>k__BackingField;
			obj17 = typeof(System.IOAsyncCallback) + 976;
			object obj21 = "m_StencilDeferredPS" + 2456;
			nint num4 = (nint)<RoundState>k__BackingField2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0355;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj23 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X10_v13-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj23 += 16;
				obj22--;
				if ((nint)obj22 != 1)
				{
					continue;
				}
				goto IL_0355;
			}
			object obj24 = obj23 + 35;
			object obj25 = num4 + obj24;
			object obj26 = obj25 + 312;
			goto IL_0808;
		}
		if (((OfflineGameController)gameController2).<Mover>k__BackingField == 1)
		{
			bool isReplay = SFSKammelnaRoomExtensions.GetIsReplay(((OfflineGameController)gameController2).<Room>k__BackingField);
			bool flag4 = !isReplay;
			func3 = null;
			if (flag4)
			{
				return;
			}
		}
		object obj27 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)2336;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj28);
		object obj29 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj31 = !flag5;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.4f, action);
		return;
		IL_0555:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0845;
		IL_0845:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v550 @ X0_v23] (should have been resolved before IL gen)");
		bool flag6 = num3 != 1;
		object obj32 = obj14;
		if (!flag6)
		{
			BalootGameController gameController5 = _gameController;
			bool isReplay2 = SFSKammelnaRoomExtensions.GetIsReplay(((OfflineGameController)gameController5).<Room>k__BackingField);
			bool flag7 = !isReplay2;
			obj32 = 0;
			if (flag7)
			{
				return;
			}
		}
		object obj33 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = default(object);
		obj34..ctor();
		object obj35 = obj34 + 24;
		obj35 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj36 = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj37 = obj34 + 16;
		obj37 = sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		BalootGameController gameController6 = _gameController;
		object key = "placementId" + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v28 (System.Object)+10]");
		SFSExtensions.Put((ISFSObject)0, (string)key, ((OfflineGameController)gameController6).<Mover>k__BackingField);
		object obj38 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)840;
		Action action2 = default(Action);
		action2..ctor(obj34, (IntPtr)obj39);
		object obj40 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v40+E4]");
		bool flag8 = (nint)0 == 0;
		object obj42 = !flag8;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(1f, action2);
		return;
		IL_009f:
		obj13 = obj3;
		num = Enumerable.Count(gameController.PlayedCards, func);
		gameController2 = _gameController;
		bool flag9 = _gameController == null;
		object obj43 = !flag9;
		func3 = func;
		if (obj43 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0200;
	}

	public void UpdateDeclaredProjectsFirstMove(int playerIndex)
	{
		//IL_0012: Expected O, but got I
		//IL_0025: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_006b: Expected O, but got I
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0b5d: Expected O, but got I4
		//IL_026f: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02d6: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_02fd: Expected O, but got I4
		//IL_0ae2: Expected O, but got I
		//IL_0af3: Expected O, but got I
		//IL_0b03: Expected O, but got I
		//IL_0b25: Expected O, but got I4
		//IL_0381: Expected O, but got I4
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected O, but got Unknown
		//IL_0b95: Expected O, but got I
		//IL_0ba6: Expected I, but got O
		//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Expected O, but got Unknown
		//IL_0bd8: Expected O, but got I
		//IL_0bf3: Expected O, but got I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03c5: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I4
		//IL_01c5: Expected O, but got I
		//IL_044a: Expected O, but got I4
		//IL_0200: Expected O, but got I
		//IL_04ae: Expected O, but got I
		//IL_0509: Expected O, but got I4
		//IL_054e: Expected O, but got I4
		//IL_0c84: Expected O, but got I
		//IL_0c95: Expected O, but got I
		//IL_0ca5: Expected O, but got I
		//IL_0cc7: Expected O, but got I4
		//IL_0595: Expected O, but got I4
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_0610: Expected O, but got I
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected O, but got Unknown
		//IL_0d04: Expected O, but got I
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Expected O, but got Unknown
		//IL_0d29: Expected I, but got O
		//IL_0d47: Expected O, but got I
		//IL_05d4: Expected O, but got I4
		//IL_05c5: Expected O, but got I
		//IL_0db6: Expected O, but got I
		//IL_0dc2: Expected O, but got I
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected O, but got Unknown
		//IL_0de2: Expected O, but got I
		//IL_0dee: Expected O, but got I
		//IL_0dff: Expected O, but got I
		//IL_0e0f: Expected O, but got I
		//IL_0e31: Expected O, but got I4
		//IL_0741: Expected I, but got O
		//IL_06bc: Expected O, but got I4
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected O, but got Unknown
		//IL_0e69: Expected O, but got I
		//IL_0e7a: Expected I, but got O
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected O, but got Unknown
		//IL_0eac: Expected O, but got I
		//IL_0711: Expected O, but got I
		//IL_071d: Expected O, but got I
		//IL_072e: Expected O, but got I4
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_0700: Expected O, but got I
		//IL_079c: Expected O, but got I4
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected O, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0834: Expected I, but got O
		//IL_0844: Expected O, but got I
		//IL_087f: Expected O, but got I
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected O, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected O, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected O, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected O, but got Unknown
		//IL_0957: Expected I, but got O
		//IL_0967: Expected O, but got I
		//IL_09a2: Expected O, but got I
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected O, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected O, but got Unknown
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected O, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		BalootGameController gameController = _gameController;
		object obj2;
		object obj7;
		List<ProjectsUtility<BalootProject>.Project> source3;
		object obj10;
		bool flag3;
		Func<BalootProject, int> func2;
		List<ProjectsUtility<BalootProject>.Project> list2;
		object obj8;
		bool gameMode;
		Func<BalootProject, int> func;
		object obj11 = default(object);
		if (_gameController != null)
		{
			object obj = (nint)0 + (nint)1144;
			IEnumerable<object> source = Enumerable.Cast<object>(((OfflineGameController)gameController).Players);
			object[] array = Enumerable.ToArray(source);
			if (array != null)
			{
				obj2 = playerIndex - 1;
				bool flag = (nint)obj2 < array.Length;
				object obj3 = !flag;
				if (obj3 != null)
				{
					goto IL_0a2e;
				}
				object obj4 = (object)array + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v8+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v8+20]");
				if ((nint)0 != 0)
				{
					BalootGameController gameController2 = _gameController;
					if (playerIndex == 1)
					{
						if (_gameController != null)
						{
							IEnumerable<object> source2 = Enumerable.Cast<object>(((OfflineGameController)gameController2).Players);
							object[] array2 = Enumerable.ToArray(source2);
							if (array2 != null)
							{
								object obj6 = array2[0];
								if (array2[0] != null)
								{
									BalootGameController gameController3 = _gameController;
									if (_gameController != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v86 (System.Object)+40]");
										nint num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v9+20]");
										List<ProjectsUtility<BalootProject>.Project> list = BalootUtils.CheckProjects((List<BalootProject>)num, (List<Card>)0, gameController3.GameMode);
										obj7 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
										obj8 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v10+E4]");
										bool flag2 = (nint)0 == 0;
										object obj9 = !flag2;
										gameMode = (byte)gameController3.GameMode != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v9+20]");
										func = (Func<BalootProject, int>)0;
										source3 = list;
										if (obj9 == null)
										{
											obj10 = obj11;
											flag3 = (byte)gameController3.GameMode != 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v9+20]");
											func2 = (Func<BalootProject, int>)0;
											object obj12 = obj8;
											list2 = list;
											goto IL_0328;
										}
										goto IL_0ad6;
									}
								}
							}
						}
					}
					else if (_gameController != null)
					{
						object obj13 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
						object obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v115+E4]");
						bool flag4 = (nint)0 == 0;
						object obj15 = !flag4;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj16 = gameController2.GameMode - 2;
						bool flag5 = obj16 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v9+20]");
						List<ProjectsUtility<BalootProject>.Project> list3 = BalootProjectUtility.BestProjectCards((List<Card>)0, null, flag5);
						obj7 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
						object obj12 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v111+E4]");
						bool flag6 = (nint)0 == 0;
						object obj17 = !flag6;
						obj10 = 0;
						flag3 = flag5;
						func2 = null;
						list2 = list3;
						obj11 = 0;
						gameMode = flag5;
						func = null;
						obj8 = obj12;
						source3 = list3;
						if (obj17 == null)
						{
							goto IL_0328;
						}
						goto IL_0ad6;
					}
				}
			}
		}
		goto IL_0a20;
		IL_0328:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj7;
		obj11 = obj10;
		gameMode = flag3;
		func = func2;
		source3 = list2;
		goto IL_0ad6;
		IL_0ad6:
		object obj18 = (nint)0 + (nint)2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v10+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v65+10]");
		Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> selector = (Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v65+10]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v10+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v75+B8]");
				obj19 = 0;
			}
			object obj24 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)816;
			Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func3 = default(Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>);
			func3..ctor(obj19, (IntPtr)obj25);
			object obj26 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v72+B8]");
			object obj28 = (nint)0 + (nint)16;
			obj28 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj11 = 0;
			selector = func3;
		}
		IEnumerable<System.Int32Enum> source4 = Enumerable.Select((IEnumerable<ProjectsUtility<System.Int32Enum>.Project>)source3, selector);
		System.Int32Enum[] source5 = Enumerable.ToArray(source4);
		BalootGameController gameController4 = _gameController;
		if (_gameController != null)
		{
			object obj29 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
			IEnumerable<object> source6 = Enumerable.Cast<object>(((OfflineGameController)gameController4).Players);
			object[] array3 = Enumerable.ToArray(source6);
			if (array3 != null)
			{
				bool flag9 = (nint)obj2 < array3.Length;
				object obj30 = !flag9;
				if (obj30 != null)
				{
					goto IL_0a2e;
				}
				object obj31 = (object)array3 + obj2;
				List<System.Int32Enum> list4 = Enumerable.ToList(source5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v6+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v6+20]");
					object obj32 = (nint)0 + (nint)64;
					obj32 = list4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					BalootGameController gameController5 = _gameController;
					if (_gameController != null)
					{
						IEnumerable<object> source7 = Enumerable.Cast<object>(((OfflineGameController)gameController5).Players);
						object[] array4 = Enumerable.ToArray(source7);
						if (array4 != null)
						{
							bool flag10 = (nint)obj2 < array4.Length;
							object obj33 = !flag10;
							if (obj33 != null)
							{
								goto IL_0a2e;
							}
							object obj34 = (object)array4 + obj2;
							object obj35 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v28+E4]");
							bool flag11 = (nint)0 == 0;
							object obj36 = !flag11;
							if (obj36 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj35 = obj29;
							}
							object obj37 = (nint)0 + (nint)280;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v28+B8]");
							object obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v55+18]");
							Func<ProjectsUtility<System.Int32Enum>.Project, IEnumerable<object>> selector2 = (Func<ProjectsUtility<System.Int32Enum>.Project, IEnumerable<object>>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v55+18]");
							bool flag12 = (nint)0 == 0;
							object obj39 = !flag12;
							BalootPlayingManager balootPlayingManager = this;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v28+E4]");
								bool flag13 = (nint)0 == 0;
								object obj40 = !flag13;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj41 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v61+B8]");
									obj38 = 0;
								}
								object obj42 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3768;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj43 = (nint)0 + (nint)824;
								obj29 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
								Func<ProjectsUtility<System.Int32Enum>.Project, object> func4 = default(Func<ProjectsUtility<System.Int32Enum>.Project, object>);
								func4..ctor(obj38, (IntPtr)obj43);
								object obj44 = obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v60+B8]");
								object obj45 = (nint)0 + (nint)24;
								obj45 = func4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								obj11 = 0;
								selector2 = (Func<ProjectsUtility<System.Int32Enum>.Project, IEnumerable<object>>)func4;
								balootPlayingManager = this;
							}
							SFSArray sFSArray = default(SFSArray);
							Func<object, object> func5 = default(Func<object, object>);
							Func<System.Int32Enum, object> func6 = default(Func<System.Int32Enum, object>);
							Action<object> action = default(Action<object>);
							while (true)
							{
								IEnumerable<object> source8 = Enumerable.SelectMany((IEnumerable<ProjectsUtility<System.Int32Enum>.Project>)source3, selector2);
								List<object> list5 = Enumerable.ToList(source8);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v21+20]");
								if ((nint)0 == 0)
								{
									break;
								}
								object obj46 = typeof(RegisteredWaitHandle) + 1888;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v21+20]");
								object obj47 = (nint)0 + (nint)56;
								obj47 = list5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								sFSArray..ctor();
								BalootGameController gameController6 = balootPlayingManager._gameController;
								if (balootPlayingManager._gameController == null)
								{
									break;
								}
								IEnumerable<object> source9 = Enumerable.Cast<object>(((OfflineGameController)gameController6).Players);
								object[] source10 = Enumerable.ToArray(source9);
								object obj48 = obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v42+E4]");
								BalootPlayingManager balootPlayingManager2;
								if ((nint)0 != 0)
								{
									balootPlayingManager2 = balootPlayingManager;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj48 = obj29;
									balootPlayingManager2 = balootPlayingManager;
								}
								object obj49 = (nint)0 + (nint)2928;
								object obj50 = (nint)0 + (nint)1096;
								object obj51 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 304;
								object obj52 = (nint)0 + (nint)2360;
								object obj53 = (nint)0 + (nint)2960;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v42+B8]");
								object obj54 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v42+20]");
								Func<object, object> selector3 = (Func<object, object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v42+20]");
								bool flag14 = (nint)0 == 0;
								object obj55 = !flag14;
								if (obj55 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v42+E4]");
									bool flag15 = (nint)0 == 0;
									object obj56 = !flag15;
									if (obj56 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj57 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
										object obj58 = obj57;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v52+B8]");
										obj54 = 0;
									}
									object obj59 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 264;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj60 = (nint)0 + (nint)832;
									func5..ctor(obj54, (IntPtr)obj60);
									object obj61 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2632;
									object obj62 = obj61;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v49+B8]");
									object obj63 = (nint)0 + (nint)32;
									obj63 = func5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									obj50 = (nint)0 + (nint)1096;
									obj49 = (nint)0 + (nint)2928;
									selector3 = func5;
									obj11 = 0;
								}
								IEnumerable<object> source11 = Enumerable.Select(source10, selector3);
								object[] array5 = Enumerable.ToArray(source11);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								func6..ctor((object)null, (IntPtr)obj52);
								IEnumerable<object> source12 = Enumerable.Select(source5, func6);
								object[] array6 = Enumerable.ToArray(source12);
								if (array5 == null)
								{
									break;
								}
								bool flag16 = (nint)obj2 < array5.Length;
								object obj64 = !flag16;
								if (obj64 != null)
								{
									goto IL_0a2e;
								}
								object obj65 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 984;
								object obj66 = (object)array5 + obj2;
								object obj67 = obj66 + 32;
								obj67 = array6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								if (sFSArray == null)
								{
									break;
								}
								object obj68 = typeof(System.IOAsyncCallback) + 960;
								nint num2 = (nint)sFSArray;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
								object obj69 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_08c0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
								object obj70 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X10_v13-8]");
									if (0 == (nint)obj68)
									{
										break;
									}
									obj70 += 16;
									obj69--;
									if ((nint)obj69 != 1)
									{
										continue;
									}
									goto IL_08c0;
								}
								object obj71 = obj70 + 27;
								object obj72 = num2 + obj71;
								object obj73 = obj72 + 312;
								goto IL_0ee7;
								IL_0ee7:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X0_v57+8]");
								action..ctor((object)sFSArray, (IntPtr)0);
								ArraysExtensions.ForEach(array5, action);
								BalootGameController gameController7 = balootPlayingManager2._gameController;
								if (balootPlayingManager2._gameController == null)
								{
									break;
								}
								ISFSObject <RoundState>k__BackingField = ((OfflineGameController)gameController7).<RoundState>k__BackingField;
								if (((OfflineGameController)gameController7).<RoundState>k__BackingField == null)
								{
									break;
								}
								object obj74 = typeof(System.IOAsyncCallback) + 976;
								object obj75 = "destinationTimeZone" + 816;
								nint num3 = (nint)<RoundState>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
								object obj76 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
									object obj77 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X10_v8-8]");
										if (0 == (nint)obj74)
										{
											break;
										}
										obj77 += 16;
										obj76--;
										if ((nint)obj76 != 1)
										{
											continue;
										}
										goto IL_09e3;
									}
									object obj78 = obj77 + 49;
									object obj79 = num3 + obj78;
									object obj80 = obj79 + 312;
									goto IL_0f60;
								}
								goto IL_09e3;
								IL_09e3:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
								goto IL_0f60;
								IL_08c0:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
								goto IL_0ee7;
								IL_0f60:
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v918 @ X0_v60] (should have been resolved before IL gen)");
							}
						}
					}
				}
			}
		}
		goto IL_0a20;
		IL_0a2e:
		throw new IndexOutOfRangeException();
		IL_0a20:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0a2e;
	}

	public void UpdateProjectSecondMove()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_012d: Expected O, but got I4
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_0451: Expected I, but got O
		//IL_0461: Expected O, but got I
		//IL_049c: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0176: Expected O, but got I
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I
		//IL_01e4: Expected O, but got I4
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_020c: Expected O, but got I4
		//IL_0254: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02af: Expected O, but got I
		//IL_02c0: Expected I, but got O
		//IL_030f: Expected I, but got O
		//IL_031f: Expected O, but got I
		//IL_02db: Expected O, but got I
		//IL_02fa: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_035a: Expected O, but got I
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		BalootGameController gameController = _gameController;
		if (_gameController != null)
		{
			object obj2 = (nint)0 + (nint)1144;
			IEnumerable<object> source = Enumerable.Cast<object>(((OfflineGameController)gameController).Players);
			int[] array = (int[])obj2;
			object[] array2 = Enumerable.ToArray(source);
			if (array2 != null)
			{
				if (array2.Length < 1)
				{
					goto IL_03ce;
				}
				object obj3 = typeof(TypeConverter<ushort, char>) + 3048;
				object obj4 = array2 + 32;
				object obj5 = typeof(System.IOAsyncCallback) + 960;
				object obj7 = default(object);
				object obj6 = obj7;
				object obj8 = 0;
				object obj10 = default(object);
				int[] array4 = default(int[]);
				Func<object, bool> func = default(Func<object, bool>);
				while (true)
				{
					object obj9 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2648;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj10..ctor();
					bool flag = (nint)obj8 < array2.Length;
					object obj11 = !flag;
					if (obj11 != null)
					{
						break;
					}
					int[] array3;
					if (obj10 != null)
					{
						object obj12 = obj10 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X28_v5+v114 @ X25_v6*8]");
						obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object obj13 = obj12;
						if (obj12 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v19+10]");
							object obj14 = -1;
							bool flag2 = (nint)obj14 < 3;
							object obj15 = !flag2;
							object obj16 = obj14 - 3;
							bool flag3 = obj16 == null;
							object obj17 = !flag3;
							object obj18 = obj15 & obj17;
							object obj20;
							if (obj18 == null)
							{
								object obj19 = 118730752 + 3184;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X10_v21+v452 @ X9_v15*4]");
								obj20 = 0;
							}
							else
							{
								obj20 = 0;
							}
							BalootGameController gameController2 = _gameController;
							if (_gameController != null)
							{
								bool flag4 = (nint)obj20 != gameController2.BestProjectTeam;
								array3 = array4;
								if (!flag4)
								{
									object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj22 = (nint)0 + (nint)848;
									func..ctor(obj10, (IntPtr)obj22);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v19+38]");
									IEnumerable<object> cards = Enumerable.Where((IEnumerable<object>)0, func);
									int[] array5 = OfflineGameController.CardsToInt((IEnumerable<Card>)cards);
									obj6 = 0;
									array3 = array5;
								}
								if (sFSArray != null)
								{
									nint num = (nint)sFSArray;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0096;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
									object obj24 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v16-8]");
										if (0 == (nint)obj5)
										{
											break;
										}
										obj24 += 16;
										obj23--;
										if ((nint)obj23 != 1)
										{
											continue;
										}
										goto IL_0096;
									}
									object obj25 = obj24 + 23;
									object obj26 = num + obj25;
									object obj27 = obj26 + 312;
									goto IL_00a5;
								}
							}
						}
					}
					goto IL_051a;
					IL_00a5:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v545 @ X0_v27] (should have been resolved before IL gen)");
					obj8++;
					bool flag5 = (nint)obj8 >= array2.Length;
					array = array3;
					if (!flag5)
					{
						continue;
					}
					goto IL_03ce;
					IL_0096:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					goto IL_00a5;
				}
				goto IL_0528;
			}
		}
		goto IL_051a;
		IL_04dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_063d;
		IL_03ce:
		BalootGameController gameController3 = _gameController;
		if (_gameController != null)
		{
			ISFSObject <RoundState>k__BackingField = ((OfflineGameController)gameController3).<RoundState>k__BackingField;
			if (((OfflineGameController)gameController3).<RoundState>k__BackingField != null)
			{
				object obj28 = typeof(System.IOAsyncCallback) + 976;
				object obj29 = "placementId" + 536;
				nint num2 = (nint)<RoundState>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04dd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj31 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X10_v8-8]");
					if (0 == (nint)obj28)
					{
						break;
					}
					obj31 += 16;
					obj30--;
					if ((nint)obj30 != 1)
					{
						continue;
					}
					goto IL_04dd;
				}
				object obj32 = obj31 + 49;
				object obj33 = num2 + obj32;
				object obj34 = obj33 + 312;
				goto IL_063d;
			}
		}
		goto IL_051a;
		IL_051a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0528;
		IL_0528:
		throw new IndexOutOfRangeException();
		IL_063d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v449 @ X0_v13] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void CopyCards()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_00f2: Expected O, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0067: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		BalootGameController gameController = _gameController;
		IEnumerable<object> source = Enumerable.Cast<object>(((OfflineGameController)gameController).Players);
		object[] array = Enumerable.ToArray(source);
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X23_v4+v90 @ X21_v7*8]");
				object obj3 = 0;
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X20_v8+18]");
				List<object> list = Enumerable.ToList((IEnumerable<object>)0);
				object obj4 = obj3 + 32;
				obj4 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			while ((nint)obj2 < array.Length);
		}
	}

	public override void ClearPlayersVariables()
	{
		//IL_0012: Expected O, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		BalootGameController gameController = _gameController;
		object obj = (nint)0 + (nint)1144;
		IEnumerable<object> source = Enumerable.Cast<object>(((OfflineGameController)gameController).Players);
		List<object> list = (List<object>)obj;
		object[] array = Enumerable.ToArray(source);
		if (array.Length >= 1)
		{
			object obj2 = typeof(List<AdaptivePerformanceScaler>) + 216;
			object obj3 = typeof(List<AdaptivePerformanceScaler>) + 416;
			object obj4 = array + 32;
			object obj5 = 0;
			List<System.Int32Enum> list2 = default(List<System.Int32Enum>);
			List<object> list3 = default(List<object>);
			List<object> list4 = default(List<object>);
			List<object> list5 = default(List<object>);
			bool flag;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list2..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X26_v4+v112 @ X22_v6*8]");
				object obj6 = (nint)0 + (nint)64;
				obj6 = list2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list3..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X26_v4+v112 @ X22_v6*8]");
				object obj7 = (nint)0 + (nint)56;
				obj7 = list3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list4..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X26_v4+v112 @ X22_v6*8]");
				object obj8 = (nint)0 + (nint)40;
				obj8 = list4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list5..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X26_v4+v112 @ X22_v6*8]");
				object obj9 = (nint)0 + (nint)32;
				obj9 = list5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 0;
				_ = 0;
				obj5++;
				flag = (nint)obj5 < array.Length;
				list = list5;
			}
			while (flag);
		}
	}

	public void CheckBaloot(int playerIndex, int bestProjectTeam)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_005f: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0125: Expected O, but got I4
		//IL_00aa: Expected O, but got I
		//IL_01cb: Expected I, but got O
		//IL_01db: Expected O, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0271: Expected O, but got I
		//IL_02a1: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0340: Expected O, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0216: Expected O, but got I
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02ed: Expected O, but got I
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03b7: Expected O, but got I
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03d4: Expected I, but got O
		//IL_03e4: Expected O, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_041f: Expected O, but got I
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0529: Expected O, but got I
		//IL_053c: Expected O, but got I4
		//IL_0557: Expected O, but got I4
		//IL_0582: Expected O, but got I
		//IL_059c: Expected O, but got I4
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_05c4: Expected O, but got I4
		//IL_0634: Expected O, but got I4
		//IL_063d: Expected O, but got I4
		//IL_05ee: Expected O, but got I4
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected O, but got Unknown
		//IL_086a: Expected O, but got I4
		//IL_0700: Expected O, but got I
		//IL_071d: Expected O, but got I
		//IL_0735: Expected O, but got I4
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected O, but got Unknown
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected O, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_07ab: Expected O, but got I
		//IL_07c3: Expected O, but got I4
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected O, but got Unknown
		//IL_092e: Expected I, but got O
		//IL_093e: Expected O, but got I
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		//IL_07f8: Expected O, but got I4
		//IL_0979: Expected O, but got I
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected O, but got Unknown
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected O, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected O, but got Unknown
		//IL_0a3d: Expected I, but got O
		//IL_0a4d: Expected O, but got I
		//IL_0a88: Expected O, but got I
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected O, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected O, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected O, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected O, but got Unknown
		BalootGameController gameController = _gameController;
		object obj;
		BalootGameController gameController2;
		if (_gameController != null)
		{
			ISFSObject <RoundState>k__BackingField = ((OfflineGameController)gameController).<RoundState>k__BackingField;
			if (((OfflineGameController)gameController).<RoundState>k__BackingField != null)
			{
				obj = typeof(System.IOAsyncCallback) + 976;
				object obj2 = "destinationTimeZone" + 816;
				nint num = (nint)<RoundState>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00eb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X10_v31-8]");
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
					goto IL_00eb;
				}
				object obj5 = obj4 + 28;
				object obj6 = num + obj5;
				object obj7 = obj6 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v526 @ X0_v76] (should have been resolved before IL gen)");
				gameController2 = _gameController;
				if (_gameController != null)
				{
					goto IL_0194;
				}
			}
		}
		goto IL_0b06;
		IL_0c85:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X0_v34+8]");
		Action<object> action = default(Action<object>);
		SFSArray sFSArray = default(SFSArray);
		action..ctor((object)sFSArray, (IntPtr)0);
		object[] array;
		ArraysExtensions.ForEach(array, action);
		BalootGameController gameController3 = _gameController;
		object obj11;
		if (_gameController != null)
		{
			ISFSObject <RoundState>k__BackingField2 = ((OfflineGameController)gameController3).<RoundState>k__BackingField;
			if (((OfflineGameController)gameController3).<RoundState>k__BackingField != null)
			{
				object obj8 = "destinationTimeZone" + 816;
				nint num2 = (nint)<RoundState>k__BackingField2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0ac9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X10_v11-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					obj10 += 16;
					obj9--;
					if ((nint)obj9 != 1)
					{
						continue;
					}
					goto IL_0ac9;
				}
				object obj12 = obj10 + 49;
				object obj13 = num2 + obj12;
				object obj14 = obj13 + 312;
				goto IL_0cf8;
			}
		}
		goto IL_0b06;
		IL_0c30:
		obj11 = typeof(System.IOAsyncCallback) + 976;
		object obj15;
		object obj21;
		if (array != null)
		{
			bool flag = (nint)obj15 < array.Length;
			object obj16 = !flag;
			if (obj16 != null)
			{
				goto IL_0b14;
			}
			object obj17 = typeof(RegisteredWaitHandle) + 1888;
			object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 984;
			object obj19 = (object)array + obj15;
			object obj20 = obj19 + 32;
			obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSArray..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			if (sFSArray != null)
			{
				object obj22 = typeof(System.IOAsyncCallback) + 960;
				nint num3 = (nint)sFSArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_09ba;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
				object obj24 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X10_v16-8]");
					if (0 == (nint)obj22)
					{
						break;
					}
					obj24 += 16;
					obj23--;
					if ((nint)obj23 != 1)
					{
						continue;
					}
					goto IL_09ba;
				}
				object obj25 = obj24 + 27;
				object obj26 = num3 + obj25;
				object obj27 = obj26 + 312;
				goto IL_0c85;
			}
		}
		goto IL_0b06;
		IL_0612:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v12+20]");
		bool flag2 = (nint)0 == 0;
		object obj28 = !flag2;
		object obj29 = 0;
		if (obj28 != null)
		{
			goto IL_0805;
		}
		goto IL_0b06;
		IL_09ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c85;
		IL_0cf8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v907 @ X0_v37] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0b14:
		throw new IndexOutOfRangeException();
		IL_00eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v440 @ X0_v73] (should have been resolved before IL gen)");
		gameController2 = _gameController;
		bool flag3 = _gameController == null;
		object obj30 = !flag3;
		if (obj30 != null)
		{
			goto IL_0194;
		}
		goto IL_0b06;
		IL_0194:
		ISFSObject <RoundState>k__BackingField3 = ((OfflineGameController)gameController2).<RoundState>k__BackingField;
		BalootGameController gameController4;
		object obj36;
		if (((OfflineGameController)gameController2).<RoundState>k__BackingField != null)
		{
			nint num4 = (nint)<RoundState>k__BackingField3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0257;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj32 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v26-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj32 += 16;
				obj31--;
				if ((nint)obj31 != 1)
				{
					continue;
				}
				goto IL_0257;
			}
			object obj33 = obj32 + 2;
			object obj34 = num4 + obj33;
			object obj35 = obj34 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v69+8]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v69] (should have been resolved before IL gen)");
			gameController4 = _gameController;
			if (_gameController != null)
			{
				goto IL_0320;
			}
		}
		goto IL_0b06;
		IL_0460:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0bb0;
		IL_0bb0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v12+8]");
		Func<int, object> func = default(Func<int, object>);
		object obj37 = default(object);
		func..ctor(obj37, (IntPtr)0);
		object obj39;
		object obj38 = obj39;
		Array array2 = default(Array);
		IEnumerable<object> source = Enumerable.Select((IEnumerable<int>)array2, func);
		array = Enumerable.ToArray(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj40 = default(object);
		if (obj40 != null)
		{
			object obj41 = "alignContent" + 3792;
			object obj42 = obj40 + 32;
			obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			BalootGameController gameController5 = _gameController;
			if (_gameController != null)
			{
				object obj43 = (nint)0 + (nint)1144;
				IEnumerable<object> source2 = Enumerable.Cast<object>(((OfflineGameController)gameController5).Players);
				object[] array3 = Enumerable.ToArray(source2);
				if (array3 != null)
				{
					obj15 = playerIndex - 1;
					bool flag4 = (nint)obj15 < array3.Length;
					object obj44 = !flag4;
					if (obj44 != null)
					{
						goto IL_0b14;
					}
					object obj45 = (object)array3 + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v12+20]");
					object obj46 = 0;
					bool flag5 = (nint)obj15 < 3;
					object obj47 = !flag5;
					object obj48 = obj15 - 3;
					bool flag6 = obj48 == null;
					object obj49 = !flag6;
					object obj50 = obj47 & obj49;
					if (obj50 == null)
					{
						object obj51 = 118730752 + 3184;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X9_v33+v416 @ X8_v19*4]");
						if ((nint)0 != bestProjectTeam)
						{
							goto IL_0612;
						}
					}
					else if (0 != bestProjectTeam)
					{
						goto IL_0612;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v12+20]");
					if ((nint)0 != 0)
					{
						object obj52 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Card card = default(Card);
						card..ctor(Rank.KING, gameController4.TrumpSuit);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X27_v7+38]");
						if ((nint)0 != 0)
						{
							object obj53 = (nint)0 + (nint)2672;
							obj38 = obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X27_v7+38]");
							bool flag7 = ((List<object>)0).Contains(card);
							bool flag8 = !flag7;
							obj29 = 0;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								Card card2 = default(Card);
								card2..ctor(Rank.QUEEN, gameController4.TrumpSuit);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X27_v7+38]");
								if ((nint)0 == 0)
								{
									goto IL_0b06;
								}
								obj38 = obj53;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X27_v7+38]");
								bool flag9 = ((List<object>)0).Contains(card2);
								bool flag10 = !flag9;
								obj29 = 0;
								if (!flag10)
								{
									object obj54 = typeof(SqlSingle[]) + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									obj29 = 0;
									object obj55 = default(object);
									obj21 = obj55;
									goto IL_0c30;
								}
							}
							goto IL_0805;
						}
					}
				}
			}
		}
		goto IL_0b06;
		IL_0b06:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b14;
		IL_0805:
		_ = 1;
		BalootGameController gameController6 = _gameController;
		if (_gameController == null)
		{
			goto IL_0b06;
		}
		gameController6.BalootProjectShown = true;
		obj21 = obj40;
		goto IL_0c30;
		IL_0ac9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0cf8;
		IL_0257:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v66+8]");
		obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v555 @ X0_v66] (should have been resolved before IL gen)");
		gameController4 = _gameController;
		bool flag11 = _gameController == null;
		object obj56 = !flag11;
		if (obj56 != null)
		{
			goto IL_0320;
		}
		goto IL_0b06;
		IL_0320:
		object obj57 = typeof(TypeConverter<ushort, char>) + 3048;
		object fldHandle = (nint)0 + (nint)1864;
		object obj58 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)fldHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		if (obj37 == null)
		{
			goto IL_0b06;
		}
		object obj59 = typeof(System.IOAsyncCallback) + 960;
		obj39 = (nint)0 + (nint)3416;
		object obj60 = typeof(SqlSingle[]) + 32;
		nint num5 = (nint)obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v12 (Il2CppClass<System.Object>)+12E]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v12 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0460;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v12 (Il2CppClass<System.Object>)+B0]");
		object obj62 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X10_v21-8]");
			if (0 == (nint)obj59)
			{
				break;
			}
			obj62 += 16;
			obj61--;
			if ((nint)obj61 != 1)
			{
				continue;
			}
			goto IL_0460;
		}
		object obj63 = obj62 + 49;
		object obj64 = num5 + obj63;
		object obj65 = obj64 + 312;
		goto IL_0bb0;
	}

	public void CheckEkkah(Card card, int playerIndex, bool forceEkkah = false)
	{
		//IL_0288: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_089a: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_007d: Expected O, but got I
		//IL_0315: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0178: Expected I, but got O
		//IL_0188: Expected O, but got I
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected O, but got Unknown
		//IL_085f: Expected O, but got I
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_038f: Expected I, but got O
		//IL_039f: Expected O, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_03da: Expected O, but got I
		//IL_0460: Expected I, but got O
		//IL_0470: Expected O, but got I
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_04ab: Expected O, but got I
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_05ad: Expected O, but got I4
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0630: Expected I, but got O
		//IL_0640: Expected O, but got I
		//IL_09d5: Expected I, but got O
		//IL_09e5: Expected O, but got I
		//IL_067b: Expected O, but got I
		//IL_070f: Expected O, but got I
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected O, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected O, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		BalootGameController gameController = _gameController;
		if (_gameController != null)
		{
			bool flag = default(bool);
			if (flag)
			{
				goto IL_07cb;
			}
			if (!BalootUtils.CheckIfCardEats(card, gameController.GameMode, gameController.AllPlayedCards, gameController.TrumpSuit))
			{
				return;
			}
			if (card != null)
			{
				object obj = card.<Suit>k__BackingField - gameController.TrumpSuit;
				bool flag2 = obj == null;
				object obj2 = !flag2;
				object obj3 = ~obj2;
				bool flag3;
				if (obj3 == null)
				{
					object obj4 = gameController.MoveNumber - 8;
					flag3 = obj4 == null;
				}
				else
				{
					flag3 = true;
				}
				object obj5 = !flag3;
				if (obj5 == null)
				{
					return;
				}
				gameController = _gameController;
				bool flag4 = _gameController == null;
				object obj6 = !flag4;
				if (obj6 != null)
				{
					goto IL_07cb;
				}
			}
		}
		goto IL_078d;
		IL_092e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v663 @ X0_v26] (should have been resolved before IL gen)");
		object obj7 = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		object obj8 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj9 = default(object);
		object[] array;
		object obj12;
		object obj19;
		if (obj9 != null)
		{
			object obj10 = "destinationTimeZone" + 1712;
			object obj11 = obj9 + 32;
			obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (array != null)
			{
				bool flag5 = (nint)obj12 < array.Length;
				object obj13 = !flag5;
				if (obj13 != null)
				{
					goto IL_079b;
				}
				object obj14 = (object)array + obj12;
				object obj15 = obj14 + 32;
				obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 984;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				if (sFSArray != null)
				{
					nint num = (nint)sFSArray;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_06bc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
					object obj18 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X10_v16-8]");
						if (0 == (nint)obj19)
						{
							break;
						}
						obj18 += 16;
						obj17--;
						if ((nint)obj17 != 1)
						{
							continue;
						}
						goto IL_06bc;
					}
					object obj20 = obj18 + 27;
					object obj21 = num + obj20;
					object obj22 = obj21 + 312;
					goto IL_09a6;
				}
			}
		}
		goto IL_078d;
		IL_06bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09a6;
		IL_041b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08cc;
		IL_08cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v21+8]");
		Func<int, object> func = default(Func<int, object>);
		object obj23 = default(object);
		func..ctor(obj23, (IntPtr)0);
		Array array2 = default(Array);
		IEnumerable<object> source = Enumerable.Select((IEnumerable<int>)array2, func);
		array = Enumerable.ToArray(source);
		ISFSObject <RoundState>k__BackingField;
		nint num2 = (nint)<RoundState>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04ec;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		object obj26;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X10_v21-8]");
			if (0 == (nint)obj26)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_04ec;
		}
		object obj27 = obj25 + 2;
		object obj28 = num2 + obj27;
		object obj29 = obj28 + 312;
		goto IL_092e;
		IL_09a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v41+8]");
		Action<object> action = default(Action<object>);
		action..ctor((object)sFSArray, (IntPtr)0);
		ArraysExtensions.ForEach(array, action);
		nint num3 = (nint)<RoundState>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0750;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X10_v11-8]");
			if (0 == (nint)obj26)
			{
				break;
			}
			obj31 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_0750;
		}
		object obj32 = obj31 + 49;
		object obj33 = num3 + obj32;
		object obj34 = obj33 + 312;
		goto IL_0a2e;
		IL_079b:
		throw new IndexOutOfRangeException();
		IL_078d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_079b;
		IL_0204:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_082b;
		IL_07cb:
		IEnumerable<object> source2 = Enumerable.Cast<object>(((OfflineGameController)gameController).Players);
		object[] array3 = Enumerable.ToArray(source2);
		if (array3 != null)
		{
			obj12 = playerIndex - 1;
			bool flag6 = (nint)obj12 < array3.Length;
			object obj35 = !flag6;
			if (obj35 != null)
			{
				goto IL_079b;
			}
			object obj36 = (object)array3 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v11+20]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v11+20]");
			if ((nint)0 != 0)
			{
				_ = 1;
				BalootGameController gameController2 = _gameController;
				if (_gameController != null)
				{
					gameController2.EkkahProjectShown = true;
					if (card != null)
					{
						if (card.<Rank>k__BackingField == Rank.ACE)
						{
							return;
						}
						<RoundState>k__BackingField = ((OfflineGameController)gameController2).<RoundState>k__BackingField;
						if (((OfflineGameController)gameController2).<RoundState>k__BackingField != null)
						{
							obj26 = typeof(System.IOAsyncCallback) + 976;
							object obj38 = "destinationTimeZone" + 816;
							nint num4 = (nint)<RoundState>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0204;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
							object obj40 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X10_v31-8]");
								if (0 == (nint)obj26)
								{
									break;
								}
								obj40 += 16;
								obj39--;
								if ((nint)obj39 != 1)
								{
									continue;
								}
								goto IL_0204;
							}
							object obj41 = obj40 + 28;
							object obj42 = num4 + obj41;
							object obj43 = obj42 + 312;
							goto IL_082b;
						}
					}
				}
			}
		}
		goto IL_078d;
		IL_082b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v498 @ X0_v14] (should have been resolved before IL gen)");
		object obj44 = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object fldHandle = (nint)0 + (nint)1864;
		RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)fldHandle);
		object obj45 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		if (obj23 == null)
		{
			goto IL_078d;
		}
		obj19 = typeof(System.IOAsyncCallback) + 960;
		nint num5 = (nint)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v23 (Il2CppClass<System.Object>)+12E]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v23 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_041b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v23 (Il2CppClass<System.Object>)+B0]");
		object obj47 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v26-8]");
			if (0 == (nint)obj19)
			{
				break;
			}
			obj47 += 16;
			obj46--;
			if ((nint)obj46 != 1)
			{
				continue;
			}
			goto IL_041b;
		}
		object obj48 = obj47 + 49;
		object obj49 = num5 + obj48;
		object obj50 = obj49 + 312;
		goto IL_08cc;
		IL_0750:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0a2e;
		IL_0a2e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v829 @ X0_v44] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_04ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_092e;
	}

	private void <OnPlay>b__3_1()
	{
		//IL_0024: Expected I, but got O
		//IL_0034: Expected O, but got I
		//IL_0044: Expected O, but got I
		BalootGameController gameController = _gameController;
		int <Mover>k__BackingField = ((OfflineGameController)gameController).<Mover>k__BackingField;
		nint num = (nint)gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v1 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+338]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v1 (Il2CppClass<KammelnaOffline.Baloot.BalootGameController>)+340]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
