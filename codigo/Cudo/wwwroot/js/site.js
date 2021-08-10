// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
  var animationEnd = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
  var animationName1 = 'wobble'; //bounce, flash, pulse, rubberband, shake, swing, tada, wobble, jello

  $('.animation').on('mouseover', function () { // click, mousedown, mouseup, mouseover, mouseout, mousemove
    $('.animation').addClass('animated ' + animationName1).one(animationEnd, function () {
      $(this).removeClass('animated ' + animationName1);
    });
  });

});


$(function () {
  var animationEnd = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
  var animationName2 = 'flipOutY';

  $('.animation').on('click', function () {
    $('.animation').addClass('animated ' + animationName2).one(animationEnd, function () {
      $(this).removeClass('animated ' + animationName2);
      location.href = '/Inicio/main';
      $(this).addClass('hide'); // hide button after animation

    });
  });

});

