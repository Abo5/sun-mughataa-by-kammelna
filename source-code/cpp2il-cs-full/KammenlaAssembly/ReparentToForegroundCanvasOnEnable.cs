using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class ReparentToForegroundCanvasOnEnable : MonoBehaviour
{
	private sealed class <WatchForClose>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public ReparentToForegroundCanvasOnEnable <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WatchForClose>d__10(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001c: Expected O, but got I4
			//IL_0043: Expected I4, but got I8
			//IL_0101: Expected I4, but got O
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I4
			bool flag = <>1__state < 2;
			object obj = !flag;
			if (obj == null)
			{
				ReparentToForegroundCanvasOnEnable reparentToForegroundCanvasOnEnable = <>4__this;
				<>1__state = -1;
				if ((object)<>4__this == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				if (reparentToForegroundCanvasOnEnable._isMoved && <>4__this.ShouldRemainReparented())
				{
					object obj2 = this + 24;
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
				<>4__this.Restore();
			}
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
			object obj2 = (nint)0 + (nint)3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private CanvasLayer _targetLayer;

	private bool _isMoved;

	private Transform _originalParent;

	private int _originalSiblingIndex;

	private readonly List<SlideAnimationHelper> _ancestorSlideHelpers;

	private Coroutine _watcher;

	private void OnEnable()
	{
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		bool flag = _isMoved;
		IntPtr intPtr = default(IntPtr);
		CanvasLayer canvasLayer = (CanvasLayer)(nint)intPtr;
		if (!flag)
		{
			Transform transform = base.transform;
			Transform parent = transform.parent;
			object obj = this + 40;
			obj = parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Transform transform2 = base.transform;
			int siblingIndex = transform2.GetSiblingIndex();
			_originalSiblingIndex = siblingIndex;
			List<SlideAnimationHelper> ancestorSlideHelpers = _ancestorSlideHelpers;
			object obj2 = (nint)0 + (nint)904;
			int version = ancestorSlideHelpers._version + 1;
			ancestorSlideHelpers._size = 0;
			ancestorSlideHelpers._version = version;
			if (ancestorSlideHelpers._size >= 1)
			{
				Array.Clear(ancestorSlideHelpers._items, 0, ancestorSlideHelpers._size);
				ancestorSlideHelpers = _ancestorSlideHelpers;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3210C");
			Transform transform3 = base.transform;
			canvasLayer = _targetLayer;
			UIExtensions.AttachToCanvas(transform3, _targetLayer);
			_isMoved = true;
		}
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		_ = 0;
		object obj5 = obj4 + 32;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj4);
		object obj6 = this + 64;
		obj6 = coroutine;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnDisable()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 64;
		if (obj != null)
		{
			StopCoroutine((Coroutine)obj);
			_watcher = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void Restore()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_01fa: Expected O, but got I4
		//IL_0175: Expected I4, but got I8
		//IL_018f: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		if (!_isMoved)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 64;
		Coroutine coroutine = (Coroutine)obj2;
		if (obj2 != null)
		{
			StopCoroutine((Coroutine)obj2);
			_watcher = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			coroutine = null;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = _originalParent == null;
			bool flag2 = !flag;
			bool flag3 = false;
			if (flag2)
			{
				goto IL_0126;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = _originalParent == null;
			bool flag5 = !flag4;
			object obj4 = !flag5;
			bool flag3 = false;
			if (obj4 == null)
			{
				goto IL_0126;
			}
		}
		goto IL_01d8;
		IL_021f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0126:
		Transform transform = base.transform;
		NullReferenceException ex;
		object obj6;
		if ((object)transform != null)
		{
			transform.SetParent(_originalParent, worldPositionStays: false);
			int num = (int)(_originalSiblingIndex & 0x80000000L);
			bool flag6 = num == 0;
			object obj5 = !flag6;
			if (obj5 == null)
			{
				Transform transform2 = base.transform;
				if ((object)transform2 == null)
				{
					ex = new NullReferenceException();
					bool flag3 = false;
					obj6 = 0;
					goto IL_021f;
				}
				transform2.SetSiblingIndex(_originalSiblingIndex);
			}
			goto IL_01d8;
		}
		ex = new NullReferenceException();
		obj6 = 0;
		goto IL_021f;
		IL_01d8:
		_isMoved = false;
	}

	private void CacheAncestorSlideHelpers()
	{
		//IL_0011: Expected O, but got I
		List<SlideAnimationHelper> ancestorSlideHelpers = _ancestorSlideHelpers;
		object obj = (nint)0 + (nint)904;
		int version = ancestorSlideHelpers._version + 1;
		ancestorSlideHelpers._size = 0;
		ancestorSlideHelpers._version = version;
		if (ancestorSlideHelpers._size >= 1)
		{
			Array.Clear(ancestorSlideHelpers._items, 0, ancestorSlideHelpers._size);
			ancestorSlideHelpers = _ancestorSlideHelpers;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3210C");
	}

	private IEnumerator WatchForClose()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private bool ShouldRemainReparented()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_01a6: Expected O, but got I
		//IL_02b6: Expected O, but got I
		//IL_02e1: Expected O, but got I4
		//IL_03cc: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_036c: Expected O, but got I4
		//IL_0375: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_027e: Expected O, but got I4
		//IL_0287: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73D3]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object originalParent;
		UnityEngine.Object originalParent2;
		if (obj2 != null)
		{
			originalParent = _originalParent;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v21+E4]");
			bool flag = (nint)0 == 0;
			originalParent2 = _originalParent;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			originalParent = _originalParent;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			originalParent2 = _originalParent;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = originalParent2 == null;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (obj5 == null)
		{
			goto IL_016b;
		}
		goto IL_02a4;
		IL_0295:
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		enumerator.Dispose();
		goto IL_02a4;
		IL_02a4:
		return false;
		IL_0348:
		NullReferenceException ex = new NullReferenceException();
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator2 = enumerator3;
		List<object>.Enumerator enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj6 = 0;
		obj7 = null;
		goto IL_0425;
		IL_0088:
		bool flag5 = originalParent == null;
		bool flag6 = !flag5;
		obj6 = 0;
		obj7 = null;
		if (flag6)
		{
			goto IL_016b;
		}
		goto IL_02a4;
		IL_016b:
		if (_ancestorSlideHelpers != null)
		{
			List<object>.Enumerator enumerator5 = ((List<object>)(object)_ancestorSlideHelpers).GetEnumerator();
			object obj8 = (nint)0 + (nint)1368;
			UnityEngine.Object obj11 = default(UnityEngine.Object);
			while (enumerator.MoveNext())
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v28+E4]");
				bool flag7 = (nint)0 == 0;
				object obj10 = !flag7;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = obj11 == null;
				bool flag9 = !flag8;
				object obj12 = !flag9;
				obj6 = 0;
				if (obj12 != null)
				{
					continue;
				}
				if ((object)obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ stack_-58 (UnityEngine.Object)+50]");
					object obj13 = (nint)0 & (nint)1;
					bool flag10 = obj13 == null;
					object obj14 = !flag10;
					obj6 = 0;
					if (obj14 != null)
					{
						continue;
					}
					goto IL_0295;
				}
				goto IL_0348;
			}
			object obj15 = (nint)0 + (nint)1360;
			obj7 = (UnityEngine.Object)obj15;
			enumerator.Dispose();
			enumerator2 = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			goto IL_02e6;
		}
		goto IL_0425;
		IL_02e6:
		if ((object)_originalParent != null)
		{
			GameObject gameObject = _originalParent.gameObject;
			bool flag11 = (object)gameObject == null;
			obj7 = null;
			if (!flag11)
			{
				return gameObject.activeInHierarchy;
			}
		}
		goto IL_0425;
		IL_0425:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag12 = (nint)obj7 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj16 = (nint)0 + (nint)1360;
			obj7 = (UnityEngine.Object)obj16;
			enumerator2.Dispose();
			object obj17 = default(object);
			bool flag13 = obj17 == null;
			enumerator3 = (List<object>.Enumerator)obj17;
			if (flag13)
			{
				goto IL_02e6;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj17;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2239CBC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result = default(bool);
		return result;
	}

	public ReparentToForegroundCanvasOnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Expected I4, but got I8
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3376;
		_targetLayer = CanvasLayer.SecondaryCanvas;
		_originalSiblingIndex = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 56;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
