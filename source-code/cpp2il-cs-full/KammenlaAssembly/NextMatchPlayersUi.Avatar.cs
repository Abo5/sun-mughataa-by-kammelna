using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.UI;

public class NextMatchPlayersUi : MonoBehaviour
{
	[Serializable]
	private class Avatar
	{
		public Image avatar;

		public Image border;
	}

	private Sprite WaitingSprite;

	private Sprite StopSprite;

	private Sprite ReadySprite;

	private Avatar[] players;

	private CardGame _game;

	private bool isInitialized;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00bb: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4024;
		object obj4 = (nint)0 + (nint)3056;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)3048;
		((KGame)obj7).OnVotingGameLobbyUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj10);
		_game.OnGameInitialized += action2;
	}

	private void OnGameInitialized()
	{
		isInitialized = true;
		RefreshUI();
	}

	private void OnEnable()
	{
		RefreshUI();
	}

	private void RefreshUI()
	{
		//IL_001d: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected I4, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_0113: Expected O, but got I
		//IL_022e: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_0153: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_025a: Expected O, but got I
		//IL_0278: Expected O, but got I4
		//IL_0183: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_01b6: Expected O, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		if (!isInitialized)
		{
			return;
		}
		KGame game = _game;
		object obj = 0;
		while (true)
		{
			List<KPlayer> list = game.Players;
			if ((nint)obj >= list._size)
			{
				return;
			}
			int num = obj + 1;
			int rotatedPlayerIndex = _game.GetRotatedPlayerIndex(num);
			KPlayer playerByIndex = _game.GetPlayerByIndex(rotatedPlayerIndex);
			Avatar[] array = players;
			object obj2 = num - 1;
			bool flag = (nint)obj2 < array.Length;
			object obj3 = !flag;
			if (obj3 != null)
			{
				break;
			}
			object obj4 = (object)array + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v9+20]");
			object obj5 = 0;
			if (playerByIndex.IsHuman)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X23_v6+10]");
				UIExtensions.AssignAvatarImage((Image)0, playerByIndex.<User>k__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X23_v6+10]");
				UIExtensions.SetAlpha((Graphic)0, 1f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X23_v6+18]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X23_v6+18]");
				((Image)0).sprite = WaitingSprite;
				game = _game;
				obj = obj2 + 1;
				continue;
			}
			Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X23_v6+10]");
			((Image)0).sprite = avatarPlaceholder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X23_v6+10]");
			UIExtensions.SetAlpha((Graphic)0, 0.3f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X23_v6+18]");
			GameObject gameObject2 = ((Component)0).gameObject;
			bool flag2 = (object)gameObject2 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				gameObject2.SetActive(value: false);
				game = _game;
				obj = obj2 + 1;
				bool flag3 = (object)_game == null;
				object obj7 = !flag3;
				if (obj7 != null)
				{
					continue;
				}
			}
			throw new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private void VotingGameLobbyUpdated(VotingGameLobby votingGameLobby)
	{
		//IL_002c: Expected O, but got I4
		//IL_0058: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected I4, but got Unknown
		//IL_0144: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0178: Expected O, but got I4
		Avatar[] array = players;
		if (players != null)
		{
			if (votingGameLobby == null)
			{
				goto IL_019e;
			}
			object obj = 0;
			Avatar[] array2 = players;
			object obj3;
			do
			{
				if ((nint)obj < array2.Length)
				{
					object obj2 = (object)array2 + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v9+20]");
					array = (Avatar[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v9+20]");
					if ((nint)0 == 0 || (object)_game == null)
					{
						break;
					}
					int playerIndex = obj + 1;
					int rotatedPlayerIndex = _game.GetRotatedPlayerIndex(playerIndex);
					if (votingGameLobby.PlayerDecisions == null)
					{
						break;
					}
					int index = rotatedPlayerIndex - 1;
					System.Int32Enum state = ((List<System.Int32Enum>)(object)votingGameLobby.PlayerDecisions).get_Item(index);
					Sprite stateSprite = GetStateSprite((PlayerDecision)state);
					if (array.Length == 0)
					{
						break;
					}
					((Image)array.Length).sprite = stateSprite;
					array = players;
					obj++;
					bool flag = players == null;
					obj3 = !flag;
					array2 = players;
					continue;
				}
				return;
			}
			while (obj3 != null);
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_019e;
		IL_019e:
		if (array.Length < 1)
		{
			return;
		}
		throw new NullReferenceException();
	}

	private Sprite GetStateSprite(PlayerDecision state)
	{
		//IL_001a: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0036: Expected O, but got I4
		//IL_004d: Expected O, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		bool flag = state < (PlayerDecision)3;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = (int)state << 3;
			object obj3 = (object)this + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X8_v2+20]");
			return (Sprite)0;
		}
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = "startPosition" + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj7 = "Picking audio files is not supported on iOS" + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		string message = default(string);
		ex..ctor(paramName, actualValue, message);
		object obj8 = (nint)0 + (nint)3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Sprite)(object)new OutOfMemoryException();
	}
}
