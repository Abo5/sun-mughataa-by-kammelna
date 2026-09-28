using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class AvatarCropperUI : PopupUI
{
	private RawImage userImage;

	private RectTransform viewport;

	private Button saveButton;

	private GameObject loadingIndicator;

	private PopupUI loadingBlocker;

	private int cropSize = 500;

	private Texture2D sourceTex;

	private Texture2D destTex;

	private float ratio = 1f;

	private WebCamTexture _cameraTexture;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0296: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00a0: Expected I, but got O
		//IL_01c4: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02e6: Expected O, but got I
		//IL_02f4: Expected I, but got O
		//IL_015e: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		object obj = (nint)0 + (nint)376;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31418");
		InvalidCastException ex = (InvalidCastException)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6 (System.InvalidCastException)+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = 1;
		UnityEngine.Object obj5 = default(UnityEngine.Object);
		object obj6;
		UnityEngine.Object obj7;
		if (!flag)
		{
			bool flag2 = obj5 != null;
			bool flag3 = !flag2;
			obj6 = 0;
			obj7 = null;
			if (!flag3)
			{
				goto IL_005a;
			}
			return;
		}
		goto IL_016b;
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = obj5 != null;
		bool flag5 = !flag4;
		object obj8 = !flag5;
		obj6 = 0;
		obj7 = null;
		if (obj8 == null)
		{
			return;
		}
		goto IL_005a;
		IL_005a:
		object a = obj5 + 40;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)2096;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj10);
		Delegate obj11 = Delegate.Combine((Delegate)a, action);
		object obj16;
		if ((object)obj11 != null)
		{
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj13 = default(object);
			if (obj13 != null)
			{
				a = obj13;
				obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				object obj14 = default(object);
				bool flag6 = obj14 == null;
				object obj15 = !flag6;
				obj16 = obj14;
				if (obj15 != null)
				{
					goto IL_02a4;
				}
			}
			ex = new InvalidCastException();
			obj3 = 0;
			obj4 = obj12;
			goto IL_016b;
		}
		a = 0;
		obj16 = 0;
		goto IL_02a4;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_02a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object a2 = obj5 + 48;
		object obj17 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)2088;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj18);
		Delegate obj19 = Delegate.Combine((Delegate)a2, action2);
		if ((object)obj19 != null)
		{
			if (obj19 == obj17)
			{
				a2 = obj19;
				if (obj19 == obj17)
				{
					goto IL_02f9;
				}
			}
			throw new InvalidCastException();
		}
		a2 = 0;
		goto IL_02f9;
	}

	private void ShowLoading()
	{
		loadingBlocker.PopFromCenter();
	}

	private void HideLoading()
	{
		loadingBlocker.ShrinkToParent();
	}

	public void OnImageSelected(Texture2D texture2D)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		UnregisterEvents();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (texture2D != null)
		{
			loadingBlocker.ShrinkToParent();
			PopFromCenter();
			LoadTexture(texture2D);
		}
		else
		{
			loadingBlocker.ShrinkToParent();
		}
	}

	private void LoadTexture(Texture2D loadedTexture)
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		userImage.texture = loadedTexture;
		RawImage rawImage = userImage;
		Texture texture = rawImage.m_Texture;
		if ((object)rawImage.m_Texture != null)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
			if (texture == obj)
			{
				object obj2 = this + 168;
				obj2 = rawImage.m_Texture;
				if (texture == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ShowPreview();
					return;
				}
			}
			throw new InvalidCastException();
		}
		object obj3 = this + 168;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ShowPreview();
	}

	private void OnCameraFeedReady(WebCamTexture webCamTexture)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		UnregisterEvents();
		loadingBlocker.ShrinkToParent();
		PopFromCenter();
		object obj = this + 192;
		obj = webCamTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X21_v3-48]");
		((RawImage)0).texture = _cameraTexture;
		ShowPreview();
	}

	private void ShowPreview()
	{
		//IL_0027: Expected O, but got I4
		//IL_0093: Invalid comparison between I4 and F8
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0222: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_0287: Expected O, but got I4
		//IL_0106: Invalid comparison between I4 and F8
		//IL_02ef: Expected I, but got O
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_016a: Expected O, but got I4
		//IL_02d3: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_035a: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_01d0: Expected O, but got I4
		RectTransform rectTransform = userImage.rectTransform;
		rectTransform.localPosition = (Vector3)0;
		userImage.SetNativeSize();
		RawImage rawImage = userImage;
		int width = rawImage.m_Texture.width;
		RawImage rawImage2 = userImage;
		int height = rawImage2.m_Texture.height;
		int num = width / height;
		Texture texture;
		object obj4;
		if ((double)num < 1.0)
		{
			RawImage rawImage3 = userImage;
			int width2 = rawImage3.m_Texture.width;
			RawImage rawImage4 = userImage;
			int height2 = rawImage4.m_Texture.height;
			num = width2 / height2;
			if (!((double)num < 1.0))
			{
				goto IL_028c;
			}
			Rect rect = viewport.rect;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v41+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RawImage rawImage5 = userImage;
			texture = rawImage5.m_Texture;
			obj4 = 0;
			object obj5 = 392;
			double num2 = 1.0;
			object obj6 = 400;
		}
		else
		{
			Rect rect2 = viewport.rect;
			object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RawImage rawImage6 = userImage;
			texture = rawImage6.m_Texture;
			object obj10 = default(object);
			obj4 = obj10;
			object obj5 = 424;
			double num2 = 1.0;
			object obj6 = 432;
		}
		nint num3 = (nint)texture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ X10_v2 (Il2CppClass<UnityEngine.Texture>)+v296 @ X9_v5] (should have been resolved before IL gen)");
		object obj11 = default(object);
		float num4 = (float)obj4 / (float)obj11;
		ratio = num4;
		goto IL_028c;
		IL_028c:
		RectTransform rectTransform2 = userImage.rectTransform;
		object obj12 = typeof(UsageHint) + 816;
		rectTransform2.localScale = (Vector3)0;
		object obj13 = (nint)0 + (nint)2904;
		RectTransform rectTransform3 = userImage.rectTransform;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v17+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v18+C]");
		float duration = 0f * ratio;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rectTransform3, (Vector3)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void AssignSourceTex()
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		object obj = this + 192;
		object obj2 = obj;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ X8_v4+188] (should have been resolved before IL gen)");
		object obj4 = obj;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ X8_v5+1A8] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Texture2D texture2D = default(Texture2D);
		int width = default(int);
		int height = default(int);
		texture2D..ctor(width, height);
		int width2 = ((Texture)obj).width;
		object obj7 = obj;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ X8_v7+1A8] (should have been resolved before IL gen)");
		int blockHeight = default(int);
		Color[] pixels = ((WebCamTexture)obj).GetPixels(0, 0, width2, blockHeight);
		texture2D.SetPixels(pixels);
		texture2D.Apply();
		((WebCamTexture)obj).Stop();
		object obj9 = this + 168;
		obj9 = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Close()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_003d: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_0175: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		ShrinkToParent();
		object obj2 = this + 192;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj2 != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0086;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((UnityEngine.Object)obj2 != null)
			{
				goto IL_0086;
			}
		}
		goto IL_0094;
		IL_0154:
		loadingIndicator.SetActive(value: false);
		goto IL_0169;
		IL_0169:
		object obj5 = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Behaviour behaviour = default(Behaviour);
		behaviour.enabled = true;
		return;
		IL_0086:
		((WebCamTexture)obj2).Stop();
		goto IL_0094;
		IL_0094:
		userImage.texture = null;
		_cameraTexture = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = loadingIndicator != null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 != null)
			{
				goto IL_0154;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (loadingIndicator != null)
			{
				goto IL_0154;
			}
		}
		goto IL_0169;
	}

	public void CropAndSubmit()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_029a: Expected O, but got I4
		//IL_02a3: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_0218: Expected O, but got I4
		//IL_0221: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_03a2: Expected O, but got I4
		//IL_0e6c: Invalid comparison between F8 and I4
		//IL_03cc: Expected F8, but got I8
		//IL_0405: Invalid comparison between F8 and I4
		//IL_0429: Expected F8, but got I8
		//IL_0452: Invalid comparison between F8 and I4
		//IL_04bb: Invalid comparison between F8 and I4
		//IL_0497: Expected F8, but got I4
		//IL_0500: Expected F8, but got I4
		//IL_0577: Expected I, but got O
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_0f38: Expected O, but got I4
		//IL_0603: Expected F8, but got I8
		//IL_061d: Expected I, but got O
		//IL_0fa8: Expected O, but got I4
		//IL_0696: Expected F8, but got I8
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected O, but got Unknown
		//IL_0711: Invalid comparison between F8 and I4
		//IL_0724: Expected O, but got F8
		//IL_0731: Expected O, but got F8
		//IL_0766: Expected O, but got I4
		//IL_0fde: Invalid comparison between F8 and I4
		//IL_0ff1: Expected O, but got F8
		//IL_0ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Expected O, but got Unknown
		//IL_1026: Expected O, but got I4
		//IL_104c: Expected O, but got I4
		//IL_1073: Invalid comparison between F8 and I4
		//IL_1086: Expected O, but got F8
		//IL_1093: Expected O, but got F8
		//IL_10c8: Expected O, but got I4
		//IL_0793: Expected F8, but got I4
		//IL_10e8: Invalid comparison between F8 and I4
		//IL_10fb: Expected O, but got F8
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Expected O, but got Unknown
		//IL_1130: Expected O, but got I4
		//IL_07c8: Expected I4, but got F8
		//IL_1166: Expected I4, but got F8
		//IL_1166: Expected I4, but got F8
		//IL_1166: Expected I4, but got F8
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Expected O, but got Unknown
		//IL_087f: Expected O, but got I4
		//IL_0895: Expected O, but got I
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected O, but got Unknown
		//IL_092d: Expected O, but got I
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected O, but got Unknown
		//IL_0955: Expected O, but got I4
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected O, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected O, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected O, but got Unknown
		//IL_11a6: Expected O, but got I
		//IL_11cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected O, but got Unknown
		//IL_11d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11de: Expected O, but got Unknown
		//IL_0985: Expected O, but got I4
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected O, but got Unknown
		//IL_0a3d: Expected O, but got I
		//IL_1476: Unknown result type (might be due to invalid IL or missing references)
		//IL_147b: Expected O, but got Unknown
		//IL_1483: Unknown result type (might be due to invalid IL or missing references)
		//IL_1488: Expected O, but got Unknown
		//IL_149f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a4: Expected I4, but got Unknown
		//IL_14b1: Expected I4, but got O
		//IL_14e6: Expected O, but got I4
		//IL_1207: Unknown result type (might be due to invalid IL or missing references)
		//IL_120c: Expected O, but got Unknown
		//IL_0a88: Expected I4, but got O
		//IL_1286: Expected O, but got I4
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Expected O, but got Unknown
		//IL_0bc1: Expected O, but got I4
		//IL_12b1: Invalid comparison between F8 and I4
		//IL_12c2: Expected O, but got I4
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected O, but got Unknown
		//IL_1333: Expected O, but got I4
		//IL_135e: Invalid comparison between F8 and I4
		//IL_136f: Expected O, but got I4
		//IL_138f: Invalid comparison between F8 and I4
		//IL_13a2: Expected O, but got F8
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13af: Expected O, but got Unknown
		//IL_13d7: Expected O, but got I4
		//IL_13fb: Invalid comparison between F8 and I8
		//IL_141b: Invalid comparison between F8 and I4
		//IL_1429: Expected I4, but got F8
		//IL_0c44: Expected F8, but got I8
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Expected O, but got Unknown
		//IL_0d94: Expected O, but got I
		//IL_0dbc: Expected O, but got I4
		//IL_0c89: Invalid comparison between F8 and I4
		//IL_0c98: Invalid comparison between F8 and I4
		//IL_0cab: Expected O, but got F8
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected O, but got Unknown
		//IL_0ce0: Expected O, but got I4
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected I4, but got Unknown
		//IL_0d06: Expected I4, but got F8
		//IL_0e18: Expected I, but got O
		//IL_0d67: Expected I4, but got F8
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E731F]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v105+E4]");
			bool flag = (nint)0 == 0;
			obj5 = loadingIndicator;
			obj6 = loadingIndicator;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = loadingIndicator;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v105+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = loadingIndicator;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (obj6 != null)
		{
			goto IL_0150;
		}
		goto IL_0184;
		IL_0230:
		Graphic graphic = userImage;
		bool flag3 = (object)userImage == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_02ff;
		}
		goto IL_0e2b;
		IL_0e2b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0e39;
		IL_0e39:
		throw new IndexOutOfRangeException();
		IL_0091:
		bool flag4 = obj5 != null;
		bool flag5 = !flag4;
		object obj9 = !flag5;
		if (obj9 != null)
		{
			goto IL_0150;
		}
		goto IL_0184;
		IL_0150:
		if ((object)loadingIndicator != null)
		{
			loadingIndicator.SetActive(value: true);
			goto IL_0184;
		}
		goto IL_0e2b;
		IL_02ff:
		RectTransform rectTransform = graphic.rectTransform;
		double num3;
		object obj16;
		double num16;
		int num23;
		object obj40;
		int num24;
		if ((object)rectTransform != null)
		{
			Vector3 localScale = rectTransform.localScale;
			if ((object)viewport != null)
			{
				object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				Rect rect = viewport.rect;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj13 = default(object);
				double num = 1.0 / (double)obj13;
				object obj14 = default(object);
				double num2 = num * (double)obj14;
				num3 = ((num2 != 2139095040.0) ? num2 : 2147483648.0);
				if ((object)viewport != null)
				{
					Rect rect2 = viewport.rect;
					object obj15 = default(object);
					double num4 = num * (double)obj15;
					double num5 = ((num4 != 2139095040.0) ? num4 : 2147483648.0);
					if ((object)sourceTex != null)
					{
						int width = sourceTex.width;
						if (num3 > (double)width)
						{
							if ((object)sourceTex == null)
							{
								goto IL_0e2b;
							}
							double num6 = sourceTex.width;
							num3 = num6;
						}
						if ((object)sourceTex != null)
						{
							int height = sourceTex.height;
							if (num5 > (double)height)
							{
								if ((object)sourceTex == null)
								{
									goto IL_0e2b;
								}
								double num7 = sourceTex.height;
								num5 = num7;
							}
							if ((object)userImage != null)
							{
								RectTransform rectTransform2 = userImage.rectTransform;
								if ((object)rectTransform2 != null)
								{
									Vector3 localPosition = rectTransform2.localPosition;
									Texture2D texture2D = sourceTex;
									if ((object)sourceTex != null)
									{
										nint num8 = (nint)texture2D;
										int width2 = sourceTex.width;
										double num9 = num * num4;
										double num10 = (double)width2 - num9;
										obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
										double num11 = num10 - num3;
										object obj17 = obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v29+E4]");
										bool flag7 = (nint)0 == 0;
										object obj18 = !flag7;
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
										double num12 = ((width2 != 2139095040) ? num11 : 2147483648.0);
										Texture2D texture2D2 = sourceTex;
										if ((object)sourceTex != null)
										{
											nint num13 = (nint)texture2D2;
											int height2 = sourceTex.height;
											double num14 = num * 2139095040.0;
											double num15 = (double)height2 - num14;
											num16 = num15 - num5;
											object obj19 = obj16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v34+E4]");
											bool flag8 = (nint)0 == 0;
											object obj20 = !flag8;
											if (obj20 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
											double num17 = ((height2 != 2139095040) ? num16 : 2147483648.0);
											if ((object)sourceTex != null)
											{
												int width3 = sourceTex.width;
												if ((object)sourceTex != null)
												{
													object obj21 = typeof(TypeConverter<ushort, char>) + 3048;
													double num18 = (double)width3 - num3;
													double num19 = num12 - num18;
													bool flag9 = num19 < 0.0;
													object obj22 = num12 ^ num18;
													object obj23 = num12 ^ num19;
													object obj24 = obj22 & obj23;
													bool flag10 = (nint)obj24 < 0;
													bool flag11 = flag9 == flag10;
													object obj25 = !flag11;
													object obj26 = ~obj25;
													if (obj26 == null)
													{
														num18 = num12;
													}
													bool flag12 = num12 < 0.0;
													object obj27 = num12 ^ num12;
													object obj28 = num12 & obj27;
													bool flag13 = (nint)obj28 < 0;
													bool flag14 = flag12 == flag13;
													object obj29 = !flag14;
													object obj30 = ~obj29;
													double num20 = ((obj30 != null) ? num18 : 0.0);
													AvatarCropperUI avatarCropperUI = (AvatarCropperUI)sourceTex.height;
													double num21 = (double)avatarCropperUI - num5;
													double num22 = num17 - num21;
													bool flag15 = num22 < 0.0;
													object obj31 = num17 ^ num21;
													object obj32 = num17 ^ num22;
													object obj33 = obj31 & obj32;
													bool flag16 = (nint)obj33 < 0;
													bool flag17 = flag15 == flag16;
													object obj34 = !flag17;
													object obj35 = ~obj34;
													if (obj35 == null)
													{
														num21 = num17;
													}
													bool flag18 = num17 < 0.0;
													object obj36 = num17 ^ num17;
													object obj37 = num17 & obj36;
													bool flag19 = (nint)obj37 < 0;
													bool flag20 = flag18 == flag19;
													object obj38 = !flag20;
													object obj39 = ~obj38;
													num23 = ((obj39 != null) ? ((int)num21) : 0);
													Texture2D texture2D3 = avatarCropperUI.Crop(sourceTex, (int)num20, num23, (int)num3, (int)num5);
													obj40 = this + 176;
													obj40 = texture2D3;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
													object obj41 = obj40;
													if (obj40 != null)
													{
														object obj42 = obj41;
														Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ X8_v30+188] (should have been resolved before IL gen)");
														object obj43 = default(object);
														if (obj43 != null)
														{
															object obj44 = obj40;
															if (obj40 != null)
															{
																object obj45 = obj44;
																Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v778 @ X8_v32+1A8] (should have been resolved before IL gen)");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v44+18]");
																bool flag21 = (nint)0 < (nint)1;
																object obj46 = !flag21;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v44+18]");
																object obj47 = -1;
																bool flag22 = obj47 == null;
																object obj48 = ~obj46;
																object obj49 = obj48 | flag22;
																if (obj49 == null)
																{
																	_ = cropSize;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v44+20]");
																	num24 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v44+18]");
																	bool flag23 = (nint)0 < (nint)2;
																	int num25 = 2139095040;
																	if (!flag23)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v44+18]");
																		object obj50 = (nint)0 & (nint)0x7FFFFFFF;
																		object obj51 = obj50 - 1;
																		bool flag24 = (nint)obj51 < 8;
																		object obj52 = !flag24;
																		object obj53;
																		int num26;
																		object obj54;
																		object obj55;
																		int num27;
																		if (obj52 == null)
																		{
																			obj53 = obj15;
																			num26 = 2139095040;
																			obj54 = obj14;
																			obj55 = 1;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v44+20]");
																			num27 = 0;
																		}
																		else
																		{
																			object obj56 = obj51 & -8;
																			obj55 = obj56 | 1;
																			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																			object obj57 = obj43 + 52;
																			object obj58 = obj56;
																			object obj59 = default(object);
																			obj58 = obj59;
																			object obj60 = default(object);
																			obj57 = obj60;
																			do
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X12_v6-10]");
																				obj54 = 0;
																				obj53 = obj57;
																				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMIN not yet implemented.\"");
																				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMIN not yet implemented.\"");
																				obj57 += 32;
																				obj58 -= 8;
																			}
																			while ((nint)obj58 != 8);
																			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMIN not yet implemented.\"");
																			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
																			bool flag25 = obj51 == obj56;
																			num26 = height2;
																			num27 = height2;
																			obj15 = obj57;
																			num25 = height2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X12_v6-10]");
																			obj14 = 0;
																			num24 = height2;
																			if (flag25)
																			{
																				goto IL_0a8d;
																			}
																		}
																		object obj61 = obj50 - obj55;
																		object obj62 = obj43 + obj55;
																		object obj63 = obj62 + 32;
																		bool flag29;
																		do
																		{
																			obj63 += 4;
																			object obj64 = obj63 - num27;
																			bool flag26 = (nint)obj64 < 0;
																			int num28 = obj63 ^ num27;
																			int num29 = obj63 ^ obj64;
																			int num30 = num28 & num29;
																			bool flag27 = num30 < 0;
																			bool flag28 = flag26 == flag27;
																			object obj65 = !flag28;
																			object obj66 = ~obj65;
																			if (obj66 == null)
																			{
																				num27 = (int)obj63;
																			}
																			obj61--;
																			flag29 = (nint)obj61 != 1;
																			obj15 = obj53;
																			num25 = num26;
																			obj14 = obj54;
																			num24 = num27;
																		}
																		while (flag29);
																	}
																	goto IL_0a8d;
																}
																goto IL_0e39;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0e2b;
		IL_0184:
		if ((object)saveButton != null)
		{
			saveButton.enabled = false;
			object obj67 = this + 192;
			object obj68 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v5+E4]");
			object obj71;
			object obj70;
			if ((nint)0 != 0)
			{
				bool flag30 = (UnityEngine.Object)obj67 != null;
				bool flag31 = !flag30;
				object obj69 = !flag31;
				obj70 = 0;
				obj71 = 0;
				if (obj69 == null)
				{
					goto IL_0230;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag32 = (UnityEngine.Object)obj67 != null;
				bool flag33 = !flag32;
				obj70 = 0;
				obj71 = 0;
				if (flag33)
				{
					goto IL_0230;
				}
			}
			AssignSourceTex();
			_cameraTexture = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			graphic = userImage;
			bool flag34 = (object)userImage == null;
			obj70 = obj71;
			if (!flag34)
			{
				goto IL_02ff;
			}
		}
		goto IL_0e2b;
		IL_0d74:
		object obj72 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj73 = (nint)0 + (nint)2064;
		int num31 = 100;
		Action<object> action = default(Action<object>);
		while (true)
		{
			byte[] array = ImageConversion.EncodeToJPG((Texture2D)obj40, num31);
			if (array == null)
			{
				break;
			}
			bool flag35 = num31 < 16;
			object obj74 = !flag35;
			object obj75 = ~obj74;
			if (obj75 == null)
			{
				num31 -= 5;
				if (array.Length > 102400)
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor((object)this, (IntPtr)obj73);
			KammelnaRequests.UpdateAvatar(array, action);
			return;
		}
		goto IL_0e2b;
		IL_0a8d:
		Texture2D texture2D4 = Resize(destTex, num24, num24);
		destTex = texture2D4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((object)userImage != null)
		{
			Transform transform = userImage.transform;
			if ((object)transform != null)
			{
				Transform parent = transform.parent;
				if ((object)parent != null)
				{
					Vector3 eulerAngles = parent.eulerAngles;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					object obj76 = obj16;
					double num32 = num16 / 1119092736.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X0_v58+E4]");
					bool flag36 = (nint)0 == 0;
					object obj77 = !flag36;
					if (obj77 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
					double num33 = num32 + -0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					double num35 = default(double);
					double num34 = num35 + -1.0;
					object obj78 = num35 & 1;
					bool flag37 = obj78 == null;
					object obj79 = !flag37;
					if (obj79 == null)
					{
						num34 = num35;
					}
					double num36 = num32 - -0.5;
					bool flag38 = num36 == 0.0;
					object obj80 = !flag38;
					object obj81 = ~obj80;
					double num37 = ((obj81 != null) ? num34 : num33);
					double num38 = num32 + 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					double num39 = num35 + 1.0;
					object obj82 = num35 & 1;
					bool flag39 = obj82 == null;
					object obj83 = !flag39;
					double num40 = ((obj83 != null) ? num39 : num35);
					double num41 = num32 - 0.5;
					bool flag40 = num41 == 0.0;
					object obj84 = !flag40;
					object obj85 = ~obj84;
					double num42 = ((obj85 != null) ? num40 : num38);
					bool flag41 = num32 < 0.0;
					object obj86 = num32 ^ num32;
					object obj87 = num32 & obj86;
					bool flag42 = (nint)obj87 < 0;
					bool flag43 = flag41 == flag42;
					object obj88 = !flag43;
					object obj89 = ~obj88;
					if (obj89 == null)
					{
						num42 = num37;
					}
					double num43 = ((num42 != 9.218868437227405E+18) ? num42 : 2147483648.0);
					bool flag44 = num43 == 0.0;
					int num44 = (int)num3;
					bool flag45 = (byte)num23 != 0;
					if (flag44)
					{
						goto IL_0d74;
					}
					if (obj40 != null)
					{
						Color[] pixels = ((Texture2D)obj40).GetPixels();
						bool flag46 = num43 < 0.0;
						bool flag47 = num43 == 0.0;
						object obj90 = num43 ^ num43;
						object obj91 = num43 & obj90;
						bool flag48 = (nint)obj91 < 0;
						bool flag49 = flag46 == flag48;
						object obj92 = !flag47;
						bool flag50 = (byte)((flag49 & obj92) ? 1 : 0) != 0;
						Color[] pixels2 = RotatePixels(pixels, num24, num24, flag50, (int)num43);
						if (obj40 != null)
						{
							((Texture2D)obj40).SetPixels(pixels2);
							if (obj40 != null)
							{
								((Texture2D)obj40).Apply();
								num44 = (int)num43;
								flag45 = flag50;
								goto IL_0d74;
							}
						}
					}
				}
			}
		}
		goto IL_0e2b;
	}

	private Texture2D Crop(Texture2D source, int x, int y, int width, int height)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if ((object)source != null)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
			Color[] pixels = source.GetPixels(x, y, width, height);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Texture2D texture2D = default(Texture2D);
			texture2D..ctor(width, height);
			if ((object)texture2D != null)
			{
				texture2D.SetPixels(pixels);
				texture2D.Apply();
				return texture2D;
			}
		}
		return (Texture2D)(object)new NullReferenceException();
	}

	public void OpenCamera()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		loadingBlocker.PopFromCenter();
		RegisterEvents();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			KMediaPicker.OpenCamera();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KMediaPicker.OpenCamera();
	}

	public void OpenGallery()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		loadingBlocker.PopFromCenter();
		RegisterEvents();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			KMediaPicker.PickFromGallery();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KMediaPicker.PickFromGallery();
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_00db: Expected I, but got O
		//IL_0105: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0094: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3688;
		object obj2 = (nint)0 + (nint)2080;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4032;
		object obj5 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KMediaPicker.OnSelectFromNativeCamera += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		KMediaPicker.OnSelectFromNativeGallery += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj5);
		KMediaPicker.OnWebCamFeedReady += action3;
	}

	private void UnregisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_00db: Expected I, but got O
		//IL_0105: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0094: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3688;
		object obj2 = (nint)0 + (nint)2080;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4032;
		object obj5 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KMediaPicker.OnSelectFromNativeCamera -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		KMediaPicker.OnSelectFromNativeGallery -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj5);
		KMediaPicker.OnWebCamFeedReady -= action3;
	}

	private static Color[] RotatePixels(Color[] pix, int w, int h, bool clockwise, int count)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02bb: Expected O, but got I4
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_04b7: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0341: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_036e: Expected O, but got I4
		//IL_0377: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_05b2: Expected O, but got I4
		//IL_0541: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1976;
		int length = h * w;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		Array.Copy(pix, array, length);
		if (count >= 1)
		{
			if (w > 0)
			{
				if (h > 0)
				{
					if (pix != null)
					{
						if (array != null)
						{
							object obj2 = pix + 32;
							object obj3 = array + 32;
							if (clockwise)
							{
								object obj4 = h - 1;
								object obj5 = 0;
								while (true)
								{
									if (obj5 != null)
									{
										Array.Copy(array, pix, length);
									}
									object obj6 = obj4;
									object obj7 = 0;
									object obj8 = 0;
									while (true)
									{
										object obj9 = obj7 << 32;
										int num = h;
										object obj10 = obj7;
										object obj11 = obj6;
										while (true)
										{
											bool flag = (nint)obj10 < pix.Length;
											object obj12 = !flag;
											if (obj12 != null)
											{
												break;
											}
											object obj13 = obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Array)+18]");
											bool flag2 = (nint)obj13 < 0;
											object obj14 = !flag2;
											if (obj14 != null)
											{
												break;
											}
											object obj15 = obj9 >> 28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X26_v5+v116 @ X16_v13]");
											_ = 0;
											obj11 += h;
											obj9 += 4294967296L;
											obj10++;
											num--;
											if (num != 1)
											{
												continue;
											}
											goto IL_01c4;
										}
										break;
										IL_01c4:
										obj8++;
										obj6--;
										obj7 += w;
										if ((nint)obj8 != w)
										{
											continue;
										}
										goto IL_020c;
									}
									break;
									IL_020c:
									obj5++;
									if ((nint)obj5 != count)
									{
										continue;
									}
									goto IL_0496;
								}
							}
							else
							{
								object obj16 = w - 1;
								object obj17 = h * obj16;
								object obj18 = 0;
								while (true)
								{
									if (obj18 != null)
									{
										Array.Copy(array, pix, length);
									}
									object obj19 = obj17;
									object obj20 = 0;
									object obj21 = 0;
									while (true)
									{
										object obj22 = obj20 << 32;
										int num2 = h;
										object obj23 = obj20;
										object obj24 = obj19;
										while (true)
										{
											bool flag3 = (nint)obj23 < pix.Length;
											object obj25 = !flag3;
											if (obj25 != null)
											{
												break;
											}
											object obj26 = obj24;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Array)+18]");
											bool flag4 = (nint)obj26 < 0;
											object obj27 = !flag4;
											if (obj27 != null)
											{
												break;
											}
											object obj28 = obj22 >> 28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X26_v5+v114 @ X16_v8]");
											_ = 0;
											obj24 -= h;
											obj22 += 4294967296L;
											obj23++;
											num2--;
											if (num2 != 1)
											{
												continue;
											}
											goto IL_0421;
										}
										break;
										IL_0421:
										obj21++;
										obj19++;
										obj20 += w;
										if ((nint)obj21 != w)
										{
											continue;
										}
										goto IL_0469;
									}
									break;
									IL_0469:
									obj18++;
									if ((nint)obj18 != count)
									{
										continue;
									}
									goto IL_0496;
								}
							}
						}
						else
						{
							bool flag5 = pix.Length == 0;
							object obj29 = !flag5;
							if (obj29 != null)
							{
								goto IL_04d3;
							}
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
					}
					goto IL_04d3;
				}
				object obj30 = count - 1;
				if (count != 1)
				{
					do
					{
						Array.Copy(array, pix, length);
						obj30--;
					}
					while ((nint)obj30 != 1);
				}
			}
			else
			{
				object obj31 = count - 1;
				if (count != 1)
				{
					do
					{
						Array.Copy(array, pix, length);
						obj31--;
					}
					while ((nint)obj31 != 1);
				}
			}
		}
		goto IL_0496;
		IL_0496:
		return (Color[])array;
		IL_04d3:
		return (Color[])(object)new NullReferenceException();
	}

	public static Texture2D Resize(Texture2D source, int newWidth, int newHeight)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		//IL_0133: Expected O, but got I4
		if ((object)source != null)
		{
			source.filterMode = FilterMode.Point;
			RenderTexture temporary = RenderTexture.GetTemporary(newWidth, newHeight);
			if ((object)temporary != null)
			{
				object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3304;
				object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
				temporary.filterMode = FilterMode.Point;
				RenderTexture.active = temporary;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Graphics.Blit(source, temporary);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Texture2D texture2D = default(Texture2D);
				texture2D..ctor(newWidth, newHeight);
				if ((object)texture2D != null)
				{
					texture2D.ReadPixels((Rect)0, 0, 0);
					texture2D.Apply();
					RenderTexture.active = null;
					return texture2D;
				}
			}
		}
		return (Texture2D)(object)new NullReferenceException();
	}

	public void RotatePicture()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_00a0: Expected O, but got I
		//IL_00c6: Expected O, but got I4
		Transform transform = userImage.transform;
		Transform parent = transform.parent;
		int num = ShortcutExtensions.DOKill(parent, complete: true);
		RectTransform rectTransform = userImage.rectTransform;
		Vector3 eulerAngles = rectTransform.eulerAngles;
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+48]");
		object obj4 = (nint)0 * (nint)1119092736;
		object obj5 = default(object);
		float duration = (float)obj5 + (float)obj4;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DORotate(parent, (Vector3)0, duration);
	}

	public void OnPinch(PinchGesture pinchGesture)
	{
		//IL_00c9: Invalid comparison between F8 and I4
		//IL_00d8: Invalid comparison between F8 and I4
		//IL_00eb: Expected O, but got F8
		//IL_00f8: Expected O, but got F8
		//IL_012d: Expected O, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0188: Expected O, but got I4
		RawImage rawImage = userImage;
		rawImage.raycastTarget = false;
		RectTransform rectTransform = userImage.rectTransform;
		Vector3 localScale = rectTransform.localScale;
		RectTransform rectTransform2 = userImage.rectTransform;
		object obj = default(object);
		float num = (float)obj * pinchGesture.DeltaScale;
		double num2 = (double)ratio * 0.5;
		double num3 = (double)ratio * 5.0;
		double num4 = num3 + 1.0;
		double num5 = (double)num - num4;
		bool flag = num5 < 0.0;
		bool flag2 = num5 == 0.0;
		object obj2 = (double)num ^ num4;
		object obj3 = (double)num ^ num5;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		if ((double)num < num2)
		{
		}
		rectTransform2.localScale = (Vector3)0;
	}

	public void OnPinchEnd(PinchGesture pinchGesture)
	{
		userImage.raycastTarget = true;
		OnScrollEnd();
	}

	private void OnScrollWheel(PointerEventData ped)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I
		//IL_0116: Expected O, but got I4
		//IL_0080: Invalid comparison between F8 and I4
		//IL_00c3: Expected O, but got I4
		RectTransform rectTransform = userImage.rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ped @ X1 (UnityEngine.EventSystems.PointerEventData)+180]");
		double num = 0.0 * 0.125;
		Vector3 localScale = rectTransform.localScale;
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v4+B8]");
		object obj3 = 0;
		double num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+C]");
		double num3 = num2 * 0.0;
		double num4 = 0.125 + num3;
		rectTransform.localScale = (Vector3)0;
		RectTransform rectTransform2 = userImage.rectTransform;
		Vector3 localScale2 = rectTransform2.localScale;
		if (num4 < 1050253722.0)
		{
			RectTransform rectTransform3 = userImage.rectTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			rectTransform3.localScale = (Vector3)0;
		}
	}

	private void OnScrollEnd()
	{
		//IL_0077: Invalid comparison between F8 and I4
		//IL_0086: Invalid comparison between F8 and I4
		//IL_0099: Expected O, but got F8
		//IL_00a6: Expected O, but got F8
		//IL_00db: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		RectTransform rectTransform = userImage.rectTransform;
		RectTransform rectTransform2 = userImage.rectTransform;
		Vector3 localScale = rectTransform2.localScale;
		double num = (double)ratio * 3.0;
		double num2 = num + 1.0;
		double num4 = default(double);
		double num3 = num4 - num2;
		bool flag = num3 < 0.0;
		bool flag2 = num3 == 0.0;
		object obj = num4 ^ num2;
		object obj2 = num4 ^ num3;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			num2 = num4;
		}
		float endValue = ((!(num4 < (double)ratio)) ? ((float)num2) : ratio);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rectTransform, endValue, 0.2f);
	}

	private void <CropAndSubmit>b__19_0(KammelnaResponseModel<bool> response)
	{
		//IL_003d: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		Close();
		if (!response.Succeeded)
		{
			object obj = (nint)0 + (nint)1024;
			string errorMessage = response.ErrorMessage;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.ShowError(errorMessage);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowError(errorMessage);
		}
	}
}
