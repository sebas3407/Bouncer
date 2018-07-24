#pragma strict

 var clip1 : AudioClip;
 var estadosonido:int =1;

function Start () {

}

function Update () {

if ( Input.GetKeyDown('m') )
     {

     if (estadosonido==1) {
         GetComponent.<AudioSource>().Pause();
         estadosonido=0;
         }

         else if (estadosonido==0) {
            GetComponent.<AudioSource>().clip = clip1;
                     GetComponent.<AudioSource>().Play();

         estadosonido=1;
         }

     
     }


}