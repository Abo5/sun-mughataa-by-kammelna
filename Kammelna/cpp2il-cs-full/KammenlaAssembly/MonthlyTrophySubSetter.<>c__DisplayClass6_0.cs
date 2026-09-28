using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mono.Btls;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

[Serializable]
public class MonthlyTrophySubSetter : MonthlyTrophyUISubSetter<ParticleSystem>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<ParticleSystem> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Populate>b__6_0(ParticleSystem p)
		{
			p.Stop();
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public Transform tform;

		public MonthlyTrophySubSetter <>4__this;

		public UserAchievementModel trophy;

		public TweenCallback <>9__2;

		internal void <Populate>b__1(bool s)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_0036: Expected O, but got I
			//IL_004f: Expected F4, but got O
			//IL_004f: Expected O, but got I4
			//IL_006e: Expected O, but got I
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_00a5: Expected O, but got I4
			//IL_0146: Expected O, but got I
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			//IL_00dd: Expected O, but got I
			//IL_00eb: Expected I, but got O
			if (s)
			{
				MonthlyTrophySubSetter monthlyTrophySubSetter = <>4__this;
				object obj = typeof(UsageHint) + 744;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v4+B8]");
				object obj3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(tform, (Vector3)0, (float)obj3);
				MonthlyTrophySubSetter monthlyTrophySubSetter2 = <>4__this;
				object obj4 = (nint)0 + (nint)2904;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				object obj5 = this + 40;
				TweenCallback tweenCallback = (TweenCallback)obj5;
				bool flag = obj5 == null;
				object obj6 = !flag;
				if (obj6 == null)
				{
					object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj8 = (nint)0 + (nint)2112;
					TweenCallback tweenCallback2 = default(TweenCallback);
					tweenCallback2..ctor(this, (IntPtr)obj8);
					<>9__2 = tweenCallback2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					tweenCallback = tweenCallback2;
				}
				object obj9 = (nint)0 + (nint)2504;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			}
		}

		internal void <Populate>b__2()
		{
			object trophyAsset = ((MonthlyTrophyUISubSetter<object>)(object)<>4__this).GetTrophyAsset(trophy);
			((ParticleSystem)trophyAsset).Play();
		}
	}

	private Achievement trophySetter;

	private Vector2 animateFrom;

	private float animationTime;

	private Ease ease;

	private ParticleSystem[] ParticleSystems
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0056: Expected O, but got I
			//IL_007a: Expected O, but got I8
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00b5: Expected O, but got I
			//IL_00e1: Expected O, but got I4
			//IL_00f7: Expected O, but got I
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			//IL_0148: Expected O, but got I
			//IL_016c: Expected O, but got I8
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_01a7: Expected O, but got I
			//IL_01d3: Expected O, but got I4
			//IL_01e9: Expected O, but got I
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected O, but got Unknown
			//IL_023a: Expected O, but got I
			object obj = typeof(TypeConverter<ushort, char>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			ParticleSystem[] array = default(ParticleSystem[]);
			if (array != null)
			{
				if (array.Length != 0)
				{
					object obj2 = array + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophySubSetter)+10]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X21_v6-8]");
					object obj3 = 0 & 0xFFFFFFFEL;
					if (obj3 != null)
					{
						object obj4 = array + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophySubSetter)+18]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X21_v8-10]");
						bool flag = (nint)0 < (nint)2;
						object obj5 = !flag;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X21_v8-10]");
						object obj6 = -2;
						bool flag2 = obj6 == null;
						object obj7 = ~obj5;
						object obj8 = obj7 | flag2;
						if (obj8 == null)
						{
							object obj9 = array + 48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophySubSetter)+20]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X21_v10-18]");
							object obj10 = 0 & 0xFFFFFFFCL;
							if (obj10 != null)
							{
								object obj11 = array + 56;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophySubSetter)+28]");
								obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X21_v12-20]");
								bool flag3 = (nint)0 < (nint)4;
								object obj12 = !flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X21_v12-20]");
								object obj13 = -4;
								bool flag4 = obj13 == null;
								object obj14 = ~obj12;
								object obj15 = obj14 | flag4;
								if (obj15 == null)
								{
									object obj16 = array + 64;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophySubSetter)+30]");
									obj16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									return array;
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (ParticleSystem[])(object)new NullReferenceException();
		}
	}

	public override void Populate(UserAchievementModel trophy)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02e5: Expected O, but got I4
		//IL_00e6: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0305: Expected O, but got I
		//IL_032f: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_0390: Expected O, but got I
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03b0: Expected O, but got I
		//IL_03c0: Expected O, but got I
		//IL_03d0: Expected O, but got I
		//IL_03f2: Expected O, but got I4
		//IL_0498: Expected I, but got O
		//IL_02ac: Expected O, but got I
		//IL_024e: Expected O, but got I4
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_042a: Expected O, but got I
		//IL_043b: Expected I, but got O
		//IL_0459: Expected O, but got I
		//IL_027e: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = trophy;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		object obj6 = typeof(SqlSingle[]) + 2360;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			object obj8 = typeof(DeviceRemoveEvent) & 1;
			if (obj8 != null)
			{
				goto IL_00da;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = typeof(DeviceRemoveEvent) & 1;
			bool flag = obj9 == null;
			object obj10 = !flag;
			if (obj10 != null)
			{
				goto IL_00da;
			}
		}
		_ = 1;
		object obj11 = (nint)0 + (nint)2080;
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v24+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		object obj14 = obj11;
		object obj15 = obj12;
		if (obj13 != null)
		{
			goto IL_0123;
		}
		goto IL_034d;
		IL_0123:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v24+B8]");
		object dictionary = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
		object valueOrDefault = CollectionExtensions.GetValueOrDefault((IReadOnlyDictionary<object, object>)dictionary, 0);
		Transform transform = trophySetter.transform;
		object obj16 = obj2 + 16;
		obj16 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = ShortcutExtensions.DOKill((Component)obj16);
		object obj17 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 200;
		((Transform)obj16).position = (Vector3)0;
		ParticleSystem[] particleSystems = ParticleSystems;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v37+E4]");
		bool flag3 = (nint)0 == 0;
		object obj19 = !flag3;
		ParticleSystem[] enumeration = particleSystems;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj17;
			enumeration = particleSystems;
		}
		object obj20 = (nint)0 + (nint)2240;
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj22 = (nint)0 + (nint)2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v37+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v16+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v16+8]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v37+E4]");
			bool flag5 = (nint)0 == 0;
			object obj25 = !flag5;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v22+B8]");
				obj23 = 0;
			}
			object obj27 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)2096;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj23, (IntPtr)obj28);
			object obj29 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v21+B8]");
			object obj30 = (nint)0 + (nint)8;
			obj30 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action2;
		}
		ArraysExtensions.ForEach(enumeration, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action3 = default(Action<bool>);
		action3..ctor(obj2, (IntPtr)obj22);
		Achievement achievement = trophySetter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+20]");
		achievement.Initialize((GameAchievementViewModel)valueOrDefault, (UserAchievementModel)0);
		return;
		IL_034d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj6;
		obj11 = obj14;
		goto IL_0123;
		IL_00da:
		obj11 = (nint)0 + (nint)2080;
		obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		obj14 = obj11;
		obj15 = obj12;
		if (!flag6)
		{
			goto IL_0123;
		}
		goto IL_034d;
	}

	public MonthlyTrophySubSetter()
	{
		_ = 1065353216;
		((MonthlyTrophyUISubSetter<object>)(object)this)..ctor();
	}
}
