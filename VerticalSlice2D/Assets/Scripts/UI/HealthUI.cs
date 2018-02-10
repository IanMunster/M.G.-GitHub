using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthUI : MonoBehaviour {

	[SerializeField] private string _tag;

	[SerializeField] private Sprite[] _healthSprites;
	[SerializeField] private Image[] _healthIconsImage;

	private PlayerLives _lives;
	private int _currentLives;
	// Use this for initialization
	void Start () {
		_lives = GameObject.FindGameObjectWithTag (_tag).GetComponent<PlayerLives> ();
		if(_lives == null){
			print ("NO "+_tag+" FOUND IN SCENE! @HealthUI");
		}
	}
	
	// Update is called once per frame
	void Update () {
		GetCurrentHealth ();
		UpdateUI ();
	}

	void GetCurrentHealth(){
		_currentLives = Mathf.RoundToInt(_lives.getCurrentHealth);
	}

	void UpdateUI(){
		switch (_currentLives) {
		/*default:
			print ("Default Display 6 lives");
			_healthIconsImage[0].sprite = _healthSprites[2];
			_healthIconsImage[1].sprite = _healthSprites[2];
			_healthIconsImage[2].sprite = _healthSprites[2];
			break;*/
		case 0:
			_healthIconsImage[0].sprite = _healthSprites[0];
			_healthIconsImage[1].sprite = _healthSprites[0];
			_healthIconsImage[2].sprite = _healthSprites[0];
			break;
		case 1:
			_healthIconsImage[0].sprite = _healthSprites[1];
			_healthIconsImage[1].sprite = _healthSprites[0];
			_healthIconsImage[2].sprite = _healthSprites[0];
			break;
		case 2:
			_healthIconsImage[0].sprite = _healthSprites[2];
			_healthIconsImage[1].sprite = _healthSprites[0];
			_healthIconsImage[2].sprite = _healthSprites[0];
			break;
		case 3:
			_healthIconsImage[0].sprite = _healthSprites[2];
			_healthIconsImage[1].sprite = _healthSprites[1];
			_healthIconsImage[2].sprite = _healthSprites[0];
			break;
		case 4:
			_healthIconsImage[0].sprite = _healthSprites[2];
			_healthIconsImage[1].sprite = _healthSprites[2];
			_healthIconsImage[2].sprite = _healthSprites[0];
			break;
		case 5:
			_healthIconsImage[0].sprite = _healthSprites[2];
			_healthIconsImage[1].sprite = _healthSprites[2];
			_healthIconsImage[2].sprite = _healthSprites[1];
			break;
		case 6:
			_healthIconsImage[0].sprite = _healthSprites[2];
			_healthIconsImage[1].sprite = _healthSprites[2];
			_healthIconsImage[2].sprite = _healthSprites[2];
			break;
		}
	}
}
