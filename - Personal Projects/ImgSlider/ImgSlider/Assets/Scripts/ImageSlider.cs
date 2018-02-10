using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageSlider : MonoBehaviour {

	[SerializeField] private Sprite[] images; //Stores all Images in Array
	[SerializeField] private Image currentImage; //the Current Image in display
	[SerializeField] private Button nxtButton; //the Next Button
	[SerializeField] private Button prvButton; //the previous button
	private int crrnt = 0; //Controls where we are in Array

	void Start () {
		StartCoroutine ("AutoScroller");
	}

	public void BtnNext(){
		if (crrnt + 1 < images.Length) {
			crrnt++;
		}
	}

	public void BtnPrev(){
		if (crrnt > 0) {
			crrnt--;
		}
	}

	void Update(){
		print ("CrrntCount: "+crrnt);
		currentImage.sprite = images[crrnt];
	}

	IEnumerator AutoScroller(){
		while (true) {
			yield return new WaitForSeconds (5f);
			print ("AutoScroll" );
			if (crrnt + 1 < images.Length) {
				crrnt++;
			} else {
				crrnt = 0;
			}
		}
	}
}
