﻿// Dynamic Placeholder
let elements = document.querySelectorAll('input[type="text"]');
elements.forEach((elem, index, array) => {
  let placeholder = elem.placeholder;
  if (placeholder != "") {
    elem.placeholder = "";
    elem.onfocus = () => {
      elem.placeholder = placeholder;
    };
    elem.onblur = () => {
      elem.placeholder = "";
    };
  }
});
