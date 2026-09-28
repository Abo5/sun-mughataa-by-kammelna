using System;
using System.Buffers.Text;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class RenderTextureInputMapper : MonoBehaviour
{
	private RawImage _rawImage;

	private RenderTexture _renderTexture;

	private static RenderTextureInputMapper _active;

	public static RenderTextureInputMapper Active
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 456;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (RenderTextureInputMapper)0;
		}
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 456;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnDisable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 456;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73FE]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v11+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj9 = (UnityEngine.Object)obj6;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			obj9 = (UnityEngine.Object)obj11;
			if (obj12 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9 == this;
		bool flag4 = !flag3;
		object obj13 = !flag4;
		object obj14 = 0;
		if (obj13 == null)
		{
			return;
		}
		goto IL_00e9;
		IL_00e9:
		object obj15 = obj2;
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00b9:
		bool flag5 = obj7 == this;
		bool flag6 = !flag5;
		obj14 = 0;
		if (!flag6)
		{
			goto IL_00e9;
		}
	}

	public unsafe bool TryMapScreenPointToRenderTexturePoint(Vector3 screenPoint, out Vector3 renderTexturePoint)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_067a: Expected native int or pointer, but got O
		//IL_0687: Expected native int or pointer, but got O
		//IL_0694: Expected native int or pointer, but got O
		//IL_0092: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_0041: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_0103: Expected O, but got I4
		//IL_0672: Expected I4, but got O
		//IL_0239: Expected O, but got I4
		//IL_0242: Expected O, but got I4
		//IL_01ec: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0372: Expected O, but got I4
		//IL_06d8: Expected O, but got Ref
		//IL_02d2: Expected O, but got I4
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0425: Expected O, but got I4
		//IL_0721: Invalid comparison between F4 and I4
		//IL_0732: Expected O, but got I4
		//IL_0762: Expected O, but got I4
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_045f: Invalid comparison between F8 and I4
		//IL_046e: Invalid comparison between F8 and I4
		//IL_0486: Expected O, but got F8
		//IL_0493: Expected O, but got F8
		//IL_04fb: Invalid comparison between F4 and I4
		//IL_050c: Expected O, but got I4
		//IL_079f: Expected O, but got I4
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_0540: Invalid comparison between F8 and I4
		//IL_054f: Invalid comparison between F8 and I4
		//IL_0567: Expected O, but got F8
		//IL_0574: Expected O, but got F8
		//IL_0637: Expected native int or pointer, but got O
		//IL_0644: Expected native int or pointer, but got O
		//IL_0651: Expected native int or pointer, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		float num = default(float);
		((Vector3*)(nint)screenPoint)->x = num;
		float num2 = default(float);
		((Vector3*)(nint)screenPoint)->y = num2;
		float num3 = default(float);
		((Vector3*)(nint)screenPoint)->z = num3;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool flag = _rawImage == null;
			bool flag2 = !flag;
			object obj3 = 0;
			UnityEngine.Object obj4 = null;
			if (flag2)
			{
				goto IL_00ae;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = _rawImage == null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			object obj3 = 0;
			UnityEngine.Object obj4 = null;
			if (obj5 == null)
			{
				goto IL_00ae;
			}
		}
		goto IL_0111;
		IL_0664:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0327:
		Graphic rawImage;
		RectTransform rectTransform = rawImage.rectTransform;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3608;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 screenPoint2;
		object obj9 = default(object);
		bool flag6 = RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, screenPoint2, (Camera)(&obj9), out *(Vector2*)null);
		if (flag6)
		{
			if ((object)_rawImage != null)
			{
				RectTransform rectTransform2 = _rawImage.rectTransform;
				if ((object)rectTransform2 != null)
				{
					Rect rect = rectTransform2.rect;
					object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v21+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num4 = (float)obj9 - num;
					float num5 = num4 / num3;
					bool flag8 = num5 < 0f;
					object obj13 = !flag8;
					object obj14 = ~obj13;
					bool flag9;
					bool flag10;
					bool flag11;
					if (obj14 == null)
					{
						double num6 = (double)num5 - 1.0;
						flag9 = num6 < 0.0;
						flag10 = num6 == 0.0;
						object obj15 = (double)num5 ^ 1.0;
						object obj16 = (double)num5 ^ num6;
						object obj17 = obj15 & obj16;
						flag11 = (nint)obj17 < 0;
					}
					else
					{
						flag11 = false;
						flag10 = false;
						flag9 = false;
					}
					bool flag12 = flag9 == flag11;
					object obj18 = !flag10;
					object obj19 = flag12 & obj18;
					flag6 = false;
					if (obj19 == null)
					{
						object obj20 = default(object);
						float num7 = (float)obj20 - num2;
						object obj21 = default(object);
						float num8 = num7 / (float)obj21;
						bool flag13 = num8 < 0f;
						object obj22 = !flag13;
						object obj23 = ~obj22;
						bool flag14;
						bool flag15;
						bool flag16;
						if (obj23 == null)
						{
							double num9 = (double)num8 - 1.0;
							flag14 = num9 < 0.0;
							flag15 = num9 == 0.0;
							object obj24 = (double)num8 ^ 1.0;
							object obj25 = (double)num8 ^ num9;
							object obj26 = obj24 & obj25;
							flag16 = (nint)obj26 < 0;
						}
						else
						{
							flag16 = false;
							flag15 = false;
							flag14 = false;
						}
						bool flag17 = flag14 == flag16;
						object obj27 = !flag15;
						object obj28 = flag17 & obj27;
						flag6 = false;
						if (obj28 == null)
						{
							if ((object)_renderTexture != null)
							{
								int width = _renderTexture.width;
								if ((object)_renderTexture != null)
								{
									int height = _renderTexture.height;
									float x = num5 * (float)width;
									float y = num8 * (float)height;
									((Vector3*)(nint)screenPoint)->x = x;
									((Vector3*)(nint)screenPoint)->y = y;
									((Vector3*)(nint)screenPoint)->z = num3;
									flag6 = true;
									goto IL_06f5;
								}
							}
							goto IL_0664;
						}
					}
					goto IL_06f5;
				}
			}
			goto IL_0664;
		}
		goto IL_06f5;
		IL_00ae:
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag18 = _renderTexture == null;
			bool flag19 = !flag18;
			object obj30 = 0;
			if (!flag19)
			{
				goto IL_0111;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag20 = _renderTexture == null;
			bool flag21 = !flag20;
			object obj31 = !flag21;
			object obj30 = 0;
			if (obj31 != null)
			{
				goto IL_0111;
			}
		}
		Canvas canvas;
		object obj34;
		if ((object)_rawImage != null)
		{
			canvas = _rawImage.canvas;
			object obj32 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				bool flag22 = canvas != null;
				bool flag23 = !flag22;
				object obj33 = 0;
				if (!flag23)
				{
					obj34 = 0;
					goto IL_0250;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag24 = canvas != null;
				bool flag25 = !flag24;
				obj34 = 0;
				object obj33 = 0;
				if (!flag25)
				{
					goto IL_0250;
				}
			}
			goto IL_02f5;
		}
		goto IL_0664;
		IL_06f5:
		return flag6;
		IL_0250:
		if ((object)canvas != null)
		{
			RenderMode renderMode = canvas.renderMode;
			bool flag26 = renderMode == RenderMode.ScreenSpaceOverlay;
			object obj33 = obj34;
			if (flag26)
			{
				goto IL_02f5;
			}
			Camera worldCamera = canvas.worldCamera;
			rawImage = _rawImage;
			bool flag27 = (object)_rawImage == null;
			object obj35 = !flag27;
			obj33 = obj34;
			screenPoint2 = (Vector2)worldCamera;
			if (obj35 != null)
			{
				goto IL_0327;
			}
		}
		goto IL_0664;
		IL_0111:
		flag6 = false;
		goto IL_06f5;
		IL_02f5:
		rawImage = _rawImage;
		bool flag28 = (object)_rawImage == null;
		screenPoint2 = (Vector2)0;
		if (!flag28)
		{
			goto IL_0327;
		}
		goto IL_0664;
	}
}
