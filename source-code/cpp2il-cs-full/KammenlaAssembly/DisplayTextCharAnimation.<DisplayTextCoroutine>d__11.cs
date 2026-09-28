using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using ArabicSupport;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;

public class DisplayTextCharAnimation : MonoBehaviour
{
	private sealed class <DisplayTextCoroutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public DisplayTextCharAnimation <>4__this;

		private float <gapDuration>5__2;

		private int <i>5__3;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <DisplayTextCoroutine>d__11(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d5: Expected I4, but got I8
			//IL_028d: Expected I4, but got O
			//IL_0021: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected I4, but got Unknown
			//IL_00ad: Expected F4, but got I4
			//IL_01d4: Expected I, but got O
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Expected O, but got Unknown
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Expected O, but got Unknown
			DisplayTextCharAnimation displayTextCharAnimation = <>4__this;
			string textValue;
			int num2;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_02b6;
				}
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					textValue = displayTextCharAnimation.textValue;
					if (displayTextCharAnimation.textValue != null)
					{
						int num = (int)(displayTextCharAnimation.duration / textValue._stringLength);
						<gapDuration>5__2 = num;
						<i>5__3 = 0;
						num2 = 0;
						goto IL_013d;
					}
				}
			}
			else
			{
				<>1__state = -1;
				num2 = ++<i>5__3;
				if ((object)<>4__this != null)
				{
					textValue = displayTextCharAnimation.textValue;
					if (displayTextCharAnimation.textValue != null)
					{
						goto IL_013d;
					}
				}
			}
			goto IL_027f;
			IL_013d:
			if (num2 < textValue._stringLength)
			{
				int length = num2 + 1;
				string text = textValue.Substring(0, length);
				bool flag2 = !displayTextCharAnimation.fixArabic;
				string text2 = text;
				if (!flag2)
				{
					string text3 = ArabicFixer.Fix(text);
					text2 = text3;
				}
				TextMeshProUGUI textField = displayTextCharAnimation.textField;
				if ((object)displayTextCharAnimation.textField != null)
				{
					nint num3 = (nint)textField;
					displayTextCharAnimation.textField.text = text2;
					object obj2 = typeof(UsageHint) + 1640;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					WaitForSeconds waitForSeconds = default(WaitForSeconds);
					waitForSeconds..ctor(<gapDuration>5__2);
					object obj3 = this + 24;
					obj3 = waitForSeconds;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
				goto IL_027f;
			}
			Action onCompleted = displayTextCharAnimation.OnCompleted;
			if (displayTextCharAnimation.OnCompleted != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v96.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			goto IL_02b6;
			IL_027f:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_02b6:
			return false;
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
			object obj2 = (nint)0 + (nint)2256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public TextMeshProUGUI textField;

	public bool fixArabic;

	public string textValue;

	public float duration = 0.15f;

	public bool playOnStart;

	private bool isAfterStartTrigger;

	private Action m_OnCompleted;

	public event Action OnCompleted
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 64;
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
			object obj2 = this + 64;
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

	public void Display()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0044: Expected O, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(textValue))
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy instance = CoroutineDummy.Instance;
			object obj4 = typeof(DebugUI.BitField) + 880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = default(object);
			obj5..ctor();
			_ = 0;
			object obj6 = obj5 + 32;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = instance.StartCoroutine((IEnumerator)obj5);
		}
	}

	private void Start()
	{
		if (playOnStart)
		{
			Display();
		}
	}

	private IEnumerator DisplayTextCoroutine()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}
}
