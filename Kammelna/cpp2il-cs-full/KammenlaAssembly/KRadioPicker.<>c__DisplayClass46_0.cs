using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class KRadioPicker : MonoBehaviour
{
	[Serializable]
	public class RadioPickerItem
	{
		public string name;

		public Sprite icon;
	}

	private sealed class <>c__DisplayClass39_0
	{
		public KRadioPicker <>4__this;

		public int clickedIdx;

		internal void <CreateItem>b__0(bool isOn)
		{
			if (!isOn)
			{
				return;
			}
			KRadioPicker kRadioPicker = <>4__this;
			if (kRadioPicker.<SelectedIndex>k__BackingField != clickedIdx)
			{
				kRadioPicker.<SelectedIndex>k__BackingField = clickedIdx;
				Action<int> <OnValueChanged>k__BackingField = kRadioPicker.<OnValueChanged>k__BackingField;
				if (kRadioPicker.<OnValueChanged>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ X8_v5 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
				}
				kRadioPicker.HighlightIcons();
			}
			if (kRadioPicker.<IsShown>k__BackingField)
			{
				kRadioPicker.<IsShown>k__BackingField = false;
				kRadioPicker.UpdateUI();
			}
		}
	}

	private sealed class <>c__DisplayClass46_0
	{
		public KRadioPicker <>4__this;

		public bool hideBlocker;

		internal void <UpdateUI>b__0()
		{
			//IL_0018: Expected O, but got I4
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			//IL_0109: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			KRadioPicker kRadioPicker = <>4__this;
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E763A]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				obj5 = kRadioPicker._group;
				obj6 = kRadioPicker._group;
				if (!flag)
				{
					goto IL_00a6;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = kRadioPicker._group;
				obj6 = kRadioPicker._group;
				if (obj7 != null)
				{
					goto IL_00a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(obj6 != null))
			{
				return;
			}
			goto IL_0167;
			IL_0167:
			KRadioPickerGroup kRadioPickerGroup = kRadioPicker._group;
			kRadioPickerGroup.<IsUpdating>k__BackingField = false;
			return;
			IL_00a6:
			bool flag3 = obj5 != null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				return;
			}
			goto IL_0167;
		}

		internal void <UpdateUI>b__1()
		{
			//IL_0068: Expected O, but got I4
			KRadioPicker kRadioPicker = <>4__this;
			GameObject gameObject = kRadioPicker.layout.gameObject;
			gameObject.SetActive(value: false);
			KRadioPicker kRadioPicker2 = <>4__this;
			Transform transform = kRadioPicker2.layout.transform;
			transform.localScale = (Vector3)0;
		}

		internal void <UpdateUI>b__2()
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I
			//IL_0177: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			KRadioPicker kRadioPicker = <>4__this;
			GameObject gameObject = kRadioPicker.blocker.gameObject;
			gameObject.SetActive(hideBlocker);
			Transform transform = <>4__this.transform;
			KRadioPicker kRadioPicker2 = <>4__this;
			transform.SetParent(kRadioPicker2.originalParent);
			KRadioPicker kRadioPicker3 = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E763A]");
			object obj2 = (nint)0 & (nint)1;
			UnityEngine.Object obj3;
			UnityEngine.Object obj5;
			if (obj2 != null)
			{
				obj3 = kRadioPicker3._group;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7+E4]");
				bool flag = (nint)0 == 0;
				obj5 = kRadioPicker3._group;
				if (!flag)
				{
					goto IL_0107;
				}
			}
			else
			{
				_ = 1;
				obj3 = kRadioPicker3._group;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj5 = kRadioPicker3._group;
				if (obj6 != null)
				{
					goto IL_0107;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(obj5 != null))
			{
				return;
			}
			goto IL_01c8;
			IL_01c8:
			KRadioPickerGroup kRadioPickerGroup = kRadioPicker3._group;
			kRadioPickerGroup.<IsUpdating>k__BackingField = false;
			return;
			IL_0107:
			bool flag3 = obj3 != null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				return;
			}
			goto IL_01c8;
		}
	}

	private Button toggle;

	private HorizontalLayoutGroup layout;

	private GameObject itemPrefab;

	private Transform blocker;

	private bool hasPlaceholder;

	private string placeholder;

	private RadioPickerItem[] items;

	private bool localizeStrings = true;

	private Sprite leftActive;

	private Sprite leftInactive;

	private Sprite midActive;

	private Sprite midInactive;

	private Sprite rightActive;

	private Sprite rightInactive;

	private List<Image> btnIcons;

	private List<GameObject> itemsGameObjects;

	private Transform originalParent;

	private Image blockerImage;

	private float origianlBlockerFade;

	private KRadioPickerGroup _group;

	private bool <IsShown>k__BackingField;

	private int <SelectedIndex>k__BackingField;

	private Action<int> <OnValueChanged>k__BackingField;

	public bool IsShown
	{
		get
		{
			return <IsShown>k__BackingField;
		}
		private set
		{
			<IsShown>k__BackingField = value;
		}
	}

	public int SelectedIndex
	{
		get
		{
			return <SelectedIndex>k__BackingField;
		}
		private set
		{
			<SelectedIndex>k__BackingField = value;
		}
	}

	public RadioPickerItem SelectedItem
	{
		get
		{
			//IL_0046: Expected O, but got I4
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_0072: Expected O, but got I
			RadioPickerItem[] array = items;
			if (items != null)
			{
				bool flag = <SelectedIndex>k__BackingField < array.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = items + <SelectedIndex>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2+20]");
					return (RadioPickerItem)0;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			return (RadioPickerItem)(object)new IndexOutOfRangeException();
		}
	}

	public Action<int> OnValueChanged
	{
		get
		{
			return <OnValueChanged>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 200;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0119: Expected O, but got I
		//IL_02a5: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_018b: Expected O, but got I4
		//IL_02dd: Expected O, but got I
		//IL_02f5: Expected I, but got O
		//IL_01f1: Expected O, but got I
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_01bd: Expected I, but got O
		//IL_01d7: Expected O, but got I
		//IL_01e0: Expected O, but got I4
		object obj = (nint)0 + (nint)448;
		GenerateItems();
		GenerateToggleIcons();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		object obj2 = this + 184;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((KRadioPickerGroup)obj2)?.Register(this);
		Transform transform = base.transform;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Transform parent = transform.parent;
		object obj5 = this + 160;
		obj5 = parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X20_v7-68]");
		if ((UnityEngine.Object)0 != null)
		{
			GameObject gameObject = blocker.gameObject;
			gameObject.SetActive(value: false);
			object obj9 = (nint)0 + (nint)3640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj10 = default(object);
			bool flag2 = obj10 == null;
			object obj11 = 0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj12 = (nint)0 + (nint)3368;
				UnityAction unityAction = default(UnityAction);
				unityAction..ctor(this, (IntPtr)obj12);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v32+100]");
				((UnityEvent)0).AddListener(unityAction);
				obj11 = 0;
			}
			object obj13 = (nint)0 + (nint)3872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj14 = this + 168;
			object obj15 = default(object);
			obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj16 = obj14;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v231 @ X8_v16+298] (should have been resolved before IL gen)");
			float num = default(float);
			origianlBlockerFade = num;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(blockerImage, 0f, 0f);
		}
		<IsShown>k__BackingField = false;
		<SelectedIndex>k__BackingField = 0;
		object obj18 = ((List<object>)(object)itemsGameObjects).get_Item(0);
		object obj19 = (nint)0 + (nint)1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Toggle toggle = default(Toggle);
		toggle.isOn = true;
		Button button = this.toggle;
		object obj20 = (nint)0 + (nint)3376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj20);
		button.m_OnClick.AddListener(unityAction2);
		GameObject gameObject2 = layout.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void OnDestroy()
	{
		KRadioPickerGroup kRadioPickerGroup = _group;
		if ((object)_group != null)
		{
			bool flag = ((List<object>)(object)kRadioPickerGroup._members).Remove((object)this);
		}
	}

	public void Hide(bool hideBlocker = false)
	{
		if (<IsShown>k__BackingField)
		{
			<IsShown>k__BackingField = false;
			UpdateUI(hideBlocker);
		}
	}

	public void Select(int index)
	{
		//IL_0101: Expected I4, but got I8
		//IL_011b: Expected O, but got I4
		//IL_0045: Expected O, but got I
		//IL_0085: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		int num = (int)(index & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		List<object> list = (List<object>)(object)itemsGameObjects;
		if (index >= list._size)
		{
			return;
		}
		object obj2 = (nint)0 + (nint)1480;
		int num2 = 0;
		Toggle toggle = default(Toggle);
		while (num2 < list._size)
		{
			object obj3 = list.get_Item(num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			object obj4 = index - num2;
			bool isOn = obj4 == null;
			toggle.isOn = isOn;
			num2++;
			list = (List<object>)(object)itemsGameObjects;
			bool flag2 = itemsGameObjects == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	private void GenerateItems()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010c: Expected O, but got I4
		//IL_026e: Expected I4, but got O
		//IL_0284: Expected O, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_01ae: Expected I4, but got I8
		//IL_01dd: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 152;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v4-58]");
		object obj6;
		if ((nint)0 == 1)
		{
			object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = default(object);
			obj4..ctor();
			object obj5 = obj4 + 16;
			obj5 = placeholder;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			CreateItem((RadioPickerItem)obj4, 0);
			obj6 = 1;
		}
		else
		{
			obj6 = 0;
		}
		SetToggleSprites(itemPrefab, midActive, midInactive);
		RadioPickerItem[] array = items;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		if (array.Length >= 1)
		{
			object obj8 = array + 32;
			object obj9 = 0;
			do
			{
				int clickedIdx = (int)(obj6 + obj9);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X26_v3+v219 @ X25_v4*8]");
				CreateItem((RadioPickerItem)0, clickedIdx);
				obj9++;
			}
			while ((nint)obj9 < array.Length);
		}
		object go = Enumerable.First((IEnumerable<object>)itemsGameObjects);
		SetToggleSprites((GameObject)go, rightActive, rightInactive);
		object go2 = Enumerable.Last((IEnumerable<object>)itemsGameObjects);
		SetToggleSprites((GameObject)go2, leftActive, leftInactive);
		object obj10 = Enumerable.First((IEnumerable<object>)itemsGameObjects);
		((KRadioPicker)obj10).SetMargin((GameObject)obj10, 25);
		object obj11 = Enumerable.Last((IEnumerable<object>)itemsGameObjects);
		((KRadioPicker)obj11).SetMargin((GameObject)obj11, -25);
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj13 = !flag;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(itemPrefab);
	}

	private void CreateItem(RadioPickerItem item, int clickedIdx)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_011d: Expected O, but got I
		//IL_01a8: Expected I, but got O
		//IL_01b8: Expected O, but got I
		//IL_0184: Expected O, but got I4
		//IL_018d: Expected O, but got I4
		//IL_01ed: Expected O, but got I
		//IL_02ad: Expected O, but got I4
		//IL_0383: Expected O, but got I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = (nint)0 + (nint)360;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
		object obj8 = (nint)0 + (nint)1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj9 = typeof(TypeConverter<ushort, char>) + 360;
		object obj10 = (nint)0 + (nint)3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
		object obj11 = (nint)0 + (nint)832;
		object obj12 = (nint)0 + (nint)1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
		TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
		if (localizeStrings)
		{
			TextMeshProExtensions.Localize(textMeshProUGUI, item.name);
			bool flag2 = (object)textMeshProUGUI == null;
			object obj13 = !flag2;
			object obj14 = 0;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			nint num = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			object obj14 = 0;
			textMeshProUGUI.text = item.name;
		}
		Transform transform = textMeshProUGUI.transform;
		Transform parent = transform.parent;
		object obj15 = (nint)0 + (nint)264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		object obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v15+E4]");
		if ((nint)0 != 0)
		{
			if (item.icon == null)
			{
				goto IL_0250;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = item.icon == null;
			bool flag4 = !flag3;
			object obj17 = !flag4;
			if (obj17 != null)
			{
				goto IL_0250;
			}
		}
		goto IL_02bb;
		IL_0250:
		UnityEngine.Component component = default(UnityEngine.Component);
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: false);
		goto IL_02bb;
		IL_02bb:
		((Image)component).sprite = item.icon;
		GameObject gameObject2 = default(GameObject);
		Transform transform2 = gameObject2.transform;
		Transform parent2 = layout.transform;
		transform2.SetParent(parent2, worldPositionStays: false);
		Transform transform3 = gameObject2.transform;
		transform3.SetAsFirstSibling();
		List<object> list = (List<object>)(object)itemsGameObjects;
		int version = list._version + 1;
		list._version = version;
		object[] array = list._items;
		bool flag5 = list._size < array.Length;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj19 = array + list._size;
			object obj20 = obj19 + 32;
			obj20 = gameObject2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)gameObject2);
		}
	}

	private static void SetToggleSprites(GameObject go, Sprite active, Sprite inactive)
	{
		//IL_0011: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0091: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		//IL_00ee: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_013a: Expected O, but got I
		//IL_016f: Expected I, but got O
		//IL_0198: Expected O, but got I4
		//IL_01cc: Expected O, but got I
		//IL_0208: Expected O, but got I
		GameObject gameObject = default(GameObject);
		if ((object)gameObject != null)
		{
			object obj = (nint)0 + (nint)1480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			object obj2 = default(object);
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+108]");
				Image image = (Image)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+108]");
				if ((nint)0 != 0)
				{
					object obj3 = typeof(System.IOAsyncCallback) + 2456;
					object obj4 = obj3;
					nint num = (nint)image;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X1_v4+130]");
					bool flag = num2 < 0;
					object obj5 = !flag;
					object obj6 = ~obj5;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X1_v4+130]");
						object obj7 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v9-8]");
						if (0 == (nint)obj4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+108]");
							((Image)0).sprite = active;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E0]");
							Image image2 = (Image)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E0]");
							if ((nint)0 == 0)
							{
								goto IL_0209;
							}
							object obj8 = obj3;
							nint num4 = (nint)image2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11 (Il2CppClass<UnityEngine.UI.Image>)+130]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X1_v6+130]");
							bool flag2 = num5 < 0;
							object obj9 = !flag2;
							object obj10 = ~obj9;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11 (Il2CppClass<UnityEngine.UI.Image>)+C8]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X1_v6+130]");
								object obj11 = num6 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v13-8]");
								if (0 == (nint)obj8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E0]");
									((Image)0).sprite = inactive;
									return;
								}
							}
						}
					}
					goto IL_0217;
				}
			}
		}
		goto IL_0209;
		IL_0217:
		throw new InvalidCastException();
		IL_0209:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0217;
	}

	private void SetMargin(GameObject go, int margin)
	{
		//IL_0011: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_006b: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_009f: Expected O, but got I
		//IL_01f2: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_0126: Invalid comparison between F8 and I4
		//IL_0135: Invalid comparison between F8 and I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_018f: Expected O, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_029c: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		//IL_0309: Expected O, but got I4
		object obj = (nint)0 + (nint)1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj2 = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TMP_Text tMP_Text = default(TMP_Text);
		Transform transform = tMP_Text.transform;
		Transform parent = transform.parent;
		object obj3 = (nint)0 + (nint)4040;
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0D1]");
		object obj5 = (nint)0 & (nint)1;
		if (obj5 != null)
		{
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00e9;
			}
		}
		else
		{
			_ = 1;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00e9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int num = Math.Sign(margin);
		RectTransform rectTransform = default(RectTransform);
		bool flag2 = (object)rectTransform == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00fb;
		IL_00e9:
		num = Math.Sign(margin);
		goto IL_00fb;
		IL_00fb:
		object obj9 = -num;
		double num2 = (double)obj9 - 1.0;
		bool flag3 = num2 < 0.0;
		bool flag4 = num2 == 0.0;
		object obj10 = obj9 ^ 1.0;
		object obj11 = obj9 ^ num2;
		object obj12 = obj10 & obj11;
		bool flag5 = (nint)obj12 < 0;
		bool flag6 = flag3 == flag5;
		object obj13 = !flag4;
		object obj14 = flag6 & obj13;
		object obj15 = ~obj14;
		if (obj15 == null)
		{
		}
		bool flag7 = (nint)obj9 < 0;
		object obj16 = obj9 ^ obj9;
		object obj17 = obj9 & obj16;
		bool flag8 = (nint)obj17 < 0;
		bool flag9 = flag7 == flag8;
		object obj18 = !flag9;
		object obj19 = ~obj18;
		if (obj19 == null)
		{
		}
		rectTransform.pivot = (Vector2)0;
		Vector2 sizeDelta = rectTransform.sizeDelta;
		if (margin < 0)
		{
		}
		Vector2 sizeDelta2 = rectTransform.sizeDelta;
		rectTransform.sizeDelta = (Vector2)0;
	}

	private void GenerateToggleIcons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0037: Expected O, but got I
		//IL_0053: Expected O, but got I
		//IL_056f: Expected O, but got I
		//IL_057f: Expected O, but got I
		//IL_0595: Expected O, but got I
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_05bd: Expected O, but got I4
		//IL_05cd: Expected O, but got I
		//IL_0088: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		//IL_062f: Expected O, but got I
		//IL_063f: Expected O, but got I
		//IL_0655: Expected O, but got I
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0607: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_015c: Expected O, but got I4
		//IL_016c: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_0690: Expected O, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0216: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_036c: Expected O, but got I
		//IL_038f: Expected O, but got I4
		//IL_0303: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_0409: Expected O, but got I
		//IL_0464: Expected I, but got O
		//IL_04d5: Expected O, but got I4
		//IL_023d: Expected O, but got I
		//IL_024d: Expected O, but got I
		//IL_0273: Expected O, but got I4
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_053e: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 144;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X20_v4-70]");
		Transform transform = ((UnityEngine.Component)0).transform;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v6+38]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v6+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v4+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v4+10]");
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag = obj8 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v4+10]");
			object obj9 = 0;
			if (!flag)
			{
				goto IL_00d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v6+38]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v11+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v11+10]");
			object obj11 = (nint)0 + (nint)309;
			object obj12 = obj11 & 1;
			bool flag2 = obj12 == null;
			object obj13 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v11+10]");
			object obj9 = 0;
			if (obj13 != null)
			{
				goto IL_00d9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 != null)
		{
			goto IL_00fe;
		}
		goto IL_0615;
		IL_017a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0189;
		IL_00fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v6+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v31+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v31+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v31+10]");
		object obj20 = 0;
		if (obj19 == null)
		{
			goto IL_017a;
		}
		goto IL_0189;
		IL_0189:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v18+B8]");
		object obj21 = 0;
		GameObject[] array = (GameObject[])obj21;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])obj21);
		RadioPickerItem[] array2 = items;
		if (array2.Length < 1)
		{
			return;
		}
		object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj23 = (nint)0 + (nint)736;
		object obj24 = array2 + 32;
		object obj25 = (nint)0 + (nint)816;
		object obj26 = 0;
		bool flag5 = false;
		GameObject gameObject = default(GameObject);
		Image image = default(Image);
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X28_v4+v110 @ X24_v5*8]");
			object obj27 = 0;
			object obj28 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v19+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X22_v10+18]");
				bool flag6 = (UnityEngine.Object)0 == null;
				bool flag7 = !flag6;
				object obj29 = !flag7;
				flag5 = false;
				array = null;
				if (obj29 != null)
				{
					goto IL_0280;
				}
				bool flag8 = false;
				UnityEngine.Object obj30 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X22_v10+18]");
				bool flag9 = (UnityEngine.Object)0 == null;
				bool flag10 = !flag9;
				object obj31 = !flag10;
				flag5 = false;
				array = null;
				bool flag8 = false;
				UnityEngine.Object obj30 = null;
				if (obj31 != null)
				{
					goto IL_0280;
				}
			}
			object obj32 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			gameObject..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X22_v10+18]");
			image.sprite = (Sprite)0;
			Transform transform2 = image.transform;
			Transform parent = toggle.transform;
			transform2.SetParent(parent, worldPositionStays: false);
			Transform transform3 = image.transform;
			transform3.SetAsFirstSibling();
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ X8_v22 (Il2CppClass<UnityEngine.Transform>)+408] (should have been resolved before IL gen)");
			List<object> list2 = (List<object>)obj2;
			object obj33 = obj25;
			int version = list2._version + 1;
			list2._version = version;
			object[] array3 = list2._items;
			bool flag11 = list2._size < array3.Length;
			object obj34 = !flag11;
			if (obj34 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v23+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v25+C0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v26+70]");
				flag5 = false;
				list2.AddWithResize((object)image);
				object obj37 = 0;
				array = (GameObject[])(object)image;
			}
			else
			{
				int size = list2._size + 1;
				list2._size = size;
				object obj38 = array3 + list2._size;
				object obj39 = obj38 + 32;
				obj39 = image;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj37 = 0;
				flag5 = false;
				array = (GameObject[])(object)image;
			}
			goto IL_0280;
			IL_0280:
			obj26++;
		}
		while ((nint)obj26 < array2.Length);
		return;
		IL_00d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00fe;
		}
		goto IL_0615;
		IL_0615:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v6+38]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v6+10]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v6+10]");
		object obj41 = (nint)0 + (nint)309;
		object obj42 = obj41 & 1;
		if (obj42 == null)
		{
			goto IL_017a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v6+10]");
		obj20 = 0;
		goto IL_0189;
	}

	private void ItemClicked(int index)
	{
		if (<SelectedIndex>k__BackingField != index)
		{
			<SelectedIndex>k__BackingField = index;
			Action<int> action = <OnValueChanged>k__BackingField;
			if (<OnValueChanged>k__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ X8_v4 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
			}
			HighlightIcons();
		}
		if (<IsShown>k__BackingField)
		{
			<IsShown>k__BackingField = false;
			UpdateUI();
		}
	}

	private void HighlightIcons()
	{
		//IL_000c: Expected O, but got I
		//IL_002c: Expected F8, but got I4
		//IL_028a: Expected I4, but got O
		//IL_02b1: Expected F4, but got I4
		//IL_0040: Expected O, but got I
		//IL_0056: Expected F4, but got I4
		//IL_00b6: Expected I4, but got O
		//IL_00ca: Expected O, but got I4
		//IL_0213: Expected I4, but got O
		//IL_00a0: Expected F8, but got I4
		//IL_00a9: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		object obj = (nint)0 + (nint)2184;
		double num = ((<SelectedIndex>k__BackingField != 0) ? 1036831949.0 : 1.0);
		bool flag = (byte)(int)obj != 0;
		List<object> list = Enumerable.ToList((IEnumerable<object>)btnIcons);
		bool flag2 = list == null;
		float num2 = 1.03683194E+09f;
		double num3 = 1.0;
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag2)
		{
			obj2 = (nint)0 + (nint)2120;
			List<object>.Enumerator enumerator = list.GetEnumerator();
			num2 = 1.03683194E+09f;
			num3 = 1.0;
			while (enumerator2.MoveNext())
			{
				int num4 = ShortcutExtensions.DOKill((UnityEngine.Component)null, complete: false);
				TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Image)null, (float)num, 0.3f);
				num2 = (float)num;
				num3 = 1050253722.0;
				object obj3 = 0;
			}
			flag = (byte)(int)obj2 != 0;
			enumerator2.Dispose();
			object obj4 = 0;
			goto IL_00cf;
		}
		goto IL_01bc;
		IL_00cf:
		if (<SelectedIndex>k__BackingField == 0)
		{
			return;
		}
		if (btnIcons != null)
		{
			int index = <SelectedIndex>k__BackingField - 1;
			object target = ((List<object>)(object)btnIcons).get_Item(index);
			int num5 = ShortcutExtensions.DOKill((UnityEngine.Component)target);
			bool flag3 = btnIcons == null;
			object obj3 = 0;
			flag = false;
			if (!flag3)
			{
				int index2 = <SelectedIndex>k__BackingField - 1;
				object target2 = ((List<object>)(object)btnIcons).get_Item(index2);
				TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade((Image)target2, 1f, 0.3f);
				return;
			}
		}
		goto IL_01bc;
		IL_01bc:
		NullReferenceException ex = new NullReferenceException();
		bool flag4 = !flag;
		NullReferenceException ex2 = ex;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			flag = (byte)(int)obj2 != 0;
			enumerator2.Dispose();
			object obj5 = default(object);
			bool flag5 = obj5 == null;
			object obj4 = obj5;
			if (flag5)
			{
				goto IL_00cf;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj4 = obj5;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237004");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void Toggle()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_01bd: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75A8]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj5 = _group;
			obj6 = _group;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = _group;
			obj6 = _group;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (obj6 != null)
		{
			goto IL_0154;
		}
		goto IL_0187;
		IL_0187:
		bool flag3 = (byte)((<IsShown>k__BackingField ? 1u : 0u) ^ 1u) != 0;
		<IsShown>k__BackingField = flag3;
		bool flag4 = !<IsShown>k__BackingField;
		object obj8 = !flag4;
		if (obj8 == null && (object)_group != null)
		{
			_group.NotifyOpened(this);
		}
		UpdateUI();
		return;
		IL_0154:
		KRadioPickerGroup kRadioPickerGroup = _group;
		if (kRadioPickerGroup.<IsUpdating>k__BackingField)
		{
			return;
		}
		goto IL_0187;
		IL_0091:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 != null)
		{
			goto IL_0154;
		}
		goto IL_0187;
	}

	private void UpdateUI(bool hideBlocker = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		//IL_006e: Expected O, but got I
		//IL_02ab: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_0388: Expected O, but got I
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I
		//IL_03d2: Expected I, but got O
		//IL_03de: Expected O, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0199: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		//IL_04b8: Expected O, but got I4
		//IL_04c1: Expected O, but got I4
		//IL_04ca: Expected F8, but got I4
		//IL_04d3: Expected F4, but got I4
		//IL_04dc: Expected O, but got I4
		//IL_0440: Expected O, but got I4
		//IL_0449: Expected O, but got I4
		//IL_0678: Expected O, but got I
		//IL_0590: Expected F4, but got I4
		//IL_0599: Expected O, but got I4
		//IL_0244: Expected O, but got I4
		//IL_0743: Expected O, but got I4
		//IL_0523: Expected O, but got I
		//IL_0534: Expected I, but got O
		//IL_0540: Expected O, but got I
		//IL_0460: Expected O, but got I4
		//IL_0469: Expected F8, but got I4
		//IL_0472: Expected F4, but got I4
		//IL_047b: Expected O, but got I4
		//IL_06fa: Expected O, but got I4
		//IL_0268: Expected F4, but got I4
		//IL_0271: Expected O, but got I4
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_0617: Expected O, but got I
		//IL_0628: Expected I, but got O
		//IL_0639: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E763A]");
		object obj6 = (nint)0 & (nint)1;
		UnityEngine.Object obj8;
		UnityEngine.Object obj9;
		if (obj6 != null)
		{
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v46+E4]");
			bool flag = (nint)0 == 0;
			obj8 = _group;
			obj9 = _group;
			if (!flag)
			{
				goto IL_00cc;
			}
		}
		else
		{
			_ = 1;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v46+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			obj8 = _group;
			obj9 = _group;
			if (obj10 != null)
			{
				goto IL_00cc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj9 != null))
		{
			goto IL_00fe;
		}
		goto IL_0303;
		IL_0791:
		KRadioPickerGroup kRadioPickerGroup = _group;
		kRadioPickerGroup.<IsUpdating>k__BackingField = false;
		return;
		IL_0134:
		UnityEngine.Component component;
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: true);
		Transform transform = layout.transform;
		object obj11 = typeof(UsageHint) + 816;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v42+B8]");
		object obj13 = 0;
		transform.localScale = (Vector3)0;
		Transform target = layout.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.4f);
		object obj14 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v48+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = blocker != null;
			bool flag4 = !flag3;
			object obj16 = !flag4;
			if (obj16 != null)
			{
				goto IL_05ac;
			}
			double num = 1.0;
			float num2 = 1.05360915E+09f;
			object obj17 = 0;
			UnityEngine.Object obj18 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = blocker != null;
			bool flag6 = !flag5;
			double num = 1.0;
			float num2 = 1.05360915E+09f;
			object obj17 = 0;
			UnityEngine.Object obj18 = null;
			if (!flag6)
			{
				goto IL_05ac;
			}
		}
		goto IL_0662;
		IL_06d6:
		UnityEngine.Object obj19;
		bool flag7 = obj19 != null;
		bool flag8 = !flag7;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			return;
		}
		goto IL_0791;
		IL_00cc:
		bool flag9 = obj8 != null;
		bool flag10 = !flag9;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			goto IL_00fe;
		}
		goto IL_0303;
		IL_0303:
		KRadioPickerGroup kRadioPickerGroup2 = _group;
		kRadioPickerGroup2.<IsUpdating>k__BackingField = true;
		component = layout;
		bool flag11 = <IsShown>k__BackingField;
		UnityEngine.Component component2 = layout;
		if (flag11)
		{
			goto IL_0134;
		}
		goto IL_0353;
		IL_00fe:
		component = layout;
		bool flag12 = !<IsShown>k__BackingField;
		component2 = layout;
		if (!flag12)
		{
			goto IL_0134;
		}
		goto IL_0353;
		IL_0353:
		Transform target2 = component2.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 0f, 0.2f);
		object obj22 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj23 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)3152;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj24);
		object obj25 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		object obj26 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v24+E4]");
		if ((nint)0 != 0)
		{
			bool flag13 = blocker != null;
			bool flag14 = !flag13;
			object obj27 = !flag14;
			object obj28 = 0;
			if (obj27 != null)
			{
				goto IL_04ef;
			}
			object obj29 = 0;
			double num = 0.0;
			float num2 = 1.04522054E+09f;
			object obj17 = 0;
			UnityEngine.Object obj18 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag15 = blocker != null;
			bool flag16 = !flag15;
			object obj28 = 0;
			object obj29 = 0;
			double num = 0.0;
			float num2 = 1.04522054E+09f;
			object obj17 = 0;
			UnityEngine.Object obj18 = null;
			if (!flag16)
			{
				goto IL_04ef;
			}
		}
		goto IL_0662;
		IL_05ac:
		GameObject gameObject2 = blocker.gameObject;
		gameObject2.SetActive(value: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = DOTweenModuleUI.DOFade(blockerImage, origianlBlockerFade, 0.3f);
		object obj30 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)3144;
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(obj2, (IntPtr)obj31);
		object obj32 = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Transform transform2 = base.transform;
		transform2.SetParent(blocker);
		return;
		IL_0662:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v2+63A]");
		object obj33 = (nint)0 & (nint)1;
		UnityEngine.Object obj35;
		if (obj33 != null)
		{
			obj19 = _group;
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v9+E4]");
			bool flag17 = (nint)0 == 0;
			obj35 = _group;
			if (!flag17)
			{
				goto IL_06d6;
			}
		}
		else
		{
			_ = 1;
			obj19 = _group;
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v9+E4]");
			bool flag18 = (nint)0 == 0;
			object obj36 = !flag18;
			obj35 = _group;
			if (obj36 != null)
			{
				goto IL_06d6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj35 != null))
		{
			return;
		}
		goto IL_0791;
		IL_04ef:
		TweenerCore<Color, Color, ColorOptions> tweenerCore4 = DOTweenModuleUI.DOFade(blockerImage, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)3160;
		TweenCallback tweenCallback3 = default(TweenCallback);
		tweenCallback3..ctor(obj2, (IntPtr)obj37);
		object obj38 = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void SetGroupUpdating(bool value)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E763A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj5 = _group;
			obj6 = _group;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = _group;
			obj6 = _group;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj6 != null))
		{
			return;
		}
		goto IL_014c;
		IL_014c:
		KRadioPickerGroup kRadioPickerGroup = _group;
		kRadioPickerGroup.<IsUpdating>k__BackingField = value;
		return;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_014c;
	}

	private void <Awake>b__34_0()
	{
		if (<IsShown>k__BackingField)
		{
			<IsShown>k__BackingField = false;
			UpdateUI();
		}
	}
}
