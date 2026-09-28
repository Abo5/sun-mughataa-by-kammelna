using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class RadialLayout : MonoBehaviour
{
	private float arc = 360f;

	private bool isClockWise;

	private bool reverseArrangement;

	private int clockWiseDir
	{
		get
		{
			//IL_002f: Expected I4, but got I8
			//IL_001d: Expected I4, but got I8
			if (!isClockWise)
			{
				return 1;
			}
			return -1;
		}
	}

	private float remainingArc => 1.13587E+09f - arc;

	private void Update()
	{
		//IL_0095: Expected O, but got I4
		//IL_0191: Invalid comparison between F8 and I4
		//IL_01a0: Invalid comparison between F8 and I4
		//IL_01b3: Expected O, but got F8
		//IL_01c0: Expected O, but got F8
		//IL_01f5: Expected O, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0232: Expected O, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0272: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_0103: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		Transform transform = base.transform;
		int childCount = transform.childCount;
		int num = childCount - 1;
		if (childCount < 1)
		{
			return;
		}
		double num2 = 1.0 / (double)childCount;
		double num3 = num2 * 1135869952.0;
		int num4 = 0;
		Vector3 euler = default(Vector3);
		object obj15;
		do
		{
			Transform transform2 = base.transform;
			bool flag = !reverseArrangement;
			object obj = !flag;
			object obj2 = ~obj;
			int index = ((obj2 != null) ? num4 : num);
			Transform child = transform2.GetChild(index);
			float num5 = 1.13587E+09f - arc;
			double num6 = (double)num5 - num3;
			bool flag2 = num6 < 0.0;
			bool flag3 = num6 == 0.0;
			object obj3 = (double)num5 ^ num3;
			object obj4 = (double)num5 ^ num6;
			object obj5 = obj3 & obj4;
			bool flag4 = (nint)obj5 < 0;
			bool flag5 = flag2 == flag4;
			object obj6 = !flag3;
			object obj7 = flag5 & obj6;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
			}
			bool flag6 = flag2 == flag4;
			object obj9 = !flag3;
			object obj10 = flag6 & obj9;
			object obj11 = ~obj10;
			if (obj11 == null)
			{
			}
			bool flag7 = !isClockWise;
			object obj12 = !flag7;
			object obj13 = ~obj12;
			if (obj13 == null)
			{
			}
			child.localPosition = (Vector3)0;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			child.localRotation = (Quaternion)0;
			num4++;
			num--;
			object obj14 = num + 1;
			bool flag8 = obj14 == null;
			obj15 = !flag8;
		}
		while (obj15 != null);
	}

	public void DoArc(float arcTo, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00e0: Expected I, but got O
		//IL_0067: Expected I, but got O
		//IL_0091: Expected O, but got I4
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
		object obj2 = (nint)0 + (nint)1264;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
		object obj4 = (nint)0 + (nint)1272;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<float> dOGetter = default(DOGetter<float>);
		dOGetter..ctor((object)this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<float> dOSetter = default(DOSetter<float>);
		dOSetter..ctor((object)this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, arcTo, duration);
	}

	private float <DoArc>b__8_0()
	{
		return arc;
	}

	private void <DoArc>b__8_1(float x)
	{
		arc = x;
	}
}
