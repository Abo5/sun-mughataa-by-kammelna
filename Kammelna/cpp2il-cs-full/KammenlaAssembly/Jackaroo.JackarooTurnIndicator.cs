using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooTurnIndicator : MonoBehaviour
{
	private RectTransform _ringTransform;

	private Image _ringImage;

	private RectTransform _arrowTransform;

	private Image _arrowImage;

	private Vector2 _defaultVector;

	private Vector2 _playerVector;

	private float _rotationDuration = 0f / 0f;

	private int _lastPlayerIndex;

	private void Awake()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0011: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		object obj = this + 32;
		obj = rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		object obj2 = (nint)0 + (nint)1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj3 = this + 40;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v4+10]");
		RectTransform rectTransform2 = ((Graphic)0).rectTransform;
		object obj5 = this + 48;
		obj5 = rectTransform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Vector2 sizeDelta = ((RectTransform)obj5).sizeDelta;
		Vector2 defaultVector = default(Vector2);
		_defaultVector = defaultVector;
	}

	public void SetTurn(int playerRotatedIndex, Color color)
	{
		//IL_027d: Expected O, but got I4
		//IL_0297: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_005e: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0258: Expected O, but got I
		//IL_00f9: Invalid comparison between F4 and I4
		//IL_02be: Invalid comparison between F4 and I4
		//IL_02cd: Invalid comparison between F4 and I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02ee: Expected O, but got F4
		//IL_0323: Expected O, but got I4
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_036a: Expected F4, but got O
		//IL_036a: Expected O, but got I4
		//IL_0139: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		//IL_03ed: Expected F4, but got I
		//IL_03ed: Expected O, but got I4
		//IL_0412: Expected O, but got I
		//IL_0422: Expected F4, but got I
		//IL_042b: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_0167: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_01bc: Expected O, but got I
		if (_lastPlayerIndex == playerRotatedIndex)
		{
			return;
		}
		object obj = playerRotatedIndex - 1;
		bool flag = (nint)obj < 4;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(UsageHint) + 816;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X9_v5+B8]");
			object obj5 = 0;
			object obj6 = 119877632 + 912;
			int num = ShortcutExtensions.DOKill(_ringTransform);
			bool flag2 = (object)_ringTransform == null;
			float num3 = default(float);
			float num2 = num3;
			float num5 = default(float);
			float num4 = num5;
			object obj8 = default(object);
			object obj7 = obj8;
			float num7 = default(float);
			float num6 = num7;
			Color color2 = (Color)0;
			if (!flag2)
			{
				Vector3 localEulerAngles = _ringTransform.localEulerAngles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X9_v8+v150 @ X8_v5*4]");
				float num8 = 0f - num5;
				float num9 = num8 + 1.13587E+09f;
				if (num8 < 0f)
				{
					num8 = num9;
				}
				float num10 = num8 - 1.13587E+09f;
				bool flag3 = num10 < 0f;
				bool flag4 = num10 == 0f;
				object obj9 = num8 ^ 0x43B40000;
				object obj10 = num8 ^ num10;
				object obj11 = obj9 & obj10;
				bool flag5 = (nint)obj11 < 0;
				bool flag6 = flag3 == flag5;
				object obj12 = !flag4;
				object obj13 = flag6 & obj12;
				object obj14 = ~obj13;
				if (obj14 == null)
				{
				}
				num2 = _rotationDuration;
				Tweener tweener = ShortcutExtensions.DOBlendableLocalRotateBy(_ringTransform, (Vector3)1, (float)obj5);
				if (playerRotatedIndex == 1)
				{
					object obj15 = 72;
				}
				else
				{
					object obj15 = 64;
				}
				if (playerRotatedIndex == 1)
				{
					object obj16 = 76;
				}
				else
				{
					object obj16 = 68;
				}
				int num11 = ShortcutExtensions.DOKill(_arrowTransform);
				num4 = _rotationDuration;
				RectTransform arrowTransform = _arrowTransform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooTurnIndicator)+v297 @ X8_v13]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(arrowTransform, (Vector2)0, 0f);
				bool flag7 = (object)_ringImage == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooTurnIndicator)+v291 @ X9_v12]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooTurnIndicator)+v297 @ X8_v13]");
				num6 = 0f;
				color2 = (Color)0;
				if (!flag7)
				{
					_ringImage.color = (Color)0;
					bool flag8 = (object)_arrowImage == null;
					num2 = num3;
					num4 = num5;
					obj7 = obj8;
					num6 = num7;
					color2 = (Color)0;
					if (!flag8)
					{
						_arrowImage.color = (Color)0;
						_lastPlayerIndex = playerRotatedIndex;
						return;
					}
				}
			}
			throw new NullReferenceException();
		}
		object obj17 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj18 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = "placementId" + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj20 = (nint)0 + (nint)976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
