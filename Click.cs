using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Button target;
    public int click;

    private void Start()
    {
        target.onClick.AddListener(() => Debug.Log("click"));
    }
    private void Update()
    {
        if (click>0)
        {
            ExecuteEvents.Execute
            (
                target: target.gameObject,
                eventData: new PointerEventData(EventSystem.current),
                functor: ExecuteEvents.pointerClickHandler
            );
        }
    }
}