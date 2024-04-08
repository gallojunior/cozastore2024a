// Dynamic Placeholder
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

  if (elem.value != "") {
    elem.parentElement.classList.add("is-filled");
  }
});

// var form = document.querySelector('form');
// if (form != null && form != undefined) {
//   form.onsubmit = (event) => {
//     //event.preventDefault();
//     let elements = document.querySelectorAll('input[type="text"]');
//     console.log(elements);
//     elements.forEach((elem, index, array) => {
//       elem.parentElement.classList.add("is-invalid");
//     });
//   };
// }
