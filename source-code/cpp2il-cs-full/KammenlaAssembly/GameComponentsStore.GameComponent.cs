using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;

public class GameComponentsStore : ScriptableObject
{
	private enum GameType
	{
		Friendly = 1,
		Ranked = 2,
		Tournament = 4,
		FastTrack = 8,
		Tutorial = 0x10,
		Replay = 0x20,
		Challenge = 0x40
	}

	private enum GameMode
	{
		Online = 1,
		Offline
	}

	private enum RoomProperties
	{
		Cheating = 1,
		NonCheating
	}

	public enum Placement
	{
		TopBar,
		BottomBar,
		GameUI,
		Popup
	}

	[Serializable]
	private class GameComponent
	{
		public AssetReferenceGameObject Prefab;

		public GameType GameType;

		public GameMode Mode;

		public RoomProperties Properties;

		public Placement Placement = Placement.Popup;
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameComponent, Placement> <>9__4_0;

		public static Func<GameComponent, AssetReferenceGameObject> <>9__4_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal Placement <GetComponentsFor>b__4_0(GameComponent component)
		{
			//IL_0035: Expected I4, but got O
			if (component != null)
			{
				return component.Placement;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Placement)ex;
		}

		internal AssetReferenceGameObject <GetComponentsFor>b__4_1(GameComponent component)
		{
			if (component != null)
			{
				return component.Prefab;
			}
			return (AssetReferenceGameObject)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public GameType gameType;

		public GameMode gameMode;

		public RoomProperties properties;

		internal bool <GetComponentsFor>g__MatchTags|2(GameComponent comp)
		{
			//IL_0132: Expected I4, but got O
			//IL_0053: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_00f9: Expected O, but got I4
			if (comp != null)
			{
				if (comp.GameType != 0)
				{
					object obj = gameType & comp.GameType;
					if (obj == null)
					{
						goto IL_0118;
					}
				}
				if (comp.Mode != 0)
				{
					object obj2 = gameMode & comp.Mode;
					if (obj2 == null)
					{
						goto IL_0118;
					}
				}
				if (comp.Properties != 0)
				{
					object obj3 = properties & comp.Properties;
					bool flag = obj3 == null;
					return !flag;
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0118:
			return false;
		}
	}

	private GameComponentsStore baseStore;

	private List<GameComponent> components;

	private List<GameComponent> Components
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0151: Expected O, but got I4
			//IL_01a0: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AE5]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				obj5 = baseStore;
				obj6 = baseStore;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = baseStore;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = baseStore;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 != null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				goto IL_00bd;
			}
			goto IL_01af;
			IL_00bd:
			if ((object)baseStore != null)
			{
				List<GameComponent> first = baseStore.Components;
				IEnumerable<object> source = Enumerable.Union((IEnumerable<object>)first, (IEnumerable<object>)components);
				return (List<GameComponent>)(object)Enumerable.ToList(source);
			}
			return (List<GameComponent>)(object)new NullReferenceException();
			IL_01af:
			return components;
			IL_0091:
			if (obj5 != null)
			{
				goto IL_00bd;
			}
			goto IL_01af;
		}
	}

