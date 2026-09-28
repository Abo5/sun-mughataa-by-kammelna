using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Mono.Btls;
using UnityEngine;

namespace UI.Popups;

public static class PopupStack
{
	private record StackItem
	{
		protected virtual Type EqualityContract
		{
			get
			{
				//IL_0009: Expected O, but got I4
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Expected O, but got Unknown
				//IL_0033: Expected O, but got I
				//IL_00d3: Expected O, but got I4
				//IL_00e3: Expected O, but got I
				//IL_0105: Expected O, but got I4
				//IL_0067: Expected O, but got I4
				//IL_0077: Expected O, but got I
				object obj = 152989696;
				object obj2 = typeof(SqlDouble) + 3240;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E5D]");
				object obj3 = (nint)0 & (nint)1;
				RuntimeTypeHandle handle;
				RuntimeTypeHandle handle2;
				if (obj3 != null)
				{
					handle = (RuntimeTypeHandle)obj2;
					object obj4 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v9+E0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v1+E4]");
					bool flag = (nint)0 == 0;
					handle2 = (RuntimeTypeHandle)obj2;
					if (!flag)
					{
						goto IL_00a4;
					}
				}
				else
				{
					_ = 1;
					handle = (RuntimeTypeHandle)obj2;
					object obj6 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+E0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v1+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					handle2 = (RuntimeTypeHandle)obj2;
					if (obj7 != null)
					{
						goto IL_00a4;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return Type.GetTypeFromHandle(handle2);
				IL_00a4:
				return Type.GetTypeFromHandle(handle);
			}
		}

		public GameObject Instance
		{
			get
			{
				return <Instance>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 16;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public Action Action
		{
			get
			{
				return <Action>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 24;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		private readonly GameObject <Instance>k__BackingField;

		private readonly Action <Action>k__BackingField;

		public StackItem(GameObject Instance, Action Action)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			object obj = this + 16;
			obj = Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 24;
			obj2 = Action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			base..ctor();
		}

		public override string ToString()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_00b6: Expected I, but got O
			//IL_00c6: Expected O, but got I
			//IL_00d6: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			StringBuilder stringBuilder = default(StringBuilder);
			stringBuilder..ctor();
			if (stringBuilder != null)
			{
				object value = "SetRoomVariables request error" + 2528;
				object value2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2336;
				StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
				StringBuilder stringBuilder3 = stringBuilder.Append((string)value2);
				if (PrintMembers(stringBuilder))
				{
					StringBuilder stringBuilder4 = stringBuilder.Append(' ');
				}
				StringBuilder stringBuilder5 = stringBuilder.Append('}');
				nint num = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+168]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+170]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X2_v6 (should have been resolved before IL gen)");
			}
			return (string)(object)new NullReferenceException();
		}

