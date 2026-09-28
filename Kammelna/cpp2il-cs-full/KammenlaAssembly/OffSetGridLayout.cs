using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class OffSetGridLayout : MonoBehaviour
{
	private sealed class <ResizeParent>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public int cols;

		public OffSetGridLayout <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <ResizeParent>d__9(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_00fc: Expected O, but got I4
			//IL_005a: Expected I4, but got I8
			//IL_013a: Expected I4, but got O
			//IL_00c2: Expected O, but got I4
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					OffSetGridLayout offSetGridLayout = <>4__this;
					<>1__state = -1;
					if ((object)<>4__this == null || (object)offSetGridLayout._rectTransform == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					offSetGridLayout._rectTransform.sizeDelta = (Vector2)0;
					<>4__this.Update();
				}
				return <>1__state == 0;
			}
			object obj = this + 24;
			obj = 0;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private Vector2 space;

	private Vector2 cellSize;

	private int rows;

	private RectTransform _rectTransform;

	private Transform _parentTransform;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 56;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform parent = ((Transform)obj2).parent;
		object obj4 = this + 64;
		obj4 = parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ApplyLayout();
	}

	private void Update()
	{
		//IL_002f: Expected O, but got I
		//IL_00a3: Expected O, but got I4
		Vector3 position = _parentTransform.position;
		Transform rectTransform = _rectTransform;
		object obj = (nint)0 + (nint)4040;
		int num = 0;
		Vector3 centerPosition = default(Vector3);
		while (true)
		{
			int childCount = rectTransform.childCount;
			if (num < childCount)
			{
				Transform child = _rectTransform.GetChild(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				UpdateChildTransformAndGraphic(centerPosition, null);
				num++;
				rectTransform = _rectTransform;
				bool flag = (object)_rectTransform == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			break;
		}
	}

	private void UpdateChildTransformAndGraphic(Vector3 centerPosition, RectTransform child)
	{
		//IL_00a0: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_012b: Expected O, but got I4
		//IL_0154: Expected O, but got I
		//IL_0202: Invalid comparison between F8 and I4
		//IL_0211: Invalid comparison between F8 and I4
		//IL_0229: Expected O, but got F8
		//IL_0236: Expected O, but got F8
		//IL_026b: Expected O, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_036a: Invalid comparison between F8 and I4
		//IL_038f: Expected O, but got I4
		//IL_02b7: Expected F8, but got I4
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0305: Expected O, but got I4
		//IL_03ae: Expected O, but got I
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		Vector3 position = ((Transform)centerPosition).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		object obj2 = default(object);
		object obj3 = default(object);
		object obj = obj2 - obj3;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj4 = obj2 ^ obj3;
		object obj5 = obj2 ^ obj;
		object obj6 = obj4 & obj5;
		bool flag3 = (nint)obj6 < 0;
		bool flag4 = flag == flag3;
		object obj7 = !flag2;
		object obj8 = flag4 & obj7;
		object obj9 = ~obj8;
		object obj10 = ((obj9 != null) ? obj3 : obj2);
		object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = _rectTransform.rect;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = (nint)0 + (nint)688;
		object obj15 = default(object);
		double num = (double)obj15 * 0.5;
		double num2 = num * num;
		Rect rect2 = _rectTransform.rect;
		double num4 = default(double);
		double num3 = num4 * 0.5;
		double num5 = num3 * num3;
		double num6 = num2 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num7 = (double)obj10 / num6;
		double num8 = 1.0 - num7;
		double num9 = num8 - 1.0;
		bool flag6 = num9 < 0.0;
		bool flag7 = num9 == 0.0;
		object obj16 = num8 ^ 1.0;
		object obj17 = num8 ^ num9;
		object obj18 = obj16 & obj17;
		bool flag8 = (nint)obj18 < 0;
		bool flag9 = flag6 == flag8;
		object obj19 = !flag7;
		object obj20 = flag9 & obj19;
		object obj21 = ~obj20;
		double num10 = ((obj21 != null) ? num8 : 1.0);
		if (num8 < 0.0)
		{
			double num11 = 0.0;
		}
		else
		{
			double num11 = num10;
		}
		((Transform)centerPosition).localScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v14+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj23 = default(object);
			object obj22 = obj23 + 32;
			object obj24 = 0;
			object obj28;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v4+v148 @ X21_v8*8]");
				object obj25 = 0;
				obj24++;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v293 @ X8_v8+298] (should have been resolved before IL gen)");
				object obj27 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ X8_v9+2A8] (should have been resolved before IL gen)");
				obj28 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v14+18]");
			}
			while ((nint)obj28 < 0);
		}
	}

	public unsafe void ApplyLayout()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0096: Expected F8, but got I4
		//IL_1148: Expected I, but got O
		//IL_1158: Expected F8, but got I
		//IL_01ae: Expected O, but got I4
		//IL_0fed: Expected native int or pointer, but got F8
		//IL_0ff6: Expected I, but got F8
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_0f38: Expected O, but got I
		//IL_0f59: Expected O, but got I4
		//IL_0f79: Invalid comparison between F8 and I4
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected I4, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Expected I4, but got Unknown
		//IL_140f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1414: Expected O, but got Unknown
		//IL_141c: Expected I4, but got O
		//IL_01bb: Expected F8, but got O
		//IL_1197: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00f5: Invalid comparison between F8 and I4
		//IL_0106: Expected O, but got I4
		//IL_011f: Invalid comparison between F8 and I4
		//IL_012e: Invalid comparison between F8 and I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected I4, but got Unknown
		//IL_014f: Expected I4, but got F8
		//IL_0174: Invalid comparison between F8 and I4
		//IL_0733: Expected I, but got O
		//IL_0743: Expected O, but got I
		//IL_0214: Expected I, but got O
		//IL_0224: Expected F8, but got I
		//IL_0830: Invalid comparison between F8 and I4
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected O, but got Unknown
		//IL_0851: Expected O, but got F8
		//IL_0891: Expected O, but got I4
		//IL_07da: Expected O, but got I4
		//IL_0354: Expected O, but got I4
		//IL_08b5: Expected F8, but got I4
		//IL_077e: Expected O, but got I
		//IL_1100: Expected native int or pointer, but got F8
		//IL_1109: Expected I, but got F8
		//IL_025f: Expected O, but got I
		//IL_0e4e: Expected I4, but got O
		//IL_122b: Expected O, but got I4
		//IL_1244: Invalid comparison between F8 and I4
		//IL_1253: Invalid comparison between F8 and I4
		//IL_1262: Unknown result type (might be due to invalid IL or missing references)
		//IL_1267: Expected I4, but got Unknown
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1274: Expected I4, but got Unknown
		//IL_11b5: Expected O, but got I
		//IL_104b: Expected O, but got I
		//IL_106c: Expected O, but got I4
		//IL_108c: Invalid comparison between F8 and I4
		//IL_10b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected I4, but got Unknown
		//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d2: Expected I4, but got Unknown
		//IL_0e65: Expected I4, but got O
		//IL_08d4: Expected I, but got F8
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected O, but got Unknown
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected I, but got Unknown
		//IL_03a1: Expected native int or pointer, but got F8
		//IL_03aa: Expected I4, but got F8
		//IL_03b2: Expected I, but got O
		//IL_03c2: Expected O, but got I
		//IL_03d2: Expected F8, but got I
		//IL_03fb: Expected O, but got I4
		//IL_0423: Invalid comparison between F8 and I4
		//IL_0432: Invalid comparison between F8 and I4
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected I4, but got Unknown
		//IL_048f: Expected I4, but got O
		//IL_12d4: Expected F8, but got I4
		//IL_12e9: Expected F8, but got I8
		//IL_08c7: Expected I, but got I8
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_029b: Invalid comparison between F8 and I4
		//IL_02ac: Expected O, but got I4
		//IL_02c5: Invalid comparison between F8 and I4
		//IL_02d4: Invalid comparison between F8 and I4
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected I4, but got Unknown
		//IL_02f5: Expected I4, but got F8
		//IL_031a: Invalid comparison between F8 and I4
		//IL_04fd: Expected O, but got I4
		//IL_051d: Invalid comparison between F8 and I4
		//IL_052c: Invalid comparison between F8 and I4
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected I4, but got Unknown
		//IL_091a: Expected O, but got I
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected O, but got Unknown
		//IL_09a8: Expected O, but got I
		//IL_09e5: Expected O, but got I4
		//IL_0a02: Expected F8, but got I8
		//IL_0a8a: Expected O, but got I4
		//IL_0aa2: Invalid comparison between F8 and I4
		//IL_0ab1: Invalid comparison between F8 and I4
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected I4, but got Unknown
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d70: Expected O, but got Unknown
		//IL_13e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ec: Expected O, but got Unknown
		//IL_067c: Expected O, but got I
		//IL_0b7b: Expected O, but got I4
		//IL_0bb6: Expected O, but got I4
		//IL_0bf4: Expected O, but got I4
		//IL_0a42: Expected O, but got I4
		//IL_0a54: Expected O, but got I4
		//IL_0c4a: Expected O, but got I4
		//IL_0cb4: Invalid comparison between F8 and I4
		//IL_0cc5: Expected O, but got I4
		//IL_0cde: Invalid comparison between F8 and I4
		//IL_0ced: Invalid comparison between F8 and I4
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Expected I4, but got Unknown
		//IL_0d0e: Expected I4, but got F8
		//IL_0d33: Invalid comparison between F8 and I4
		//IL_1329: Expected O, but got I
		//IL_137f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1384: Expected O, but got Unknown
		//IL_13a1: Expected O, but got I4
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13af: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7399]");
		nint num = 0;
		bool flag = (object)_rectTransform == null;
		Component component = null;
		IntPtr intPtr = default(IntPtr);
		int num2 = (int)(nint)intPtr;
		int num3 = 152989696;
		bool flag3 = default(bool);
		object obj2 = default(object);
		object obj3 = default(object);
		double num9 = default(double);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		bool flag7 = default(bool);
		object obj4 = default(object);
		object obj8;
		object obj9;
		object obj10 = default(object);
		bool flag15;
		bool flag16;
		int num23;
		int num24;
		int num25;
		bool flag17;
		bool flag18;
		double num26;
		object obj11;
		object obj12;
		int num4;
		if (!flag)
		{
			IEnumerator enumerator = _rectTransform.GetEnumerator();
			flag = enumerator == null;
			component = null;
			num4 = 0;
			num2 = 0;
			num = (nint)(&component);
			if (flag)
			{
				goto IL_0ec3;
			}
			Component component2 = (Component)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
			double num5 = (double)typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952.0;
			double num6 = 0.0;
			IEnumerator enumerator2 = enumerator;
			double num14 = default(double);
			object obj6 = default(object);
			IEnumerator enumerator3 = default(IEnumerator);
			double num17 = default(double);
			Component component3 = default(Component);
			double num8;
			while (true)
			{
				nint num7 = (nint)enumerator2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v11 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				num8 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v11 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_019b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v11 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj = (nint)0 + (nint)8;
				bool flag2 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v26-8]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v26-8]");
					bool flag4 = 0 < (nint)component2;
					obj3 = !flag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v26-8]");
					num9 = 0.0 - (double)component2;
					flag5 = num9 < 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v26-8]");
					flag6 = 0 == (nint)component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v26-8]");
					num10 = 0 ^ component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v26-8]");
					num11 = 0 ^ num9;
					num12 = num10 & num11;
					flag7 = num12 < 0;
					if (flag6)
					{
						break;
					}
					obj4 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v11 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					num8 = 0.0 - 1.0;
					bool flag8 = num8 < 1.0;
					obj3 = !flag8;
					num9 = num8 - 1.0;
					flag5 = num9 < 0.0;
					flag6 = num9 == 0.0;
					num10 = num8 ^ 1;
					num11 = num8 ^ num9;
					num12 = num10 & num11;
					flag7 = num12 < 0;
					flag3 = num8 != 1.0;
					flag2 = flag3;
					obj = obj4;
					if (flag3)
					{
						continue;
					}
					goto IL_019b;
				}
				num8 = (double)obj;
				double num13 = (double)num7 + (double)obj;
				num14 = num13 + 312.0;
				flag3 = flag2;
				obj4 = obj;
				goto IL_0fe9;
				IL_0fe9:
				num = (nint)((double*)(nint)num14)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X0_v13 (System.Double)+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v528.m_value (System.Double) (should have been resolved before IL gen)");
				object obj5 = obj6 & 1;
				if (obj5 == null)
				{
					break;
				}
				if (enumerator3 == null)
				{
					goto IL_0dc3;
				}
				nint num15 = (nint)enumerator3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v32 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				num8 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v32 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0341;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v32 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				bool flag9 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v21-8]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v21-8]");
					bool flag10 = 0 < (nint)component2;
					obj3 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v21-8]");
					num9 = 0.0 - (double)component2;
					flag5 = num9 < 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v21-8]");
					flag6 = 0 == (nint)component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v21-8]");
					num10 = 0 ^ component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v21-8]");
					num11 = 0 ^ num9;
					num12 = num10 & num11;
					flag7 = num12 < 0;
					if (flag6)
					{
						break;
					}
					obj4 = obj7 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v32 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					num8 = 0.0 - 1.0;
					bool flag11 = num8 < 1.0;
					obj3 = !flag11;
					num9 = num8 - 1.0;
					flag5 = num9 < 0.0;
					flag6 = num9 == 0.0;
					num10 = num8 ^ 1;
					num11 = num8 ^ num9;
					num12 = num10 & num11;
					flag7 = num12 < 0;
					flag3 = num8 != 1.0;
					flag9 = flag3;
					obj7 = obj4;
					if (flag3)
					{
						continue;
					}
					goto IL_0341;
				}
				num8 = (double)obj7 + 1.0;
				double num16 = (double)num15 + num8;
				num17 = num16 + 312.0;
				flag3 = flag9;
				obj4 = obj7;
				goto IL_10fc;
				IL_10fc:
				num = (nint)((double*)(nint)num17)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v58 (System.Double)+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v667.m_value (System.Double) (should have been resolved before IL gen)");
				if ((object)component3 != null)
				{
					num2 = (int)((double*)(nint)num5)->m_value;
					num = (nint)component3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)+130]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X1_v2 (System.Int32)+130]");
					num8 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)+130]");
					nint num18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X1_v2 (System.Int32)+130]");
					bool flag12 = num18 < 0;
					obj3 = !flag12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)+130]");
					double num19 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X1_v2 (System.Int32)+130]");
					num9 = num19 - 0.0;
					flag5 = num9 < 0.0;
					flag6 = num9 == 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)+130]");
					nint num20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X1_v2 (System.Int32)+130]");
					num10 = (int)(num20 ^ 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)+130]");
					num11 = 0 ^ num9;
					num12 = num10 & num11;
					flag7 = num12 < 0;
					flag3 = (byte)(int)(~obj3) != 0;
					component = null;
					num4 = 0;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)+C8]");
						double num21 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X1_v2 (System.Int32)+130]");
						double num22 = num21 + 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v37 (System.Double)-8]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v37 (System.Double)-8]");
						bool flag13 = (nint)0 < (nint)num2;
						obj3 = !flag13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v37 (System.Double)-8]");
						num9 = 0.0 - (double)num2;
						flag5 = num9 < 0.0;
						flag6 = num9 == 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v37 (System.Double)-8]");
						num10 = (int)((nint)0 ^ (nint)num2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v37 (System.Double)-8]");
						num11 = 0 ^ num9;
						num12 = num10 & num11;
						flag7 = num12 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v37 (System.Double)-8]");
						flag3 = (nint)0 != num2;
						component = null;
						num4 = 0;
						if (!flag3)
						{
							GameObject gameObject = component3.gameObject;
							if ((object)gameObject != null)
							{
								bool activeSelf = gameObject.activeSelf;
								num6 += (double)(activeSelf ? 1 : 0);
								bool flag14 = enumerator3 == null;
								flag = !flag14;
								obj8 = obj2;
								component = null;
								obj9 = obj10;
								flag15 = flag3;
								flag16 = flag7;
								num23 = num12;
								num24 = num11;
								num25 = num10;
								flag17 = flag6;
								flag18 = flag5;
								num26 = num9;
								obj11 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)+130]");
								obj12 = 0;
								num4 = 0;
								num2 = 0;
								enumerator2 = enumerator3;
								if (flag)
								{
									continue;
								}
								goto IL_06a6;
							}
							goto IL_0de1;
						}
					}
					goto IL_0d97;
				}
				goto IL_0da5;
				IL_0341:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj10 = 1;
				goto IL_10fc;
				IL_019b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj10 = 0;
				goto IL_0fe9;
			}
			num4 = 0;
			num3 = 0;
			Component component4 = default(Component);
			object obj17 = default(object);
			IntPtr intPtr2 = default(IntPtr);
			while (true)
			{
				component2 = (Component)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344);
				num2 = (int)component2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				if ((object)component4 == null)
				{
					goto IL_117d;
				}
				nint num27 = (nint)component4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v27 (Il2CppClass<UnityEngine.Component>)+12E]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v27 (Il2CppClass<UnityEngine.Component>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_07c7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v27 (Il2CppClass<UnityEngine.Component>)+B0]");
				object obj14 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X10_v14-8]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X10_v14-8]");
					if (0 == (nint)component2)
					{
						break;
					}
					obj4 = obj14 + 16;
					obj13--;
					bool flag19 = (nint)obj13 != 1;
					obj14 = obj4;
					if (flag19)
					{
						continue;
					}
					goto IL_07c7;
				}
				object obj15 = num27 + obj14;
				num = (nint)(obj15 + 312);
				obj4 = obj14;
				goto IL_11d9;
				IL_117d:
				bool flag20 = num3 == 0;
				object obj16 = !flag20;
				if (obj16 != null)
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					if (num2 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						num3 = (int)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						num4 = (int)obj17;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
				}
				break;
				IL_07c7:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj10 = 0;
				component2 = component4;
				num = intPtr2;
				goto IL_11d9;
				IL_11d9:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v571 @ X8_v15 (Il2CppClass<UnityEngine.Component>)] (should have been resolved before IL gen)");
				goto IL_117d;
			}
			double num28 = num6 - 3.0;
			bool flag21 = num28 < 0.0;
			object obj18 = num6 ^ 3;
			object obj19 = num6 ^ num28;
			object obj20 = obj18 & obj19;
			bool flag22 = (nint)obj20 < 0;
			bool flag23 = flag21 == flag22;
			flag3 = !flag23;
			object obj21 = !flag3;
			num5 = ((obj21 != null) ? 3.0 : num6);
			double num29 = num6 / num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			Vector2 vector = default(Vector2);
			bool flag24 = (nint)vector < 2139095040;
			obj3 = !flag24;
			num9 = (double)vector - 2139095040.0;
			flag5 = num9 < 0.0;
			flag6 = num9 == 0.0;
			num10 = vector ^ 0x7F800000;
			num11 = vector ^ num9;
			num12 = num10 & num11;
			flag7 = num12 < 0;
			bool flag25 = (nint)vector != 2139095040;
			nint num30 = (nint)(flag25 ? ((nint)num29) : 2147483648L);
			Transform rectTransform = _rectTransform;
			flag = (object)_rectTransform == null;
			double num31 = 2139095040.0;
			component = component4;
			num8 = 2147483648.0;
			if (!flag)
			{
				Vector2 vector2 = cellSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (OffSetGridLayout)+2C]");
				double num32 = 0.0 * num5;
				double num33 = num5 - 1.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (OffSetGridLayout)+24]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (OffSetGridLayout)+24]");
				double num34 = 0.0 * num33;
				double num35 = num32 + num34;
				double num36 = num35 * 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (OffSetGridLayout)+2C]");
				double num37 = 0.0 * 0.5;
				double num38 = num36 - num37;
				nint num39 = num30 - 1;
				object obj23 = cellSize * num30;
				object obj24 = (nint)0 + (nint)4040;
				double num40 = (double)space * (double)num39;
				double num41 = (double)obj23 + num40;
				double num42 = num41 * 0.5;
				object obj25 = 0;
				bool flag26 = flag25;
				object obj26 = obj10;
				double num43 = 2147483648.0;
				int num44 = 0;
				Component component5 = default(Component);
				object obj28 = default(object);
				do
				{
					int childCount = rectTransform.childCount;
					bool flag27 = num44 < childCount;
					obj3 = !flag27;
					num9 = (double)num44 - (double)childCount;
					flag5 = num9 < 0.0;
					flag6 = num9 == 0.0;
					num10 = num44 ^ childCount;
					num11 = num44 ^ num9;
					num12 = num10 & num11;
					flag7 = num12 < 0;
					flag3 = num44 >= childCount;
					if (!flag3)
					{
						flag = (object)_rectTransform == null;
						component = component4;
						obj10 = obj26;
						num2 = 0;
						if (flag)
						{
							break;
						}
						Transform child = _rectTransform.GetChild(num44);
						flag = (object)child == null;
						component = component4;
						obj10 = 0;
						if (flag)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						flag = (object)component5 == null;
						component = component4;
						obj10 = 0;
						if (flag)
						{
							break;
						}
						GameObject gameObject2 = component5.gameObject;
						flag = (object)gameObject2 == null;
						component = component4;
						obj10 = 0;
						num2 = 0;
						if (flag)
						{
							break;
						}
						bool activeSelf2 = gameObject2.activeSelf;
						bool flag28 = !activeSelf2;
						num2 = 0;
						if (!flag28)
						{
							((RectTransform)component5).sizeDelta = (Vector2)0;
							double num45 = (double)obj25 / num5;
							double num46 = num45 * num5;
							num43 = (double)obj25 - num46;
							double num47 = (double)cellSize * 0.5;
							double num48 = num47 - num42;
							double num49 = num47 + num48;
							bool flag29 = num43 < 1.0;
							obj3 = !flag29;
							num9 = num43 - 1.0;
							flag5 = num9 < 0.0;
							flag6 = num9 == 0.0;
							num10 = num43 ^ 1;
							num11 = num43 ^ num9;
							num12 = num10 & num11;
							flag7 = num12 < 0;
							if (num43 != 1.0)
							{
								num49 = num48;
							}
							double num50 = (double)cellSize * num45;
							double num51 = num50 + num49;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (OffSetGridLayout)+24]");
							obj22 = 0;
							double num52 = (double)space * num45;
							num41 = num52 + num51;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (OffSetGridLayout)+2C]");
							double num53 = 0.0 * num43;
							double num54 = num38 - num53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (OffSetGridLayout)+24]");
							vector2 = (Vector2)(0 * num43);
							num40 = num54 - (double)vector2;
							((RectTransform)component5).anchoredPosition = (Vector2)0;
							obj25++;
							num34 = num45;
							num2 = 0;
						}
						num44++;
						rectTransform = _rectTransform;
						flag = (object)_rectTransform == null;
						obj26 = 0;
						component = component4;
						obj10 = 0;
						continue;
					}
					object obj27 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1448;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj28..ctor();
					_ = 0;
					object obj29 = obj28 + 40;
					obj29 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Coroutine coroutine = StartCoroutine((IEnumerator)obj28);
					return;
				}
				while (!flag);
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0d97;
		IL_06a6:
		NullReferenceException ex3 = new NullReferenceException();
		obj2 = obj8;
		obj10 = obj9;
		flag3 = flag15;
		flag7 = flag16;
		num12 = num23;
		num11 = num24;
		num10 = num25;
		flag6 = flag17;
		flag5 = flag18;
		num9 = num26;
		obj3 = obj11;
		obj4 = obj12;
		goto IL_0ec3;
		IL_0ec3:
		obj8 = obj2;
		obj9 = obj10;
		flag15 = flag3;
		flag16 = flag7;
		num23 = num12;
		num24 = num11;
		num25 = num10;
		flag17 = flag6;
		flag18 = flag5;
		num26 = num9;
		obj11 = obj3;
		obj12 = obj4;
		goto IL_06a6;
		IL_0d97:
		InvalidCastException ex4 = new InvalidCastException();
		goto IL_0ec3;
		IL_0dc3:
		NullReferenceException ex5 = new NullReferenceException();
		component = null;
		num4 = 0;
		goto IL_0ec3;
		IL_0de1:
		NullReferenceException ex6 = new NullReferenceException();
		component = null;
		num4 = 0;
		num2 = 0;
		goto IL_0ec3;
		IL_0da5:
		NullReferenceException ex7 = new NullReferenceException();
		component = null;
		num4 = 0;
		goto IL_0ec3;
	}

	private IEnumerator ResizeParent(int cols)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public OffSetGridLayout()
	{
		//IL_0012: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EA0]");
		space = (Vector2)0;
		rows = 3;
		base..ctor();
	}
}
