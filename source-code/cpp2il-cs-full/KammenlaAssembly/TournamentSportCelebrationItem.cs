using System;
using System.Data;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class TournamentSportCelebrationItem : MonoBehaviour
{
	private Image selectionFrame;

	private Image sportTeamImage;

	private Image sportTeamLogo;

	private int <sportTeamId>k__BackingField;

	public int cardBackId;

	private SportTeamAddonSelector _manager;

	public int sportTeamId
	{
		get
		{
			return <sportTeamId>k__BackingField;
		}
		set
		{
			<sportTeamId>k__BackingField = value;
		}
	}

	private bool isSelected
	{
		get
		{
			//IL_0093: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			SportTeamAddonSelector manager = _manager;
			if ((object)_manager != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					return manager.<selectedItem>k__BackingField == this;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return manager.<selectedItem>k__BackingField == this;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public void PopulateInfo(SportTeam item, SportTeamAddonSelector manager)
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0016: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		object obj = this + 64;
		obj = manager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X22_v3-20]");
		GameObject gameObject = ((Component)0).gameObject;
		gameObject.SetActive(value: false);
		object obj2 = "setMimeType" + 3608;
		<sportTeamId>k__BackingField = item.<id>k__BackingField;
		int? num = default(int?);
		int value = num.Value;
		cardBackId = value;
		GameObject gameObject2 = base.gameObject;
		int num2 = default(int);
		string text = num2.ToString();
		string text2 = (string)obj2 + text;
		gameObject2.name = text2;
		UIExtensions.LoadItemImage(sportTeamImage, cardBackId, ImageCacher.ItemImageType.InGame);
		UIExtensions.LoadItemImage(sportTeamLogo, cardBackId, ImageCacher.ItemImageType.StoreTitle);
	}

	public void Refresh()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		GameObject gameObject = selectionFrame.gameObject;
		SportTeamAddonSelector manager = _manager;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool active = manager.<selectedItem>k__BackingField == this;
		gameObject.SetActive(active);
	}

	public void OnItemClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C2A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object manager;
		UnityEngine.Object manager2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			manager = _manager;
			manager2 = _manager;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			manager = _manager;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			manager2 = _manager;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = manager2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			goto IL_00c7;
		}
		goto IL_01c3;
		IL_00c7:
		object obj9 = typeof(DataRelation) + 856;
		object message = "ThisIsFakeReceiptData" + 384;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			Debug.LogError(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.LogError(message);
		return;
		IL_01c3:
		Select();
		return;
		IL_0091:
		bool flag5 = manager == null;
		bool flag6 = !flag5;
		obj7 = 0;
		obj8 = null;
		if (!flag6)
		{
			goto IL_00c7;
		}
		goto IL_01c3;
	}

	public void Select()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		SportTeamAddonSelector manager = _manager;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = manager.<selectedItem>k__BackingField == this;
			bool flag2 = !flag;
			object obj3 = 0;
			if (!flag2)
			{
				goto IL_0080;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = manager.<selectedItem>k__BackingField == this;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			object obj3 = 0;
			if (obj4 != null)
			{
				goto IL_0080;
			}
		}
		object obj5 = _manager + 104;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_manager.Refresh();
		Refresh();
		return;
		IL_0080:
		Refresh();
	}
}
