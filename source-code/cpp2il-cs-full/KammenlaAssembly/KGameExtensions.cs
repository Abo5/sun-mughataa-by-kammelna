using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.WebRequests;
using Sfs2X.Entities;
using UnityEngine.TextCore;

public static class KGameExtensions
{
	public static IClientContext GetClientContext(KGame game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_01ab: Expected I, but got O
		//IL_01bb: Expected O, but got I
		//IL_01db: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_01ff: Expected O, but got I4
		//IL_0103: Expected I8, but got O
		//IL_0122: Expected I, but got O
		//IL_0132: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		//IL_03ea: Expected I, but got O
		//IL_03fa: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_02e1: Expected O, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClientContext clientContext = default(ClientContext);
		clientContext..ctor();
		TournamentData tournamentInfo;
		object obj2;
		object obj4;
		object obj5;
		long? num3;
		object obj7;
		nint num4;
		long? num5;
		object obj9;
		System.Int32Enum? <GameType>k__BackingField;
		if ((object)game != null)
		{
			Room room = game.Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			<GameType>k__BackingField = (System.Int32Enum)gameType;
			if (clientContext != null)
			{
				clientContext.<GameType>k__BackingField = (GameType?)<GameType>k__BackingField;
				Room room2 = game.Room;
				tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(room2);
				if (tournamentInfo != null)
				{
					obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
					object obj3 = (??)tournamentInfo.<TournamentId>k__BackingField & 1;
					if (obj3 != null)
					{
						long value = (object?)tournamentInfo.<TournamentId>k__BackingField >> 32;
						long? num = value;
						obj4 = obj2;
						nint num2 = (nint)clientContext;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v18 (Il2CppClass<Kammelna.Server.WebRequests.ClientContext>)+12E]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v18 (Il2CppClass<Kammelna.Server.WebRequests.ClientContext>)+12E]");
						bool flag = (nint)0 == 0;
						object obj6 = !flag;
						num3 = num;
						obj7 = 0;
						num4 = num2;
						if (obj6 != null)
						{
							goto IL_020d;
						}
						num5 = num;
						object obj8 = obj2;
						obj9 = 0;
					}
					else
					{
						obj4 = obj2;
						num4 = (nint)clientContext;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13 (Il2CppClass<Kammelna.Server.WebRequests.ClientContext>)+12E]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13 (Il2CppClass<Kammelna.Server.WebRequests.ClientContext>)+12E]");
						bool flag2 = (nint)0 == 0;
						num3 = (long?)(object)0;
						obj7 = 0;
						num5 = (long?)(object)0;
						object obj8 = obj2;
						obj9 = 0;
						if (!flag2)
						{
							goto IL_020d;
						}
					}
					goto IL_027d;
				}
				goto IL_039d;
			}
		}
		return (IClientContext)new NullReferenceException();
		IL_0322:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0443;
		IL_020d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13 (Il2CppClass<Kammelna.Server.WebRequests.ClientContext>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X10_v12-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj10 += 16;
			obj5--;
			bool flag3 = (nint)obj5 != 1;
			num5 = num3;
			object obj8 = obj4;
			obj9 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_027d;
		}
		object obj11 = obj10 + 5;
		object obj12 = num4 + obj11;
		object obj13 = obj12 + 312;
		num5 = num3;
		obj9 = obj7;
		goto IL_03c6;
		IL_039d:
		return clientContext;
		IL_0443:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_039d;
		IL_027d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03c6;
		IL_03c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v318 @ X0_v15] (should have been resolved before IL gen)");
		<GameType>k__BackingField = (System.Int32Enum)tournamentInfo.<Type>k__BackingField;
		nint num6 = (nint)clientContext;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v8 (Il2CppClass<Kammelna.Server.WebRequests.ClientContext>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v8 (Il2CppClass<Kammelna.Server.WebRequests.ClientContext>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0322;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v8 (Il2CppClass<Kammelna.Server.WebRequests.ClientContext>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X10_v7-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0322;
		}
		object obj16 = obj15 + 7;
		object obj17 = num6 + obj16;
		object obj18 = obj17 + 312;
		goto IL_0443;
	}
}
