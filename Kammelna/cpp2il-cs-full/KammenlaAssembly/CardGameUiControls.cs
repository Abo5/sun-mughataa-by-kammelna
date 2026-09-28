using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

public class CardGameUiControls : KGameUiControls
{
	private new CardGame game
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			CardGame cardGame = (CardGame)base.game;
			if ((object)base.game != null)
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
			return (CardGame)base.game;
		}
	}
}
