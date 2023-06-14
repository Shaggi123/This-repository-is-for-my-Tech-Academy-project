// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
// script.js
window.addEventListener('load', function() {
  var box = document.querySelector('.box');
  box.style.opacity = 0; // Set initial opacity to 0

  // Animate fading effect
  var opacity = 0;
  var interval = setInterval(function() {
    if (opacity >= 1) {
      clearInterval(interval);
    }
    opacity += 0.01;
    box.style.opacity = opacity;
  }, 10);
});
