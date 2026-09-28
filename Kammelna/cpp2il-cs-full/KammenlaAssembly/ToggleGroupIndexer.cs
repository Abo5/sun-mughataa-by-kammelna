using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ToggleGroupIndexer : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Toggle, bool> <>9__4_0;

		public static Action<Toggle> <>9__5_0;

		public static Action<Toggle> <>9__11_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_SelectedIndex>b__4_0(Toggle toggle)
		{
			//IL_0035: Expected I4, but got O
			if ((object)toggle != null)
			{
				return toggle.m_IsOn;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <set_SelectedIndex>b__5_0(Toggle t)
		{
			t.isOn = false;
		}

		internal void <DisableToggles>b__11_0(Toggle item)
		{
			item.interactable = false;
		}
	}

	public Toggle[] Toggles;

	public UnityEvent<int> onSelectionChange;

	private int lastSelected = -1;

	public int SelectedIndex
	{
		get
		{
			//IL_00b9: Expected I4, but got I8
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00d7: Expected O, but got I
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0119: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_0072: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_0151: Expected O, but got I4
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected O, but got Unknown
			//IL_01e7: Expected O, but got I
			//IL_01f8: Expected I, but got O
			//IL_0216: Expected O, but got I
			//IL_0181: Expected O, but got I
			object obj;
			object obj4;
			Func<object, bool> predicate;
			object obj6;
			object obj3;
			if (Toggles != null)
			{
				obj = typeof(SkeletonBinary.SkeletonInput) + 3272;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
				if ((nint)0 != 0)
				{
					obj3 = (nint)0 + (nint)1952;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+8]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj6 = obj3;
						goto IL_012f;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					obj6 = (nint)0 + (nint)1952;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+8]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj3 = obj6;
					if (obj7 == null)
					{
						goto IL_012f;
					}
				}
				goto IL_0186;
			}
			return -1;
			IL_0186:
			return ArraysExtensions.FindIndex(Toggles, predicate);
			IL_012f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v12+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3480;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v11+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = obj6;
			predicate = func;
			goto IL_0186;
		}
		set
		{
			//IL_0053: Expected O, but got I4
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_020a: Expected O, but got I4
			//IL_011a: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00b2: Expected O, but got I
			//IL_00c2: Expected O, but got I
			//IL_00e4: Expected O, but got I4
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Expected O, but got Unknown
			//IL_017c: Expected O, but got I4
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c1: Expected O, but got I
			//IL_02d2: Expected I, but got O
			//IL_02f0: Expected O, but got I
			//IL_0262: Expected O, but got I
			//IL_01ac: Expected O, but got I
			if (Toggles == null)
			{
				return;
			}
			GameObject gameObject = base.gameObject;
			object obj2;
			object obj4;
			Action<object> action;
			if ((object)gameObject != null)
			{
				bool activeInHierarchy = gameObject.activeInHierarchy;
				bool flag = !activeInHierarchy;
				object obj = !flag;
				if (obj == null)
				{
					obj2 = typeof(SkeletonBinary.SkeletonInput) + 3272;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v14+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v14+B8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+10]");
						action = (Action<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+10]");
						bool flag2 = (nint)0 == 0;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							goto IL_015a;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v14+B8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+10]");
						action = (Action<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+10]");
						bool flag3 = (nint)0 == 0;
						object obj6 = !flag3;
						if (obj6 == null)
						{
							goto IL_015a;
						}
					}
					goto IL_01b1;
				}
				goto IL_01c6;
			}
			goto IL_0263;
			IL_015a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v20+B8]");
				obj4 = 0;
			}
			object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3488;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj4, (IntPtr)obj10);
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v19+B8]");
			object obj12 = (nint)0 + (nint)16;
			obj12 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action2;
			goto IL_01b1;
			IL_0271:
			throw new IndexOutOfRangeException();
			IL_0263:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0271;
			IL_01c6:
			Toggle[] toggles = Toggles;
			if (Toggles != null)
			{
				bool flag5 = value < toggles.Length;
				object obj13 = !flag5;
				if (obj13 != null)
				{
					goto IL_0271;
				}
				object obj14 = Toggles + value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+20]");
					((Toggle)0).isOn = true;
					return;
				}
			}
			goto IL_0263;
			IL_01b1:
			ArraysExtensions.ForEach(Toggles, action);
			goto IL_01c6;
		}
	}

	public int SelectedViewIndex
	{
		get
		{
			//IL_0036: Expected I4, but got I8
			//IL_003f: Expected O, but got I4
			//IL_0061: Expected O, but got I
			//IL_009f: Expected O, but got I
			//IL_00f8: Expected O, but got I
			//IL_0112: Expected O, but got I4
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_0154: Expected O, but got I4
			Toggle[] toggles = Toggles;
			if (Toggles != null)
			{
				int num = -1;
				object obj = 0;
				while (true)
				{
					bool flag = (nint)obj >= toggles.Length;
					int num2 = num;
					if (!flag)
					{
						object obj2 = (object)toggles + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+20]");
						Component component = (Component)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+20]");
						bool flag2 = (nint)0 == 0;
						num2 = num;
						if (flag2)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+20]");
						GameObject gameObject = ((Component)0).gameObject;
						bool flag3 = (object)gameObject == null;
						num2 = num;
						if (flag3)
						{
							break;
						}
						bool activeSelf = gameObject.activeSelf;
						num2 = num + (activeSelf ? 1 : 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v5 (UnityEngine.Component)+120]");
						object obj3 = (nint)0 & (nint)1;
						bool flag4 = obj3 == null;
						object obj4 = !flag4;
						if (obj4 == null)
						{
							obj++;
							toggles = Toggles;
							bool flag5 = Toggles == null;
							object obj5 = !flag5;
							num = num2;
							if (obj5 == null)
							{
								break;
							}
							continue;
						}
					}
					return num2;
				}
			}
			throw new NullReferenceException();
		}
	}

	public int GetSelectedViewIndexByOrder(int[] orderArray = null)
	{
		//IL_022a: Expected O, but got I4
		//IL_0237: Expected I4, but got I8
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0061: Expected I4, but got I8
		//IL_006a: Expected O, but got I4
		//IL_0259: Expected O, but got I
		//IL_0297: Expected O, but got I
		//IL_012b: Expected O, but got I
		//IL_00a6: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		//IL_02f0: Expected O, but got I
		//IL_030a: Expected O, but got I4
		//IL_0161: Expected O, but got I
		//IL_0380: Expected I4, but got O
		//IL_00dd: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_034c: Expected O, but got I4
		//IL_01b2: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_020e: Expected O, but got I4
		Toggle[] toggles = Toggles;
		if (Toggles != null)
		{
			int num;
			if (orderArray != null)
			{
				object obj = orderArray + 32;
				num = -1;
				object obj2 = 0;
				while ((nint)obj2 < toggles.Length)
				{
					bool flag = orderArray.Length < 1;
					object obj3 = obj2;
					if (!flag)
					{
						object obj4 = orderArray.Length & 0x7FFFFFFF;
						bool flag2 = obj2 < obj4;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X24_v4+v97 @ X23_v5*4]");
							obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X24_v4+v97 @ X23_v5*4]");
							bool flag3 = (nint)0 < (nint)toggles.Length;
							object obj6 = !flag3;
							if (obj6 == null)
							{
								goto IL_010e;
							}
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						return (int)ex;
					}
					goto IL_010e;
					IL_010e:
					object obj7 = (object)toggles + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+20]");
					Component component = (Component)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+20]");
						GameObject gameObject = ((Component)0).gameObject;
						if ((object)gameObject != null)
						{
							bool activeSelf = gameObject.activeSelf;
							num += (activeSelf ? 1 : 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v8 (UnityEngine.Component)+120]");
							object obj8 = (nint)0 & (nint)1;
							bool flag4 = obj8 == null;
							object obj9 = !flag4;
							if (obj9 != null)
							{
								break;
							}
							obj2++;
							toggles = Toggles;
							bool flag5 = Toggles == null;
							object obj10 = !flag5;
							if (obj10 != null)
							{
								continue;
							}
						}
					}
					goto IL_0362;
				}
			}
			else
			{
				object obj11 = 0;
				int num2 = -1;
				while (true)
				{
					bool flag6 = (nint)obj11 >= toggles.Length;
					num = num2;
					if (flag6)
					{
						break;
					}
					object obj12 = (object)toggles + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v5+20]");
					Component component2 = (Component)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v5+20]");
					bool flag7 = (nint)0 == 0;
					num = num2;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v5+20]");
						GameObject gameObject2 = ((Component)0).gameObject;
						bool flag8 = (object)gameObject2 == null;
						num = num2;
						if (!flag8)
						{
							bool activeSelf2 = gameObject2.activeSelf;
							num = num2 + (activeSelf2 ? 1 : 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X21_v6 (UnityEngine.Component)+120]");
							object obj13 = (nint)0 & (nint)1;
							bool flag9 = obj13 == null;
							object obj14 = !flag9;
							if (obj14 != null)
							{
								break;
							}
							toggles = Toggles;
							obj11++;
							bool flag10 = Toggles == null;
							object obj15 = !flag10;
							num2 = num;
							if (obj15 != null)
							{
								continue;
							}
						}
					}
					goto IL_0362;
				}
			}
			return num;
		}
		goto IL_0362;
		IL_0362:
		throw new NullReferenceException();
	}

	private void Awake()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		Toggle[] toggles = Toggles;
		if (toggles.Length >= 1)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 360;
			object obj2 = (nint)0 + (nint)152;
			object obj3 = toggles + 32;
			object obj4 = (nint)0 + (nint)832;
			object obj5 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X26_v4+v93 @ X23_v5*8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
				obj5++;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
			}
			while ((nint)obj5 < toggles.Length);
		}
	}

	private void OnToggleChanged(bool isOn)
	{
		int arg = (lastSelected = SelectedIndex);
		if (onSelectionChange != null)
		{
			onSelectionChange.Invoke(arg);
		}
	}

	public void DisableToggles()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0281: Expected O, but got I
		//IL_0292: Expected I, but got O
		//IL_02b0: Expected O, but got I
		//IL_0244: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AFB]");
		object obj3 = (nint)0 & (nint)1;
		Toggle[] toggles;
		Toggle[] toggles2;
		object obj4;
		if (obj3 != null)
		{
			toggles = Toggles;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			toggles2 = Toggles;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			toggles = Toggles;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			toggles2 = Toggles;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+18]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+18]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = toggles2;
		object obj10 = obj7;
		IEnumerable<object> enumeration = toggles2;
		if (obj9 == null)
		{
			goto IL_01f2;
		}
		goto IL_0249;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3472;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)24;
		obj16 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		action = action2;
		enumeration = enumerable;
		goto IL_0249;
		IL_0249:
		ArraysExtensions.ForEach(enumeration, action);
		return;
		IL_0099:
		obj10 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+18]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+18]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		enumeration = toggles;
		if (obj17 == null)
		{
			obj7 = obj10;
			enumerable = toggles;
			goto IL_01f2;
		}
		goto IL_0249;
	}

	public void SetIsOnWithoutNotify(int indexOfOn)
	{
		//IL_0022: Expected O, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_009e: Expected O, but got I4
		lastSelected = indexOfOn;
		Toggle[] toggles = Toggles;
		object obj = 0;
		while ((nint)obj < toggles.Length)
		{
			object obj2 = (object)toggles + obj;
			object obj3 = indexOfOn - obj;
			bool isOnWithoutNotify = obj3 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v5+20]");
			((Toggle)0).SetIsOnWithoutNotify(isOnWithoutNotify);
			toggles = Toggles;
			obj++;
			bool flag = Toggles == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
	}
}
