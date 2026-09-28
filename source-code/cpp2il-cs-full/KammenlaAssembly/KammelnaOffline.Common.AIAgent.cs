using System;
using System.Threading;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

namespace KammelnaOffline.Common;

public class AIAgent
{
	private readonly OfflinePlayer _player;

	private readonly AbstractAiLogic _logic;

	public int PlayerIndex
	{
		get
		{
			//IL_0041: Expected I4, but got O
			OfflinePlayer player = _player;
			if (_player != null)
			{
				return player.PlayerIndex;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public AIAgent(OfflinePlayer player, AbstractAiLogic logic)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = logic;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public string Bid(int biddingState)
	{
		//IL_005a: Expected I, but got O
		OfflinePlayer player = _player;
		if (_player != null)
		{
			AbstractAiLogic logic = _logic;
			if (_logic != null)
			{
				nint num = (nint)logic;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v31 @ X8_v2 (Il2CppClass<KammelnaOffline.Common.AbstractAiLogic>)+188] (should have been resolved before IL gen)");
			}
		}
		return (string)(object)new NullReferenceException();
	}

	public (string, ISFSObject) GetPlayerAction()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I4
		//IL_0207: Expected O, but got I
		//IL_0217: Expected O, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		OfflinePlayer player = _player;
		object obj2;
		object item;
		if (_player != null)
		{
			object key = "placementId" + 112;
			SFSExtensions.Put(sFSObject, (string)key, player.PlayerIndex);
			OfflinePlayer player2 = _player;
			if (_player != null && _logic != null)
			{
				obj2 = "___# Content push apply failed [{0}]: {1}" + 2712;
				string action = _logic.GetAction(player2.PlayerIndex);
				bool flag = action == (string)obj2;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_01db;
				}
				obj2 = "___# Content push apply failed [{0}]: {1}" + 2664;
				if (action == (string)obj2)
				{
					OfflinePlayer player3 = _player;
					if (_player == null || _logic == null)
					{
						goto IL_0224;
					}
					Card card = _logic.PlayCard(player3.<Cards>k__BackingField, player3.PlayerIndex);
					if (card != null)
					{
						string val = card.ToString();
						object key2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2400;
						SFSExtensions.Put(sFSObject, (string)key2, val);
						goto IL_01db;
					}
				}
				object obj4 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v13+90]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v14+B8]");
				object obj6 = 0;
				item = obj6;
				goto IL_026e;
			}
		}
		goto IL_0224;
		IL_0224:
		return ((string, ISFSObject))new NullReferenceException();
		IL_01db:
		item = obj2;
		goto IL_026e;
		IL_026e:
		return ((string)item, sFSObject);
	}
}
