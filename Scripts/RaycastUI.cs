using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class RaycastUI : MonoBehaviour
{
	Camera camera;
    [SerializeField] GraphicRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;
    [SerializeField] EventSystem m_EventSystem;
	void Start()
    {
        // m_Raycaster = GetComponent<GraphicRaycaster>();
        // m_EventSystem = GetComponent<EventSystem>();
    }
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			OnClick();
		}
	}
	void OnClick()
	{
		Debug.Log("click");
		m_PointerEventData = new PointerEventData(m_EventSystem);
		m_PointerEventData.position = Input.mousePosition;
		List<RaycastResult> results = new List<RaycastResult>();
		m_Raycaster.Raycast(m_PointerEventData, results);
		foreach (RaycastResult result in results)
        {
            Debug.Log("Hit " + result.gameObject.name);
        }
	}
}
