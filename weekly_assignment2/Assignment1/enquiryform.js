const form = document.getElementById("enquiryForm");
const errors = document.querySelectorAll(".errormsg");
const success = document.getElementById("success");

form.addEventListener("submit", function (e) {
  e.preventDefault();
  errors.forEach(err => err.textContent = "");
  success.textContent = "";

  let valid = true;

  const name = document.getElementById("name").value.trim();
  const email = document.getElementById("email").value.trim();
  const mobile = document.getElementById("mobile").value.trim();
  const requestType = document.getElementById("requestType").value;
  const policyType = document.getElementById("policyType").value;
  const message = document.getElementById("message").value.trim();
  const rating = document.querySelector('input[name="rating"]:checked');

  if (!name) { errors[0].textContent = "Name required"; valid = false; }
  if (!email) { errors[1].textContent = "Email required"; valid = false; }
  if (!/^\d{10}$/.test(mobile)) { errors[2].textContent = "Enter 10-digit mobile"; valid = false; }
  if (!requestType) { errors[3].textContent = "Select request type"; valid = false; }
  if (!policyType) { errors[4].textContent = "Select policy type"; valid = false; }
  if (message.length < 10) { errors[5].textContent = "Minimum 10 characters"; valid = false; }
  if (!rating) { errors[6].textContent = "Select rating"; valid = false; }

  if (valid) {
    success.textContent = "Thank you! Your enquiry has been successfully submitted.";
    form.reset();
  }
});
