using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class RoomItem : MonoBehaviour
{
	private sealed class <>c__DisplayClass24_0
	{
		public int generation;

		public RoomItem <>4__this;

		internal unsafe void <LoadAnimatedElements>b__0(AnimatedRoomDataModel model)
		{
			//IL_0008: Expected O, but got Ref
			//IL_0010: Expected O, but got Ref
			//IL_0020: Expected O, but got I
			//IL_1112: Expected F8, but got I4
			//IL_004b: Expected F8, but got I4
			//IL_1017: Expected O, but got I
			//IL_1065: Expected O, but got I
			//IL_1087: Expected F8, but got I4
			//IL_00a3: Expected F8, but got I4
			//IL_00d3: Expected F8, but got I4
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_0102: Expected O, but got I
			//IL_0123: Expected O, but got I4
			//IL_0144: Expected F8, but got I4
			//IL_0155: Expected O, but got I4
			//IL_015e: Expected O, but got I4
			//IL_0396: Expected O, but got I4
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Expected O, but got Unknown
			//IL_048a: Expected F8, but got I
			//IL_04b4: Expected F8, but got I
			//IL_04ca: Expected O, but got I
			//IL_0516: Expected F8, but got I4
			//IL_1145: Expected O, but got Ref
			//IL_1198: Expected O, but got I4
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Expected O, but got Unknown
			//IL_0531: Expected O, but got I
			//IL_054b: Expected O, but got I4
			//IL_05eb: Expected O, but got I4
			//IL_06cb: Expected O, but got I4
			//IL_07ab: Expected O, but got I4
			//IL_088b: Expected O, but got I4
			//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f3: Expected O, but got Unknown
			//IL_096d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0972: Expected O, but got Unknown
			//IL_0987: Unknown result type (might be due to invalid IL or missing references)
			//IL_098c: Expected O, but got Unknown
			//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a6: Expected O, but got Unknown
			//IL_09bc: Expected O, but got I
			//IL_09da: Expected O, but got I
			//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a57: Expected O, but got Unknown
			//IL_0a6c: Expected O, but got I
			//IL_0a7a: Expected O, but got Ref
			//IL_0a8a: Expected O, but got I
			//IL_0a9f: Expected O, but got Ref
			//IL_0ab4: Expected F8, but got I
			//IL_0b22: Expected O, but got I
			//IL_0b22: Expected O, but got I
			//IL_0b22: Expected O, but got I
			//IL_0b22: Expected O, but got I
			//IL_0b22: Expected O, but got Ref
			//IL_0b4b: Expected O, but got I4
			//IL_0b5b: Expected O, but got I
			//IL_0b6b: Expected O, but got I
			//IL_0b7b: Expected O, but got I
			//IL_0b83: Expected O, but got Ref
			//IL_0bc6: Expected O, but got I4
			//IL_0bd6: Expected O, but got I
			//IL_0be6: Expected O, but got I
			//IL_0bf6: Expected O, but got I
			//IL_0bfe: Expected O, but got Ref
			//IL_0c7c: Expected O, but got Ref
			//IL_0c98: Expected O, but got I4
			//IL_0ca8: Expected O, but got I
			//IL_0cb8: Expected O, but got I
			//IL_0cc5: Expected O, but got Ref
			//IL_0cce: Expected F8, but got I4
			//IL_0cd7: Expected F8, but got I4
			//IL_0ce4: Expected I, but got O
			//IL_0d23: Expected O, but got I4
			//IL_0d33: Expected O, but got I
			//IL_0d43: Expected O, but got I
			//IL_0d56: Expected F8, but got I4
			//IL_0d5f: Expected F8, but got I4
			//IL_0d6c: Expected I, but got O
			//IL_0da4: Expected O, but got I4
			//IL_0db4: Expected O, but got I
			//IL_0dc4: Expected O, but got I
			//IL_0dda: Expected F8, but got I4
			//IL_0de3: Expected F8, but got I4
			//IL_0df0: Expected I, but got O
			//IL_0e0a: Expected O, but got I
			//IL_0e5c: Expected O, but got I4
			//IL_0e6c: Expected O, but got I
			//IL_0e7c: Expected O, but got I
			//IL_0e92: Expected F8, but got I4
			//IL_0e9b: Expected F8, but got I4
			//IL_0ea8: Expected I, but got O
			//IL_0ed6: Expected O, but got I4
			//IL_017b: Expected O, but got I
			//IL_018b: Expected O, but got I
			//IL_01b6: Expected O, but got I4
			//IL_01c6: Expected O, but got I
			//IL_01d6: Expected O, but got I
			//IL_01df: Expected O, but got I4
			//IL_01f5: Expected F8, but got I4
			//IL_01fe: Expected F8, but got I4
			//IL_0207: Expected O, but got I4
			//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f1b: Expected O, but got Unknown
			//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f29: Expected O, but got Unknown
			//IL_0f44: Expected O, but got I4
			//IL_0f54: Expected O, but got I
			//IL_0f64: Expected O, but got I
			//IL_0f6d: Expected O, but got I4
			//IL_0f83: Expected F8, but got I4
			//IL_0f8c: Expected F8, but got I4
			//IL_0f99: Expected I, but got O
			//IL_0fa2: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			SpineRoomElementData spineRoomElementData = default(SpineRoomElementData);
			object obj3 = (object)(&spineRoomElementData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj4 = 0;
			_ = 0;
			_ = 0;
			RoomItem roomItem = <>4__this;
			bool flag = (object)<>4__this == null;
			AnimatedRoomDataModel animatedRoomDataModel2 = default(AnimatedRoomDataModel);
			AnimatedRoomDataModel animatedRoomDataModel = animatedRoomDataModel2;
			double num = 0.0;
			<>c__DisplayClass24_0 <>c__DisplayClass24_;
			IndexOutOfRangeException ex;
			if (!flag)
			{
				bool flag2 = generation != roomItem._loadGeneration;
				num = 0.0;
				if (flag2)
				{
					goto IL_1007;
				}
				if (animatedRoomDataModel2 == null)
				{
					roomItem._isAnimatedItemsLoaded = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X29_v1-98]");
					bool flag3 = obj5 != null;
					num = 0.0;
					ex = (IndexOutOfRangeException)(object)<>4__this;
					if (!flag3)
					{
						<>4__this.FinishLoading();
						return;
					}
					goto IL_10cf;
				}
				int[] array = SortElementsBySortOrder(animatedRoomDataModel2);
				bool flag4 = array == null;
				animatedRoomDataModel = animatedRoomDataModel2;
				num = 0.0;
				if (!flag4)
				{
					bool flag5 = array.Length < 1;
					animatedRoomDataModel = animatedRoomDataModel2;
					num = 0.0;
					<>c__DisplayClass24_ = this;
					if (flag5)
					{
						goto IL_0faf;
					}
					object obj6 = array + 32;
					object obj8 = default(object);
					object obj7 = (nint)(&obj8) | (nint)4;
					object obj10 = default(object);
					object obj9 = obj10;
					AudioClip audioClip2 = default(AudioClip);
					AudioClip audioClip = audioClip2;
					Texture2D texture2D2 = default(Texture2D);
					Texture2D texture2D = texture2D2;
					spineRoomElementData = (SpineRoomElementData)0;
					string text2 = default(string);
					string text = text2;
					AnimatedRoomDataModel animatedRoomDataModel3 = animatedRoomDataModel2;
					double num3 = default(double);
					double num2 = num3;
					double num4 = 0.0;
					nint num6 = default(nint);
					nint num5 = num6;
					object obj11 = 96;
					object obj12 = 0;
					AnimatedRoomDataModel animatedRoomDataModel4 = animatedRoomDataModel2;
					object obj31 = default(object);
					while (true)
					{
						AnimatedRoomDataInfo <AnimatedRoomInfo>k__BackingField = animatedRoomDataModel4.<AnimatedRoomInfo>k__BackingField;
						bool flag6 = (object)animatedRoomDataModel4.<AnimatedRoomInfo>k__BackingField == null;
						obj10 = obj9;
						audioClip2 = audioClip;
						texture2D2 = texture2D;
						text2 = text;
						animatedRoomDataModel = animatedRoomDataModel3;
						num3 = num2;
						num = num4;
						num6 = num5;
						if (flag6)
						{
							break;
						}
						AnimatedRoomElementInfo[] elements = <AnimatedRoomInfo>k__BackingField.Elements;
						bool flag7 = <AnimatedRoomInfo>k__BackingField.Elements == null;
						obj10 = obj9;
						audioClip2 = audioClip;
						texture2D2 = texture2D;
						text2 = text;
						animatedRoomDataModel = animatedRoomDataModel3;
						num3 = num2;
						num = num4;
						num6 = num5;
						if (flag7)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
						bool flag8 = (nint)0 < (nint)elements.Length;
						object obj13 = !flag8;
						obj10 = obj9;
						audioClip2 = audioClip;
						texture2D2 = texture2D;
						text2 = text;
						animatedRoomDataModel = animatedRoomDataModel3;
						num3 = num2;
						num = num4;
						num6 = num5;
						if (obj13 == null)
						{
							bool flag9 = (object)<>4__this == null;
							obj10 = obj9;
							audioClip2 = audioClip;
							texture2D2 = texture2D;
							text2 = text;
							animatedRoomDataModel = animatedRoomDataModel3;
							num3 = num2;
							num = num4;
							num6 = num5;
							if (flag9)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
							object obj14 = 0 * obj11;
							object obj15 = (object)<AnimatedRoomInfo>k__BackingField.Elements + obj14;
							object obj16 = obj15 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+34]");
							double num7 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+4]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+48]");
							num4 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+58]");
							object obj17 = (nint)0 & (nint)1;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								double num8 = num7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+48]");
								num7 = num8 * 0.0;
								num2 = 1059648963.0;
							}
							else
							{
								num2 = 0.5;
							}
							object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 224));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X27_v1+90]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X27_v1+9C]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+3C]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+5C]");
							_ = 0;
							bool flag10 = obj16 == null;
							object obj19 = !flag10;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+58]");
								object obj20 = (nint)0 & (nint)1;
								bool flag11 = obj20 == null;
								object obj21 = !flag11;
								if (obj21 == null)
								{
									Texture2D[] <Images>k__BackingField = animatedRoomDataModel4.<Images>k__BackingField;
									bool flag12 = animatedRoomDataModel4.<Images>k__BackingField == null;
									obj10 = obj9;
									audioClip2 = audioClip;
									texture2D2 = texture2D;
									text2 = text;
									animatedRoomDataModel = animatedRoomDataModel3;
									num3 = num2;
									num = num4;
									num6 = num5;
									if (flag12)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
									bool flag13 = (nint)0 < (nint)<Images>k__BackingField.Length;
									object obj22 = !flag13;
									obj10 = obj9;
									audioClip2 = audioClip;
									texture2D2 = texture2D;
									text2 = text;
									animatedRoomDataModel = animatedRoomDataModel3;
									num3 = num2;
									num = num4;
									num6 = num5;
									if (obj22 == null)
									{
										AudioClip[] <Audios>k__BackingField = animatedRoomDataModel4.<Audios>k__BackingField;
										bool flag14 = animatedRoomDataModel4.<Audios>k__BackingField == null;
										obj10 = obj9;
										audioClip2 = audioClip;
										texture2D2 = texture2D;
										text2 = text;
										animatedRoomDataModel = animatedRoomDataModel3;
										num3 = num2;
										num = num4;
										num6 = num5;
										if (flag14)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
										bool flag15 = (nint)0 < (nint)<Audios>k__BackingField.Length;
										object obj23 = !flag15;
										obj10 = obj9;
										audioClip2 = audioClip;
										texture2D2 = texture2D;
										text2 = text;
										animatedRoomDataModel = animatedRoomDataModel3;
										num3 = num2;
										num = num4;
										num6 = num5;
										if (obj23 == null)
										{
											string[] <SpineSkeletonTexts>k__BackingField = animatedRoomDataModel4.<SpineSkeletonTexts>k__BackingField;
											bool flag16 = animatedRoomDataModel4.<SpineSkeletonTexts>k__BackingField == null;
											obj10 = obj9;
											audioClip2 = audioClip;
											texture2D2 = texture2D;
											text2 = text;
											animatedRoomDataModel = animatedRoomDataModel3;
											num3 = num2;
											num = num4;
											num6 = num5;
											if (flag16)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
											bool flag17 = (nint)0 < (nint)<SpineSkeletonTexts>k__BackingField.Length;
											object obj24 = !flag17;
											obj10 = obj9;
											audioClip2 = audioClip;
											texture2D2 = texture2D;
											text2 = text;
											animatedRoomDataModel = animatedRoomDataModel3;
											num3 = num2;
											num = num4;
											num6 = num5;
											if (obj24 == null)
											{
												string[] <SpineAtlasTexts>k__BackingField = animatedRoomDataModel4.<SpineAtlasTexts>k__BackingField;
												bool flag18 = animatedRoomDataModel4.<SpineAtlasTexts>k__BackingField == null;
												obj10 = obj9;
												audioClip2 = audioClip;
												texture2D2 = texture2D;
												text2 = text;
												animatedRoomDataModel = animatedRoomDataModel3;
												num3 = num2;
												num = num4;
												num6 = num5;
												if (flag18)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
												bool flag19 = (nint)0 < (nint)<SpineAtlasTexts>k__BackingField.Length;
												object obj25 = !flag19;
												obj10 = obj9;
												audioClip2 = audioClip;
												texture2D2 = texture2D;
												text2 = text;
												animatedRoomDataModel = animatedRoomDataModel3;
												num3 = num2;
												num = num4;
												num6 = num5;
												if (obj25 == null)
												{
													string[] <SpineAtlasTexts>k__BackingField2 = animatedRoomDataModel4.<SpineAtlasTexts>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
													object obj26 = <SpineAtlasTexts>k__BackingField2 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X11_v9+20]");
													bool flag20 = (nint)0 == 0;
													obj10 = obj9;
													audioClip2 = audioClip;
													texture2D2 = texture2D;
													text2 = text;
													animatedRoomDataModel = animatedRoomDataModel3;
													num3 = num2;
													num = num4;
													num6 = num5;
													if (flag20)
													{
														break;
													}
													Texture2D[] <Images>k__BackingField2 = animatedRoomDataModel4.<Images>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
													object obj27 = <Images>k__BackingField2 + 0;
													AudioClip[] <Audios>k__BackingField2 = animatedRoomDataModel4.<Audios>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
													object obj28 = <Audios>k__BackingField2 + 0;
													string[] <SpineSkeletonTexts>k__BackingField2 = animatedRoomDataModel4.<SpineSkeletonTexts>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X19_v12+v258 @ X28_v9*4]");
													object obj29 = <SpineSkeletonTexts>k__BackingField2 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X11_v9+20]");
													int num9 = ((string)0).IndexOf('.');
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X11_v9+20]");
													string name = ((string)0).Substring(0, num9);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													bool flag21 = (nint)0 == 0;
													obj10 = obj9;
													audioClip2 = audioClip;
													texture2D2 = texture2D;
													text2 = null;
													animatedRoomDataModel = null;
													num3 = num2;
													num = num4;
													num6 = num9;
													if (flag21)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+2C]");
													object obj30 = 0 * obj31;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													((UnityEngine.Object)0).name = name;
													object obj32 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 224));
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v33+20]");
													obj7 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v33+2C]");
													_ = 0;
													object obj33 = (object)(&obj8);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v33+C]");
													num = 0.0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v33+C]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+59]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X27_v1+8B]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v32+20]");
													nint num10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X11_v9+20]");
													nint num11 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													nint num12 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
													spineRoomElementData = new SpineRoomElementData((AnimatedRoomElementInfo)(&obj8), (string)num10, (string)num11, (Texture2D)num12, (AudioClip)0);
													RoomItem roomItem2 = <>4__this;
													bool flag22 = (object)<>4__this == null;
													obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
													audioClip2 = (AudioClip)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													texture2D2 = (Texture2D)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X11_v9+20]");
													text2 = (string)0;
													animatedRoomDataModel = (AnimatedRoomDataModel)(&obj8);
													num3 = num2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v32+20]");
													num6 = 0;
													if (flag22)
													{
														break;
													}
													bool flag23 = (object)roomItem2.factory == null;
													obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
													audioClip2 = (AudioClip)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													texture2D2 = (Texture2D)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X11_v9+20]");
													text2 = (string)0;
													animatedRoomDataModel = (AnimatedRoomDataModel)(&obj8);
													num3 = num2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v32+20]");
													num6 = 0;
													if (flag23)
													{
														break;
													}
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X27_v1+60]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X27_v1+70]");
													_ = 0;
													_ = 0;
													_ = 0;
													_ = 0;
													SpineRoomElement spineRoomElement = roomItem2.factory.CreateSpineRoomElement((SpineRoomElementData)(&obj8), roomItem2.animatedElementsParent);
													bool flag24 = (object)spineRoomElement == null;
													obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
													audioClip2 = (AudioClip)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													texture2D2 = (Texture2D)0;
													text2 = null;
													animatedRoomDataModel = (AnimatedRoomDataModel)(&obj8);
													num3 = 0.0;
													num = 0.0;
													num6 = (nint)roomItem2.animatedElementsParent;
													if (flag24)
													{
														break;
													}
													GameObject gameObject = spineRoomElement.gameObject;
													RoomItem roomItem3 = <>4__this;
													bool flag25 = (object)<>4__this == null;
													obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
													audioClip2 = (AudioClip)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													texture2D2 = (Texture2D)0;
													text2 = null;
													animatedRoomDataModel = null;
													num3 = 0.0;
													num = 0.0;
													num6 = (nint)roomItem2.animatedElementsParent;
													if (flag25)
													{
														break;
													}
													List<object> animatedElements = (List<object>)(object)roomItem3._animatedElements;
													bool flag26 = roomItem3._animatedElements == null;
													obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
													audioClip2 = (AudioClip)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													texture2D2 = (Texture2D)0;
													text2 = null;
													animatedRoomDataModel = (AnimatedRoomDataModel)(object)gameObject;
													num3 = 0.0;
													num = 0.0;
													num6 = (nint)roomItem2.animatedElementsParent;
													if (flag26)
													{
														break;
													}
													object obj34 = (nint)0 + (nint)2544;
													object obj35 = obj34;
													int version = animatedElements._version + 1;
													animatedElements._version = version;
													object[] items = animatedElements._items;
													bool flag27 = animatedElements._items == null;
													obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
													audioClip2 = (AudioClip)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
													texture2D2 = (Texture2D)0;
													text2 = null;
													animatedRoomDataModel = (AnimatedRoomDataModel)(object)gameObject;
													num3 = 0.0;
													num = 0.0;
													num6 = (nint)roomItem2.animatedElementsParent;
													if (flag27)
													{
														break;
													}
													bool flag28 = animatedElements._size < items.Length;
													object obj36 = !flag28;
													if (obj36 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v40+20]");
														object obj37 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v42+C0]");
														object obj38 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v43+70]");
														num5 = 0;
														((List<object>)(object)roomItem3._animatedElements).AddWithResize((object)gameObject);
														obj9 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
														audioClip = (AudioClip)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
														texture2D = (Texture2D)0;
														obj8 = 0;
														text = null;
														animatedRoomDataModel3 = (AnimatedRoomDataModel)(object)gameObject;
														num2 = 0.0;
														num4 = 0.0;
														obj11 = 96;
														array = (int[])(object)roomItem3._animatedElements;
														animatedRoomDataModel4 = animatedRoomDataModel2;
													}
													else
													{
														int size = animatedElements._size + 1;
														animatedElements._size = size;
														object obj39 = animatedElements._items + animatedElements._size;
														object obj40 = obj39 + 32;
														obj40 = gameObject;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														obj9 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v31+20]");
														audioClip = (AudioClip)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v30+20]");
														texture2D = (Texture2D)0;
														obj8 = 0;
														text = null;
														animatedRoomDataModel3 = (AnimatedRoomDataModel)(object)gameObject;
														num2 = 0.0;
														num4 = 0.0;
														num5 = (nint)roomItem2.animatedElementsParent;
														obj11 = 96;
														animatedRoomDataModel4 = animatedRoomDataModel2;
													}
													goto IL_0221;
												}
											}
										}
									}
									goto IL_10b9;
								}
							}
							goto IL_0221;
						}
						goto IL_10b9;
						IL_0221:
						obj12++;
						bool flag29 = (nint)obj12 >= array.Length;
						obj10 = obj9;
						audioClip2 = audioClip;
						texture2D2 = texture2D;
						text2 = text;
						animatedRoomDataModel = animatedRoomDataModel3;
						num3 = num2;
						num = num4;
						num6 = num5;
						<>c__DisplayClass24_ = this;
						if (!flag29)
						{
							continue;
						}
						goto IL_0faf;
					}
				}
			}
			goto IL_10ab;
			IL_1007:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X29_v1-98]");
			bool flag30 = obj41 != null;
			ex = (IndexOutOfRangeException)(object)roomItem;
			if (!flag30)
			{
				return;
			}
			goto IL_10cf;
			IL_0faf:
			roomItem = <>c__DisplayClass24_.<>4__this;
			if ((object)<>c__DisplayClass24_.<>4__this != null)
			{
				roomItem._isAnimatedItemsLoaded = true;
				<>c__DisplayClass24_.<>4__this.FinishLoading();
				animatedRoomDataModel2 = animatedRoomDataModel;
				goto IL_1007;
			}
			goto IL_10ab;
			IL_10cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			return;
			IL_10ab:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_10b9;
			IL_10b9:
			ex = new IndexOutOfRangeException();
			animatedRoomDataModel2 = animatedRoomDataModel;
			goto IL_10cf;
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public AnimatedRoomDataModel model;

		internal unsafe int <SortElementsBySortOrder>b__0(int a, int b)
		{
			//IL_016a: Expected I4, but got O
			//IL_00a2: Expected O, but got I4
			//IL_00cb: Expected O, but got I4
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00fa: Expected O, but got I4
			//IL_0115: Expected O, but got I4
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected I4, but got Unknown
			AnimatedRoomDataModel animatedRoomDataModel = model;
			if (model != null)
			{
				AnimatedRoomDataInfo <AnimatedRoomInfo>k__BackingField = animatedRoomDataModel.<AnimatedRoomInfo>k__BackingField;
				if ((object)animatedRoomDataModel.<AnimatedRoomInfo>k__BackingField != null)
				{
					AnimatedRoomElementInfo[] elements = <AnimatedRoomInfo>k__BackingField.Elements;
					if (<AnimatedRoomInfo>k__BackingField.Elements != null)
					{
						bool flag = a < elements.Length;
						object obj = !flag;
						if (obj == null)
						{
							bool flag2 = b < elements.Length;
							object obj2 = !flag2;
							if (obj2 == null)
							{
								object obj3 = <AnimatedRoomInfo>k__BackingField.Elements + 32;
								object obj4 = a * 96;
								object obj5 = obj3 + obj4;
								object obj6 = b * 96;
								object obj7 = obj3 + obj6;
								int num = obj5 + 80;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v7+50]");
								return ((int*)num)->CompareTo(0);
							}
						}
						goto IL_015c;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_015c;
			IL_015c:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
		}
	}

	private const float POPUP_SCALE = 0.66f;

	private const float POPUP_JACKAROO_BOARD_SCALE = 0.5f;

	private const float POPUP_JACKAROO_BOARD_TILT_DEGREES = 30f;

	private Transform animatedElementsParent;

	public Image itemImage;

	public Image itemTitleImage;

	public RotatingLoadingIndicator imageLoadingIndicator;

	public StoreItem currentItem;

	private AnimatedRoomElementFactory factory;

	private bool _isRoomItemLoaded;

	private bool _isRoomItemTitleLoaded;

	private bool _isAnimatedItemsLoaded;

	private int? _templateId;

	private readonly List<GameObject> _animatedElements;

	private int _loadGeneration;

	public bool IsRoomAnimated => StoreItemExtensions.IsAnimatedRoomTheme(currentItem);

	private void OnDisable()
	{
		int loadGeneration = _loadGeneration + 1;
		_loadGeneration = loadGeneration;
		ClearAnimatedElements();
	}

	public void PopulateRoomItem(StoreItem item, bool isPopup, int? tempId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0029: Expected O, but got I
		object obj = this + 64;
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X22_v2+28]");
		object obj2 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		_ = 0;
		if (isPopup)
		{
			LoadPopupContent();
		}
		else
		{
			LoadItemContent();
		}
	}

	public void ResetContent()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6947]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			obj5 = itemImage;
			obj6 = itemImage;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = itemImage;
			obj6 = itemImage;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		_isRoomItemLoaded = false;
		itemImage.enabled = false;
		return;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0154;
	}

	public void OpenRoomItem()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1408;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoomItemPopup.ShowRoomItemPopup(currentItem, isPurchasable: true, _templateId);
	}

	public void OpenUnPurchasableRoomItem()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1408;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoomItemPopup.ShowRoomItemPopup(currentItem, isPurchasable: false, _templateId);
	}

	private void LoadItemContent()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_0062: Expected I, but got O
		//IL_00a4: Expected O, but got I
		//IL_00bc: Expected I, but got O
		imageLoadingIndicator.StartLoading();
		_isAnimatedItemsLoaded = true;
		StoreItem storeItem = currentItem;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)2928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		UIExtensions.LoadItemImage(itemImage, storeItem.<id>k__BackingField, ImageCacher.ItemImageType.StorePreview, FilterMode.Point, action);
		StoreItem storeItem2 = currentItem;
		object obj3 = (nint)0 + (nint)2936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action2 = default(Action<bool>);
		action2..ctor((object)this, (IntPtr)obj3);
		UIExtensions.LoadItemImage(itemTitleImage, storeItem2.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle, FilterMode.Point, action2);
	}

	private void LoadPopupContent()
	{
		//IL_0041: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_0121: Expected I, but got O
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I4
		//IL_0162: Expected O, but got I
		//IL_017a: Expected I, but got O
		//IL_01b4: Expected O, but got I4
		imageLoadingIndicator.StartLoading();
		bool isTablet = ScreenUtility.IsTablet;
		bool flag = StoreItemExtensions.IsAnimatedRoomTheme(currentItem);
		bool flag2 = !flag;
		object obj = 0;
		if (!flag2)
		{
			StoreItem storeItem = currentItem;
			ITrackEvent trackEvent = TrackerLibrary.StoreAnimatedRoomThemeViewed(storeItem.<id>k__BackingField, storeItem.<name>k__BackingField);
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			obj = 0;
		}
		LoadAnimatedElements();
		StoreItem storeItem2 = currentItem;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj6 = (nint)0 + (nint)2952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj6);
		UIExtensions.LoadItemImage(itemImage, storeItem2.<id>k__BackingField, isTablet ? ImageCacher.ItemImageType.InGameLandscape : ImageCacher.ItemImageType.InGame, FilterMode.Point, action);
		StoreItem storeItem3 = currentItem;
		object obj7 = (nint)0 + (nint)2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action2 = default(Action<bool>);
		action2..ctor((object)this, (IntPtr)obj7);
		UIExtensions.LoadItemImage(itemTitleImage, storeItem3.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle, FilterMode.Point, action2);
	}

	private void LoadAnimatedElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_0138: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (StoreItemExtensions.IsAnimatedRoomTheme(currentItem))
		{
			_ = _loadGeneration;
			object obj4 = typeof(Queue<string>) + 688;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = (nint)0 + (nint)1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			StoreItem storeItem = currentItem;
			GameObject go = base.gameObject;
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)888;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj9);
			AnimatedAssetsLoader animatedAssetsLoader = default(AnimatedAssetsLoader);
			animatedAssetsLoader.LoadAnimatedRoomElements(storeItem.<id>k__BackingField, go, action);
		}
		else
		{
			_isAnimatedItemsLoaded = true;
			FinishLoading();
		}
	}

	private static int[] SortElementsBySortOrder(AnimatedRoomDataModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_0222: Expected I, but got O
		//IL_00f3: Expected O, but got I4
		//IL_010d: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_0144: Expected O, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int[] array = default(int[]);
		object obj6;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj3 != null)
			{
				object obj4 = typeof(TypeConverter<ushort, char>) + 3048;
				int elementCount = ((AnimatedRoomDataModel)obj3).ElementCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				if (array != null)
				{
					object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3368;
					obj6 = (nint)0 + (nint)896;
					if (array.Length >= 1)
					{
						object obj7 = array.Length & 0x7FFFFFFF;
						bool flag = (nint)obj7 < 8;
						object obj8 = !flag;
						object obj9;
						object obj11;
						object obj13;
						object obj15;
						object obj17;
						object obj16 = default(object);
						if (obj8 == null)
						{
							object obj10 = default(object);
							obj9 = obj10;
							object obj12 = default(object);
							obj11 = obj12;
							object obj14 = default(object);
							obj13 = obj14;
							obj15 = obj16;
							obj17 = 0;
						}
						else
						{
							obj17 = array.Length & 0x7FFFFFF8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70185E0]");
							obj15 = 0;
							object obj18 = array + 48;
							object obj19 = obj17;
							object obj20 = default(object);
							obj19 = obj20;
							obj15 = obj16;
							object obj21 = default(object);
							obj18 = obj21;
							do
							{
								obj9 = obj15 + 4;
								obj18 = obj9;
								obj15 += 8;
								obj18 += 32;
								obj19 -= 8;
							}
							while ((nint)obj19 != 8);
							bool flag2 = obj7 == obj17;
							obj11 = 8;
							obj13 = 4;
							object obj10 = obj9;
							object obj12 = 8;
							object obj14 = 4;
							obj16 = obj15;
							if (flag2)
							{
								goto IL_0207;
							}
						}
						object obj22 = array + 32;
						object obj23 = default(object);
						obj17 = obj23;
						bool flag3;
						do
						{
							obj17++;
							flag3 = obj7 != obj17;
							object obj10 = obj9;
							object obj12 = obj11;
							object obj14 = obj13;
							obj16 = obj15;
						}
						while (flag3);
					}
					goto IL_0207;
				}
			}
		}
		return (int[])(object)new NullReferenceException();
		IL_0207:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Comparison<int> comparison = default(Comparison<int>);
		comparison..ctor(obj2, (IntPtr)obj6);
		Array.Sort(array, comparison);
		return array;
	}

	private unsafe AnimatedRoomElementInfo RemapAnimatedInfoToPopupPreview(AnimatedRoomElementInfo info)
	{
		//IL_005f: Expected native int or pointer, but got O
		//IL_00f0: Expected native int or pointer, but got O
		//IL_0102: Expected native int or pointer, but got O
		//IL_0114: Expected native int or pointer, but got O
		//IL_0126: Expected native int or pointer, but got O
		//IL_0138: Expected native int or pointer, but got O
		//IL_014a: Expected native int or pointer, but got O
		//IL_015c: Expected native int or pointer, but got O
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0086: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_00c0: Expected native int or pointer, but got O
		AnimatedRoomElementInfo animatedRoomElementInfo = default(AnimatedRoomElementInfo);
		AnimatedRoomElementInfo result;
		if (animatedRoomElementInfo.isJackarooBoard)
		{
			object obj = typeof(UsageHint) + 816;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v7+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v8+38]");
			double num = 0.0 * 30.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v8+30]");
			Vector3 rotation = (Vector3)((nint)0 * (nint)0);
			((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->rotation = rotation;
			result = (AnimatedRoomElementInfo)this;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj4 = default(object);
			Vector2 tabletSize = (Vector2)((object)animatedRoomElementInfo.tabletSize * obj4);
			((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->tabletSize = tabletSize;
			result = (AnimatedRoomElementInfo)this;
		}
		object obj5 = default(object);
		float width = animatedRoomElementInfo.width * (float)obj5;
		((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->width = width;
		AnimatedRoomElementInfo animatedRoomElementInfo2 = default(AnimatedRoomElementInfo);
		((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo2)->loopCount = animatedRoomElementInfo.loopCount;
		((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo2)->sortOrder = animatedRoomElementInfo.sortOrder;
		((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo2)->type = animatedRoomElementInfo.type;
		((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo2)->pivotPosition = animatedRoomElementInfo.pivotPosition;
		((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo2)->rotation = animatedRoomElementInfo.rotation;
		((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo2)->height = animatedRoomElementInfo.height;
		return result;
	}

	private void FinishLoading()
	{
		//IL_00af: Expected O, but got I
		if (_isRoomItemLoaded && _isRoomItemTitleLoaded && _isAnimatedItemsLoaded)
		{
			itemTitleImage.enabled = true;
			itemImage.enabled = true;
			Transform target = itemTitleImage.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target, 0f, 0.8f);
			object obj = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			imageLoadingIndicator.FinishLoading();
		}
	}

	private void ClearAnimatedElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00ca: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		((List<object>)(object)_animatedElements).ForEach(action);
		List<GameObject> animatedElements = _animatedElements;
		int version = animatedElements._version + 1;
		animatedElements._size = 0;
		animatedElements._version = version;
		if (animatedElements._size >= 1)
		{
			Array.Clear(animatedElements._items, 0, animatedElements._size);
		}
	}

	public RoomItem()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 96;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <LoadItemContent>b__22_0(bool success)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0050: Expected O, but got I
		//IL_005e: Expected I, but got O
		if (success)
		{
			_isRoomItemLoaded = true;
			FinishLoading();
			return;
		}
		StoreItem storeItem = currentItem;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = (nint)0 + (nint)2944;
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		UIExtensions.LoadItemImage(itemImage, storeItem.<id>k__BackingField, ImageCacher.ItemImageType.InGame, FilterMode.Point, action);
	}

	private void <LoadItemContent>b__22_2(bool fallbackSuccess)
	{
		if (fallbackSuccess)
		{
			_isRoomItemLoaded = true;
		}
		FinishLoading();
	}

	private void <LoadItemContent>b__22_1(bool success)
	{
		if (success)
		{
			_isRoomItemTitleLoaded = true;
		}
		FinishLoading();
	}

	private void <LoadPopupContent>b__23_0(bool success)
	{
		if (success)
		{
			_isRoomItemLoaded = true;
		}
		FinishLoading();
	}

	private void <LoadPopupContent>b__23_1(bool success)
	{
		if (success)
		{
			_isRoomItemTitleLoaded = true;
		}
		FinishLoading();
	}
}
