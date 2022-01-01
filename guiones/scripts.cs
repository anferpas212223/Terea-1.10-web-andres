//Image switcher code

let myImage= document.querySelector('img');

myImage.onclick = function(){
  let mySrc = myImage.getAttribute('src');
  if(mySrc === 'images/firefox-icon.png'){
    myImage.setAttribute ('src','images/https://cdn.pixabay.com/photo/2018/05/08/21/29/spotify-3384019_960_720.png');
  } else{
    myImage.setAttribute ('src','imageshttps://cdn.pixabay.com/photo/2018/05/08/21/29/spotify-3384019_960_720.png');
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