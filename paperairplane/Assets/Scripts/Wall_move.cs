using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_move : MonoBehaviour {
	public GameObject wallPrefab;//壁プレハブにしとく
	public GameObject movingwall;//空のスプリクト入れ

	void Start () {
		StartCoroutine(MoveMap());
		StartCoroutine(Setwall());
	}
	
	IEnumerator Setwall(){
		while (true) {//無限ループ
			Vector3 pos =new Vector3(20,Random.Range(8f,-7f),0);//発生
			GameObject wall=Instantiate(wallPrefab,pos,transform.rotation)as GameObject;
				wall.transform.parent=movingwall.transform;
			yield return new WaitForSeconds (3f);
		}
	}
	IEnumerator MoveMap(){
		while (true) {
			Vector3 pos = movingwall.transform.position;
			pos.x -= 4 * Time.deltaTime;
			movingwall.transform.position = pos;
			yield return 0;
		}
	}

}
