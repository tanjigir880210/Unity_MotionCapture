using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    private Animator ani;
    private void Start ()

    {
        ani = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	private void Update ()

    {
        if (Input.GetKeyDown(KeyCode.Space)) ani.SetTrigger("揮拳觸發器");
        ani.SetBool("走路開關", Input.GetKey(KeyCode.R));
	}
}
