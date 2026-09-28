using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class ReferralCongratsPopup : MonoBehaviour
{
	private PopupUI popup;

	private TextMeshProUGUI titleText;

	private TextMeshProUGUI coinsText;

	private TextMeshProUGUI subscriptionText;

	private TextMeshProUGUI itemsText;

	private RectTransform congrats;

	private RectTransform gift;

	private RectTransform panel;

	private RectTransform backButton;

	private UserReferralRewardModel _reward;

	private readonly Queue<UserReferralRewardModel> rewardsQueue;

	public void Populate(UserReferralRewardModel reward)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0057: Expected O, but got I4
		if (reward == null)
		{
			return;
		}
		object obj = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+8]");
		Queue<object> queue = (Queue<object>)0;
		if (obj != null)
		{
			bool flag = queue == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		else if (queue._size == 0)
		{
			_reward = reward;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Populate();
			return;
		}
		queue.Enqueue(reward);
	}

	private unsafe void Populate()
	{
		//IL_0431: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_00ef: Expected O, but got Ref
		//IL_0114: Expected O, but got Ref
		//IL_012a: Expected I, but got O
		//IL_013a: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_0215: Expected O, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0269: Expected O, but got I4
		//IL_046b: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_02ed: Expected O, but got I4
		//IL_032d: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		//IL_03b4: Expected O, but got I4
		UserReferralRewardModel reward = _reward;
		bool flag = _reward == null;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			text = reward.<name>k__BackingField;
			TextMeshProExtensions.FixArabic(titleText, reward.<name>k__BackingField);
			bool flag2 = _reward == null;
			object[] array = null;
			if (!flag2)
			{
				object obj = typeof(TypeConverter<ushort, char>) + 3400;
				int num = default(int);
				string text2 = num.ToString();
				TextMeshProExtensions.FixArabic(coinsText, text2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				bool flag3 = _reward == null;
				array = null;
				text = (string)1;
				if (!flag3)
				{
					object obj2 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array2 = default(object[]);
					bool flag4 = array2 == null;
					array = null;
					int num2 = default(int);
					text = (string)(&num2);
					if (!flag4)
					{
						object obj3 = default(object);
						bool flag5 = obj3 == null;
						string text3 = (string)(&num2);
						if (!flag5)
						{
							nint num3 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							text3 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag6 = ex == null;
							array = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							if (flag6)
							{
								goto IL_03f8;
							}
						}
						bool flag7 = array2.Length == 0;
						array = null;
						text = text3;
						if (flag7)
						{
							goto IL_03ea;
						}
						object obj4 = "DNQUALIFIER" + 1456;
						object obj5 = array2 + 32;
						obj5 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						text = (string)obj4;
						TextMeshProExtensions.Localize(subscriptionText, (string)obj4, array2);
						UserReferralRewardModel reward2 = _reward;
						bool flag8 = _reward == null;
						object obj6 = 0;
						array = array2;
						if (!flag8)
						{
							object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
							object obj8 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v16+E4]");
							bool flag9 = (nint)0 == 0;
							object obj9 = !flag9;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							StoreItem storeItem = Store.GetStoreItem(reward2.<itemID>k__BackingField);
							bool flag10 = (object)itemsText == null;
							obj6 = 0;
							array = array2;
							text = null;
							if (!flag10)
							{
								Transform transform = itemsText.transform;
								bool flag11 = (object)transform == null;
								obj6 = 0;
								array = array2;
								text = null;
								if (!flag11)
								{
									Transform parent = transform.parent;
									bool flag12 = (object)parent == null;
									obj6 = 0;
									array = array2;
									text = null;
									if (!flag12)
									{
										GameObject gameObject = parent.gameObject;
										bool flag13 = (object)gameObject == null;
										obj6 = 0;
										array = array2;
										text = null;
										if (!flag13)
										{
											bool flag14 = storeItem == null;
											bool flag15 = !flag14;
											gameObject.SetActive(flag15);
											if (storeItem != null)
											{
												bool flag16 = (object)itemsText == null;
												obj6 = 0;
												array = null;
												text = (string)flag15;
												if (flag16)
												{
													goto IL_03dc;
												}
												itemsText.text = storeItem.<name>k__BackingField;
											}
											Animate();
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_03dc;
		IL_03f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_03dc:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03ea;
		IL_03ea:
		ex = new IndexOutOfRangeException();
		goto IL_03f8;
	}

	private void Animate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_020b: Expected O, but got I
		//IL_0235: Expected O, but got I4
		//IL_004e: Expected I, but got O
		//IL_007f: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_0097: Expected O, but got I
		//IL_00a3: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)2032;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence sequence = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		PopupUI popupUI = popup;
		object obj6 = (nint)0 + (nint)2872;
		object obj7 = (nint)0 + (nint)2432;
		object obj8 = (nint)0 + (nint)2440;
		object obj9 = (nint)0 + (nint)2408;
		Sequence sequence2 = TweenSettingsExtensions.AppendInterval(s, popupUI.animationSpeed);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(congrats, 0f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
		Tween t = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Append(s, t);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(gift, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
		Tween t2 = default(Tween);
		Sequence sequence4 = TweenSettingsExtensions.Join(s, t2);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOAnchorPosY(panel, -1300f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
		Tween t3 = default(Tween);
		Sequence sequence5 = TweenSettingsExtensions.Append(s, t3);
		Sequence sequence6 = TweenSettingsExtensions.AppendInterval(s, 1f);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore4 = DOTweenModuleUI.DOAnchorPosY(backButton, -1100f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
		Tween t4 = default(Tween);
		Sequence sequence7 = TweenSettingsExtensions.Append(s, t4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	public void Close()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0061: Expected I, but got O
		//IL_008b: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2040;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		popup.ShrinkToParent();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	public ReferralCongratsPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Queue<object> queue = default(Queue<object>);
		queue..ctor();
		object obj2 = this + 112;
		obj2 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Animate>b__13_0()
	{
		popup.PopFromCenter();
	}

	private void <Close>b__14_0()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		Queue<object> queue = (Queue<object>)(object)rewardsQueue;
		if (queue._size != 0)
		{
			object obj = queue.Dequeue();
			object obj2 = this + 104;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Populate();
		}
		else
		{
			object obj3 = this + 104;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
