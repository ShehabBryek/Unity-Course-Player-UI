using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class PlayerUI : MonoBehaviour
{
	public Player player;
	public TextMeshProUGUI coinsCounterText;
	public Slider healthSlider;
 
	void Update()
	{
		// Updating the text with the number of coins
		coinsCounterText.text = player.coins.ToString();
 
		// Updating the player's health value
		healthSlider.maxValue = player.maxHealth;
		healthSlider.value = player.health;
	}
 
}
