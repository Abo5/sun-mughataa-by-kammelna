using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Cpp2ILInjected;
using Unity.Properties;

namespace Features.GameReplay;

public class GameReplayListView : UiListView<GameReplayDataHolder, GameReplayCard>
{
	public void SetGameReplay(GameReplayListUI gameReplayListUI, List<GameReplayCardData> gameReplayCardData, bool forceUpdate = false)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0052: Expected O, but got I4
		//IL_02e3: Expected O, but got I4
		//IL_0277: Expected O, but got I
		//IL_029e: Expected O, but got I4
		//IL_02b3: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_021e: Expected I, but got O
		//IL_022e: Expected O, but got I
		//IL_023e: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_014b: Expected I, but got O
		//IL_015b: Expected O, but got I
		//IL_01b0: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8388]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_0248;
		}
		bool flag = !forceUpdate;
		object obj3 = !flag;
		if (obj3 == null)
		{
			goto IL_0060;
		}
		goto IL_0267;
		IL_02e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		goto IL_0300;
		IL_0060:
		bool flag2 = gameReplayCardData == null;
		GameReplayListView gameReplayListView = this;
		object obj5 = default(object);
		object obj4 = obj5;
		if (!flag2)
		{
			goto IL_008a;
		}
		goto IL_02c1;
		IL_008a:
		object obj6 = typeof(TypeConverter<ushort, char>) + 2576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		if (gameReplayCardData._size < 1)
		{
			goto IL_0208;
		}
		object obj7 = (nint)0 + (nint)2688;
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		NullReferenceException ex2 = default(NullReferenceException);
		List<GameReplayCardData> list;
		GameReplayListUI gameReplayListUI2;
		if (enumerable != null)
		{
			object obj8 = enumerable + 32;
			object obj9 = "Read object reference Id '{0}' for {1}." + 2264;
			int num = 0;
			object obj12 = default(object);
			while (true)
			{
				list = (List<GameReplayCardData>)obj7;
				object obj10 = ((List<object>)(object)gameReplayCardData).get_Item(num);
				object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj12..ctor();
				object obj13 = obj12 + 40;
				obj13 = gameReplayListUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj14 = obj12 + 16;
				obj14 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj15 = obj12 + 32;
				obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				gameReplayListUI2 = (GameReplayListUI)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex2 == null;
				obj4 = obj5;
				if (flag3)
				{
					break;
				}
				int num3 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v45 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				bool flag4 = (nint)num3 < (nint)0;
				object obj16 = !flag4;
				obj4 = obj5;
				if (obj16 == null)
				{
					obj8 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num++;
					if (num < gameReplayCardData._size)
					{
						continue;
					}
					goto IL_0208;
				}
				goto IL_0300;
			}
			goto IL_02e8;
		}
		object obj17 = ((List<object>)(object)gameReplayCardData).get_Item(0);
		object obj18 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = default(object);
		obj19..ctor();
		object obj20 = obj19 + 40;
		obj20 = gameReplayListUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj21 = obj19 + 16;
		obj21 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj22 = "Read object reference Id '{0}' for {1}." + 2264;
		object obj23 = obj19 + 32;
		obj23 = obj22;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		throw new NullReferenceException();
		IL_0208:
		List<object> list2 = Enumerable.ToList(enumerable);
		nint num4 = (nint)gameReplayListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v22 (Il2CppClass<Features.GameReplay.GameReplayListView>)+2A8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v22 (Il2CppClass<Features.GameReplay.GameReplayListView>)+2B0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v268 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0248;
		IL_0267:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayListView)+E8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayListView)+E8]");
		_ = 0;
		bool flag5 = gameReplayCardData == null;
		object obj26 = !flag5;
		gameReplayListView = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Features.GameReplay.GameReplayListView)+E8]");
		obj4 = 0;
		if (obj26 != null)
		{
			goto IL_008a;
		}
		goto IL_02c1;
		IL_0248:
		_ = 1;
		if (!forceUpdate)
		{
			goto IL_0060;
		}
		goto IL_0267;
		IL_02c1:
		ex2 = new NullReferenceException();
		list = gameReplayCardData;
		gameReplayListUI2 = gameReplayListUI;
		obj7 = 152993792;
		goto IL_02e8;
		IL_0300:
		obj5 = obj4;
		throw new IndexOutOfRangeException();
	}

	public GameReplayListView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}
}
