using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class CardGameSoundControls : KGameSoundControls
{
	protected int MyTeamIndex
	{
		get
		{
			//IL_01ac: Expected I4, but got O
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			//IL_007a: Expected I, but got O
			//IL_00a3: Expected O, but got I4
			//IL_00d7: Expected O, but got I
			//IL_0111: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_0153: Expected O, but got I4
			//IL_017d: Expected O, but got I4
			if ((object)game != null)
			{
				if (game.IsSpectator)
				{
					return 1;
				}
				KGame kGame = game;
				if ((object)game != null)
				{
					object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
					object obj2 = obj;
					nint num = (nint)kGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v7 (Il2CppClass<KGame>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X1_v4+130]");
					bool flag = num2 < 0;
					object obj3 = !flag;
					object obj4 = ~obj3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v7 (Il2CppClass<KGame>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X1_v4+130]");
						object obj5 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v9-8]");
						if (0 == (nint)obj2)
						{
							object obj6 = kGame.<MySeatIndex>k__BackingField - 1;
							bool flag2 = (nint)obj6 < 3;
							object obj7 = !flag2;
							object obj8 = obj6 - 3;
							bool flag3 = obj8 == null;
							object obj9 = !flag3;
							object obj10 = obj7 & obj9;
							if (obj10 == null)
							{
								object obj11 = 118730752 + 3184;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X9_v4+v126 @ X8_v12*4]");
								return 0;
							}
							return 0;
						}
					}
					goto IL_019e;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_019e;
			IL_019e:
			InvalidCastException ex2 = new InvalidCastException();
			return (int)ex2;
		}
	}

	protected CardGame cardGame
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			CardGame cardGame = (CardGame)game;
			if ((object)game != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
				object obj2 = obj;
				nint num = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (CardGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (CardGame)game;
		}
	}

	protected override void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_013f: Expected I, but got O
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f8: Expected I, but got O
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0051: Expected I, but got O
		//IL_007a: Expected O, but got I4
		//IL_00ae: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		base.Init();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<CardGameSoundControls>)+190]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		game.OnRoundEnd += action;
		KGame kGame = game;
		bool flag = (object)game == null;
		Action action2 = action;
		if (!flag)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			action2 = (Action)obj2;
			nint num2 = (nint)kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v14 (Il2CppClass<KGame>)+130]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v6 (System.Action)+130]");
			bool flag2 = num3 < 0;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v14 (Il2CppClass<KGame>)+C8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v6 (System.Action)+130]");
				object obj5 = num4 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v16-8]");
				if (0 == (nint)action2)
				{
					goto IL_00d5;
				}
			}
			throw new InvalidCastException();
		}
		goto IL_00d5;
		IL_00d5:
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num5 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v11 (Il2CppClass<CardGameSoundControls>)+1A0]");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)0);
		game.OnGameEnd += action3;
	}

	protected virtual void OnRoundEnd()
	{
	}

	protected virtual void OnGameEnd(ISFSObject data)
	{
	}
}
