using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

namespace ListView;

public abstract class ListViewItem<TData, TIndex> : MonoBehaviour, IListViewItem<TData, TIndex>, IListViewItem where TData : IListViewItemData<TIndex>
{
	private GameObject _gameObject;

	private Transform _transform;

	private Action<Action> <startSettling>k__BackingField;

	private Action <endSettling>k__BackingField;

	private TData <data>k__BackingField;

	private Func<TIndex, IListViewItem<TData, TIndex>> <getListItem>k__BackingField;

	private Action<TData> <RemoveSelf>k__BackingField;

	private Action<TData> <PinSelf>k__BackingField;

	private bool <IsPinned>k__BackingField;

	private bool <IsDatumPinned>k__BackingField;

	public GameObject GameObject
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_0124: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0179: Expected O, but got I4
			//IL_018a: Expected O, but got I4
			object obj = 152961024;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E0E86]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 32;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 32;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 != null;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			obj4 = obj8;
			object obj11 = 0;
			if (obj10 != null)
			{
				goto IL_00dc;
			}
			goto IL_0198;
			IL_00dc:
			return (GameObject)obj4;
			IL_0198:
			GameObject result = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return result;
			IL_00a0:
			bool flag5 = obj5 != null;
			bool flag6 = !flag5;
			obj11 = 0;
			obj8 = obj4;
			if (!flag6)
			{
				goto IL_00dc;
			}
			goto IL_0198;
		}
	}

	public Vector3 localPosition
	{
		get
		{
			//IL_0036: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+28]");
				return ((Transform)0).localPosition;
			}
			return (Vector3)new NullReferenceException();
		}
		set
		{
			//IL_0016: Expected O, but got I4
			//IL_0016: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+28]");
			((Transform)0).localPosition = (Vector3)0;
		}
	}

	public Quaternion localRotation
	{
		get
		{
			//IL_0036: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+28]");
				return ((Transform)0).localRotation;
			}
			return (Quaternion)new NullReferenceException();
		}
		set
		{
			//IL_0016: Expected O, but got I4
			//IL_0016: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+28]");
			((Transform)0).localRotation = (Quaternion)0;
		}
	}

	public Action<Action> startSettling
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+30]");
			return (Action<Action>)0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Action endSettling
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+38]");
			return (Action)0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TData data
	{
		get
		{
			//IL_0010: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+60]");
			_ = 0;
			return (TData)this;
		}
		set
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X1 (TData)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X1 (TData)+10]");
			_ = 0;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Func<TIndex, IListViewItem<TData, TIndex>> getListItem
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+68]");
			return (Func<TIndex, IListViewItem<TData, TIndex>>)0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Action<TData> RemoveSelf
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+70]");
			return (Action<TData>)0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Action<TData> PinSelf
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+78]");
			return (Action<TData>)0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsPinned
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+80]");
			return false;
		}
		private set
		{
		}
	}

	public bool IsDatumPinned
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+90]");
			return false;
		}
		private set
		{
		}
	}

	public event Action OnPinnedStateChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 136;
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
			object obj2 = this + 136;
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

	public event Action OnDatumPinnedStateChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 152;
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
			object obj2 = this + 152;
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

	public void SetPinned(bool pinned, bool animated)
	{
		//IL_0015: Expected O, but got I
		//IL_004e: Expected I, but got O
		//IL_005e: Expected O, but got I
		//IL_006e: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1 (ListView.ListViewItem`2<TData, TIndex>)+88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1 (ListView.ListViewItem`2<TData, TIndex>)+88]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ X9_v1+18] (should have been resolved before IL gen)");
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v2 (Il2CppClass<ListView.ListViewItem`2<TData, TIndex>>)+2E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v2 (Il2CppClass<ListView.ListViewItem`2<TData, TIndex>>)+2F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v56 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void OnPinnedChanged(bool pinned, bool animated)
	{
	}

	public void SetDatumPinned(bool pinned)
	{
		//IL_0039: Expected O, but got I
		//IL_0073: Expected I, but got O
		//IL_0083: Expected O, but got I
		//IL_0093: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v1 (ListView.ListViewItem`2<TData, TIndex>)+90]");
		bool flag = default(bool);
		if ((nint)(flag ? 1 : 0) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v1 (ListView.ListViewItem`2<TData, TIndex>)+98]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v1 (ListView.ListViewItem`2<TData, TIndex>)+98]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ X9_v1+18] (should have been resolved before IL gen)");
			}
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<ListView.ListViewItem`2<TData, TIndex>>)+2F8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<ListView.ListViewItem`2<TData, TIndex>>)+300]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	protected virtual void OnDatumPinnedChanged(bool pinned)
	{
	}

	public void SetActive(bool active)
	{
		//IL_0015: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+20]");
		((GameObject)0).SetActive(active);
	}

	public void SetSiblingIndex(int index)
	{
		//IL_0015: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.ListViewItem`2<TData, TIndex>)+28]");
		((Transform)0).SetSiblingIndex(index);
	}

	public virtual void Setup(TData datum, bool firstTime)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (TData)+10]");
		_ = 0;
		object obj = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (firstTime)
		{
			Transform transform = base.transform;
			object obj2 = this + 40;
			obj2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			GameObject gameObject = base.gameObject;
			object obj3 = this + 32;
			obj3 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public unsafe void ForceRefresh()
	{
		//IL_0010: Expected O, but got Ref
		object obj = default(object);
		((ListViewItem<, >)(object)this).Setup((TData)(&obj), firstTime: false);
	}
}
