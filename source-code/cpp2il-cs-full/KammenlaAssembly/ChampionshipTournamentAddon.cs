using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Server.Models;
using Spine;

public class ChampionshipTournamentAddon : TournamentAddonModel, ICardbackAddon, IRoomThemeAddon
{
	private string <trophyName>k__BackingField;

	private int <levelId>k__BackingField;

	public override int Priority => 10;

	public override TournamentAddonType Type => TournamentAddonType.Championship;

	public override string SerializedData => <trophyName>k__BackingField;

	public int CardbackId
	{
		get
		{
			//IL_0020: Expected I4, but got O
			TournamentAddonConfig.ChampionshipConfig championshipConfig = config;
			if (championshipConfig != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v2 (TournamentAddonConfig+ChampionshipConfig)+18]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int RoomThemeId
	{
		get
		{
			//IL_0020: Expected I4, but got O
			TournamentAddonConfig.ChampionshipConfig championshipConfig = config;
			if (championshipConfig != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v2 (TournamentAddonConfig+ChampionshipConfig)+20]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public string trophyName
	{
		get
		{
			return <trophyName>k__BackingField;
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

	public int levelId
	{
		get
		{
			return <levelId>k__BackingField;
		}
		set
		{
			<levelId>k__BackingField = value;
		}
	}

	private TournamentAddonConfig.ChampionshipConfig config
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01b3: Expected I, but got O
			//IL_01dc: Expected O, but got I4
			//IL_0211: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CA0]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_024f;
			IL_024f:
			return (TournamentAddonConfig.ChampionshipConfig)(object)new NullReferenceException();
			IL_011d:
			if (current.<Tournaments>k__BackingField != null)
			{
				Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> addons = current.<Tournaments>k__BackingField.Addons;
				object obj5 = DictionaryExtensions.Get((IDictionary<System.Int32Enum, object>)addons, (System.Int32Enum)5);
				bool flag2 = obj5 == null;
				TournamentAddonConfig.ChampionshipConfig result = (TournamentAddonConfig.ChampionshipConfig)obj5;
				if (!flag2)
				{
					object obj6 = typeof(SkeletonBinary.SkeletonInput) + 3408;
					object obj7 = obj6;
					nint num = (nint)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v2 (Il2CppClass<System.Object>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+130]");
					bool flag3 = num2 < 0;
					object obj8 = !flag3;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v2 (Il2CppClass<System.Object>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+130]");
						object obj9 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v4-8]");
						if (0 == (nint)obj7)
						{
							return (TournamentAddonConfig.ChampionshipConfig)obj5;
						}
						return null;
					}
					result = null;
				}
				return result;
			}
			goto IL_024f;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag4 = current == null;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_011d;
			}
			goto IL_024f;
		}
	}

	public ChampionshipTournamentAddon(string trophyName)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = trophyName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