		protected virtual bool PrintMembers(StringBuilder builder)
		{
			//IL_0089: Expected I4, but got O
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			RuntimeHelpers.EnsureSufficientExecutionStack();
			if (builder != null)
			{
				object value = "Index = {0} position = {1}" + 1184;
				object value2 = "&action=sign-up" + 3440;
				StringBuilder stringBuilder = builder.Append((string)value);
				StringBuilder stringBuilder2 = builder.Append((object)<Instance>k__BackingField);
				StringBuilder stringBuilder3 = builder.Append((string)value2);
				StringBuilder stringBuilder4 = builder.Append(<Action>k__BackingField);
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public override int GetHashCode()
		{
			//IL_000c: Expected O, but got I
			//IL_00f8: Expected I4, but got O
			//IL_001d: Expected O, but got I
			//IL_005c: Expected O, but got I
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00e5: Expected I4, but got O
			object obj = (nint)0 + (nint)168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
			Type equalityContract = EqualityContract;
			object obj2 = default(object);
			if (obj2 != null)
			{
				object obj3 = (nint)0 + (nint)72;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ X8_v5+1C8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
				object obj5 = default(object);
				if (obj5 != null)
				{
					object obj6 = 0;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X8_v6+1C8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
					object obj8 = default(object);
					if (obj8 != null)
					{
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ X8_v7+1C8] (should have been resolved before IL gen)");
						object obj11 = default(object);
						object obj10 = obj11 * 2773833001L;
						object obj13 = default(object);
						object obj12 = obj13 + obj10;
						object obj14 = obj12 * 2773833001L;
						object obj15 = default(object);
						return (int)(obj15 + obj14);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		public virtual bool Equals(StackItem other)
		{
			//IL_0034: Expected I, but got O
			//IL_0050: Expected O, but got I4
			//IL_0060: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_0132: Expected O, but got I
			//IL_0208: Expected I4, but got O
			//IL_018a: Expected O, but got I
			//IL_01e0: Expected O, but got I
			//IL_01f0: Expected O, but got I
			bool flag;
			if ((object)this != other)
			{
				if ((object)other != null)
				{
					Type equalityContract = EqualityContract;
					nint num = (nint)other;
					Type equalityContract2 = other.EqualityContract;
					object obj = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+E0]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
					if ((nint)0 != 0)
					{
						flag = equalityContract == equalityContract2;
						bool flag2 = !flag;
						object obj3 = !flag2;
						object obj4 = 0;
						Type type = equalityContract2;
						if (obj3 == null)
						{
							goto IL_00cb;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						flag = equalityContract == equalityContract2;
						bool flag3 = !flag;
						object obj4 = 0;
						Type type = equalityContract2;
						if (flag3)
						{
							goto IL_00cb;
						}
					}
					object obj5 = (nint)0 + (nint)72;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
					object obj6 = default(object);
					if (obj6 != null)
					{
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X8_v11+1B8] (should have been resolved before IL gen)");
						if (!flag)
						{
							goto IL_00cb;
						}
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
						object obj9 = default(object);
						if (obj9 != null)
						{
							Action action = other.<Action>k__BackingField;
							Action action2 = <Action>k__BackingField;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v14+1B8]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v14+1C0]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X4_v1 (should have been resolved before IL gen)");
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				return false;
			}
			return true;
			IL_00cb:
			return flag;
		}

		protected StackItem(StackItem original)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			object obj = this + 16;
			obj = original.<Instance>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 24;
			obj2 = original.<Action>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		public unsafe void Deconstruct(out GameObject Instance, out Action Action)
		{
			ref GameObject reference = ref *(GameObject*)<Instance>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ref Action reference2 = ref *(Action*)<Action>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private static readonly List<StackItem> Stack;

	private static bool _isStackEmpty;

	public static void Push(GameObject instance, Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0382: Expected O, but got I4
		//IL_03a0: Expected O, but got I
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_00a4: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_011c: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_0319: Expected O, but got I4
		//IL_029e: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1424;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2904;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
		object obj5 = 0;
		List<object> list = (List<object>)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = default(object);
		object obj6 = obj7 + 16;
		obj6 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj7 + 24;
		obj8 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj7..ctor();
		object obj9 = (nint)0 + (nint)3544;
		object obj10 = obj9;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag2 = list._size < items.Length;
		object obj11 = !flag2;
		nint num;
		object obj17;
		object obj14;
		if (obj11 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj12 = items + list._size;
			object obj13 = obj12 + 32;
			obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v22+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v23+8]");
			bool flag3 = (nint)0 == 1;
			object obj16 = obj7;
			nint num2 = default(nint);
			num = num2;
			obj17 = obj7;
			object obj18 = obj14;
			if (!flag3)
			{
				goto IL_0161;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+20]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v14+C0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v15+70]");
			nint num2 = 0;
			list.AddWithResize(obj7);
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v22+B8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v16+8]");
			bool flag4 = (nint)0 != 1;
			object obj16 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v15+70]");
			num = 0;
			obj17 = obj7;
			object obj18 = obj14;
			if (flag4)
			{
				goto IL_0161;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v16+E4]");
		object obj23;
		if ((nint)0 != 0)
		{
			ShowTopPopup();
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			nint num2 = num;
			object obj16 = obj17;
			obj23 = obj14;
			if (obj22 != null)
			{
				goto IL_018e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ShowTopPopup();
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			if (obj24 != null)
			{
				goto IL_018e;
			}
			nint num2 = num;
			object obj16 = obj17;
			obj23 = obj14;
		}
		goto IL_02c4;
		IL_02c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj14 = obj;
		goto IL_018e;
		IL_018e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v22+B8]");
		object obj25 = 0;
		_ = 0;
		return;
		IL_0161:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		obj23 = obj14;
		if (!flag7)
		{
			goto IL_018e;
		}
		goto IL_02c4;
	}

	private static void Pop()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_0197: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_01e0: Expected O, but got I4
		//IL_026f: Expected O, but got I
		//IL_0286: Expected O, but got I
		//IL_0231: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E5A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ScreenManager screenManager = default(ScreenManager);
		bool flag3 = (object)screenManager == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_01ee;
		IL_01fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v1 (System.NullReferenceException)+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v1 (System.NullReferenceException)+B8]");
			object obj9 = 0;
			_ = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v3+B8]");
			object obj11 = 0;
			_ = 1;
		}
		return;
		IL_00b8:
		obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1424;
		object obj12 = (nint)0 + (nint)2416;
		screenManager.Back();
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+B8]");
		object source = 0;
		bool flag5 = Enumerable.Any((IEnumerable<object>)source);
		NullReferenceException ex = (NullReferenceException)obj2;
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v1 (System.NullReferenceException)+E4]");
			if ((nint)0 != 0)
			{
				ShowTopPopup();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ShowTopPopup();
			return;
		}
		goto IL_01fc;
		IL_01ee:
		ex = new NullReferenceException();
		goto IL_01fc;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)screenManager != null)
		{
			goto IL_00b8;
		}
		goto IL_01ee;
	}

	private static void ShowTopPopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_024b: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_02b5: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_02e5: Expected O, but got I4
		//IL_0304: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_01c3: Expected I, but got O
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_0238: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E5B]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2416;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v46+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2416;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v46+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+B8]");
		object source = 0;
		object obj10 = obj7;
		bool flag3 = Enumerable.Any((IEnumerable<object>)source);
		bool flag4 = !flag3;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			return;
		}
		goto IL_00d7;
		IL_00d7:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v31+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v31+B8]");
		object obj14 = 0;
		object obj15 = ((List<object>)obj14).get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v35 (System.Object)+18]");
		Actions.SafeInvoke((Action)0);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v13+B8]");
		object obj17 = 0;
		object obj18 = (nint)0 + (nint)3552;
		((List<object>)obj17).RemoveAt(0);
		object obj19 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)1448;
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj20);
		object obj21 = typeof(RegisteredWaitHandle) + 3136;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v40+E4]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v35 (System.Object)+10]");
		ScreenManager.PushPopup((GameObject)0, action);
		return;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v46+B8]");
		object source2 = 0;
		obj10 = obj4;
		if (Enumerable.Any((IEnumerable<object>)source2))
		{
			goto IL_00d7;
		}
	}

	static PopupStack()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		object obj = typeof(List<Tween>) + 1128;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = obj2;
		object obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+B8]");
		object obj6 = 0;
		_ = 1;
	}
}
