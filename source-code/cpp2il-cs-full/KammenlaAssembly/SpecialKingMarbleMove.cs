using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Jackaroo;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SpecialKingMarbleMove : ICustomMarbleMove
{
	private sealed class <>c__DisplayClass25_0
	{
		public SpecialKingMarbleMove <>4__this;

		public JackarooMarble target;

		public int index;

		public JackarooNodeMono[] nodes;

		public Transform board;

		public Transform playGround;

		public Transform effectsLayer;

		internal void <Move>b__0()
		{
			SpecialKingMarbleMove specialKingMarbleMove = <>4__this;
			GameObject gameObject = specialKingMarbleMove.circularFire.gameObject;
			gameObject.SetActive(value: true);
			SpecialKingMarbleMove specialKingMarbleMove2 = <>4__this;
			specialKingMarbleMove2.audio.PlayOneShot(specialKingMarbleMove2.flameBurstClip);
		}

		internal void <Move>b__1()
		{
			SpecialKingMarbleMove specialKingMarbleMove = <>4__this;
			specialKingMarbleMove.audio.PlayOneShot(specialKingMarbleMove.flamesClip);
		}

		internal void <Move>b__2()
		{
			//IL_0067: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_0103: Expected O, but got I4
			//IL_0137: Expected O, but got I4
			//IL_016b: Expected O, but got I4
			//IL_022a: Expected O, but got I4
			//IL_026d: Expected O, but got I4
			JackarooMarble jackarooMarble = target;
			Transform transform = jackarooMarble.<MarbleMono>k__BackingField.transform;
			Vector3 position = transform.position;
			SpecialKingMarbleMove specialKingMarbleMove = <>4__this;
			Transform transform2 = specialKingMarbleMove.marbleFire.transform;
			transform2.position = (Vector3)0;
			SpecialKingMarbleMove specialKingMarbleMove2 = <>4__this;
			Transform transform3 = specialKingMarbleMove2.marbleGlow.transform;
			transform3.position = (Vector3)0;
			SpecialKingMarbleMove specialKingMarbleMove3 = <>4__this;
			Transform transform4 = specialKingMarbleMove3.fireSmokeTrail.transform;
			transform4.position = (Vector3)0;
			SpecialKingMarbleMove specialKingMarbleMove4 = <>4__this;
			Transform transform5 = specialKingMarbleMove4.maskDrawer.transform;
			transform5.position = (Vector3)0;
			SpecialKingMarbleMove specialKingMarbleMove5 = <>4__this;
			Transform transform6 = specialKingMarbleMove5.dustSmoke.transform;
			transform6.position = (Vector3)0;
			SpecialKingMarbleMove specialKingMarbleMove6 = <>4__this;
			Transform transform7 = specialKingMarbleMove6.brokenWoodParticle.transform;
			transform7.position = (Vector3)0;
			SpecialKingMarbleMove specialKingMarbleMove7 = <>4__this;
			GameObject gameObject = specialKingMarbleMove7.marbleFire.gameObject;
			gameObject.SetActive(value: true);
			SpecialKingMarbleMove specialKingMarbleMove8 = <>4__this;
			GameObject gameObject2 = specialKingMarbleMove8.marbleGlow.gameObject;
			gameObject2.SetActive(value: true);
			SpecialKingMarbleMove specialKingMarbleMove9 = <>4__this;
			if (!specialKingMarbleMove9._isStarted)
			{
				Transform transform8 = specialKingMarbleMove9.smokeBurst.transform;
				transform8.position = (Vector3)0;
				SpecialKingMarbleMove specialKingMarbleMove10 = <>4__this;
				Transform transform9 = specialKingMarbleMove10.smokeBurst.transform;
				float num = <Move>g__GetAngleToNextNode|4();
				transform9.eulerAngles = (Vector3)0;
				SpecialKingMarbleMove specialKingMarbleMove11 = <>4__this;
				specialKingMarbleMove11.smokeBurst.Play();
				SpecialKingMarbleMove specialKingMarbleMove12 = <>4__this;
				specialKingMarbleMove12.fireSmokeTrail.Play();
				SpecialKingMarbleMove specialKingMarbleMove13 = <>4__this;
				specialKingMarbleMove13.maskDrawer.Play();
				SpecialKingMarbleMove specialKingMarbleMove14 = <>4__this;
				specialKingMarbleMove14.brokenWoodParticle.Play();
				SpecialKingMarbleMove specialKingMarbleMove15 = <>4__this;
				specialKingMarbleMove15.dustSmoke.Play();
				SpecialKingMarbleMove specialKingMarbleMove16 = <>4__this;
				specialKingMarbleMove16._isStarted = true;
			}
		}

		internal void <Move>b__3()
		{
			//IL_001f: Expected O, but got I4
			JackarooNodeMono[] array = nodes;
			object obj = array.Length - 1;
			if (index == (nint)obj)
			{
				<>4__this.OnArrived();
			}
		}

		internal float <Move>g__GetAngleToNextNode|4()
		{
			//IL_0015: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_009e: Expected O, but got I
			//IL_00af: Expected O, but got I
			//IL_00f9: Expected O, but got I4
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_014e: Expected O, but got I
			//IL_0168: Expected O, but got I
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_037a: Expected O, but got I4
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_01af: Expected O, but got I
			//IL_03e9: Expected O, but got I4
			//IL_029c: Invalid comparison between F4 and I4
			//IL_044e: Expected O, but got I
			//IL_045e: Expected F4, but got I
			//IL_046e: Expected F4, but got I
			//IL_0476: Expected F4, but got O
			//IL_048c: Expected O, but got I
			//IL_04a6: Expected O, but got I4
			//IL_04ae: Expected F4, but got O
			//IL_04be: Expected F4, but got I
			//IL_04ce: Expected F4, but got I
			//IL_0558: Expected F4, but got I
			//IL_02f6: Expected O, but got I
			JackarooNodeMono[] array = nodes;
			object obj4;
			object obj10;
			float num;
			float num2 = default(float);
			object obj15;
			object obj16 = default(object);
			object obj17;
			object obj18 = default(object);
			object obj21;
			float num3;
			object obj22;
			object obj19;
			if (nodes != null)
			{
				object obj = index + 1;
				bool flag = (nint)obj < array.Length;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_050d;
				}
				object obj3 = (object)nodes + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+20]");
				if ((nint)0 != 0)
				{
					obj4 = typeof(UsageHint) + 816;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+B8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+20]");
					Vector3 position = ((JackarooNodeMono)0).Position;
					JackarooNodeMono[] array2 = nodes;
					if (nodes != null)
					{
						bool flag2 = index < array2.Length;
						object obj7 = !flag2;
						if (obj7 != null)
						{
							goto IL_050d;
						}
						object obj8 = nodes + index;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+20]");
							Vector3 position2 = ((JackarooNodeMono)0).Position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
							object obj9 = (nint)0 & (nint)1;
							object obj12;
							if (obj9 != null)
							{
								obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
								object obj11 = (nint)0 & (nint)1;
								bool flag3 = obj11 == null;
								obj12 = obj10;
								if (!flag3)
								{
									goto IL_01d4;
								}
							}
							else
							{
								_ = 1;
								obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
								object obj13 = (nint)0 & (nint)1;
								bool flag4 = obj13 == null;
								object obj14 = !flag4;
								obj12 = obj10;
								if (obj14 != null)
								{
									goto IL_01d4;
								}
							}
							_ = 1;
							num = num2 - num2;
							obj15 = obj16 - obj16;
							obj17 = obj18 - obj18;
							obj19 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v10+E4]");
							bool flag5 = (nint)0 == 0;
							object obj20 = !flag5;
							obj21 = obj15;
							num3 = num;
							obj22 = obj17;
							if (obj20 != null)
							{
								goto IL_0242;
							}
							goto IL_040f;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_050d;
			IL_040f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj21;
			num = num3;
			obj17 = obj22;
			goto IL_0242;
			IL_04dc:
			_ = 1;
			float num5;
			float num4 = num5;
			float num7;
			float num6 = num7;
			float num9;
			float num8 = num9;
			goto IL_0541;
			IL_0541:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @513A294");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+24]");
			return 0f;
			IL_0242:
			float num10 = num * num;
			object obj23 = obj15 * obj15;
			float num11 = num10 + (float)obj23;
			object obj24 = obj17 * obj17;
			float num12 = (float)obj24 + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			if (num12 > 925353400f)
			{
				num5 = num / num12;
				num7 = (float)obj15 / num12;
				num9 = (float)obj17 / num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CB]");
				object obj25 = (nint)0 & (nint)1;
				if (obj25 == null)
				{
					goto IL_04dc;
				}
				num4 = num5;
				num6 = num7;
				num8 = num9;
			}
			else
			{
				object obj26 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v26+B8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27+4]");
				num7 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27+8]");
				num9 = 0f;
				num5 = (float)obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CB]");
				object obj28 = (nint)0 & (nint)1;
				bool flag6 = obj28 == null;
				object obj29 = !flag6;
				num4 = (float)obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27+4]");
				num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27+8]");
				num8 = 0f;
				if (obj29 == null)
				{
					goto IL_04dc;
				}
			}
			goto IL_0541;
			IL_01d4:
			num = num2 - num2;
			obj15 = obj16 - obj16;
			obj17 = obj18 - obj18;
			obj19 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v10+E4]");
			bool flag7 = (nint)0 == 0;
			obj21 = obj15;
			num3 = num;
			obj22 = obj17;
			if (!flag7)
			{
				goto IL_0242;
			}
			goto IL_040f;
			IL_050d:
			throw new IndexOutOfRangeException();
		}

		internal void <Move>g__OnStepAction|5(JackarooMarble marble, JackarooNode node)
		{
			Transform transform = default(Transform);
			Transform transform2 = default(Transform);
			Transform transform3 = default(Transform);
			<>4__this.CustomDeath(target, marble.<MarbleMono>k__BackingField, node, transform, transform2, transform3);
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public JackarooMarbleMono marbleToDie;

		internal void <CustomDeath>b__0()
		{
			marbleToDie.SetMoveTrailActiveState(active: true);
		}

		internal void <CustomDeath>b__1()
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			marbleToDie.PlaySmokeEffect2();
			marbleToDie.SetMoveTrailActiveState(active: false);
			JackarooMarbleMono jackarooMarbleMono = marbleToDie;
			object name = "Read object reference Id '{0}' for {1}." + 3096;
			int sortingLayerID = SortingLayer.NameToID((string)name);
			jackarooMarbleMono.<MarbleCanvas>k__BackingField.sortingLayerID = sortingLayerID;
		}
	}

	public float durationScale = 1f;

	public AnimationCurve durationCurve;

	private float delay = 0.5f;

	private ParticleSystem marbleFire;

	private Transform marbleGlow;

	private ParticleSystem smokeBurst;

	private ParticleSystem fireSmokeTrail;

	private ParticleSystem maskDrawer;

	private ParticleSystem hit;

	private ParticleSystem brokenWoodParticle;

	private ParticleSystem fireBurstHit;

	private ParticleSystem dustSmoke;

	private GameObject circularFire;

	private AudioSource audio;

	private AudioClip hitMarbleClip;

	private AudioClip flameBurstClip;

	private AudioClip flamesClip;

	private GameEventsChannel gameEventsChannel;

	private bool _isStarted;

	private float deathDuration = 0.7f;

	private static Camera textureRendererCamera
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_021c: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_02a2: Expected O, but got I4
			//IL_024a: Expected O, but got I
			//IL_0264: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Expected O, but got Unknown
			//IL_014f: Expected O, but got I4
			//IL_02da: Expected O, but got I
			//IL_02fc: Expected O, but got I4
			//IL_0183: Expected O, but got I
			//IL_01ba: Expected O, but got I
			//IL_01ec: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(SqlSingle[]) + 3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B96]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v14+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_0272;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v26+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			goto IL_0102;
			IL_0102:
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 136;
			object obj11 = obj10;
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v16+130]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X1_v2+130]");
			bool flag3 = num < 0;
			object obj13 = !flag3;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v16+C8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X1_v2+130]");
				object obj15 = num2 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v19-8]");
				if (0 == (nint)obj11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v23+78]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v23+78]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v21+158]");
						return (Camera)0;
					}
					return null;
				}
			}
			return (Camera)(object)new InvalidCastException();
			IL_02b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v7+B8]");
			object obj18 = 0;
			obj9 = obj18;
			bool flag4 = obj18 == null;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0102;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj20 = (nint)0 & (nint)1;
			if (obj20 != null)
			{
				goto IL_00b0;
			}
			goto IL_0272;
			IL_0272:
			_ = 1;
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v26+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			object obj23 = obj21;
			if (obj22 != null)
			{
				goto IL_00e5;
			}
			goto IL_02b8;
			IL_00b0:
			obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v26+E4]");
			bool flag6 = (nint)0 == 0;
			obj23 = obj21;
			if (!flag6)
			{
				goto IL_00e5;
			}
			goto IL_02b8;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPerspectiveTopDown = Preferences.IsPerspectiveTopDown;
		OnGamePerspectiveChanged(isPerspectiveTopDown);
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)1784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnGamePerspectiveChanged += action;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)1784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnGamePerspectiveChanged -= action;
	}

	private void OnGamePerspectiveChanged(bool isTopDown)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0219: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_0022: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_011d: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_0066: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00c8: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3832;
		bool isTablet = ScreenUtility.IsTablet;
		bool flag = !isTablet;
		object obj2 = !flag;
		object obj3 = ~obj2;
		object obj4 = ((obj3 != null) ? ((object)1141145600) : ((object)1143439360));
		bool flag2 = !isTopDown;
		object obj5 = !flag2;
		object obj6 = ~obj5;
		object obj7 = ((obj6 != null) ? obj4 : ((object)1139113984));
		Camera camera = textureRendererCamera;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 != null)
			{
				goto IL_0083;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj10 = (nint)0 & (nint)1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			if (obj11 != null)
			{
				goto IL_0083;
			}
		}
		_ = 1;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_00b8;
		}
		goto IL_018b;
		IL_01ba:
		float num = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v11+38]");
		float orthographicSize = num * 0f;
		camera.orthographicSize = orthographicSize;
		maskDrawer.Clear();
		return;
		IL_00b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v20+B8]");
		object obj15 = 0;
		object obj16 = obj15;
		bool flag5 = obj15 == null;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ba;
		IL_018b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13+B8]");
		object obj19 = 0;
		obj16 = obj19;
		goto IL_01ba;
		IL_0083:
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v20+E4]");
		bool flag6 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag6)
		{
			goto IL_00b8;
		}
		goto IL_018b;
	}

	public unsafe override (DG.Tweening.Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip) Move(JackarooMarble target, float duration, JackarooNodeMono[] nodes, int index, Transform board, Transform playGround, Transform effectsLayer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_016e: Expected O, but got I
		//IL_0236: Expected O, but got I4
		//IL_04ce: Expected O, but got I
		//IL_0541: Expected O, but got I4
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_02f7: Expected O, but got I4
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05b8: Expected O, but got I
		//IL_05c4: Expected O, but got I
		//IL_05d0: Expected O, but got I
		//IL_05dc: Expected O, but got I
		//IL_05fe: Expected O, but got I
		//IL_0621: Expected O, but got I4
		//IL_0621: Expected O, but got I
		//IL_0645: Expected I, but got O
		//IL_0694: Expected I, but got O
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0356: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_0374: Expected O, but got I4
		//IL_0380: Expected O, but got I
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03b9: Expected O, but got I
		//IL_03ca: Expected I, but got O
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06d1: Expected O, but got I
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_040d: Expected O, but got I4
		//IL_0712: Expected I, but got O
		//IL_0721: Expected O, but got I4
		//IL_073a: Expected native int or pointer, but got O
		//IL_0468: Expected O, but got I
		//IL_0479: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj4;
		object obj5;
		object obj8;
		float num3;
		DG.Tweening.Sequence sequence2;
		DG.Tweening.Sequence sequence3;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = obj2 + 24;
			obj4 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj5 = obj2 + 40;
			obj5 = nodes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 48;
			obj6 = board;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 56;
			obj7 = playGround;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = obj2 + 64;
			obj8 = effectsLayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj5;
			if (obj5 != null && durationCurve != null)
			{
				object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3 (System.Object)+20]");
				double num = 0.0 + 1.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v5+18]");
				object obj11 = 0;
				float num2 = (float)num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v5+18]");
				float time = num2 / 0f;
				num3 = durationCurve.Evaluate(time);
				object obj12 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					DG.Tweening.Sequence sequence = DOTween.Sequence();
					bool flag = !_isStarted;
					sequence2 = sequence;
					if (flag)
					{
						goto IL_0254;
					}
					sequence3 = sequence;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					DG.Tweening.Sequence sequence4 = DOTween.Sequence();
					bool flag2 = !_isStarted;
					object obj13 = !flag2;
					sequence2 = sequence4;
					sequence3 = sequence4;
					if (obj13 == null)
					{
						goto IL_0254;
					}
				}
				goto IL_0499;
			}
		}
		goto IL_0749;
		IL_0499:
		object obj14 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v8+18]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v8+18]");
			if ((nint)0 != 0)
			{
				object obj16 = obj5;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3 (System.Object)+20]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v5+18]");
					bool flag3 = num4 < 0;
					object obj17 = !flag3;
					if (obj17 != null)
					{
						goto IL_0757;
					}
					object obj18 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3 (System.Object)+20]");
					object obj19 = obj18 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v6+20]");
					if ((nint)0 != 0)
					{
						float num5 = duration * num3;
						object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
						object obj21 = (nint)0 + (nint)568;
						object obj22 = (nint)0 + (nint)2680;
						object obj23 = (nint)0 + (nint)2904;
						object obj24 = (nint)0 + (nint)576;
						float num6 = num5 * durationScale;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v6+20]");
						Vector3 position = ((JackarooNodeMono)0).Position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v9+30]");
						TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = JackarooMarbleMono.DoLocalMove((Transform)0, (Vector3)1, num5, snapping: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						TweenCallback tweenCallback = default(TweenCallback);
						tweenCallback..ctor(obj2, (IntPtr)obj21);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30587F0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Tween t = default(Tween);
						DG.Tweening.Sequence sequence5 = TweenSettingsExtensions.Append(sequence3, t);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						TweenCallback tweenCallback2 = default(TweenCallback);
						tweenCallback2..ctor(obj2, (IntPtr)obj24);
						if (sequence5 != null)
						{
							object obj25 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 544;
							object obj26 = (nint)0 + (nint)584;
							object obj27 = sequence5 + 128;
							obj27 = tweenCallback2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							Action<object, object> action = default(Action<object, object>);
							action..ctor(obj2, (IntPtr)obj26);
							_ = 0;
							(DG.Tweening.Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip) tuple = ((DG.Tweening.Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip))0;
							_ = 0;
							System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (ValueTuple<object, bool, object, object, object>)(sequence3, true, null, action, null));
							return tuple;
						}
					}
				}
			}
		}
		goto IL_0749;
		IL_0254:
		if ((object)circularFire != null)
		{
			Transform transform = circularFire.transform;
			if ((object)transform != null)
			{
				transform.parent = (Transform)obj8;
				if ((object)circularFire != null)
				{
					Transform transform2 = circularFire.transform;
					if ((object)transform2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						transform2.localPosition = (Vector3)0;
						if ((object)circularFire != null)
						{
							Transform transform3 = circularFire.transform;
							if ((object)transform3 != null)
							{
								object obj28 = typeof(System.Buffers.Text.ParserHelpers) + 2696;
								object obj29 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v21+B8]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v22+4]");
								object obj11 = 0;
								transform3.localRotation = (Quaternion)0;
								object obj31 = (nint)0 + (nint)2784;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
								object obj32 = typeof(SqlSingle[]) + 2376;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj33 = (nint)0 + (nint)552;
								Action action2 = default(Action);
								action2..ctor(obj2, (IntPtr)obj33);
								object obj34 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
								object obj35 = obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v58+E4]");
								bool flag4 = (nint)0 == 0;
								object obj36 = !flag4;
								if (obj36 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float seconds = delay * 1.0594812E+09f;
								Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj37 = (nint)0 + (nint)560;
								Action action3 = default(Action);
								action3..ctor(obj2, (IntPtr)obj37);
								Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(delay, action3);
								sequence3 = sequence2;
								goto IL_0499;
							}
						}
					}
				}
			}
		}
		goto IL_0749;
		IL_0757:
		return ((DG.Tweening.Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip))new IndexOutOfRangeException();
		IL_0749:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0757;
	}

	private void OnArrived()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0116: Expected O, but got I
		//IL_0122: Expected O, but got I
		//IL_017b: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence s = DOTween.Sequence();
		int num = ShortcutExtensions.DOKill(marbleGlow);
		maskDrawer.Stop();
		brokenWoodParticle.Stop();
		fireSmokeTrail.Stop();
		dustSmoke.Stop();
		GameObject gameObject = circularFire.gameObject;
		gameObject.SetActive(value: false);
		Transform target = marbleFire.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(target, 0f, 0.5f);
		DG.Tweening.Sequence s2 = TweenSettingsExtensions.Append(s, t);
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj5 = (nint)0 + (nint)1776;
		object obj6 = (nint)0 + (nint)2512;
		Transform target2 = marbleGlow.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(target2, 0f, 0.3f);
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(s2, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		_isStarted = false;
	}

	private void CustomDeath(JackarooMarble target, JackarooMarbleMono marbleToDie, JackarooNode homeNode, Transform board, Transform playGround, Transform effectsLayer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0137: Expected O, but got I4
		//IL_01b9: Expected O, but got I4
		//IL_01b9: Expected O, but got I
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_0950: Expected O, but got I
		//IL_097f: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected O, but got Unknown
		//IL_09e1: Expected O, but got I
		//IL_0a1e: Expected O, but got I4
		//IL_0a53: Expected O, but got I
		//IL_0281: Expected O, but got I4
		//IL_0281: Expected O, but got I
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected O, but got Unknown
		//IL_0a7c: Expected O, but got I
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0abc: Expected O, but got I
		//IL_0b07: Expected O, but got I4
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected O, but got Unknown
		//IL_0b67: Expected O, but got I
		//IL_0b9e: Expected O, but got I
		//IL_0bb5: Expected O, but got I4
		//IL_0be8: Expected O, but got I
		//IL_0317: Expected I, but got O
		//IL_0341: Expected O, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_038c: Expected O, but got I
		//IL_03b5: Expected I, but got O
		//IL_03c6: Expected O, but got I
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_0422: Expected O, but got I
		//IL_0439: Expected O, but got I4
		//IL_04ac: Expected O, but got I
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_06bb: Expected O, but got I
		//IL_06d5: Expected O, but got I4
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_04f3: Expected O, but got I
		//IL_0750: Expected O, but got I4
		//IL_05ee: Expected O, but got I4
		//IL_05f7: Invalid comparison between F8 and I4
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07c9: Expected O, but got I
		//IL_07d9: Expected F4, but got I
		//IL_07e9: Expected F8, but got I
		//IL_07f1: Expected F8, but got O
		//IL_0807: Expected O, but got I
		//IL_0821: Expected O, but got I4
		//IL_0829: Expected F8, but got O
		//IL_0839: Expected F4, but got I
		//IL_0849: Expected F8, but got I
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected O, but got Unknown
		//IL_0c1d: Expected O, but got I
		//IL_0c2e: Expected O, but got I
		//IL_0c3f: Expected O, but got I
		//IL_0c50: Expected O, but got I
		//IL_0651: Expected O, but got I
		//IL_08a7: Expected O, but got I
		//IL_08be: Expected O, but got I4
		//IL_08e5: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = marbleToDie;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v4+48]");
		Transform target2 = ((Component)0).transform;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v5+60]");
		Transform target3 = ((Component)0).transform;
		object obj6 = obj3;
		object obj7 = "ThisIsFakeReceiptData" + 3656;
		int sortingLayerID = SortingLayer.NameToID((string)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v6+50]");
		((Canvas)0).sortingLayerID = sortingLayerID;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v7+30]");
		Vector3 position = ((Transform)0).position;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Vector3 position2 = homeNode.<NodeMono>k__BackingField.Position;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v19+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		object obj12 = obj3;
		object obj14 = default(object);
		object obj13 = obj14 - obj14;
		double num = (double)obj13 * 0.5;
		float duration = (float)obj14 + (float)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v9+30]");
		TweenerCore<Vector3, Vector3, VectorOptions> t = JackarooMarbleMono.DoLocalMove((Transform)0, (Vector3)0, duration, snapping: false);
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		object obj15 = typeof(UsageHint) + 816;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v14+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v15+18]");
		float duration2 = 0f * 0f;
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOLocalMove(target2, (Vector3)0, duration2);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t2);
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(target2, 7f, deathDuration);
		DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.Join(sequence, t3);
		TweenerCore<Vector3, Vector3, VectorOptions> t4 = ShortcutExtensions.DOScale(target3, (Vector3)0, 4f);
		DG.Tweening.Sequence sequence5 = TweenSettingsExtensions.Join(sequence, t4);
		object obj18 = typeof(UsageHint) + 816;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v20+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v21+24]");
		float duration3 = 0f * 4f;
		Tweener t5 = ShortcutExtensions.DOBlendableLocalMoveBy(target3, (Vector3)0, duration3);
		DG.Tweening.Sequence sequence6 = TweenSettingsExtensions.Join(sequence, t5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v5+60]");
		TweenerCore<Color, Color, ColorOptions> t6 = DOTweenModuleUI.DOFade((Image)0, 0.25f, deathDuration);
		DG.Tweening.Sequence sequence7 = TweenSettingsExtensions.Join(sequence, t6);
		object obj21 = obj3;
		float num2 = deathDuration * 1.0552869E+09f;
		Vector3 position3 = homeNode.<NodeMono>k__BackingField.Position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v22+30]");
		TweenerCore<Vector3, Vector3, VectorOptions> t7 = JackarooMarbleMono.DoLocalMove((Transform)0, (Vector3)0, 0.45f, snapping: false);
		DG.Tweening.Sequence sequence8 = TweenSettingsExtensions.Append(sequence, t7);
		object obj22 = typeof(SqlSingle[]) + 2376;
		object obj23 = (nint)0 + (nint)592;
		object obj24 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj25 = typeof(UsageHint) + 816;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v27+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v28+24]");
		float duration4 = 0f * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v28+2C]");
		double num3 = 0.0 * 5.0;
		TweenerCore<Vector3, Vector3, VectorOptions> t8 = ShortcutExtensions.DOLocalMove(target2, (Vector3)0, duration4);
		DG.Tweening.Sequence sequence9 = TweenSettingsExtensions.Join(sequence, t8);
		TweenerCore<Vector3, Vector3, VectorOptions> t9 = ShortcutExtensions.DOScale(target3, 1f, num2);
		DG.Tweening.Sequence sequence10 = TweenSettingsExtensions.Join(sequence, t9);
		object obj28 = typeof(UsageHint) + 816;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v34+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v35+18]");
		float duration5 = 0f * (float)num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v35+20]");
		object obj31 = (nint)0 * (nint)1128792064;
		Tweener t10 = ShortcutExtensions.DOBlendableLocalMoveBy(target3, (Vector3)0, duration5);
		DG.Tweening.Sequence sequence11 = TweenSettingsExtensions.Join(sequence, t10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v5+60]");
		TweenerCore<Color, Color, ColorOptions> t11 = DOTweenModuleUI.DOFade((Image)0, 1f, num2);
		DG.Tweening.Sequence sequence12 = TweenSettingsExtensions.Join(sequence, t11);
		TweenerCore<Vector3, Vector3, VectorOptions> t12 = ShortcutExtensions.DOScale(target2, 1f, num2);
		DG.Tweening.Sequence sequence13 = TweenSettingsExtensions.Join(sequence, t12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj23);
		object obj32 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v79+E4]");
		bool flag2 = (nint)0 == 0;
		object obj33 = !flag2;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForEndOfFrame(action);
		object obj34 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj35 = (nint)0 + (nint)600;
		((JackarooMarbleMono)obj3).PlayBurnAnimation();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj35);
		object obj36 = (nint)0 + (nint)2408;
		object obj37 = sequence + 128;
		obj37 = tweenCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		Transform transform = hit.transform;
		object obj38 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v38+30]");
		Vector3 position4 = ((Transform)0).position;
		transform.position = (Vector3)0;
		hit.Play();
		JackarooMarbleMono <MarbleMono>k__BackingField = target.<MarbleMono>k__BackingField;
		Vector3 position5 = <MarbleMono>k__BackingField.<Transform>k__BackingField.position;
		JackarooNode <Node>k__BackingField = target.<Node>k__BackingField;
		Vector3 position6 = <Node>k__BackingField.<NodeMono>k__BackingField.Position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
		object obj39 = (nint)0 & (nint)1;
		object obj40;
		object obj42;
		if (obj39 != null)
		{
			obj40 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
			object obj41 = (nint)0 & (nint)1;
			bool flag3 = obj41 == null;
			obj42 = obj40;
			if (!flag3)
			{
				goto IL_0518;
			}
		}
		else
		{
			_ = 1;
			obj40 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
			object obj43 = (nint)0 & (nint)1;
			bool flag4 = obj43 == null;
			object obj44 = !flag4;
			obj42 = obj40;
			if (obj44 != null)
			{
				goto IL_0518;
			}
		}
		_ = 1;
		double num4 = 1.0 - 1.0;
		float num5 = num2 - num2;
		object obj45 = obj31 - obj31;
		object obj46 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v100+E4]");
		bool flag5 = (nint)0 == 0;
		object obj47 = !flag5;
		object obj48 = obj45;
		float num6 = num5;
		double num7 = num4;
		if (obj47 != null)
		{
			goto IL_0592;
		}
		goto IL_0776;
		IL_0592:
		double num8 = num4 * num4;
		float num9 = num5 * num5;
		double num10 = num8 + (double)num9;
		object obj49 = obj45 * obj45;
		double num11 = (double)obj49 + num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj50 = 146599936;
		double num12;
		float num13;
		double num14;
		double num15;
		float num16;
		double num17;
		if (num11 > 925353388.0)
		{
			num12 = num4 / num11;
			num13 = num5 / (float)num11;
			num14 = (double)obj45 / num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C9]");
			object obj51 = (nint)0 & (nint)1;
			if (obj51 == null)
			{
				goto IL_0857;
			}
			num15 = num12;
			num16 = num13;
			num17 = num14;
		}
		else
		{
			object obj52 = typeof(UsageHint) + 816;
			object obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v74+B8]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v75+4]");
			num13 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v75+8]");
			num14 = 0.0;
			num12 = (double)obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X21_v21+C9]");
			object obj55 = (nint)0 & (nint)1;
			bool flag6 = obj55 == null;
			object obj56 = !flag6;
			num15 = (double)obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v75+4]");
			num16 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v75+8]");
			num17 = 0.0;
			if (obj56 == null)
			{
				goto IL_0857;
			}
		}
		goto IL_0bf1;
		IL_0bf1:
		object obj57 = typeof(UsageHint) + 816;
		object obj58 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v54+B8]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v55+18]");
		object obj60 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v55+1C]");
		object obj61 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v55+20]");
		object obj62 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @513A294");
		Transform transform2 = fireBurstHit.transform;
		object obj63 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v57+30]");
		Vector3 position7 = ((Transform)0).position;
		transform2.position = (Vector3)0;
		Transform transform3 = fireBurstHit.transform;
		transform3.eulerAngles = (Vector3)0;
		fireBurstHit.Play();
		audio.PlayOneShot(hitMarbleClip);
		return;
		IL_0776:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj45 = obj48;
		num5 = num6;
		num4 = num7;
		goto IL_0592;
		IL_0518:
		num4 = 1.0 - 1.0;
		num5 = num2 - num2;
		obj45 = obj31 - obj31;
		obj46 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v100+E4]");
		bool flag7 = (nint)0 == 0;
		obj48 = obj45;
		num6 = num5;
		num7 = num4;
		if (!flag7)
		{
			goto IL_0592;
		}
		goto IL_0776;
		IL_0857:
		_ = 1;
		num15 = num12;
		num16 = num13;
		num17 = num14;
		goto IL_0bf1;
	}

	private void <OnArrived>b__26_0()
	{
		//IL_005e: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		GameObject gameObject = marbleGlow.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = marbleFire.gameObject;
		gameObject2.SetActive(value: false);
		marbleGlow.localScale = (Vector3)0;
		Transform transform = marbleFire.transform;
		transform.localScale = (Vector3)0;
	}
}
