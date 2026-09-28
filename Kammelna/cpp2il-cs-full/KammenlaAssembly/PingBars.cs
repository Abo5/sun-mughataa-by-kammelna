using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ReportEnums;
using UnityEngine;
using UnityEngine.UI;

public class PingBars : MonoBehaviour
{
	private static readonly Color SignalRed;

	private static readonly Color SignalYellow;

	private static readonly Color SignalGreen;

	public Image[] bars;

	private int barsCount;

	private int roundTripPings;

	private float roundTripAverageTime;

	private const float startAnimationY = 1100f;

	private float endAnimationY;

	private KGame game;

	public ConnectionSpeed TestBarsCount;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0183: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_0168: Expected I, but got O
		//IL_00d1: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 56;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isFastTrackGame = ((KGame)obj5).IsFastTrackGame;
		bool flag2 = !isFastTrackGame;
		bool flag3 = false;
		if (!flag2)
		{
			Transform transform = base.transform;
			Vector3 localPosition = transform.localPosition;
			float num = default(float);
			endAnimationY = num;
			bool isTablet = ScreenUtility.IsTablet;
			bool flag4 = !isTablet;
			object obj7 = !flag4;
			flag3 = false;
			if (obj7 == null)
			{
				Transform gObject = base.transform;
				float? y = 1100f;
				UIExtensions.MoveTo(gObject, isWorldPositions: false, (float?)(object)0, y, (float?)(object)0);
				flag3 = false;
			}
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj9 = (nint)0 + (nint)3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj9);
		SFS.OnPingPong += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj2 = (nint)0 + (nint)3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnPingPong -= action;
	}

	private void SetBars(ConnectionSpeed connection)
	{
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06df: Expected O, but got I4
		//IL_0719: Expected O, but got I4
		//IL_0727: Expected O, but got I4
		//IL_0741: Expected O, but got I4
		//IL_078f: Expected O, but got I4
		//IL_079d: Expected O, but got I4
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected O, but got Unknown
		//IL_0120: Expected O, but got I4
		//IL_0063: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_07db: Expected O, but got I4
		//IL_080a: Expected O, but got I4
		//IL_01aa: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_01dc: Expected O, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0839: Expected O, but got I4
		//IL_087f: Expected O, but got I4
		//IL_0519: Expected O, but got I
		//IL_026a: Expected O, but got I
		//IL_053a: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_058d: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_0339: Expected O, but got I4
		//IL_0347: Expected O, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_05ce: Expected O, but got I
		//IL_05ef: Expected O, but got I4
		//IL_03df: Expected O, but got I
		//IL_0647: Expected I, but got O
		//IL_0657: Expected O, but got I
		//IL_0667: Expected O, but got I
		//IL_0670: Expected O, but got I4
		//IL_0441: Expected O, but got I4
		//IL_0499: Expected I, but got O
		//IL_04a9: Expected O, but got I
		//IL_04b9: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 608;
		bool flag = connection < ConnectionSpeed.Fast;
		object obj2 = !flag;
		object obj3 = ~obj2;
		object obj4 = ~obj3;
		ConnectionSpeed connectionSpeed = ((obj4 != null) ? ConnectionSpeed.Fast : connection);
		bool flag2 = connection < (ConnectionSpeed)2147483646;
		object obj5 = !flag2;
		object obj6 = connection - 2147483646;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		object obj8 = obj5 & obj7;
		object obj9 = ~obj8;
		int num = (barsCount = (int)((obj9 == null) ? ConnectionSpeed.MediumSlow : (connectionSpeed + 1)));
		StopAlert();
		bool flag4 = num < 2;
		object obj10 = !flag4;
		object obj11 = num - 2;
		bool flag5 = obj11 == null;
		object obj12 = ~obj10;
		object obj13 = obj12 | flag5;
		if (obj13 == null)
		{
			object obj14 = obj;
			bool flag6 = num < 4;
			object obj15 = !flag6;
			object obj16 = num - 4;
			bool flag7 = obj16 == null;
			object obj17 = !flag7;
			object obj18 = obj15 & obj17;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
			}
			object obj20 = !flag7;
			object obj21 = obj15 & obj20;
			object obj22 = ~obj21;
			if (obj22 == null)
			{
			}
			object obj23 = !flag7;
			object obj24 = obj15 & obj23;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
			}
			object obj26 = !flag7;
			object obj27 = obj15 & obj26;
			object obj28 = ~obj27;
			if (obj28 == null)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v35+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj;
			}
		}
		else
		{
			object obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v30+E4]");
			bool flag9 = (nint)0 == 0;
			object obj31 = !flag9;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj;
			}
			StartAlert(num);
		}
		while (true)
		{
			Image[] array = bars;
			if (bars != null && (object)array[0] != null)
			{
				array[0].color = (Color)0;
				Image[] array2 = bars;
				bool flag10 = num < 1;
				object obj32 = !flag10;
				object obj33 = num - 1;
				bool flag11 = obj33 == null;
				object obj34 = ~obj32;
				object obj35 = obj34 | flag11;
				if (obj35 == null)
				{
					if (bars != null && (object)array2[1] != null)
					{
						array2[1].color = (Color)0;
						if (num == 2)
						{
							goto IL_08a1;
						}
						Image[] array3 = bars;
						if (bars != null)
						{
							bool flag12 = array3.Length < 3;
							object obj36 = !flag12;
							object obj37 = ~obj36;
							if (obj37 != null)
							{
								break;
							}
							if ((object)array3[2] != null)
							{
								array3[2].color = (Color)0;
								bool flag13 = num < 3;
								object obj38 = !flag13;
								object obj39 = num - 3;
								bool flag14 = obj39 == null;
								object obj40 = ~obj38;
								object obj41 = obj40 | flag14;
								if (obj41 != null)
								{
									goto IL_08ca;
								}
								Image[] array4 = bars;
								if (bars != null && (object)array4[3] != null)
								{
									array4[3].color = (Color)0;
									if (num == 4)
									{
										goto IL_08f3;
									}
									Image[] array5 = bars;
									if (bars != null)
									{
										bool flag15 = array5.Length < 5;
										object obj42 = !flag15;
										object obj43 = ~obj42;
										if (obj43 != null)
										{
											break;
										}
										Image image = array5[4];
										if ((object)array5[4] != null)
										{
											nint num2 = (nint)image;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v36 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
											object obj44 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v36 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
											object obj45 = 0;
											goto IL_091c;
										}
									}
								}
							}
						}
					}
				}
				else if (bars != null && (object)array2[1] != null)
				{
					array2[1].color = (Color)0;
					goto IL_08a1;
				}
			}
			goto IL_069c;
			IL_08f3:
			Image[] array6 = bars;
			if (bars != null)
			{
				bool flag16 = array6.Length < 5;
				object obj46 = !flag16;
				object obj47 = ~obj46;
				if (obj47 != null)
				{
					break;
				}
				Image image = array6[4];
				if ((object)array6[4] != null)
				{
					nint num3 = (nint)image;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v14 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v14 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
					object obj45 = 0;
					object obj48 = 1047233823;
					double num4 = 1.0;
					double num5 = 1.0;
					double num6 = 1.0;
					goto IL_091c;
				}
			}
			goto IL_069c;
			IL_08ca:
			Image[] array7 = bars;
			if (bars == null || (object)array7[3] == null)
			{
				goto IL_069c;
			}
			array7[3].color = (Color)0;
			goto IL_08f3;
			IL_08a1:
			Image[] array8 = bars;
			if (bars != null)
			{
				bool flag17 = array8.Length < 3;
				object obj49 = !flag17;
				object obj50 = ~obj49;
				if (obj50 != null)
				{
					break;
				}
				if ((object)array8[2] != null)
				{
					array8[2].color = (Color)0;
					goto IL_08ca;
				}
			}
			goto IL_069c;
			IL_091c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v456 @ X2_v1 (should have been resolved before IL gen)");
			continue;
			IL_069c:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private void StartAlert(int count)
	{
		//IL_00b1: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		if ((object)game != null)
		{
			bool isFastTrackGame = game.IsFastTrackGame;
			if (count <= 2 && isFastTrackGame)
			{
				AnimatePingBarsIn();
			}
			Image[] array = bars;
			if (bars != null && (object)array[0] != null)
			{
				object obj = (nint)0 + (nint)3704;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object obj2 = default(object);
				if (obj2 != null)
				{
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v167 @ X8_v6+178] (should have been resolved before IL gen)");
					if (count < 2)
					{
						return;
					}
					Image[] array2 = bars;
					if (bars != null && (object)array2[1] != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						object obj4 = default(object);
						if (obj4 != null)
						{
							object obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v8+178]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v8+180]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v144 @ X2_v1 (should have been resolved before IL gen)");
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void StopAlert()
	{
		//IL_0016: Expected O, but got I
		//IL_0071: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_01ed: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ACD]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (barsCount < 3)
			{
				goto IL_0055;
			}
		}
		else
		{
			_ = 1;
			if (barsCount < 3)
			{
				goto IL_0055;
			}
		}
		AnimatePingBarsOut();
		Image[] array = bars;
		if (bars != null)
		{
			goto IL_00e2;
		}
		goto IL_01f7;
		IL_01f7:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_00e2:
		if ((object)array[0] != null)
		{
			object obj2 = (nint)0 + (nint)3704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj3 = default(object);
			if (obj3 != null)
			{
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ X8_v5+1A8] (should have been resolved before IL gen)");
				Image[] array2 = bars;
				if (bars != null && (object)array2[1] != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					object obj5 = default(object);
					if (obj5 != null)
					{
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7+1A8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7+1B0]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v159 @ X2_v1 (should have been resolved before IL gen)");
					}
				}
			}
		}
		goto IL_01f7;
		IL_0055:
		bool flag = bars == null;
		object obj9 = !flag;
		array = bars;
		if (obj9 != null)
		{
			goto IL_00e2;
		}
		goto IL_01f7;
	}

	private void AnimatePingBarsIn()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		if (!ScreenUtility.IsTablet)
		{
			object obj = (nint)0 + (nint)2904;
			object obj2 = (nint)0 + (nint)2776;
			Transform target = base.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target, endAnimationY, 0.5f, snapping: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	private void AnimatePingBarsOut()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		if (!ScreenUtility.IsTablet)
		{
			object obj = (nint)0 + (nint)2904;
			object obj2 = (nint)0 + (nint)2776;
			Transform target = base.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target, 1100f, 0.5f, snapping: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	private void OnPingPong(int _)
	{
		ConnectionSpeed connectionSpeed = SFS.ConnectionSpeed;
		SetBars(connectionSpeed);
	}

	public void ApplyTest()
	{
		SetBars(TestBarsCount);
	}

	static PingBars()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 608;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531A0]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531C0]");
		_ = 0;
	}
}
