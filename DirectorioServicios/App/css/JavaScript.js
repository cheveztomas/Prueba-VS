﻿function ValidarPassword(){
	//Variables
	var pass1="";
	var pass2="";

	//Inicio
	pass1=document.getElementById("txt_Conrteasenia").value.toString();
	pass1=document.getElementById("txt_ConrteaseniaConfir").value.toString();

	if (pass1==pass2) {
		document.getElementById('btn_Registrar').disabled=false;
		document.getElementById('MensajeCon').style.display='none';
	}
	else {
		document.getElementById('btn_Registrar').disabled=true;
		document.getElementById('MensajeCon').style.display='block';
	}
}