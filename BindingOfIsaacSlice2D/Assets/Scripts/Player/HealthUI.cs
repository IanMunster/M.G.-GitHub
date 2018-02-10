using UnityEngine;
using UnityEngine.UI;
using System.Collections;
/// <summary>
/// Health UI.
/// This Class is responsible for displaying the current Health of the Tag.
/// </summary>
public class HealthUI : MonoBehaviour {

	[SerializeField] private string _target;					//The Target GameObjects, which health should be displayed
	[SerializeField] private Sprite[] _healthSprites;			//The Differend Sprites for the UI (empty heart, half heart and full heart)
	[SerializeField] private Image[] _healthIconsImage;			//The Number of Health Icons for the UI

	private HealthHandler _lives;								//A Reference to the Lives of the Target
	private int _currentLives;									//private variable of current lives
	// Use this for initialization
	void Start () {
		_lives = GameObject.Find(_target).GetComponent<HealthHandler> ();	//Find the Target GameObject
		if(_lives == null){													//If there is no Lives found
			print ("NO "+_target+" FOUND IN SCENE! @HealthUI");				//Print Error if the are no Lives found
		}
	}
	
	// Update is called once per frame
	void Update () {
		GetCurrentHealth ();			//Update the Current Health state
		UpdateUI ();					//Update the UI
	}

	void GetCurrentHealth(){
		_currentLives = Mathf.RoundToInt(_lives.getCurrentHealth);	//Get the Current Health of the Target and store in in CurrentLives
	}

	void UpdateUI(){
		switch (_currentLives) {									//Switch on Number of Current Lives
		case 0:														//If Health = 0
			_healthIconsImage[0].sprite = _healthSprites[0];		//Set heart 0 to empty
			_healthIconsImage[1].sprite = _healthSprites[0];		//Set heart 1 to empty
			_healthIconsImage[2].sprite = _healthSprites[0];		//Set heart 2 to empty
			break;
		case 1:														//If Health = 1
			_healthIconsImage[0].sprite = _healthSprites[1];		//Set heart 0 to half
			_healthIconsImage[1].sprite = _healthSprites[0];		//Set heart 1 to empty
			_healthIconsImage[2].sprite = _healthSprites[0];		//Set heart 2 to empty
			break;
		case 2:														//If health = 2
			_healthIconsImage[0].sprite = _healthSprites[2];		//Set heart 0 to full
			_healthIconsImage[1].sprite = _healthSprites[0];		//Set heart 1 to empty
			_healthIconsImage[2].sprite = _healthSprites[0];		//Set heart 2 to empty
			break;
		case 3:														//If health = 3
			_healthIconsImage[0].sprite = _healthSprites[2];		//Set heart 0 to full
			_healthIconsImage[1].sprite = _healthSprites[1];		//Set heart 1 to half
			_healthIconsImage[2].sprite = _healthSprites[0];		//Set heart 2 to empty
			break;
		case 4:														//If health = 4
			_healthIconsImage[0].sprite = _healthSprites[2];		//Set heart 0 to full
			_healthIconsImage[1].sprite = _healthSprites[2];		//Set heart 1 to full
			_healthIconsImage[2].sprite = _healthSprites[0];		//Set heart 2 to empty
			break;
		case 5:														//If health = 5
			_healthIconsImage[0].sprite = _healthSprites[2];		//Set heart 0 to full
			_healthIconsImage[1].sprite = _healthSprites[2];		//Set heart 1 to full
			_healthIconsImage[2].sprite = _healthSprites[1];		//Set heart 2 to half
			break;
		case 6:														//If health = 6
			_healthIconsImage[0].sprite = _healthSprites[2];		//Set heart 0 to full
			_healthIconsImage[1].sprite = _healthSprites[2];		//Set heart 1 to full
			_healthIconsImage[2].sprite = _healthSprites[2];		//Set heart 2 to full
			break;
		}
	}
}
