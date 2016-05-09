using UnityEngine;
using System.Collections;

public class FireTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void ApplyDamage()
    {
        StartCoroutine(destroyTree(gameObject));

        Hud hud = GameObject.Find("Canvas").GetComponent<Hud>();
        hud.recordTreeHit();

    }

    public IEnumerator destroyTree(GameObject tree)
    {
        yield return new WaitForSeconds(2);
        Destroy(tree);
    }

}
