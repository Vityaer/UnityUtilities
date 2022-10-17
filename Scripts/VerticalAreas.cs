using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalAreas : MonoBehaviour
{
    [Range(0f, 0.5f)][SerializeField] private float height;
	public RectTransform topArea, middleArea, bottomArea;

	void OnValidate()
	{
		RecalculateAreas();
	}
	void RecalculateAreas()
	{
		if((topArea != null) && (middleArea != null) && (bottomArea != null))
		{
			bottomArea.SetAnchors(Vector2.zero, new Vector2(1, height));
			middleArea.SetAnchors(new Vector2(0, height), new Vector2(1, 1 - height));
			topArea.SetAnchors(new Vector2(0, 1 - height), Vector2.one);
		}
	}
}
