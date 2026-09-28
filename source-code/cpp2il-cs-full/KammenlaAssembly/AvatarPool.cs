using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class AvatarPool : MonoBehaviour
{
	private AvatarInitializer avatarPrefab;

	private int poolSize;

	private Queue<AvatarInitializer> pool;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Queue<object> queue = default(Queue<object>);
		queue..ctor();
		object obj2 = this + 48;
		obj2 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ExpandPool(poolSize);
	}

	private void ExpandPool(int size)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0110: Expected O, but got I4
		if (size < 1)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)480;
		object obj3 = (nint)0 + (nint)912;
		int num = size;
		Component component = default(Component);
		do
		{
			Transform transform = base.transform;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			GameObject gameObject = component.gameObject;
			gameObject.SetActive(value: false);
			((Queue<object>)(object)pool).Enqueue((object)component);
			num--;
		}
		while (num != 1);
	}

	public AvatarInitializer GetFromPool()
	{
		//IL_0024: Expected O, but got I4
		Queue<object> queue = (Queue<object>)(object)pool;
		if (pool != null)
		{
			bool flag = queue._size == 0;
			object obj = !flag;
			if (obj == null)
			{
				ExpandPool(poolSize);
				queue = (Queue<object>)(object)pool;
				if (pool == null)
				{
					goto IL_00cf;
				}
			}
			object obj2 = queue.Dequeue();
			if (obj2 != null)
			{
				GameObject gameObject = ((Component)obj2).gameObject;
				if ((object)gameObject != null)
				{
					gameObject.SetActive(value: true);
					return (AvatarInitializer)obj2;
				}
			}
		}
		goto IL_00cf;
		IL_00cf:
		return (AvatarInitializer)(object)new NullReferenceException();
	}

	public void ReturnToPool(AvatarInitializer avatar)
	{
		GameObject gameObject = avatar.gameObject;
		gameObject.SetActive(value: false);
		((Queue<object>)(object)pool).Enqueue((object)avatar);
	}
}
