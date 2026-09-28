using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public struct CustomUserBoxParticleOptions
{
	public Userbox.UserBoxDirection targetUserBox;

	public ParticleSystem particle;

	public ParticleSystem[] cloneParticles;

	public bool setLocalPosition;

	public bool setLocalRotation;

	private Vector3 localPosition;

	private Vector3 localRotation;

	public bool useStartSpeed;

	public bool useStartSize;

	public bool useStartRotation;

	public bool useStartLifeTime;

	public bool useMultiplier;

	private Vector2 startSpeedRange;

	private Vector2 startSizeRange;

	private Vector2 startRotationRange;

	private Vector2 startLifeTimeRange;

	public int multiplyStartSpeed;

	public int multiplyStartSize;

	public int multiplyStartRotation;

	public int multiplyStartLifeTime;

	public int multiplyVelocityOverTime;

	public int multiplyLocalPosition;

	private bool ShowSpeedOption()
	{
		return useStartSpeed;
	}

	private bool ShowSizeOption()
	{
		return useStartSize;
	}

	private bool ShowRotationOption()
	{
		return useStartRotation;
	}

	private bool ShowLifeTimeOptions()
	{
		return useStartLifeTime;
	}

	private bool ShowNoOptionSelectedMessage()
	{
		if (useStartSpeed)
		{
			return false;
		}
		if (useStartSize)
		{
			return false;
		}
		if (useStartRotation)
		{
			return false;
		}
		return !useStartLifeTime;
	}

	private bool ShowLocalPositionInput()
	{
		return setLocalPosition;
	}

	private bool ShowLocalRotationInput()
	{
		return setLocalRotation;
	}

	private bool ShowMultiplierOptions()
	{
		return useMultiplier;
	}

	public unsafe void SetParticleOptions(Userbox userbox, float multiplier = 1f)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0615: Expected O, but got Ref
		//IL_0621: Expected native int or pointer, but got O
		//IL_0635: Expected O, but got Ref
		//IL_0642: Expected O, but got Ref
		//IL_065b: Expected I, but got O
		//IL_06ab: Expected O, but got Ref
		//IL_06b7: Expected native int or pointer, but got O
		//IL_06cb: Expected O, but got Ref
		//IL_06d8: Expected O, but got Ref
		//IL_06f1: Expected I, but got O
		//IL_0741: Expected O, but got Ref
		//IL_074d: Expected native int or pointer, but got O
		//IL_0761: Expected O, but got Ref
		//IL_076e: Expected O, but got Ref
		//IL_0787: Expected I, but got O
		//IL_07d7: Expected O, but got Ref
		//IL_07e3: Expected native int or pointer, but got O
		//IL_07f7: Expected O, but got Ref
		//IL_0804: Expected O, but got Ref
		//IL_081d: Expected I, but got O
		//IL_0822: Expected I, but got O
		//IL_0405: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_049b: Expected O, but got I4
		//IL_04b1: Expected O, but got I
		//IL_04c8: Expected O, but got Ref
		//IL_04e8: Expected O, but got Ref
		//IL_04f5: Expected O, but got Ref
		//IL_0503: Expected O, but got Ref
		//IL_0523: Expected O, but got Ref
		//IL_0530: Expected O, but got Ref
		//IL_053e: Expected O, but got Ref
		//IL_055e: Expected O, but got Ref
		//IL_056b: Expected O, but got Ref
		//IL_0579: Expected O, but got Ref
		//IL_0599: Expected O, but got Ref
		//IL_05a6: Expected O, but got Ref
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		_ = 0;
		if (userbox.direction != targetUserBox)
		{
			return;
		}
		ParticleSystem.MainModule main = particle.main;
		object obj3 = default(object);
		nint num2 = default(nint);
		if (!useStartSpeed)
		{
			if (!useStartSize)
			{
				goto IL_008b;
			}
		}
		else
		{
			bool flag = multiplyStartSpeed == 0;
			double num = 1.0;
			if (!flag)
			{
				bool flag2 = !useMultiplier;
				num = 1.0;
				if (!flag2)
				{
					bool flag3 = multiplyStartSpeed == 1;
					num = multiplier;
					if (!flag3)
					{
						num = 1.0 / (double)multiplier;
					}
				}
			}
			_ = 0;
			_ = 0;
			float min = (float)startSpeedRange * (float)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomUserBoxParticleOptions)+40]");
			float max = 0f * (float)num;
			ParticleSystem.MinMaxCurve minMaxCurve = (ParticleSystem.MinMaxCurve)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)minMaxCurve, new ParticleSystem.MinMaxCurve(min, max));
			ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
			((ParticleSystem.MainModule*)mainModule)->startSpeed = (ParticleSystem.MinMaxCurve)(&obj3);
			bool flag4 = !useStartSize;
			num2 = unchecked((nint)null);
			if (flag4)
			{
				goto IL_008b;
			}
		}
		bool flag5 = multiplyStartSize == 0;
		double num3 = 1.0;
		if (!flag5)
		{
			bool flag6 = !useMultiplier;
			num3 = 1.0;
			if (!flag6)
			{
				bool flag7 = multiplyStartSize == 1;
				num3 = multiplier;
				if (!flag7)
				{
					num3 = 1.0 / (double)multiplier;
				}
			}
		}
		_ = 0;
		_ = 0;
		float min2 = (float)startSizeRange * (float)num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomUserBoxParticleOptions)+48]");
		float max2 = 0f * (float)num3;
		ParticleSystem.MinMaxCurve minMaxCurve2 = (ParticleSystem.MinMaxCurve)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)minMaxCurve2, new ParticleSystem.MinMaxCurve(min2, max2));
		ParticleSystem.MainModule mainModule2 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		((ParticleSystem.MainModule*)mainModule2)->startSize = (ParticleSystem.MinMaxCurve)(&obj3);
		bool flag8 = !useStartRotation;
		num2 = unchecked((nint)null);
		if (flag8)
		{
			goto IL_00aa;
		}
		goto IL_024a;
		IL_02e5:
		bool flag9 = multiplyStartLifeTime == 0;
		double num4 = 1.0;
		if (!flag9)
		{
			bool flag10 = !useMultiplier;
			num4 = 1.0;
			if (!flag10)
			{
				bool flag11 = multiplyStartLifeTime == 1;
				num4 = multiplier;
				if (!flag11)
				{
					num4 = 1.0 / (double)multiplier;
				}
			}
		}
		_ = 0;
		_ = 0;
		float min3 = (float)startLifeTimeRange * (float)num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomUserBoxParticleOptions)+58]");
		float max3 = 0f * (float)num4;
		ParticleSystem.MinMaxCurve minMaxCurve3 = (ParticleSystem.MinMaxCurve)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)minMaxCurve3, new ParticleSystem.MinMaxCurve(min3, max3));
		ParticleSystem.MainModule mainModule3 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		((ParticleSystem.MainModule*)mainModule3)->startLifetime = (ParticleSystem.MinMaxCurve)(&obj3);
		bool flag12 = !setLocalPosition;
		num2 = unchecked((nint)null);
		nint num5 = unchecked((nint)null);
		if (flag12)
		{
			goto IL_00f0;
		}
		goto IL_0380;
		IL_008b:
		if (!useStartRotation)
		{
			goto IL_00aa;
		}
		goto IL_024a;
		IL_00f0:
		if (setLocalRotation)
		{
			goto IL_042f;
		}
		goto IL_0456;
		IL_0380:
		Transform transform = particle.transform;
		if (multiplyLocalPosition == 0 || !useMultiplier || multiplyLocalPosition == 1)
		{
		}
		transform.localPosition = (Vector3)0;
		bool flag13 = !setLocalRotation;
		num2 = num5;
		if (!flag13)
		{
			goto IL_042f;
		}
		goto IL_0456;
		IL_00c9:
		bool flag14 = setLocalPosition;
		num5 = num2;
		if (!flag14)
		{
			goto IL_00f0;
		}
		goto IL_0380;
		IL_024a:
		bool flag15 = multiplyStartRotation == 0;
		double num6 = 1.0;
		if (!flag15)
		{
			bool flag16 = !useMultiplier;
			num6 = 1.0;
			if (!flag16)
			{
				bool flag17 = multiplyStartRotation == 1;
				num6 = multiplier;
				if (!flag17)
				{
					num6 = 1.0 / (double)multiplier;
				}
			}
		}
		_ = 0;
		_ = 0;
		float min4 = (float)startRotationRange * (float)num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomUserBoxParticleOptions)+50]");
		float max4 = 0f * (float)num6;
		ParticleSystem.MinMaxCurve minMaxCurve4 = (ParticleSystem.MinMaxCurve)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)minMaxCurve4, new ParticleSystem.MinMaxCurve(min4, max4));
		ParticleSystem.MainModule mainModule4 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		((ParticleSystem.MainModule*)mainModule4)->startRotation = (ParticleSystem.MinMaxCurve)(&obj3);
		bool flag18 = !useStartLifeTime;
		num2 = unchecked((nint)null);
		if (flag18)
		{
			goto IL_00c9;
		}
		goto IL_02e5;
		IL_0456:
		ParticleSystem[] array = cloneParticles;
		if (array.Length >= 1)
		{
			object obj4 = array + 32;
			object obj5 = 0;
			object obj6 = default(object);
			object obj7 = default(object);
			object obj8 = default(object);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+v55 @ X20_v5*8]");
				ParticleSystem.MainModule main2 = ((ParticleSystem)0).main;
				ParticleSystem.MainModule mainModule5 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
				ParticleSystem.MinMaxCurve startSpeed = ((ParticleSystem.MainModule*)mainModule5)->startSpeed;
				ParticleSystem.MainModule mainModule6 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
				((ParticleSystem.MainModule*)mainModule6)->startSpeed = (ParticleSystem.MinMaxCurve)(&obj3);
				ParticleSystem.MainModule mainModule7 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
				ParticleSystem.MinMaxCurve startSize = ((ParticleSystem.MainModule*)mainModule7)->startSize;
				ParticleSystem.MainModule mainModule8 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
				((ParticleSystem.MainModule*)mainModule8)->startSize = (ParticleSystem.MinMaxCurve)(&obj6);
				ParticleSystem.MainModule mainModule9 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
				ParticleSystem.MinMaxCurve startRotation = ((ParticleSystem.MainModule*)mainModule9)->startRotation;
				ParticleSystem.MainModule mainModule10 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
				((ParticleSystem.MainModule*)mainModule10)->startRotation = (ParticleSystem.MinMaxCurve)(&obj7);
				ParticleSystem.MainModule mainModule11 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
				ParticleSystem.MinMaxCurve startLifetime = ((ParticleSystem.MainModule*)mainModule11)->startLifetime;
				ParticleSystem.MainModule mainModule12 = (ParticleSystem.MainModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
				((ParticleSystem.MainModule*)mainModule12)->startLifetime = (ParticleSystem.MinMaxCurve)(&obj8);
				obj5++;
			}
			while ((nint)obj5 < array.Length);
		}
		return;
		IL_042f:
		Transform transform2 = particle.transform;
		transform2.localEulerAngles = (Vector3)0;
		goto IL_0456;
		IL_00aa:
		if (!useStartLifeTime)
		{
			goto IL_00c9;
		}
		goto IL_02e5;
	}

	private unsafe ParticleSystem.MinMaxCurve GetMinMaxValue(Vector2 rangeValues, float multiplier)
	{
		//IL_0009: Expected native int or pointer, but got O
		//IL_0013: Expected native int or pointer, but got O
		//IL_0042: Expected native int or pointer, but got O
		ParticleSystem.MinMaxCurve minMaxCurve = default(ParticleSystem.MinMaxCurve);
		((ParticleSystem.MinMaxCurve*)(nint)minMaxCurve)->m_Mode = ParticleSystemCurveMode.Constant;
		System.Runtime.CompilerServices.Unsafe.Write(&((ParticleSystem.MinMaxCurve*)(nint)minMaxCurve)->m_CurveMax, null);
		object obj = default(object);
		float min = multiplier * (float)obj;
		object obj2 = default(object);
		float max = (float)obj2 * (float)obj;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)minMaxCurve, new ParticleSystem.MinMaxCurve(min, max));
		return minMaxCurve;
	}

	private float GetMultiplierValue(float multiplier, int direction)
	{
		bool flag = direction == 0;
		float result = 1f;
		if (!flag)
		{
			bool flag2 = !useMultiplier;
			result = 1f;
			if (!flag2)
			{
				if (direction == 1)
				{
					return multiplier;
				}
				result = 1f / multiplier;
			}
		}
		return result;
	}
}
