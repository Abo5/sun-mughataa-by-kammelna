using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class KRadioPickerGroup : MonoBehaviour
{
	private readonly List<KRadioPicker> _members;

	private bool <IsUpdating>k__BackingField;

	public bool IsUpdating
	{
		get
		{
			return <IsUpdating>k__BackingField;
		}
		set
		{
			<IsUpdating>k__BackingField = value;
		}
	}

	public void Register(KRadioPicker picker)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_012b: Expected O, but got I
		//IL_01bf: Expected O, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75A9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (picker != null)
		{
			goto IL_011f;
		}
		return;
		IL_011f:
		object obj5 = (nint)0 + (nint)2904;
		if (!((List<object>)(object)_members).Contains((object)picker))
		{
			List<object> members = (List<object>)(object)_members;
			int version = members._version + 1;
			members._version = version;
			object[] items = members._items;
			bool flag2 = members._size < items.Length;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				int size = members._size + 1;
				members._size = size;
				object obj7 = items + members._size;
				object obj8 = obj7 + 32;
				obj8 = picker;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				members.AddWithResize((object)picker);
			}
		}
		return;
		IL_0074:
		bool flag3 = picker != null;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			return;
		}
		goto IL_011f;
	}

	public void Unregister(KRadioPicker picker)
	{
		bool flag = ((List<object>)(object)_members).Remove((object)picker);
	}

	public void NotifyOpened(KRadioPicker source)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0122: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		List<object> members = (List<object>)(object)_members;
		object obj = (nint)0 + (nint)2928;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		for (int i = 0; i < members._size; i++, members = (List<object>)(object)_members)
		{
			object obj3 = members.get_Item(i);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				if (!((Object)obj3 != null))
				{
					continue;
				}
				Object obj5 = null;
				object obj6 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = (Object)obj3 != null;
				bool flag2 = !flag;
				Object obj5 = null;
				object obj6 = 0;
				if (flag2)
				{
					continue;
				}
			}
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				if (!((Object)obj3 != source))
				{
					continue;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!((Object)obj3 != source))
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v6 (System.Object)+C0]");
			if ((nint)0 == 1)
			{
				_ = 0;
				((KRadioPicker)obj3).UpdateUI(hideBlocker: true);
			}
		}
	}

	public KRadioPickerGroup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 32;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
