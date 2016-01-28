using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    private Controller2D player;

    public GameObject deathParticle;
	private SpriteRenderer renderer;
	//private GameObject player;
	private GameObject play;
   

    public float respawnDelay;
    // Use this for initialization
    void Start()
    {
		play = GameObject.Find ("Player");
		//player = GameObject.Find ("Player");
        player = FindObjectOfType<Controller2D>();
		renderer = play.GetComponent<SpriteRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void respawnPlayer()
    {
		StartCoroutine ("Fade");
        StartCoroutine("respawnPlayerCo");

    }

    public IEnumerator respawnPlayerCo()
    {
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(respawnDelay);
        Application.LoadLevel(Application.loadedLevel);
        yield return new WaitForSeconds(respawnDelay);
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        
        //Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
        //player.transform.position = currentCheckpoint.transform.position;
    }
	public IEnumerator Fade() {
		for (float f = 1f; f >= 0; f -= 0.01f) {
			Color c = renderer.material.color;
			c.a = f;
			renderer.material.color = c;
			yield return null;
		}
		yield return new WaitForSeconds (9.0f);
		//Application.LoadLevel ("ninja");
		
		
	}
}