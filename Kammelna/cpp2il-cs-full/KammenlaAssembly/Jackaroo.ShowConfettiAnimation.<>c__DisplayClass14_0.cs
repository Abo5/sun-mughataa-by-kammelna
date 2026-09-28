using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

namespace Jackaroo;

public class ShowConfettiAnimation : MonoBehaviour
{
	private sealed class <>c__DisplayClass12_0
	{
		public ShowConfettiAnimation <>4__this;

		public Sequence confettiSequence;

		public Sequence glowSequence;

		internal void <PlayWin>b__0()
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		}

		internal void <PlayWin>b__1()
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		}
	}

	private sealed class <>c__DisplayClass12_1
	{
		public int index;

		public <>c__DisplayClass12_0 CS$<>8__locals1;

		internal void <PlayWin>b__2()
		{
			//IL_00a4: Expected O, but got I4
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00fc: Expected O, but got I
			//IL_01a0: Expected O, but got I4
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Expected O, but got Unknown
			//IL_01f8: Expected O, but got I
			<>c__DisplayClass12_0 cS$<>8__locals = CS$<>8__locals1;
			if (CS$<>8__locals1 != null)
			{
				ShowConfettiAnimation <>4__this = cS$<>8__locals.<>4__this;
				if ((object)cS$<>8__locals.<>4__this != null)
				{
					ParticleSystem[] confettiParticles = <>4__this._confettiParticles;
					if (<>4__this._confettiParticles != null)
					{
						bool flag = index < confettiParticles.Length;
						object obj = !flag;
						if (obj != null)
						{
							goto IL_0207;
						}
						object obj2 = <>4__this._confettiParticles + index;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+20]");
							((ParticleSystem)0).Play();
							<>c__DisplayClass12_0 cS$<>8__locals2 = CS$<>8__locals1;
							if (CS$<>8__locals1 != null)
							{
								ShowConfettiAnimation <>4__this2 = cS$<>8__locals2.<>4__this;
								if ((object)cS$<>8__locals2.<>4__this != null)
								{
									ParticleSystem[] fireworkParticles = <>4__this2._fireworkParticles;
									if (<>4__this2._fireworkParticles != null)
									{
										bool flag2 = index < fireworkParticles.Length;
										object obj3 = !flag2;
										if (obj3 != null)
										{
											goto IL_0207;
										}
										object obj4 = <>4__this2._fireworkParticles + index;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v10+20]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v10+20]");
											((ParticleSystem)0).Play();
											return;
										}
									}
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0207;
			IL_0207:
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <>c__DisplayClass12_2
	{
		public int index;

		public <>c__DisplayClass12_0 CS$<>8__locals2;

		internal void <PlayWin>b__3()
		{
			//IL_004b: Expected O, but got I
			<>c__DisplayClass12_0 cS$<>8__locals = CS$<>8__locals2;
			ShowConfettiAnimation <>4__this = cS$<>8__locals.<>4__this;
			object obj = ((List<object>)(object)<>4__this._marbles).get_Item(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v5 (System.Object)+F0]");
			((ParticleSystem)0).Play(withChildren: true);
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public ShowConfettiAnimation <>4__this;

		public Sequence confettiSequence;

		internal void <PlayTest>b__0()
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		}
	}

	private sealed class <>c__DisplayClass14_1
	{
		public int index;

		public <>c__DisplayClass14_0 CS$<>8__locals1;

		internal void <PlayTest>b__1()
		{
			//IL_00a4: Expected O, but got I4
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00fc: Expected O, but got I
			//IL_01a0: Expected O, but got I4
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Expected O, but got Unknown
			//IL_01f8: Expected O, but got I
			<>c__DisplayClass14_0 cS$<>8__locals = CS$<>8__locals1;
			if (CS$<>8__locals1 != null)
			{
				ShowConfettiAnimation <>4__this = cS$<>8__locals.<>4__this;
				if ((object)cS$<>8__locals.<>4__this != null)
				{
					ParticleSystem[] confettiParticles = <>4__this._confettiParticles;
					if (<>4__this._confettiParticles != null)
					{
						bool flag = index < confettiParticles.Length;
						object obj = !flag;
						if (obj != null)
						{
							goto IL_0207;
						}
						object obj2 = <>4__this._confettiParticles + index;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+20]");
							((ParticleSystem)0).Play();
							<>c__DisplayClass14_0 cS$<>8__locals2 = CS$<>8__locals1;
							if (CS$<>8__locals1 != null)
							{
								ShowConfettiAnimation <>4__this2 = cS$<>8__locals2.<>4__this;
								if ((object)cS$<>8__locals2.<>4__this != null)
								{
									ParticleSystem[] fireworkParticles = <>4__this2._fireworkParticles;
									if (<>4__this2._fireworkParticles != null)
									{
										bool flag2 = index < fireworkParticles.Length;
										object obj3 = !flag2;
										if (obj3 != null)
										{
											goto IL_0207;
										}
										object obj4 = <>4__this2._fireworkParticles + index;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v10+20]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v10+20]");
											((ParticleSystem)0).Play();
											return;
										}
									}
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0207;
			IL_0207:
			throw new IndexOutOfRangeException();
		}
	}

	private List<Transform> _shootersTransforms;

	private Ease _shooterScaleEase = Ease.InOutBack;

	private ParticleSystem[] _confettiParticles;

	private ParticleSystem[] _fireworkParticles;

	private float _scaleDuration;

	private float _delayStartEffect;

	private float _delaySlotEffect;

	private List<JackarooMarbleMono> _marbles;

	private float _delayGlowEffect;

	private float _delayBetweenGlowEffect;

	public void SetColor(Color color)
	{
		//IL_01c4: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		bool flag = _shootersTransforms == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		Color color2 = default(Color);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)2664;
			object obj3 = (nint)0 + (nint)1312;
			obj = (nint)0 + (nint)2656;
			List<object>.Enumerator enumerator = ((List<object>)(object)_shootersTransforms).GetEnumerator();
			color2 = (Color)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj4 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = (nint)color2 != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			color2 = (Color)obj;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj4 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBEBE0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void SetMarbles(List<JackarooMarbleMono> marbles)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 80;
		obj = marbles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public Sequence PlayWin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0960: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_00d3: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_01b6: Expected O, but got I
		//IL_01d3: Expected O, but got I
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0aae: Expected O, but got I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_086e: Expected O, but got I
		//IL_0889: Expected O, but got I4
		//IL_0140: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_0281: Expected O, but got I4
		//IL_0198: Expected O, but got I4
		//IL_01a5: Expected O, but got F8
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0545: Expected O, but got I4
		//IL_08c4: Expected O, but got I
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_061a: Expected O, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_07e5: Expected O, but got I
		//IL_07f6: Expected I, but got O
		//IL_03e5: Expected O, but got I
		//IL_03f6: Expected I, but got O
		//IL_0410: Expected O, but got I
		//IL_0438: Expected O, but got I4
		//IL_0441: Expected O, but got I4
		//IL_0827: Expected O, but got I
		//IL_0838: Expected I, but got O
		//IL_0477: Expected O, but got I4
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected O, but got Unknown
		//IL_09e3: Expected O, but got I4
		//IL_09ec: Expected O, but got I4
		//IL_09f5: Expected O, but got I4
		//IL_09fe: Expected O, but got I4
		//IL_04ca: Expected O, but got I4
		//IL_070b: Expected I, but got O
		//IL_02b6: Expected O, but got I
		//IL_073a: Expected O, but got I
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_0772: Expected O, but got I4
		//IL_077b: Expected O, but got I4
		//IL_0784: Expected O, but got I4
		//IL_079d: Expected O, but got I4
		//IL_07a6: Expected O, but got I4
		//IL_04e1: Expected O, but got I4
		//IL_04ea: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		TweenCallback tweenCallback = null;
		Sequence sequence = (Sequence)152989696;
		if (!flag)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence2 = DOTween.Sequence();
			bool flag3 = _shootersTransforms == null;
			tweenCallback = (TweenCallback)(object)this;
			sequence = sequence2;
			if (!flag3)
			{
				object obj7 = (nint)0 + (nint)2664;
				object obj8 = (nint)0 + (nint)2904;
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				List<object>.Enumerator enumerator = ((List<object>)(object)_shootersTransforms).GetEnumerator();
				object obj10 = typeof(UsageHint) + 816;
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				List<object>.Enumerator enumerator2 = enumerator3;
				List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
				object obj13;
				Transform transform = default(Transform);
				Tween t = default(Tween);
				object obj18 = default(object);
				Sequence result = default(Sequence);
				object obj16 = default(object);
				while (true)
				{
					object obj11 = obj7;
					if (!enumerator4.MoveNext())
					{
						object obj12 = (nint)0 + (nint)2656;
						obj11 = obj12;
						enumerator4.Dispose();
						obj13 = (nint)0 + (nint)3680;
						break;
					}
					if ((object)transform != null)
					{
						object obj14 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v46+B8]");
						object obj15 = 0;
						transform.localScale = (Vector3)0;
						TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(transform, 1f, _scaleDuration);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Sequence sequence3 = TweenSettingsExtensions.Join(sequence2, t);
						obj16 = 0;
						enumerator2 = (List<object>.Enumerator)1.0;
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					obj13 = (nint)0 + (nint)3680;
					bool flag4 = (nint)obj11 != 1;
					enumerator3 = (List<object>.Enumerator)0;
					OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						object obj17 = (nint)0 + (nint)2656;
						obj11 = obj17;
						enumerator4.Dispose();
						if (obj18 == null)
						{
							break;
						}
						ex2 = new OutOfMemoryException();
						enumerator3 = (List<object>.Enumerator)obj18;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBEBE0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return result;
				}
				object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v29+E4]");
				bool flag5 = (nint)0 == 0;
				object obj21 = !flag5;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sequence sequence4 = DOTween.Sequence();
				object obj22 = obj2 + 24;
				obj22 = sequence4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				float delayStartEffect = _delayStartEffect;
				Sequence sequence5 = TweenSettingsExtensions.AppendInterval((Sequence)obj22, _delayStartEffect);
				ParticleSystem[] confettiParticles = _confettiParticles;
				bool flag6 = _confettiParticles == null;
				tweenCallback = null;
				sequence = sequence2;
				if (!flag6)
				{
					object obj24 = default(object);
					object obj23 = obj24;
					object obj25 = obj16;
					object obj26 = 0;
					float num = _delayStartEffect;
					TweenCallback tweenCallback2 = null;
					object obj28 = default(object);
					TweenCallback tweenCallback3 = default(TweenCallback);
					bool flag12;
					object obj41 = default(object);
					TweenCallback tweenCallback5 = default(TweenCallback);
					TweenCallback tweenCallback6 = default(TweenCallback);
					TweenCallback tweenCallback7 = default(TweenCallback);
					do
					{
						if ((nint)obj26 < confettiParticles.Length)
						{
							object obj27 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3984;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							obj28..ctor();
							bool flag7 = obj28 == null;
							obj24 = obj23;
							obj16 = obj25;
							delayStartEffect = num;
							tweenCallback = null;
							sequence = sequence2;
							if (flag7)
							{
								break;
							}
							object obj29 = obj28 + 24;
							obj29 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj30 = obj29;
							bool flag8 = obj29 == null;
							obj24 = obj23;
							obj16 = obj25;
							delayStartEffect = num;
							tweenCallback = (TweenCallback)obj2;
							sequence = sequence2;
							if (flag8)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj31 = (nint)0 + (nint)3672;
							tweenCallback3..ctor(obj28, (IntPtr)obj31);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v33+18]");
							Sequence sequence6 = TweenSettingsExtensions.AppendCallback((Sequence)0, tweenCallback3);
							ParticleSystem[] confettiParticles2 = _confettiParticles;
							bool flag9 = _confettiParticles == null;
							obj24 = 0;
							obj16 = 0;
							delayStartEffect = num;
							tweenCallback = tweenCallback3;
							sequence = sequence2;
							if (flag9)
							{
								break;
							}
							object obj32 = confettiParticles2.Length - 1;
							bool flag10 = obj26 >= obj32;
							tweenCallback2 = tweenCallback3;
							confettiParticles = _confettiParticles;
							if (!flag10)
							{
								object obj33 = obj29;
								bool flag11 = obj29 == null;
								object obj34 = !flag11;
								if (obj34 == null)
								{
									obj24 = 0;
									obj16 = 0;
									delayStartEffect = num;
									tweenCallback = tweenCallback3;
									sequence = sequence2;
									break;
								}
								num = _delaySlotEffect;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v38+18]");
								Sequence sequence7 = TweenSettingsExtensions.AppendInterval((Sequence)0, _delaySlotEffect);
								confettiParticles = _confettiParticles;
								tweenCallback2 = null;
							}
							obj26++;
							flag12 = confettiParticles == null;
							obj23 = 0;
							obj25 = 0;
							obj24 = 0;
							obj16 = 0;
							delayStartEffect = num;
							tweenCallback = tweenCallback2;
							sequence = sequence2;
							continue;
						}
						object obj35 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
						object obj36 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v38+E4]");
						bool flag13 = (nint)0 == 0;
						object obj37 = !flag13;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Sequence sequence8 = DOTween.Sequence();
						object obj38 = obj2 + 32;
						obj38 = sequence8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						delayStartEffect = _delayGlowEffect;
						Sequence sequence9 = TweenSettingsExtensions.AppendInterval((Sequence)obj38, _delayGlowEffect);
						List<JackarooMarbleMono> marbles = _marbles;
						object obj39 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3992;
						bool flag14 = _marbles == null;
						obj24 = obj23;
						obj16 = obj25;
						tweenCallback = null;
						sequence = sequence2;
						if (flag14)
						{
							break;
						}
						float num2 = _delayGlowEffect;
						object obj40 = 0;
						TweenCallback tweenCallback4 = null;
						object obj44;
						do
						{
							bool flag15 = (nint)obj40 >= marbles._size;
							obj24 = obj23;
							obj16 = obj25;
							delayStartEffect = num2;
							tweenCallback = tweenCallback4;
							sequence = sequence2;
							if (!flag15)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj41..ctor();
								bool flag16 = obj41 == null;
								obj24 = obj23;
								obj16 = obj25;
								delayStartEffect = num2;
								tweenCallback = null;
								sequence = sequence2;
								if (flag16)
								{
									break;
								}
								object obj42 = obj41 + 24;
								obj42 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj43 = obj42;
								bool flag17 = obj42 == null;
								obj24 = obj23;
								obj16 = obj25;
								delayStartEffect = num2;
								tweenCallback = (TweenCallback)obj2;
								sequence = sequence2;
								if (flag17)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								tweenCallback5..ctor(obj41, (IntPtr)obj13);
								delayStartEffect = _delayBetweenGlowEffect * (float)obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v29+20]");
								Sequence sequence10 = TweenSettingsExtensions.InsertCallback((Sequence)0, delayStartEffect, tweenCallback5);
								obj40++;
								marbles = _marbles;
								bool flag18 = _marbles == null;
								obj44 = !flag18;
								obj24 = 0;
								obj16 = 0;
								tweenCallback = tweenCallback5;
								sequence = sequence2;
								obj23 = 0;
								obj25 = 0;
								num2 = delayStartEffect;
								tweenCallback4 = tweenCallback5;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj45 = (nint)0 + (nint)3656;
							tweenCallback6..ctor(obj2, (IntPtr)obj45);
							Sequence sequence11 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback6);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj46 = (nint)0 + (nint)3664;
							tweenCallback7..ctor(obj2, (IntPtr)obj46);
							Sequence sequence12 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback7);
							return sequence;
						}
						while (obj44 != null);
						break;
					}
					while (!flag12);
				}
			}
		}
		throw new NullReferenceException();
	}

	public void Reset()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0154: Expected I, but got O
		//IL_00e3: Expected I, but got O
		//IL_0095: Expected O, but got I4
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (_shootersTransforms != null)
		{
			object obj = (nint)0 + (nint)2664;
			obj2 = (nint)0 + (nint)2656;
			List<object>.Enumerator enumerator = ((List<object>)(object)_shootersTransforms).GetEnumerator();
			object obj3 = typeof(UsageHint) + 816;
			num = (nint)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj4 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj2;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBEBE0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void PlayTest()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_00d3: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_01b6: Expected O, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected O, but got Unknown
		//IL_078c: Expected O, but got I4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_05c0: Expected O, but got I4
		//IL_0140: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_0198: Expected O, but got I4
		//IL_01a5: Expected O, but got F8
		//IL_053f: Expected O, but got I
		//IL_0550: Expected I, but got O
		//IL_05fb: Expected O, but got I
		//IL_0572: Expected O, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_0401: Expected O, but got I
		//IL_0412: Expected I, but got O
		//IL_042c: Expected O, but got I
		//IL_0454: Expected O, but got I4
		//IL_045d: Expected O, but got I4
		//IL_0493: Expected O, but got I4
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_070d: Expected O, but got I4
		//IL_0716: Expected O, but got I4
		//IL_071f: Expected O, but got I4
		//IL_0728: Expected O, but got I4
		//IL_04e6: Expected O, but got I4
		//IL_04ef: Expected O, but got I4
		//IL_04f8: Expected O, but got I4
		//IL_02be: Expected O, but got I
		Sequence sequence = (Sequence)(typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4000);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj = default(object);
		obj..ctor();
		bool flag = obj == null;
		TweenCallback tweenCallback = null;
		if (!flag)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj3 = obj + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence2 = DOTween.Sequence();
			bool flag3 = _shootersTransforms == null;
			tweenCallback = (TweenCallback)(object)this;
			sequence = sequence2;
			if (!flag3)
			{
				object obj6 = (nint)0 + (nint)2664;
				object obj7 = (nint)0 + (nint)2904;
				object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				List<object>.Enumerator enumerator = ((List<object>)(object)_shootersTransforms).GetEnumerator();
				object obj9 = typeof(UsageHint) + 816;
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				List<object>.Enumerator enumerator2 = enumerator3;
				List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
				Transform transform = default(Transform);
				Tween t = default(Tween);
				object obj17 = default(object);
				object obj15 = default(object);
				while (true)
				{
					object obj10 = obj6;
					object obj12;
					if (!enumerator4.MoveNext())
					{
						object obj11 = (nint)0 + (nint)2656;
						obj10 = obj11;
						enumerator4.Dispose();
						obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4008;
						break;
					}
					if ((object)transform != null)
					{
						object obj13 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v36+B8]");
						object obj14 = 0;
						transform.localScale = (Vector3)0;
						TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(transform, 1f, _scaleDuration);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Sequence sequence3 = TweenSettingsExtensions.Join(sequence2, t);
						obj15 = 0;
						enumerator2 = (List<object>.Enumerator)1.0;
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4008;
					bool flag4 = (nint)obj10 != 1;
					enumerator3 = (List<object>.Enumerator)0;
					OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						object obj16 = (nint)0 + (nint)2656;
						obj10 = obj16;
						enumerator4.Dispose();
						if (obj17 == null)
						{
							break;
						}
						ex2 = new OutOfMemoryException();
						enumerator3 = (List<object>.Enumerator)obj17;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBEBE0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
				}
				object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v26+E4]");
				bool flag5 = (nint)0 == 0;
				object obj20 = !flag5;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sequence sequence4 = DOTween.Sequence();
				object obj21 = obj + 24;
				obj21 = sequence4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				float delayStartEffect = _delayStartEffect;
				Sequence sequence5 = TweenSettingsExtensions.AppendInterval((Sequence)obj21, _delayStartEffect);
				ParticleSystem[] confettiParticles = _confettiParticles;
				bool flag6 = _confettiParticles == null;
				tweenCallback = null;
				sequence = sequence2;
				if (!flag6)
				{
					object obj23 = default(object);
					object obj22 = obj23;
					object obj24 = obj15;
					object obj25 = 0;
					float num = _delayStartEffect;
					TweenCallback tweenCallback2 = null;
					object obj26 = default(object);
					TweenCallback tweenCallback3 = default(TweenCallback);
					bool flag13;
					TweenCallback tweenCallback4 = default(TweenCallback);
					do
					{
						bool flag7 = (nint)obj25 >= confettiParticles.Length;
						obj23 = obj22;
						obj15 = obj24;
						delayStartEffect = num;
						tweenCallback = tweenCallback2;
						sequence = sequence2;
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							obj26..ctor();
							bool flag8 = obj26 == null;
							obj23 = obj22;
							obj15 = obj24;
							delayStartEffect = num;
							tweenCallback = null;
							sequence = sequence2;
							if (flag8)
							{
								break;
							}
							object obj27 = obj26 + 24;
							obj27 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj28 = obj27;
							bool flag9 = obj27 == null;
							obj23 = obj22;
							obj15 = obj24;
							delayStartEffect = num;
							tweenCallback = (TweenCallback)obj;
							sequence = sequence2;
							if (flag9)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj29 = (nint)0 + (nint)3696;
							tweenCallback3..ctor(obj26, (IntPtr)obj29);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v23+18]");
							Sequence sequence6 = TweenSettingsExtensions.AppendCallback((Sequence)0, tweenCallback3);
							ParticleSystem[] confettiParticles2 = _confettiParticles;
							bool flag10 = _confettiParticles == null;
							obj23 = 0;
							obj15 = 0;
							delayStartEffect = num;
							tweenCallback = tweenCallback3;
							sequence = sequence2;
							if (flag10)
							{
								break;
							}
							object obj30 = confettiParticles2.Length - 1;
							bool flag11 = obj25 >= obj30;
							tweenCallback2 = tweenCallback3;
							confettiParticles = _confettiParticles;
							if (!flag11)
							{
								object obj31 = obj27;
								bool flag12 = obj27 == null;
								object obj32 = !flag12;
								obj23 = 0;
								obj15 = 0;
								delayStartEffect = num;
								tweenCallback = tweenCallback3;
								sequence = sequence2;
								if (obj32 == null)
								{
									break;
								}
								num = _delaySlotEffect;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v28+18]");
								Sequence sequence7 = TweenSettingsExtensions.AppendInterval((Sequence)0, _delaySlotEffect);
								confettiParticles = _confettiParticles;
								tweenCallback2 = null;
							}
							obj25++;
							flag13 = confettiParticles == null;
							obj22 = 0;
							obj24 = 0;
							obj23 = 0;
							obj15 = 0;
							delayStartEffect = num;
							tweenCallback = tweenCallback2;
							sequence = sequence2;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj33 = (nint)0 + (nint)3688;
						tweenCallback4..ctor(obj, (IntPtr)obj33);
						Sequence sequence8 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback4);
						object obj34 = (nint)0 + (nint)2408;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
						return;
					}
					while (!flag13);
				}
			}
		}
		throw new NullReferenceException();
	}

	public ShowConfettiAnimation()
	{
		//IL_001d: Expected F4, but got I
		//IL_002d: Expected F4, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253348]");
		_scaleDuration = 0f;
		_delayGlowEffect = (float)typeof(!!0);
		base..ctor();
	}
}
