using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class LobbyFakeServer : MonoBehaviour
{
	public delegate void ServerUpdateDel(List<LobbyPlayerData> playerData);

	public delegate void VoidDelegate();

	private List<LobbyPlayerData> players;

	private ServerUpdateDel m_LobbyUpdated;

	private VoidDelegate m_GameStarted;

	public event ServerUpdateDel LobbyUpdated
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2160;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2160;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event VoidDelegate GameStarted
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2168;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2168;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public void UpdateServer()
	{
		ServerUpdateDel lobbyUpdated = this.LobbyUpdated;
		if (this.LobbyUpdated != null)
		{
			List<LobbyPlayerData> list = players;
			IntPtr invoke_impl = ((Delegate)lobbyUpdated).invoke_impl;
			IntPtr method_code = ((Delegate)lobbyUpdated).method_code;
			IntPtr method = ((Delegate)lobbyUpdated).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void JoinPlayer()
	{
	}

	public void SetPlayerTeam(int playerID, int team)
	{
		//IL_018c: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_012d: Expected I4, but got O
		//IL_003b: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_00df: Expected I4, but got O
		bool flag = players == null;
		object obj = 152993792;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		int num = default(int);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)3088;
			obj = (nint)0 + (nint)3080;
			List<object>.Enumerator enumerator = ((List<object>)(object)players).GetEnumerator();
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				goto IL_008c;
			}
			object obj3 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj4 = 0;
			num = (int)obj2;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (int)obj;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				goto IL_008c;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EE78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_008c:
		ServerUpdateDel lobbyUpdated = this.LobbyUpdated;
		if (this.LobbyUpdated != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void KickPlayer(int playerID)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0117: Expected I4, but got O
		//IL_0187: Expected I4, but got O
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		NullReferenceException ex;
		int num = default(int);
		if (players != null)
		{
			object obj = (nint)0 + (nint)3088;
			obj2 = (nint)0 + (nint)3080;
			List<object>.Enumerator enumerator = ((List<object>)(object)players).GetEnumerator();
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				goto IL_00c5;
			}
			object obj3 = null;
			ex = new NullReferenceException();
			object obj4 = 0;
			num = (int)obj;
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			ex = new NullReferenceException();
		}
		bool flag = num != 1;
		NullReferenceException ex3 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (int)obj2;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				goto IL_00c5;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EE78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00c5:
		ServerUpdateDel lobbyUpdated = this.LobbyUpdated;
		if (this.LobbyUpdated != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v228.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void StartGame()
	{
		VoidDelegate gameStarted = this.GameStarted;
		if (this.GameStarted != null)
		{
			IntPtr invoke_impl = ((Delegate)gameStarted).invoke_impl;
			IntPtr method_code = ((Delegate)gameStarted).method_code;
			IntPtr method = ((Delegate)gameStarted).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
