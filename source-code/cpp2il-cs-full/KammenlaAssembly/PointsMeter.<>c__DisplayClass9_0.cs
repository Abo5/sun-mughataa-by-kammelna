using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Mono.Btls;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsMeter : AvatarComponent
{
	private sealed class <>c__DisplayClass9_0
	{
		public User user;

		public PointsMeter <>4__this;

		internal void <InitializeMeter>b__0()
		{
			//IL_002b: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
			object obj = rank.<Points>k__BackingField - rank.<MinSubRankLimit>k__BackingField;
			object obj2 = rank.<MaxSubRankLimit>k__BackingField - rank.<MinSubRankLimit>k__BackingField;
			double num = (double)obj / (double)obj2;
			PointsMeter pointsMeter = <>4__this;
			if (rank.<Rank>k__BackingField == PlayerRank.Ranks.Master && rank.<SubRanksCount>k__BackingField == 4)
			{
				num = 1.0;
			}
			pointsMeter.fillAmount = (float)num;
			object obj3 = pointsMeter.Points - rank.<Points>k__BackingField;
			bool flag = obj3 == null;
			bool resetToDefault = !flag;
			pointsMeter.Points = rank.<Points>k__BackingField;
			pointsMeter.AnimateMeter(resetToDefault);
		}
	}

	private TextMeshProUGUI UserPoints;

	private Image UserPointsBar;

	private TextMeshProUGUI pointsBarText;

	private float fillAmount;

	private int Points;

	public bool isMyPoints;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		if (isMyPoints)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			InitializeMeter(localUser);
		}
	}

	private void OnEnable()
	{
		AnimateMeter(resetToDefault: true);
	}

	private void AnimateMeter(bool resetToDefault)
	{
		//IL_0147: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0167: Expected O, but got I
		//IL_01b5: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0095: Expected I, but got O
		if (resetToDefault)
		{
			int num = ShortcutExtensions.DOKill(UserPointsBar);
			int num2 = ShortcutExtensions.DOKill(UserPoints);
			int num3 = ShortcutExtensions.DOKill(pointsBarText);
			UserPointsBar.fillAmount = 0f;
			object text = ", stale={0}" + 120;
			UserPoints.text = (string)text;
			TextMeshProUGUI textMeshProUGUI = pointsBarText;
			nint num4 = (nint)textMeshProUGUI;
			textMeshProUGUI.text = (string)text;
		}
		object obj = (nint)0 + (nint)2752;
		object obj2 = typeof(SqlSingle[]) + 3912;
		object obj3 = (nint)0 + (nint)2800;
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFillAmount(UserPointsBar, fillAmount, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(pointsBarText, Points, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tweener tweener2 = AnimationExtensions.DONumber(UserPoints, Points, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	public void InitializeMeter(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0098: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00d6: Expected I, but got O
		//IL_00f4: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = UserPointsBar.gameObject;
		VariableBinderExtensions.Unbind(go);
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)1264;
		object varName = "placementId" + 1552;
		GameObject go2 = UserPointsBar.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		VariableBinderExtensions.Bind(go2, (User)0, (string)varName, action);
	}

	public void InitializeMeter(PlayerRank rank)
	{
		//IL_0017: Expected O, but got I4
		//IL_002e: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		object obj = rank.<Points>k__BackingField - rank.<MinSubRankLimit>k__BackingField;
		object obj2 = rank.<MaxSubRankLimit>k__BackingField - rank.<MinSubRankLimit>k__BackingField;
		float num = (float)obj / (float)obj2;
		if (rank.<Rank>k__BackingField == PlayerRank.Ranks.Master && rank.<SubRanksCount>k__BackingField == 4)
		{
			num = 1f;
		}
		fillAmount = num;
		object obj3 = Points - rank.<Points>k__BackingField;
		bool flag = obj3 == null;
		bool resetToDefault = !flag;
		Points = rank.<Points>k__BackingField;
		AnimateMeter(resetToDefault);
	}

	public override void Initialize(AvatarData avatarData)
	{
		//IL_0029: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		PlayerRank <Rank>k__BackingField = avatarData.<Rank>k__BackingField;
		object obj = <Rank>k__BackingField.<Points>k__BackingField - <Rank>k__BackingField.<MinSubRankLimit>k__BackingField;
		object obj2 = <Rank>k__BackingField.<MaxSubRankLimit>k__BackingField - <Rank>k__BackingField.<MinSubRankLimit>k__BackingField;
		float num = (float)obj / (float)obj2;
		if (<Rank>k__BackingField.<Rank>k__BackingField == PlayerRank.Ranks.Master && <Rank>k__BackingField.<SubRanksCount>k__BackingField == 4)
		{
			num = 1f;
		}
		fillAmount = num;
		object obj3 = Points - <Rank>k__BackingField.<Points>k__BackingField;
		bool flag = obj3 == null;
		bool resetToDefault = !flag;
		Points = <Rank>k__BackingField.<Points>k__BackingField;
		AnimateMeter(resetToDefault);
	}

	public override void Initialize(User userData)
	{
		InitializeMeter(userData);
	}

	public override void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0030: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_00d0: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(0);
		object obj2 = playerRank.<Points>k__BackingField - playerRank.<MinSubRankLimit>k__BackingField;
		object obj3 = playerRank.<MaxSubRankLimit>k__BackingField - playerRank.<MinSubRankLimit>k__BackingField;
		double num = (double)obj2 / (double)obj3;
		if (playerRank.<Rank>k__BackingField == PlayerRank.Ranks.Master && playerRank.<SubRanksCount>k__BackingField == 4)
		{
			num = 1.0;
		}
		fillAmount = (float)num;
		object obj4 = Points - playerRank.<Points>k__BackingField;
		bool flag = obj4 == null;
		bool resetToDefault = !flag;
		Points = playerRank.<Points>k__BackingField;
		AnimateMeter(resetToDefault);
	}
}
