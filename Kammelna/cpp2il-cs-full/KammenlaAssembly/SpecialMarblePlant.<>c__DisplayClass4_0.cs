using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Jackaroo;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SpecialMarblePlant : ICustomMarbleMove
{
	private sealed class <>c__DisplayClass4_0
	{
		public JackarooMarbleMono marbleMono;

		public JackarooNodeMono homeNode;

		public Transform marbleShadowTransform;

		public Vector3 shadowLocalPosition;

		public Transform board;

		public Transform playGround;

		public SpecialMarblePlant <>4__this;

		public Transform effectsLayer;

		public JackarooMarble marble;

		internal void <Move>b__0()
		{
			//IL_002c: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_0151: Expected O, but got I
			//IL_0167: Expected O, but got I
			//IL_01b5: Expected O, but got I
			//IL_01f0: Expected O, but got I4
			//IL_0184: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_020f: Expected O, but got I
			//IL_024a: Expected O, but got I4
			//IL_00a2: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			JackarooMarbleMono jackarooMarbleMono = marbleMono;
			Vector3 position = homeNode.Position;
			jackarooMarbleMono.<Transform>k__BackingField.position = (Vector3)0;
			marbleShadowTransform.localPosition = (Vector3)0;
			object obj = typeof(UsageHint) + 816;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v7+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v9+18]");
			object obj4 = (nint)0 * (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v9+3C]");
			object obj5 = (nint)0 * (nint)0;
			float randomness = (float)obj4 + (float)obj5;
			Tweener tweener = ShortcutExtensions.DOShakePosition(board, 0.5f, (Vector3)35, 1, randomness, snapping: true, fadeOut: false);
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v12+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v14+18]");
			object obj8 = (nint)0 * (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v14+3C]");
			object obj9 = (nint)0 * (nint)0;
			float randomness2 = (float)obj8 + (float)obj9;
			Tweener tweener2 = ShortcutExtensions.DOShakePosition(playGround, 0.5f, (Vector3)35, 1, randomness2, snapping: true, fadeOut: false);
			SpecialMarblePlant specialMarblePlant = <>4__this;
			Transform transform = specialMarblePlant.boardCrackEffect.transform;
			transform.parent = effectsLayer;
			Vector3 position2 = homeNode.Position;
			transform.position = (Vector3)0;
			transform.localEulerAngles = (Vector3)0;
			SpecialMarblePlant specialMarblePlant2 = <>4__this;
			specialMarblePlant2.boardCrackEffect.Play();
			marbleMono.PlaySmokeEffect2();
			JackarooMarbleMono jackarooMarbleMono2 = marbleMono;
			object name = "Read object reference Id '{0}' for {1}." + 3096;
			int sortingLayerID = SortingLayer.NameToID((string)name);
			jackarooMarbleMono2.<MarbleCanvas>k__BackingField.sortingLayerID = sortingLayerID;
		}
	}

	private ParticleSystem boardCrackEffect;

	private Vector3[] boardEffectPlacements;

	private AudioSource audio;

	private float delay;

	public unsafe override (DG.Tweening.Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip) Move(JackarooMarble marble, float duration, JackarooNodeMono[] nodes, int index, Transform board, Transform playGround, Transform effectsLayer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0103: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_029f: Expected O, but got I
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0325: Expected O, but got I
		//IL_033a: Expected O, but got I
		//IL_0364: Expected O, but got I4
		//IL_0418: Expected O, but got I4
		//IL_0418: Expected O, but got I
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0654: Expected O, but got I
		//IL_0683: Expected O, but got I4
		//IL_0473: Expected O, but got I4
		//IL_06df: Expected O, but got I
		//IL_071c: Expected O, but got I4
		//IL_074f: Expected O, but got I
		//IL_0770: Expected O, but got I
		//IL_07bb: Expected O, but got I4
		//IL_0807: Expected O, but got I
		//IL_083e: Expected O, but got I
		//IL_0855: Expected O, but got I4
		//IL_0888: Expected O, but got I
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_053e: Expected O, but got I
		//IL_056f: Expected I, but got O
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_05bc: Expected O, but got I4
		//IL_05d2: Expected native int or pointer, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 56;
			obj3 = board;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 64;
			obj4 = playGround;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 72;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 80;
			obj6 = effectsLayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 88;
			obj7 = marble;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj7;
			if (obj7 != null)
			{
				object obj9 = obj2 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v5+18]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj10 = obj9;
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v6+48]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v6+48]");
						Transform target = ((Component)0).transform;
						object obj11 = obj9;
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7+60]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7+60]");
								Transform transform = ((Component)0).transform;
								object obj12 = obj2 + 32;
								obj12 = transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								if (obj12 != null)
								{
									Vector3 localPosition = ((Transform)obj12).localPosition;
									if (nodes != null)
									{
										if (nodes.Length == 0)
										{
											goto IL_05ef;
										}
										object obj13 = obj2 + 24;
										obj13 = nodes[0];
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v4-8]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v4-8]");
										if ((nint)0 != 0)
										{
											object obj15 = "ThisIsFakeReceiptData" + 3656;
											int sortingLayerID = SortingLayer.NameToID((string)obj15);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v9+50]");
											if ((nint)0 != 0)
											{
												object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
												object obj17 = (nint)0 + (nint)2784;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v9+50]");
												((Canvas)0).sortingLayerID = sortingLayerID;
												object obj18 = obj16;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v37+E4]");
												bool flag = (nint)0 == 0;
												object obj19 = !flag;
												if (obj19 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												DG.Tweening.Sequence sequence = DOTween.Sequence();
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
												object obj20 = obj9;
												if (obj9 != null && obj13 != null)
												{
													float num = duration * 1.06032006E+09f;
													Vector3 position = ((JackarooNodeMono)obj13).Position;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v11+30]");
													TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOMove((Transform)0, (Vector3)0, 0.7f);
													DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
													object obj21 = typeof(UsageHint) + 816;
													float num2 = duration - num;
													object obj22 = obj21;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v14+B8]");
													object obj23 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v15+18]");
													float duration2 = 0f * 0f;
													TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOLocalMove(target, (Vector3)0, duration2);
													DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t2);
													TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(target, 15f, num);
													DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.Join(sequence, t3);
													TweenerCore<Vector3, Vector3, VectorOptions> t4 = ShortcutExtensions.DOScale((Transform)obj12, (Vector3)0, 10f);
													DG.Tweening.Sequence sequence5 = TweenSettingsExtensions.Join(sequence, t4);
													float duration3 = num2 * 1.06199776E+09f;
													object obj24 = obj21;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v18+B8]");
													object obj25 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v19+24]");
													float duration4 = 0f * 10f;
													Tweener t5 = ShortcutExtensions.DOBlendableLocalMoveBy((Transform)obj12, (Vector3)0, duration4);
													DG.Tweening.Sequence sequence6 = TweenSettingsExtensions.Join(sequence, t5);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7+60]");
													TweenerCore<Color, Color, ColorOptions> t6 = DOTweenModuleUI.DOFade((Image)0, 0.25f, num);
													DG.Tweening.Sequence sequence7 = TweenSettingsExtensions.Join(sequence, t6);
													object obj26 = obj21;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v23+B8]");
													object obj27 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v24+24]");
													float duration5 = 0f * 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v24+2C]");
													double num3 = 0.0 * 10.0;
													TweenerCore<Vector3, Vector3, VectorOptions> t7 = ShortcutExtensions.DOLocalMove(target, (Vector3)0, duration5);
													DG.Tweening.Sequence sequence8 = TweenSettingsExtensions.Append(sequence, t7);
													TweenerCore<Vector3, Vector3, VectorOptions> t8 = ShortcutExtensions.DOScale((Transform)obj12, 1f, duration3);
													DG.Tweening.Sequence sequence9 = TweenSettingsExtensions.Join(sequence, t8);
													object obj28 = obj21;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v27+B8]");
													object obj29 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v28+18]");
													float duration6 = 0f * (float)num3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v28+20]");
													object obj30 = (nint)0 * (nint)1128792064;
													Tweener t9 = ShortcutExtensions.DOBlendableLocalMoveBy((Transform)obj12, (Vector3)0, duration6);
													DG.Tweening.Sequence sequence10 = TweenSettingsExtensions.Join(sequence, t9);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7+60]");
													TweenerCore<Color, Color, ColorOptions> t10 = DOTweenModuleUI.DOFade((Image)0, 1f, duration3);
													DG.Tweening.Sequence sequence11 = TweenSettingsExtensions.Join(sequence, t10);
													TweenerCore<Vector3, Vector3, VectorOptions> t11 = ShortcutExtensions.DOScale(target, 1f, duration3);
													DG.Tweening.Sequence sequence12 = TweenSettingsExtensions.Join(sequence, t11);
													if ((object)audio != null)
													{
														object obj31 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
														object obj32 = (nint)0 + (nint)608;
														audio.PlayDelayed(delay);
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														TweenCallback tweenCallback = default(TweenCallback);
														tweenCallback..ctor(obj2, (IntPtr)obj32);
														if (sequence != null)
														{
															object obj33 = sequence + 128;
															obj33 = tweenCallback;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															_ = 0;
															(DG.Tweening.Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip) tuple = ((DG.Tweening.Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip))0;
															_ = 0;
															System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (ValueTuple<object, bool, object, object, object>)(sequence, false, null, null, null));
															return tuple;
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
		NullReferenceException ex = new NullReferenceException();
		goto IL_05ef;
		IL_05ef:
		return ((DG.Tweening.Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip))new IndexOutOfRangeException();
	}

	private static float GetAngleByPlayerIndex(int playerIndex)
	{
		//IL_000e: Expected O, but got I4
		object obj = playerIndex - 1;
		return (float)obj * 1.1190927E+09f;
	}
}
