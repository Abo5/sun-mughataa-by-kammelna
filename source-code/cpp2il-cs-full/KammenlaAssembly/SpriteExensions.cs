using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public static class SpriteExensions
{
	public static void SetAtlasRectInfo(SpriteRenderer renderer, bool isSharedMaterial = true, string materialProperty = "_TextureRect")
	{
		//IL_0010: Expected O, but got I
		//IL_02c3: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_0043: Expected O, but got I4
		//IL_0192: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_0155: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E7F]");
		object obj = 0;
		bool flag = (object)renderer == null;
		bool flag2 = isSharedMaterial;
		object obj2 = 152981504;
		object obj3 = default(object);
		object obj5 = default(object);
		object obj7 = default(object);
		object obj9 = default(object);
		bool flag6;
		Renderer renderer2;
		object obj11;
		object obj12;
		object obj13;
		object obj14;
		Renderer renderer3;
		object obj15;
		object obj16;
		NullReferenceException ex;
		if (!flag)
		{
			Sprite sprite = renderer.sprite;
			bool flag3 = (object)sprite == null;
			flag2 = false;
			obj2 = 152981504;
			if (!flag3)
			{
				obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				Rect textureRect = sprite.textureRect;
				ex = (NullReferenceException)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.NullReferenceException)+E4]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.NullReferenceException)+E4]");
				bool flag4 = (nint)0 == 0;
				object obj4 = default(object);
				obj3 = obj4;
				object obj6 = default(object);
				obj5 = obj6;
				object obj8 = default(object);
				obj7 = obj8;
				object obj10 = default(object);
				obj9 = obj10;
				flag2 = false;
				if (flag4)
				{
					goto IL_01b6;
				}
				bool flag5 = !isSharedMaterial;
				obj3 = obj4;
				obj5 = obj6;
				obj7 = obj8;
				obj9 = obj10;
				flag6 = false;
				renderer2 = renderer;
				obj11 = obj4;
				obj12 = obj6;
				obj13 = obj8;
				obj14 = obj10;
				flag2 = false;
				renderer3 = renderer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5 (System.NullReferenceException)+E4]");
				obj15 = 0;
				obj16 = obj2;
				if (!flag5)
				{
					goto IL_016b;
				}
				goto IL_0236;
			}
		}
		goto IL_01a8;
		IL_01b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = !isSharedMaterial;
		object obj17 = !flag7;
		flag6 = false;
		renderer2 = renderer;
		obj11 = obj3;
		obj12 = obj5;
		obj13 = obj7;
		obj14 = obj9;
		flag2 = false;
		renderer3 = renderer;
		obj15 = obj;
		obj16 = obj2;
		if (obj17 != null)
		{
			goto IL_016b;
		}
		goto IL_0236;
		IL_0236:
		Material material = renderer3.material;
		bool flag8 = (object)material == null;
		obj3 = obj11;
		obj5 = obj12;
		obj7 = obj13;
		obj9 = obj14;
		obj = obj15;
		obj2 = obj16;
		if (flag8)
		{
			goto IL_01a8;
		}
		goto IL_0290;
		IL_0290:
		material.SetVector(materialProperty, (Vector4)0);
		return;
		IL_016b:
		material = renderer2.sharedMaterial;
		bool flag9 = (object)material == null;
		object obj18 = !flag9;
		flag2 = flag6;
		if (obj18 == null)
		{
			goto IL_01a8;
		}
		goto IL_0290;
		IL_01a8:
		ex = new NullReferenceException();
		goto IL_01b6;
	}

	public static void SetAtlasRectInfo(Image renderer, string materialProperty = "_TextureRect")
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0055: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect textureRect = renderer.m_Sprite.textureRect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Material material = renderer.material;
		material.SetVector(materialProperty, (Vector4)0);
	}

	private static void ModifySortLayer(SpriteRenderer renderer, int orderId, string layerName)
	{
		int sortingLayerID = SortingLayer.NameToID(layerName);
		renderer.sortingLayerID = sortingLayerID;
		renderer.sortingOrder = orderId;
	}

	private static void ModifySortLayer(SpriteRenderer renderer, int orderId, int layerId)
	{
		renderer.sortingLayerID = layerId;
		renderer.sortingOrder = orderId;
	}

	public static Sprite[] CreateSprites(Texture2D texture, Vector2Int gridSize)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003b: Expected I4, but got O
		//IL_0047: Expected O, but got I
		//IL_005c: Expected I, but got O
		//IL_0093: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected I4, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0154: Expected O, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f8: Expected O, but got I
		//IL_0209: Expected O, but got I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_053b: Expected O, but got I
		//IL_0555: Expected O, but got I4
		//IL_0363: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_0389: Expected O, but got I
		//IL_03a3: Expected O, but got I4
		//IL_03b3: Expected O, but got I
		//IL_032e: Expected O, but got I
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0675: Expected O, but got I4
		//IL_0675: Expected O, but got I4
		//IL_0581: Expected O, but got I
		//IL_0591: Expected O, but got I
		//IL_05a7: Expected O, but got I
		//IL_05d4: Expected O, but got I
		//IL_044b: Expected O, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0286: Expected I, but got O
		//IL_0298: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_018a: Invalid comparison between F4 and I4
		//IL_01a5: Expected O, but got I4
		//IL_0472: Expected O, but got I
		//IL_0482: Expected O, but got I
		//IL_0492: Expected O, but got I
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04d0: Expected O, but got I4
		List<object> list = default(List<object>);
		if ((object)texture != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3456;
			int num = (object)gridSize >> 32;
			object obj3 = (nint)0 + (nint)2120;
			int width = texture.width;
			nint num2 = (nint)texture;
			int height = texture.height;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = obj3;
			list..ctor();
			float num3 = (float)num - 1f;
			if (num >= 1 && (nint)gridSize >= 1)
			{
				int num4 = (int)(width / gridSize);
				object obj7 = typeof(UsageHint) + 744;
				int num5 = height / num;
				object obj8 = (nint)0 + (nint)2136;
				int num6 = num;
				int num7 = height;
				Vector2Int vector2Int = gridSize;
				nint num8 = default(nint);
				SpriteMeshType meshType = default(SpriteMeshType);
				Vector4 border = default(Vector4);
				object obj32 = default(object);
				while (true)
				{
					Vector2Int vector2Int2 = (Vector2Int)(num5 * num3);
					Vector2 vector = (Vector2)num8;
					float num9 = num3;
					object obj9 = 0;
					Sprite sprite;
					uint num10;
					object obj30;
					object obj31;
					while (true)
					{
						object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v17+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BE]");
							object obj12 = (nint)0 & (nint)1;
							if (obj12 != null)
							{
								goto IL_034b;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BE]");
							object obj13 = (nint)0 & (nint)1;
							bool flag2 = obj13 == null;
							object obj14 = !flag2;
							if (obj14 != null)
							{
								goto IL_034b;
							}
						}
						_ = 1;
						object obj15 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v26+B8]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v27+8]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BD]");
						object obj18 = (nint)0 & (nint)1;
						if (obj18 == null)
						{
							goto IL_03c1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v27+8]");
						object obj19 = 0;
						goto IL_0634;
						IL_034b:
						object obj20 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v32+B8]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v33+8]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BD]");
						object obj22 = (nint)0 & (nint)1;
						bool flag3 = obj22 == null;
						object obj23 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v33+8]");
						obj19 = 0;
						if (obj23 == null)
						{
							goto IL_03c1;
						}
						goto IL_0634;
						IL_03c1:
						_ = 1;
						obj19 = obj17;
						goto IL_0634;
						IL_0634:
						num9 = (float)num4 * (float)obj9;
						object obj24 = obj19 * 63;
						sprite = Sprite.Create(texture, (Rect)1, (Vector2)0, num9, 0u, meshType, border);
						if (list == null)
						{
							break;
						}
						object obj25 = obj8;
						int version = list._version + 1;
						list._version = version;
						object[] items = list._items;
						if (list._items == null)
						{
							break;
						}
						bool flag4 = list._size < items.Length;
						object obj26 = !flag4;
						object obj27 = ~obj26;
						if (obj27 != null)
						{
							int size = list._size + 1;
							list._size = size;
							object obj28 = list._items + list._size;
							object obj29 = obj28 + 32;
							obj29 = sprite;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj9++;
							bool flag5 = (object)gridSize == obj9;
							num8 = unchecked((nint)null);
							num10 = 0u;
							obj30 = 1120403456;
							obj31 = obj32;
							vector = (Vector2)0;
							num6 = num5;
							num7 = num4;
							vector2Int = vector2Int2;
							obj6 = sprite;
							if (!flag5)
							{
								continue;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v19+20]");
							object obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v20+C0]");
							object obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v21+70]");
							vector = (Vector2)0;
							list.AddWithResize((object)sprite);
							obj9++;
							bool flag6 = (object)gridSize != obj9;
							num10 = 0u;
							obj30 = 1120403456;
							obj31 = obj32;
							num6 = num5;
							num7 = num4;
							vector2Int = vector2Int2;
							obj6 = sprite;
							if (flag6)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v21+70]");
							num8 = 0;
						}
						goto IL_0171;
					}
					break;
					IL_0171:
					float num11 = num3 - 1f;
					bool flag7 = !(num3 > 0f);
					num10 = 0u;
					obj30 = 1120403456;
					obj31 = obj32;
					num6 = num5;
					num7 = num4;
					vector2Int = vector2Int2;
					obj6 = sprite;
					num3 = num11;
					if (!flag7)
					{
						continue;
					}
					goto IL_05f6;
				}
			}
			else if (list != null)
			{
				goto IL_05f6;
			}
		}
		return (Sprite[])(object)new NullReferenceException();
		IL_05f6:
		return (Sprite[])list.ToArray();
	}
}
