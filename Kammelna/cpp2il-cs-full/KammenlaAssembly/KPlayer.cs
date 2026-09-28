using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;

public abstract class KPlayer
{
	private int <Index>k__BackingField;

	private User <User>k__BackingField;

	private Action m_OnUserChanged;

	private Action m_OnDidLastAction;

	private KGame <Game>k__BackingField;

	private DateTime playerJoinTimeStamp;

	public int Index
	{
		get
		{
			return <Index>k__BackingField;
		}
		set
		{
			<Index>k__BackingField = value;
		}
	}

	public string DBId
	{
		get
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			if (<User>k__BackingField != null)
			{
				return SFSKammelnaUserExtensions.GetDbId(<User>k__BackingField);
			}
			return "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2448;
		}
	}

	public string NickName
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0057: Expected O, but got I4
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_00b0: Expected O, but got I
			if (<User>k__BackingField != null)
			{
				return SFSKammelnaUserExtensions.GetUserName(<User>k__BackingField);
			}
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2448;
			string text = LocalizationText.GetText((string)key);
			int num = default(int);
			string text2 = num.ToString();
			object obj4 = (nint)0 + (nint)3072;
			return text + (string)obj4 + text2;
		}
	}

	public bool IsHuman
	{
		get
		{
			bool flag = <User>k__BackingField == null;
			return !flag;
		}
	}

	public bool IsHumanSeated
	{
		get
		{
			//IL_00a3: Expected I4, but got O
			//IL_007b: Expected O, but got I4
			if (<User>k__BackingField != null)
			{
				KGame kGame = <Game>k__BackingField;
				if ((object)<Game>k__BackingField != null && kGame.<SeatStatuses>k__BackingField != null)
				{
					int index = <Index>k__BackingField - 1;
					System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)kGame.<SeatStatuses>k__BackingField).get_Item(index);
					object obj = int32Enum - 6;
					return obj == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public bool IsJoinable
	{
		get
		{
			//IL_0070: Expected I4, but got O
			KGame kGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null && kGame.<SeatStatuses>k__BackingField != null)
			{
				int index = <Index>k__BackingField - 1;
				System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)kGame.<SeatStatuses>k__BackingField).get_Item(index);
				return int32Enum == (System.Int32Enum)0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool IsMe
	{
		get
		{
			//IL_005f: Expected I4, but got O
			//IL_003d: Expected O, but got I4
			KGame kGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null)
			{
				object obj = kGame.<MySeatIndex>k__BackingField - <Index>k__BackingField;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool IsMover
	{
		get
		{
			//IL_005f: Expected I4, but got O
			//IL_003d: Expected O, but got I4
			KGame kGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null)
			{
				object obj = kGame.<Mover>k__BackingField - <Index>k__BackingField;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool IsRoomOwner
	{
		get
		{
			//IL_0098: Expected I4, but got O
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected O, but got Unknown
			if ((object)<Game>k__BackingField != null)
			{
				Room room = <Game>k__BackingField.Room;
				int originalOwnerId = SFSKammelnaRoomExtensions.GetOriginalOwnerId(room);
				int num = default(int);
				string text = num.ToString();
				string text2;
				if (<User>k__BackingField != null)
				{
					string dbId = SFSKammelnaUserExtensions.GetDbId(<User>k__BackingField);
					text2 = dbId;
				}
				else
				{
					object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2448;
					text2 = (string)obj;
				}
				return text == text2;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public TimeSpan TimeInGame
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0078: Expected O, but got I4
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			return now - playerJoinTimeStamp;
		}
	}

	public virtual bool CanPlay
	{
		get
		{
			//IL_005f: Expected I4, but got O
			//IL_003d: Expected O, but got I4
			KGame kGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null)
			{
				object obj = kGame.<Mover>k__BackingField - <Index>k__BackingField;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public SeatStatus SeatStatus
	{
		get
		{
			//IL_0061: Expected I4, but got O
			KGame kGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null && kGame.<SeatStatuses>k__BackingField != null)
			{
				int index = <Index>k__BackingField - 1;
				return (SeatStatus)((List<System.Int32Enum>)(object)kGame.<SeatStatuses>k__BackingField).get_Item(index);
			}
			NullReferenceException ex = new NullReferenceException();
			return (SeatStatus)ex;
		}
	}

	public int ForfeitingPenalty
	{
		get
		{
			//IL_0061: Expected I4, but got O
			KGame kGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null && kGame.<ForfeitingPenalties>k__BackingField != null)
			{
				int index = <Index>k__BackingField - 1;
				return kGame.<ForfeitingPenalties>k__BackingField.get_Item(index);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public bool IsPossibleForfeiter
	{
		get
		{
			//IL_006f: Expected I4, but got O
			KGame kGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null && kGame.<ForfeitingPenalties>k__BackingField != null)
			{
				int index = <Index>k__BackingField - 1;
				int num = kGame.<ForfeitingPenalties>k__BackingField.get_Item(index);
				return (byte)(num >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public User User
	{
		get
		{
			return <User>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public KGame Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public event Action OnUserChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
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
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
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

	public event Action OnDidLastAction
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
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
			object obj = typeof(SqlSingle[]) + 2376;
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

	public KPlayer(KGame game)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 48;
		obj = game;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void UpdateGameState(ISFSObject response)
	{
		//IL_003d: Expected I, but got O
		//IL_004d: Expected O, but got I
		//IL_005d: Expected O, but got I
		bool flag = UpdateUser();
		UpdatePlayerState(response);
		if (flag)
		{
			UserChanged();
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3 (Il2CppClass<KPlayer>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3 (Il2CppClass<KPlayer>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v50 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void OnSeatSwitch()
	{
		//IL_0028: Expected I, but got O
		//IL_0038: Expected O, but got I
		//IL_0048: Expected O, but got I
		if (UpdateUser())
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v1 (Il2CppClass<KPlayer>)+1A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v1 (Il2CppClass<KPlayer>)+1B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v16 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	protected bool UpdateUser()
	{
		//IL_024c: Expected I4, but got O
		//IL_0053: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0124: Expected I, but got O
		//IL_0134: Expected O, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		if ((object)<Game>k__BackingField != null)
		{
			Room room = <Game>k__BackingField.Room;
			PlayerInfo[] playersInfo = SFSKammelnaRoomExtensions.GetPlayersInfo(room);
			if (playersInfo != null)
			{
				object obj = <Index>k__BackingField - 1;
				bool flag = (nint)obj < playersInfo.Length;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_023e;
				}
				if ((object)<Game>k__BackingField != null)
				{
					object obj3 = (object)playersInfo + obj;
					Room room2 = <Game>k__BackingField.Room;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v4+20]");
					if ((nint)0 != 0)
					{
						int num = default(int);
						string text = num.ToString();
						if (room2 != null)
						{
							object obj4 = typeof(RegisteredWaitHandle) + 1376;
							nint num2 = (nint)room2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_01b0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
							object obj6 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v5-8]");
								if (0 == (nint)obj4)
								{
									break;
								}
								obj6 += 16;
								obj5--;
								if ((nint)obj5 != 1)
								{
									continue;
								}
								goto IL_01b0;
							}
							object obj7 = obj6 + 26;
							object obj8 = num2 + obj7;
							object obj9 = obj8 + 312;
							goto IL_028f;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_023e;
		IL_01b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_028f;
		IL_028f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X0_v13] (should have been resolved before IL gen)");
		object obj10 = this + 24;
		object obj11 = default(object);
		if (obj11 != obj10)
		{
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		object obj12 = obj11 - obj10;
		bool flag2 = obj12 == null;
		return !flag2;
		IL_023e:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	protected abstract void UpdatePlayerState(ISFSObject response);

	protected virtual void FireEvents()
	{
		//IL_0040: Expected O, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		KGame kGame = <Game>k__BackingField;
		LastActionInfo <LastAction>k__BackingField = kGame.<LastAction>k__BackingField;
		if (kGame.<LastAction>k__BackingField == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)3136;
		int? num = <LastAction>k__BackingField.<ActionPlayer>k__BackingField;
		object obj2 = default(object);
		if (<Index>k__BackingField != (nint)obj2)
		{
			return;
		}
		object obj3 = (??)num & 1;
		if (obj3 != null)
		{
			Action onDidLastAction = this.OnDidLastAction;
			if (this.OnDidLastAction != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void InvokeOnDidLastAction()
	{
		Action onDidLastAction = this.OnDidLastAction;
		if (this.OnDidLastAction != null)
		{
			IntPtr invoke_impl = ((Delegate)onDidLastAction).invoke_impl;
			IntPtr method_code = ((Delegate)onDidLastAction).method_code;
			IntPtr method = ((Delegate)onDidLastAction).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	protected virtual void UserChanged()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B8F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00ea;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_007d;
		}
		goto IL_0128;
		IL_0128:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		playerJoinTimeStamp = now;
		Action onUserChanged = this.OnUserChanged;
		bool flag = this.OnUserChanged == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00b9;
		IL_007d:
		DateTime now2 = DateTime.Now;
		playerJoinTimeStamp = now2;
		onUserChanged = this.OnUserChanged;
		if (this.OnUserChanged != null)
		{
			goto IL_00b9;
		}
		return;
		IL_00b9:
		IntPtr invoke_impl = ((Delegate)onUserChanged).invoke_impl;
		IntPtr method_code = ((Delegate)onUserChanged).method_code;
		IntPtr method = ((Delegate)onUserChanged).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v66 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_00ea;
		IL_00ea:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_007d;
		}
		goto IL_0128;
	}

	public override string ToString()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object obj = "Picking audio files is not supported on iOS" + 472;
		object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1080;
		string nickName = NickName;
		int num = default(int);
		string text = num.ToString();
		return (string)obj + nickName + (string)obj2 + text;
	}
}
