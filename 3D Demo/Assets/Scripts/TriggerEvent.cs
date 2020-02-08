using UnityEngine.Events;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{

    public UnityEvent triggerEnterEvent, collisionEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionEnterEvent.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
