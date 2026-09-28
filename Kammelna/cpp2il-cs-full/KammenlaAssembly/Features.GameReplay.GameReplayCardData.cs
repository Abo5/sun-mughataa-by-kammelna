using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

namespace Features.GameReplay;

public class GameReplayCardData
{
	private readonly GameReplay <GameReplay>k__BackingField;

	private IThemeColorProfile <Color>k__BackingField;

	private int[] <DisplayPlayersDbIds>k__BackingField;

	private string[] <DisplayPlayersNames>k__BackingField;

	private int[] <DisplayPlayersRanksPoints>k__BackingField;

	private bool[] <DisplayPlayersRanksIsNew>k__BackingField;

	private int <DisplayTeamScore1>k__BackingField;

	private int <DisplayTeamScore2>k__BackingField;

	public GameReplay GameReplay
	{
		get
		{
			return <GameReplay>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public IThemeColorProfile Color
	{
		get
		{
			return <Color>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool HasTheme
	{
		get
		{
			//IL_00c2: Expected I4, but got O
			//IL_00a2: Expected O, but got I4
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected I4, but got Unknown
			GameReplay gameReplay = <GameReplay>k__BackingField;
			if (<GameReplay>k__BackingField != null)
			{
				bool flag = gameReplay.<RoomThemeId>k__BackingField < 0;
				bool flag2 = gameReplay.<RoomThemeId>k__BackingField == 0;
				int num = gameReplay.<RoomThemeId>k__BackingField ^ gameReplay.<RoomThemeId>k__BackingField;
				int num2 = gameReplay.<RoomThemeId>k__BackingField & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int[] DisplayPlayersDbIds
	{
		get
		{
			return <DisplayPlayersDbIds>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string[] DisplayPlayersNames
	{
		get
		{
			return <DisplayPlayersNames>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int[] DisplayPlayersRanksPoints
	{
		get
		{
			return <DisplayPlayersRanksPoints>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool[] DisplayPlayersRanksIsNew
	{
		get
		{
			return <DisplayPlayersRanksIsNew>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int DisplayTeamScore1
	{
		get
		{
			return <DisplayTeamScore1>k__BackingField;
		}
		private set
		{
			<DisplayTeamScore1>k__BackingField = value;
		}
	}

	public int DisplayTeamScore2
	{
		get
		{
			return <DisplayTeamScore2>k__BackingField;
		}
		private set
		{
			<DisplayTeamScore2>k__BackingField = value;
		}
	}

	public static GameReplayCardData FromGameReplay(GameReplay gameReplay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = gameReplay;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((GameReplayCardData)obj2).BuildDisplayData();
			GenerateColorTheme((GameReplayCardData)obj2);
			return (GameReplayCardData)obj2;
		}
		return (GameReplayCardData)(object)new NullReferenceException();
	}

	private void BuildDisplayData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0146: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0348: Expected O, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_035f: Expected O, but got I
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_01de: Expected O, but got I
		//IL_0395: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_03ab: Expected O, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_022b: Expected O, but got I
		//IL_03e1: Expected O, but got I
		//IL_0241: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_03f2: Expected O, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0277: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_0288: Expected O, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_045d: Expected I4, but got O
		//IL_02c4: Expected O, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f3: Expected I4, but got O
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E820B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v38+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string userDbId = UserInfo.UserDbId;
		int value = int.Parse(userDbId);
		GameReplay gameReplay = <GameReplay>k__BackingField;
		goto IL_013a;
		IL_013a:
		object obj5 = (nint)0 + (nint)3552;
		int num = Array.IndexOf(gameReplay.<PlayersDbIds>k__BackingField, value);
		int num2 = num | 2;
		if (num2 == 3)
		{
			GameReplay gameReplay2 = <GameReplay>k__BackingField;
			int[] array = SwapTeamsToCardOrder(gameReplay2.<PlayersDbIds>k__BackingField);
			object obj6 = this + 32;
			obj6 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X20_v13-10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v17+30]");
			object[] array2 = SwapTeamsToCardOrder((object[])0);
			object obj8 = this + 40;
			obj8 = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X20_v15-18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v18+38]");
			int[] array3 = SwapTeamsToCardOrder((int[])0);
			object obj10 = this + 48;
			obj10 = array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X20_v17-20]");
			object obj11 = 0;
			object obj12 = (nint)0 + (nint)1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E34630");
			object obj13 = this + 56;
			object obj14 = default(object);
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X20_v19-28]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v20+90]");
			<DisplayTeamScore1>k__BackingField = 0;
			object obj16 = obj15 + 140;
			<DisplayTeamScore2>k__BackingField = (int)obj16;
		}
		else
		{
			GameReplay gameReplay3 = <GameReplay>k__BackingField;
			int[] array4 = ToCardOrder(gameReplay3.<PlayersDbIds>k__BackingField);
			object obj17 = this + 32;
			obj17 = array4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X20_v4-10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v6+30]");
			object[] array5 = ToCardOrder((object[])0);
			object obj19 = this + 40;
			obj19 = array5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X20_v6-18]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v9+38]");
			int[] array6 = ToCardOrder((int[])0);
			object obj21 = this + 48;
			obj21 = array6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X20_v8-20]");
			object obj22 = 0;
			object obj23 = (nint)0 + (nint)2016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E34C74");
			object obj24 = this + 56;
			object obj25 = default(object);
			obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X20_v10-28]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v13+8C]");
			<DisplayTeamScore1>k__BackingField = 0;
			object obj27 = obj26 + 144;
			<DisplayTeamScore2>k__BackingField = (int)obj27;
		}
		return;
		IL_0074:
		string userDbId2 = UserInfo.UserDbId;
		value = int.Parse(userDbId2);
		gameReplay = <GameReplay>k__BackingField;
		bool flag2 = <GameReplay>k__BackingField == null;
		object obj28 = !flag2;
		if (obj28 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013a;
	}

	private static T[] ToCardOrder<T>(T[] source)
	{
		//IL_0050: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I4
		//IL_01d3: Expected O, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		if (source != null)
		{
			if (source.Length == 4)
			{
				object obj = (nint)0 + (nint)309;
				object obj2 = obj & 1;
				bool flag = obj2 == null;
				object obj3 = !flag;
				nint num = 0;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				if (source.Length != 0)
				{
					T[] array = default(T[]);
					if (array == null)
					{
						goto IL_02aa;
					}
					if (array.Length != 0)
					{
						array[0] = source[0];
						bool flag2 = source.Length < 2;
						object obj4 = !flag2;
						object obj5 = source.Length - 2;
						bool flag3 = obj5 == null;
						object obj6 = ~obj4;
						object obj7 = obj6 | flag3;
						if (obj7 == null && array.Length != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X0 (T[])+22]");
							_ = 0;
							bool flag4 = array.Length < 2;
							object obj8 = !flag4;
							object obj9 = array.Length - 2;
							bool flag5 = obj9 == null;
							object obj10 = ~obj8;
							object obj11 = obj10 | flag5;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X0 (T[])+21]");
								_ = 0;
								if (source.Length != 3 && array.Length != 3)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X0 (T[])+23]");
									_ = 0;
									return array;
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				goto IL_02aa;
			}
			return source;
		}
		return null;
		IL_02aa:
		return (T[])(object)new NullReferenceException();
	}

	private static T[] SwapTeamsToCardOrder<T>(T[] source)
	{
		//IL_0050: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_015a: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_0211: Expected O, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		if (source != null)
		{
			if (source.Length == 4)
			{
				object obj = (nint)0 + (nint)309;
				object obj2 = obj & 1;
				bool flag = obj2 == null;
				object obj3 = !flag;
				nint num = 0;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				bool flag2 = source.Length < 1;
				object obj4 = !flag2;
				object obj5 = source.Length - 1;
				bool flag3 = obj5 == null;
				object obj6 = ~obj4;
				object obj7 = obj6 | flag3;
				if (obj7 == null)
				{
					T[] array = default(T[]);
					if (array == null)
					{
						goto IL_02cb;
					}
					if (array.Length != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X0 (T[])+21]");
						array[0] = (T)0;
						bool flag4 = source.Length < 3;
						object obj8 = !flag4;
						object obj9 = source.Length - 3;
						bool flag5 = obj9 == null;
						object obj10 = ~obj8;
						object obj11 = obj10 | flag5;
						if (obj11 == null && array.Length != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X0 (T[])+23]");
							_ = 0;
							bool flag6 = array.Length < 2;
							object obj12 = !flag6;
							object obj13 = array.Length - 2;
							bool flag7 = obj13 == null;
							object obj14 = ~obj12;
							object obj15 = obj14 | flag7;
							if (obj15 == null)
							{
								_ = source[0];
								if (array.Length != 3)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X0 (T[])+22]");
									_ = 0;
									return array;
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				goto IL_02cb;
			}
			return source;
		}
		return null;
		IL_02cb:
		return (T[])(object)new NullReferenceException();
	}

	private static void GenerateColorTheme(GameReplayCardData gameReplayCardData)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		GameReplay gameReplay = gameReplayCardData.<GameReplay>k__BackingField;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
		StoreItem storeItem;
		if ((nint)0 != 0)
		{
			storeItem = Store.GetStoreItem(gameReplay.<RoomThemeId>k__BackingField);
			bool flag = storeItem == null;
			object obj3 = !flag;
			object obj4 = 0;
			if (obj3 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			storeItem = Store.GetStoreItem(gameReplay.<RoomThemeId>k__BackingField);
			bool flag2 = storeItem == null;
			object obj4 = 0;
			if (flag2)
			{
				return;
			}
		}
		object obj5 = (??)storeItem.<Color>k__BackingField & 1;
		if (obj5 != null)
		{
			object obj6 = typeof(RegisteredWaitHandle) + 1792;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			RuntimeThemeColorProfile runtimeThemeColorProfile = default(RuntimeThemeColorProfile);
			runtimeThemeColorProfile..ctor();
			object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ThemeColorPalette themeColorPalette = default(ThemeColorPalette);
			themeColorPalette..ctor();
			Color? color = default(Color?);
			Color value = color.Value;
			themeColorPalette.PrimaryColor = (Color)storeItem.<Color>k__BackingField;
			object obj8 = runtimeThemeColorProfile + 16;
			obj8 = themeColorPalette;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = gameReplayCardData + 24;
			obj9 = runtimeThemeColorProfile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
