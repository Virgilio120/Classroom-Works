using UnityEngine;
using System.Collections;

public class Vida : MonoBehaviour {
	public GUISkin Vazio;
	public GUISkin Sangue;
	
	public float posX;
	public float posXSangue;
	public float posY;
	public float posYSangue;
	public float Alt;
	public float AltSangue;
	public float Lar;
	public float LarSangue;
	public float Lar1;
    public float QntVida;
	public float MaxQntVida;
	 public float tempo;

	void Start () {
	  MaxQntVida = 100; // Quantidade de Vida Inicial = 100
		QntVida = MaxQntVida;
	}
	

	void Update () {
	    Lar1 = 200; // Tamanha da Barra Vazia do Fundo
		LarSangue = 170;
		LarSangue = 193 * (QntVida /MaxQntVida); // 193 = Tamanho da Barra de Sangue
		posX = 0;
		posXSangue = 3; // posição em X > que o Sangue começa na Tela
		posY = 20;
		posYSangue = 25; // posição em Y /\ \/ que o Sangue Começa na Tela
		Alt = 20;
		AltSangue = 10.8f; // Altura da Barra de Sangue
		
		if(Input.GetKey("c")){ // Quando Apertar C diminoi a Vida , Depois é Só Retirar para Colocar O Dano de Inimigos
			if(QntVida > 0)
			{
				QntVida = QntVida -0.5f;
				tempo = -1;
 			}
		}
			
		if(tempo >= 0){ // Acada Seg , Aumenta 1 de Vida , sendo a Vida 100/100
		if(QntVida < MaxQntVida){
				if(tempo > 0.01f){
					QntVida += Time.deltaTime;
					tempo = 0;
				}
			}
		}
		tempo = tempo + Time.deltaTime;
		
	}
	
	void OnGUI(){
		GUI.skin = Vazio; // Barra de Sangue Vazia Fundo ... Completa
		GUI.Box(new Rect(posX, posY, Lar1, Alt), "");
		
		GUI.skin = Sangue; // < Barra de Sangue Vermelha ..  Alguns Bugs
		GUI.Button (new Rect(posXSangue, posYSangue, LarSangue, AltSangue), "");
	}
	
}
