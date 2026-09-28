using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public struct SpineRoomElementData
{
	private readonly AnimatedRoomElementInfo <Info>k__BackingField;

	private readonly string <AnimationJson>k__BackingField;

	private readonly string <AtlasJson>k__BackingField;

	private readonly Texture2D <Image>k__BackingField;

	private readonly AudioClip <AudioClip>k__BackingField;

	public unsafe AnimatedRoomElementInfo Info
	{
		get
		{
			//IL_0015: Expected O, but got I
			//IL_0010: Expected native int or pointer, but got O
			//IL_002a: Expected F4, but got I
			//IL_0025: Expected native int or pointer, but got O
			//IL_003a: Expected native int or pointer, but got O
			//IL_004f: Expected native int or pointer, but got O
			//IL_0063: Expected I4, but got O
			//IL_005e: Expected native int or pointer, but got O
			//IL_0078: Expected O, but got I
			//IL_0073: Expected native int or pointer, but got O
			//IL_007a: Expected O, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpineRoomElementData)+20]");
			AnimatedRoomElementInfo animatedRoomElementInfo = default(AnimatedRoomElementInfo);
			((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->rotation = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpineRoomElementData)+30]");
			((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->height = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpineRoomElementData)+40]");
			((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->loopCount = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpineRoomElementData)+50]");
			((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->sortOrder = 0;
			((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->type = (AnimatedRoomElementType)<Info>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpineRoomElementData)+10]");
			((AnimatedRoomElementInfo*)(nint)animatedRoomElementInfo)->pivotPosition = (Vector2)0;
			return (AnimatedRoomElementInfo)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}

	public string AnimationJson => <AnimationJson>k__BackingField;

	public string AtlasJson => <AtlasJson>k__BackingField;

	public Texture2D Image => <Image>k__BackingField;

	public AudioClip AudioClip => <AudioClip>k__BackingField;

	public unsafe SpineRoomElementData(AnimatedRoomElementInfo info, string animationJson, string atlasJson, Texture2D image, AudioClip audioClip)
	{
		//IL_0037: Expected O, but got I4
		//IL_004c: Expected O, but got Ref
		//IL_0061: Expected O, but got Ref
		//IL_0083: Expected O, but got Ref
		//IL_00a0: Expected O, but got Ref
		//IL_00c2: Expected O, but got Ref
		_ = info.loopCount;
		_ = info.sortOrder;
		_ = info.rotation;
		_ = info.height;
		<Info>k__BackingField = (AnimatedRoomElementInfo)info.type;
		_ = info.pivotPosition;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 96));
		obj2 = animationJson;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 104));
		obj3 = atlasJson;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 112));
		obj4 = image;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 120));
		obj5 = audioClip;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
