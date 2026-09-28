using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SettingEmotesSection : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreItem, bool> <>9__19_0;

		public static Func<StoreItem, int> <>9__19_1;

		public static Predicate<Transform> <>9__24_0;

		public static Func<QuickPhotoReplySetup, int> <>9__26_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Initialize>b__19_0(StoreItem i)
		{
			//IL_003d: Expected I4, but got O
			if (i != null)
			{
				return i.IsActiveAndNotAd;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <Initialize>b__19_1(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<Order>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <AddBottomEmote>b__24_0(Transform t)
		{
			//IL_009f: Expected I4, but got O
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			if ((object)t != null)
			{
				object obj = (nint)0 + (nint)4016;
				object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+E4]");
				UnityEngine.Object obj4 = default(UnityEngine.Object);
				if ((nint)0 != 0)
				{
					return obj4 == null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return obj4 == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <SaveSelection>b__26_0(QuickPhotoReplySetup e)
		{
			//IL_0064: Expected I4, but got O
			if ((object)e != null)
			{
				StoreItem item = e.item;
				if (e.item != null)
				{
					return item.<id>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public bool isOn;

		internal void <OnToggleChanged>b__0(QuickPhotoReplySetup k)
		{
			bool closeIndicatorVisibility = !isOn;
			k.SetCloseIndicatorVisibility(closeIndicatorVisibility);
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public int emoteId;

		internal bool <LoadSavedEmotes>b__0(QuickPhotoReplySetup e)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if ((object)e != null)
			{
				StoreItem item = e.item;
				if (e.item != null)
				{
					object obj = item.<id>k__BackingField - emoteId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public SettingEmotesSection <>4__this;

		public QuickPhotoReplySetup topEmote;

		internal void <AddBottomEmote>b__1()
		{
			<>4__this.OnEmoteClicked(topEmote);
		}
	}

	private RectTransform bottomPanelContent;

	private RectTransform topPanel;

	private EmoteViewer emoteViewer;

	private Image playBackProgress;

	private SpriteSheetPlayer spritePlayer;

	private QuickPhotoReplySetup replayPhotoPrefab;

	private Toggle toggle;

	private GameObject plusSlotPrefab;

	private SlideAnimationHelper sortEmotePopup;

	private readonly List<StoreItem> selectedItems;

	private readonly Dictionary<QuickPhotoReplySetup, QuickPhotoReplySetup> topToBottom;

	private readonly List<Transform> topOrder;

	private bool isInitialized;

	public bool previewMode;

	public void Open()
	{
		sortEmotePopup.SlideIn();
		if (isInitialized)
		{
			LoadSavedEmotes();
		}
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_004e: Expected O, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_009d: Expected I, but got O
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I
		//IL_00ee: Expected I, but got O
		//IL_011d: Expected O, but got I
		//IL_0135: Expected I, but got O
		//IL_0146: Expected O, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0189: Expected I, but got O
		//IL_01b3: Expected O, but got I4
		Toggle toggle = this.toggle;
		object obj = typeof(TypeConverter<ushort, char>) + 360;
		object obj2 = (nint)0 + (nint)3192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)832;
		object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 512;
		object obj5 = (nint)0 + (nint)3216;
		toggle.onValueChanged.AddListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, object> action = default(Action<int, object>);
		action..ctor((object)this, (IntPtr)obj5);
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)3208;
		spritePlayer.OnFrameChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj7);
		spritePlayer.OnCompleted += action2;
		Toggle toggle2 = this.toggle;
		object obj8 = (nint)0 + (nint)3184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction2 = default(UnityAction<bool>);
		unityAction2..ctor((object)this, (IntPtr)obj8);
		object obj9 = (nint)0 + (nint)3168;
		object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		toggle2.onValueChanged.AddListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj9);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v18+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action3);
	}

	private void OnToggleChanged(bool isOn)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_007f: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)520;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3224;
		object obj5 = (nint)0 + (nint)1960;
		Dictionary<object, object>.KeyCollection keys = ((Dictionary<object, object>)(object)topToBottom).Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		ArraysExtensions.ForEach(keys, action);
	}

	private void SpritePlayer_OnCompleted()
	{
		GameObject gameObject = playBackProgress.gameObject;
		gameObject.SetActive(value: false);
	}

	private void SpritePlayer_OnFrameChanged(int frameIndex, Sprite frame)
	{
		float playbackProgress = spritePlayer.PlaybackProgress;
		float fillAmount = 1f - playbackProgress;
		playBackProgress.fillAmount = fillAmount;
	}

	private void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_126b: Expected O, but got Unknown
		//IL_1295: Expected O, but got I4
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_006f: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_00b1: Expected O, but got I4
		//IL_1338: Expected O, but got I
		//IL_1344: Expected O, but got I
		//IL_1353: Unknown result type (might be due to invalid IL or missing references)
		//IL_1358: Expected O, but got Unknown
		//IL_1368: Expected O, but got I
		//IL_1378: Expected O, but got I
		//IL_139a: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_025c: Expected O, but got I
		//IL_12b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b7: Expected O, but got Unknown
		//IL_12cd: Expected O, but got I
		//IL_12de: Expected I, but got O
		//IL_12fc: Expected O, but got I
		//IL_1317: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0194: Expected O, but got I
		//IL_13b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Expected O, but got Unknown
		//IL_13d2: Expected O, but got I
		//IL_13e3: Expected I, but got O
		//IL_1401: Expected O, but got I
		//IL_141c: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_0349: Expected O, but got I
		//IL_03c8: Expected O, but got I4
		//IL_04a2: Expected O, but got I
		//IL_04b2: Expected O, but got I
		//IL_04c2: Expected O, but got I
		//IL_050f: Expected O, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_060d: Expected O, but got I4
		//IL_06e7: Expected O, but got I
		//IL_06f7: Expected O, but got I
		//IL_0707: Expected O, but got I
		//IL_0754: Expected O, but got I4
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected O, but got Unknown
		//IL_06b0: Expected O, but got I4
		//IL_0852: Expected O, but got I4
		//IL_092c: Expected O, but got I
		//IL_093c: Expected O, but got I
		//IL_094c: Expected O, but got I
		//IL_098f: Expected O, but got I4
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected O, but got Unknown
		//IL_08eb: Expected O, but got I4
		//IL_0ace: Expected O, but got I4
		//IL_0ba8: Expected O, but got I
		//IL_0bb8: Expected O, but got I
		//IL_0bc8: Expected O, but got I
		//IL_0c0b: Expected O, but got I4
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected O, but got Unknown
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_0b67: Expected O, but got I4
		//IL_0d4a: Expected O, but got I4
		//IL_0e24: Expected O, but got I
		//IL_0e34: Expected O, but got I
		//IL_0e44: Expected O, but got I
		//IL_0e87: Expected O, but got I4
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected O, but got Unknown
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected O, but got Unknown
		//IL_0de3: Expected O, but got I4
		//IL_0fc6: Expected O, but got I4
		//IL_1040: Expected O, but got I
		//IL_1050: Expected O, but got I
		//IL_1060: Expected O, but got I
		//IL_1006: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Expected O, but got Unknown
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_1019: Expected O, but got Unknown
		//IL_10a6: Expected O, but got I
		//IL_10b2: Expected O, but got I
		//IL_10be: Expected O, but got I
		//IL_10fa: Expected O, but got I4
		//IL_119f: Expected O, but got I4
		//IL_115a: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3112;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<StoreItem> categoryItems = Store.GetCategoryItems(ItemCategory.Emotes);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v126+E4]");
		object obj7;
		Func<object, bool> predicate;
		object obj9;
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = (nint)0 + (nint)3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v126+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v73+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v73+8]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				obj9 = obj6;
				goto IL_0142;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			obj9 = (nint)0 + (nint)3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v126+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v73+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v73+8]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj6 = obj9;
			if (obj10 == null)
			{
				goto IL_0142;
			}
		}
		goto IL_0199;
		IL_09da:
		object obj11;
		SettingEmotesSection settingEmotesSection = (SettingEmotesSection)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject = default(GameObject);
		bool flag4 = (object)gameObject == null;
		object obj13;
		object obj12 = obj13;
		object obj15;
		object obj20;
		object obj22;
		object obj23;
		GameObject gameObject3;
		GameObject gameObject2;
		if (!flag4)
		{
			Transform transform = gameObject.transform;
			List<object> list = (List<object>)(object)topOrder;
			bool flag5 = topOrder == null;
			obj12 = transform;
			if (!flag5)
			{
				object obj14 = obj15;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag6 = list._items == null;
				obj12 = transform;
				if (!flag6)
				{
					bool flag7 = list._size < items.Length;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj17 = list._items + list._size;
						object obj18 = obj17 + 32;
						obj18 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						gameObject2 = plusSlotPrefab;
						object obj19 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v83+E4]");
						bool flag8 = (nint)0 == 0;
						object obj21 = !flag8;
						obj22 = topPanel;
						if (obj21 == null)
						{
							obj23 = topPanel;
							gameObject3 = plusSlotPrefab;
							goto IL_0c37;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v19+20]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v40+C0]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v41+70]");
						settingEmotesSection = (SettingEmotesSection)0;
						((List<object>)(object)topOrder).AddWithResize((object)transform);
						gameObject3 = plusSlotPrefab;
						object obj19 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v83+E4]");
						bool flag9 = (nint)0 == 0;
						object obj26 = !flag9;
						obj23 = topPanel;
						obj22 = topPanel;
						gameObject2 = plusSlotPrefab;
						if (obj26 == null)
						{
							goto IL_0c37;
						}
					}
					goto IL_0c56;
				}
			}
		}
		goto IL_1429;
		IL_09bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj27;
		obj13 = obj27;
		GameObject gameObject5;
		GameObject gameObject4 = gameObject5;
		goto IL_09da;
		IL_0776:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj28;
		obj12 = obj28;
		GameObject gameObject7;
		GameObject gameObject6 = gameObject7;
		goto IL_1466;
		IL_0c56:
		settingEmotesSection = (SettingEmotesSection)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject8 = default(GameObject);
		bool flag10 = (object)gameObject8 == null;
		obj12 = obj22;
		object obj35;
		object obj36;
		GameObject gameObject10;
		GameObject gameObject9;
		if (!flag10)
		{
			Transform transform2 = gameObject8.transform;
			List<object> list2 = (List<object>)(object)topOrder;
			bool flag11 = topOrder == null;
			obj12 = transform2;
			if (!flag11)
			{
				object obj29 = obj15;
				int version2 = list2._version + 1;
				list2._version = version2;
				object[] items2 = list2._items;
				bool flag12 = list2._items == null;
				obj12 = transform2;
				if (!flag12)
				{
					bool flag13 = list2._size < items2.Length;
					object obj30 = !flag13;
					if (obj30 == null)
					{
						int size2 = list2._size + 1;
						list2._size = size2;
						object obj31 = list2._items + list2._size;
						object obj32 = obj31 + 32;
						obj32 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						gameObject9 = plusSlotPrefab;
						object obj33 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v76+E4]");
						bool flag14 = (nint)0 == 0;
						object obj34 = !flag14;
						obj35 = topPanel;
						if (obj34 == null)
						{
							obj36 = topPanel;
							gameObject10 = plusSlotPrefab;
							goto IL_0eb3;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v21+20]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v34+C0]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v35+70]");
						settingEmotesSection = (SettingEmotesSection)0;
						((List<object>)(object)topOrder).AddWithResize((object)transform2);
						gameObject10 = plusSlotPrefab;
						object obj33 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v76+E4]");
						bool flag15 = (nint)0 == 0;
						object obj39 = !flag15;
						obj36 = topPanel;
						obj35 = topPanel;
						gameObject9 = plusSlotPrefab;
						if (obj39 == null)
						{
							goto IL_0eb3;
						}
					}
					goto IL_0ed2;
				}
			}
		}
		goto IL_1429;
		IL_1466:
		settingEmotesSection = (SettingEmotesSection)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject11 = default(GameObject);
		if ((object)gameObject11 != null)
		{
			Transform transform3 = gameObject11.transform;
			List<object> list3 = (List<object>)(object)topOrder;
			bool flag16 = topOrder == null;
			obj12 = transform3;
			if (!flag16)
			{
				object obj40 = obj15;
				int version3 = list3._version + 1;
				list3._version = version3;
				object[] items3 = list3._items;
				bool flag17 = list3._items == null;
				obj12 = transform3;
				if (!flag17)
				{
					bool flag18 = list3._size < items3.Length;
					object obj41 = !flag18;
					if (obj41 == null)
					{
						int size3 = list3._size + 1;
						list3._size = size3;
						object obj42 = list3._items + list3._size;
						object obj43 = obj42 + 32;
						obj43 = transform3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						gameObject4 = plusSlotPrefab;
						object obj44 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v90+E4]");
						bool flag19 = (nint)0 == 0;
						object obj45 = !flag19;
						obj13 = topPanel;
						if (obj45 == null)
						{
							obj27 = topPanel;
							gameObject5 = plusSlotPrefab;
							goto IL_09bb;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v17+20]");
						object obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v46+C0]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v47+70]");
						settingEmotesSection = (SettingEmotesSection)0;
						((List<object>)(object)topOrder).AddWithResize((object)transform3);
						gameObject5 = plusSlotPrefab;
						object obj44 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v90+E4]");
						bool flag20 = (nint)0 == 0;
						object obj48 = !flag20;
						obj27 = topPanel;
						obj13 = topPanel;
						gameObject4 = plusSlotPrefab;
						if (obj48 == null)
						{
							goto IL_09bb;
						}
					}
					goto IL_09da;
				}
			}
		}
		goto IL_1429;
		IL_0142:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v126+E4]");
		bool flag21 = (nint)0 == 0;
		object obj49 = !flag21;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj50 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v79+B8]");
			obj7 = 0;
		}
		object obj51 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj52 = (nint)0 + (nint)1936;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj7, (IntPtr)obj52);
		object obj53 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v78+B8]");
		object obj54 = (nint)0 + (nint)8;
		obj54 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj55 = 0;
		obj6 = obj9;
		predicate = func;
		goto IL_0199;
		IL_117a:
		LoadSavedEmotes();
		isInitialized = true;
		return;
		IL_0eb3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj35 = obj36;
		gameObject9 = gameObject10;
		goto IL_0ed2;
		IL_0199:
		IEnumerable<object> source = Enumerable.Where(categoryItems, predicate);
		object obj56 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v11+E4]");
		bool flag22 = (nint)0 == 0;
		object obj57 = !flag22;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj56 = obj2;
		}
		object obj58 = (nint)0 + (nint)2232;
		object obj59 = (nint)0 + (nint)2720;
		obj20 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v11+B8]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v64+10]");
		Func<object, int> keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v64+10]");
		bool flag23 = (nint)0 == 0;
		object obj61 = !flag23;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v11+E4]");
			bool flag24 = (nint)0 == 0;
			object obj62 = !flag24;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj63 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v70+B8]");
				obj60 = 0;
			}
			object obj64 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj65 = (nint)0 + (nint)1944;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj60, (IntPtr)obj65);
			object obj66 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v69+B8]");
			object obj67 = (nint)0 + (nint)16;
			obj67 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj55 = 0;
			keySelector = func2;
		}
		obj11 = (nint)0 + (nint)544;
		IOrderedEnumerable<object> source2 = Enumerable.OrderBy(source, keySelector);
		List<object> list4 = Enumerable.ToList(source2);
		object obj68 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v16+E4]");
		bool flag25 = (nint)0 == 0;
		object obj69 = !flag25;
		if (obj69 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		settingEmotesSection = (SettingEmotesSection)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject12 = default(GameObject);
		bool flag26 = (object)gameObject12 == null;
		obj12 = topPanel;
		object obj76;
		GameObject gameObject14;
		GameObject gameObject13;
		if (!flag26)
		{
			Transform transform4 = gameObject12.transform;
			List<object> list5 = (List<object>)(object)topOrder;
			bool flag27 = topOrder == null;
			obj12 = transform4;
			if (!flag27)
			{
				obj15 = (nint)0 + (nint)1744;
				object obj70 = obj15;
				int version4 = list5._version + 1;
				list5._version = version4;
				object[] items4 = list5._items;
				bool flag28 = list5._items == null;
				obj12 = transform4;
				if (!flag28)
				{
					bool flag29 = list5._size < items4.Length;
					object obj71 = !flag29;
					if (obj71 == null)
					{
						int size4 = list5._size + 1;
						list5._size = size4;
						object obj72 = list5._items + list5._size;
						object obj73 = obj72 + 32;
						obj73 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						gameObject13 = plusSlotPrefab;
						obj12 = topPanel;
						object obj74 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v57+E4]");
						bool flag30 = (nint)0 == 0;
						object obj75 = !flag30;
						if (obj75 == null)
						{
							obj76 = topPanel;
							gameObject14 = plusSlotPrefab;
							goto IL_0531;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v13+20]");
						object obj77 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v58+C0]");
						object obj78 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v59+70]");
						settingEmotesSection = (SettingEmotesSection)0;
						((List<object>)(object)topOrder).AddWithResize((object)transform4);
						gameObject14 = plusSlotPrefab;
						obj76 = topPanel;
						object obj74 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v57+E4]");
						bool flag31 = (nint)0 == 0;
						object obj79 = !flag31;
						obj12 = topPanel;
						gameObject13 = plusSlotPrefab;
						if (obj79 == null)
						{
							goto IL_0531;
						}
					}
					goto IL_1437;
				}
			}
		}
		goto IL_1429;
		IL_0531:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj76;
		gameObject13 = gameObject14;
		goto IL_1437;
		IL_118c:
		NullReferenceException ex = new NullReferenceException();
		object obj80 = 0;
		obj12 = bottomPanelContent;
		goto IL_1429;
		IL_1429:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag32 = (nint)obj12 != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		if (!flag32)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj12 = obj11;
			enumerator.Dispose();
			object obj81 = default(object);
			if (obj81 == null)
			{
				goto IL_117a;
			}
			ex3 = new OutOfMemoryException();
			obj80 = obj81;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238594");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0c37:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj22 = obj23;
		gameObject2 = gameObject3;
		goto IL_0c56;
		IL_0ed2:
		settingEmotesSection = (SettingEmotesSection)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject15 = default(GameObject);
		bool flag33 = (object)gameObject15 == null;
		obj12 = obj35;
		if (!flag33)
		{
			Transform transform5 = gameObject15.transform;
			List<object> list6 = (List<object>)(object)topOrder;
			bool flag34 = topOrder == null;
			obj12 = transform5;
			if (!flag34)
			{
				object obj82 = obj15;
				int version5 = list6._version + 1;
				list6._version = version5;
				object[] items5 = list6._items;
				bool flag35 = list6._items == null;
				obj12 = transform5;
				if (!flag35)
				{
					bool flag36 = list6._size < items5.Length;
					object obj83 = !flag36;
					if (obj83 == null)
					{
						int size5 = list6._size + 1;
						list6._size = size5;
						object obj84 = list6._items + list6._size;
						object obj85 = obj84 + 32;
						obj85 = transform5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v23+20]");
						object obj86 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X8_v30+C0]");
						object obj87 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v31+70]");
						settingEmotesSection = (SettingEmotesSection)0;
						((List<object>)(object)topOrder).AddWithResize((object)transform5);
					}
					bool flag37 = list4 == null;
					obj12 = transform5;
					if (!flag37)
					{
						object obj88 = (nint)0 + (nint)1800;
						object obj89 = (nint)0 + (nint)640;
						obj11 = (nint)0 + (nint)1792;
						List<object>.Enumerator enumerator2 = list4.GetEnumerator();
						QuickPhotoReplySetup quickPhotoReplySetup = default(QuickPhotoReplySetup);
						while (enumerator.MoveNext())
						{
							object obj90 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X0_v67+E4]");
							bool flag38 = (nint)0 == 0;
							object obj91 = !flag38;
							if (obj91 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							settingEmotesSection = (SettingEmotesSection)obj89;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
							if ((object)quickPhotoReplySetup != null)
							{
								quickPhotoReplySetup.Setup(null, this);
								obj55 = 0;
								settingEmotesSection = this;
								continue;
							}
							goto IL_118c;
						}
						obj12 = obj11;
						enumerator.Dispose();
						goto IL_117a;
					}
				}
			}
		}
		goto IL_1429;
		IL_1437:
		settingEmotesSection = (SettingEmotesSection)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject16 = default(GameObject);
		if ((object)gameObject16 != null)
		{
			Transform transform6 = gameObject16.transform;
			List<object> list7 = (List<object>)(object)topOrder;
			bool flag39 = topOrder == null;
			obj12 = transform6;
			if (!flag39)
			{
				object obj92 = obj15;
				int version6 = list7._version + 1;
				list7._version = version6;
				object[] items6 = list7._items;
				bool flag40 = list7._items == null;
				obj12 = transform6;
				if (!flag40)
				{
					bool flag41 = list7._size < items6.Length;
					object obj93 = !flag41;
					if (obj93 == null)
					{
						int size6 = list7._size + 1;
						list7._size = size6;
						object obj94 = list7._items + list7._size;
						object obj95 = obj94 + 32;
						obj95 = transform6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						gameObject6 = plusSlotPrefab;
						obj12 = topPanel;
						object obj96 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v51+E4]");
						bool flag42 = (nint)0 == 0;
						object obj97 = !flag42;
						if (obj97 == null)
						{
							obj28 = topPanel;
							gameObject7 = plusSlotPrefab;
							goto IL_0776;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v15+20]");
						object obj98 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v52+C0]");
						object obj99 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v53+70]");
						settingEmotesSection = (SettingEmotesSection)0;
						((List<object>)(object)topOrder).AddWithResize((object)transform6);
						gameObject7 = plusSlotPrefab;
						obj28 = topPanel;
						object obj96 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v51+E4]");
						bool flag43 = (nint)0 == 0;
						object obj100 = !flag43;
						obj12 = topPanel;
						gameObject6 = plusSlotPrefab;
						if (obj100 == null)
						{
							goto IL_0776;
						}
					}
					goto IL_1466;
				}
			}
		}
		goto IL_1429;
	}

	private void LoadSavedEmotes()
	{
		//IL_0631: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0029: Expected I, but got O
		//IL_0053: Expected O, but got I4
		//IL_05aa: Expected O, but got I
		//IL_05b2: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_0086: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0655: Expected I, but got O
		//IL_0164: Expected O, but got I
		//IL_016c: Expected I, but got O
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_01dc: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_0478: Expected O, but got I4
		//IL_0489: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_0272: Expected O, but got I4
		//IL_0277: Expected I, but got O
		//IL_04a0: Expected O, but got I4
		//IL_04b1: Expected O, but got I4
		//IL_04b9: Expected I, but got O
		//IL_02a2: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02b8: Expected I, but got O
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_04e0: Expected O, but got I4
		//IL_04e5: Expected I, but got O
		//IL_050c: Expected O, but got I4
		//IL_0511: Expected I, but got O
		//IL_0375: Expected I, but got O
		//IL_03b5: Expected O, but got I4
		//IL_03f8: Expected O, but got I4
		//IL_0401: Expected O, but got I4
		//IL_0528: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_054a: Expected O, but got I4
		//IL_0552: Expected I, but got O
		//IL_0448: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		bool flag = topToBottom == null;
		List<int>.Enumerator enumerator = (List<int>.Enumerator)0;
		nint num = default(nint);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2592;
			Dictionary<object, object>.KeyCollection keys = ((Dictionary<object, object>)(object)topToBottom).Keys;
			num = (nint)obj;
			List<object> list = Enumerable.ToList(keys);
			bool flag2 = list == null;
			enumerator = (List<int>.Enumerator)0;
			if (!flag2)
			{
				object obj2 = (nint)0 + (nint)360;
				object obj3 = (nint)0 + (nint)512;
				object obj4 = (nint)0 + (nint)2392;
				object obj5 = (nint)0 + (nint)720;
				object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3016;
				object obj7 = (nint)0 + (nint)1968;
				object obj8 = (nint)0 + (nint)1128;
				object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
				List<object>.Enumerator enumerator2 = list.GetEnumerator();
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				object obj12 = default(object);
				SessionModel sessionModel = default(SessionModel);
				List<int>.Enumerator enumerator7 = default(List<int>.Enumerator);
				object obj19 = default(object);
				Func<object, bool> func = default(Func<object, bool>);
				IEnumerable<object> source = default(IEnumerable<object>);
				List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
				while (true)
				{
					num = (nint)obj2;
					List<object>.Enumerator enumerator4;
					if (enumerator3.MoveNext())
					{
						if (topToBottom != null)
						{
							object obj10 = obj3;
							object obj11 = ((Dictionary<object, object>)(object)topToBottom).get_Item(obj12);
							if (obj11 != null)
							{
								((QuickPhotoReplySetup)obj11).Deselect();
								RemoveTopEmote((QuickPhotoReplySetup)obj12);
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							enumerator = (List<int>.Enumerator)0;
							enumerator4 = enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							num = (nint)obj12;
							break;
						}
						NullReferenceException ex2 = new NullReferenceException();
						enumerator = (List<int>.Enumerator)0;
						enumerator4 = enumerator5;
						enumerator5 = (List<object>.Enumerator)0;
						break;
					}
					object obj13 = (nint)0 + (nint)352;
					num = (nint)obj13;
					enumerator3.Dispose();
					object obj14 = typeof(Queue<string>) + 848;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v25+E4]");
					bool flag3 = (nint)0 == 0;
					object obj16 = !flag3;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj17 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					bool flag4 = (object)sessionModel == null;
					enumerator = (List<int>.Enumerator)0;
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					if (flag4)
					{
						break;
					}
					User localUser = sessionModel.LocalUser;
					int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
					EmoteSaveData emoteSaveData = EmoteSaveData.LoadEmoteSaveData(intDbId);
					bool flag5 = emoteSaveData == null;
					enumerator = (List<int>.Enumerator)0;
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					num = unchecked((nint)null);
					if (flag5)
					{
						break;
					}
					bool flag6 = emoteSaveData.manuallyOrderedEmotes == null;
					enumerator = (List<int>.Enumerator)0;
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					num = unchecked((nint)null);
					if (flag6)
					{
						break;
					}
					List<int>.Enumerator enumerator6 = emoteSaveData.manuallyOrderedEmotes.GetEnumerator();
					while (true)
					{
						if (enumerator7.MoveNext())
						{
							object obj18 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3128;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							obj19..ctor();
							if (obj19 != null)
							{
								if ((object)bottomPanelContent != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									func..ctor(obj19, (IntPtr)obj7);
									object obj20 = Enumerable.FirstOrDefault(source, func);
									object obj21 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v48+E4]");
									bool flag7 = (nint)0 == 0;
									object obj22 = !flag7;
									if (obj22 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag8 = (UnityEngine.Object)obj20 != null;
									bool flag9 = !flag8;
									object obj23 = 0;
									object obj10 = 0;
									if (!flag9)
									{
										AddBottomEmote((QuickPhotoReplySetup)obj20);
										if (obj20 == null)
										{
											NullReferenceException ex3 = new NullReferenceException();
											obj23 = 0;
											enumerator = (List<int>.Enumerator)enumerator5;
											obj10 = 0;
											enumerator4 = enumerator5;
											enumerator5 = (List<object>.Enumerator)0;
											num = (nint)obj20;
											break;
										}
										((QuickPhotoReplySetup)obj20).Select();
										obj23 = 0;
										obj10 = 0;
									}
									continue;
								}
								NullReferenceException ex4 = new NullReferenceException();
								enumerator = (List<int>.Enumerator)enumerator5;
								enumerator4 = enumerator5;
								enumerator5 = (List<object>.Enumerator)0;
								num = unchecked((nint)null);
								break;
							}
							NullReferenceException ex5 = new NullReferenceException();
							enumerator = (List<int>.Enumerator)enumerator5;
							enumerator4 = enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							num = unchecked((nint)null);
							break;
						}
						enumerator7.Dispose();
						return;
					}
					break;
				}
			}
		}
		NullReferenceException ex6 = new NullReferenceException();
		bool flag10 = num != 1;
		OutOfMemoryException ex7 = (OutOfMemoryException)(object)ex6;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj24 = (nint)0 + (nint)2384;
			num = (nint)obj24;
			enumerator.Dispose();
			object obj25 = default(object);
			if (obj25 == null)
			{
				return;
			}
			ex7 = new OutOfMemoryException();
			List<object>.Enumerator enumerator5 = (List<object>.Enumerator)obj25;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBC9E0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void OnEmoteClicked(QuickPhotoReplySetup emote)
	{
		if (((Dictionary<object, object>)(object)topToBottom).TryGetValue((object)emote, out object value))
		{
			if (previewMode)
			{
				OnPreviewClicked(emote.item);
				return;
			}
			((QuickPhotoReplySetup)value).Deselect();
			RemoveTopEmote(emote);
		}
		else
		{
			emote.Select();
			AddBottomEmote(emote);
		}
	}

	public void OnPreviewClicked(StoreItem item)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_0081: Expected O, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00f4: Expected I, but got O
		emoteViewer.PlayLoadingEmote();
		GameObject gameObject = playBackProgress.gameObject;
		object obj = typeof(Queue<string>) + 688;
		object obj2 = (nint)0 + (nint)1888;
		gameObject.SetActive(value: true);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1888;
		object obj6 = (nint)0 + (nint)3160;
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		AnimatedAssetsLoader animatedAssetsLoader = default(AnimatedAssetsLoader);
		animatedAssetsLoader.LoadEmoteItem(item.<id>k__BackingField, go, action);
	}

	public void CreateEmote(EmoteItemData data, EmoteViewer target, Texture2D framesTexture, AudioClip clip)
	{
		framesTexture.filterMode = FilterMode.Bilinear;
		target.PlayEmote(clip, framesTexture, data.gridSize, data.duration, data.delayAudio, data.shiftMask);
	}

	private void AddBottomEmote(QuickPhotoReplySetup bottomEmote)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0079: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_016e: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_020e: Expected O, but got I
		//IL_022f: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_0588: Expected O, but got I
		//IL_0599: Expected I, but got O
		//IL_05b7: Expected O, but got I
		//IL_01f0: Expected O, but got I
		//IL_02af: Expected O, but got I4
		//IL_033f: Expected O, but got I
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_03b4: Expected O, but got I4
		//IL_05e3: Expected O, but got I
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_0435: Expected O, but got I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected I4, but got Unknown
		//IL_046d: Expected O, but got I
		//IL_0483: Expected O, but got I
		//IL_04a0: Expected O, but got I
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04cf: Expected O, but got I
		//IL_04e0: Expected I, but got O
		//IL_04fa: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (nint)0 + (nint)2896;
		bool flag = ((List<object>)(object)selectedItems).Contains((object)bottomEmote.item);
		bool flag2 = !flag;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		object obj6 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3112;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v46+E4]");
		object obj8;
		Predicate<object> match;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v46+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v40+18]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v40+18]");
			if ((nint)0 != 0)
			{
				goto IL_010d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v46+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v40+18]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v40+18]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_010d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v46+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v46+B8]");
			obj8 = 0;
		}
		object obj12 = typeof(List<Tween>) + 3584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)1928;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj8, (IntPtr)obj13);
		object obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v45+B8]");
		object obj15 = (nint)0 + (nint)24;
		obj15 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		match = predicate;
		goto IL_0202;
		IL_0202:
		object obj16 = (nint)0 + (nint)1760;
		int num = ((List<object>)(object)topOrder).FindIndex(match);
		object obj17 = num + 1;
		if (obj17 != null)
		{
			List<object> list = (List<object>)(object)selectedItems;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag5 = list._size < items.Length;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj19 = items + list._size;
				object obj20 = obj19 + 32;
				obj20 = bottomEmote.item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize((object)bottomEmote.item);
			}
			object obj21 = (nint)0 + (nint)1800;
			object obj22 = ((List<object>)(object)topOrder).get_Item(num);
			int siblingIndex = ((Transform)obj22).GetSiblingIndex();
			GameObject gameObject = ((Component)obj22).gameObject;
			object obj23 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj25 = !flag6;
			UnityEngine.Object obj26 = gameObject;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = gameObject;
			}
			UnityEngine.Object.Destroy(obj26);
			object obj27 = (nint)0 + (nint)640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			object obj28 = obj2 + 24;
			object obj29 = default(object);
			obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((QuickPhotoReplySetup)obj28).Setup(bottomEmote.item, this);
			Transform transform = ((Component)obj28).transform;
			transform.SetSiblingIndex(siblingIndex);
			Toggle toggle = this.toggle;
			object obj30 = ~(toggle.m_IsOn ? 1 : 0);
			bool closeIndicatorVisibility = (byte)(1 & obj30) != 0;
			((QuickPhotoReplySetup)obj28).SetCloseIndicatorVisibility(closeIndicatorVisibility);
			object obj31 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v24+28]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v25+100]");
			((UnityEventBase)0).RemoveAllListeners();
			object obj33 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v26+28]");
			object obj34 = 0;
			object obj35 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj36 = (nint)0 + (nint)1976;
			UnityAction unityAction = default(UnityAction);
			unityAction..ctor(obj2, (IntPtr)obj36);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v27+100]");
			((UnityEvent)0).AddListener(unityAction);
			Transform value = ((Component)obj28).transform;
			((List<object>)(object)topOrder).set_Item(num, (object)value);
			((Dictionary<object, object>)(object)topToBottom).set_Item(obj28, (object)bottomEmote);
		}
		return;
		IL_010d:
		bool flag7 = topOrder == null;
		object obj37 = !flag7;
		if (obj37 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0202;
	}

	private void RemoveTopEmote(QuickPhotoReplySetup topEmote)
	{
		//IL_0039: Expected O, but got I4
		//IL_0062: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00f5: Expected O, but got I4
		Transform item = topEmote.transform;
		int num = ((List<object>)(object)topOrder).IndexOf((object)item);
		object obj = num + 1;
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)2920;
			bool flag = ((List<object>)(object)selectedItems).Remove((object)topEmote.item);
			Transform transform = topEmote.transform;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = (nint)0 + (nint)544;
			int siblingIndex = transform.GetSiblingIndex();
			GameObject gameObject = topEmote.gameObject;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			UnityEngine.Object obj7 = gameObject;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = gameObject;
			}
			UnityEngine.Object.Destroy(obj7);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			GameObject gameObject2 = default(GameObject);
			Transform transform2 = gameObject2.transform;
			transform2.SetSiblingIndex(siblingIndex);
			Transform value = gameObject2.transform;
			((List<object>)(object)topOrder).set_Item(num, (object)value);
			bool flag3 = ((Dictionary<object, object>)(object)topToBottom).Remove((object)topEmote);
		}
	}

	public void SaveSelection()
	{
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_095e: Expected O, but got I
		//IL_077f: Expected O, but got I
		//IL_078b: Expected O, but got I
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07af: Expected O, but got I
		//IL_07bf: Expected O, but got I
		//IL_07e1: Expected O, but got I4
		//IL_00f1: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_0819: Expected O, but got I
		//IL_082a: Expected I, but got O
		//IL_0848: Expected O, but got I
		//IL_0863: Expected O, but got I4
		//IL_00e0: Expected O, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected I, but got Unknown
		//IL_01f1: Expected I, but got O
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0282: Expected I, but got O
		//IL_0292: Expected O, but got I
		//IL_0344: Expected O, but got I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_03f4: Expected O, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_041b: Expected O, but got I
		//IL_02cd: Expected O, but got I
		//IL_08da: Expected I, but got O
		//IL_0456: Expected O, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected I, but got Unknown
		//IL_04fe: Expected O, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected I, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0538: Expected O, but got I
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_05ce: Expected I, but got O
		//IL_05f8: Expected O, but got I4
		//IL_0573: Expected O, but got I
		//IL_060e: Expected I, but got O
		//IL_061e: Expected O, but got I
		//IL_06ad: Expected O, but got I4
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_06dd: Expected I, but got O
		//IL_0701: Expected O, but got I4
		//IL_070a: Expected O, but got I4
		//IL_0659: Expected O, but got I
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_0938: Expected O, but got I4
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68A8]");
		nint num = 0;
		object obj23;
		object obj24 = default(object);
		object obj26 = default(object);
		object obj16;
		if ((object)topPanel != null)
		{
			object obj = (nint)0 + (nint)720;
			object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			object obj5 = (nint)0 + (nint)3912;
			object obj6 = (nint)0 + (nint)2200;
			object obj7 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v9+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v37+20]");
			Func<object, int> selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v37+20]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj11 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v43+B8]");
					obj8 = 0;
				}
				object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)1952;
				Func<object, int> func = default(Func<object, int>);
				func..ctor(obj8, (IntPtr)obj13);
				object obj14 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v42+B8]");
				object obj15 = (nint)0 + (nint)32;
				obj15 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj16 = 0;
				selector = func;
			}
			object obj17 = (nint)0 + (nint)2200;
			IEnumerable<object> source2 = default(IEnumerable<object>);
			IEnumerable<int> source = Enumerable.Select(source2, selector);
			List<int> list = Enumerable.ToList(source);
			object obj18 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v14+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				EmoteSaveData emoteSaveData = EmoteSaveData.LoadEmoteSaveData(intDbId);
				if (emoteSaveData != null)
				{
					num = (nint)(emoteSaveData + 16);
					num = (nint)list;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					string contents = JsonUtility.ToJson(emoteSaveData);
					string userEmotesPath = EmoteSaveData.GetUserEmotesPath(intDbId);
					File.WriteAllText(userEmotesPath, contents);
					IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
					if (popupWindowBuilderNeedsTitle != null)
					{
						object obj20 = typeof(System.IOAsyncCallback) + 392;
						object obj21 = "SERVICE_DISABLED" + 1648;
						nint num2 = (nint)popupWindowBuilderNeedsTitle;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v18 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v18 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0316;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v18 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
						obj23 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X10_v12-8]");
							if (0 == (nint)obj20)
							{
								break;
							}
							obj24 = obj23 + 16;
							obj22--;
							bool flag5 = (nint)obj22 != 1;
							obj23 = obj24;
							if (flag5)
							{
								continue;
							}
							goto IL_0316;
						}
						object obj25 = num2 + obj23;
						num = (nint)(obj25 + 312);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
						bool flag6 = obj26 == null;
						obj24 = obj23;
						if (!flag6)
						{
							goto IL_03b1;
						}
					}
				}
			}
		}
		goto IL_0718;
		IL_0726:
		object obj27 = obj24 + 9;
		object obj28 = num + obj27;
		object obj29 = obj28 + 312;
		goto IL_0946;
		IL_049f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_08b8;
		IL_0718:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0726;
		IL_05bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj30 = default(object);
		num = (nint)obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v591 @ X0_v40] (should have been resolved before IL gen)");
		bool flag7 = ex == null;
		obj24 = obj23;
		obj16 = 0;
		if (!flag7)
		{
			goto IL_0606;
		}
		goto IL_0718;
		IL_0316:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v455 @ X0_v48 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag8 = obj26 == null;
		object obj31 = !flag8;
		obj23 = obj24;
		if (obj31 != null)
		{
			goto IL_03b1;
		}
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_0718;
		IL_0606:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_069a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj24 = (nint)0 + (nint)8;
		object obj33;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X10_v22-8]");
			bool flag9 = 0 == (nint)obj33;
			obj16 = 0;
			if (flag9)
			{
				break;
			}
			obj24 += 16;
			obj32--;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_069a;
		}
		goto IL_0726;
		IL_08b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj34;
		action..ctor(this, (IntPtr)obj34);
		object label;
		PopupButton popupButton = PopupButton.Positive((string)label, action, dismiss: true);
		object obj35 = default(object);
		bool flag10 = obj35 == null;
		obj24 = obj23;
		obj16 = 0;
		if (!flag10)
		{
			obj33 = typeof(System.IOAsyncCallback) + 368;
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v24+12E]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v24+12E]");
			if ((nint)0 == 0)
			{
				goto IL_05bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v24+B0]");
			obj24 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X10_v22-8]");
				if (0 == (nint)obj33)
				{
					break;
				}
				obj23 = obj24 + 16;
				obj37--;
				bool flag11 = (nint)obj37 != 1;
				obj24 = obj23;
				if (flag11)
				{
					continue;
				}
				goto IL_05bc;
			}
			object obj38 = obj36 + obj24;
			object obj39 = obj38 + 312;
			num = (nint)obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v606 @ X0_v43] (should have been resolved before IL gen)");
			bool flag12 = ex == null;
			object obj40 = !flag12;
			obj16 = 0;
			if (obj40 != null)
			{
				goto IL_0606;
			}
		}
		goto IL_0718;
		IL_0946:
		object obj41 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v3+8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v330 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_03b1:
		object obj43 = typeof(System.IOAsyncCallback) + 384;
		object obj44 = "Drop Menu Toggle" + 2264;
		object obj45 = typeof(SqlSingle[]) + 2376;
		obj34 = (nint)0 + (nint)3176;
		label = "Network Authentication Required" + 3128;
		object obj46 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v22+12E]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v22+12E]");
		if ((nint)0 == 0)
		{
			goto IL_049f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v22+B0]");
		object obj48 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X10_v20-8]");
			if (0 == (nint)obj43)
			{
				break;
			}
			obj23 = obj48 + 16;
			obj47--;
			bool flag13 = (nint)obj47 != 1;
			obj48 = obj23;
			if (flag13)
			{
				continue;
			}
			goto IL_049f;
		}
		object obj49 = obj46 + obj48;
		num = (nint)(obj49 + 312);
		obj23 = obj48;
		goto IL_08b8;
		IL_069a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj16 = 0;
		object obj50 = default(object);
		obj29 = obj50;
		goto IL_0946;
	}

	public void OnBackClicked()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_00ba: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = typeof(Queue<string>) + 840;
		sortEmotePopup.SlideOut();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2184;
		ScreenManager.AllowBackAction();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ScreenManager screenManager = default(ScreenManager);
		screenManager.Back();
		toggle.isOn = false;
	}

	private void OnUserToggleChanged(bool value)
	{
		previewMode = value;
		if (!value)
		{
			emoteViewer.Reset();
			GameObject gameObject = playBackProgress.gameObject;
			gameObject.SetActive(value: false);
			playBackProgress.fillAmount = 1f;
		}
	}

	public void WarningMessage()
	{
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0012: Expected O, but got I4
		//IL_07f8: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008a: Expected I, but got O
		//IL_009a: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0203: Expected O, but got I
		//IL_021b: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_0703: Expected I, but got O
		//IL_0256: Expected O, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_032c: Expected O, but got I
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0353: Expected O, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_076c: Expected I, but got O
		//IL_038e: Expected O, but got I
		//IL_0426: Expected O, but got I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_0454: Expected O, but got I
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_050c: Expected O, but got I4
		//IL_048f: Expected O, but got I
		//IL_052a: Expected I, but got O
		//IL_053a: Expected O, but got I
		//IL_05c9: Expected O, but got I4
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_061d: Expected O, but got I4
		//IL_0626: Expected O, but got I4
		//IL_0575: Expected O, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_07ca: Expected O, but got I4
		//IL_07d2: Expected O, but got I
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		List<StoreItem> list = selectedItems;
		object label;
		object obj3;
		object obj4 = default(object);
		object obj6 = default(object);
		if (selectedItems != null)
		{
			list = (List<StoreItem>)list._size;
			if (list._size < 1)
			{
				OnBackClicked();
				return;
			}
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 392;
				label = "UInt16" + 3840;
				nint num = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_011e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 = obj3 + 16;
					obj2--;
					bool flag = (nint)obj2 != 1;
					obj3 = obj4;
					if (flag)
					{
						continue;
					}
					goto IL_011e;
				}
				object obj5 = num + obj3;
				list = (List<StoreItem>)(obj5 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v5 (System.Collections.Generic.List`1<StoreItem>)] (should have been resolved before IL gen)");
				bool flag2 = obj6 == null;
				obj4 = obj3;
				if (!flag2)
				{
					goto IL_01c0;
				}
			}
		}
		goto IL_0634;
		IL_0742:
		object obj7 = default(object);
		list = (List<StoreItem>)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v588 @ X0_v16] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj8;
		action..ctor(this, (IntPtr)obj8);
		object label2;
		PopupButton popupButton = PopupButton.Neutral((string)label2, action, dismiss: true);
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = 0;
		obj4 = obj3;
		object obj13;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag3)
		{
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v21+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v21+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04d8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v21+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X10_v28-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj3 = obj4 + 16;
				obj12--;
				bool flag4 = (nint)obj12 != 1;
				obj4 = obj3;
				if (flag4)
				{
					continue;
				}
				goto IL_04d8;
			}
			object obj14 = obj11 + obj4;
			object obj15 = obj14 + 312;
			list = (List<StoreItem>)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v634 @ X0_v30] (should have been resolved before IL gen)");
			bool flag5 = ex == null;
			object obj16 = !flag5;
			obj10 = 0;
			if (obj16 != null)
			{
				goto IL_0522;
			}
		}
		goto IL_0634;
		IL_029f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		List<StoreItem> list2 = default(List<StoreItem>);
		list = list2;
		goto IL_06e1;
		IL_07e0:
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v4+8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v331 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_06e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v5 (System.Collections.Generic.List`1<StoreItem>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		object obj20;
		action2..ctor(this, (IntPtr)obj20);
		PopupButton popupButton2 = PopupButton.Positive((string)label, action2, dismiss: true);
		object obj21 = default(object);
		bool flag6 = obj21 == null;
		obj10 = 0;
		obj4 = obj3;
		if (flag6)
		{
			goto IL_0634;
		}
		obj13 = typeof(System.IOAsyncCallback) + 368;
		obj8 = (nint)0 + (nint)3176;
		label2 = "Complete" + 1184;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v18+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03d7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v18+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X10_v21-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj3 = obj24 + 16;
			obj23--;
			bool flag7 = (nint)obj23 != 1;
			obj24 = obj3;
			if (flag7)
			{
				continue;
			}
			goto IL_03d7;
		}
		object obj25 = obj22 + obj24;
		obj7 = obj25 + 312;
		obj3 = obj24;
		goto IL_0742;
		IL_0642:
		object obj26 = obj4 + 9;
		object obj27 = (object)list + obj26;
		obj18 = obj27 + 312;
		goto IL_07e0;
		IL_04d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj28 = default(object);
		list = (List<StoreItem>)obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v619 @ X0_v27] (should have been resolved before IL gen)");
		bool flag8 = ex == null;
		obj10 = 0;
		obj4 = obj3;
		if (!flag8)
		{
			goto IL_0522;
		}
		goto IL_0634;
		IL_0522:
		nint num2 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05b6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X10_v28-8]");
			bool flag9 = 0 == (nint)obj13;
			obj10 = 0;
			list = (List<StoreItem>)num2;
			if (flag9)
			{
				break;
			}
			obj4 += 16;
			obj29--;
			if ((nint)obj29 != 1)
			{
				continue;
			}
			goto IL_05b6;
		}
		goto IL_0642;
		IL_05b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj10 = 0;
		object obj30 = default(object);
		obj18 = obj30;
		goto IL_07e0;
		IL_011e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v399 @ X0_v38 (System.Collections.Generic.List`1<StoreItem>)] (should have been resolved before IL gen)");
		bool flag10 = obj6 == null;
		object obj31 = !flag10;
		obj3 = obj4;
		if (obj31 != null)
		{
			goto IL_01c0;
		}
		List<StoreItem> list3 = default(List<StoreItem>);
		list = list3;
		goto IL_0634;
		IL_01c0:
		object obj32 = typeof(System.IOAsyncCallback) + 384;
		object obj33 = "WhiteSmoke" + 1976;
		object obj34 = typeof(SqlSingle[]) + 2376;
		obj20 = (nint)0 + (nint)3200;
		object obj35 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v16+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_029f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v16+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X10_v26-8]");
			if (0 == (nint)obj32)
			{
				break;
			}
			obj3 = obj37 + 16;
			obj36--;
			bool flag11 = (nint)obj36 != 1;
			obj37 = obj3;
			if (flag11)
			{
				continue;
			}
			goto IL_029f;
		}
		object obj38 = obj35 + obj37;
		list = (List<StoreItem>)(obj38 + 312);
		obj3 = obj37;
		goto IL_06e1;
		IL_0634:
		ex = new NullReferenceException();
		goto IL_0642;
		IL_03d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0742;
	}

	public SettingEmotesSection()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3592;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1880;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 4072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 104;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj5 = this + 112;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj6 = this + 120;
		obj6 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <OnPreviewClicked>b__22_0(EmoteAnimationDataModel data)
	{
		if (data != null)
		{
			EmoteItemData <EmoteData>k__BackingField = data.<EmoteData>k__BackingField;
			data.<SpriteSheet>k__BackingField.filterMode = FilterMode.Bilinear;
			emoteViewer.PlayEmote(data.<Clip>k__BackingField, data.<SpriteSheet>k__BackingField, <EmoteData>k__BackingField.gridSize, <EmoteData>k__BackingField.duration, <EmoteData>k__BackingField.delayAudio, <EmoteData>k__BackingField.shiftMask);
		}
	}
}
