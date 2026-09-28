using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.TextCore;

namespace ListView;

public abstract class ListViewController<TData, TItem, TIndex> : ListViewControllerBase where TData : IListViewItemData<TIndex> where TItem : IListViewItem<TData, TIndex>
{
	protected sealed class ListViewItemTemplate
	{
		public readonly GameObject prefab;

		public readonly Queue<TItem> pool;

		public ListViewItemTemplate(GameObject prefab)
		{
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected O, but got Unknown
			//IL_01eb: Expected O, but got I
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_0213: Expected O, but got I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0101: Expected O, but got I4
			//IL_010f: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_00af: Expected O, but got I4
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Expected O, but got Unknown
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_016a: Expected O, but got I4
			//IL_00cb: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			nint num = 0;
			IntPtr intPtr = num;
			object obj2 = num + 309;
			object obj3 = obj2 & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Queue<object> queue = default(Queue<object>);
			queue..ctor();
			object obj5 = this + 24;
			obj5 = queue;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			base..ctor();
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v9+E4]");
			object obj8;
			object obj10;
			if ((nint)0 != 0)
			{
				bool flag2 = prefab == null;
				bool flag3 = !flag2;
				object obj7 = !flag3;
				obj8 = 0;
				UnityEngine.Object obj9 = null;
				if (obj7 != null)
				{
					goto IL_011d;
				}
				obj10 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = prefab == null;
				bool flag5 = !flag4;
				obj8 = 0;
				UnityEngine.Object obj9 = null;
				obj10 = 0;
				if (!flag5)
				{
					goto IL_011d;
				}
			}
			goto IL_019d;
			IL_011d:
			object obj11 = typeof(DataRelation) + 856;
			object message = "SubscribeGroup request Error" + 3352;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogError(message);
			obj10 = obj8;
			goto IL_019d;
			IL_019d:
			object obj14 = this + 16;
			obj14 = prefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected List<TData> m_Data;

	protected IListViewItem<TData, TIndex> m_LastUpdatedItemItem;

	protected readonly Dictionary<string, ListViewItemTemplate> m_TemplateDictionary;

	protected readonly Dictionary<TIndex, TItem> m_ListItems;

	protected readonly Dictionary<TIndex, Transform> m_GrabbedRows;

	protected Action<Action> m_StartSettling;

	protected Action m_EndSettling;

	protected Func<TIndex, IListViewItem<TData, TIndex>> m_GetListItem;

	protected Action<TData> _removeItem;

	protected Action<TData> _togglePin;

