using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public class OneShotEvent<T>
{
	private List<Action<T>> _callbacks;

	private readonly Action <DataLoader>k__BackingField;

	private T <Data>k__BackingField;

	private bool <IsReady>k__BackingField;

	private bool <DataRequested>k__BackingField;

	public Action DataLoader => <DataLoader>k__BackingField;

	public T Data
	{
		get
		{
			return <Data>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsReady
	{
		get
		{
			return <IsReady>k__BackingField;
		}
		private set
		{
			<IsReady>k__BackingField = value;
		}
	}

	public bool DataRequested
	{
		get
		{
			return <DataRequested>k__BackingField;
		}
		private set
		{
			<DataRequested>k__BackingField = value;
		}
	}

	public OneShotEvent()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<OneShotEvent`1>)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<OneShotEvent`1>)+10]");
		if ((object)((object)((object)((nint)0 + (nint)309) & 1) != null) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 16;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	public OneShotEvent(Action dataLoader)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v2 (Il2CppRgctx<OneShotEvent`1>)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v2 (Il2CppRgctx<OneShotEvent`1>)+10]");
		if ((object)((object)((object)((nint)0 + (nint)309) & 1) != null) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 16;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj3 = this + 24;
		obj3 = dataLoader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe void MarkReady(T param)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0252: Expected O, but got I
		//IL_0262: Expected O, but got I
		//IL_0272: Expected O, but got I
		//IL_0295: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_00d4: Expected O, but got I
		//IL_00e4: Expected O, but got I
		//IL_00f4: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0142: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = this + 32;
		T val = default(T);
		obj3 = val;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 16;
		_ = 1;
		List<object>.Enumerator enumerator = ((List<object>)obj4).GetEnumerator();
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		while (enumerator2.MoveNext())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v23+20]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v24+C0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v25+60]");
			num = 0;
			Actions.SafeInvoke(null, obj3);
		}
		object obj8 = 0;
		object obj9 = 0;
		List<object> list = default(List<object>);
		object obj21 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v3+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v4+C0]");
			object obj12 = 0;
			enumerator2.Dispose();
			bool flag = obj9 == null;
			object obj13 = !flag;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6+20]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v7+C0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+10]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+10]");
				object obj18 = (nint)0 + (nint)309;
				object obj19 = obj18 & 1;
				bool flag2 = obj19 == null;
				object obj20 = !flag2;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list..ctor();
				obj4 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if ((nint)val != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj9 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = intPtr;
			obj8 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D49ACC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void MarkNotReady()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 32;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
	}

	public void CallWhenReady(Action<T> callback)
	{
		//IL_00a8: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		//IL_0059: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		if (<IsReady>k__BackingField)
		{
			if (callback == null)
			{
				return;
			}
			T val = <Data>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X1 (System.Action`1<T>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X1 (System.Action`1<T>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X1 (System.Action`1<T>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v28 @ X3_v1 (should have been resolved before IL gen)");
		}
		List<object> callbacks = (List<object>)(object)_callbacks;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5 (Il2CppRgctx<OneShotEvent`1>)+90]");
		object obj4 = 0;
		int version = callbacks._version + 1;
		callbacks._version = version;
		object[] items = callbacks._items;
		bool flag = callbacks._size < items.Length;
		object obj5 = !flag;
		if (obj5 == null)
		{
			int size = callbacks._size + 1;
			callbacks._size = size;
			object obj6 = items + callbacks._size;
			object obj7 = obj6 + 32;
			obj7 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (<DataRequested>k__BackingField)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+20]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+C0]");
			object obj9 = 0;
			callbacks.AddWithResize((object)callback);
			bool flag2 = !<DataRequested>k__BackingField;
			object obj10 = !flag2;
			if (obj10 != null)
			{
				return;
			}
		}
		Action action = <DataLoader>k__BackingField;
		if (<DataLoader>k__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v142.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		<DataRequested>k__BackingField = true;
	}

	public void Clear()
	{
		//IL_0021: Expected O, but got I
		//IL_0037: Expected O, but got I
		//IL_0051: Expected O, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		<IsReady>k__BackingField = false;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<OneShotEvent`1>)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+135]");
		object obj2 = (nint)0 & (nint)1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 16;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
