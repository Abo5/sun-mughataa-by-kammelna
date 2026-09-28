using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;

public class WarpTextMeshPro : MonoBehaviour
{
	private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public TextMeshProUGUI textComponent;

		public WarpTextMeshPro <>4__this;

		private float <old_CurveScale>5__2;

		private AnimationCurve <old_curve>5__3;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WarpText>d__7(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_1615: Expected O, but got I4
			//IL_162f: Expected O, but got I4
			//IL_1648: Invalid comparison between F8 and I4
			//IL_0077: Expected O, but got I4
			//IL_001c: Expected I4, but got I8
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_15fb: Expected I4, but got O
			//IL_0170: Expected O, but got I
			//IL_018a: Expected O, but got I4
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected O, but got Unknown
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Expected O, but got Unknown
			//IL_168d: Invalid comparison between F8 and I4
			//IL_169c: Invalid comparison between F8 and I4
			//IL_16af: Expected O, but got F8
			//IL_16bc: Expected O, but got F8
			//IL_16f1: Expected O, but got I4
			//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16fe: Expected O, but got Unknown
			//IL_03e9: Expected I, but got O
			//IL_03f9: Expected O, but got I
			//IL_172d: Expected O, but got I
			//IL_1769: Invalid comparison between F8 and I4
			//IL_1778: Invalid comparison between F8 and I4
			//IL_178b: Expected O, but got F8
			//IL_1798: Expected O, but got F8
			//IL_17cd: Expected O, but got I4
			//IL_17d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_17da: Expected I4, but got Unknown
			//IL_17e5: Expected O, but got I4
			//IL_1816: Expected O, but got I4
			//IL_1841: Expected F8, but got I4
			//IL_023a: Expected O, but got I8
			//IL_0252: Expected F8, but got I4
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Expected O, but got Unknown
			//IL_05a5: Expected O, but got I4
			//IL_05ae: Expected O, but got I4
			//IL_05bf: Expected O, but got I4
			//IL_05cf: Expected O, but got I
			//IL_05da: Expected F8, but got I4
			//IL_05fd: Expected O, but got I4
			//IL_1556: Unknown result type (might be due to invalid IL or missing references)
			//IL_155b: Expected O, but got Unknown
			//IL_1581: Unknown result type (might be due to invalid IL or missing references)
			//IL_1586: Expected O, but got Unknown
			//IL_0810: Expected O, but got I4
			//IL_02e0: Expected O, but got I8
			//IL_02f8: Expected F8, but got I4
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Expected O, but got Unknown
			//IL_1a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a80: Expected O, but got Unknown
			//IL_1a89: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a8e: Expected O, but got Unknown
			//IL_187b: Invalid comparison between F4 and I4
			//IL_188a: Invalid comparison between F4 and I4
			//IL_189d: Expected O, but got F8
			//IL_18aa: Expected O, but got F4
			//IL_18df: Expected O, but got I4
			//IL_18e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ec: Expected O, but got Unknown
			//IL_191b: Expected O, but got I
			//IL_1957: Invalid comparison between F8 and I4
			//IL_1966: Invalid comparison between F8 and I4
			//IL_1979: Expected O, but got F8
			//IL_1986: Expected O, but got F8
			//IL_19bb: Expected O, but got I4
			//IL_19c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_19c8: Expected O, but got Unknown
			//IL_0919: Expected O, but got I4
			//IL_1a02: Expected O, but got I4
			//IL_1a1a: Invalid comparison between F8 and I4
			//IL_1a3f: Expected F8, but got I4
			//IL_099a: Expected O, but got I
			//IL_09bc: Expected O, but got I
			//IL_15c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c7: Expected O, but got Unknown
			//IL_15d0: Expected O, but got I4
			//IL_09f1: Expected O, but got I
			//IL_0a1a: Expected O, but got I4
			//IL_0a9b: Expected O, but got I
			//IL_0abc: Expected O, but got I4
			//IL_0b3d: Expected O, but got I
			//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b52: Expected O, but got Unknown
			//IL_0b81: Expected F8, but got O
			//IL_0b91: Expected F8, but got I
			//IL_0bcb: Expected O, but got F8
			//IL_0be1: Expected O, but got I
			//IL_0c02: Expected O, but got I4
			//IL_0c86: Expected O, but got F8
			//IL_0c96: Expected F8, but got I
			//IL_0cc4: Expected O, but got F8
			//IL_0cdf: Expected O, but got I
			//IL_0d00: Expected O, but got I4
			//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d61: Expected O, but got Unknown
			//IL_0d74: Expected native int or pointer, but got F8
			//IL_0d8c: Expected native int or pointer, but got F8
			//IL_0e45: Expected O, but got I
			//IL_0ff1: Expected O, but got I
			//IL_100b: Expected O, but got I4
			//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea9: Expected O, but got Unknown
			//IL_0e78: Expected O, but got I
			//IL_102e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1033: Expected O, but got Unknown
			//IL_105d: Expected O, but got I4
			//IL_0f82: Invalid comparison between F8 and I4
			//IL_109a: Expected O, but got I
			//IL_10aa: Expected F4, but got I
			//IL_10ba: Expected F8, but got I
			//IL_10c2: Expected F8, but got O
			//IL_10cb: Expected O, but got I4
			//IL_1b99: Invalid comparison between F4 and I4
			//IL_1ba8: Invalid comparison between F4 and I4
			//IL_1bbb: Expected O, but got F8
			//IL_1bc8: Expected O, but got F4
			//IL_1bfd: Expected O, but got I4
			//IL_1c05: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c0a: Expected O, but got Unknown
			//IL_0fd0: Expected O, but got I4
			//IL_1c5b: Expected O, but got I
			//IL_1cb0: Expected O, but got I4
			//IL_1cf0: Expected F8, but got I
			//IL_1d06: Expected O, but got I4
			//IL_1d16: Expected F8, but got I
			//IL_11ae: Expected O, but got F8
			//IL_11d4: Expected O, but got I4
			//IL_1222: Expected O, but got I4
			//IL_130c: Expected O, but got F8
			//IL_1332: Expected O, but got I4
			//IL_1380: Expected O, but got I4
			//IL_146a: Expected O, but got F8
			//IL_1490: Expected O, but got I4
			//IL_14e7: Expected O, but got I4
			//IL_060b: Expected native int or pointer, but got F8
			//IL_0697: Expected O, but got F8
			//IL_06c2: Expected O, but got F8
			//IL_06ed: Expected O, but got F8
			//IL_0772: Expected native int or pointer, but got F8
			//IL_078c: Expected O, but got I
			//IL_0795: Expected O, but got F8
			//IL_07a6: Expected O, but got I4
			//IL_07af: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			WarpTextMeshPro warpTextMeshPro = <>4__this;
			object obj3 = <>1__state - 1;
			bool flag = (nint)obj3 < 2;
			object obj4 = !flag;
			double num = (double)obj3 - 2.0;
			bool flag2 = num < 0.0;
			object obj5;
			<WarpText>d__7 <WarpText>d__ = default(<WarpText>d__7);
			float curveScale = default(float);
			if (obj4 == null)
			{
				<>1__state = -1;
				obj5 = this + 32;
				bool flag3 = (object)<>4__this == null;
				object obj6 = !flag3;
				<WarpText>d__ = this;
				if (obj6 != null)
				{
					goto IL_0141;
				}
			}
			else
			{
				bool flag4 = <>1__state == 0;
				object obj7 = !flag4;
				if (obj7 != null)
				{
					return false;
				}
				obj5 = this + 32;
				_ = 4294967295L;
				if (obj5 != null)
				{
					((TMP_Text)obj5).havePropertiesChanged = true;
					if ((object)<>4__this != null)
					{
						curveScale = warpTextMeshPro.curveScale;
						<old_CurveScale>5__2 = warpTextMeshPro.curveScale;
						AnimationCurve animationCurve = ((WarpTextMeshPro)obj5).CopyAnimationCurve(warpTextMeshPro.vertexCurve);
						object obj8 = this + 56;
						obj8 = animationCurve;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag5 = false;
						goto IL_0141;
					}
				}
			}
			goto IL_15ed;
			IL_0141:
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
			double num15 = default(double);
			double num16 = default(double);
			Vector3 euler = default(Vector3);
			Quaternion q = default(Quaternion);
			Vector3 s = default(Vector3);
			object obj89 = default(object);
			double num64 = default(double);
			object obj90 = default(object);
			double num67 = default(double);
			object obj91 = default(object);
			double num70 = default(double);
			double num73 = default(double);
			double num77 = default(double);
			double num81 = default(double);
			object obj93 = default(object);
			object obj94 = default(object);
			object obj96 = default(object);
			object obj97 = default(object);
			object obj100 = default(object);
			double num7 = default(double);
			double num21 = default(double);
			double num23 = default(double);
			double num25 = default(double);
			double num27 = default(double);
			double num29 = default(double);
			double num3 = default(double);
			WaitForSeconds waitForSeconds = default(WaitForSeconds);
			while (true)
			{
				object obj10 = obj5;
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v8+3B0]");
				object obj11 = (nint)0 & (nint)1;
				bool flag6 = obj11 == null;
				object obj12 = !flag6;
				WarpTextMeshPro warpTextMeshPro2 = (WarpTextMeshPro)(object)<WarpText>d__;
				int num12;
				<WarpText>d__7 <WarpText>d__2;
				double num5;
				if (obj12 == null)
				{
					warpTextMeshPro2 = (WarpTextMeshPro)(object)<WarpText>d__;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					double num2 = (double)curveScale - num3;
					bool flag7 = num2 < 0.0;
					bool flag8 = num2 == 0.0;
					object obj13 = (double)curveScale ^ num3;
					object obj14 = (double)curveScale ^ num2;
					object obj15 = obj13 & obj14;
					bool flag9 = (nint)obj15 < 0;
					bool flag10 = flag7 == flag9;
					object obj16 = !flag8;
					object obj17 = flag10 & obj16;
					object obj18 = ~obj17;
					double num4 = ((obj18 != null) ? num3 : ((double)curveScale));
					object obj19 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X8_v72+B8]");
					object obj20 = 0;
					num5 = num4 * 897988541.0;
					num3 = (double)obj20 * 8.0;
					double num6 = num5 - num3;
					bool flag11 = num6 < 0.0;
					bool flag12 = num6 == 0.0;
					object obj21 = num5 ^ num3;
					object obj22 = num5 ^ num6;
					object obj23 = obj21 & obj22;
					bool flag13 = (nint)obj23 < 0;
					bool flag14 = flag11 == flag13;
					object obj24 = !flag12;
					bool flag15 = (byte)((flag14 & obj24) ? 1 : 0) != 0;
					object obj25 = !flag15;
					if (obj25 != null)
					{
						num5 = num3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					bool flag16 = num3 < num5;
					obj4 = !flag16;
					num = num3 - num5;
					flag2 = num3 < num5;
					num7 = 897988541.0;
					if (!flag2)
					{
						if (<old_curve>5__3 == null)
						{
							break;
						}
						Keyframe[] keys = <old_curve>5__3.keys;
						if (keys == null)
						{
							break;
						}
						object obj26 = keys.Length & 0xFFFFFFFEL;
						bool flag17 = obj26 == null;
						num7 = 897988541.0;
						if (!flag17)
						{
							Keyframe keyframe = (Keyframe)(keys + 60);
							float value = ((Keyframe*)keyframe)->value;
							if (warpTextMeshPro.vertexCurve == null)
							{
								break;
							}
							Keyframe[] keys2 = warpTextMeshPro.vertexCurve.keys;
							if (keys2 == null)
							{
								break;
							}
							object obj27 = keys2.Length & 0xFFFFFFFEL;
							bool flag18 = obj27 == null;
							num7 = 897988541.0;
							num5 = value;
							if (!flag18)
							{
								Keyframe keyframe2 = (Keyframe)(keys2 + 60);
								float value2 = ((Keyframe*)keyframe2)->value;
								warpTextMeshPro2 = (WarpTextMeshPro)keyframe2;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								float num8 = value2 - (float)num3;
								bool flag19 = num8 < 0f;
								bool flag20 = num8 == 0f;
								object obj28 = (double)value2 ^ num3;
								object obj29 = value2 ^ num8;
								object obj30 = obj28 & obj29;
								bool flag21 = (nint)obj30 < 0;
								bool flag22 = flag19 == flag21;
								object obj31 = !flag20;
								object obj32 = flag22 & obj31;
								object obj33 = ~obj32;
								double num9 = ((obj33 != null) ? num3 : ((double)value2));
								object obj34 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v77+B8]");
								object obj35 = 0;
								double num10 = num9 * 897988541.0;
								num3 = (double)obj35 * 8.0;
								double num11 = num10 - num3;
								bool flag23 = num11 < 0.0;
								bool flag24 = num11 == 0.0;
								object obj36 = num10 ^ num3;
								object obj37 = num10 ^ num11;
								object obj38 = obj36 & obj37;
								bool flag25 = (nint)obj38 < 0;
								bool flag26 = flag23 == flag25;
								obj24 = !flag24;
								object obj39 = flag26 & obj24;
								obj25 = ~obj39;
								if (obj25 != null)
								{
									num10 = num3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								bool flag27 = num3 < num10;
								obj4 = !flag27;
								num = num3 - num10;
								flag2 = num < 0.0;
								flag15 = !(num3 < num10);
								num7 = 897988541.0;
								if (flag15)
								{
									object obj40 = this + 24;
									obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									num12 = 1;
									<WarpText>d__2 = this;
									goto IL_1d2c;
								}
								goto IL_0362;
							}
						}
						goto IL_1505;
					}
				}
				goto IL_0362;
				IL_1d2c:
				<WarpText>d__2.<>1__state = num12;
				return true;
				IL_1505:
				throw new IndexOutOfRangeException();
				IL_0362:
				curveScale = warpTextMeshPro.curveScale;
				<old_CurveScale>5__2 = warpTextMeshPro.curveScale;
				AnimationCurve animationCurve2 = warpTextMeshPro2.CopyAnimationCurve(warpTextMeshPro.vertexCurve);
				<old_curve>5__3 = animationCurve2;
				object obj41 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProUGUI textMeshProUGUI = textComponent;
				if ((object)textComponent == null)
				{
					break;
				}
				nint num13 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v21 (Il2CppClass<TMPro.TextMeshProUGUI>)+7E0]");
				object obj42 = 0;
				textComponent.ForceMeshUpdate();
				if (obj5 == null)
				{
					break;
				}
				TMP_TextInfo textInfo = ((TMP_Text)obj5).textInfo;
				if (textInfo == null)
				{
					break;
				}
				bool flag28 = textInfo.characterCount == 0;
				bool flag5 = false;
				<WarpText>d__ = (<WarpText>d__7)(object)textInfo;
				if (flag28)
				{
					continue;
				}
				if (obj5 == null)
				{
					break;
				}
				Bounds bounds = ((TMP_Text)obj5).bounds;
				if (obj5 == null)
				{
					break;
				}
				Bounds bounds2 = ((TMP_Text)obj5).bounds;
				bool flag29 = textInfo.characterCount < 1;
				object obj43 = obj5;
				<WarpText>d__7 <WarpText>d__3 = this;
				num5 = warpTextMeshPro.curveScale;
				flag5 = false;
				if (!flag29)
				{
					double num14 = num15 - num16;
					double num17 = num15 + num16;
					double num18 = num17 - num14;
					object obj44 = typeof(UsageHint) + 816;
					WarpTextMeshPro warpTextMeshPro3 = <>4__this;
					double num19 = num7;
					double num20 = num21;
					double num22 = num23;
					double num24 = num25;
					double num26 = num27;
					double num28 = num29;
					object obj45 = 12;
					object obj46 = 324;
					double num30 = num16;
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v21 (Il2CppClass<TMPro.TextMeshProUGUI>)+7E0]");
					object obj48 = 0;
					double num31 = 897988541.0;
					bool flag30 = false;
					object obj49 = obj5;
					TMP_TextInfo tMP_TextInfo = textInfo;
					object obj50 = 146599936;
					while (true)
					{
						TMP_CharacterInfo[] characterInfo = tMP_TextInfo.characterInfo;
						if (tMP_TextInfo.characterInfo == null)
						{
							break;
						}
						bool flag31 = (nint)obj47 < characterInfo.Length;
						object obj51 = !flag31;
						num7 = num19;
						num21 = num20;
						num23 = num22;
						num25 = num24;
						num27 = num26;
						num29 = num28;
						num3 = num30;
						obj43 = obj5;
						<WarpText>d__3 = this;
						obj42 = obj48;
						num5 = num17;
						flag5 = flag30;
						object obj59;
						double num34;
						object obj64;
						object obj67;
						float num38;
						double num39;
						float num40;
						object obj75;
						object obj77;
						if (obj51 == null)
						{
							object obj52 = (object)tMP_TextInfo.characterInfo + obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v8+4C]");
							if ((nint)0 != 1)
							{
								goto IL_1a72;
							}
							TMP_MeshInfo[] meshInfo = tMP_TextInfo.meshInfo;
							if (tMP_TextInfo.meshInfo == null)
							{
								break;
							}
							object obj53 = (object)tMP_TextInfo.characterInfo + obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X11_v9-F4]");
							bool flag32 = (nint)0 < (nint)meshInfo.Length;
							object obj54 = !flag32;
							num7 = num19;
							num21 = num20;
							num23 = num22;
							num25 = num24;
							num27 = num26;
							num29 = num28;
							num3 = num30;
							obj43 = obj5;
							<WarpText>d__3 = this;
							obj42 = obj48;
							num5 = num17;
							flag5 = flag30;
							if (obj54 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X11_v9-F4]");
								object obj55 = (nint)0 * (nint)80;
								object obj56 = (object)tMP_TextInfo.meshInfo + obj55;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+30]");
								object obj57 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+30]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v8-E0]");
								obj50 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v8-E0]");
								nint num32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X12_v7+18]");
								bool flag33 = num32 < 0;
								object obj58 = !flag33;
								num7 = num19;
								num21 = num20;
								num23 = num22;
								num25 = num24;
								num27 = num26;
								num29 = num28;
								num3 = num30;
								obj43 = obj5;
								<WarpText>d__3 = this;
								obj42 = obj48;
								num5 = num17;
								flag5 = flag30;
								if (obj58 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v8-E0]");
									obj59 = (nint)0 + (nint)2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X12_v7+18]");
									bool flag34 = (nint)obj59 < 0;
									object obj60 = !flag34;
									num7 = num19;
									num21 = num20;
									num23 = num22;
									num25 = num24;
									num27 = num26;
									num29 = num28;
									num3 = num30;
									obj43 = obj5;
									<WarpText>d__3 = this;
									obj42 = obj48;
									num5 = num17;
									flag5 = flag30;
									if (obj60 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+30]");
										object obj61 = (nint)0 + (nint)32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v8-E0]");
										object obj62 = 0 * obj45;
										obj49 = obj61 + obj62;
										object obj63 = obj59 * obj45;
										obj9 = obj61 + obj63;
										num5 = (double)obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X9_v11 (TMPro.TMP_CharacterInfo[])+v293 @ X28_v8]");
										num3 = 0.0;
										double num33 = (double)obj49 + (double)obj9;
										num34 = num33 * 0.5;
										num7 = (double)obj49 - num34;
										obj49 = num7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v8-E0]");
										obj64 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X12_v7+18]");
										bool flag35 = (nint)obj64 < 0;
										object obj65 = !flag35;
										num21 = num34;
										num23 = num22;
										num25 = num34;
										num27 = num26;
										num29 = num28;
										obj43 = obj5;
										<WarpText>d__3 = this;
										obj42 = obj48;
										flag5 = flag30;
										if (obj65 == null)
										{
											object obj66 = obj64 * obj45;
											warpTextMeshPro3 = (WarpTextMeshPro)(object)(obj61 + obj66);
											double num35 = (double)warpTextMeshPro3 - num34;
											warpTextMeshPro3 = (WarpTextMeshPro)num35;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X20_v11+4]");
											num7 = 0.0;
											num5 -= num34;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X20_v11+4]");
											num3 = 0.0 - num3;
											obj9 = num5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v8-E0]");
											obj67 = (nint)0 + (nint)3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X12_v7+18]");
											bool flag36 = (nint)obj67 < 0;
											object obj68 = !flag36;
											num21 = num34;
											num23 = num22;
											num25 = num34;
											num27 = num26;
											num29 = num28;
											obj43 = obj5;
											<WarpText>d__3 = this;
											obj42 = obj48;
											flag5 = flag30;
											if (obj68 == null)
											{
												object obj69 = obj67 * 12;
												num31 = (double)obj61 + (double)obj69;
												double value3 = ((double*)(nint)num31)->m_value - num34;
												((double*)(nint)num31)->m_value = value3;
												if (warpTextMeshPro.vertexCurve == null)
												{
													break;
												}
												double num36 = num34 - num14;
												double num37 = num36 / num18;
												num38 = warpTextMeshPro.vertexCurve.Evaluate((float)num37);
												if (warpTextMeshPro.vertexCurve == null)
												{
													break;
												}
												num39 = num37 + 953267991.0;
												num40 = warpTextMeshPro.vertexCurve.Evaluate((float)num39);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
												object obj70 = (nint)0 & (nint)1;
												if (obj70 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
													object obj71 = (nint)0 & (nint)1;
													if (obj71 != null)
													{
														goto IL_0e95;
													}
												}
												else
												{
													_ = 1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
													object obj72 = (nint)0 & (nint)1;
													bool flag37 = obj72 == null;
													object obj73 = !flag37;
													if (obj73 != null)
													{
														goto IL_0e95;
													}
												}
												_ = 1;
												object obj74 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
												obj75 = obj74;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ X0_v44+E4]");
												bool flag38 = (nint)0 == 0;
												object obj76 = !flag38;
												obj77 = obj75;
												if (obj76 != null)
												{
													goto IL_0ede;
												}
												goto IL_1073;
											}
										}
									}
								}
							}
						}
						goto IL_1505;
						IL_0ede:
						float num41 = num38 * warpTextMeshPro.curveScale;
						float num42 = num40 * warpTextMeshPro.curveScale;
						double num43 = num18 * num39;
						double num44 = num14 + num43;
						double num45 = num44 - num34;
						float num46 = num42 - num41;
						double num47 = num45 * num45;
						float num48 = num46 * num46;
						double num49 = num47 + (double)num48;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						double num50;
						float num51;
						double num52;
						object obj78;
						if (num49 > 925353388.0)
						{
							num50 = num45 / num49;
							num51 = num46 / (float)num49;
							num52 = 0.0 / num49;
							obj78 = 0;
						}
						else
						{
							object obj79 = obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v63+B8]");
							object obj80 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ X8_v64+4]");
							num51 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ X8_v64+8]");
							num52 = 0.0;
							num50 = (double)obj80;
							obj78 = 0;
						}
						float num53 = num51 * (float)obj78;
						double num54 = num50 + (double)num53;
						double num55 = num52 * (double)obj78;
						double num56 = num55 + num54;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0DC0");
						double num57 = num56 * 1113927393.0;
						double num58 = num45 * (double)obj78;
						double num59 = 1135869952.0 - num57;
						float num60 = num46 - (float)num58;
						bool flag39 = num60 < 0f;
						bool flag40 = num60 == 0f;
						object obj81 = (double)num46 ^ num58;
						object obj82 = num46 ^ num60;
						object obj83 = obj81 & obj82;
						bool flag41 = (nint)obj83 < 0;
						bool flag42 = flag39 == flag41;
						object obj24 = !flag40;
						object obj84 = flag42 & obj24;
						object obj25 = ~obj84;
						if (obj25 != null)
						{
							num57 = num59;
						}
						double num61 = num57 * 1016003125.0;
						Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
						object obj85 = obj44;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1446 @ X8_v56+B8]");
						object obj86 = 0;
						_ = 0;
						_ = 0;
						Matrix4x4 matrix4x = Matrix4x4.Internal_TRS(ref System.Runtime.CompilerServices.Unsafe.As<object, Vector3>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 164)), ref q, ref s);
						object obj87 = obj50;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X12_v7+18]");
						bool flag43 = (nint)obj87 < 0;
						object obj88 = !flag43;
						num7 = num59;
						num21 = num34;
						num23 = num22;
						num25 = num34;
						num27 = num26;
						num29 = num28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v57+C]");
						num3 = 0.0;
						obj43 = obj5;
						<WarpText>d__3 = this;
						obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v57+14]");
						num5 = 0.0;
						flag5 = (byte)(&s) != 0;
						if (obj88 == null)
						{
							double num62 = num15 * (double)obj89;
							double num63 = num64 * (double)obj90;
							double num65 = num62 + num63;
							double num66 = num67 * (double)obj91;
							double num68 = num65 + num66;
							double num69 = num70 + num68;
							double num71 = num61 * (double)obj49;
							double num72 = num73;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X26_v9+4]");
							double num74 = num72 * 0.0;
							double num75 = num71 + num74;
							double num76 = num77;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X26_v9+8]");
							double num78 = num76 * 0.0;
							double num79 = num75 + num78;
							double num80 = num81 + num79;
							obj49 = num69;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X12_v7+18]");
							bool flag44 = (nint)obj64 < 0;
							object obj92 = !flag44;
							num7 = num64;
							num21 = num15;
							num23 = num81;
							num25 = num77;
							num27 = num73;
							num29 = num61;
							num3 = num67;
							obj43 = obj5;
							<WarpText>d__3 = this;
							obj42 = 0;
							num5 = num70;
							flag5 = (byte)(&s) != 0;
							if (obj92 == null)
							{
								double num82 = num15 * (double)obj91;
								double num83 = num64 * (double)obj93;
								double num84 = num82 + num83;
								double num85 = num67 * (double)obj94;
								double num86 = num84 + num85;
								double num87 = num70 + num86;
								double num88 = num61 * (double)warpTextMeshPro3;
								double num89 = num73;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X24_v9 (WarpTextMeshPro)+4]");
								double num90 = num89 * 0.0;
								double num91 = num88 + num90;
								double num92 = num77;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X24_v9 (WarpTextMeshPro)+8]");
								double num93 = num92 * 0.0;
								double num94 = num91 + num93;
								double num95 = num81 + num94;
								warpTextMeshPro3 = (WarpTextMeshPro)num87;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X12_v7+18]");
								bool flag45 = (nint)obj59 < 0;
								object obj95 = !flag45;
								num7 = num64;
								num21 = num15;
								num23 = num81;
								num25 = num77;
								num27 = num73;
								num29 = num61;
								num3 = num67;
								obj43 = obj5;
								<WarpText>d__3 = this;
								obj42 = 0;
								num5 = num70;
								flag5 = (byte)(&s) != 0;
								if (obj95 == null)
								{
									double num96 = num15 * (double)obj94;
									double num97 = num64 * (double)obj96;
									double num98 = num96 + num97;
									double num99 = num67 * (double)obj97;
									double num100 = num98 + num99;
									double num101 = num70 + num100;
									double num102 = num61 * (double)obj9;
									double num103 = num73;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X20_v11+4]");
									double num104 = num103 * 0.0;
									double num105 = num102 + num104;
									double num106 = num77;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X20_v11+8]");
									double num107 = num106 * 0.0;
									double num108 = num105 + num107;
									double num109 = num81 + num108;
									obj9 = num101;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X12_v7+18]");
									bool flag46 = (nint)obj67 < 0;
									object obj98 = !flag46;
									object obj99 = ~obj98;
									num7 = num64;
									num21 = num15;
									num23 = num81;
									num25 = num77;
									num27 = num73;
									num29 = num61;
									num3 = num67;
									obj43 = obj5;
									<WarpText>d__3 = this;
									obj42 = 0;
									num5 = num70;
									flag5 = (byte)(&s) != 0;
									if (obj99 != null)
									{
										double num110 = num61 * ((double*)(nint)num31)->m_value;
										double num111 = num73;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X21_v10 (System.Double)+4]");
										double num112 = num111 * 0.0;
										double num113 = num110 + num112;
										double num114 = num77;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X21_v10 (System.Double)+8]");
										double num115 = num114 * 0.0;
										double num116 = num113 + num115;
										double num117 = num81 + num116;
										double num118 = num34 + num69;
										double num119 = num80 + (double)obj78;
										obj49 = num118;
										double num120 = num34 + num87;
										double num121 = num95 + (double)obj78;
										warpTextMeshPro3 = (WarpTextMeshPro)num120;
										num28 = num34 + num101;
										num26 = num109 + (double)obj78;
										obj9 = num28;
										num24 = num117 + (double)obj78;
										num20 = num15 * (double)obj96;
										double num122 = num64 * (double)obj97;
										num19 = num20 + num122;
										double num123 = num67 * (double)obj100;
										num30 = num19 + num123;
										double num124 = num70 + num30;
										num17 = (((double*)(nint)num31)->m_value = num34 + num124);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v57+C]");
										s = (Vector3)0;
										q = (Quaternion)num61;
										num22 = num34;
										obj45 = 12;
										obj48 = 0;
										flag30 = (byte)(&s) != 0;
										tMP_TextInfo = textInfo;
										goto IL_1a72;
									}
								}
							}
						}
						goto IL_1505;
						IL_1a72:
						obj47++;
						obj46 += 376;
						bool flag47 = textInfo.characterCount == (nint)obj47;
						num7 = num19;
						num21 = num20;
						num23 = num22;
						num25 = num24;
						num27 = num26;
						num29 = num28;
						num3 = num30;
						obj43 = obj5;
						<WarpText>d__3 = this;
						obj42 = obj48;
						num5 = num17;
						flag5 = flag30;
						if (!flag47)
						{
							continue;
						}
						goto IL_1510;
						IL_1073:
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						goto IL_0ede;
						IL_0e95:
						object obj101 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
						obj75 = obj101;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ X0_v44+E4]");
						bool flag48 = (nint)0 == 0;
						obj77 = obj75;
						if (!flag48)
						{
							goto IL_0ede;
						}
						goto IL_1073;
					}
					break;
				}
				goto IL_1510;
				IL_1510:
				object obj102 = obj43;
				if (obj43 == null)
				{
					break;
				}
				object obj103 = obj102;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1184 @ X8_v13+808] (should have been resolved before IL gen)");
				object obj104 = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				waitForSeconds..ctor(0.025f);
				object obj105 = <WarpText>d__3 + 24;
				obj105 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num12 = 2;
				<WarpText>d__2 = <WarpText>d__3;
				goto IL_1d2c;
			}
			goto IL_15ed;
			IL_15ed:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private AnimationCurve vertexCurve;

	private float curveScale;

	private List<TextMeshProUGUI> texts;

	private void Reset()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0064: Expected I, but got O
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3880;
		object obj2 = (nint)0 + (nint)840;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 48;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v3 (Il2CppClass<System.Object>)+1F0]");
		Action<object> action = default(Action<object>);
		action..ctor(obj5, (IntPtr)0);
		IEnumerable<object> enumeration = default(IEnumerable<object>);
		ArraysExtensions.ForEach(enumeration, action);
	}

	private void Start()
	{
		vertexCurve.preWrapMode = WrapMode.Once;
		vertexCurve.postWrapMode = WrapMode.Once;
		double num = (double)curveScale * 10.0;
		curveScale = (float)num;
	}

	private void OnEnable()
	{
		//IL_0012: Expected O, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (texts != null)
		{
			object obj = (nint)0 + (nint)2280;
			List<object>.Enumerator enumerator = ((List<object>)(object)texts).GetEnumerator();
			object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 2488;
			object obj3 = default(object);
			while (enumerator2.MoveNext())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj3..ctor();
				object obj4 = obj3 + 40;
				obj4 = this;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj5 = obj3 + 32;
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Coroutine coroutine = StartCoroutine((IEnumerator)obj3);
			}
			enumerator2.Dispose();
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		IntPtr intPtr = default(IntPtr);
		bool flag = intPtr != (IntPtr)1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			enumerator2.Dispose();
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			ex2 = new OutOfMemoryException();
			object obj7 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223AE94");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AnimationCurve animationCurve = default(AnimationCurve);
		animationCurve..ctor();
		if (curve != null)
		{
			Keyframe[] keys = curve.keys;
			if (animationCurve != null)
			{
				animationCurve.keys = keys;
				return animationCurve;
			}
		}
		return (AnimationCurve)(object)new NullReferenceException();
	}

	private IEnumerator WarpText(TextMeshProUGUI textComponent)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = textComponent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public WarpTextMeshPro()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0071: Expected O, but got I8
		//IL_00cb: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Keyframe keyframe = new Keyframe(0f, 0f);
		Keyframe[] array = default(Keyframe[]);
		if (array.Length != 0)
		{
			Keyframe keyframe2 = new Keyframe(0.5f, 2f);
			if ((object)(array.Length & 0xFFFFFFFEL) != null)
			{
				Keyframe keyframe3 = new Keyframe(1f, 0f);
				if ((object)(~(object)(array.Length >= 2) | ((object)(array.Length - 2) == null)) == null)
				{
					object obj2 = typeof(SqlSingle[]) + 3880;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					AnimationCurve animationCurve = default(AnimationCurve);
					animationCurve..ctor(array);
					object obj3 = this + 32;
					obj3 = animationCurve;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					curveScale = 1f;
					base..ctor();
					return;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
