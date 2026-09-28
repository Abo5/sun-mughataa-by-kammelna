using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class CardsRevealer : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameObject, int> <>9__29_0;

		public static Func<GameObject, Vector3> <>9__29_1;

		public static Func<GameObject, int> <>9__29_2;

		public static Func<GameObject, Quaternion> <>9__29_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <SaveOriginalState>b__29_0(GameObject o)
		{
			//IL_003d: Expected I4, but got O
			if ((object)o != null)
			{
				return o.GetInstanceID();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal Vector3 <SaveOriginalState>b__29_1(GameObject o)
		{
			if ((object)o != null)
			{
				Transform transform = o.transform;
				if ((object)transform != null)
				{
					return transform.localScale;
				}
			}
			return (Vector3)new NullReferenceException();
		}

		internal int <SaveOriginalState>b__29_2(GameObject o)
		{
			//IL_003d: Expected I4, but got O
			if ((object)o != null)
			{
				return o.GetInstanceID();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal Quaternion <SaveOriginalState>b__29_3(GameObject o)
		{
			if ((object)o != null)
			{
				Transform transform = o.transform;
				if ((object)transform != null)
				{
					return transform.localRotation;
				}
			}
			return (Quaternion)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public CardsRevealer <>4__this;

		public List<Card> cards;

		public float hideAfter;

		public float minimumWait;

		internal void <ShowCards>b__0()
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			<>4__this.ShowCardsHelper(cards);
			GameObject gameObject = <>4__this.gameObject;
			if (gameObject.activeInHierarchy)
			{
				float timeSinceLevelLoad = Time.timeSinceLevelLoad;
				float num = minimumWait + timeSinceLevelLoad;
				object methodName = "HH:mm:ss.ffZ" + 1352;
				<>4__this.Invoke((string)methodName, hideAfter);
			}
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public CardsRevealer <>4__this;

		public List<Card> cards;

		internal void <TestHideWait5>b__0()
		{
			<>4__this.ShowCards(cards, 5f);
		}
	}

	private const float AnimationTime = 0.8f;

	private RectTransform container;

	public GameObject[] cardObjects;

	public SpriteRenderer[] cardSprites;

	protected CardsSprites cardsSprites;

	private Sequence _showAnimation;

	private Sequence _hideAnimation;

	private float _minHideTime;

	private Vector3 _orignalAnchorPosition;

	private Dictionary<int, Vector3> _originalScales;

	private Dictionary<int, Quaternion> _originalRotations;

	private Quaternion _originalRootRotation;

	private Vector3 _originalRootPosition;

	private void Awake()
	{
		//IL_00cb: Expected O, but got I
		if ((object)container != null)
		{
			Quaternion localRotation = container.localRotation;
			Quaternion quaternion = default(Quaternion);
			_originalRootRotation = quaternion;
			if ((object)container != null)
			{
				Vector3 localPosition = container.localPosition;
				_originalRootPosition = (Vector3)quaternion;
				GameObject[] array = cardObjects;
				if (cardObjects != null && (object)array[0] != null)
				{
					object obj = (nint)0 + (nint)1360;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
					Transform transform = default(Transform);
					if ((object)transform != null)
					{
						Vector3 localPosition2 = transform.localPosition;
						_orignalAnchorPosition = (Vector3)quaternion;
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void SaveRevealerPlacement()
	{
		Quaternion localRotation = container.localRotation;
		Quaternion quaternion = default(Quaternion);
		_originalRootRotation = quaternion;
		Vector3 localPosition = container.localPosition;
		_originalRootPosition = (Vector3)quaternion;
	}

	public void ResetRevealerPlacement()
	{
		//IL_0010: Expected O, but got I4
		//IL_0025: Expected O, but got I4
		container.localPosition = (Vector3)0;
		container.localRotation = (Quaternion)0;
	}

	public void ShowCards(List<Card> cards, float hideAfter = 60f, float minimumWait = 0f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94602CC");
	}

	private void SetHideDelay(float hideAfter, float minimumWait)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			float timeSinceLevelLoad = Time.timeSinceLevelLoad;
			float minHideTime = minimumWait + timeSinceLevelLoad;
			object methodName = "HH:mm:ss.ffZ" + 1352;
			_minHideTime = minHideTime;
			Invoke((string)methodName, hideAfter);
		}
	}

	public void HideGracefully()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_006c: Invalid comparison between F4 and I4
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			object methodName = "HH:mm:ss.ffZ" + 1352;
			CancelInvoke((string)methodName);
			float timeSinceLevelLoad = Time.timeSinceLevelLoad;
			float num = _minHideTime - timeSinceLevelLoad;
			if (num > 0f)
			{
				Invoke((string)methodName, num);
			}
			else
			{
				HideCardsAnimation(null);
			}
		}
	}

	public void HideImmediate()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			object methodName = "HH:mm:ss.ffZ" + 1352;
			CancelInvoke((string)methodName);
			HideCardsAnimation(null);
		}
	}

	private void HideImmediate(TweenCallback callback)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			object methodName = "HH:mm:ss.ffZ" + 1352;
			CancelInvoke((string)methodName);
			HideCardsAnimation(callback);
		}
		else if (callback != null)
		{
			IntPtr invoke_impl = ((Delegate)callback).invoke_impl;
			IntPtr method_code = ((Delegate)callback).method_code;
			IntPtr method = ((Delegate)callback).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v66 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void SetCards(List<Card> cards)
	{
		OrganizeCards(cards);
		SaveOriginalState();
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	private void ShowCardsHelper(List<Card> cards)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I
		//IL_02c0: Expected F4, but got O
		//IL_02c0: Expected O, but got I4
		//IL_02c0: Expected O, but got I
		//IL_02d0: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		//IL_01ea: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_0212: Expected O, but got I
		//IL_0147: Expected O, but got I
		//IL_015e: Expected F4, but got O
		//IL_015e: Expected O, but got I4
		//IL_016e: Expected O, but got I
		//IL_0189: Expected O, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		if (gameObject.activeSelf)
		{
			return;
		}
		OrganizeCards(cards);
		SaveOriginalState();
		GameObject gameObject2 = base.gameObject;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		object target = gameObject2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject2;
		}
		Sequence sequence = DOTween.Sequence(target);
		object obj4 = this + 64;
		obj4 = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sequence sequence2 = TweenSettingsExtensions.AppendInterval((Sequence)obj4, 0.2f);
		object obj5 = typeof(UsageHint) + 816;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v11+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X20_v4-20]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale((Transform)0, (Vector3)0, (float)obj7);
		object obj8 = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
		object obj9 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Append((Sequence)obj4, t);
		GameObject[] array = cardObjects;
		if (array.Length >= 1)
		{
			object obj10 = array + 32;
			object obj11 = 0;
			Tween t2 = default(Tween);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v4+v137 @ X26_v5*8]");
				Transform transform = ((GameObject)0).transform;
				transform.localScale = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v4+v137 @ X26_v5*8]");
				Transform target2 = ((GameObject)0).transform;
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v26+B8]");
				object obj13 = 0;
				TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(target2, (Vector3)0, (float)obj13);
				object obj14 = (nint)0 + (nint)2424;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
				object obj15 = (nint)0 + (nint)2848;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				Sequence sequence4 = TweenSettingsExtensions.Join((Sequence)obj4, t2);
				obj11++;
			}
			while ((nint)obj11 < array.Length);
		}
		GameObject gameObject3 = base.gameObject;
		gameObject3.SetActive(value: true);
	}

	private void HideCardsAnimation()
	{
		HideCardsAnimation(null);
	}

	private void HideCardsAnimation(TweenCallback callback)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0162: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_04ab: Expected O, but got I4
		//IL_0326: Expected F4, but got I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0211: Expected O, but got I
		//IL_021a: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_044c: Expected O, but got I
		//IL_045a: Expected I, but got O
		//IL_02e0: Expected O, but got I
		//IL_0119: Expected I, but got O
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0351: Expected O, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0245: Expected O, but got I
		//IL_0255: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_027c: Expected F4, but got O
		//IL_027c: Expected O, but got I4
		//IL_0419: Expected O, but got I
		//IL_02bc: Expected O, but got I4
		//IL_02c1: Expected I, but got O
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_037c: Expected O, but got I
		//IL_0384: Expected F4, but got O
		//IL_0394: Expected O, but got I
		//IL_03a4: Expected O, but got I
		//IL_03b6: Expected F4, but got O
		//IL_03b6: Expected O, but got I4
		//IL_03ed: Expected O, but got I4
		//IL_03f2: Expected I, but got O
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeSelf)
		{
			return;
		}
		object obj = this + 72;
		bool flag = obj == null;
		object obj2 = 0;
		if (!flag)
		{
			if (callback == null)
			{
				return;
			}
			object a = obj + 128;
			Delegate obj3 = Delegate.Combine((Delegate)a, callback);
			if ((object)obj3 != null)
			{
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				obj2 = obj4;
				if (obj3 == obj4)
				{
					a = obj3;
					if (obj3 == obj4)
					{
						goto IL_04bf;
					}
				}
				nint num = unchecked((nint)null);
				throw new InvalidCastException();
			}
			a = 0;
			goto IL_04bf;
		}
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence hideAnimation = DOTween.Sequence();
		_hideAnimation = hideAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sequence sequence = TweenSettingsExtensions.AppendInterval(_hideAnimation, 0.2f);
		GameObject[] array = cardObjects;
		object obj8 = typeof(UsageHint) + 816;
		if (array.Length >= 1)
		{
			object obj9 = array + 32;
			object obj10 = (nint)0 + (nint)2848;
			object obj11 = 0;
			Tween t = default(Tween);
			bool flag3;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X27_v9+v89 @ X26_v9*8]");
				Transform target = ((GameObject)0).transform;
				obj11++;
				object obj12 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v30+B8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v31+4]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v31+8]");
				object obj15 = 0;
				TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(target, (Vector3)0, (float)obj13);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				Sequence sequence2 = TweenSettingsExtensions.Join((Sequence)obj, t);
				flag3 = (nint)obj11 >= array.Length;
				object obj16 = 1061997773;
				nint num = unchecked((nint)null);
			}
			while (!flag3);
		}
		Sequence sequence3 = TweenSettingsExtensions.AppendInterval(_hideAnimation, 0.6f);
		GameObject[] array2 = cardObjects;
		bool flag4 = array2.Length < 1;
		float num2 = 1.0586423E+09f;
		Tween tween = null;
		if (!flag4)
		{
			object obj17 = array2 + 32;
			object obj18 = 0;
			bool flag5;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X26_v7+v198 @ X19_v11*8]");
				Transform target2 = ((GameObject)0).transform;
				obj18++;
				object obj19 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v23+B8]");
				object obj20 = 0;
				num2 = (float)obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v24+4]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v24+8]");
				object obj15 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, (Vector3)0, (float)obj20);
				Sequence sequence4 = TweenSettingsExtensions.Join((Sequence)obj, tweenerCore2);
				flag5 = (nint)obj18 >= array2.Length;
				object obj16 = 1053609165;
				nint num = unchecked((nint)null);
				tween = tweenerCore2;
			}
			while (!flag5);
		}
		object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)3392;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj22);
		Sequence sequence5 = TweenSettingsExtensions.AppendCallback(_hideAnimation, tweenCallback);
		if (callback != null)
		{
			Sequence sequence6 = TweenSettingsExtensions.AppendCallback((Sequence)obj, callback);
		}
		return;
		IL_04bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void ResetObjects()
	{
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0178: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0196: Expected O, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_0084: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_00ef: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		if (_originalScales == null || _originalScales.Count == 0)
		{
			return;
		}
		GameObject[] array = cardObjects;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X25_v5+v197 @ X24_v6*8]");
				Transform transform = ((GameObject)0).transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X25_v5+v197 @ X24_v6*8]");
				int instanceID = ((UnityEngine.Object)0).GetInstanceID();
				Quaternion quaternion = _originalRotations.get_Item(instanceID);
				transform.localRotation = (Quaternion)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X25_v5+v197 @ X24_v6*8]");
				Transform transform2 = ((GameObject)0).transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X25_v5+v197 @ X24_v6*8]");
				int instanceID2 = ((UnityEngine.Object)0).GetInstanceID();
				Vector3 vector = _originalScales.get_Item(instanceID2);
				transform2.localScale = (Vector3)0;
				obj3++;
			}
			while ((nint)obj3 < array.Length);
		}
		object obj4 = this + 64;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 72;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private void ResetSpritePositions()
	{
		//IL_0030: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_005a: Expected O, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		SpriteRenderer[] array = cardSprites;
		if (array.Length >= 1)
		{
			object obj = (nint)0 + (nint)4040;
			object obj2 = array + 32;
			object obj3 = 0;
			RectTransform rectTransform = default(RectTransform);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				rectTransform.anchoredPosition3D = (Vector3)0;
				rectTransform.localRotation = (Quaternion)0;
				obj3++;
			}
			while ((nint)obj3 < array.Length);
		}
	}

	public void ResetAll()
	{
		//IL_0010: Expected O, but got I4
		//IL_0025: Expected O, but got I4
		container.localPosition = (Vector3)0;
		container.localRotation = (Quaternion)0;
		ResetObjects();
		ResetSpritePositions();
	}

	private void OrganizeCards(List<Card> cards)
	{
		//IL_0018: Expected O, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_06de: Expected O, but got I4
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected I4, but got Unknown
		//IL_0747: Expected O, but got I4
		//IL_075a: Expected O, but got I4
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected I4, but got Unknown
		//IL_07d2: Expected O, but got I4
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_011d: Expected I4, but got I8
		//IL_012a: Invalid comparison between F8 and I8
		//IL_082d: Expected O, but got I4
		//IL_085a: Expected O, but got F8
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected F8, but got Unknown
		//IL_014e: Expected F8, but got I8
		//IL_08ba: Expected O, but got I4
		//IL_08ea: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0183: Expected F8, but got I4
		//IL_0255: Expected O, but got I4
		//IL_026f: Expected O, but got I4
		//IL_08fa: Expected O, but got I4
		//IL_0913: Expected O, but got I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02dd: Expected O, but got I4
		//IL_065d: Expected O, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_038b: Expected O, but got I4
		//IL_03d6: Expected O, but got I4
		//IL_0415: Expected O, but got I
		//IL_044a: Expected O, but got I4
		//IL_0454: Expected F8, but got O
		//IL_0464: Expected O, but got I4
		//IL_04ad: Expected O, but got I4
		//IL_0539: Expected O, but got I
		//IL_057d: Expected O, but got I4
		//IL_05c1: Expected O, but got I
		//IL_0607: Expected O, but got I4
		//IL_0619: Expected O, but got I4
		List<Card> list = default(List<Card>);
		if (list != null)
		{
			object obj = list._size - 2;
			bool flag = (nint)obj < 0;
			int num = list._size ^ 2;
			int num2 = list._size ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			object obj4 = ((obj3 != null) ? ((object)2) : ((object)(2 + 1)));
			object obj5 = list._size - 6;
			bool flag4 = (nint)obj5 < 0;
			int num4 = list._size ^ 6;
			int num5 = list._size ^ obj5;
			int num6 = num4 & num5;
			bool flag5 = num6 < 0;
			bool flag6 = flag4 == flag5;
			object obj6 = !flag6;
			object obj7 = list._size - 3;
			bool flag7 = (nint)obj7 < 0;
			bool flag8 = obj7 == null;
			int num7 = list._size ^ 3;
			int num8 = list._size ^ obj7;
			int num9 = num7 & num8;
			bool flag9 = num9 < 0;
			bool flag10 = flag7 == flag9;
			object obj8 = !flag8;
			object obj9 = flag10 & obj8;
			object obj10 = ~obj9;
			object obj11 = ((obj10 != null) ? obj4 : obj6);
			GameObject[] array = cardObjects;
			if (cardObjects != null)
			{
				object obj12 = obj11 * 18;
				double num10 = 33.0 + (double)obj12;
				double num11 = num10 / 2.0000000001164153;
				int num12 = (int)(list._size & 0x80000001L);
				double num13 = ((num11 != 9.218868437227405E+18) ? num11 : 2147483648.0);
				object obj13 = num12 - 1;
				bool flag11 = obj13 == null;
				double num14 = num10 * 171.0;
				object obj14 = num14 >> 9;
				double num15 = obj14 & 0x7F;
				double num16 = ((num12 != 1) ? num13 : num15);
				if (num12 == 1)
				{
					num13 = 0.0;
				}
				object obj15 = list._size - (flag11 ? 1 : 0);
				object obj16 = obj15 + obj11;
				object obj17 = obj16;
				int num17 = num12;
				int num18 = 0;
				object obj18 = 4;
				Vector3 euler = default(Vector3);
				Transform transform = default(Transform);
				do
				{
					object obj19 = obj18 - 4;
					if ((nint)obj19 >= array.Length)
					{
						return;
					}
					SpriteRenderer[] array2 = cardSprites;
					if (cardSprites == null)
					{
						break;
					}
					if ((nint)obj19 >= array2.Length)
					{
						return;
					}
					object obj20 = num17 - 1;
					bool flag12 = obj20 == null;
					object obj21 = !flag12;
					object obj22 = ~obj21;
					bool flag13;
					if (obj22 == null)
					{
						object obj23 = obj18 - 7;
						flag13 = obj23 == null;
					}
					else
					{
						flag13 = false;
					}
					object obj24 = !flag13;
					bool flag14 = obj19 < obj11;
					object obj25 = !flag14;
					object obj26 = ~obj25;
					if (obj26 == null)
					{
						object obj27 = obj19 - obj17;
						bool flag15 = obj27 == null;
						obj8 = !flag15;
						if (obj19 <= obj17)
						{
							object obj28 = obj24 & 1;
							if (obj28 != null)
							{
								if (num18 >= list._size)
								{
									goto IL_0188;
								}
								bool flag16 = (nint)obj19 < 3;
								object obj29 = !flag16;
								object obj30 = obj19 - 3;
								bool flag17 = obj30 == null;
								object obj31 = !flag17;
								object obj32 = obj29 & obj31;
								object obj33 = ~obj32;
								if (obj33 == null)
								{
								}
								Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
								GameObject[] array3 = cardObjects;
								if (cardObjects == null)
								{
									break;
								}
								bool flag18 = (nint)obj19 < array3.Length;
								object obj34 = !flag18;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v15 (UnityEngine.GameObject[])+v341 @ X19_v5*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									object obj35 = (nint)0 + (nint)1360;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
									if ((object)transform == null)
									{
										break;
									}
									transform.localRotation = (Quaternion)0;
									num11 = (double)_orignalAnchorPosition;
									transform.localPosition = (Vector3)0;
									SpriteRenderer[] array4 = cardSprites;
									if (cardSprites == null)
									{
										break;
									}
									bool flag19 = (nint)obj19 < array4.Length;
									object obj36 = !flag19;
									if (obj36 == null)
									{
										object card = ((List<object>)(object)list).get_Item(num18);
										if ((object)cardsSprites == null)
										{
											break;
										}
										Sprite sprite = cardsSprites.GetFor((Card)card);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v18 (UnityEngine.SpriteRenderer[])+v341 @ X19_v5*8]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v18 (UnityEngine.SpriteRenderer[])+v341 @ X19_v5*8]");
										((SpriteRenderer)0).sprite = sprite;
										GameObject[] array5 = cardObjects;
										if (cardObjects == null)
										{
											break;
										}
										bool flag20 = (nint)obj19 < array5.Length;
										object obj37 = !flag20;
										if (obj37 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v21 (UnityEngine.GameObject[])+v341 @ X19_v5*8]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v21 (UnityEngine.GameObject[])+v341 @ X19_v5*8]");
											GameObject gameObject = ((GameObject)0).gameObject;
											if ((object)gameObject == null)
											{
												break;
											}
											gameObject.SetActive(value: true);
											num18++;
											euler = (Vector3)0;
											obj17 = obj16;
											list = (List<Card>)1;
											num17 = num12;
											goto IL_0188;
										}
									}
								}
								goto IL_06a7;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v8 (UnityEngine.GameObject[])+v341 @ X19_v5*8]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v8 (UnityEngine.GameObject[])+v341 @ X19_v5*8]");
					GameObject gameObject2 = ((GameObject)0).gameObject;
					if ((object)gameObject2 == null)
					{
						break;
					}
					gameObject2.SetActive(value: false);
					list = null;
					goto IL_0188;
					IL_0188:
					array = cardObjects;
					num10 -= num16;
					obj18++;
				}
				while (cardObjects != null);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_06a7;
		IL_06a7:
		throw new IndexOutOfRangeException();
	}

	public void SaveOriginalState()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_02d3: Expected O, but got I4
		//IL_0261: Expected O, but got I
		//IL_0271: Expected O, but got I
		//IL_0293: Expected O, but got I4
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_088f: Expected O, but got I
		//IL_08a0: Expected I, but got O
		//IL_08be: Expected O, but got I
		//IL_0332: Expected O, but got I4
		//IL_034b: Expected O, but got I4
		//IL_0353: Expected I, but got O
		//IL_035b: Expected I, but got O
		//IL_0303: Expected O, but got I
		//IL_0397: Expected O, but got I
		//IL_03a7: Expected O, but got I
		//IL_03b7: Expected O, but got I
		//IL_03d9: Expected O, but got I4
		//IL_014f: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_0191: Expected O, but got I4
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0431: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01c0: Expected I, but got O
		//IL_01c8: Expected I, but got O
		//IL_062f: Expected O, but got I
		//IL_063f: Expected O, but got I
		//IL_0661: Expected O, but got I4
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_08ff: Expected O, but got I
		//IL_0910: Expected I, but got O
		//IL_092e: Expected O, but got I
		//IL_055e: Expected I, but got O
		//IL_04e2: Expected O, but got I
		//IL_04f2: Expected O, but got I
		//IL_0461: Expected O, but got I
		//IL_0766: Expected O, but got I
		//IL_0776: Expected O, but got I
		//IL_0786: Expected O, but got I
		//IL_07a8: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_083e: Expected O, but got I
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected O, but got Unknown
		//IL_0588: Expected O, but got I
		//IL_0598: Expected O, but got I
		//IL_05a8: Expected O, but got I
		//IL_05ca: Expected O, but got I4
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected O, but got Unknown
		//IL_098f: Expected O, but got I
		//IL_0997: Expected I, but got O
		//IL_09a8: Expected I, but got O
		//IL_09c6: Expected O, but got I
		//IL_07f0: Expected O, but got I4
		//IL_06f8: Expected O, but got I4
		//IL_0701: Expected O, but got I4
		//IL_0722: Expected O, but got I4
		//IL_06c9: Expected O, but got I
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected O, but got Unknown
		//IL_0a07: Expected O, but got I
		//IL_0a18: Expected I, but got O
		//IL_0a36: Expected O, but got I
		//IL_05f8: Expected I, but got O
		//IL_0820: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(CardUtils.<>c) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E666A]");
		object obj3 = (nint)0 & (nint)1;
		GameObject[] array;
		GameObject[] array2;
		object obj4;
		if (obj3 != null)
		{
			array = cardObjects;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			array2 = cardObjects;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			array = cardObjects;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			array2 = cardObjects;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v44+8]");
		Func<object, int> func = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v44+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		array = array2;
		object obj9 = obj4;
		if (obj8 != null)
		{
			goto IL_00ee;
		}
		goto IL_02b1;
		IL_0466:
		object obj11;
		object obj10 = obj11;
		IEnumerable<object> source;
		Func<object, int> keySelector;
		Func<object, Vector3> func2;
		Dictionary<int, Vector3> dictionary = Enumerable.ToDictionary(source, keySelector, func2);
		object obj12 = this + 96;
		obj12 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+E4]");
		object obj14;
		Func<object, int> func3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v17+18]");
			func3 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v17+18]");
			bool flag4 = (nint)0 == 0;
			object obj15 = obj13;
			if (!flag4)
			{
				goto IL_051f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v17+18]");
			func3 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v17+18]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			object obj15 = obj13;
			if (obj16 != null)
			{
				goto IL_051f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v23+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v24+B8]");
			obj14 = 0;
		}
		object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)2728;
		nint num = (nint)obj20;
		Func<object, int> func4 = default(Func<object, int>);
		func4..ctor(obj14, (IntPtr)obj20);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v22+B8]");
		object obj22 = (nint)0 + (nint)24;
		obj22 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		obj10 = 0;
		Dictionary<int, Vector3> dictionary2 = (Dictionary<int, Vector3>)(object)func4;
		Func<object, Vector3> func5 = (Func<object, Vector3>)obj20;
		func3 = func4;
		object obj24 = 0;
		Dictionary<int, Vector3> dictionary3 = (Dictionary<int, Vector3>)(object)func4;
		Func<object, int> func6 = func4;
		object obj25 = obj13;
		if (obj23 != null)
		{
			goto IL_057c;
		}
		goto IL_0748;
		IL_07ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		object obj28;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v12+B8]");
			obj28 = 0;
		}
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)2736;
		Func<object, Quaternion> func7 = default(Func<object, Quaternion>);
		func7..ctor(obj28, (IntPtr)obj30);
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v11+B8]");
		object obj32 = (nint)0 + (nint)32;
		obj32 = func7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<object, Quaternion> elementSelector = func7;
		object obj34;
		object obj33 = obj34;
		Func<object, int> func8;
		Func<object, int> keySelector2 = func8;
		goto IL_0825;
		IL_0825:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v4-38]");
		Dictionary<int, Quaternion> dictionary4 = Enumerable.ToDictionary((IEnumerable<object>)0, keySelector2, elementSelector);
		object obj35 = this + 104;
		obj35 = dictionary4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v44+8]");
		func = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v44+8]");
		bool flag9 = (nint)0 == 0;
		obj9 = obj4;
		array2 = array;
		if (!flag9)
		{
			goto IL_00ee;
		}
		goto IL_02b1;
		IL_02b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v47+E4]");
		bool flag10 = (nint)0 == 0;
		object obj36 = !flag10;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj37 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v51+B8]");
			obj7 = 0;
		}
		object obj38 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)2712;
		Func<object, int> func9 = default(Func<object, int>);
		func9..ctor(obj7, (IntPtr)obj39);
		object obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v49+B8]");
		object obj41 = (nint)0 + (nint)8;
		obj41 = func9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
		bool flag11 = (nint)0 == 0;
		object obj42 = !flag11;
		func = func9;
		array = array2;
		object obj43 = 0;
		nint num2 = (nint)func9;
		nint num3 = (nint)obj39;
		Func<object, int> func10 = func9;
		object obj44 = obj4;
		if (obj42 != null)
		{
			goto IL_0143;
		}
		goto IL_0379;
		IL_0748:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj2;
		obj34 = (nint)0 + (nint)1672;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+B8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v6+20]");
		elementSelector = (Func<object, Quaternion>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v6+20]");
		bool flag12 = (nint)0 == 0;
		object obj45 = !flag12;
		func8 = func6;
		obj33 = obj34;
		keySelector2 = func6;
		if (obj45 == null)
		{
			goto IL_07ce;
		}
		goto IL_0825;
		IL_057c:
		obj33 = (nint)0 + (nint)1672;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+B8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v6+20]");
		elementSelector = (Func<object, Quaternion>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v6+20]");
		bool flag13 = (nint)0 == 0;
		object obj46 = !flag13;
		keySelector2 = func3;
		if (obj46 == null)
		{
			obj24 = obj10;
			dictionary3 = dictionary2;
			num = (nint)func5;
			obj34 = obj33;
			func8 = func3;
			goto IL_07ce;
		}
		goto IL_0825;
		IL_00ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
		bool flag14 = (nint)0 == 0;
		object obj47 = default(object);
		obj43 = obj47;
		IntPtr intPtr = default(IntPtr);
		num2 = intPtr;
		IntPtr intPtr2 = default(IntPtr);
		num3 = intPtr2;
		func10 = func;
		obj44 = obj4;
		array2 = array;
		if (!flag14)
		{
			goto IL_0143;
		}
		goto IL_0379;
		IL_0379:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj48 = (nint)0 + (nint)1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+B8]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+10]");
		func2 = (Func<object, Vector3>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+10]");
		bool flag15 = (nint)0 == 0;
		object obj50 = !flag15;
		Func<object, int> func11 = func10;
		IEnumerable<object> enumerable = array2;
		obj11 = obj48;
		keySelector = func10;
		source = array2;
		if (obj50 == null)
		{
			goto IL_040f;
		}
		goto IL_0466;
		IL_0143:
		obj11 = (nint)0 + (nint)1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+B8]");
		obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+10]");
		func2 = (Func<object, Vector3>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+10]");
		bool flag16 = (nint)0 == 0;
		object obj51 = !flag16;
		keySelector = func;
		source = array;
		if (obj51 == null)
		{
			obj43 = 0;
			num2 = (nint)func9;
			num3 = (nint)obj39;
			obj48 = obj11;
			func11 = func;
			enumerable = array;
			goto IL_040f;
		}
		goto IL_0466;
		IL_051f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+E4]");
		bool flag17 = (nint)0 == 0;
		dictionary2 = dictionary;
		func5 = func2;
		obj24 = obj10;
		dictionary3 = dictionary;
		num = (nint)func2;
		func6 = func3;
		obj25 = obj13;
		if (!flag17)
		{
			goto IL_057c;
		}
		goto IL_0748;
		IL_040f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
		bool flag18 = (nint)0 == 0;
		object obj52 = !flag18;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj53 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v39+B8]");
			obj49 = 0;
		}
		object obj54 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj55 = (nint)0 + (nint)2720;
		Func<object, Vector3> func12 = default(Func<object, Vector3>);
		func12..ctor(obj49, (IntPtr)obj55);
		object obj56 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v38+B8]");
		object obj57 = (nint)0 + (nint)16;
		obj57 = func12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func2 = func12;
		obj11 = obj48;
		keySelector = func11;
		source = enumerable;
		goto IL_0466;
	}

	public void TestHideWait()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_05a0: Expected O, but got I4
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v26+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v27+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v23+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v24+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj19 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj21 = items3 + list._size;
			object obj22 = obj21 + 32;
			obj22 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj23 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v20+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v21+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj23 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.KING, Suit.CLUBS);
		object obj26 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj27 = !flag4;
		if (obj27 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj28 = items4 + list._size;
			object obj29 = obj28 + 32;
			obj29 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit4 = Suit.CLUBS;
			object obj30 = card4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v10+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v17+C0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v18+70]");
			Suit suit4 = Suit.SPADES;
			list.AddWithResize((object)card4);
			object obj30 = card4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card5 = default(Card);
		card5..ctor(Rank.ACE, Suit.DIAMONDS);
		int version5 = list._version + 1;
		list._version = version5;
		object[] items5 = list._items;
		bool flag5 = list._size < items5.Length;
		object obj33 = !flag5;
		if (obj33 == null)
		{
			int size5 = list._size + 1;
			list._size = size5;
			object obj34 = items5 + list._size;
			object obj35 = obj34 + 32;
			obj35 = card5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)card5);
		}
		ShowCards((List<Card>)(object)list, 3f);
	}

	public void TestHideWait2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05db: Expected O, but got I4
		//IL_0659: Expected O, but got I
		//IL_0669: Expected O, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_06c0: Expected I, but got O
		//IL_06ea: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v27+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v28+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v24+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v25+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj19 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj21 = items3 + list._size;
			object obj22 = obj21 + 32;
			obj22 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj23 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v21+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v22+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj23 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.KING, Suit.CLUBS);
		object obj26 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj27 = !flag4;
		if (obj27 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj28 = items4 + list._size;
			object obj29 = obj28 + 32;
			obj29 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit4 = Suit.CLUBS;
			object obj30 = card4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v10+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v18+C0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v19+70]");
			Suit suit4 = Suit.SPADES;
			list.AddWithResize((object)card4);
			object obj30 = card4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card5 = default(Card);
		card5..ctor(Rank.ACE, Suit.DIAMONDS);
		object obj33 = obj4;
		int version5 = list._version + 1;
		list._version = version5;
		object[] items5 = list._items;
		object obj34 = typeof(SqlSingle[]) + 2376;
		object obj35 = (nint)0 + (nint)3376;
		object obj36 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		bool flag5 = list._size < items5.Length;
		object obj37 = !flag5;
		if (obj37 == null)
		{
			int size5 = list._size + 1;
			list._size = size5;
			object obj38 = items5 + list._size;
			object obj39 = obj38 + 32;
			obj39 = card5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit5 = Suit.DIAMONDS;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v12+20]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v15+C0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v16+70]");
			Suit suit5 = Suit.SPADES;
			list.AddWithResize((object)card5);
		}
		ShowCards((List<Card>)(object)list, 10f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj35);
		object obj42 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		object obj43 = !flag6;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
	}

	public void TestHideWait3()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05db: Expected O, but got I4
		//IL_0659: Expected O, but got I
		//IL_0669: Expected O, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_06c0: Expected I, but got O
		//IL_06ea: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v28+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v29+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v25+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v26+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj19 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj21 = items3 + list._size;
			object obj22 = obj21 + 32;
			obj22 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj23 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v22+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v23+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj23 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.KING, Suit.CLUBS);
		object obj26 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj27 = !flag4;
		if (obj27 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj28 = items4 + list._size;
			object obj29 = obj28 + 32;
			obj29 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit4 = Suit.CLUBS;
			object obj30 = card4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v10+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v19+C0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v20+70]");
			Suit suit4 = Suit.SPADES;
			list.AddWithResize((object)card4);
			object obj30 = card4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card5 = default(Card);
		card5..ctor(Rank.ACE, Suit.DIAMONDS);
		object obj33 = obj4;
		int version5 = list._version + 1;
		list._version = version5;
		object[] items5 = list._items;
		object obj34 = typeof(SqlSingle[]) + 2376;
		object obj35 = (nint)0 + (nint)3376;
		object obj36 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		bool flag5 = list._size < items5.Length;
		object obj37 = !flag5;
		if (obj37 == null)
		{
			int size5 = list._size + 1;
			list._size = size5;
			object obj38 = items5 + list._size;
			object obj39 = obj38 + 32;
			obj39 = card5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit5 = Suit.DIAMONDS;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v12+20]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v16+C0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v17+70]");
			Suit suit5 = Suit.SPADES;
			list.AddWithResize((object)card5);
		}
		ShowCards((List<Card>)(object)list, 100f, 7f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj35);
		object obj42 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		object obj43 = !flag6;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
	}

	public void TestHideWait4()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05db: Expected O, but got I4
		//IL_0659: Expected O, but got I
		//IL_0669: Expected O, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_06c0: Expected I, but got O
		//IL_06ea: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v28+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v29+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v25+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v26+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj19 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj21 = items3 + list._size;
			object obj22 = obj21 + 32;
			obj22 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj23 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v22+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v23+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj23 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.KING, Suit.CLUBS);
		object obj26 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj27 = !flag4;
		if (obj27 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj28 = items4 + list._size;
			object obj29 = obj28 + 32;
			obj29 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit4 = Suit.CLUBS;
			object obj30 = card4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v10+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v19+C0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v20+70]");
			Suit suit4 = Suit.SPADES;
			list.AddWithResize((object)card4);
			object obj30 = card4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card5 = default(Card);
		card5..ctor(Rank.ACE, Suit.DIAMONDS);
		object obj33 = obj4;
		int version5 = list._version + 1;
		list._version = version5;
		object[] items5 = list._items;
		object obj34 = typeof(SqlSingle[]) + 2376;
		object obj35 = (nint)0 + (nint)3384;
		object obj36 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		bool flag5 = list._size < items5.Length;
		object obj37 = !flag5;
		if (obj37 == null)
		{
			int size5 = list._size + 1;
			list._size = size5;
			object obj38 = items5 + list._size;
			object obj39 = obj38 + 32;
			obj39 = card5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit5 = Suit.DIAMONDS;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v12+20]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v16+C0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v17+70]");
			Suit suit5 = Suit.SPADES;
			list.AddWithResize((object)card5);
		}
		ShowCards((List<Card>)(object)list, 100f, 7f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj35);
		object obj42 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		object obj43 = !flag6;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
	}

	public void TestHideWait5()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0195: Expected O, but got I
		//IL_01a5: Expected O, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_024b: Expected O, but got I4
		//IL_02d1: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_0387: Expected O, but got I4
		//IL_040d: Expected O, but got I
		//IL_041d: Expected O, but got I
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_04c3: Expected O, but got I4
		//IL_0541: Expected O, but got I
		//IL_0551: Expected O, but got I
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_0644: Expected O, but got I4
		//IL_06ca: Expected O, but got I
		//IL_06da: Expected O, but got I
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_0780: Expected O, but got I4
		//IL_0806: Expected O, but got I
		//IL_0816: Expected O, but got I
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected O, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_08bc: Expected O, but got I4
		//IL_0942: Expected O, but got I
		//IL_0952: Expected O, but got I
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected O, but got Unknown
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected O, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected O, but got Unknown
		//IL_09f8: Expected O, but got I
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected O, but got Unknown
		//IL_0a2c: Expected O, but got I4
		//IL_0aaa: Expected O, but got I
		//IL_0aba: Expected O, but got I
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected O, but got Unknown
		//IL_0b0b: Expected I, but got O
		//IL_0b35: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj4 = (nint)0 + (nint)2632;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj7 = (nint)0 + (nint)2648;
		object obj8 = obj7;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj9 = !flag;
		if (obj9 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj10 = items + list._size;
			object obj11 = obj10 + 32;
			obj11 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj12 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v4+20]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v43+C0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v44+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj12 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj15 = obj7;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj17 = items2 + list._size;
			object obj18 = obj17 + 32;
			obj18 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj19 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v6+20]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v40+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v41+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj19 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj22 = obj7;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj24 = items3 + list._size;
			object obj25 = obj24 + 32;
			obj25 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj26 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v8+20]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v37+C0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v38+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj26 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.ACE, Suit.DIAMONDS);
		object obj29 = obj7;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj30 = !flag4;
		if (obj30 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj31 = items4 + list._size;
			object obj32 = obj31 + 32;
			obj32 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit4 = Suit.DIAMONDS;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v10+20]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v34+C0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v35+70]");
			Suit suit4 = Suit.SPADES;
			list.AddWithResize((object)card4);
		}
		object obj35 = obj2 + 24;
		obj35 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ShowCards((List<Card>)obj35, 100f, 7f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card5 = default(Card);
		card5..ctor(Rank.KING, Suit.HEARTS);
		object obj36 = obj7;
		int version5 = list2._version + 1;
		list2._version = version5;
		object[] items5 = list2._items;
		bool flag5 = list2._size < items5.Length;
		object obj37 = !flag5;
		if (obj37 == null)
		{
			int size5 = list2._size + 1;
			list2._size = size5;
			object obj38 = items5 + list2._size;
			object obj39 = obj38 + 32;
			obj39 = card5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit5 = Suit.HEARTS;
			object obj40 = card5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v13+20]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v31+C0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v32+70]");
			Suit suit5 = Suit.SPADES;
			list2.AddWithResize((object)card5);
			object obj40 = card5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card6 = default(Card);
		card6..ctor(Rank.KING, Suit.SPADES);
		object obj43 = obj7;
		int version6 = list2._version + 1;
		list2._version = version6;
		object[] items6 = list2._items;
		bool flag6 = list2._size < items6.Length;
		object obj44 = !flag6;
		if (obj44 == null)
		{
			int size6 = list2._size + 1;
			list2._size = size6;
			object obj45 = items6 + list2._size;
			object obj46 = obj45 + 32;
			obj46 = card6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit6 = Suit.SPADES;
			object obj47 = card6;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v15+20]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v28+C0]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v29+70]");
			Suit suit6 = Suit.SPADES;
			list2.AddWithResize((object)card6);
			object obj47 = card6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card7 = default(Card);
		card7..ctor(Rank.KING, Suit.CLUBS);
		object obj50 = obj7;
		int version7 = list2._version + 1;
		list2._version = version7;
		object[] items7 = list2._items;
		bool flag7 = list2._size < items7.Length;
		object obj51 = !flag7;
		if (obj51 == null)
		{
			int size7 = list2._size + 1;
			list2._size = size7;
			object obj52 = items7 + list2._size;
			object obj53 = obj52 + 32;
			obj53 = card7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit7 = Suit.CLUBS;
			object obj54 = card7;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v17+20]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v25+C0]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v26+70]");
			Suit suit7 = Suit.SPADES;
			list2.AddWithResize((object)card7);
			object obj54 = card7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card8 = default(Card);
		card8..ctor(Rank.KING, Suit.DIAMONDS);
		object obj57 = obj7;
		int version8 = list2._version + 1;
		list2._version = version8;
		object[] items8 = list2._items;
		object obj58 = typeof(SqlSingle[]) + 2376;
		object obj59 = (nint)0 + (nint)2752;
		object obj60 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		bool flag8 = list2._size < items8.Length;
		object obj61 = !flag8;
		if (obj61 == null)
		{
			int size8 = list2._size + 1;
			list2._size = size8;
			object obj62 = items8 + list2._size;
			object obj63 = obj62 + 32;
			obj63 = card8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit8 = Suit.DIAMONDS;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v19+20]");
			object obj64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v22+C0]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v23+70]");
			Suit suit8 = Suit.SPADES;
			list2.AddWithResize((object)card8);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj59);
		object obj66 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v44+E4]");
		bool flag9 = (nint)0 == 0;
		object obj67 = !flag9;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
	}

	public void TestShowCards1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj4 = !flag;
		if (obj4 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj5 = items + list._size;
			object obj6 = obj5 + 32;
			obj6 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)card);
		}
		ShowCards((List<Card>)(object)list);
	}

	public void TestShowCards2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v12+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v13+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj13 = items2 + list._size;
			object obj14 = obj13 + 32;
			obj14 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)card2);
		}
		ShowCards((List<Card>)(object)list);
	}

	public void TestShowCards3()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0328: Expected O, but got I4
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v17+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v18+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v14+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v15+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj20 = items3 + list._size;
			object obj21 = obj20 + 32;
			obj21 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)card3);
		}
		ShowCards((List<Card>)(object)list);
	}

	public void TestShowCards4()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0464: Expected O, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v22+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v23+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v19+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v20+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj19 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj21 = items3 + list._size;
			object obj22 = obj21 + 32;
			obj22 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj23 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v16+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v17+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj23 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.KING, Suit.CLUBS);
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj27 = items4 + list._size;
			object obj28 = obj27 + 32;
			obj28 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)card4);
		}
		ShowCards((List<Card>)(object)list);
	}

	public void TestShowCards5()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_05a0: Expected O, but got I4
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v27+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v28+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v24+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v25+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj19 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj21 = items3 + list._size;
			object obj22 = obj21 + 32;
			obj22 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj23 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v21+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v22+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj23 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.KING, Suit.CLUBS);
		object obj26 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj27 = !flag4;
		if (obj27 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj28 = items4 + list._size;
			object obj29 = obj28 + 32;
			obj29 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit4 = Suit.CLUBS;
			object obj30 = card4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v10+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v18+C0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v19+70]");
			Suit suit4 = Suit.SPADES;
			list.AddWithResize((object)card4);
			object obj30 = card4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card5 = default(Card);
		card5..ctor(Rank.ACE, Suit.DIAMONDS);
		int version5 = list._version + 1;
		list._version = version5;
		object[] items5 = list._items;
		bool flag5 = list._size < items5.Length;
		object obj33 = !flag5;
		if (obj33 == null)
		{
			int size5 = list._size + 1;
			list._size = size5;
			object obj34 = items5 + list._size;
			object obj35 = obj34 + 32;
			obj35 = card5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)card5);
		}
		ShowCards((List<Card>)(object)list);
	}

	public void TestShowCards6()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I4
		//IL_062d: Expected O, but got I
		//IL_063d: Expected O, but got I
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_06dc: Expected O, but got I4
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected O, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v32+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v33+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v29+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v30+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj19 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj21 = items3 + list._size;
			object obj22 = obj21 + 32;
			obj22 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj23 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v26+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v27+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj23 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.KING, Suit.CLUBS);
		object obj26 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj27 = !flag4;
		if (obj27 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj28 = items4 + list._size;
			object obj29 = obj28 + 32;
			obj29 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit4 = Suit.CLUBS;
			object obj30 = card4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v10+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v23+C0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v24+70]");
			Suit suit4 = Suit.SPADES;
			list.AddWithResize((object)card4);
			object obj30 = card4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card5 = default(Card);
		card5..ctor(Rank.ACE, Suit.DIAMONDS);
		object obj33 = obj4;
		int version5 = list._version + 1;
		list._version = version5;
		object[] items5 = list._items;
		bool flag5 = list._size < items5.Length;
		object obj34 = !flag5;
		if (obj34 == null)
		{
			int size5 = list._size + 1;
			list._size = size5;
			object obj35 = items5 + list._size;
			object obj36 = obj35 + 32;
			obj36 = card5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit5 = Suit.DIAMONDS;
			object obj37 = card5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v12+20]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v20+C0]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v21+70]");
			Suit suit5 = Suit.SPADES;
			list.AddWithResize((object)card5);
			object obj37 = card5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card6 = default(Card);
		card6..ctor(Rank.TEN, Suit.DIAMONDS);
		int version6 = list._version + 1;
		list._version = version6;
		object[] items6 = list._items;
		bool flag6 = list._size < items6.Length;
		object obj40 = !flag6;
		if (obj40 == null)
		{
			int size6 = list._size + 1;
			list._size = size6;
			object obj41 = items6 + list._size;
			object obj42 = obj41 + 32;
			obj42 = card6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)card6);
		}
		ShowCards((List<Card>)(object)list);
	}

	public void TestShowCards7()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I4
		//IL_062d: Expected O, but got I
		//IL_063d: Expected O, but got I
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_06e3: Expected O, but got I4
		//IL_0769: Expected O, but got I
		//IL_0779: Expected O, but got I
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_0818: Expected O, but got I4
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected O, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(Rank.ACE, Suit.HEARTS);
		object obj4 = (nint)0 + (nint)2648;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit = Suit.HEARTS;
			object obj9 = card;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v37+C0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v38+70]");
			Suit suit = Suit.SPADES;
			list.AddWithResize((object)card);
			object obj9 = card;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(Rank.ACE, Suit.SPADES);
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit2 = Suit.SPADES;
			object obj16 = card2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v34+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v35+70]");
			Suit suit2 = Suit.SPADES;
			list.AddWithResize((object)card2);
			object obj16 = card2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card3 = default(Card);
		card3..ctor(Rank.ACE, Suit.CLUBS);
		object obj19 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj21 = items3 + list._size;
			object obj22 = obj21 + 32;
			obj22 = card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit3 = Suit.CLUBS;
			object obj23 = card3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v31+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v32+70]");
			Suit suit3 = Suit.SPADES;
			list.AddWithResize((object)card3);
			object obj23 = card3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card4 = default(Card);
		card4..ctor(Rank.KING, Suit.CLUBS);
		object obj26 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj27 = !flag4;
		if (obj27 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj28 = items4 + list._size;
			object obj29 = obj28 + 32;
			obj29 = card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit4 = Suit.CLUBS;
			object obj30 = card4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v10+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v28+C0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v29+70]");
			Suit suit4 = Suit.SPADES;
			list.AddWithResize((object)card4);
			object obj30 = card4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card5 = default(Card);
		card5..ctor(Rank.ACE, Suit.DIAMONDS);
		object obj33 = obj4;
		int version5 = list._version + 1;
		list._version = version5;
		object[] items5 = list._items;
		bool flag5 = list._size < items5.Length;
		object obj34 = !flag5;
		if (obj34 == null)
		{
			int size5 = list._size + 1;
			list._size = size5;
			object obj35 = items5 + list._size;
			object obj36 = obj35 + 32;
			obj36 = card5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit5 = Suit.DIAMONDS;
			object obj37 = card5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v12+20]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v25+C0]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v26+70]");
			Suit suit5 = Suit.SPADES;
			list.AddWithResize((object)card5);
			object obj37 = card5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card6 = default(Card);
		card6..ctor(Rank.TEN, Suit.DIAMONDS);
		object obj40 = obj4;
		int version6 = list._version + 1;
		list._version = version6;
		object[] items6 = list._items;
		bool flag6 = list._size < items6.Length;
		object obj41 = !flag6;
		if (obj41 == null)
		{
			int size6 = list._size + 1;
			list._size = size6;
			object obj42 = items6 + list._size;
			object obj43 = obj42 + 32;
			obj43 = card6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Suit suit6 = Suit.DIAMONDS;
			object obj44 = card6;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v14+20]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v22+C0]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v23+70]");
			Suit suit6 = Suit.SPADES;
			list.AddWithResize((object)card6);
			object obj44 = card6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card7 = default(Card);
		card7..ctor(Rank.KING, Suit.HEARTS);
		int version7 = list._version + 1;
		list._version = version7;
		object[] items7 = list._items;
		bool flag7 = list._size < items7.Length;
		object obj47 = !flag7;
		if (obj47 == null)
		{
			int size7 = list._size + 1;
			list._size = size7;
			object obj48 = items7 + list._size;
			object obj49 = obj48 + 32;
			obj49 = card7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)card7);
		}
		ShowCards((List<Card>)(object)list);
	}
}
