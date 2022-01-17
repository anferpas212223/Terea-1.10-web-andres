//Image switcher code

let myImage= document.querySelector('img');

myImage.onclick = function(){
  let mySrc = myImage.getAttribute('src');
  if(mySrc === 'imagenes/spotify-3384019_1280.png'){
    myImage.setAttribute ('src','imagenes/descarga.png');
  } else{
    myImage.setAttribute ('src','imagenes/spotify-3384019_1280.png');
  }
}

// Personalized welcome message code

let myButton=document.querySelector('button');
let myHeading=document.querySelector('h1');

function setUserName(){
  let myName=prompt('Please enter your name.');
  if(!myName || myName===null){
    setUserName();
  } else{
    localStorage.setItem('name', myName);
    myHeading.innerHTML='Spotify is cool,' + myName;
  }
}

if(!localStorage.getItem('name')){
  setUserName();
} else {
  let storedName=localStorage.getItem('name');
  myHeading.innerHTML='Spotify is cool,' + storedName;
}

myButton.onlick=function(){
  setUserName();
}
