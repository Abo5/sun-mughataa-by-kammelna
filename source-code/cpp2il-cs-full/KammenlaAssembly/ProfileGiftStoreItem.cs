using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ProfileGiftStoreItem : MonoBehaviour, ISelectable
{
	private Image giftImage;

	private TextMeshProUGUI priceText;

	private ObjectToggler selectionMarker;

	private TextMeshProUGUI titleText;

	private TextMeshProUGUI titleTextOutline;

	public UnityEvent<ProfileGiftStoreItem> Callback;

	private ProfileGiftModel <GiftModel>k__BackingField;

	public ProfileGiftModel GiftModel
	{
		get
		{
			return <GiftModel>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public long GiftId
	{
		get
		{
			//IL_0041: Expected I8, but got O
			ProfileGiftModel profileGiftModel = <GiftModel>k__BackingField;
			if (<GiftModel>k__BackingField != null)
			{
				return profileGiftModel.ID;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	public void Initialize(ProfileGiftModel giftId)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		object obj = this + 80;
		obj = giftId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object format = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 688;
		UIExtensions.LoadProfileGiftImage(giftImage, giftId.ID);
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		priceText.text = text;
		TextMeshProExtensions.FixArabic(titleText, giftId.Name);
		TextMeshProExtensions.FixArabic(titleTextOutline, giftId.Name);
	}

	public void InvokeCallback()
	{
		((UnityEvent<object>)(object)Callback).Invoke((object)this);
	}

	public void Select()
	{
		selectionMarker.ToggleManual(isON: true);
	}

	public void Deselect()
	{
		selectionMarker.ToggleManual(isON: false);
	}
}
