using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;

public class MatchupsListView : UiGridView<Matchup, MatchupUi>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<QueuePlayer, int> <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <SetData>b__4_0(QueuePlayer player)
		{
			//IL_0035: Expected I4, but got O
			if (player != null)
			{
				return player.<order>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public Dictionary<int, QueuePlayer> queuePlayers;

		internal Matchup <SetData>b__1(int i)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_00ec: Expected O, but got I4
			//IL_00f4: Expected I, but got O
			//IL_01bf: Expected O, but got I4
			//IL_01c7: Expected I, but got O
			//IL_014f: Expected O, but got I
			//IL_0171: Expected O, but got I4
			//IL_0179: Expected I, but got O
			//IL_0191: Expected O, but got I
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected O, but got Unknown
			//IL_031f: Expected O, but got I8
			//IL_0337: Expected O, but got I4
			//IL_033f: Expected I, but got O
			//IL_02bd: Expected O, but got I
			//IL_02df: Expected O, but got I4
			//IL_02e7: Expected I, but got O
			//IL_02f7: Expected O, but got I
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Expected O, but got Unknown
			//IL_037e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			bool flag = obj2 == null;
			QueuePlayer queuePlayer = null;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			if (!flag)
			{
				object obj3 = typeof(TypeConverter<ushort, char>) + 3592;
				object obj4 = (nint)0 + (nint)3264;
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2768;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				int num = i << 2;
				object obj6 = DictionaryExtensions.Get((IDictionary<int, object>)queuePlayers, num);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
				object obj7 = DictionaryExtensions.Get((IDictionary<int, object>)queuePlayers, 1);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				int num2 = i << 1;
				QueueTeam queueTeam = default(QueueTeam);
				queueTeam..ctor((QueuePlayer)obj6, (QueuePlayer)obj7, num2);
				object obj8 = default(object);
				bool flag2 = obj8 == null;
				object obj9 = 0;
				nint num3 = (nint)obj7;
				int num4 = num2;
				queuePlayer = (QueuePlayer)obj6;
				if (!flag2)
				{
					bool flag3 = queueTeam == null;
					QueuePlayer queuePlayer2 = (QueuePlayer)obj6;
					if (!flag3)
					{
						object obj10 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v13+40]");
						queuePlayer2 = (QueuePlayer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag4 = ex == null;
						obj9 = 0;
						num3 = (nint)obj7;
						num4 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v13+40]");
						queuePlayer = (QueuePlayer)0;
						if (flag4)
						{
							goto IL_03bb;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v12+18]");
					bool flag5 = (nint)0 == 0;
					obj9 = 0;
					num3 = (nint)obj7;
					num4 = num2;
					queuePlayer = queuePlayer2;
					if (!flag5)
					{
						object obj11 = obj8 + 32;
						obj11 = queueTeam;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						int key = num | 2;
						object obj12 = DictionaryExtensions.Get((IDictionary<int, object>)queuePlayers, key);
						int key2 = num | 3;
						object obj13 = DictionaryExtensions.Get((IDictionary<int, object>)queuePlayers, key2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						num4 = num2 | 1;
						QueueTeam queueTeam2 = default(QueueTeam);
						queueTeam2..ctor((QueuePlayer)obj12, (QueuePlayer)obj13, num4);
						bool flag6 = queueTeam2 == null;
						QueuePlayer queuePlayer3 = (QueuePlayer)obj12;
						if (!flag6)
						{
							object obj14 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v12+40]");
							queuePlayer3 = (QueuePlayer)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag7 = ex == null;
							obj9 = 0;
							num3 = (nint)obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v12+40]");
							queuePlayer = (QueuePlayer)0;
							if (flag7)
							{
								goto IL_03bb;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v12+18]");
						object obj15 = 0 & 0xFFFFFFFEL;
						bool flag8 = obj15 == null;
						obj9 = 0;
						num3 = (nint)obj13;
						queuePlayer = queuePlayer3;
						if (!flag8)
						{
							object obj16 = obj8 + 40;
							obj16 = queueTeam2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj17 = obj2 + 16;
							obj17 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return (Matchup)obj2;
						}
					}
					goto IL_03ad;
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_03ad;
			IL_03bb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			return (Matchup)(object)new OutOfMemoryException();
			IL_03ad:
			ex = new IndexOutOfRangeException();
			goto IL_03bb;
		}
	}

	private int <MatchCount>k__BackingField;

	public int MatchCount
	{
		get
		{
			return <MatchCount>k__BackingField;
		}
		set
		{
			<MatchCount>k__BackingField = value;
		}
	}

	public void SetData(List<QueuePlayer> players)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0188: Expected O, but got I
		//IL_0198: Expected O, but got I
		//IL_01a8: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0202: Expected O, but got I4
		//IL_0113: Expected I, but got O
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02e2: Expected O, but got I
		//IL_02f3: Expected I, but got O
		//IL_0311: Expected O, but got I
		//IL_0263: Expected O, but got I4
		//IL_0232: Expected O, but got I
		//IL_0140: Expected I, but got O
		//IL_0150: Expected O, but got I
		//IL_0160: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3304;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+E4]");
		if ((nint)0 == 0)
		{
			goto IL_016a;
		}
		object obj5 = (nint)0 + (nint)1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+8]");
		bool flag = (nint)0 == 0;
		object obj8 = obj5;
		if (!flag)
		{
			goto IL_0086;
		}
		goto IL_01e0;
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12+B8]");
			obj6 = 0;
		}
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1200;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj6, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v11+B8]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE5C6C");
		bool flag3 = obj3 == null;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_009d;
		IL_0086:
		obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE5C6C");
		goto IL_009d;
		IL_009d:
		object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1912;
		object obj18 = (nint)0 + (nint)1208;
		object obj19 = obj3 + 16;
		object obj20 = default(object);
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<int> source = Enumerable.Range(0, <MatchCount>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<int, object> func2 = default(Func<int, object>);
		func2..ctor(obj3, (IntPtr)obj18);
		IEnumerable<object> source2 = Enumerable.Select(source, func2);
		List<object> list = Enumerable.ToList(source2);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v16 (Il2CppClass<MatchupsListView>)+2A8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v16 (Il2CppClass<MatchupsListView>)+2B0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v189 @ X3_v5 (should have been resolved before IL gen)");
		goto IL_016a;
		IL_016a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		obj5 = (nint)0 + (nint)1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+B8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+8]");
		bool flag4 = (nint)0 == 0;
		object obj23 = !flag4;
		obj8 = obj5;
		if (obj23 != null)
		{
			goto IL_0086;
		}
		goto IL_01e0;
	}

	public MatchupsListView()
	{
		((UiGridView<object, object>)(object)this)..ctor();
	}
}
