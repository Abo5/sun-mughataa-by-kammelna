using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;
using UnityEngine;

public class UiGridView<TData, TItem> : UiListView<TData, TItem> where TData : IGridViewItemData<int> where TItem : IListViewItem<TData, int>
{
	private int columns;

	private float cachedHeight;

	protected override void Start()
	{
		//IL_0087: Expected O, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9DD98");
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+EC]");
		if ((nint)0 == 0)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+EC]");
		if ((nint)0 == 0)
		{
		}
		UIExtensions.SetPivot(rectTransform, (Vector2)0);
	}

	protected override void ComputeConditions()
	{
		//IL_02a0: Expected O, but got I
		//IL_01f2: Expected O, but got I
		//IL_000a: Expected I, but got O
		//IL_001a: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0068: Expected I, but got O
		//IL_0078: Expected O, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00fd: Expected O, but got I
		//IL_011a: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+98]");
		bool flag = (nint)0 == 0;
		IntPtr intPtr = default(IntPtr);
		object obj = (nint)intPtr;
		if (!flag)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v9 (Il2CppClass<UiGridView`2<TData, TItem>>)+2A0]");
			obj = 0;
			List<TData> list = base.data;
			if (list != null)
			{
				if (list._size < 1)
				{
					goto IL_02ae;
				}
				nint num2 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v12 (Il2CppClass<UiGridView`2<TData, TItem>>)+2A0]");
				obj = 0;
				List<AchievementHolder> list2 = (List<AchievementHolder>)(object)base.data;
				if (list2 != null)
				{
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v14 (Il2CppRgctx<UiGridView`2>)+40]");
					object obj2 = 0;
					AchievementHolder achievementHolder = list2.get_Item(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+130]");
					bool flag2 = (nint)0 == 0;
					obj = null;
					if (!flag2)
					{
						object obj3 = (nint)0 + (nint)1192;
						obj2 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+130]");
						object obj4 = default(object);
						Vector3 vector = ((Dictionary<object, Vector3>)0).get_Item(obj4);
						obj = obj4;
						goto IL_02ae;
					}
				}
			}
			throw new NullReferenceException();
		}
		goto IL_02ae;
		IL_02ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+110]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+110]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+110]");
				if ((nint)0 != 2)
				{
					object obj5 = typeof(System.IOAsyncCallback) + 2632;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj6 = "Index = {0} position = {1}" + 2552;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					IndexOutOfRangeException ex = default(IndexOutOfRangeException);
					string message = default(string);
					ex..ctor(message);
					object obj7 = (nint)0 + (nint)2304;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					throw new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+84]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
				object obj8 = num4 / 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+80]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
				object obj9 = num5 / 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+7C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
			object obj10 = num6 / 0;
		}
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9E1E8");
	}

	protected unsafe override void UpdateItems()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0752: Expected O, but got I
		//IL_0772: Expected F4, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_004d: Expected F4, but got I4
		//IL_066b: Expected O, but got I
		//IL_0685: Expected O, but got I4
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I
		//IL_00cb: Expected F4, but got I4
		//IL_00dd: Expected F4, but got I4
		//IL_00e6: Expected F4, but got I4
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0707: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_0279: Expected I4, but got O
		//IL_028e: Expected O, but got I
		//IL_0331: Expected F4, but got O
		//IL_03ce: Expected O, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected I4, but got Unknown
		//IL_0408: Expected F4, but got I4
		//IL_0306: Expected I, but got O
		//IL_0831: Expected O, but got F4
		//IL_085a: Expected O, but got I4
		//IL_0324: Expected F4, but got O
		//IL_088a: Expected O, but got I4
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		//IL_042d: Invalid comparison between F4 and I4
		//IL_043c: Invalid comparison between F4 and I4
		//IL_044f: Expected O, but got F4
		//IL_045c: Expected O, but got F4
		//IL_010b: Expected I, but got O
		//IL_0121: Expected O, but got Ref
		//IL_0146: Invalid comparison between F4 and I4
		//IL_0155: Invalid comparison between F4 and I4
		//IL_0168: Expected O, but got F4
		//IL_0175: Expected O, but got F4
		//IL_01aa: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_04a2: Expected I, but got O
		//IL_04bc: Expected I4, but got O
		//IL_04e1: Invalid comparison between F4 and I4
		//IL_04f0: Invalid comparison between F4 and I4
		//IL_0503: Expected O, but got F4
		//IL_0510: Expected O, but got F4
		//IL_0545: Expected O, but got I4
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_0627: Expected O, but got I
		//IL_08d4: Expected I, but got O
		//IL_08dc: Expected O, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
		object obj;
		float num;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
				bool flag = (nint)0 != 1;
				num = 0f;
				if (flag)
				{
					goto IL_06a3;
				}
				obj = this + 128;
			}
			else
			{
				obj = this + 132;
			}
		}
		else
		{
			obj = this + 124;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+98]");
		bool flag2 = (nint)0 == 0;
		num = 0f;
		if (!flag2)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+18]");
			if ((nint)0 < (nint)1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+48]");
				object obj3 = (nint)1 & (nint)0;
				bool flag3 = obj3 == null;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					return;
				}
				goto IL_0644;
			}
			object obj5 = (nint)0 + (nint)1192;
			num = 0f;
			bool doneSettling = true;
			float num2 = 0f;
			float num3 = 0f;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			float num9 = default(float);
			AchievementHolder achievementHolder3 = default(AchievementHolder);
			object obj6 = default(object);
			AchievementHolder achievementHolder4 = default(AchievementHolder);
			AchievementHolder achievementHolder5 = default(AchievementHolder);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+98]");
				if ((nint)0 == 0)
				{
					break;
				}
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v13 (Il2CppRgctx<UiGridView`2>)+40]");
				int num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+98]");
				AchievementHolder achievementHolder = ((List<AchievementHolder>)0).get_Item(num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+130]");
				bool flag4 = (nint)0 == 0;
				num = num9;
				nint num10 = num4;
				AchievementHolder achievementHolder2 = achievementHolder3;
				if (flag4)
				{
					break;
				}
				num8 = (int)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+130]");
				Vector3 vector = ((Dictionary<object, Vector3>)0).get_Item(obj6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
				float num11;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
						bool flag5 = (nint)0 != 1;
						num = num9;
						num10 = (nint)obj6;
						achievementHolder2 = achievementHolder3;
						if (flag5)
						{
							goto IL_06a3;
						}
						num11 = (float)achievementHolder3;
					}
					else
					{
						num11 = (float)achievementHolder4;
					}
				}
				else
				{
					num11 = num9;
				}
				int num12 = achievementHolder5.columns;
				int num14;
				int num16;
				int num17;
				if (num12 >= 1)
				{
					int num13 = achievementHolder5.columns;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
					num14 = 0;
					num5 = num13 + num5;
					int num15 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
					bool flag6 = (nint)num15 <= (nint)0;
					num16 = num13;
					num17 = num13;
					if (!flag6)
					{
						goto IL_03a5;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
					num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
					num5 = (int)((nint)0 + (nint)num5);
					int num18 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
					bool flag7 = (nint)num18 > (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
					num16 = 0;
					if (flag7)
					{
						goto IL_03a5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
					num17 = 0;
				}
				goto IL_080d;
				IL_080d:
				float num19 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+20]");
				num = num19 + 0f;
				achievementHolder2 = (AchievementHolder)(num11 + num);
				float num20 = (float)obj + num11;
				bool flag8 = (nint)achievementHolder2 < 0;
				object obj7 = !flag8;
				object obj8 = ~obj7;
				bool flag9;
				bool flag10;
				bool flag11;
				if (obj8 == null)
				{
					float num21 = num - num20;
					flag9 = num21 < 0f;
					flag10 = num21 == 0f;
					object obj9 = num ^ num20;
					object obj10 = num ^ num21;
					object obj11 = obj9 & obj10;
					flag11 = (nint)obj11 < 0;
				}
				else
				{
					flag11 = false;
					flag10 = false;
					flag9 = false;
				}
				bool flag12 = flag9 == flag11;
				object obj12 = !flag12;
				object obj13 = obj12 | flag10;
				float num25;
				if (obj13 != null)
				{
					nint num22 = (nint)this;
					base.UpdateVisibleItem((TData)(&num9), num6, num, ref doneSettling);
					int num23 = num6 + num17;
					float num24 = num2 - num11;
					bool flag13 = num24 < 0f;
					bool flag14 = num24 == 0f;
					object obj14 = num2 ^ num11;
					object obj15 = num2 ^ num24;
					object obj16 = obj14 & obj15;
					bool flag15 = (nint)obj16 < 0;
					bool flag16 = flag13 == flag15;
					object obj17 = !flag14;
					object obj18 = flag16 & obj17;
					object obj19 = ~obj18;
					if (obj19 != null)
					{
						num2 = num11;
					}
					num4++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+18]");
					bool flag17 = (nint)0 == num4;
					num8 = num6;
					num10 = (nint)(&num9);
					achievementHolder4 = achievementHolder3;
					achievementHolder2 = achievementHolder5;
					num6 = num23;
					num25 = num2;
					if (!flag17)
					{
						continue;
					}
				}
				else
				{
					nint num26 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v22 (Il2CppClass<UiGridView`2<TData, TItem>>)+2D0]");
					num8 = 0;
					base.Recycle((int)achievementHolder5);
					num6 += num17;
					float num27 = num2 - num11;
					bool flag18 = num27 < 0f;
					bool flag19 = num27 == 0f;
					object obj20 = num2 ^ num11;
					object obj21 = num2 ^ num27;
					object obj22 = obj20 & obj21;
					bool flag20 = (nint)obj22 < 0;
					bool flag21 = flag18 == flag20;
					object obj23 = !flag19;
					object obj24 = flag21 & obj23;
					object obj25 = ~obj24;
					if (obj25 != null)
					{
						num2 = num11;
					}
					num4++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+18]");
					bool flag22 = (nint)0 != num4;
					num10 = (nint)achievementHolder5;
					achievementHolder4 = (AchievementHolder)num20;
					if (flag22)
					{
						continue;
					}
					num25 = num2;
				}
				float num28 = num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+16C]");
				float num29 = num28 + 0f;
				bool num30 = doneSettling;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+48]");
				object obj26 = (nint)(num30 ? 1 : 0) & (nint)0;
				if (obj26 != null)
				{
					goto IL_0644;
				}
				return;
				IL_03a5:
				num3 = num2 + num3;
				int num31 = num6 / num14;
				object obj27 = num14 * num31;
				num6 = num14 + obj27;
				float num32 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+16C]");
				float num33 = num32 + 0f;
				num17 = num16;
				num2 = 0f;
				num5 = num16;
				goto IL_080d;
			}
		}
		throw new NullReferenceException();
		IL_0644:
		base.EndSettling();
		return;
		IL_06a3:
		object obj28 = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = "Index = {0} position = {1}" + 2552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string message = default(string);
		ex..ctor(message);
		object obj30 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	protected unsafe override void UpdateItem(IListViewItem item, int order, float offset, ref bool doneSettling)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00f8: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_011e: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_014a: Expected O, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0172: Expected O, but got I4
		//IL_04e0: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_0549: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_0326: Expected O, but got I
		//IL_0348: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_0244: Expected O, but got I
		//IL_025a: Expected O, but got I
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0282: Expected O, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_058b: Expected O, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_064d: Expected O, but got Ref
		//IL_064d: Expected O, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_05f4: Expected O, but got I
		//IL_02bd: Expected O, but got I
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_0495: Expected O, but got I
		//IL_0394: Expected O, but got I
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v2 (Il2CppRgctx<UiGridView`2>)+80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v2 (Il2CppRgctx<UiGridView`2>)+80]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj5 = default(object);
			obj = obj5;
		}
		int num4 = default(int);
		object obj9;
		int num2 = default(int);
		object obj7;
		AchievementHolder achievementHolder;
		if (item != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj6 = default(object);
			bool flag2 = obj6 == null;
			achievementHolder = (AchievementHolder)0;
			if (flag2)
			{
				num2 = num2;
				obj7 = obj;
				throw new InvalidCastException();
			}
			bool flag3 = obj6 == null;
			object obj8 = !flag3;
			obj9 = obj6;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
				obj = 0;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10 (Il2CppRgctx<UiGridView`2>)+88]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10 (Il2CppRgctx<UiGridView`2>)+88]");
				object obj11 = (nint)0 + (nint)309;
				object obj12 = obj11 & 1;
				bool flag4 = obj12 == null;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj14 = default(object);
					obj10 = obj14;
				}
				object obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v13+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v13+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01ee;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v13+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X10_v17-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_01ee;
				}
				object obj18 = obj15 + obj17;
				object obj19 = obj18 + 312;
				num2 = num4;
				goto IL_0529;
			}
			num2 = num4;
			achievementHolder = (AchievementHolder)0;
		}
		else
		{
			obj9 = 0;
			num2 = num4;
			achievementHolder = (AchievementHolder)0;
		}
		goto IL_040b;
		IL_03c9:
		object obj20;
		if ((nint)obj20 == 2 || (nint)obj20 == 1)
		{
			goto IL_0630;
		}
		object obj21 = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = "Index = {0} position = {1}" + 2552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string message = default(string);
		ex..ctor(message);
		object obj23 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_0630:
		ref bool doneSettling2 = default(ref bool);
		base.UpdateItemTransform(item, num4, (Vector3)0, (Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref doneSettling), dontSettle: false, ref doneSettling2);
		return;
		IL_040b:
		throw new NullReferenceException();
		IL_02fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 0;
		goto IL_05d4;
		IL_01ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 0;
		goto IL_0529;
		IL_05d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v649 @ X0_v38] (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v43 (Il2CppRgctx<UiGridView`2>)+60]");
		obj7 = 0;
		AchievementHolder achievementHolder2 = default(AchievementHolder);
		int num6 = achievementHolder2.columns;
		bool flag5 = (object)this == null;
		object obj25 = default(object);
		object obj24 = obj25;
		AchievementHolder achievementHolder3 = default(AchievementHolder);
		achievementHolder = achievementHolder3;
		if (flag5)
		{
			goto IL_040b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+110]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+110]");
		bool flag6 = (nint)0 == 0;
		obj24 = obj25;
		achievementHolder = achievementHolder3;
		if (flag6)
		{
			goto IL_0630;
		}
		goto IL_03c9;
		IL_0529:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ X0_v23] (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v17 (Il2CppRgctx<UiGridView`2>)+60]");
		obj7 = 0;
		int num8 = achievementHolder2.columns;
		if (num8 >= 1)
		{
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v35 (Il2CppRgctx<UiGridView`2>)+88]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v35 (Il2CppRgctx<UiGridView`2>)+88]");
			object obj27 = (nint)0 + (nint)309;
			object obj28 = obj27 & 1;
			bool flag7 = obj28 == null;
			object obj29 = !flag7;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				object obj30 = default(object);
				obj26 = obj30;
			}
			object obj31 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v38+12E]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v38+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02fe;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v38+B0]");
			object obj33 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X10_v12-8]");
				if (0 == (nint)obj26)
				{
					break;
				}
				obj33 += 16;
				obj32--;
				if ((nint)obj32 != 1)
				{
					continue;
				}
				goto IL_02fe;
			}
			object obj34 = obj31 + obj33;
			object obj35 = obj34 + 312;
			goto IL_05d4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+110]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+110]");
		bool flag8 = (nint)0 == 0;
		object obj36 = !flag8;
		achievementHolder = (AchievementHolder)0;
		if (obj36 != null)
		{
			goto IL_03c9;
		}
		goto IL_0630;
	}

	protected override float ComputeListHeight()
	{
		//IL_0010: Expected O, but got I
		//IL_011f: Expected F4, but got I4
		//IL_02a7: Invalid comparison between F4 and I4
		//IL_02b6: Invalid comparison between F4 and I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02d7: Expected O, but got F4
		//IL_030c: Expected O, but got I4
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_01d7: Expected F4, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_026c: Expected O, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+98]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+98]");
		float num5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+16C]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
				int num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v1+18]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
				int num3 = IntegerExtensions.CeilingTo((int)num2, 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
				bool flag = (nint)0 < (nint)3;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_0208;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
				object obj3 = this + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v11+58]");
				object obj4 = (nint)0 * (nint)num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+168]");
				object obj5 = obj4 / 0;
				float num4 = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v11+7C]");
				num5 = num4 - 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
				object obj6;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+10C]");
						bool flag2 = (nint)0 != 1;
						IntPtr intPtr = default(IntPtr);
						int num = (int)(nint)intPtr;
						if (flag2)
						{
							goto IL_0208;
						}
						obj6 = this + 128;
					}
					else
					{
						obj6 = this + 132;
					}
				}
				else
				{
					obj6 = this + 124;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UiGridView`2<TData, TItem>)+16C]");
				num5 = 0f - (float)obj6;
			}
		}
		else
		{
			num5 = 0f;
		}
		float num6 = num5 - 2.139095E+09f;
		bool flag3 = num6 < 0f;
		bool flag4 = num6 == 0f;
		object obj7 = num5 ^ 0x7F7FFFFF;
		object obj8 = num5 ^ num6;
		object obj9 = obj7 & obj8;
		bool flag5 = (nint)obj9 < 0;
		bool flag6 = flag3 == flag5;
		object obj10 = !flag4;
		object obj11 = flag6 & obj10;
		object obj12 = ~obj11;
		float result = ((obj12 != null) ? num5 : 2.139095E+09f);
		if ((double)num5 < 1.0)
		{
			return 1f;
		}
		return result;
		IL_0208:
		object obj13 = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = "Index = {0} position = {1}" + 2552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string message = default(string);
		ex..ctor(message);
		object obj15 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public UiGridView()
	{
		_ = 2;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA2BB4");
	}
}
