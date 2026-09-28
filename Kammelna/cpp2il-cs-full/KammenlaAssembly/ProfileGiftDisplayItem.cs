using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfileGiftDisplayItem : ListViewItem<ProfileGiftDataHolder, int>
{
	private static readonly AddressReference<AchievementInfoPopup> AchievementProgress;

	private Image[] images;

	private Image stampImage;

	private TextMeshProUGUI countLabel;

	private GameObject countLabelObject;

	private TweenAnimation stampAnim;

	private Button openProgressButton;

	private float randomRotationRange;

	private long <GiftId>k__BackingField;

	private int <ItemCount>k__BackingField;

	public long GiftId
	{
		get
		{
			return <GiftId>k__BackingField;
		}
		private set
		{
			<GiftId>k__BackingField = value;
		}
	}

	public int ItemCount
	{
		get
		{
			return <ItemCount>k__BackingField;
		}
		private set
		{
			<ItemCount>k__BackingField = value;
		}
	}

	private void PopulateImage()
	{
		UIExtensions.LoadProfileGiftImage(images, <GiftId>k__BackingField);
		UIExtensions.LoadProfileGiftImage(stampImage, <GiftId>k__BackingField);
	}

	private void SetRotation(float range)
	{
		//IL_0092: Expected O, but got I4
		Image[] array = images;
		if (images != null && (object)array[0] != null)
		{
			Transform transform = array[0].transform;
			if ((object)transform != null)
			{
				transform.localEulerAngles = (Vector3)0;
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void SetCount(int count)
	{
		//IL_030a: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001d: Expected O, but got I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected I4, but got Unknown
		//IL_0368: Expected I4, but got O
		//IL_01d1: Expected O, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected I4, but got Unknown
		//IL_0240: Expected O, but got I4
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected I4, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_02db: Expected I, but got O
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected I4, but got Unknown
		//IL_00f6: Expected I4, but got O
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		Image[] array = images;
		bool flag = images == null;
		object obj = 152985600;
		ProfileGiftDisplayItem profileGiftDisplayItem = this;
		if (!flag)
		{
			obj = "utf-32" + 3632;
			object obj2 = 0;
			Image[] array2 = images;
			object obj5;
			object arg = default(object);
			do
			{
				object obj3 = obj2 - array2.Length;
				bool flag2 = (nint)obj3 < 0;
				bool flag3 = obj3 == null;
				int num = obj2 ^ array2.Length;
				int num2 = obj2 ^ obj3;
				int num3 = num & num2;
				bool flag4 = num3 < 0;
				bool flag5 = (nint)obj2 >= array2.Length;
				object obj4 = obj2;
				array = array2;
				profileGiftDisplayItem = this;
				if (!flag5)
				{
					array = (Image[])(object)((object)array2 + obj2);
					bool flag6 = (object)array[0] == null;
					obj4 = obj2;
					profileGiftDisplayItem = this;
					if (flag6)
					{
						break;
					}
					GameObject gameObject = array[0].gameObject;
					bool flag7 = (object)gameObject == null;
					obj4 = obj2;
					profileGiftDisplayItem = this;
					if (flag7)
					{
						break;
					}
					obj3 = obj2 - count;
					flag2 = (nint)obj3 < 0;
					flag3 = obj3 == null;
					num = obj2 ^ count;
					num2 = obj2 ^ obj3;
					num3 = num & num2;
					flag4 = num3 < 0;
					bool flag8 = flag2 == flag4;
					flag5 = !flag8;
					gameObject.SetActive(flag5);
					array = images;
					obj4 = obj2 + 1;
					bool flag9 = images == null;
					obj5 = !flag9;
					profileGiftDisplayItem = this;
					obj2 = obj4;
					array2 = images;
					continue;
				}
				if ((object)profileGiftDisplayItem.countLabelObject == null)
				{
					break;
				}
				obj3 = count - array2.Length;
				flag2 = (nint)obj3 < 0;
				flag3 = obj3 == null;
				num = count ^ array2.Length;
				num2 = count ^ obj3;
				num3 = num & num2;
				flag4 = num3 < 0;
				bool flag10 = flag2 == flag4;
				object obj6 = !flag3;
				flag5 = (byte)((flag10 & obj6) ? 1 : 0) != 0;
				profileGiftDisplayItem.countLabelObject.SetActive(flag5);
				profileGiftDisplayItem.<ItemCount>k__BackingField = count;
				profileGiftDisplayItem = (ProfileGiftDisplayItem)(object)profileGiftDisplayItem.countLabel;
				array = (Image[])(153100288 + 1024);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string text = string.Format((string)obj, arg);
				if ((object)profileGiftDisplayItem.countLabel == null)
				{
					break;
				}
				nint num4 = (nint)profileGiftDisplayItem;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ X8_v7 (Il2CppClass<ProfileGiftDisplayItem>)+558] (should have been resolved before IL gen)");
				return;
			}
			while (obj5 != null);
		}
		throw new NullReferenceException();
	}

	public void AddCount(int count)
	{
		SetCount(<ItemCount>k__BackingField += count);
		Sequence sequence = stampAnim.PlaySequence();
	}

	public void ShowAchievementProgress()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_00c2: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_00ea: Expected I, but got O
		//IL_0114: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 2200;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1024;
		object obj3 = (nint)0 + (nint)3480;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		object obj7 = (nint)0 + (nint)1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	public void InitializeImage(ProfileGiftModel gift)
	{
		<GiftId>k__BackingField = gift.ID;
		UIExtensions.LoadProfileGiftImage(images, gift.ID);
		UIExtensions.LoadProfileGiftImage(stampImage, <GiftId>k__BackingField);
	}

	public override void Setup(ProfileGiftDataHolder datum, bool firstTime)
	{
		//IL_0098: Expected O, but got I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_0188: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		if (datum != null)
		{
			Image[] array = images;
			if (images != null && (object)array[0] != null)
			{
				Transform transform = array[0].transform;
				if ((object)transform != null)
				{
					transform.localEulerAngles = (Vector3)0;
					<GiftId>k__BackingField = datum.<GiftId>k__BackingField;
					UIExtensions.LoadProfileGiftImage(images, datum.<GiftId>k__BackingField);
					UIExtensions.LoadProfileGiftImage(stampImage, <GiftId>k__BackingField);
					int <Quantity>k__BackingField = datum.<Quantity>k__BackingField;
					SetCount(datum.<Quantity>k__BackingField);
					if (datum.<AnimateAddedItem>k__BackingField)
					{
						if (stampAnim == null)
						{
							goto IL_027c;
						}
						Sequence sequence = stampAnim.PlaySequence();
						datum.<AnimateAddedItem>k__BackingField = false;
						<Quantity>k__BackingField = 0;
					}
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+E4]");
					if ((nint)0 != 0)
					{
						bool flag = openProgressButton;
						bool flag2 = !flag;
						object obj3 = !flag2;
						if (obj3 != null)
						{
							goto IL_01d4;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						if ((bool)openProgressButton)
						{
							goto IL_01d4;
						}
					}
					goto IL_020d;
				}
			}
		}
		goto IL_027c;
		IL_020d:
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		RectTransform rectTransform2 = UIExtensions.rectTransform(this);
		if ((object)rectTransform2 != null)
		{
			Vector2 sizeDelta = rectTransform2.sizeDelta;
			if ((object)rectTransform != null)
			{
				rectTransform.sizeDelta = (Vector2)0;
				return;
			}
		}
		goto IL_027c;
		IL_027c:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_01d4:
		if ((object)openProgressButton != null)
		{
			openProgressButton.interactable = datum.<Clickable>k__BackingField;
			goto IL_020d;
		}
		goto IL_027c;
	}

	public ProfileGiftDisplayItem()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	static ProfileGiftDisplayItem()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3344;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2992;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <ShowAchievementProgress>b__20_0(AchievementInfoPopup popup)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0032: Expected O, but got I4
		object format = "Cannot populate JSON object onto type '{0}'." + 3952;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string achievementId = string.Format((string)format, arg);
		popup.ShowAchievementPreview(achievementId);
	}
}
