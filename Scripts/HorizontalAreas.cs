using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HorizontalAreas : MonoBehaviour
{
	[Range(0f, 0.5f)][SerializeField] private float width;
	public RectTransform leftArea, middleArea, rightArea;

	void OnValidate()
	{
		RecalculateAreas();
	}
	void RecalculateAreas()
	{
		if((leftArea != null) && (middleArea != null) && (rightArea != null))
		{
			leftArea.SetAnchors(Vector2.zero, new Vector2(width, 1));
			middleArea.SetAnchors(new Vector2(width, 0), new Vector2(1 - width, 1));
			rightArea.SetAnchors(new Vector2(1 - width, 0), Vector2.one);
		}
	}
}
