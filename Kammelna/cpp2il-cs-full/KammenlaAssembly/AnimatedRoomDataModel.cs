using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;

public class AnimatedRoomDataModel
{
	private AnimatedRoomDataInfo <AnimatedRoomInfo>k__BackingField;

	private string[] <SpineSkeletonTexts>k__BackingField;

	private string[] <SpineAtlasTexts>k__BackingField;

	private AudioClip[] <Audios>k__BackingField;

	private Texture2D[] <Images>k__BackingField;

	public AnimatedRoomDataInfo AnimatedRoomInfo
	{
		get
		{
			return <AnimatedRoomInfo>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string[] SpineSkeletonTexts
	{
		get
		{
			return <SpineSkeletonTexts>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string[] SpineAtlasTexts
	{
		get
		{
			return <SpineAtlasTexts>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public AudioClip[] Audios
	{
		get
		{
			return <Audios>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Texture2D[] Images
	{
		get
		{
			return <Images>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int ElementCount
	{
		get
		{
			//IL_006d: Expected I4, but got O
			AnimatedRoomDataInfo animatedRoomDataInfo = <AnimatedRoomInfo>k__BackingField;
			if ((object)<AnimatedRoomInfo>k__BackingField != null)
			{
				AnimatedRoomElementInfo[] elements = animatedRoomDataInfo.Elements;
				if (animatedRoomDataInfo.Elements != null)
				{
					return elements.Length;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public AnimatedRoomDataModel(int elementCount)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 240;
		object obj2 = typeof(SqlSingle[]) + 32;
		object obj3 = typeof(TypeConverter<ushort, char>) + 1744;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj4 = this + 48;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj6 = this + 32;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj8 = this + 24;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj10 = this + 40;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public bool IsValid()
	{
		//IL_0654: Expected I4, but got O
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0324: Expected O, but got I4
		//IL_032d: Expected O, but got I4
		//IL_0336: Expected O, but got I4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_0404: Expected O, but got I4
		//IL_043c: Expected O, but got I4
		//IL_046b: Expected O, but got I
		//IL_04e2: Expected O, but got I4
		//IL_0512: Expected O, but got I4
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_039f: Expected O, but got I4
		//IL_0564: Expected O, but got I4
		//IL_05db: Expected O, but got I4
		//IL_06bc: Expected O, but got I4
		AnimatedRoomDataInfo animatedRoomDataInfo = <AnimatedRoomInfo>k__BackingField;
		object obj;
		AnimatedRoomElementInfo[] elements2;
		bool flag4;
		if ((object)<AnimatedRoomInfo>k__BackingField != null)
		{
			AnimatedRoomElementInfo[] elements = animatedRoomDataInfo.Elements;
			if (animatedRoomDataInfo.Elements != null)
			{
				if (elements.Length == 0)
				{
					goto IL_0632;
				}
				if (elements.Length < 1)
				{
					goto IL_062c;
				}
				Texture2D[] array = <Images>k__BackingField;
				if (<Images>k__BackingField != null)
				{
					if (array.Length == 0)
					{
						goto IL_0646;
					}
					obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v10+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag2 = array[0] != null;
					AnimatedRoomDataInfo animatedRoomDataInfo2 = <AnimatedRoomInfo>k__BackingField;
					if ((object)<AnimatedRoomInfo>k__BackingField != null)
					{
						elements2 = animatedRoomDataInfo2.Elements;
						if (animatedRoomDataInfo2.Elements != null)
						{
							if (elements2.Length != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v6 (AnimatedRoomElementInfo[])+20]");
								if ((nint)0 != 0)
								{
									bool flag3 = !flag2;
									object obj4 = !flag3;
									if (obj4 != null)
									{
										goto IL_02fc;
									}
									flag4 = false;
									goto IL_069d;
								}
								string[] array2 = <SpineAtlasTexts>k__BackingField;
								if (<SpineAtlasTexts>k__BackingField == null)
								{
									goto IL_0638;
								}
								if (array2.Length != 0)
								{
									if (array2[0] != null)
									{
										string[] array3 = <SpineSkeletonTexts>k__BackingField;
										if (<SpineSkeletonTexts>k__BackingField == null)
										{
											goto IL_0638;
										}
										if (array3.Length == 0)
										{
											goto IL_0646;
										}
										bool flag5 = array3[0] != null && flag2;
										if (flag5)
										{
											goto IL_02fc;
										}
									}
									goto IL_062c;
								}
							}
							goto IL_0646;
						}
					}
				}
			}
		}
		goto IL_0638;
		IL_02fc:
		if (elements2.Length < 2)
		{
			goto IL_0632;
		}
		object obj5 = 128;
		object obj6 = 5;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		while (true)
		{
			Texture2D[] array4 = <Images>k__BackingField;
			if (<Images>k__BackingField == null)
			{
				break;
			}
			object obj9 = obj6 - 4;
			bool flag6 = (nint)obj9 < array4.Length;
			object obj10 = !flag6;
			AnimatedRoomElementInfo[] elements3;
			if (obj10 == null)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v16+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v16 (UnityEngine.Texture2D[])+v56 @ X23_v10*8]");
				flag4 = (UnityEngine.Object)0 != null;
				AnimatedRoomDataInfo animatedRoomDataInfo3 = <AnimatedRoomInfo>k__BackingField;
				if ((object)<AnimatedRoomInfo>k__BackingField == null)
				{
					break;
				}
				elements3 = animatedRoomDataInfo3.Elements;
				if (animatedRoomDataInfo3.Elements == null)
				{
					break;
				}
				bool flag8 = (nint)obj9 < elements3.Length;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v12 (AnimatedRoomElementInfo[])+v54 @ X22_v10]");
					bool flag9 = (nint)0 == 0;
					object obj14 = !flag9;
					if (obj14 != null)
					{
						if (flag4)
						{
							goto IL_0359;
						}
						goto IL_069d;
					}
					string[] array5 = <SpineAtlasTexts>k__BackingField;
					if (<SpineAtlasTexts>k__BackingField == null)
					{
						break;
					}
					bool flag10 = (nint)obj9 < array5.Length;
					object obj15 = !flag10;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v14 (System.String[])+v56 @ X23_v10*8]");
						if ((nint)0 != 0)
						{
							string[] array6 = <SpineSkeletonTexts>k__BackingField;
							if (<SpineSkeletonTexts>k__BackingField == null)
							{
								break;
							}
							bool flag11 = (nint)obj9 < array6.Length;
							object obj16 = !flag11;
							if (obj16 != null)
							{
								goto IL_0646;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X9_v16 (System.String[])+v56 @ X23_v10*8]");
							bool flag12 = (nint)0 != 0 && flag4;
							bool flag13 = !flag12;
							object obj17 = !flag13;
							if (obj17 != null)
							{
								goto IL_0359;
							}
						}
						goto IL_062c;
					}
				}
			}
			goto IL_0646;
			IL_0359:
			object obj18 = obj6 - 3;
			obj6++;
			obj5 += 96;
			bool flag14 = (nint)obj18 >= elements3.Length;
			obj7 = 0;
			obj8 = null;
			if (!flag14)
			{
				continue;
			}
			goto IL_0632;
		}
		goto IL_0638;
		IL_0632:
		return true;
		IL_0646:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_0638:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0646;
		IL_069d:
		return flag4;
		IL_062c:
		return false;
	}
}
