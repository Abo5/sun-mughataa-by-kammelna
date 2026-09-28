using Cpp2ILInjected;
using UnityEngine;

public class SpriteSheetRoomElement : AnimatedRoomElement
{
	private SpriteRenderer renderer;

	private SpriteSheetPlayer player;

	public override void Prepare()
	{
		SpriteSheetPlayer spriteSheetPlayer = player;
		spriteSheetPlayer.duration = duration;
		spriteSheetPlayer.gridSize = spriteGridSize;
		SpriteSheetPlayer spriteSheetPlayer2 = player;
		spriteSheetPlayer2.loopCount = loopCount;
	}

	public void Setup(Texture2D texture)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		SpriteSheetPlayer spriteSheetPlayer = player;
		object obj = player + 48;
		obj = texture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sprite[] array = SpriteExensions.CreateSprites((Texture2D)obj, spriteSheetPlayer.gridSize);
		object obj2 = player + 96;
		obj2 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe override void ApplyRoomSetup(AnimatedRoomElementInfo info)
	{
		//IL_000b: Expected O, but got Ref
		//IL_0020: Expected O, but got I4
		AnimatedRoomElementType animatedRoomElementType = default(AnimatedRoomElementType);
		base.ApplyRoomSetup((AnimatedRoomElementInfo)(&animatedRoomElementType));
		renderer.size = (Vector2)0;
	}

	public override void Play()
	{
		player.Play();
	}
}
