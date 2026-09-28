using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TournamentChampionshipTrophyItem : MonoBehaviour
{
	private Image selectionFrame;

	private PopupUI trophyPopup;

	public Image[] icons;

	public TextMeshProUGUI price;

	public TextMeshProUGUI trophyDescription;

	private TournamentsCreationPopupEventsChannel eventsChannel;

	private string <TrophyName>k__BackingField;

	public UnityEvent<TournamentChampionshipTrophyItem> OnSelected;

	public string TrophyName
	{
		get
		{
			return <TrophyName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void PopulateInfo(TournamentAddonConfig.ChampionshipConfig.TrophyConfig trophy)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		object obj = "Material with texture name \"" + 3224;
		UIExtensions.LoadAchievementImage(icons, trophy.<Name>k__BackingField, 1);
		int num = default(int);
		string text = num.ToString((string)obj);
		price.text = text;
		Transform transform = trophyPopup.transform;
		UIExtensions.AttachToCanvas(transform, CanvasLayer.SecondaryCanvas);
		GameObject gameObject = base.gameObject;
		gameObject.name = trophy.<Name>k__BackingField;
		object obj2 = this + 80;
		obj2 = trophy.<Name>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void UpdateTrophyDescription(string tournamentName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ff: Expected O, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0299: Expected O, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01ce: Expected I, but got O
		//IL_01de: Expected O, but got I
		//IL_0207: Expected O, but got I
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C1E]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(tournamentName);
		TextMeshProUGUI textMesh = trophyDescription;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		TextMeshProUGUI textMesh2 = trophyDescription;
		if (obj5 != null)
		{
			goto IL_00b2;
		}
		goto IL_0165;
		IL_02b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_00b2:
		object text = "placementId" + 992;
		TextMeshProExtensions.Localize(textMesh, (string)text);
		return;
		IL_0165:
		object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj7;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj8;
		if (array != null)
		{
			bool flag4 = tournamentName == null;
			obj7 = 1;
			if (!flag4)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
				obj8 = 0;
				if (flag5)
				{
					goto IL_02b4;
				}
			}
			if (array.Length != 0)
			{
				object obj9 = array + 32;
				obj9 = tournamentName;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object text2 = "placementId" + 1000;
				LocalizableText text3 = TextMeshProExtensions.LocalizeWith((string)text2, array);
				TextMeshProExtensions.Localize(textMesh2, text3);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj7 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj8 = obj7;
		goto IL_02b4;
		IL_0074:
		bool flag6 = StringsExtensions.IsNullOrEmpty(tournamentName);
		textMesh = trophyDescription;
		bool flag7 = !flag6;
		textMesh2 = trophyDescription;
		if (!flag7)
		{
			goto IL_00b2;
		}
		goto IL_0165;
	}

	public void OnItemClicked()
	{
		TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel = eventsChannel;
		UpdateTrophyDescription(tournamentsCreationPopupEventsChannel.<TournamentName>k__BackingField);
		trophyPopup.PopFromCenter();
		if (OnSelected != null)
		{
			((UnityEvent<object>)(object)OnSelected).Invoke((object)this);
		}
		GameObject gameObject = selectionFrame.gameObject;
		gameObject.SetActive(value: true);
	}

	public void Select()
	{
		if (OnSelected != null)
		{
			((UnityEvent<object>)(object)OnSelected).Invoke((object)this);
		}
		GameObject gameObject = selectionFrame.gameObject;
		gameObject.SetActive(value: true);
	}

	public void Refresh(bool isSelected)
	{
		GameObject gameObject = selectionFrame.gameObject;
		gameObject.SetActive(isSelected);
	}
}
