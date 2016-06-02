#pragma strict

var SpawnPoint: Transform;

var player : GameObject;

function OnTriggerEnter2D(col : Collider2D)
{
	
	
		player.transform.position = SpawnPoint.position;
	
}