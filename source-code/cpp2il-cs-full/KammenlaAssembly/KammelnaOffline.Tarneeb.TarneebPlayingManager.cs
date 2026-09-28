using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Common;
using UnityEngine.AdaptivePerformance;

namespace KammelnaOffline.Tarneeb;

public class TarneebPlayingManager : PlayingManager
{
	private readonly TarneebGameController _gameController;

	public TarneebPlayingManager(TarneebGameController gameController)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void StartPlaying()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public override void OnPlay()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public override void CopyCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public override void ClearPlayersVariables()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_00cb: Expected O, but got I
		TarneebGameController gameController = _gameController;
		OfflinePlayer[] players = gameController.Players;
		if (players.Length >= 1)
		{
			object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
			object obj2 = players + 32;
			object obj3 = 0;
			List<object> list = default(List<object>);
			List<object> list2 = default(List<object>);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list..ctor();
				obj3++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X25_v4+v66 @ X22_v5*8]");
				object obj4 = (nint)0 + (nint)40;
				obj4 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list2..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X25_v4+v66 @ X22_v5*8]");
				object obj5 = (nint)0 + (nint)32;
				obj5 = list2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			while ((nint)obj3 < players.Length);
		}
	}
}
