using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class TournamentTitleItem : MonoBehaviour
{
	private GameObject checkMark;

	public Image Icon;

	public RotatingLoadingIndicator loading;

	private GameAchievementViewModel <TitleModel>k__BackingField;

	private TitleAddonSelector manager;

	public GameAchievementViewModel TitleModel
	{
		get
		{
			return <TitleModel>k__BackingField;
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

	private bool isSelected
	{
		get
		{
			//IL_004e: Expected I4, but got O
			TitleAddonSelector titleAddonSelector = manager;
			if ((object)manager != null && titleAddonSelector.selectedItems != null)
			{
				return ((List<object>)(object)titleAddonSelector.selectedItems).Contains((object)this);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public void PopulateInfo(GameAchievementViewModel titleModel, TitleAddonSelector _manager)
	{
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0016: Expected O, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0084: Expected O, but got I
		//IL_0092: Expected I, but got O
		//IL_0126: Expected O, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00c1: Expected O, but got I
		//IL_00cf: Expected I, but got O
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_017f: Expected O, but got I
		//IL_018d: Expected I, but got O
		object obj = this + 64;
		obj = _manager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 56;
		obj2 = titleModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X21_v3-10]");
		GameObject gameObject = ((Component)0).gameObject;
		gameObject.SetActive(value: false);
		bool flag = base.isActiveAndEnabled;
		bool flag2 = !flag;
		Action action = null;
		if (!flag2)
		{
			object obj3 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)1544;
			Func<bool> func = default(Func<bool>);
			func..ctor((object)this, (IntPtr)obj4);
			object obj5 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)1552;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj6);
			Coroutine coroutine = UIExtensions.SetTimeout(this, 0.3f, func, action2);
			action = action2;
		}
		if (titleModel.<achievementLevels>k__BackingField != null)
		{
			object obj7 = (nint)0 + (nint)304;
			object obj8 = Enumerable.FirstOrDefault((IEnumerable<object>)titleModel.<achievementLevels>k__BackingField);
			if (obj8 != null)
			{
				object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj10 = (nint)0 + (nint)1560;
				Action<bool> action3 = default(Action<bool>);
				action3..ctor((object)this, (IntPtr)obj10);
				Image icon = Icon;
				string <id>k__BackingField = titleModel.<id>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v18 (System.Object)+10]");
				UIExtensions.LoadAchievementImage(icon, <id>k__BackingField, 0, action3);
			}
		}
		GameObject gameObject2 = base.gameObject;
		gameObject2.name = titleModel.<name>k__BackingField;
	}

	public void OnItemClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015a: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_027b: Expected O, but got I
		//IL_0295: Expected O, but got I4
		//IL_0223: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE7]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj5 = manager;
			obj6 = manager;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = manager;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = manager;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			goto IL_00c6;
		}
		goto IL_02ff;
		IL_02ad:
		_ = 1;
		GameObject gameObject2;
		GameObject gameObject = gameObject2;
		goto IL_030e;
		IL_00c6:
		object obj11 = typeof(DataRelation) + 856;
		object message = "ThisIsFakeReceiptData" + 384;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v33+E4]");
		if ((nint)0 != 0)
		{
			Debug.LogError(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.LogError(message);
		return;
		IL_030e:
		TitleAddonSelector titleAddonSelector = manager;
		bool active = ((List<object>)(object)titleAddonSelector.selectedItems).Contains((object)this);
		gameObject.SetActive(active);
		return;
		IL_0091:
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		obj9 = 0;
		obj10 = null;
		if (!flag6)
		{
			goto IL_00c6;
		}
		goto IL_02ff;
		IL_02ff:
		TitleAddonSelector titleAddonSelector2 = manager;
		if (((List<object>)(object)titleAddonSelector2.selectedItems).Contains((object)this))
		{
			manager.DeselectItem(this);
			gameObject2 = checkMark;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE6]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 == null)
			{
				goto IL_02ad;
			}
			gameObject = checkMark;
		}
		else
		{
			manager.SelectItem(this);
			gameObject2 = checkMark;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE6]");
			object obj14 = (nint)0 & (nint)1;
			bool flag7 = obj14 == null;
			object obj15 = !flag7;
			gameObject = checkMark;
			if (obj15 == null)
			{
				goto IL_02ad;
			}
		}
		goto IL_030e;
	}

	public void Refresh()
	{
		TitleAddonSelector titleAddonSelector = manager;
		bool active = ((List<object>)(object)titleAddonSelector.selectedItems).Contains((object)this);
		checkMark.SetActive(active);
	}

	private bool <PopulateInfo>b__10_0()
	{
		//IL_006b: Expected I4, but got O
		if ((object)Icon != null)
		{
			GameObject gameObject = Icon.gameObject;
			if ((object)gameObject != null)
			{
				return gameObject.activeSelf;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <PopulateInfo>b__10_1()
	{
		loading.StartLoading();
	}

	private void <PopulateInfo>b__10_2(bool b)
	{
		loading.FinishLoading();
		GameObject gameObject = Icon.gameObject;
		gameObject.SetActive(value: true);
	}
}
