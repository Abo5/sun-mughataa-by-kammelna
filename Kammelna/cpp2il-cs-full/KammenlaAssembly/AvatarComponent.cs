using Sfs2X.Entities;
using UnityEngine;

public abstract class AvatarComponent : MonoBehaviour
{
	private bool requiresProfileRequest;

	public bool RequiresProfileRequest => requiresProfileRequest;

	public abstract void Initialize(AvatarData avatarData);

	public abstract void Initialize(User userData);

	public abstract void Clear();
}
