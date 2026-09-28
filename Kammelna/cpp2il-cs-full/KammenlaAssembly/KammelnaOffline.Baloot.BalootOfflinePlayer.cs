using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using KammelnaOffline.Common;
using UnityEngine.AdaptivePerformance;

namespace KammelnaOffline.Baloot;

public class BalootOfflinePlayer : OfflinePlayer
{
	public int BalootCounter;

	public bool HasBaloot;

	public bool HasEkkah;

	private List<Card> <ProjectCards>k__BackingField;

	private List<BalootProject> <DeclaredProjectsList>k__BackingField;

	public List<Card> ProjectCards
	{
		get
		{
			return <ProjectCards>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<BalootProject> DeclaredProjectsList
	{
		get
		{
			return <DeclaredProjectsList>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public BalootOfflinePlayer(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 216;
		int index2 = default(int);
		base..ctor(index2);
		HasBaloot = false;
		BalootCounter = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 56;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<System.Int32Enum> list2 = default(List<System.Int32Enum>);
		list2..ctor();
		object obj4 = this + 64;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
