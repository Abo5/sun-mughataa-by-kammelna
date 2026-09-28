using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using Jackaroo;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class JackarooRoomCard : RoomCard
{
	private DiscreteProgressIndicator _team1P1Score;

	private DiscreteProgressIndicator _team1P2Score;

	private DiscreteProgressIndicator _team2P1Score;

	private DiscreteProgressIndicator _team2P2Score;

	private Button _customRulesButton;

	private ComponentReference<JackarooCustomRulesPreview> _customRulesPreview;

	private JackarooAllowedRules _jackarooAllowedRules;

	private new JackarooGameRoomData room
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01c4: Expected O, but got I4
			//IL_007f: Expected O, but got I
			//IL_0052: Expected O, but got I
			//IL_01e8: Expected O, but got I
			//IL_020a: Expected O, but got I4
			//IL_00b4: Expected O, but got I
			//IL_018e: Expected O, but got I
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			//IL_00fd: Expected I, but got O
			//IL_0126: Expected O, but got I4
			//IL_015a: Expected O, but got I
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A53]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_006f;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_006f;
				}
			}
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00a4;
			}
			goto IL_0218;
			IL_0181:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v9+10]");
			return (JackarooGameRoomData)0;
			IL_0226:
			return (JackarooGameRoomData)(object)new InvalidCastException();
			IL_00a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v9+10]");
			JackarooGameRoomData jackarooGameRoomData = (JackarooGameRoomData)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v9+10]");
			if ((nint)0 == 0)
			{
				goto IL_0181;
			}
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 216;
			object obj9 = obj8;
			nint num = (nint)jackarooGameRoomData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v13 (Il2CppClass<JackarooGameRoomData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X1_v3+130]");
			bool flag3 = num2 < 0;
			object obj10 = !flag3;
			object obj11 = ~obj10;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v13 (Il2CppClass<JackarooGameRoomData>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X1_v3+130]");
				object obj12 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v15-8]");
				if (0 == (nint)obj9)
				{
					goto IL_0181;
				}
			}
			goto IL_0226;
			IL_006f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
			if ((nint)0 != 0)
			{
				goto IL_00a4;
			}
			goto IL_0218;
			IL_0218:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0226;
		}
	}

	protected override void Awake()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I
		//IL_00c2: Expected I, but got O
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0042: Expected O, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		AvatarInitializer[] array = base.avatarInitializer;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = array.Length & 0x7FFFFFFF;
			do
			{
				object obj3 = obj;
				obj += 8;
				_ = 5;
				obj2--;
			}
			while ((nint)obj2 != 1);
		}
		Button customRulesButton = _customRulesButton;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj5 = (nint)0 + (nint)848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj5);
		customRulesButton.m_OnClick.AddListener(unityAction);
	}

	protected override void Refresh()
	{
		//IL_001c: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_009e: Expected O, but got I4
		//IL_004f: Expected O, but got I
		//IL_0140: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		//IL_01e6: Expected O, but got I
		//IL_0259: Expected O, but got I
		//IL_030a: Expected O, but got I
		//IL_0324: Expected O, but got I4
		//IL_02b9: Expected O, but got I
		//IL_02db: Expected O, but got I4
		//IL_028c: Expected O, but got I
		//IL_037d: Expected O, but got I
		//IL_0348: Expected O, but got I
		//IL_03db: Expected O, but got I4
		//IL_040f: Expected O, but got I
		//IL_0482: Expected O, but got I
		//IL_0533: Expected O, but got I
		//IL_054d: Expected O, but got I4
		//IL_04e2: Expected O, but got I
		//IL_0504: Expected O, but got I4
		//IL_04b5: Expected O, but got I
		//IL_05a6: Expected O, but got I
		//IL_0571: Expected O, but got I
		//IL_0604: Expected O, but got I4
		//IL_0638: Expected O, but got I
		//IL_06ab: Expected O, but got I
		//IL_075c: Expected O, but got I
		//IL_0776: Expected O, but got I4
		//IL_070b: Expected O, but got I
		//IL_072d: Expected O, but got I4
		//IL_06de: Expected O, but got I
		//IL_07cf: Expected O, but got I
		//IL_079a: Expected O, but got I
		//IL_082d: Expected O, but got I4
		//IL_0861: Expected O, but got I
		//IL_08d4: Expected O, but got I
		//IL_0985: Expected O, but got I
		//IL_099f: Expected O, but got I4
		//IL_0934: Expected O, but got I
		//IL_0956: Expected O, but got I4
		//IL_0907: Expected O, but got I
		//IL_09f8: Expected O, but got I
		//IL_09c3: Expected O, but got I
		//IL_0a56: Expected O, but got I4
		//IL_0a8a: Expected O, but got I
		base.Refresh();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A53]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_006c;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_006c;
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		if ((nint)0 != 0)
		{
			goto IL_0130;
		}
		goto IL_0b38;
		IL_0596:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v16+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v16+10]");
		if ((nint)0 == 0)
		{
			goto IL_0b38;
		}
		object obj8;
		object obj7 = obj8;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v17+130]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X1_v7+130]");
		bool flag2 = num < 0;
		object obj10 = !flag2;
		object obj11 = ~obj10;
		object obj17;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v17+C8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X1_v7+130]");
			object obj12 = num2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v19-8]");
			if (0 == (nint)obj7)
			{
				if ((object)_team2P1Score != null)
				{
					DiscreteProgressIndicator team2P1Score = _team2P1Score;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v12+70]");
					team2P1Score.CurrentProgress = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A53]");
					object obj13 = (nint)0 & (nint)1;
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
						object obj14 = (nint)0 & (nint)1;
						if (obj14 != null)
						{
							goto IL_06fb;
						}
					}
					else
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
						object obj15 = (nint)0 & (nint)1;
						bool flag3 = obj15 == null;
						object obj16 = !flag3;
						if (obj16 != null)
						{
							goto IL_06fb;
						}
					}
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
					if ((nint)0 != 0)
					{
						goto IL_07bf;
					}
				}
				goto IL_0b38;
			}
		}
		goto IL_0b46;
		IL_036d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v10+10]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v10+10]");
		if ((nint)0 == 0)
		{
			goto IL_0b38;
		}
		object obj19 = obj8;
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v11+130]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X1_v5+130]");
		bool flag4 = num3 < 0;
		object obj21 = !flag4;
		object obj22 = ~obj21;
		object obj28;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v11+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X1_v5+130]");
			object obj23 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v13-8]");
			if (0 == (nint)obj19)
			{
				if ((object)_team1P2Score != null)
				{
					DiscreteProgressIndicator team1P2Score = _team1P2Score;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v9+6C]");
					team1P2Score.CurrentProgress = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A53]");
					object obj24 = (nint)0 & (nint)1;
					if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
						object obj25 = (nint)0 & (nint)1;
						if (obj25 != null)
						{
							goto IL_04d2;
						}
					}
					else
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
						object obj26 = (nint)0 & (nint)1;
						bool flag5 = obj26 == null;
						object obj27 = !flag5;
						if (obj27 != null)
						{
							goto IL_04d2;
						}
					}
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
					if ((nint)0 != 0)
					{
						goto IL_0596;
					}
				}
				goto IL_0b38;
			}
		}
		goto IL_0b46;
		IL_02a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		bool flag6 = (nint)0 == 0;
		object obj30 = !flag6;
		if (obj30 != null)
		{
			goto IL_036d;
		}
		goto IL_0b38;
		IL_006c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		bool flag7 = (nint)0 == 0;
		object obj31 = !flag7;
		if (obj31 != null)
		{
			goto IL_0130;
		}
		goto IL_0b38;
		IL_0130:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+10]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+10]");
		if ((nint)0 == 0)
		{
			goto IL_0b38;
		}
		obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 216;
		object obj33 = obj8;
		object obj34 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v5+130]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X1_v3+130]");
		bool flag8 = num5 < 0;
		object obj35 = !flag8;
		object obj36 = ~obj35;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v5+C8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X1_v3+130]");
			object obj37 = num6 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v7-8]");
			if (0 == (nint)obj33)
			{
				if ((object)_team1P1Score != null)
				{
					DiscreteProgressIndicator team1P1Score = _team1P1Score;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+68]");
					team1P1Score.CurrentProgress = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A53]");
					object obj38 = (nint)0 & (nint)1;
					if (obj38 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
						object obj39 = (nint)0 & (nint)1;
						if (obj39 != null)
						{
							goto IL_02a9;
						}
					}
					else
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
						object obj40 = (nint)0 & (nint)1;
						bool flag9 = obj40 == null;
						object obj41 = !flag9;
						if (obj41 != null)
						{
							goto IL_02a9;
						}
					}
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
					obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
					if ((nint)0 != 0)
					{
						goto IL_036d;
					}
				}
				goto IL_0b38;
			}
		}
		goto IL_0b46;
		IL_0b46:
		throw new InvalidCastException();
		IL_06fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		bool flag10 = (nint)0 == 0;
		object obj42 = !flag10;
		if (obj42 != null)
		{
			goto IL_07bf;
		}
		goto IL_0b38;
		IL_07bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v22+10]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v22+10]");
		if ((nint)0 == 0)
		{
			goto IL_0b38;
		}
		object obj44 = obj8;
		object obj45 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v23+130]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X1_v9+130]");
		bool flag11 = num7 < 0;
		object obj46 = !flag11;
		object obj47 = ~obj46;
		object obj53;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v23+C8]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X1_v9+130]");
			object obj48 = num8 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v25-8]");
			if (0 == (nint)obj44)
			{
				if ((object)_team2P2Score != null)
				{
					DiscreteProgressIndicator team2P2Score = _team2P2Score;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v15+74]");
					team2P2Score.CurrentProgress = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A53]");
					object obj49 = (nint)0 & (nint)1;
					if (obj49 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
						object obj50 = (nint)0 & (nint)1;
						if (obj50 != null)
						{
							goto IL_0924;
						}
					}
					else
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
						object obj51 = (nint)0 & (nint)1;
						bool flag12 = obj51 == null;
						object obj52 = !flag12;
						if (obj52 != null)
						{
							goto IL_0924;
						}
					}
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
					obj53 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
					if ((nint)0 != 0)
					{
						goto IL_09e8;
					}
				}
				goto IL_0b38;
			}
		}
		goto IL_0b46;
		IL_09e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v28+10]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v28+10]");
		if ((nint)0 == 0)
		{
			goto IL_0b38;
		}
		object obj55 = obj8;
		object obj56 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v29+130]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X1_v11+130]");
		bool flag13 = num9 < 0;
		object obj57 = !flag13;
		object obj58 = ~obj57;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v29+C8]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X1_v11+130]");
			object obj59 = num10 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v31-8]");
			if (0 == (nint)obj55)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v18+78]");
				_jackarooAllowedRules = JackarooAllowedRules.DEFAULT;
				if ((object)_customRulesButton != null)
				{
					GameObject gameObject = _customRulesButton.gameObject;
					if ((object)gameObject != null)
					{
						bool flag14 = _jackarooAllowedRules == JackarooAllowedRules.DEFAULT;
						bool active = !flag14;
						gameObject.SetActive(active);
						return;
					}
				}
				goto IL_0b38;
			}
		}
		goto IL_0b46;
		IL_04d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		bool flag15 = (nint)0 == 0;
		object obj60 = !flag15;
		if (obj60 != null)
		{
			goto IL_0596;
		}
		goto IL_0b38;
		IL_0b38:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b46;
		IL_0924:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomCard)+40]");
		bool flag16 = (nint)0 == 0;
		object obj61 = !flag16;
		if (obj61 != null)
		{
			goto IL_09e8;
		}
		goto IL_0b38;
	}

	public JackarooRoomCard()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <Awake>b__9_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2464;
		object obj2 = (nint)0 + (nint)856;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void <Awake>b__9_1(JackarooCustomRulesPreview pop)
	{
		pop.Populate(_jackarooAllowedRules);
	}
}
