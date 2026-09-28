using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class ContentParentPreserver : MonoBehaviour
{
	private class DisableListener : MonoBehaviour
	{
		private Action m_OnContentDisabled;

		public event Action OnContentDisabled
		{
			add
			{
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Expected O, but got Unknown
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Expected O, but got Unknown
				object obj = typeof(SqlSingle[]) + 2376;
				object obj2 = this + 32;
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
				object obj2 = this + 32;
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

		private void OnDisable()
		{
			Action onContentDisabled = this.OnContentDisabled;
			if (this.OnContentDisabled != null)
			{
				IntPtr invoke_impl = ((Delegate)onContentDisabled).invoke_impl;
				IntPtr method_code = ((Delegate)onContentDisabled).method_code;
				IntPtr method = ((Delegate)onContentDisabled).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <RestoreNextFrame>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public ContentParentPreserver <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RestoreNextFrame>d__9(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0129: Expected O, but got I4
			//IL_005a: Expected I4, but got I8
			//IL_0167: Expected I4, but got O
			//IL_00fa: Expected O, but got I4
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					ContentParentPreserver contentParentPreserver = <>4__this;
					<>1__state = -1;
					if ((object)<>4__this != null)
					{
						contentParentPreserver._restorePending = false;
						if ((object)contentParentPreserver._contentParent != null)
						{
							contentParentPreserver._contentParent.SetParent(contentParentPreserver._originalParent, worldPositionStays: false);
							if ((object)contentParentPreserver._contentParent != null)
							{
								contentParentPreserver._contentParent.anchoredPosition = (Vector2)0;
								goto IL_00ff;
							}
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				goto IL_00ff;
			}
			object obj = this + 24;
			obj = 0;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return <>1__state == 0;
			IL_00ff:
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
			object obj2 = (nint)0 + (nint)1912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private RectTransform _contentParent;

	private Transform _originalParent;

	private Vector2 _originalAnchoredPosition;

	private DisableListener _listener;

	private bool _restorePending;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Expected O, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_017b: Expected O, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		object obj = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+28]");
		Transform parent = ((Transform)0).parent;
		Transform transform;
		if ((object)parent != null)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			if (parent == obj2)
			{
				object obj3 = this + 32;
				obj3 = parent;
				if (parent == obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					transform = (Transform)obj3;
					bool flag = obj3 == null;
					object obj4 = !flag;
					if (obj4 == null)
					{
						throw new NullReferenceException();
					}
					goto IL_0112;
				}
			}
			throw new InvalidCastException();
		}
		object obj5 = this + 32;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		transform = (Transform)obj5;
		goto IL_0112;
		IL_0112:
		Transform parent2 = transform.parent;
		object obj6 = this + 40;
		obj6 = parent2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X21_v7-8]");
		Vector2 anchoredPosition = ((RectTransform)0).anchoredPosition;
		Vector2 originalAnchoredPosition = default(Vector2);
		_originalAnchoredPosition = originalAnchoredPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+28]");
		GameObject gameObject = ((Component)0).gameObject;
		object obj7 = (nint)0 + (nint)1048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		object obj8 = this + 56;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00c6: Expected I, but got O
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = _listener + 32;
		Delegate obj4 = (Delegate)obj3;
		bool flag;
		Delegate obj6 = default(Delegate);
		do
		{
			Delegate obj5 = Delegate.Combine(obj4, action);
			if ((object)obj5 == null || obj5 == obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag = (object)obj6 == obj4;
				obj4 = obj6;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag);
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_01a4: Expected I, but got O
		//IL_0159: Expected O, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E753C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object listener;
		UnityEngine.Object listener2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			listener = _listener;
			listener2 = _listener;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			listener = _listener;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			listener2 = _listener;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = listener2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			goto IL_016c;
		}
		return;
		IL_016c:
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		object obj10 = _listener + 32;
		Delegate obj11 = (Delegate)obj10;
		bool flag5;
		Delegate obj13 = default(Delegate);
		do
		{
			Delegate obj12 = Delegate.Remove(obj11, action);
			if ((object)obj12 == null || obj12 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag5 = (object)obj13 == obj11;
				obj11 = obj13;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag5);
		return;
		IL_0091:
		bool flag6 = listener != null;
		bool flag7 = !flag6;
		object obj14 = !flag7;
		obj6 = 0;
		obj7 = null;
		if (obj14 == null)
		{
			return;
		}
		goto IL_016c;
	}

	private void ScheduleRestore()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		if (!_restorePending)
		{
			_restorePending = true;
			object obj = typeof(CardUtils.<>c) + 2368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 0;
			object obj3 = obj2 + 32;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
		}
	}

	private IEnumerator RestoreNextFrame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2368;
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