	public unsafe virtual List<TData> data
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+98]");
			return (List<TData>)0;
		}
		set
		{
			//IL_0008: Expected O, but got Ref
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_0030: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_0091: Expected O, but got I
			//IL_0522: Expected O, but got I
			//IL_0532: Expected O, but got I
			//IL_0542: Expected O, but got I
			//IL_0552: Expected O, but got I
			//IL_023b: Expected O, but got I4
			//IL_0244: Expected O, but got I4
			//IL_024e: Expected O, but got I4
			//IL_04a8: Expected O, but got I
			//IL_04b8: Expected O, but got I
			//IL_04c8: Expected O, but got I
			//IL_04d8: Expected O, but got I
			//IL_04fb: Expected O, but got I4
			//IL_0313: Expected O, but got I4
			//IL_00c8: Expected O, but got I
			//IL_00d8: Expected O, but got I
			//IL_00e8: Expected O, but got I
			//IL_00f8: Expected O, but got I
			//IL_010e: Expected O, but got I
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			//IL_0136: Expected O, but got I4
			//IL_03d4: Expected O, but got I
			//IL_03e4: Expected O, but got I
			//IL_02aa: Expected O, but got I4
			//IL_01fd: Expected I, but got O
			//IL_0391: Expected O, but got I4
			//IL_02fa: Expected O, but got I
			//IL_0458: Expected I, but got O
			//IL_0467: Expected O, but got I
			//IL_0171: Expected O, but got I
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Expected O, but got Unknown
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Expected O, but got Unknown
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Expected O, but got Unknown
			object obj2 = default(object);
			object obj = (object)(&obj2);
			object obj3 = this + 152;
			bool flag = obj3 == null;
			Dictionary<int, object>.Enumerator enumerator = (Dictionary<int, object>.Enumerator)0;
			if (flag)
			{
				goto IL_03a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
			bool flag2 = (nint)0 == 0;
			List<TData> list2 = default(List<TData>);
			List<TData> list = list2;
			Dictionary<int, object>.Enumerator enumerator2 = (Dictionary<int, object>.Enumerator)0;
			enumerator = (Dictionary<int, object>.Enumerator)0;
			Dictionary<int, object>.Enumerator enumerator5 = default(Dictionary<int, object>.Enumerator);
			Dictionary<int, object>.Enumerator enumerator7 = default(Dictionary<int, object>.Enumerator);
			object obj24;
			Dictionary<int, object>.Enumerator enumerator4;
			List<TData> list3;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
				Dictionary<int, object>.Enumerator enumerator3 = ((Dictionary<int, object>)0).GetEnumerator();
				IntPtr intPtr = default(IntPtr);
				object obj14 = default(object);
				bool flag5 = default(bool);
				string template = default(string);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v20+20]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v21+C0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v22+88]");
					list = (List<TData>)0;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					if (intPtr != (IntPtr)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v23+20]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v24+C0]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v25+58]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v25+58]");
						object obj11 = (nint)0 + (nint)309;
						object obj12 = obj11 & 1;
						bool flag3 = obj12 == null;
						object obj13 = !flag3;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							obj10 = obj14;
						}
						object obj15 = (nint)intPtr;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v28+12E]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v28+12E]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v28+B0]");
							object obj17 = (nint)0 + (nint)8;
							bool flag4 = flag5;
							object obj19;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v11-8]");
								object obj18 = 0 - obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v11-8]");
								if (0 == (nint)obj10)
								{
									break;
								}
								obj19 = obj17 + 16;
								obj16--;
								obj18 = obj16 - 1;
								bool flag6 = obj18 == null;
								flag5 = (nint)obj16 != 1;
								flag4 = flag5;
								obj17 = obj19;
								if (flag5)
								{
									continue;
								}
								goto IL_01ee;
							}
							object obj20 = obj15 + obj17;
							object obj21 = obj20 + 312;
							flag5 = flag4;
							obj19 = obj17;
							goto IL_0449;
						}
						goto IL_01ee;
					}
					goto IL_02ff;
					IL_01ee:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					nint num = unchecked((nint)null);
					goto IL_0449;
					IL_0449:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v446 @ X0_v28] (should have been resolved before IL gen)");
					nint num2 = (nint)this;
					RecycleItem(template, (TItem)(nint)intPtr);
					num = intPtr;
				}
				object obj22 = 5;
				object obj23 = 0;
				obj24 = 0;
				enumerator4 = enumerator5;
				list3 = list2;
				Dictionary<int, object>.Enumerator enumerator6 = enumerator7;
				enumerator = enumerator7;
				object obj29 = default(object);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v5+20]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v6+C0]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v7+90]");
					list = (List<TData>)0;
					enumerator6.Dispose();
					bool flag7 = obj23 == null;
					object obj28 = !flag7;
					enumerator2 = enumerator6;
					if (obj28 != null)
					{
						OutOfMemoryException ex = new OutOfMemoryException();
						if ((nint)list == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj23 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							obj22 = 0;
							obj24 = obj29;
							enumerator6 = enumerator2;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CC9F44");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
					}
					break;
				}
				if ((nint)obj22 != 5)
				{
					bool flag8 = obj22 == null;
					object obj30 = !flag8;
					if (obj30 != null)
					{
						return;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
				bool flag9 = (nint)0 == 0;
				enumerator2 = enumerator6;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
					((Dictionary<int, object>)0).Clear();
					goto IL_03a7;
				}
			}
			goto IL_03c1;
			IL_02ff:
			NullReferenceException ex2 = new NullReferenceException();
			obj24 = 0;
			enumerator4 = enumerator5;
			list3 = list2;
			enumerator2 = enumerator7;
			enumerator = enumerator7;
			goto IL_03c1;
			IL_03c1:
			throw new NullReferenceException();
			IL_03a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
		}
	}

	protected override float listHeight
	{
		get
		{
			//IL_0010: Expected O, but got I
			//IL_005f: Expected F4, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+98]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+98]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+60]");
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+18]");
				return num * 0f;
			}
			return 0f;
		}
	}

	protected override void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0047: Expected I, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_008e: Expected I, but got O
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I
		//IL_00f2: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01be: Expected O, but got I
		//IL_01d4: Expected O, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1032;
		object obj2 = typeof(SqlSingle[]) + 2376;
		base.Awake();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<ListView.ListViewController`3<TData, TItem, TIndex>>)+280]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		object obj3 = this + 192;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v4 (Il2CppClass<ListView.ListViewController`3<TData, TItem, TIndex>>)+290]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		object obj4 = this + 200;
		obj4 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6 (Il2CppRgctx<ListView.ListViewController`3>)+B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6 (Il2CppRgctx<ListView.ListViewController`3>)+B0]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag = obj7 == null;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v10 (Il2CppRgctx<ListView.ListViewController`3>)+A8]");
		Func<int, object> func = default(Func<int, object>);
		func..ctor((object)this, (IntPtr)0);
		object obj9 = this + 208;
		obj9 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = this + 152;
		if (obj10 == null)
		{
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v13 (Il2CppRgctx<ListView.ListViewController`3>)+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v13 (Il2CppRgctx<ListView.ListViewController`3>)+8]");
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag2 = obj13 == null;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<AchievementHolder> list = default(List<AchievementHolder>);
			list..ctor();
			obj10 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected virtual void Start()
	{
		//IL_001c: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0129: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_020c: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I4
		//IL_02a5: Expected O, but got I
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A8]");
		((Dictionary<object, object>)0).Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X26_v3+18]");
		if ((nint)0 <= (nint)0)
		{
			object obj2 = typeof(DataRelation) + 856;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "Network Authentication Required" + 1168;
			Debug.LogError(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+38]");
			obj = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X26_v3+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object message2 = "ThisIsFakeReceiptData" + 2816;
		object obj5 = obj + 32;
		object obj6 = 0;
		object value = default(object);
		object obj15;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X25_v4+v82 @ X27_v5*8]");
			string text = ((UnityEngine.Object)0).name;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A8]");
			bool flag2 = ((Dictionary<object, object>)0).ContainsKey(text);
			bool flag3 = !flag2;
			object obj7 = text;
			if (!flag3)
			{
				object obj8 = typeof(DataRelation) + 856;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v18+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogError(message2);
				obj7 = null;
			}
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v15 (Il2CppRgctx<ListView.ListViewController`3>)+E0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v15 (Il2CppRgctx<ListView.ListViewController`3>)+E0]");
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag5 = obj13 == null;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32A05E0");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A8]");
			((Dictionary<object, object>)0).set_Item((object)text, value);
			obj6++;
			obj15 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X26_v3+18]");
		}
		while ((nint)obj15 < 0);
	}

	protected unsafe override void UpdateItems()
	{
		//IL_0010: Expected O, but got I
		//IL_0020: Expected O, but got I
		//IL_045e: Expected O, but got I
		//IL_0478: Expected O, but got I4
		//IL_03fc: Expected I, but got O
		//IL_0078: Expected O, but got I
		//IL_0081: Expected O, but got I4
		//IL_051d: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_01b4: Invalid comparison between F4 and I4
		//IL_01c5: Expected O, but got I4
		//IL_04f2: Expected O, but got I4
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_01fc: Invalid comparison between F4 and I4
		//IL_020b: Invalid comparison between F4 and I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0233: Expected O, but got F4
		//IL_009d: Expected I, but got O
		//IL_00b7: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_03a2: Expected O, but got I
		//IL_0288: Expected I, but got O
		//IL_02ba: Expected O, but got I
		//IL_02d1: Expected O, but got Ref
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0315: Expected O, but got Ref
		//IL_0325: Expected O, but got I
		//IL_032d: Expected F4, but got O
		//IL_0346: Expected O, but got Ref
		//IL_0356: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_036e: Expected F4, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+98]");
		object obj5;
		object obj7;
		object obj9;
		float num;
		float num3;
		int num5;
		nint num14;
		NullReferenceException ex;
		object obj6 = default(object);
		object obj8 = default(object);
		object obj10 = default(object);
		float num2 = default(float);
		float num4 = default(float);
		int num6 = default(int);
		nint num13;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5+18]");
			if ((nint)0 < (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+48]");
				object obj3 = (nint)1 & (nint)0;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_03f7;
				}
				obj5 = obj6;
				obj7 = obj8;
				obj9 = obj10;
				num = num2;
				num3 = num4;
				ex = (NullReferenceException)(object)this;
				num5 = num6;
				goto IL_050d;
			}
			IntPtr intPtr = default(IntPtr);
			object obj11 = (nint)(&intPtr) | (nint)4;
			object obj12 = 0;
			int num7 = 0;
			bool doneSettling = true;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+98]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+98]");
				AchievementHolder achievementHolder = ((List<AchievementHolder>)0).get_Item(num7);
				float num8 = (float)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+20]");
				num4 = num8 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+60]");
				num2 = 0f + num4;
				bool flag2 = num2 < 0f;
				object obj13 = !flag2;
				object obj14 = ~obj13;
				bool flag3;
				bool flag4;
				bool flag5;
				if (obj14 == null)
				{
					float num9 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+84]");
					float num10 = num9 - 0f;
					flag3 = num10 < 0f;
					flag4 = num10 == 0f;
					float num11 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+84]");
					object obj15 = num11 ^ 0;
					object obj16 = num4 ^ num10;
					object obj17 = obj15 & obj16;
					flag5 = (nint)obj17 < 0;
				}
				else
				{
					flag5 = false;
					flag4 = false;
					flag3 = false;
				}
				bool flag6 = flag3 == flag5;
				object obj18 = !flag4;
				object obj19 = flag6 & obj18;
				if (obj19 != null)
				{
					nint num12 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v22 (Il2CppClass<ListView.ListViewController`3<TData, TItem, TIndex>>)+2D0]");
					num6 = 0;
					Recycle((TIndex)(nint)intPtr);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+60]");
					obj12 = 0 + obj12;
					num7++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5+18]");
					bool flag7 = (nint)0 == num7;
					num13 = intPtr;
					obj5 = obj6;
					obj7 = obj8;
					obj9 = obj10;
					num = num2;
					num14 = intPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v22 (Il2CppClass<ListView.ListViewController`3<TData, TItem, TIndex>>)+2D0]");
					num5 = 0;
					if (!flag7)
					{
						continue;
					}
				}
				else
				{
					int num15 = 0 + 1;
					nint num16 = (nint)this;
					obj11 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v6+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v6+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v21 (Il2CppClass<ListView.ListViewController`3<TData, TItem, TIndex>>)+2F0]");
					obj8 = 0;
					UpdateVisibleItem((TData)(&intPtr), 0, num4, ref doneSettling);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+60]");
					obj12 = 0 + obj12;
					num7++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5+18]");
					bool flag8 = (nint)0 != num7;
					obj6 = (object)(&doneSettling);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v6+10]");
					obj10 = 0;
					num2 = (float)obj11;
					num13 = (nint)(&intPtr);
					num6 = 0;
					obj5 = (object)(&doneSettling);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v21 (Il2CppClass<ListView.ListViewController`3<TData, TItem, TIndex>>)+2F0]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v6+10]");
					obj9 = 0;
					num = (float)obj11;
					num14 = (nint)(&intPtr);
					num5 = num15;
					if (flag8)
					{
						continue;
					}
				}
				goto IL_038c;
			}
		}
		ex = new NullReferenceException();
		goto IL_04ce;
		IL_050d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj20 = 0;
		bool flag9 = obj20 != obj;
		obj6 = obj5;
		obj8 = obj7;
		obj10 = obj9;
		num2 = num;
		num4 = num3;
		num6 = num5;
		if (!flag9)
		{
			return;
		}
		goto IL_04ce;
		IL_03f7:
		nint num17 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v12 (Il2CppClass<ListView.ListViewController`3<TData, TItem, TIndex>>)+290]");
		num13 = 0;
		base.EndSettling();
		obj5 = obj6;
		obj7 = obj8;
		obj9 = obj10;
		num = num2;
		num3 = num4;
		num5 = num6;
		goto IL_050d;
		IL_038c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+48]");
		object obj21 = (nint)1 & (nint)0;
		bool flag10 = obj21 == null;
		obj6 = obj5;
		obj8 = obj7;
		obj10 = obj9;
		num2 = num;
		num6 = num5;
		num3 = num4;
		num13 = num14;
		if (!flag10)
		{
			goto IL_03f7;
		}
		goto IL_050d;
		IL_04ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
	}

	protected unsafe virtual void Recycle(TIndex index)
	{
		//IL_0016: Expected I4, but got O
		//IL_0016: Expected O, but got I
		//IL_0034: Expected O, but got I4
		//IL_0061: Expected I4, but got O
		//IL_0061: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I4
		//IL_01c6: Expected I, but got O
		//IL_01d6: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_011d: Expected O, but got I
		//IL_01b4: Expected I4, but got O
		//IL_01b4: Expected O, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0199: Expected O, but got Ref
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B8]");
		bool flag = ((Dictionary<int, object>)0).ContainsKey((int)index);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		if (!((Dictionary<int, object>)0).TryGetValue((int)index, out var value))
		{
			return;
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3 & 1;
		bool flag3 = obj4 == null;
		object obj5 = !flag3;
		object obj6 = value;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj6 = value;
			object obj7 = default(object);
			obj2 = obj7;
		}
		nint num3 = (nint)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v11 (Il2CppClass<System.Object>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v11 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_015e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v11 (Il2CppClass<System.Object>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X10_v7-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_015e;
		}
		object obj10 = num3 + obj9;
		object obj11 = obj10 + 312;
		object obj12 = (object)(&value);
		goto IL_021f;
		IL_021f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X0_v9] (should have been resolved before IL gen)");
		string template = default(string);
		RecycleItem(template, (TItem)value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		bool flag4 = ((Dictionary<int, object>)0).Remove((int)index);
		return;
		IL_015e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj12 = 0;
		goto IL_021f;
	}

	protected virtual void RecycleItem(string template, TItem item)
	{
		//IL_0038: Expected O, but got I
		//IL_0057: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0073: Expected I, but got O
		//IL_0083: Expected O, but got I
		//IL_0196: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		if (template == null || item == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A8]");
		object obj = ((Dictionary<object, object>)0).get_Item((object)template);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v5 (System.Object)+18]");
		((Queue<object>)0).Enqueue(item);
		object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3512;
		nint num = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v10 (Il2CppClass<TItem>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v10 (Il2CppClass<TItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v10 (Il2CppClass<TItem>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ff;
		}
		object obj5 = obj4 + 15;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_017e;
		IL_00ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_017e;
		IL_017e:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v7+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v66 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected unsafe virtual void UpdateVisibleItem(TData datum, int order, float offset, ref bool doneSettling)
	{
		//IL_0016: Expected O, but got I
		//IL_002f: Expected I4, but got O
		//IL_002f: Expected O, but got I
		//IL_004d: Expected O, but got I4
		//IL_0055: Expected I, but got F4
		//IL_005d: Expected O, but got Ref
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_0073: Expected I, but got O
		//IL_0078: Expected I, but got O
		//IL_0088: Expected O, but got I
		//IL_0096: Expected O, but got Ref
		//IL_00a2: Expected O, but got Ref
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v2 (Il2CppRgctx<ListView.ListViewController`3>)+130]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		object value;
		bool flag = ((Dictionary<int, object>)0).TryGetValue((int)datum, out value);
		bool flag2 = !flag;
		object obj2 = !flag2;
		nint num2 = (nint)offset;
		object obj3 = (object)(&value);
		if (obj2 == null)
		{
			num2 = (nint)datum;
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<ListView.ListViewController`3<TData, TItem, TIndex>>)+320]");
			obj = 0;
			IntPtr intPtr = default(IntPtr);
			bool newItem = GetNewItem((TData)(&intPtr), out *(TItem*)(&value));
			obj3 = (object)(&value);
		}
		object obj4 = this + 160;
		obj4 = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base.UpdateItem((IListViewItem)value, order, offset, ref doneSettling);
	}

	protected virtual void SetRowGrabbed(TIndex index, Transform rayOrigin, bool grabbed)
	{
		//IL_004a: Expected I4, but got O
		//IL_004a: Expected O, but got I
		//IL_0033: Expected I4, but got O
		//IL_0033: Expected O, but got I
		if (grabbed)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B8]");
			((Dictionary<int, object>)0).set_Item((int)index, (object)rayOrigin);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B8]");
			bool flag = ((Dictionary<int, object>)0).Remove((int)index);
		}
	}

	protected unsafe virtual TItem GetGrabbedRow(Transform rayOrigin)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0038: Expected O, but got I
		//IL_0326: Expected O, but got I
		//IL_0336: Expected O, but got I
		//IL_0346: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_022c: Expected O, but got I4
		//IL_03e7: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_00b7: Expected I, but got O
		//IL_00d5: Expected O, but got I
		//IL_00e5: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_0137: Expected I, but got O
		//IL_0141: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_0167: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_0187: Expected O, but got I
		//IL_01af: Expected O, but got I
		//IL_01cd: Expected O, but got I4
		//IL_030c: Expected O, but got I4
		//IL_0382: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_0394: Expected O, but got I4
		//IL_01f4: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B8]");
		Dictionary<int, object>.Enumerator enumerator = ((Dictionary<int, object>)0).GetEnumerator();
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		Dictionary<int, object>.Enumerator enumerator2 = default(Dictionary<int, object>.Enumerator);
		UnityEngine.Object obj9 = default(UnityEngine.Object);
		Transform transform = default(Transform);
		object obj15 = default(object);
		object obj17 = default(object);
		object obj26 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v14+20]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v15+C0]");
			object obj6 = 0;
			Transform transform2;
			TItem result;
			object obj22;
			object obj23;
			object obj16;
			object obj18;
			if (enumerator2.MoveNext())
			{
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v24+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = obj9 == transform;
				bool flag3 = !flag2;
				num = unchecked((nint)null);
				if (flag3)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v18+20]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v19+C0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v20+1C0]");
				object obj13 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
				bool flag4 = (nint)0 == 0;
				object obj14 = obj15;
				obj16 = obj17;
				num = unchecked((nint)null);
				obj18 = 0;
				transform2 = transform;
				if (flag4)
				{
					goto IL_02a6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v21+20]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v22+C0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v23+130]");
				obj16 = 0;
				ref object reference = ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
				bool flag5 = ((Dictionary<int, object>)0).TryGetValue(0, out reference);
				bool flag6 = !flag5;
				object obj21 = !flag6;
				obj14 = ~obj21;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					result = (TItem)0;
				}
				else
				{
					result = (TItem)null;
				}
				num = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				obj18 = 0;
				obj22 = 0;
				obj23 = 4;
			}
			else
			{
				obj16 = obj17;
				obj18 = 0;
				obj22 = 0;
				result = (TItem)null;
				obj23 = 5;
			}
			goto IL_03c1;
			IL_03c1:
			enumerator2.Dispose();
			bool flag7 = obj22 == null;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				if ((nint)obj23 != 5)
				{
					bool flag8 = obj23 == null;
					object obj25 = !flag8;
					if (obj25 != null)
					{
						goto IL_0399;
					}
				}
				result = (TItem)null;
				goto IL_0399;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			obj16 = obj17;
			num = intPtr;
			transform2 = transform;
			goto IL_02a6;
			IL_02a6:
			NullReferenceException ex2 = new NullReferenceException();
			if ((nint)transform2 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj22 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj18 = obj26;
			result = (TItem)null;
			obj23 = 0;
			goto IL_03c1;
			IL_0399:
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CC9F8C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		TItem result2 = default(TItem);
		return result2;
	}

	protected TItem GetListItem(TIndex index)
	{
		//IL_003f: Expected I4, but got O
		//IL_003f: Expected O, but got I
		//IL_005d: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
			object value;
			bool flag = ((Dictionary<int, object>)0).TryGetValue((int)index, out value);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return (TItem)value;
			}
			return (TItem)null;
		}
		return (TItem)new NullReferenceException();
	}

	protected unsafe virtual bool GetNewItem(TData datum, out TItem item)
	{
		//IL_0010: Expected O, but got I
		//IL_13ba: Expected O, but got Ref
		//IL_13cb: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02f4: Expected O, but got I
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0336: Expected O, but got I4
		//IL_0094: Expected O, but got Ref
		//IL_00c2: Expected O, but got I
		//IL_00e1: Expected O, but got Ref
		//IL_0178: Expected O, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0373: Expected O, but got I
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I4
		//IL_03e4: Expected O, but got I
		//IL_03ec: Expected I, but got O
		//IL_01b9: Expected O, but got I
		//IL_01f5: Expected O, but got Ref
		//IL_01fb: Expected O, but got I
		//IL_044f: Expected I, but got O
		//IL_045f: Expected O, but got I
		//IL_046f: Expected O, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_022d: Expected I, but got O
		//IL_023d: Expected O, but got I
		//IL_04b9: Expected O, but got I
		//IL_04cf: Expected O, but got I
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_04f7: Expected O, but got I4
		//IL_1415: Expected O, but got I
		//IL_142f: Expected O, but got I
		//IL_143f: Expected O, but got I
		//IL_1460: Expected I, but got O
		//IL_0278: Expected O, but got I
		//IL_14a3: Expected I, but got O
		//IL_14b3: Expected O, but got I
		//IL_05df: Expected O, but got I
		//IL_05f5: Expected O, but got I
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_061d: Expected O, but got I4
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_152e: Expected O, but got I
		//IL_156b: Expected O, but got I4
		//IL_053b: Expected O, but got I
		//IL_1589: Expected I, but got O
		//IL_1599: Expected O, but got I
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_0770: Expected I4, but got O
		//IL_07a7: Expected O, but got I
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected O, but got Unknown
		//IL_1614: Expected O, but got I
		//IL_1636: Expected O, but got I4
		//IL_1646: Expected I, but got O
		//IL_0661: Expected O, but got I
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07d9: Expected I, but got O
		//IL_07e9: Expected O, but got I
		//IL_06f7: Expected I, but got O
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected O, but got Unknown
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		//IL_088f: Expected O, but got I
		//IL_08bd: Expected O, but got I4
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected O, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got Unknown
		//IL_099c: Expected I, but got O
		//IL_09ac: Expected O, but got I
		//IL_0824: Expected O, but got I
		//IL_0a52: Expected O, but got I
		//IL_0a80: Expected O, but got I4
		//IL_0b85: Expected O, but got I
		//IL_0b9b: Expected O, but got I
		//IL_0bb1: Expected O, but got I
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Expected O, but got Unknown
		//IL_0bd9: Expected O, but got I4
		//IL_09e7: Expected O, but got I
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected O, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected O, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_093a: Expected O, but got I
		//IL_16b4: Expected I, but got O
		//IL_16c4: Expected O, but got I
		//IL_0ab6: Expected O, but got I
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected O, but got Unknown
		//IL_0c88: Expected O, but got I
		//IL_0cb6: Expected O, but got I4
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Expected O, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected O, but got Unknown
		//IL_0b0c: Expected O, but got I
		//IL_0b57: Expected O, but got I
		//IL_0dab: Expected O, but got I
		//IL_0dc1: Expected O, but got I
		//IL_0dd7: Expected O, but got I
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Expected O, but got Unknown
		//IL_0dff: Expected O, but got I4
		//IL_0c1d: Expected O, but got I
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected O, but got Unknown
		//IL_1715: Expected I, but got O
		//IL_1725: Expected O, but got I
		//IL_0cec: Expected O, but got I
		//IL_0eae: Expected O, but got I
		//IL_0edc: Expected O, but got I4
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected O, but got Unknown
		//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d14: Expected O, but got Unknown
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected O, but got Unknown
		//IL_0d3a: Expected O, but got I
		//IL_0d85: Expected O, but got I
		//IL_0fd7: Expected O, but got I
		//IL_0fed: Expected O, but got I
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffb: Expected O, but got Unknown
		//IL_1015: Expected O, but got I4
		//IL_0e43: Expected O, but got I
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected O, but got Unknown
		//IL_1776: Expected I, but got O
		//IL_1786: Expected O, but got I
		//IL_0f12: Expected O, but got I
		//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2d: Expected O, but got Unknown
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected O, but got Unknown
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected O, but got Unknown
		//IL_0f60: Expected O, but got I
		//IL_0fab: Expected O, but got I
		//IL_17df: Expected O, but got I
		//IL_17f9: Expected O, but got I
		//IL_1059: Expected O, but got I
		//IL_0e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e56: Expected O, but got Unknown
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e64: Expected O, but got Unknown
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bf: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Expected O, but got Unknown
		//IL_10d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10da: Expected O, but got Unknown
		//IL_18d5: Expected O, but got Ref
		//IL_1067: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Expected O, but got Unknown
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Expected O, but got Unknown
		//IL_1116: Expected O, but got I
		//IL_11bf: Expected I, but got O
		//IL_11d8: Expected O, but got I4
		//IL_11f9: Expected O, but got I4
		//IL_1202: Expected I, but got O
		//IL_1151: Expected O, but got I
		//IL_1218: Expected O, but got I
		//IL_1228: Expected O, but got I
		//IL_12c7: Expected O, but got I4
		//IL_12dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e2: Expected O, but got Unknown
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fd: Expected O, but got Unknown
		//IL_1318: Expected I, but got O
		//IL_1333: Expected O, but got I4
		//IL_1354: Expected I, but got O
		//IL_1263: Expected O, but got I
		//IL_115f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1164: Expected O, but got Unknown
		//IL_116d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1172: Expected O, but got Unknown
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_137b: Expected O, but got Unknown
		//IL_1391: Unknown result type (might be due to invalid IL or missing references)
		//IL_1396: Expected O, but got Unknown
		//IL_1271: Unknown result type (might be due to invalid IL or missing references)
		//IL_1276: Expected O, but got Unknown
		//IL_127f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1284: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E0E4F]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A8]");
		bool flag = (nint)0 == 0;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref item);
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		object obj3 = 152961024;
		nint num2 = intPtr;
		object obj8;
		object obj32 = default(object);
		object obj13 = default(object);
		object obj22;
		nint num9;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+8]");
			obj3 = 0;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v13 (Il2CppRgctx<ListView.ListViewController`3>)+1D8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+8]");
			if (!((Dictionary<object, object>)num4).TryGetValue(0, out var value))
			{
				object format = "COORDINATE_TYPE_GCJ_02" + 3632;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+8]");
				string text = string.Format((string)format, 0);
				object obj4 = typeof(DataRelation) + 856;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v18+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object message = text;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					message = text;
				}
				Debug.LogWarning(message);
				ref TItem reference = ref *(TItem*)null;
				return false;
			}
			bool flag3 = value == null;
			obj2 = (object)(&value);
			obj = value;
			num2 = intPtr;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ stack_-B8_v7 (System.Object)+18]");
				Queue<object> queue = (Queue<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ stack_-B8_v7 (System.Object)+18]");
				bool flag4 = (nint)0 == 0;
				obj2 = (object)(&value);
				obj = value;
				num2 = intPtr;
				if (!flag4)
				{
					bool flag5 = queue._size < 0;
					bool flag6 = queue._size == 0;
					int num5 = queue._size ^ queue._size;
					int num6 = queue._size & num5;
					bool flag7 = num6 < 0;
					bool flag8 = flag5 == flag7;
					object obj7 = !flag6;
					obj8 = flag8 & obj7;
					if (queue._size >= 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ stack_-B8_v7 (System.Object)+18]");
						object obj9 = ((Queue<object>)0).Dequeue();
						ref TItem reference = ref *(TItem*)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj3 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
						bool flag9 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
						obj2 = (object)(&value);
						obj = 0;
						num2 = intPtr;
						if (!flag9)
						{
							object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3512;
							nint num7 = (nint)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v85 (Il2CppClass<System.Object>)+12E]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v85 (Il2CppClass<System.Object>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_02c1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v85 (Il2CppClass<System.Object>)+B0]");
							object obj12 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X10_v64-8]");
								if (0 == (nint)obj10)
								{
									break;
								}
								obj13 = obj12 + 16;
								obj11--;
								bool flag10 = (nint)obj11 != 1;
								obj12 = obj13;
								if (flag10)
								{
									continue;
								}
								goto IL_02c1;
							}
							object obj14 = obj12 + 15;
							object obj15 = num7 + obj14;
							object obj16 = obj15 + 312;
							obj13 = obj12;
							goto IL_1405;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ stack_-B8_v7 (System.Object)+10]");
						obj3 = 0;
						Transform transform = base.transform;
						object obj17 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X0_v84+E4]");
						bool flag11 = (nint)0 == 0;
						object obj19 = !flag11;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						obj = (nint)0 + (nint)920;
						num = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
						object obj20 = default(object);
						bool flag12 = obj20 == null;
						obj2 = null;
						num2 = intPtr;
						if (!flag12)
						{
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
							object obj21 = default(object);
							ref TItem reference = ref *(TItem*)obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							num9 = (nint)datum;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+10]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+20]");
							obj = 0;
							obj3 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
							bool flag13 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
							obj2 = null;
							num2 = intPtr;
							if (!flag13)
							{
								nint num10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v74 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
								object obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v74 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
								object obj24 = (nint)0 + (nint)309;
								object obj25 = obj24 & 1;
								bool flag14 = obj25 == null;
								object obj26 = !flag14;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
									object obj27 = default(object);
									obj23 = obj27;
									obj3 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
								}
								nint num11 = (nint)obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X8_v77 (Il2CppClass<System.Object>)+12E]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X8_v77 (Il2CppClass<System.Object>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_0584;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X8_v77 (Il2CppClass<System.Object>)+B0]");
								object obj29 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X10_v52-8]");
									if (0 == (nint)obj23)
									{
										break;
									}
									obj13 = obj29 + 16;
									obj28--;
									bool flag15 = (nint)obj28 != 1;
									obj29 = obj13;
									if (flag15)
									{
										continue;
									}
									goto IL_0584;
								}
								object obj30 = obj29 + 5;
								object obj31 = num11 + obj30;
								obj32 = obj31 + 312;
								obj13 = obj29;
								goto IL_14fc;
							}
						}
					}
				}
			}
		}
		goto IL_1362;
		IL_0b75:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+D0]");
		obj3 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X8_v28 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X8_v28 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj34 = (nint)0 + (nint)309;
		object obj35 = obj34 & 1;
		bool flag16 = obj35 == null;
		object obj36 = !flag16;
		TItem val;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			val = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
			object obj37 = default(object);
			obj33 = obj37;
		}
		nint num13 = (nint)val;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v31 (Il2CppClass<TItem>)+12E]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v31 (Il2CppClass<TItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c66;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v31 (Il2CppClass<TItem>)+B0]");
		obj13 = (nint)0 + (nint)8;
		object obj39;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v55-8]");
			if (0 == (nint)obj33)
			{
				break;
			}
			obj39 = obj13 + 16;
			obj38--;
			bool flag17 = (nint)obj38 != 1;
			obj13 = obj39;
			if (flag17)
			{
				continue;
			}
			goto IL_0c66;
		}
		object obj40 = obj13 + 2;
		object obj41 = num13 + obj40;
		object obj42 = obj41 + 312;
		obj = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X0_v63+8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1194 @ X0_v63] (should have been resolved before IL gen)");
		TItem val2 = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag18 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		obj39 = obj13;
		object obj44;
		obj22 = obj44;
		nint num14;
		num9 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X0_v63+8]");
		obj2 = 0;
		num2 = intPtr;
		if (!flag18)
		{
			goto IL_0d9b;
		}
		goto IL_1362;
		IL_1362:
		throw new NullReferenceException();
		IL_119a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj45 = default(object);
		obj = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1390 @ X0_v39] (should have been resolved before IL gen)");
		nint num15 = (nint)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag19 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		object obj46 = 1;
		obj22 = obj44;
		num9 = num14;
		obj13 = obj39;
		obj2 = 1;
		num2 = (nint)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		if (!flag19)
		{
			goto IL_1210;
		}
		goto IL_1362;
		IL_1210:
		obj = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v9 (System.Object)+12E]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v9 (System.Object)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_12a4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v9 (System.Object)+B0]");
		obj13 = (nint)0 + (nint)8;
		object obj48;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v55-8]");
			bool flag20 = 0 == (nint)obj48;
			obj22 = obj44;
			num9 = num14;
			obj2 = obj46;
			num2 = num15;
			if (flag20)
			{
				break;
			}
			obj13 += 16;
			obj47--;
			if ((nint)obj47 != 1)
			{
				continue;
			}
			goto IL_12a4;
		}
		object obj49 = obj13 + 2;
		object obj50 = obj + obj49;
		object obj51 = obj50 + 312;
		goto IL_18ae;
		IL_0e8c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj52 = default(object);
		obj = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ X0_v51+8]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1247 @ X0_v51] (should have been resolved before IL gen)");
		TItem val3 = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag21 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		object obj54 = !flag21;
		if (obj54 != null)
		{
			goto IL_0fc1;
		}
		obj22 = obj44;
		num9 = num14;
		obj13 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ X0_v51+8]");
		obj2 = 0;
		num2 = intPtr;
		goto IL_1362;
		IL_02c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1405;
		IL_1405:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v105+8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v863 @ X0_v105] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+10]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+20]");
		obj = 0;
		obj3 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag22 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		num9 = (nint)datum;
		num2 = intPtr;
		if (flag22)
		{
			goto IL_1362;
		}
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v90 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v90 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj56 = (nint)0 + (nint)309;
		object obj57 = obj56 & 1;
		bool flag23 = obj57 == null;
		object obj58 = !flag23;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj59 = default(object);
			obj55 = obj59;
			obj3 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		}
		nint num17 = (nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v93 (Il2CppClass<System.Object>)+12E]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v93 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06aa;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v93 (Il2CppClass<System.Object>)+B0]");
		object obj61 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X10_v59-8]");
			if (0 == (nint)obj55)
			{
				break;
			}
			obj13 = obj61 + 16;
			obj60--;
			bool flag24 = (nint)obj60 != 1;
			obj61 = obj13;
			if (flag24)
			{
				continue;
			}
			goto IL_06aa;
		}
		object obj62 = obj61 + 5;
		object obj63 = num17 + obj62;
		object obj64 = obj63 + 312;
		obj13 = obj61;
		goto IL_15e2;
		IL_15e2:
		obj = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X0_v109+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1008 @ X0_v109] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		Dictionary<int, object> dictionary = (Dictionary<int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		bool flag25 = (nint)0 == 0;
		object obj65 = !flag25;
		obj44 = obj22;
		num14 = (nint)datum;
		obj39 = obj13;
		object obj66 = obj8;
		if (obj65 != null)
		{
			goto IL_073f;
		}
		num9 = (nint)datum;
		obj2 = null;
		num2 = intPtr;
		goto IL_1362;
		IL_18c5:
		IntPtr intPtr2 = default(IntPtr);
		OnItemSetup((TData)(&intPtr2), (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item));
		return obj66 == null;
		IL_0fc1:
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ X8_v40 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ X8_v40 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj68 = (nint)0 + (nint)309;
		object obj69 = obj68 & 1;
		bool flag26 = obj69 == null;
		object obj70 = !flag26;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			val3 = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
			object obj71 = default(object);
			obj67 = obj71;
		}
		nint num19 = (nint)val3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1299 @ X8_v43 (Il2CppClass<TItem>)+12E]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1299 @ X8_v43 (Il2CppClass<TItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_10a2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1299 @ X8_v43 (Il2CppClass<TItem>)+B0]");
		object obj73 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1332 @ X10_v26-8]");
			if (0 == (nint)obj67)
			{
				break;
			}
			obj39 = obj73 + 16;
			obj72--;
			bool flag27 = (nint)obj72 != 1;
			obj73 = obj39;
			if (flag27)
			{
				continue;
			}
			goto IL_10a2;
		}
		object obj74 = obj73 + 4;
		object obj75 = num19 + obj74;
		object obj76 = obj75 + 312;
		obj39 = obj73;
		goto IL_17cf;
		IL_086d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj77 = default(object);
		obj = obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v76+8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1051 @ X0_v76] (should have been resolved before IL gen)");
		object obj78 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag28 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		object obj79 = !flag28;
		if (obj79 != null)
		{
			goto IL_0994;
		}
		obj22 = obj44;
		num9 = num14;
		obj13 = obj39;
		obj3 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		num2 = intPtr;
		goto IL_1362;
		IL_0994:
		nint num20 = (nint)obj78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X8_v25 (Il2CppClass<System.Object>)+12E]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X8_v25 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X8_v25 (Il2CppClass<System.Object>)+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v55-8]");
			if (0 == (nint)obj48)
			{
				break;
			}
			obj39 = obj13 + 16;
			obj80--;
			bool flag29 = (nint)obj80 != 1;
			obj13 = obj39;
			if (flag29)
			{
				continue;
			}
			goto IL_0a30;
		}
		object obj81 = obj13 + 6;
		object obj82 = num20 + obj81;
		object obj83 = obj82 + 312;
		obj = obj83;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X0_v72+8]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1124 @ X0_v72] (should have been resolved before IL gen)");
		val = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag30 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		obj39 = obj13;
		obj22 = obj44;
		num9 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X0_v72+8]");
		obj2 = 0;
		obj3 = obj78;
		num2 = intPtr;
		if (!flag30)
		{
			goto IL_0b75;
		}
		goto IL_1362;
		IL_0d9b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+D8]");
		obj3 = 0;
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v34 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v34 (Il2CppRgctx<ListView.ListViewController`3>)+58]");
		object obj86 = (nint)0 + (nint)309;
		object obj87 = obj86 & 1;
		bool flag31 = obj87 == null;
		object obj88 = !flag31;
		if (obj88 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			val2 = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
			object obj89 = default(object);
			obj85 = obj89;
		}
		nint num22 = (nint)val2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X8_v37 (Il2CppClass<TItem>)+12E]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X8_v37 (Il2CppClass<TItem>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e8c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X8_v37 (Il2CppClass<TItem>)+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v55-8]");
			if (0 == (nint)obj85)
			{
				break;
			}
			obj39 = obj13 + 16;
			obj90--;
			bool flag32 = (nint)obj90 != 1;
			obj13 = obj39;
			if (flag32)
			{
				continue;
			}
			goto IL_0e8c;
		}
		object obj91 = obj13 + 3;
		object obj92 = num22 + obj91;
		object obj93 = obj92 + 312;
		obj = obj93;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X0_v54+8]");
		obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1264 @ X0_v54] (should have been resolved before IL gen)");
		val3 = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag33 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		obj39 = obj13;
		obj22 = obj44;
		num9 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X0_v54+8]");
		obj2 = 0;
		num2 = intPtr;
		if (!flag33)
		{
			goto IL_0fc1;
		}
		goto IL_1362;
		IL_10a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_17cf;
		IL_0c66:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj94 = default(object);
		obj = obj94;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X0_v60+8]");
		obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1177 @ X0_v60] (should have been resolved before IL gen)");
		val2 = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag34 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		object obj95 = !flag34;
		if (obj95 != null)
		{
			goto IL_0d9b;
		}
		obj22 = obj44;
		num9 = num14;
		obj13 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X0_v60+8]");
		obj2 = 0;
		num2 = intPtr;
		goto IL_1362;
		IL_17cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1366 @ X0_v32+8]");
		obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1366 @ X0_v32] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A0]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A0]");
		obj3 = (((nint)0 != 0) ? obj66 : null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+A0]");
		if ((nint)0 != 0)
		{
			object obj97 = obj96;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ X8_v46+12E]");
			object obj98 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ X8_v46+12E]");
			if ((nint)0 == 0)
			{
				goto IL_119a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ X8_v46+B0]");
			obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v55-8]");
				if (0 == (nint)obj48)
				{
					break;
				}
				obj39 = obj13 + 16;
				obj98--;
				bool flag35 = (nint)obj98 != 1;
				obj13 = obj39;
				if (flag35)
				{
					continue;
				}
				goto IL_119a;
			}
			object obj99 = obj13 + 1;
			object obj100 = obj97 + obj99;
			object obj101 = obj100 + 312;
			obj = obj101;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1406 @ X0_v42] (should have been resolved before IL gen)");
			num15 = (nint)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
			bool flag36 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
			object obj102 = !flag36;
			obj22 = obj44;
			num9 = num14;
			obj2 = obj46;
			num2 = (nint)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
			if (obj102 != null)
			{
				goto IL_1210;
			}
			goto IL_1362;
		}
		goto IL_18c5;
		IL_0a30:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj103 = default(object);
		obj = obj103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X0_v69+8]");
		obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1107 @ X0_v69] (should have been resolved before IL gen)");
		val = (TItem)System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag37 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		object obj104 = !flag37;
		if (obj104 != null)
		{
			goto IL_0b75;
		}
		obj22 = obj44;
		num9 = num14;
		obj13 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X0_v69+8]");
		obj2 = 0;
		obj3 = obj78;
		num2 = intPtr;
		goto IL_1362;
		IL_18ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v600 @ X0_v7] (should have been resolved before IL gen)");
		obj66 = obj3;
		goto IL_18c5;
		IL_0584:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_14fc;
		IL_14fc:
		obj = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v92+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1020 @ X0_v92] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		dictionary = (Dictionary<int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		bool flag38 = (nint)0 == 0;
		obj44 = obj22;
		num14 = num9;
		obj39 = obj13;
		obj66 = null;
		obj2 = 1;
		num2 = intPtr;
		if (!flag38)
		{
			goto IL_073f;
		}
		goto IL_1362;
		IL_12a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj22 = obj44;
		num9 = num14;
		obj2 = 2;
		num2 = num15;
		goto IL_18ae;
		IL_06aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_15e2;
		IL_073f:
		obj2 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v22 (Il2CppRgctx<ListView.ListViewController`3>)+208]");
		num = 0;
		dictionary.set_Item((int)datum, System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item));
		obj3 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
		bool flag39 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
		obj22 = obj44;
		num9 = num14;
		obj13 = obj39;
		obj = 0;
		num2 = intPtr;
		if (!flag39)
		{
			obj48 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3512;
			nint num24 = (nint)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v23 (Il2CppClass<System.Object>)+12E]");
			object obj105 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v23 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_086d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v23 (Il2CppClass<System.Object>)+B0]");
			obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v55-8]");
				if (0 == (nint)obj48)
				{
					break;
				}
				obj39 = obj13 + 16;
				obj105--;
				bool flag40 = (nint)obj105 != 1;
				obj13 = obj39;
				if (flag40)
				{
					continue;
				}
				goto IL_086d;
			}
			object obj106 = obj13 + 5;
			object obj107 = num24 + obj106;
			object obj108 = obj107 + 312;
			obj = obj108;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X0_v79+8]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1068 @ X0_v79] (should have been resolved before IL gen)");
			obj78 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
			bool flag41 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item) == null;
			obj39 = obj13;
			obj22 = obj44;
			num9 = num14;
			obj3 = System.Runtime.CompilerServices.Unsafe.As<TItem, object>(ref item);
			num2 = intPtr;
			if (!flag41)
			{
				goto IL_0994;
			}
		}
		goto IL_1362;
	}

	protected virtual void OnItemSetup(TData datum, TItem item)
	{
	}

	protected ListViewController()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0164: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<ListView.ListViewController`3>)+C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<ListView.ListViewController`3>)+C8]");
		if ((object)((object)((object)((nint)0 + (nint)309) & 1) != null) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj2 = this + 168;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v8 (Il2CppRgctx<ListView.ListViewController`3>)+10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v8 (Il2CppRgctx<ListView.ListViewController`3>)+10]");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, object> dictionary2 = default(Dictionary<int, object>);
		dictionary2..ctor();
		object obj7 = this + 176;
		obj7 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v14 (Il2CppRgctx<ListView.ListViewController`3>)+120]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v14 (Il2CppRgctx<ListView.ListViewController`3>)+120]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag2 = obj10 == null;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, object> dictionary3 = default(Dictionary<int, object>);
		dictionary3..ctor();
		object obj12 = this + 184;
		obj12 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private IListViewItem<TData, TIndex> <Awake>b__16_0(TIndex index)
	{
		//IL_0042: Expected I4, but got O
		//IL_0042: Expected O, but got I
		//IL_0060: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewController`3<TData, TItem, TIndex>)+B0]");
			object value;
			bool flag = ((Dictionary<int, object>)0).TryGetValue((int)index, out value);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return (IListViewItem<TData, TIndex>)value;
			}
			return null;
		}
		return (IListViewItem<TData, TIndex>)new NullReferenceException();
	}
}
