using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class CurrencyParticleEffect : MonoBehaviour
{
	private int currencyPerSecond;

	private int currencyPerEmissionRate;

	private float baseDuration;

	private int baseEmission;

	private int maximumEmissionRate;

	private ParticleSystem _particles;

	private GiftBombData _lastGiftBomb;

	private ParticleSystem Particles
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00fc: Expected O, but got I4
			//IL_0164: Expected O, but got I
			//IL_014a: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E0]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object particles;
			UnityEngine.Object particles2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				particles = _particles;
				particles2 = _particles;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				particles = _particles;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				particles2 = _particles;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = particles2;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_00bb;
			}
			goto IL_0158;
			IL_00bb:
			return _particles;
			IL_0158:
			object obj7 = (nint)0 + (nint)3976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			ParticleSystem result = default(ParticleSystem);
			return result;
			IL_0091:
			if ((bool)particles)
			{
				goto IL_00bb;
			}
			goto IL_0158;
		}
	}

	public void StartEffect(GiftBombData giftBomb)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0030: Expected O, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_0193: Expected O, but got I
		//IL_0179: Expected O, but got I4
		//IL_023f: Expected O, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected I4, but got Unknown
		//IL_0279: Invalid comparison between F4 and I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected I4, but got Unknown
		//IL_029b: Expected O, but got F4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected I4, but got Unknown
		//IL_02d0: Expected O, but got I4
		//IL_02f6: Expected F4, but got I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected I4, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_0209: Expected O, but got I
		object obj = this + 64;
		if (giftBomb == obj)
		{
			return;
		}
		object obj2 = 152993792;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E0]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object particles;
		UnityEngine.Object particles2;
		if (obj4 != null)
		{
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			particles = _particles;
			particles2 = _particles;
			if (!flag)
			{
				goto IL_00b8;
			}
		}
		else
		{
			_ = 1;
			particles = _particles;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			particles2 = _particles;
			if (obj6 != null)
			{
				goto IL_00b8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = particles2;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			goto IL_00e2;
		}
		goto IL_0187;
		IL_00b8:
		if ((bool)particles)
		{
			goto IL_00e2;
		}
		goto IL_0187;
		IL_01a2:
		ParticleSystem particles3 = default(ParticleSystem);
		if (particles3.isPlaying)
		{
			object obj8 = obj;
			object obj9 = giftBomb.<CurrencyPerShard>k__BackingField * giftBomb.<NumberOfShards>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+34]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+30]");
			object obj10 = num * 0;
			if (obj9 <= obj10)
			{
				return;
			}
		}
		object obj11 = giftBomb.<NumberOfShards>k__BackingField * giftBomb.<CurrencyPerShard>k__BackingField;
		int num2 = obj11 / currencyPerEmissionRate;
		float num3 = (float)baseEmission + (float)num2;
		float num4 = num3 - (float)maximumEmissionRate;
		bool flag5 = num4 < 0f;
		int num5 = num3 ^ maximumEmissionRate;
		object obj12 = num3 ^ num4;
		int num6 = num5 & obj12;
		bool flag6 = num6 < 0;
		bool flag7 = flag5 == flag6;
		object obj13 = !flag7;
		object obj14 = ~obj13;
		if (obj14 != null)
		{
			num3 = maximumEmissionRate;
		}
		int num7 = obj11 / currencyPerSecond;
		float duration = baseDuration + (float)num7;
		PlayParticleSystem(num3, duration);
		_lastGiftBomb = giftBomb;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00e2:
		particles3 = _particles;
		goto IL_01a2;
		IL_0187:
		object obj15 = (nint)0 + (nint)3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		goto IL_01a2;
	}

	public void SimulateBomb(int shards, int shardValue)
	{
		//IL_003a: Expected O, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected I4, but got Unknown
		//IL_009a: Expected O, but got I4
		//IL_00f3: Expected F4, but got I4
		int num = shardValue * shards;
		int num2 = num / currencyPerEmissionRate;
		int num3 = baseEmission + num2;
		object obj = num3 - maximumEmissionRate;
		bool flag = (nint)obj < 0;
		int num4 = num3 ^ maximumEmissionRate;
		int num5 = num3 ^ obj;
		int num6 = num4 & num5;
		bool flag2 = num6 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 != null)
		{
			num3 = maximumEmissionRate;
		}
		int num7 = num / currencyPerSecond;
		float duration = baseDuration + (float)num7;
		PlayParticleSystem(num3, duration);
		DebugBombInfo(num);
	}

	private int TotalPayed(GiftBombData giftBomb)
	{
		//IL_0047: Expected I4, but got O
		if (giftBomb != null)
		{
			return giftBomb.<NumberOfShards>k__BackingField * giftBomb.<CurrencyPerShard>k__BackingField;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private bool NewBombShouldOverrideTheAnimation(GiftBombData giftBomb)
	{
		//IL_010e: Expected I4, but got O
		//IL_005d: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected I4, but got Unknown
		if (giftBomb != null)
		{
			GiftBombData lastGiftBomb = _lastGiftBomb;
			if (_lastGiftBomb != null)
			{
				object obj = giftBomb.<CurrencyPerShard>k__BackingField * giftBomb.<NumberOfShards>k__BackingField;
				object obj2 = lastGiftBomb.<NumberOfShards>k__BackingField * lastGiftBomb.<CurrencyPerShard>k__BackingField;
				object obj3 = obj - obj2;
				bool flag = (nint)obj3 < 0;
				bool flag2 = obj3 == null;
				object obj4 = obj ^ obj2;
				object obj5 = obj ^ obj3;
				object obj6 = obj4 & obj5;
				bool flag3 = (nint)obj6 < 0;
				bool flag4 = flag == flag3;
				object obj7 = !flag2;
				return (byte)((flag4 & obj7) ? 1 : 0) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private float GetDuration(int totalPayed)
	{
		int num = totalPayed / currencyPerSecond;
		return baseDuration + (float)num;
	}

	private float GetEmissionRate(int totalPayed)
	{
		//IL_002d: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_00bd: Expected F4, but got I4
		int num = totalPayed / currencyPerEmissionRate;
		int num2 = baseEmission + num;
		object obj = num2 - maximumEmissionRate;
		bool flag = (nint)obj < 0;
		int num3 = num2 ^ maximumEmissionRate;
		int num4 = num2 ^ obj;
		int num5 = num3 & num4;
		bool flag2 = num5 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 != null)
		{
			num2 = maximumEmissionRate;
		}
		return num2;
	}

	private void PlayParticleSystem(float emissionRate, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0094: Expected O, but got I
		//IL_013d: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_0169: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_0323: Expected O, but got I
		//IL_03f4: Expected O, but got I4
		//IL_0442: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E0]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object particles;
		UnityEngine.Object particles2;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v51+E4]");
			bool flag = (nint)0 == 0;
			particles = _particles;
			particles2 = _particles;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			particles = _particles;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v51+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			particles2 = _particles;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = (nint)0 + (nint)3976;
		bool flag3 = particles2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = obj5;
		if (obj6 != null)
		{
			goto IL_00c6;
		}
		goto IL_017f;
		IL_045f:
		ParticleSystem particles3 = default(ParticleSystem);
		particles3.Play();
		return;
		IL_02f1:
		ParticleSystem particles4 = default(ParticleSystem);
		particles4.Stop();
		SetParticleSystemVariables(emissionRate, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E0]");
		object obj8 = (nint)0 & (nint)1;
		UnityEngine.Object particles5;
		UnityEngine.Object particles6;
		if (obj8 != null)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v10+E4]");
			bool flag5 = (nint)0 == 0;
			particles5 = _particles;
			particles6 = _particles;
			if (!flag5)
			{
				goto IL_0381;
			}
		}
		else
		{
			_ = 1;
			particles5 = _particles;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v10+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			particles6 = _particles;
			if (obj10 != null)
			{
				goto IL_0381;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = particles6;
		bool flag8 = !flag7;
		object obj11 = !flag8;
		if (obj11 != null)
		{
			goto IL_03ab;
		}
		goto IL_0450;
		IL_023d:
		particles4 = _particles;
		goto IL_02f1;
		IL_0088:
		obj5 = (nint)0 + (nint)3976;
		bool flag9 = particles;
		bool flag10 = !flag9;
		obj7 = obj5;
		if (!flag10)
		{
			goto IL_00c6;
		}
		goto IL_017f;
		IL_017f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		obj5 = obj7;
		goto IL_0196;
		IL_00c6:
		ParticleSystem particles7 = _particles;
		goto IL_0196;
		IL_0196:
		particles7.Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E0]");
		object obj12 = (nint)0 & (nint)1;
		UnityEngine.Object particles8;
		UnityEngine.Object particles9;
		if (obj12 != null)
		{
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v30+E4]");
			bool flag11 = (nint)0 == 0;
			particles8 = _particles;
			particles9 = _particles;
			if (!flag11)
			{
				goto IL_0213;
			}
		}
		else
		{
			_ = 1;
			particles8 = _particles;
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v30+E4]");
			bool flag12 = (nint)0 == 0;
			object obj14 = !flag12;
			particles9 = _particles;
			if (obj14 != null)
			{
				goto IL_0213;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = particles9;
		bool flag14 = !flag13;
		object obj15 = !flag14;
		if (obj15 != null)
		{
			goto IL_023d;
		}
		goto IL_02e2;
		IL_0381:
		if ((bool)particles5)
		{
			goto IL_03ab;
		}
		goto IL_0450;
		IL_0450:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		goto IL_045f;
		IL_03ab:
		particles3 = _particles;
		goto IL_045f;
		IL_0213:
		if ((bool)particles8)
		{
			goto IL_023d;
		}
		goto IL_02e2;
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		goto IL_02f1;
	}

	private unsafe void SetParticleSystemVariables(float emissionRate, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0094: Expected O, but got I
		//IL_013d: Expected O, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_0169: Expected O, but got I4
		//IL_0228: Expected O, but got Ref
		//IL_0243: Expected O, but got I
		//IL_0314: Expected O, but got I4
		//IL_0362: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E0]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object particles;
		UnityEngine.Object particles2;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v44+E4]");
			bool flag = (nint)0 == 0;
			particles = _particles;
			particles2 = _particles;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			particles = _particles;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v44+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			particles2 = _particles;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = (nint)0 + (nint)3976;
		bool flag3 = particles2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = obj5;
		if (obj6 != null)
		{
			goto IL_00c6;
		}
		goto IL_017f;
		IL_02a1:
		UnityEngine.Object particles3;
		if ((bool)particles3)
		{
			goto IL_02cb;
		}
		goto IL_0370;
		IL_0370:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		goto IL_037f;
		IL_02cb:
		ParticleSystem particles4 = _particles;
		goto IL_037f;
		IL_0088:
		obj5 = (nint)0 + (nint)3976;
		bool flag5 = particles;
		bool flag6 = !flag5;
		obj7 = obj5;
		if (!flag6)
		{
			goto IL_00c6;
		}
		goto IL_017f;
		IL_017f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		obj5 = obj7;
		goto IL_0196;
		IL_00c6:
		ParticleSystem particles5 = _particles;
		goto IL_0196;
		IL_0196:
		ParticleSystem.EmissionModule emission = particles5.emission;
		object obj8 = typeof(SqlSingle[]) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AnimationCurve animationCurve = default(AnimationCurve);
		animationCurve..ctor();
		int num = animationCurve.AddKey(0f, emissionRate);
		float value = emissionRate * 0.25f;
		int num2 = animationCurve.AddKey(1f, value);
		ParticleSystem.MinMaxCurve minMaxCurve = new ParticleSystem.MinMaxCurve(1f, animationCurve);
		ParticleSystem.EmissionModule emissionModule = default(ParticleSystem.EmissionModule);
		ParticleSystem.MinMaxCurve minMaxCurve2 = default(ParticleSystem.MinMaxCurve);
		emissionModule.rateOverTime = (ParticleSystem.MinMaxCurve)(&minMaxCurve2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E0]");
		object obj9 = (nint)0 & (nint)1;
		UnityEngine.Object particles6;
		if (obj9 != null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v20+E4]");
			bool flag7 = (nint)0 == 0;
			particles3 = _particles;
			particles6 = _particles;
			if (!flag7)
			{
				goto IL_02a1;
			}
		}
		else
		{
			_ = 1;
			particles3 = _particles;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v20+E4]");
			bool flag8 = (nint)0 == 0;
			object obj11 = !flag8;
			particles6 = _particles;
			if (obj11 != null)
			{
				goto IL_02a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = particles6;
		bool flag10 = !flag9;
		object obj12 = !flag10;
		if (obj12 != null)
		{
			goto IL_02cb;
		}
		goto IL_0370;
		IL_037f:
		ParticleSystem.MainModule main = particles4.main;
		ParticleSystem.MainModule mainModule = default(ParticleSystem.MainModule);
		mainModule.duration = duration;
	}

	private AnimationCurve GetAnimationCureve(float emissionRate)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AnimationCurve animationCurve = default(AnimationCurve);
		animationCurve..ctor();
		if (animationCurve != null)
		{
			int num = animationCurve.AddKey(0f, emissionRate);
			float value = emissionRate * 0.25f;
			int num2 = animationCurve.AddKey(1f, value);
			return animationCurve;
		}
		return (AnimationCurve)(object)new NullReferenceException();
	}

	private void DebugBombInfo(int totalPayed)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0093: Expected O, but got I8
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0147: Expected O, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0196: Expected O, but got I8
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		//IL_020b: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0268: Expected O, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected I4, but got Unknown
		//IL_0330: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj2 = "ThisIsFakeReceiptData" + 904;
			object obj3 = array + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = default(int);
			string text = num.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v6-8]");
			object obj4 = 0 & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				object obj5 = array + 40;
				obj5 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X21_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj6 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X21_v8-10]");
				object obj7 = -2;
				bool flag2 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag2;
				if (obj9 == null)
				{
					object obj10 = (nint)0 + (nint)3744;
					object obj11 = array + 48;
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					int num2 = default(int);
					string text2 = num2.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X21_v10-18]");
					object obj12 = 0 & 0xFFFFFFFCL;
					if (obj12 != null)
					{
						object obj13 = array + 56;
						obj13 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X21_v12-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj14 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X21_v12-20]");
						object obj15 = -4;
						bool flag4 = obj15 == null;
						object obj16 = ~obj14;
						object obj17 = obj16 | flag4;
						if (obj17 == null)
						{
							object obj18 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1096;
							object obj19 = "Drop Menu Toggle" + 2248;
							object obj20 = (nint)0 + (nint)3504;
							object obj21 = array + 64;
							obj21 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string message = string.Concat(array);
							MonoBehaviour.print(message);
							int num3 = num / currencyPerEmissionRate;
							int num4 = baseEmission + num3;
							object obj22 = num4 - maximumEmissionRate;
							bool flag5 = (nint)obj22 < 0;
							int num5 = num4 ^ maximumEmissionRate;
							int num6 = num4 ^ obj22;
							int num7 = num5 & num6;
							bool flag6 = num7 < 0;
							bool flag7 = flag5 == flag6;
							object obj23 = !flag7;
							object obj24 = ~obj23;
							if (obj24 == null)
							{
							}
							float num8 = default(float);
							string text3 = num8.ToString();
							string text4 = num8.ToString();
							string message2 = (string)obj19 + text3 + (string)obj20 + text4;
							MonoBehaviour.print(message2);
							return;
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public CurrencyParticleEffect()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253608]");
		currencyPerSecond = 0;
		baseDuration = 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253610]");
		baseEmission = 0;
		base..ctor();
	}
}
