using UnityEngine;

public class Targets : MonoBehaviour
{

    public TargetManager _targetmanager;

    // Start is called before the first frame update
    public void Clear()
    {
        gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //mr.material = pressed;
            gameObject.SetActive(false);
            _targetmanager.HitTarget();
        }
    }
}
