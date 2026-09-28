using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class TextMeshAnimator : MonoBehaviour
{
	public TextMeshProUGUI text;

	public float speed = 0f;

	public float scale;

	private void Start()
	{
	}

	private void Update()
	{
		//IL_0017: Expected I, but got O
		//IL_0068: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_025d: Expected O, but got I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0399: Expected O, but got I
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0414: Expected O, but got F4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_043d: Expected O, but got I4
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_04a5: Expected O, but got I
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_054e: Expected O, but got I4
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_05b6: Expected O, but got I
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_0651: Expected O, but got I4
		//IL_010c: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0203: Expected O, but got I4
		//IL_0231: Expected O, but got I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0331: Expected O, but got I4
		TextMeshProUGUI textMeshProUGUI = text;
		nint num = (nint)textMeshProUGUI;
		textMeshProUGUI.ForceMeshUpdate();
		Mesh mesh = text.mesh;
		float time = Time.time;
		Vector3[] vertices = mesh.vertices;
		object obj = vertices.Length;
		if (vertices.Length >= 4)
		{
			object obj2 = vertices + 40;
			object obj3 = typeof(UsageHint) + 816;
			object obj4 = 3;
			object obj5 = 0;
			object obj12 = default(object);
			object obj14 = default(object);
			while (true)
			{
				object obj6 = obj4 - 3;
				bool flag = obj6 < obj;
				object obj7 = !flag;
				if (obj7 == null)
				{
					float time2 = Time.time;
					object obj8 = obj4 - 3;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					float num2 = time2 * speed;
					float num3 = (float)obj8 + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB2164");
					object obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v13+B8]");
					object obj10 = 0;
					float num4 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v14+44]");
					float num5 = num4 * 0f;
					float num6 = num5 * scale;
					float num7 = (float)obj2 + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v14+3C]");
					object obj11 = 0 * obj12;
					object obj13 = obj11 * obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v5-8]");
					object obj15 = 0 + obj13;
					obj2 = num7;
					object obj16 = obj4 - 2;
					bool flag2 = (nint)obj16 < vertices.Length;
					object obj17 = !flag2;
					if (obj17 == null)
					{
						float time3 = Time.time;
						object obj18 = obj4 - 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						float num8 = time3 * speed;
						float num9 = (float)obj18 + num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB2164");
						object obj19 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v18+B8]");
						object obj20 = 0;
						float num10 = num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v19+44]");
						float num11 = num10 * 0f;
						float num12 = num11 * scale;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v5+C]");
						float num13 = 0f + num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v19+3C]");
						object obj21 = 0 * obj12;
						object obj22 = obj21 * obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v5+4]");
						object obj23 = 0 + obj22;
						object obj24 = obj4 - 1;
						bool flag3 = (nint)obj24 < vertices.Length;
						object obj25 = !flag3;
						if (obj25 == null)
						{
							float time4 = Time.time;
							object obj26 = obj4 - 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
							float num14 = time4 * speed;
							float num15 = (float)obj26 + num14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB2164");
							object obj27 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v23+B8]");
							object obj28 = 0;
							float num16 = num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v24+44]");
							float num17 = num16 * 0f;
							float num18 = num17 * scale;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v5+18]");
							float num19 = 0f + num18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v24+3C]");
							object obj29 = 0 * obj12;
							object obj30 = obj29 * obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v5+10]");
							object obj31 = 0 + obj30;
							bool flag4 = (nint)obj4 < vertices.Length;
							object obj32 = !flag4;
							if (obj32 == null)
							{
								float time5 = Time.time;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
								float num20 = time5 * speed;
								float num21 = (float)obj4 + num20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB2164");
								object obj33 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v27+B8]");
								object obj34 = 0;
								float num22 = num21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v28+44]");
								float num23 = num22 * 0f;
								float num24 = num23 * scale;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v5+24]");
								float num25 = 0f + num24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v28+3C]");
								object obj35 = 0 * obj12;
								object obj36 = obj35 * obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v5+1C]");
								object obj37 = 0 + obj36;
								obj5++;
								object obj38 = vertices.Length + 3;
								bool flag5 = vertices.Length < 0;
								object obj39 = vertices.Length ^ vertices.Length;
								object obj40 = vertices.Length & obj39;
								bool flag6 = (nint)obj40 < 0;
								bool flag7 = flag5 == flag6;
								object obj41 = !flag7;
								object obj42 = ~obj41;
								object obj43 = ((obj42 != null) ? ((object)vertices.Length) : obj38);
								object obj44 = obj43 >> 2;
								obj2 += 48;
								obj4 += 4;
								bool flag8 = obj5 >= obj44;
								obj = vertices.Length;
								if (flag8)
								{
									break;
								}
								continue;
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
		}
		mesh.vertices = vertices;
		CanvasRenderer canvasRenderer = text.canvasRenderer;
		canvasRenderer.SetMesh(mesh);
	}

	private Vector3 GetImpact(int index)
	{
		float time = Time.time;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num = time * speed;
		float num2 = (float)index + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB2164");
		Vector3 result = default(Vector3);
		return result;
	}
}
