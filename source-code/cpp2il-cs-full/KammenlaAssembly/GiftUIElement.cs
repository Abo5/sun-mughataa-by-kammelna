using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GiftUIElement : ListViewItem<GiftsHolder, int>
{
	private Image highlight;

	private TextMeshProUGUI priceText;

	private Image image;

	private GameEventsChannel gameEventsChannel;

	private SpriteSheetPlayer spriteSheetPlayer;

	public StoreItem GiftStoreItem
	{
		get
		{
			//IL_0030: Expected O, but got I
			//IL_0012: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+28]");
				return (StoreItem)0;
			}
			return (StoreItem)(object)new NullReferenceException();
		}
	}

	private void Awake()
	{
		UIExtensions.SetAlpha(highlight, 0f);
	}

	private void OnEnable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0199: Expected O, but got I
		//IL_01b1: Expected I, but got O
		//IL_00cb: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E65A7]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj5 = spriteSheetPlayer;
			obj6 = spriteSheetPlayer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = spriteSheetPlayer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = spriteSheetPlayer;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0160;
		}
		goto IL_0179;
		IL_0179:
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		StorePricing.OnPricingChanged += action;
		return;
		IL_0160:
		spriteSheetPlayer.Play();
		obj8 = 0;
		goto IL_0179;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			goto IL_0160;
		}
		obj8 = 0;
		goto IL_0179;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		StorePricing.OnPricingChanged -= action;
	}

	private void RefreshPrice()
	{
		//IL_0075: Expected O, but got I
		//IL_003b: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+28]");
				int num = StorePricing.EffectivePrice((StoreItem)0);
				int num2 = default(int);
				string text = num2.ToString();
				priceText.text = text;
			}
		}
	}

	public override void Setup(GiftsHolder datum, bool firstTime)
	{
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		Populate();
	}

	public void Populate()
	{
		//IL_00d5: Expected O, but got I
		//IL_0015: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_003f: Expected O, but got I
		//IL_0055: Expected O, but got I
		GameObject gameObject = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
		gameObject.name = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v6+28]");
		int num = StorePricing.EffectivePrice((StoreItem)0);
		int num2 = default(int);
		string text = num2.ToString();
		priceText.text = text;
		GameObject gameObject2 = base.gameObject;
		if (gameObject2.activeInHierarchy)
		{
			LoadPreviewImage();
		}
	}

	private void LoadPreviewImage()
	{
		//IL_0037: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_00b5: Expected O, but got I4
		//IL_020d: Expected O, but got I
		//IL_021e: Expected I, but got O
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0287: Expected O, but got I4
		//IL_0103: Expected O, but got I
		//IL_011d: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_017e: Expected I, but got O
		GameObject gameObject = image.gameObject;
		gameObject.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v4+28]");
		ItemCategory category = ((StoreItem)0).GetCategory();
		if (category == ItemCategory.AnimatedGifts)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v11+28]");
			bool hasGameAction = ((StoreItem)0).HasGameAction;
			bool flag = !hasGameAction;
			object obj3 = !flag;
			object obj4 = ~obj3;
			ImageCacher.ItemImageType itemImageType = ((obj4 != null) ? ImageCacher.ItemImageType.StoreTitle : ImageCacher.ItemImageType.InGame);
			object obj5 = typeof(Queue<string>) + 760;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v18+28]");
			object obj10 = 0;
			GameObject go = base.gameObject;
			object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3264;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v19+10]");
			ImageCacher imageCacher = default(ImageCacher);
			imageCacher.LoadItemImage(0, itemImageType, go, action);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GiftUIElement)+40]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v5+28]");
			object obj14 = 0;
			GameObject gameObject2 = image.gameObject;
			object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)1928;
			Action<bool> action2 = default(Action<bool>);
			action2..ctor((object)gameObject2, (IntPtr)obj16);
			Image img = image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v6+10]");
			UIExtensions.LoadItemImage(img, 0, ImageCacher.ItemImageType.StoreTitle, FilterMode.Bilinear, action2);
		}
	}

	public void Highlight()
	{
		//IL_007b: Expected O, but got I
		//IL_0087: Expected O, but got I
		int num = ShortcutExtensions.DOKill(highlight, complete: true);
		Transform target = image.transform;
		int num2 = ShortcutExtensions.DOKill(target, complete: true);
		GameObject gameObject = highlight.gameObject;
		gameObject.SetActive(value: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(highlight, 1f, 0.1f);
		object obj = (nint)0 + (nint)2440;
		object obj2 = (nint)0 + (nint)2904;
		Transform target2 = image.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 0.8f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void Dismiss()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj2 = (nint)0 + (nint)3256;
		object obj3 = (nint)0 + (nint)2456;
		int num = ShortcutExtensions.DOKill(highlight, complete: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(highlight, 0f, 0.1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public void OnClick()
	{
		Highlight();
		gameEventsChannel.TriggerGiftClicked(this);
	}

	public GiftUIElement()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <LoadPreviewImage>b__13_0(Sprite sprite)
	{
		GameObject gameObject = image.gameObject;
		gameObject.SetActive(value: true);
		Texture2D texture = sprite.texture;
		spriteSheetPlayer.SetTexture(texture);
		spriteSheetPlayer.Play();
	}

	private void <Dismiss>b__15_0()
	{
		GameObject gameObject = highlight.gameObject;
		gameObject.SetActive(value: false);
	}
}
