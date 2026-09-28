using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using Spine;
using UnityEngine;
using UnityEngine.UI;

public class TitleSetter : AvatarComponent
{
	private sealed class <>c__DisplayClass5_0
	{
		public TitleSetter <>4__this;

		public User userClient;

		internal void <Initialize>b__0()
		{
			string title = SFSKammelnaUserExtensions.GetTitle(userClient);
			int titleLevel = SFSKammelnaUserExtensions.GetTitleLevel(userClient);
			int? level = titleLevel;
			<>4__this.AssignTitleInternal(title, level);
		}
	}

	private Image title;

	private bool isInitialized;

	private void Awake()
	{
		if (!isInitialized)
		{
			GameObject gameObject = title.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	public void AssignTitle(string achievementID, int titleLevelId)
	{
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		int? level = titleLevelId;
		AssignTitleInternal(achievementID, level);
	}

	public void AssignTitle(string achievementID)
	{
		//IL_0027: Expected O, but got I4
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		AssignTitleInternal(achievementID, (int?)(object)0);
	}

	public override void Initialize(User userClient)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00cc: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3440;
		object varName = "___# Content push apply failed [{0}]: {1}" + 3976;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = userClient;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		VariableBinderExtensions.Bind(go2, (User)obj6, (string)varName, action);
	}

	public override void Clear()
	{
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		GameObject gameObject = title.gameObject;
		gameObject.SetActive(value: false);
	}

	private void AssignTitleInternal(string achievementID, int? level)
	{
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_010e: Expected I, but got O
		GameObject gameObject = title.gameObject;
		object obj = (nint)0 + (nint)3176;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj3 = (nint)0 + (nint)56;
		gameObject.SetActive(value: false);
		object obj4 = (object?)level >> 32;
		object obj7;
		if (obj4 != null)
		{
			object obj5 = (??)level & 1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			obj7 = 0;
			if (obj6 != null)
			{
				goto IL_00e4;
			}
		}
		object obj8 = (nint)0 + (nint)3136;
		obj7 = obj8;
		int? num = 1;
		goto IL_00e4;
		IL_00e4:
		int value = num.Value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj3);
		UIExtensions.LoadAchievementImage(title, achievementID, value, action);
	}

	public override void Initialize(AvatarData avatarData)
	{
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		AssignTitleInternal(level: avatarData.<TitleLevel>k__BackingField, achievementID: avatarData.<TitleId>k__BackingField);
	}

	private void <AssignTitleInternal>b__7_0(bool isSuccess)
	{
		GameObject gameObject = title.gameObject;
		gameObject.SetActive(isSuccess);
		isInitialized = true;
	}
}
