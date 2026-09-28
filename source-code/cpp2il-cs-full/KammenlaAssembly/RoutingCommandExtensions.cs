using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;

public static class RoutingCommandExtensions
{
	public static Scenes GetScene(RoutingCommand command)
	{
		//IL_0013: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_04dc: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0276: Expected O, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_03e6: Expected O, but got I4
		//IL_0088: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_0878: Expected O, but got I
		//IL_0892: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_02c5: Expected O, but got I4
		//IL_0395: Expected O, but got I4
		//IL_07e9: Expected O, but got I
		//IL_0738: Expected O, but got I8
		//IL_041a: Expected O, but got I4
		//IL_0434: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0908: Expected O, but got I
		//IL_08d0: Expected O, but got I4
		//IL_0231: Expected O, but got I4
		//IL_059e: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_02f0: Expected O, but got I4
		//IL_084b: Expected O, but got I
		//IL_06ef: Expected O, but got I4
		//IL_0709: Expected O, but got I4
		//IL_0559: Expected O, but got I4
		//IL_0573: Expected O, but got I4
		//IL_076c: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_060d: Expected O, but got I4
		//IL_0923: Expected I4, but got O
		//IL_066f: Expected O, but got I4
		//IL_06a9: Expected O, but got I4
		Scenes result;
		if (command > RoutingCommand.Game)
		{
			object obj = (int)command >> 1;
			bool flag = (nint)obj < 4052;
			object obj2 = !flag;
			object obj3 = obj - 4052;
			bool flag2 = obj3 == null;
			object obj4 = ~obj2;
			object obj5 = obj4 | flag2;
			if (obj5 == null)
			{
				bool flag3 = command < RoutingCommand.TournamentChat;
				object obj6 = !flag3;
				object obj7 = command - 12005;
				bool flag4 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag4;
				if (obj9 == null)
				{
					bool flag5 = command < RoutingCommand.MassTournamentWithCode;
					object obj10 = !flag5;
					object obj11 = command - 13001;
					bool flag6 = obj11 == null;
					object obj12 = ~obj10;
					object obj13 = obj12 | flag6;
					if (obj13 == null)
					{
						object obj14 = command & (RoutingCommand)2147483644;
						if ((nint)obj14 == 14000)
						{
							result = Scenes.Menu;
							goto IL_0943;
						}
					}
					else
					{
						if (command == RoutingCommand.JoinTournaemntSpawner)
						{
							return Scenes.TournamentView;
						}
						object obj15 = command & (RoutingCommand)16382;
						if ((nint)obj15 == 13000)
						{
							return Scenes.MassTournament;
						}
					}
				}
				else
				{
					object obj16 = command & (RoutingCommand)16380;
					if ((nint)obj16 == 9000)
					{
						return Scenes.PredictAndWin;
					}
					if ((nint)obj16 == 11000)
					{
						return Scenes.Tutorial;
					}
					object obj17 = (int)command >> 5;
					bool flag7 = (nint)obj17 < 375;
					object obj18 = !flag7;
					object obj19 = ~obj18;
					if (obj19 == null)
					{
						return Scenes.TournamentView;
					}
				}
			}
			else
			{
				bool flag8 = (nint)obj < 3502;
				object obj20 = !flag8;
				object obj21 = obj - 3502;
				bool flag9 = obj21 == null;
				object obj22 = ~obj20;
				object obj23 = obj22 | flag9;
				if (obj23 == null)
				{
					object obj24 = command & (RoutingCommand)8190;
					if ((nint)obj24 != 7006)
					{
						object obj25 = command & (RoutingCommand)8184;
						if ((nint)obj25 == 8000)
						{
							return Scenes.Settings;
						}
						object obj26 = (int)command >> 2;
						bool flag10 = (nint)obj26 < 2025;
						object obj27 = !flag10;
						object obj28 = ~obj27;
						if (obj28 == null)
						{
							return Scenes.Menu;
						}
					}
				}
				else
				{
					if (command == RoutingCommand.FastTrackMenu)
					{
						return Scenes.FastTrackMenu;
					}
					if (command == RoutingCommand.MiniGame)
					{
						return Scenes.MiniGame;
					}
					object obj29 = (int)command >> 3;
					bool flag11 = (nint)obj29 < 875;
					object obj30 = !flag11;
					object obj31 = ~obj30;
					if (obj31 == null)
					{
						object obj32 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
						object obj33 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v25+E4]");
						bool flag12 = (nint)0 == 0;
						object obj34 = !flag12;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SFSConfig currentSFS = Config.CurrentSFS;
						if (currentSFS != null)
						{
							bool flag13 = !currentSFS.<IsFastTrack>k__BackingField;
							object obj35 = !flag13;
							result = Scenes.Menu;
							if (obj35 == null)
							{
								bool isTablet = ScreenUtility.IsTablet;
								bool flag14 = !isTablet;
								object obj36 = !flag14;
								object obj37 = ~obj36;
								if (obj37 == null)
								{
									return Scenes.Store;
								}
								return Scenes.Menu;
							}
							goto IL_0943;
						}
						NullReferenceException ex = new NullReferenceException();
						return (Scenes)ex;
					}
				}
			}
			goto IL_0792;
		}
		if (command > RoutingCommand.OpenUpdateAppLink)
		{
			bool flag15 = command < RoutingCommand.Chat;
			object obj38 = !flag15;
			object obj39 = command - 3500;
			bool flag16 = obj39 == null;
			object obj40 = ~obj38;
			object obj41 = obj40 | flag16;
			if (obj41 == null)
			{
				object obj42 = command - 3600;
				bool flag17 = (nint)obj42 < 9;
				object obj43 = !flag17;
				object obj44 = ~obj43;
				result = Scenes.Menu;
				if (obj44 == null)
				{
					object obj45 = command & (RoutingCommand)2147483646;
					bool flag18 = (nint)obj45 == 3700;
					result = Scenes.Menu;
					if (!flag18)
					{
						goto IL_0792;
					}
				}
			}
			else
			{
				object obj46 = command & (RoutingCommand)4092;
				bool flag19 = (nint)obj46 == 3400;
				result = Scenes.Menu;
				if (!flag19)
				{
					object obj47 = command - 3300;
					bool flag20 = (nint)obj47 < 5;
					object obj48 = !flag20;
					object obj49 = ~obj48;
					result = Scenes.Menu;
					if (obj49 == null)
					{
						bool flag21 = command == RoutingCommand.Chat;
						result = Scenes.Menu;
						if (!flag21)
						{
							goto IL_0792;
						}
					}
				}
			}
		}
		else
		{
			if (command <= RoutingCommand.Login_Error)
			{
				bool flag22 = command < (RoutingCommand)4;
				object obj50 = !flag22;
				object obj51 = ~obj50;
				if (obj51 == null)
				{
					if (command == RoutingCommand.FetchServer)
					{
						return Scenes.FetchServer;
					}
					object obj52 = (long)command & 0xFFFFFFFEL;
					if ((nint)obj52 == 2000)
					{
						return Scenes.Login;
					}
				}
				goto IL_0792;
			}
			bool flag23 = command == RoutingCommand.Menu;
			result = Scenes.Menu;
			if (!flag23)
			{
				bool flag24 = command == RoutingCommand.HomeTab;
				result = Scenes.Menu;
				if (!flag24)
				{
					goto IL_0792;
				}
			}
		}
		goto IL_0943;
		IL_083b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v15+B8]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v13+18]");
		return (Scenes)0;
		IL_08e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj55;
		object obj54 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v7+B8]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v7+18]");
		return (Scenes)0;
		IL_0792:
		obj55 = typeof(RegisteredWaitHandle) + 3136;
		object obj57 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj58 = (nint)0 & (nint)1;
			if (obj58 != null)
			{
				goto IL_0806;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj59 = (nint)0 & (nint)1;
			bool flag25 = obj59 == null;
			object obj60 = !flag25;
			if (obj60 != null)
			{
				goto IL_0806;
			}
		}
		_ = 1;
		object obj61 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v15+E4]");
		bool flag26 = (nint)0 == 0;
		object obj62 = !flag26;
		object obj63 = obj61;
		if (obj62 != null)
		{
			goto IL_083b;
		}
		goto IL_08e6;
		IL_0943:
		return result;
		IL_0806:
		obj61 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v15+E4]");
		bool flag27 = (nint)0 == 0;
		obj63 = obj61;
		if (!flag27)
		{
			goto IL_083b;
		}
		goto IL_08e6;
	}
}
