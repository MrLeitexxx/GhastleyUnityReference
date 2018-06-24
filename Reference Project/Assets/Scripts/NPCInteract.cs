using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteract : MonoBehaviour {

	private bool playerIsPresent = false;
	SpriteRenderer m_spriteRenderer;
	Sprite NPCTalkSprite;
	Sprite NPCSprite;

	void Start(){
		
		NPCTalkSprite = Resources.Load ("Sprites/NPC_Talk", typeof(Sprite)) as Sprite;
		NPCSprite = Resources.Load ("Sprites/NPC", typeof(Sprite)) as Sprite;

	}

	void OnTriggerEnter2D(Collider2D collider) {

		if (collider.tag == "Player") {

			playerIsPresent = true;

			m_spriteRenderer = GetComponent<SpriteRenderer> ();
			m_spriteRenderer.sprite = NPCTalkSprite;

			transform.position = new Vector3 (transform.position.x, transform.position.y + 0.16f, transform.position.z);

		}
			
	}

	void OnTriggerExit2D(Collider2D collider) {

		if (collider.tag == "Player") {

			playerIsPresent = false;

			m_spriteRenderer = GetComponent<SpriteRenderer> ();
			m_spriteRenderer.sprite = NPCSprite;

			transform.position = new Vector3 (transform.position.x, transform.position.y - 0.16f, transform.position.z);
		}

	}

	void OnTriggerStay2D(Collider2D collider) {

		if (collider.tag == "Player") {

			//Debug.Log ("Player IS HERE!");
		}

	}
}