	public ILookup<Placement, AssetReferenceGameObject> GetComponentsFor(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_0542: Expected O, but got I4
		//IL_054b: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_0583: Expected I, but got O
		//IL_0144: Expected I, but got O
		//IL_02d9: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_030b: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_01a2: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_0410: Expected O, but got I
		//IL_0420: Expected O, but got I
		//IL_0430: Expected O, but got I
		//IL_0452: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_023a: Expected O, but got I
		//IL_024a: Expected O, but got I
		//IL_025a: Expected O, but got I
		//IL_027c: Expected O, but got I4
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_05b2: Expected O, but got I
		//IL_05ba: Expected I, but got O
		//IL_05cb: Expected I, but got O
		//IL_05e9: Expected O, but got I
		//IL_0492: Expected O, but got I4
		//IL_03a2: Expected O, but got I4
		//IL_03ab: Expected O, but got I4
		//IL_03c4: Expected O, but got I4
		//IL_03cc: Expected I, but got O
		//IL_0373: Expected O, but got I
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_062a: Expected O, but got I
		//IL_063b: Expected I, but got O
		//IL_0659: Expected O, but got I
		//IL_04c2: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		GameType typeForRoom = ((GameComponentsStore)obj2).GetTypeForRoom(room);
		object obj6;
		Func<object, bool> func = default(Func<object, bool>);
		nint num;
		object obj24;
		Func<object, bool> func4;
		Func<object, System.Int32Enum> func6;
		object obj26;
		object obj25;
		nint num2;
		Func<object, bool> func5;
		object obj13;
		Func<object, System.Int32Enum> func2;
		if (obj2 != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 392;
			object obj4 = (nint)0 + (nint)1480;
			object obj5 = (nint)0 + (nint)3904;
			obj6 = typeof(DebugUI.BitField) + 3960;
			bool flag = SFSKammelnaRoomExtensions.IsOffline(room);
			bool flag2 = !flag;
			object obj7 = !flag2;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				object obj9 = 1 + 1;
			}
			else
			{
				object obj9 = 1;
			}
			bool flag3 = SFSKammelnaRoomExtensions.IsCheatingAllowed(room);
			bool flag4 = !flag3;
			object obj10 = !flag4;
			object obj11 = 1;
			object obj12 = 0;
			if (obj10 == null)
			{
				TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room);
				if (!TutorialTypeExtensions.IsCatchTutorial(tutorialType))
				{
					obj11 = 1 + 1;
					obj12 = 0;
				}
				else
				{
					obj11 = 1;
					obj12 = 0;
				}
			}
			List<GameComponent> source = Components;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj4);
			num = (nint)obj5;
			IEnumerable<object> enumerable = Enumerable.Where(source, func);
			obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v21+E4]");
			object obj14;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v21+B8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v18+8]");
				func2 = (Func<object, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v18+8]");
				bool flag5 = (nint)0 == 0;
				object obj15 = obj13;
				if (!flag5)
				{
					goto IL_01cf;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v21+B8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v18+8]");
				func2 = (Func<object, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v18+8]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				object obj15 = obj13;
				if (obj16 != null)
				{
					goto IL_01cf;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v32+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj18 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v25+B8]");
				obj14 = 0;
			}
			object obj19 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)1464;
			num = (nint)obj20;
			Func<object, System.Int32Enum> func3 = default(Func<object, System.Int32Enum>);
			func3..ctor(obj14, (IntPtr)obj20);
			object obj21 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v23+B8]");
			object obj22 = (nint)0 + (nint)8;
			obj22 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v21+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			obj24 = 0;
			func4 = (Func<object, bool>)(object)func3;
			func2 = func3;
			obj25 = 0;
			num2 = (nint)obj20;
			func5 = (Func<object, bool>)(object)func3;
			obj26 = obj13;
			func6 = func3;
			if (obj23 != null)
			{
				goto IL_022e;
			}
			goto IL_03f2;
		}
		return (ILookup<Placement, AssetReferenceGameObject>)new NullReferenceException();
		IL_04c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DEA0C4");
		ILookup<Placement, AssetReferenceGameObject> result = default(ILookup<Placement, AssetReferenceGameObject>);
		return result;
		IL_01cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v21+E4]");
		bool flag9 = (nint)0 == 0;
		obj24 = 0;
		func4 = func;
		obj25 = 0;
		num2 = num;
		func5 = func;
		obj26 = obj13;
		func6 = func2;
		if (!flag9)
		{
			goto IL_022e;
		}
		goto IL_03f2;
		IL_022e:
		object obj27 = (nint)0 + (nint)2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v21+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v7+10]");
		Func<object, object> func7 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v7+10]");
		bool flag10 = (nint)0 == 0;
		object obj29 = !flag10;
		object obj30;
		if (obj29 == null)
		{
			obj25 = obj24;
			num2 = num;
			obj30 = obj27;
			func5 = func4;
			func6 = func2;
			goto IL_0470;
		}
		goto IL_04c7;
		IL_03f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj6;
		obj30 = (nint)0 + (nint)2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v21+B8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v7+10]");
		func7 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v7+10]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		obj27 = obj30;
		func2 = func6;
		if (obj31 == null)
		{
			goto IL_0470;
		}
		goto IL_04c7;
		IL_0470:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v21+E4]");
		bool flag12 = (nint)0 == 0;
		object obj32 = !flag12;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v13+B8]");
			obj28 = 0;
		}
		object obj34 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)1472;
		Func<object, object> func8 = default(Func<object, object>);
		func8..ctor(obj28, (IntPtr)obj35);
		object obj36 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v12+B8]");
		object obj37 = (nint)0 + (nint)16;
		obj37 = func8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj27 = obj30;
		func7 = func8;
		func2 = func6;
		goto IL_04c7;
	}

	private GameType GetTypeForRoom(Room room)
	{
		//IL_0159: Expected O, but got I4
		if (SFSKammelnaRoomExtensions.GetTutorialType(room) != TutorialType.None)
		{
			return GameType.Tutorial;
		}
		if (SFSKammelnaRoomExtensions.GetIsReplay(room))
		{
			return GameType.Replay;
		}
		global::GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		if (GameTypeExtensions.IsFriendly(gameType))
		{
			return GameType.Friendly;
		}
		if (GameTypeExtensions.IsRanked(gameType))
		{
			return GameType.Ranked;
		}
		if (GameTypeExtensions.IsTournament(gameType))
		{
			return GameType.Tournament;
		}
		if (GameTypeExtensions.IsFastTrack(gameType))
		{
			return GameType.FastTrack;
		}
		bool flag = GameTypeExtensions.IsChallenge(gameType);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			return GameType.Challenge;
		}
		return GameType.Friendly;
	}

	private GameMode GetModeForRoom(Room room)
	{
		//IL_0027: Expected O, but got I4
		bool flag = SFSKammelnaRoomExtensions.IsOffline(room);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			return GameMode.Offline;
		}
		return GameMode.Online;
	}

	private RoomProperties GetRoomProperties(Room room)
	{
		//IL_0027: Expected O, but got I4
		bool flag = SFSKammelnaRoomExtensions.IsCheatingAllowed(room);
		bool flag2 = !flag;
		object obj = !flag2;
		RoomProperties result = RoomProperties.Cheating;
		if (obj == null)
		{
			TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room);
			result = (TutorialTypeExtensions.IsCatchTutorial(tutorialType) ? RoomProperties.Cheating : RoomProperties.NonCheating);
		}
		return result;
	}
}
