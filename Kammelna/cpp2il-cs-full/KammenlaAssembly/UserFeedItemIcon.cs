using System;
using Server.Models;
using UnityEngine;

public abstract class UserFeedItemIcon : MonoBehaviour
{
	public abstract void Populate(UserFeedItem feedItem, Action onReady);
}
