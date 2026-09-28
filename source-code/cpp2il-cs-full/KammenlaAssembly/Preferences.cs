using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DataTracking;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public static class Preferences
{
	private enum Option
	{
		SFXSound,
		ChatSound,
		GameSound,
		BackgroundMusic,
		SoundActor,
		CardDimming,
		ConfirmSawa,
		ForceTablet,
		BiddingPredetermination,
		EnablePowerSaving,
		AllowDifferentCardElevation,
		AllowMyTurnHandAnimation,
		AllowVibration,
		ShowJackarooTips,
		IsPerspectiveTopDown,
		CurrentGame,
		MultipleVoiceActors,
		IgnoreWatchersChat,
		UsedReplayTrails,
		JackarooCustomRulesIndex
	}

	public enum GameSoundState
	{
		AllOn,
		BackgroundMusicOff,
		AllOff
	}

	private const bool sFXSound = true;

	private const bool chatSound = true;

	private const bool gameSound = true;

	private const bool bgMusic = true;

	private const bool cardShade = true;

	private const bool confirmSawa = true;

	private const bool forceTablet = true;

	private const bool biddingPredetermination = true;

	private const bool enablePowerSaving = false;

	private const bool allowDifferentCardElevation = false;

	private const bool allowMyTurnHandAnimation = false;

	private const bool allowVibration = true;

	private const bool showJackarooTips = true;

	private const bool isPerspectiveTopDown = false;

	private const bool multipleVoiceActors = true;

	private const bool ignoreWatchersChat = true;

	public const int MaxReplayFreeTrials = 2;

	public static Games ThreadSafeCurrentGame;

	public static bool HasPreferredGame
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Complete" + 3480;
			return Prefs.HasKey((string)key);
		}
	}

	public static Games CurrentGame
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object obj = "Complete" + 3480;
			object obj2 = (nint)0 + (nint)2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
			Games result = default(Games);
			return result;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00fe: Expected O, but got I4
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Expected O, but got Unknown
			//IL_018a: Expected O, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			//IL_01ae: Expected O, but got I
			//IL_01b6: Expected O, but got I4
			//IL_01c2: Expected O, but got I
			//IL_00af: Expected O, but got I4
			//IL_015d: Expected O, but got I
			//IL_016e: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = "Complete" + 3480;
			object obj5 = (nint)0 + (nint)2528;
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+B8]");
			object obj7 = 0;
			obj7 = value;
			object obj8 = (nint)0 + (nint)2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81564");
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+E4]");
			object obj10 = default(object);
			if ((nint)0 != 0)
			{
				Tracker.SetActiveGame();
				if ((nint)value == (nint)obj10)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.SetActiveGame();
				if ((nint)value == (nint)obj10)
				{
					return;
				}
			}
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v11+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v9+8]");
			Actions.SafeInvoke((Action)0);
		}
	}

	public static bool SFXSound
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "SERVICE_DISABLED" + 120;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "SERVICE_DISABLED" + 120;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool ChatSound
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Cannot populate JSON object onto type '{0}'." + 2344;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Cannot populate JSON object onto type '{0}'." + 2344;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool GameSound
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2312;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0086: Expected O, but got I4
			//IL_0043: Expected F4, but got I4
			//IL_00d0: Expected O, but got I4
			//IL_00ee: Expected O, but got I
			//IL_00ff: Expected O, but got I
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2312;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Prefs.SetBool((string)key, value);
			bool flag = !value;
			object obj2 = !flag;
			object obj3 = ~obj2;
			float volume = ((obj3 != null) ? 0f : 1f);
			AudioListener.volume = volume;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+10]");
			Actions.SafeInvoke((Action)0);
		}
	}

	public static bool BackgroundMusic
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "AvailableVoices" + 816;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "AvailableVoices" + 816;
			Prefs.SetBool((string)key, value);
		}
	}

	public static GameSoundState SoundState
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01af: Expected O, but got I
			//IL_01d1: Expected O, but got I4
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_00a2: Expected O, but got I
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected O, but got Unknown
			//IL_020e: Expected O, but got I
			//IL_0228: Expected O, but got I4
			//IL_0271: Expected O, but got I4
			//IL_027a: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected O, but got Unknown
			//IL_02c6: Expected O, but got I
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_0156: Expected O, but got I
			//IL_0170: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7378]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7376]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			object key = obj6;
			if (obj8 != null)
			{
				goto IL_00c7;
			}
			goto IL_023e;
			IL_02f0:
			object key2;
			bool flag3 = Prefs.GetBool((string)key2, defaultValue: true);
			return (GameSoundState)((flag3 ? 1 : 0) ^ 1);
			IL_0186:
			_ = 1;
			object obj9;
			key2 = obj9;
			goto IL_02f0;
			IL_0104:
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				obj9 = "AvailableVoices" + 816;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7377]");
				object obj11 = (nint)0 & (nint)1;
				bool flag4 = obj11 == null;
				object obj12 = !flag4;
				key2 = obj9;
				if (obj12 == null)
				{
					goto IL_0186;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = "AvailableVoices" + 816;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7377]");
				object obj13 = (nint)0 & (nint)1;
				if (obj13 == null)
				{
					goto IL_0186;
				}
				key2 = obj9;
			}
			goto IL_02f0;
			IL_007d:
			obj6 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7376]");
			object obj14 = (nint)0 & (nint)1;
			bool flag5 = obj14 == null;
			key = obj6;
			if (!flag5)
			{
				goto IL_00c7;
			}
			goto IL_023e;
			IL_023e:
			_ = 1;
			bool flag6 = Prefs.GetBool((string)key, defaultValue: true);
			bool flag7 = !flag6;
			object obj15 = !flag7;
			object obj16 = 0;
			bool flag8 = true;
			if (obj15 != null)
			{
				goto IL_0104;
			}
			goto IL_0291;
			IL_00c7:
			bool flag9 = Prefs.GetBool((string)obj6, defaultValue: true);
			bool flag10 = !flag9;
			obj16 = 0;
			flag8 = true;
			if (!flag10)
			{
				goto IL_0104;
			}
			goto IL_0291;
			IL_0291:
			return GameSoundState.AllOff;
		}
	}

	public static string SoundActor
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			object key = "SetRoomVariables request error" + 1632;
			if (PlayerPrefsGame.HasKey((string)key))
			{
				return PlayerPrefsGame.GetString((string)key, null);
			}
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				return GetAndAssignDefaultActor();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return GetAndAssignDefaultActor();
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "SetRoomVariables request error" + 1632;
			PlayerPrefsGame.SetString((string)key, value);
		}
	}

	public static bool CardDimming
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Cannot populate JSON object onto type '{0}'." + 1696;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Cannot populate JSON object onto type '{0}'." + 1696;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool ConfirmSawa
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Complete" + 296;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Complete" + 296;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool BiddingPredetermination
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "AvailableVoices" + 1552;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "AvailableVoices" + 1552;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool EnablePowerSaving
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Drop Menu Toggle" + 2536;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Drop Menu Toggle" + 2536;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool AllowDifferentCardElevation
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Added Tournament Prizes And Features" + 488;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Added Tournament Prizes And Features" + 488;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool AllowMyTurnHandAnimation
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Added Tournament Prizes And Features" + 504;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Added Tournament Prizes And Features" + 504;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool AllowVibration
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Added Tournament Prizes And Features" + 512;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Added Tournament Prizes And Features" + 512;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool ShowJackarooTips
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "SetRoomVariables request error" + 584;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "SetRoomVariables request error" + 584;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool IsPerspectiveTopDown
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 1840;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 1840;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool ForceTablet
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 784;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 784;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool MultipleVoiceActors
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Material with texture name \"" + 2936;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Material with texture name \"" + 2936;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool IgnoreWatchersChat
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "HH:mm:ss.ffZ" + 3496;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "HH:mm:ss.ffZ" + 3496;
			Prefs.SetBool((string)key, value);
		}
	}

	public static int JackarooPreferredCustomRulesIndex
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3040;
			return Prefs.GetInt((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3040;
			Prefs.SetInt((string)key, value);
		}
	}

	public static int UsedReplayTrails
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Unsupported map type" + 584;
			return Prefs.GetInt((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Unsupported map type" + 584;
			Prefs.SetInt((string)key, value);
		}
	}

	public static event Action OnGameChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnSoundChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	static Preferences()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_005b: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = "Complete" + 3480;
		object obj3 = (nint)0 + (nint)2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+B8]");
		object obj5 = 0;
		object obj6 = default(object);
		obj5 = obj6;
	}

	private static string GetAndAssignDefaultActor()
	{
		//IL_000c: Expected O, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0120: Expected O, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_00c8: Expected O, but got I4
		object obj = (nint)0 + (nint)2040;
		string resourcesPath = SoundActors.ResourcesPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF8ABC");
		SoundActors soundActors = default(SoundActors);
		SoundActor random;
		string name;
		object obj4;
		object key;
		if ((object)soundActors != null)
		{
			random = soundActors.GetRandom();
			if ((object)random != null)
			{
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				name = random.name;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					obj4 = "SetRoomVariables request error" + 1632;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7379]");
					object obj5 = (nint)0 & (nint)1;
					bool flag = obj5 == null;
					object obj6 = !flag;
					key = obj4;
					if (obj6 == null)
					{
						goto IL_00de;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = "SetRoomVariables request error" + 1632;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7379]");
					object obj7 = (nint)0 & (nint)1;
					if (obj7 == null)
					{
						goto IL_00de;
					}
					key = obj4;
				}
				goto IL_0188;
			}
		}
		return (string)(object)new NullReferenceException();
		IL_00de:
		_ = 1;
		key = obj4;
		goto IL_0188;
		IL_0188:
		PlayerPrefsGame.SetString((string)key, name);
		return random.name;
	}
}
