using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine.Purchasing.Telemetry;

[Serializable]
public class TweenAnimation
{
	private TweenAnimBase[] anims;

	private Sequence sequence;

	private Sequence GetSequence
	{
		get
		{
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			//IL_042d: Expected O, but got Unknown
			//IL_044f: Expected O, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_03e0: Expected O, but got I
			//IL_03f6: Expected O, but got I
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			//IL_00f7: Expected O, but got I4
			//IL_0100: Expected O, but got I4
			//IL_0168: Expected O, but got I
			//IL_033b: Expected O, but got I4
			//IL_034d: Expected O, but got I4
			//IL_01eb: Expected O, but got I4
			//IL_0378: Expected O, but got I
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_014a: Expected O, but got I4
			//IL_0494: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Expected O, but got Unknown
			//IL_04b2: Expected O, but got I4
			//IL_03bd: Expected O, but got I4
			//IL_021f: Expected O, but got I
			//IL_03af: Expected O, but got I
			//IL_02c0: Expected O, but got I
			//IL_02d0: Expected O, but got I
			object obj = this + 24;
			Sequence result = (Sequence)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sequence sequence = DOTween.Sequence();
				this.sequence = sequence;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TweenAnimBase[] array = anims;
				if (anims != null)
				{
					if (array.Length < 1)
					{
						goto IL_03d4;
					}
					object obj6 = anims + 32;
					object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2328;
					object obj8 = 0;
					object obj9 = 0;
					Tween t = default(Tween);
					Tween t2 = default(Tween);
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X26_v5+v244 @ X24_v6*8]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X26_v5+v244 @ X24_v6*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X21_v6+10]");
						if ((nint)0 != 0)
						{
							object obj12 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v26+130]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X9_v8+130]");
							bool flag3 = num < 0;
							object obj13 = !flag3;
							object obj14 = ~obj13;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v26+C8]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X9_v8+130]");
								object obj15 = num2 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X10_v7-8]");
								if (0 == (nint)obj12)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X21_v6+28]");
									if ((nint)0 == 1 && obj8 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X25_v7+14]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X25_v7+18]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X26_v5+v244 @ X24_v6*8]");
										object obj16 = (nint)0 + (nint)32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X25_v7+20]");
										obj16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										obj11 = obj10;
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v377 @ X8_v26+198] (should have been resolved before IL gen)");
							Sequence sequence2 = TweenSettingsExtensions.Join((Sequence)obj, t);
							obj9++;
							bool flag4 = (nint)obj9 >= array.Length;
							object obj17 = 0;
							if (!flag4)
							{
								continue;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v377 @ X8_v26+198] (should have been resolved before IL gen)");
							Sequence sequence3 = TweenSettingsExtensions.Append((Sequence)obj, t2);
							object obj18 = obj7;
							object obj19 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X10_v5+130]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v7+130]");
							bool flag5 = num3 < 0;
							object obj20 = !flag5;
							object obj21 = ~obj20;
							object obj22 = 0;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X10_v5+C8]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v7+130]");
								object obj23 = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v20-8]");
								if (0 == (nint)obj18)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X26_v5+v244 @ X24_v6*8]");
									obj22 = 0;
								}
								else
								{
									obj22 = 0;
								}
							}
							if (obj22 != null)
							{
								obj8 = obj22;
							}
							obj9++;
							bool flag6 = (nint)obj9 < array.Length;
							object obj17 = 0;
							if (flag6)
							{
								continue;
							}
						}
						goto IL_03d4;
					}
				}
				return (Sequence)(object)new NullReferenceException();
			}
			goto IL_04c0;
			IL_03d4:
			object obj24 = (nint)0 + (nint)2720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C58");
			object obj25 = (nint)0 + (nint)2968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30590D4");
			result = this.sequence;
			goto IL_04c0;
			IL_04c0:
			return result;
		}
	}

	public Sequence PlaySequence()
	{
		//IL_000c: Expected O, but got I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002a: Expected O, but got I4
		object obj = (nint)0 + (nint)2408;
		object obj2 = this + 24;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sequence getSequence = GetSequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		Sequence result = default(Sequence);
		return result;
	}

	public bool IsPlaying()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0066: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return DOTween.IsTweening(this);
	}

	public void Kill()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = DOTween.Kill(this);
	}

	public void Rewind()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = DOTween.Rewind(this);
	}

	public Sequence Replay()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_0043: Expected O, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = DOTween.Rewind(this);
		object obj4 = (nint)0 + (nint)2408;
		object obj5 = this + 24;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sequence getSequence = GetSequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		Sequence result = default(Sequence);
		return result;
	}

	public void PlayBackwards()
	{
		Sequence getSequence = GetSequence;
		TweenExtensions.PlayBackwards(getSequence);
	}

	public void PlayForward()
	{
		Sequence getSequence = GetSequence;
		TweenExtensions.PlayForward(getSequence);
	}

	public static implicit operator TweenAnimation(TweenAnim anims)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2336;
		object obj2 = typeof(SqlSingle[]) + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj4 = default(object);
		bool flag = obj4 == null;
		TweenAnim tweenAnim = (TweenAnim)1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		TweenAnim tweenAnim2;
		if (!flag)
		{
			bool flag2 = anims == null;
			tweenAnim = (TweenAnim)1;
			if (!flag2)
			{
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+40]");
				tweenAnim = (TweenAnim)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+40]");
				tweenAnim2 = (TweenAnim)0;
				if (flag3)
				{
					goto IL_017b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+18]");
			if ((nint)0 == 0)
			{
				goto IL_0165;
			}
			object obj6 = obj4 + 32;
			obj6 = anims;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag4 = obj3 == null;
			tweenAnim = anims;
			if (!flag4)
			{
				object obj7 = obj3 + 16;
				obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return (TweenAnimation)obj3;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0165;
		IL_017b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (TweenAnimation)(object)new OutOfMemoryException();
		IL_0165:
		ex = new IndexOutOfRangeException();
		tweenAnim2 = tweenAnim;
		goto IL_017b;
	}

	public static implicit operator TweenAnimation(Tween anim)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_00fe: Expected O, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2336;
		object obj2 = typeof(SqlSingle[]) + 384;
		object obj3 = (nint)0 + (nint)2392;
		object obj4 = typeof(SqlSingle[]) + 2832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30506C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AdapterAnim adapterAnim = default(AdapterAnim);
		Tween tween = default(Tween);
		adapterAnim..ctor(tween);
		object obj6 = default(object);
		bool flag = obj6 == null;
		Tween tween2 = tween;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		Tween tween3;
		if (!flag)
		{
			bool flag2 = adapterAnim == null;
			tween2 = tween;
			if (!flag2)
			{
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v8+40]");
				tween2 = (Tween)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v8+40]");
				tween3 = (Tween)0;
				if (flag3)
				{
					goto IL_01bf;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+18]");
			if ((nint)0 == 0)
			{
				goto IL_01a9;
			}
			object obj8 = obj6 + 32;
			obj8 = adapterAnim;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag4 = obj5 == null;
			tween2 = (Tween)(object)adapterAnim;
			if (!flag4)
			{
				object obj9 = obj5 + 16;
				obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return (TweenAnimation)obj5;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01a9;
		IL_01bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (TweenAnimation)(object)new OutOfMemoryException();
		IL_01a9:
		ex = new IndexOutOfRangeException();
		tween3 = tween2;
		goto IL_01bf;
	}

	public static implicit operator Sequence(TweenAnimation anim)
	{
		if (anim != null)
		{
			return anim.GetSequence;
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public string Name(TweenAnimBase t)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		object obj = "Picking audio files is not supported on iOS" + 600;
		if (t != null)
		{
			string text = t.Name();
			if (text == null)
			{
				text = (string)obj;
			}
			return text;
		}
		return (string)obj;
	}
}
