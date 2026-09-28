using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class CounterBubbleText : MonoBehaviour
{
	private TextMeshProUGUI text;

	private CounterBubbleType type;

	private bool useExtra;

	private string extra;

	private RectTransform container;

	private bool playSound;

	private AudioSource sound;

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)152;
		Transform transform = base.transform;
		RectTransform rectTransform = UIExtensions.parentRt(transform);
		object obj2 = this + 56;
		obj2 = rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj3 = this + 32;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private unsafe void Start()
	{
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0329: Expected O, but got I
		//IL_0343: Expected O, but got I4
		//IL_002f: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_03b9: Expected O, but got I
		//IL_03c9: Expected O, but got I
		//IL_03eb: Expected O, but got I4
		//IL_0381: Expected O, but got I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_0459: Expected O, but got I
		//IL_0475: Expected I, but got O
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_0165: Expected O, but got I4
		//IL_0113: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_01b4: Expected I, but got O
		//IL_0199: Expected O, but got Ref
		//IL_02b8: Expected I, but got O
		//IL_02e2: Expected O, but got I4
		//IL_0184: Expected O, but got Ref
		//IL_0265: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		ResetUI();
		int counter;
		if (useExtra)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v39+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int count = CounterBubbleManager.GetCount(type, extra);
			counter = count;
			goto IL_0439;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A66]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				goto IL_00ce;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A66]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00ce;
			}
		}
		_ = 1;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v35+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj8;
		if (obj9 != null)
		{
			goto IL_0103;
		}
		goto IL_0397;
		IL_0128:
		object obj11 = (nint)0 + (nint)2352;
		Dictionary<System.Int32Enum, int> dictionary;
		int value;
		bool flag4 = dictionary.TryGetValue((System.Int32Enum)type, out value);
		bool flag5 = !flag4;
		object obj12 = !flag5;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			object obj14 = (object)(&value);
			counter = value;
		}
		else
		{
			object obj14 = (object)(&value);
			counter = 0;
		}
		goto IL_0439;
		IL_02ff:
		CounterBubbleManager.CounterUpdated counterUpdated = default(CounterBubbleManager.CounterUpdated);
		CounterBubbleManager.OnCounterUpdated += counterUpdated;
		return;
		IL_02f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_02ff;
		IL_0103:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v35+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v30+8]");
		dictionary = (Dictionary<System.Int32Enum, int>)0;
		goto IL_0128;
		IL_00ce:
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v35+E4]");
		bool flag6 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag6)
		{
			goto IL_0103;
		}
		goto IL_0397;
		IL_0397:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v22+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v20+8]");
		dictionary = (Dictionary<System.Int32Enum, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v20+8]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0128;
		IL_0439:
		object obj19 = typeof(CardUtils.<>c) + 2776;
		object obj20 = (nint)0 + (nint)464;
		SetCounter(counter);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = (nint)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X21_v4 (System.IntPtr)+8]");
		((Delegate)counterUpdated).method_ptr = (IntPtr)0;
		((Delegate)counterUpdated).method = method;
		object obj21 = counterUpdated + 32;
		obj21 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Delegate)counterUpdated).method_code = (IntPtr)counterUpdated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj22 = default(object);
		object obj23;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X21_v4 (System.IntPtr)+52]");
			if ((nint)0 == 3)
			{
				nint invoke_impl = 35892784;
				((Delegate)counterUpdated).invoke_impl = invoke_impl;
				nint extra_arg = 35892676;
				((Delegate)counterUpdated).extra_arg = extra_arg;
				obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v13+E4]");
				bool flag8 = (nint)0 == 0;
				object obj24 = !flag8;
				if (obj24 == null)
				{
					goto IL_02f0;
				}
				goto IL_02ff;
			}
		}
		((Delegate)counterUpdated).invoke_impl = ((Delegate)counterUpdated).method_ptr;
		nint extra_arg2 = 35892676;
		((Delegate)counterUpdated).extra_arg = extra_arg2;
		((Delegate)counterUpdated).method_code = (IntPtr)((Delegate)counterUpdated).m_target;
		obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v13+E4]");
		bool flag9 = (nint)0 == 0;
		object obj25 = !flag9;
		if (obj25 == null)
		{
			goto IL_02f0;
		}
		goto IL_02ff;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0128: Expected I, but got O
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0174: Expected I, but got O
		//IL_0100: Expected O, but got I4
		//IL_00c9: Expected I, but got O
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2776;
		object obj2 = (nint)0 + (nint)464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v3 (System.IntPtr)+8]");
		CounterBubbleManager.CounterUpdated counterUpdated = default(CounterBubbleManager.CounterUpdated);
		((Delegate)counterUpdated).method_ptr = (IntPtr)0;
		((Delegate)counterUpdated).method = method;
		object obj3 = counterUpdated + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Delegate)counterUpdated).method_code = (IntPtr)counterUpdated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj4 = default(object);
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v3 (System.IntPtr)+52]");
			if ((nint)0 == 3)
			{
				nint invoke_impl = 35892784;
				((Delegate)counterUpdated).invoke_impl = invoke_impl;
				goto IL_0183;
			}
		}
		else if ((object)this == null)
		{
			object obj5 = 134782976 + 1449;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
			throw new OutOfMemoryException();
		}
		((Delegate)counterUpdated).invoke_impl = ((Delegate)counterUpdated).method_ptr;
		((Delegate)counterUpdated).method_code = (IntPtr)((Delegate)counterUpdated).m_target;
		goto IL_0183;
		IL_0183:
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		nint extra_arg = 35892676;
		((Delegate)counterUpdated).extra_arg = extra_arg;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			CounterBubbleManager.OnCounterUpdated -= counterUpdated;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CounterBubbleManager.OnCounterUpdated -= counterUpdated;
	}

	private void ResetUI()
	{
		//IL_0042: Expected O, but got I
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		GameObject gameObject = container.gameObject;
		gameObject.SetActive(value: false);
		TextMeshProUGUI textMeshProUGUI = text;
		object obj = (nint)0 + (nint)2000;
		object obj2 = obj;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void CounterUpdated(CounterBubbleType cType, int newCount, string cExtra = null)
	{
		//IL_0029: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_01ff: Expected O, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_024b: Expected O, but got I4
		if (type != cType)
		{
			return;
		}
		bool flag = !useExtra;
		int num = newCount;
		string text = (string)cType;
		if (!flag)
		{
			bool flag2 = extra != cExtra;
			bool flag3 = !flag2;
			object obj = !flag3;
			if (obj != null)
			{
				return;
			}
			bool flag4 = !useExtra;
			object obj2 = !flag4;
			num = 0;
			text = cExtra;
			int num2 = 0;
			if (obj2 != null)
			{
				goto IL_0172;
			}
		}
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = StringsExtensions.IsNullOrEmpty(cExtra);
			bool flag6 = !flag5;
			object obj5 = !flag6;
			int num2 = num;
			if (obj5 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = StringsExtensions.IsNullOrEmpty(cExtra);
			bool flag8 = !flag7;
			int num2 = num;
			if (flag8)
			{
				return;
			}
		}
		goto IL_0172;
		IL_0172:
		if (newCount != 0)
		{
			SetCounter(newCount);
			if (!playSound || !sound.isActiveAndEnabled)
			{
				return;
			}
			bool flag9 = type == CounterBubbleType.PublicChat;
			object obj6 = !flag9;
			if (obj6 == null)
			{
				object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v13+E4]");
				bool flag10 = (nint)0 == 0;
				object obj9 = !flag10;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!Preferences.ChatSound)
				{
					return;
				}
			}
			sound.Play();
		}
		else
		{
			GameObject gameObject = container.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private void SetCounter(int newCount)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_002e: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0118: Expected F4, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_0180: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0286: Expected O, but got I
		//IL_02cc: Expected O, but got I4
		string text2;
		if (newCount > 0)
		{
			int num = default(int);
			string text = num.ToString();
			bool flag = (object)this.text == null;
			object obj = !flag;
			text2 = text;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			object obj2 = "{0} color encoding is currently unsupported for outputting to HDR." + 2792;
			text2 = (string)obj2;
		}
		this.text.text = text2;
		bool flag2 = newCount < 0;
		bool flag3 = newCount == 0;
		int num2 = newCount ^ newCount;
		int num3 = newCount & num2;
		bool flag4 = num3 < 0;
		bool flag5 = flag2 == flag4;
		object obj3 = !flag3;
		object obj4 = flag5 & obj3;
		object obj5 = ~obj4;
		float fontSizeMin = ((obj5 != null) ? 1.1135877E+09f : 16f);
		this.text.fontSizeMin = fontSizeMin;
		int num4 = ShortcutExtensions.DOKill(container, complete: true);
		if (newCount >= 1)
		{
			GameObject gameObject = container.gameObject;
			gameObject.SetActive(value: true);
			object obj6 = typeof(UsageHint) + 816;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15+B8]");
			object obj8 = 0;
			container.localScale = (Vector3)0;
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v19+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v20+C]");
			float num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v16+14]");
			float duration = num5 * 0f;
			float elasticity = default(float);
			Tweener tweener = ShortcutExtensions.DOPunchScale(container, (Vector3)10, duration, 0, elasticity);
		}
		else if (newCount != 0)
		{
			GameObject gameObject2 = container.gameObject;
			gameObject2.SetActive(value: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			container.localScale = (Vector3)0;
		}
		else
		{
			GameObject gameObject3 = container.gameObject;
			gameObject3.SetActive(value: false);
		}
	}
}
